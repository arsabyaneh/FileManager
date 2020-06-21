using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using FileManager.Controls;
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
            this.NameContentComboBox.SelectedItem = this.NameContentComboBox.Items[2];
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

        private void Search_Click(object sender, EventArgs e)
        {
            SearchOption searchOption = (this.DirectoryComboBox.SelectedIndex == 0) ? SearchOption.TopDirectoryOnly : SearchOption.AllDirectories;

            this.ResultPanel.Controls.Clear();
            Results.Clear();

            if (this.DirectoryComboBox.SelectedIndex != 2)
            {
                if (this.CurrentDirectory == null)
                    return;

                SearchFiles(CurrentDirectory, searchOption, this.SearchQuery.Text);
                SearchDirectories(CurrentDirectory, searchOption, this.SearchQuery.Text);

                ShowSearchResults();
            }
        }

        private void ShowSearchResults()
        {
            this.ResultPanel.Controls.Clear();

            foreach (Result result in Results)
            {
                SearchResult searchResult = new SearchResult();
                searchResult.Controls["FileName"].Text = Path.GetFileNameWithoutExtension(result.FilePath);
                searchResult.Controls["FoundText"].Text = result.FoundText;
                searchResult.Controls["Path"].Text = result.FilePath;
                (searchResult.Controls["Picture"] as PictureBox).Image = GetImage(result.FilePath);
                (searchResult.Controls["Picture"] as PictureBox).SizeMode = GetSizeMode((searchResult.Controls["Picture"] as PictureBox), (searchResult.Controls["Picture"] as PictureBox).Image);

                this.ResultPanel.Controls.Add(searchResult);
                this.ResultPanel.SetFlowBreak(ResultPanel.Controls[ResultPanel.Controls.Count - 1], true);

                // add separator line
                Label Line = new Label();
                Line.Text = string.Empty;
                Line.AutoSize = false;
                Line.Height = 3;
                Line.Width = this.ResultPanel.Size.Width - 10;
                Line.BackColor = ColorTranslator.FromHtml("#E6E6E6");

                this.ResultPanel.Controls.Add(Line);
                this.ResultPanel.SetFlowBreak(ResultPanel.Controls[ResultPanel.Controls.Count - 1], true);
            }
        }

        private Image GetImage(string path)
        {
            return Directory.Exists(path) ? Properties.Resources.Folder : Properties.Resources.Doc;
        }

        private PictureBoxSizeMode GetSizeMode(PictureBox picture, Image image)
        {
            if (image.Width > picture.Width || image.Height > picture.Height)
                return PictureBoxSizeMode.Zoom;
            else
                return PictureBoxSizeMode.CenterImage;
        }

        private void SearchDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ResultPanel.Controls.Clear();
            Results.Clear();
        }

        private void ResultPanel_Resize(object sender, EventArgs e)
        {
            ShowSearchResults();
        }
    }
}
