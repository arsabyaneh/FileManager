using FileExplorer.Controls;
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
        private FilesPane FilesListView;

        public Form1()
        {
            InitializeComponent();

            FilesListView = new FilesPane();
            FilesListView.Initialize();
            SplitContainer.Panel2.Controls.Add(FilesListView);

            InitializeViewOptions();
        }

        private void FileExplorer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            FilesListView.Items.Clear();
            FilesListView.LargeImageList.Images.Clear();
            FilesListView.SmallImageList.Images.Clear();

            string path = (string)e.Node.Tag;
            try
            {
                FilesListView.ShowFiles(path);
                FilesListView.ShowDirectories(path);
            }
            catch
            {

            }

            this.CurrentDirectory.Text = path;
        }

        private void InitializeViewOptions()
        {
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

            switch ((View)ViewOption.Tag)
            {
                case View.Details:
                    FilesListView.View = View.Details;
                    break;

                case View.LargeIcon:
                    FilesListView.View = View.LargeIcon;
                    if (FilesListView.LargeImageList.ImageSize != FilesListView.LargeIconSize)
                    {
                        FilesListView.LargeImageList.ImageSize = FilesListView.LargeIconSize;

                        // change in Imagesize removes elements of LargeImageList.Images, thus we need the following
                        FilesListView.UpdateIconImages();
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
                    if (FilesListView.LargeImageList.ImageSize != FilesListView.TileIconSize)
                    {
                        FilesListView.LargeImageList.ImageSize = FilesListView.TileIconSize;

                        // change in Imagesize removes elements of LargeImageList.Images, thus we need the following
                        FilesListView.UpdateIconImages();
                    }
                    break;
            }
        }
    }
}
