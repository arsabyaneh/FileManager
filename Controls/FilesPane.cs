using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer.Controls
{
    public class FilesPane : ListView
    {
        public Size SmallIconSize { get; set; }
        public Size TileIconSize { get; set; }
        public Size LargeIconSize { get; set; }

        private List<FileType> FileTypes;
        private FileType Document;
        private FileType Folder;

        public void Initialize()
        {
            SmallIconSize = new Size(16, 16);
            TileIconSize  = new Size(32, 32);
            LargeIconSize = new Size(128, 128);

            this.View = View.Details;
            this.Dock = DockStyle.Fill;
            this.LargeImageList = new ImageList();
            this.SmallImageList = new ImageList();
            this.LargeImageList.ImageSize = TileIconSize;
            this.SmallImageList.ImageSize = SmallIconSize;
            this.LargeImageList.ColorDepth = ColorDepth.Depth32Bit;
            this.Columns.Add("Name", 150, HorizontalAlignment.Left);
            this.Columns.Add("Date Modified", 150, HorizontalAlignment.Left);
            this.Columns.Add("Type", 100, HorizontalAlignment.Left);

            InitializeFileTypes();
        }

        public void InitializeFileTypes()
        {
            FileType Picture = new FileType()
            {
                Name = "Picture",
                Description = " File",
                Extensions = new[] { "jpg", "jpeg", "bmp", "png", "gif", "tiff" },
                SearchPattern = new[] { "*.jpg", "*.jpeg", "*.bmp", "*.png", "*.gif", "*.tiff" },
                Image = Properties.Resources.Picture
            };

            FileType Pdf = new FileType()
            {
                Name = "Pdf",
                Description = " Document",
                Extensions = new[] { "pdf" },
                SearchPattern = new[] { "*.pdf" },
                Image = Properties.Resources.Pdf
            };

            FileType Word = new FileType()
            {
                Name = "Word",
                Description = " Document",
                Extensions = new[] { "docx" },
                SearchPattern = new[] { "*.docx" },
                Image = Properties.Resources.Word
            };

            FileType Excel = new FileType()
            {
                Name = "Excel",
                Description = " Document",
                Extensions = new[] { "xlsx" },
                SearchPattern = new[] { "*.xlsx" },
                Image = Properties.Resources.Excel
            };

            FileType PowerPoint = new FileType()
            {
                Name = "PowerPoint",
                Description = " Presentation",
                Extensions = new[] { "pptx" },
                SearchPattern = new[] { "*.pptx" },
                Image = Properties.Resources.Powerpoint
            };

            FileType Audio = new FileType()
            {
                Name = "Audio",
                Description = " File",
                Extensions = new[] { "m4a", "mp3", "wav" },
                SearchPattern = new[] { "*.m4a", "*.mp3", "*.wav" },
                Image = Properties.Resources.Audio
            };

            FileType Video = new FileType()
            {
                Name = "Video",
                Description = " File",
                Extensions = new[] { "mp4", "3gp", "wmv", "flv", "mkv" },
                SearchPattern = new[] { "*.mp4", "*.3gp", "*.wmv", "*.flv", "*.mkv" },
                Image = Properties.Resources.Video
            };

            FileType Text = new FileType()
            {
                Name = "Text",
                Description = " Document",
                Extensions = new[] { "txt" },
                SearchPattern = new[] { "*.txt" },
                Image = Properties.Resources.Doc
            };

            FileType Archive = new FileType()
            {
                Name = "Archive",
                Description = " Archive",
                Extensions = new[] { "rar", "zip", "7z", "gzip" },
                SearchPattern = new[] { "*.rar", "*.zip", "*.7z", "*.gzip" },
                Image = Properties.Resources.Archive
            };

            FileTypes = new List<FileType> { Picture, Pdf, Word, Excel, PowerPoint, Audio, Video, Text, Archive };

            Document = new FileType()
            {
                Name = "Document",
                Description = " Document",
                Extensions = new[] { "" },
                SearchPattern = new[] { "*" },
                Image = Properties.Resources.Doc
            };

            Folder = new FileType()
            {
                Name = "Folder",
                Description = "File Folder",
                Extensions = new[] { "" },
                SearchPattern = new[] { "" },
                Image = Properties.Resources.Folder
            };
        }

        public void ShowFiles(string path)
        {
            List<string> files = new List<string>();
            FileType fileType;

            files.AddRange(Directory.GetFiles(path));

            this.BeginUpdate();

            foreach (string file in files)
            {
                try
                {
                    fileType = DetectFileType(Path.GetExtension(file).Substring(1).ToLower());

                    this.SmallImageList.Images.Add(fileType.Image);

                    if (fileType.Name == "Picture")
                        this.LargeImageList.Images.Add(Image.FromFile(file));
                    else
                        this.LargeImageList.Images.Add(fileType.Image);

                    ListViewItem listViewItem = new ListViewItem(
                        new string[] { Path.GetFileNameWithoutExtension(file),
                        File.GetLastWriteTime(file).ToString(),
                        Path.GetExtension(file).Substring(1).ToUpper() + fileType.Description },
                        this.SmallImageList.Images.Count - 1);
                    listViewItem.Tag = file;
                    this.Items.Add(listViewItem);
                }
                catch
                {
                    if (this.SmallImageList.Images.Count != this.LargeImageList.Images.Count)
                        this.SmallImageList.Images.RemoveAt(this.SmallImageList.Images.Count - 1);
                }
            }

            this.EndUpdate();
        }

        public void ShowDirectories(string path)
        {
            List<string> directories = new List<string>();

            directories.AddRange(Directory.GetDirectories(path));

            this.BeginUpdate();

            foreach (string directory in directories)
            {
                this.SmallImageList.Images.Add(Folder.Image);
                this.LargeImageList.Images.Add(Folder.Image);

                ListViewItem listViewItem = new ListViewItem(
                    new string[] { Path.GetFileName(directory),
                        File.GetLastWriteTime(directory).ToString(),
                        Folder.Description },
                    this.SmallImageList.Images.Count - 1);
                listViewItem.Tag = directory;
                this.Items.Add(listViewItem);
            }

            this.EndUpdate();
        }

        public void UpdateIconImages()
        {
            FileType fileType;

            this.BeginUpdate();

            this.LargeImageList.Images.Clear();
            foreach (ListViewItem item in this.Items)
            {
                if (item.SubItems[2].Text == "File Folder")
                    this.LargeImageList.Images.Add(Folder.Image);
                else
                {
                    fileType = DetectFileType(Path.GetExtension(((string)item.Tag)).Substring(1).ToLower());

                    if (fileType.Name == "Picture")
                        this.LargeImageList.Images.Add(Image.FromFile((string)item.Tag));
                    else
                        this.LargeImageList.Images.Add(fileType.Image);
                }
            }

            this.EndUpdate();
        }

        public FileType DetectFileType(string searchExtension)
        {
            foreach (FileType type in FileTypes)
            {
                foreach (string extension in type.Extensions)
                {
                    if (searchExtension == extension)
                        return type;
                }
            }

            return Document;
        }
    }
}
