using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class SearchDialog : Form
    {
        public string CurrentDirectory { get; set; }
        private List<Result> Results { get; set; }

        private class Result
        {
            public bool ContentSearched { get; set; }
            public string FilePath { get; set; }
            public string FoundText { get; set; }
        }

        public SearchDialog()
        {
            InitializeComponent();

            this.DirectoryComboBox.SelectedItem   = this.DirectoryComboBox.Items[0];
            this.NameContentComboBox.SelectedItem = this.NameContentComboBox.Items[0];
            this.Results = new List<Result>();
        }

        public void SearchFiles(string path, SearchOption depth, string query)
        {
            bool searchFileName = this.NameContentComboBox.SelectedIndex == 0 || this.NameContentComboBox.SelectedIndex == 2;
            bool searchContent  = this.NameContentComboBox.SelectedIndex == 1 || this.NameContentComboBox.SelectedIndex == 2;

            foreach (string file in Directory.GetFiles(path, "*", depth))
            {
                if (searchFileName)
                {
                    if (Path.GetFileNameWithoutExtension(file).Contains(query))
                    {
                        Results.Add(
                            new Result()
                            {
                                ContentSearched = false,
                                FilePath = file,
                                FoundText = Path.GetFileNameWithoutExtension(file)
                            });
                    }
                }

                if (searchContent)
                {
                    switch (Path.GetExtension(file))
                    {
                        case ".docx":
                            string result = SearchWordDocument(file, query);
                            if (result != string.Empty)
                            {
                                Results.Add(
                                    new Result()
                                    {
                                        ContentSearched = true,
                                        FilePath = file,
                                        FoundText = result
                                    });
                            }
                            break;
                    }
                }
            }
        }

        public void SearchDirectories(string path, SearchOption depth, string query)
        {
            if (this.NameContentComboBox.SelectedIndex == 1)
                return;

            foreach (string directory in Directory.GetDirectories(path, "*", depth))
            {
                if (Path.GetFileName(directory).Contains(query))
                {
                    Results.Add(
                        new Result(){
                            ContentSearched = false,
                            FilePath = directory,
                            FoundText = Path.GetFileName(directory)
                        });
                }
            }
        }

        public string SearchWordDocument(string path, string query)
        {
            string result = string.Empty;

            // Open Word Document ReadOnly

            using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(path, false))
            {
                Document document = wordDocument.MainDocumentPart.Document;

                foreach (Text text in document.Descendants<Text>())
                {
                    if (text.Text.Contains(query))
                    {
                        result = text.Text;
                        break;
                    }
                }
            }

            return result;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchOption searchOption = (this.DirectoryComboBox.SelectedIndex == 0) ? SearchOption.TopDirectoryOnly : SearchOption.AllDirectories;
            
            if (this.DirectoryComboBox.SelectedIndex != 2)
            {
                SearchFiles(CurrentDirectory, searchOption, this.SearchQuery.Text);
                SearchDirectories(CurrentDirectory, searchOption, this.SearchQuery.Text);
            }
        }
    }
}
