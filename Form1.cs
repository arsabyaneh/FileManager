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

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        private Size LargeIconSize;
        private Size TileIconSize;
        private Size SmallIconSize;

        public Form1()
        {
            InitializeComponent();

            InitializeFilesListView();
        }

        private void InitializeFilesListView()
        {
            SmallIconSize = new Size(16, 16);
            TileIconSize  = new Size(32, 32);
            LargeIconSize = new Size(128, 128);

            FilesListView.View = View.Details;
            FilesListView.LargeImageList = new ImageList();
            FilesListView.SmallImageList = new ImageList();
            FilesListView.LargeImageList.ImageSize = TileIconSize;
            FilesListView.SmallImageList.ImageSize = SmallIconSize;
            FilesListView.Columns.Add("Name", 150, HorizontalAlignment.Left);
            FilesListView.Columns.Add("Date Modified", 150, HorizontalAlignment.Left);
            FilesListView.Columns.Add("Type", 100, HorizontalAlignment.Left);

            ViewDetails.Tag = View.Details;
            ViewLargeIcons.Tag = View.LargeIcon;
            ViewList.Tag = View.List;
            ViewSmallIcons.Tag = View.SmallIcon;
            ViewTiles.Tag = View.Tile;

            EventHandler viewOptionClickHandler = new EventHandler(ViewOptions_Click);
            ViewDetails.Click += viewOptionClickHandler;
            ViewLargeIcons.Click += viewOptionClickHandler;
            ViewList.Click += viewOptionClickHandler;
            ViewSmallIcons.Click += viewOptionClickHandler;
            ViewTiles.Click += viewOptionClickHandler;
        }

        private void FileExplorer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            FilesListView.Items.Clear();
            FilesListView.LargeImageList.Images.Clear();
            FilesListView.SmallImageList.Images.Clear();

            string path = (string)e.Node.Tag;
            try
            {
                ShowFiles(path);
            }
            catch
            {

            }

            this.CurrentDirectory.Text = path;
        }

        private void ShowFiles(string path)
        {
            string[] extensions = new[] { "*.jpg", "*.jpeg", "*.bmp", "*.png", "*.gif", "*.tiff" };
            List<string> files = new List<string>();
            int imageIndex = -1;

            foreach (string extension in extensions)
            {
                files.AddRange(Directory.GetFiles(path, extension));
            }

            foreach (string file in files)
            {
                FilesListView.SmallImageList.Images.Add(Image.FromFile(file));
                FilesListView.LargeImageList.Images.Add(Image.FromFile(file));

                imageIndex++;

                ListViewItem listViewItem = new ListViewItem(
                    new string[] { Path.GetFileNameWithoutExtension(file), File.GetLastWriteTime(file).ToString(), Path.GetExtension(file).Substring(1) },
                    imageIndex);
                listViewItem.Tag = file;
                FilesListView.Items.Add(listViewItem);
            }
        }

        private void ViewOptions_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem ViewOption = (sender as ToolStripMenuItem);
            if (ViewOption.Checked == true)
                return;

            foreach (ToolStripMenuItem item in this.ViewMenuItem.DropDownItems)
            {
                if (item.Checked == true)
                {
                    item.Checked = false;
                }
            }

            ViewOption.Checked = true;

            this.SuspendLayout();

            switch ((View)ViewOption.Tag)
            {
                case View.Details:
                    FilesListView.View = View.Details;
                    break;

                case View.LargeIcon:
                    FilesListView.View = View.LargeIcon;
                    if (FilesListView.LargeImageList.ImageSize != LargeIconSize)
                    {
                        FilesListView.LargeImageList.ImageSize = LargeIconSize;

                        // change in Imagesize removes elements of LargeImageList.Images, thus we need the following
                        UpdateIconImages();
                    }
                    break;

                case View.List:
                    FilesListView.View = View.List;
                    break;

                case View.SmallIcon:
                    FilesListView.View = View.SmallIcon;
                    break;

                case View.Tile:
                    FilesListView.View = View.Tile;
                    if (FilesListView.LargeImageList.ImageSize != TileIconSize)
                    {
                        FilesListView.LargeImageList.ImageSize = TileIconSize;

                        // change in Imagesize removes elements of LargeImageList.Images, thus we need the following
                        UpdateIconImages();
                    }
                    break;
            }

            this.ResumeLayout();
        }

        private void UpdateIconImages()
        {
            FilesListView.LargeImageList.Images.Clear();
            foreach (ListViewItem item in FilesListView.Items)
            {
                FilesListView.LargeImageList.Images.Add(Image.FromFile((string)item.Tag));
            }
        }
    }
}
