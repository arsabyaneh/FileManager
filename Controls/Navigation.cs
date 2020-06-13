using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager.Controls
{
    public class Navigation : TreeView
    {
        private void Initialize()
        {
            ImageList ImageListTreeView = new ImageList();

            ImageListTreeView.Images.AddRange(new[] { Properties.Resources.Computer_16x,
                Properties.Resources.HardDrive_16x, Properties.Resources.CDDrive_16x,
                Properties.Resources.FolderClosed_16x, Properties.Resources.FolderOpened_16x });

            ImageListTreeView.Images.SetKeyName(0, "Computer");
            ImageListTreeView.Images.SetKeyName(1, "HardDrive");
            ImageListTreeView.Images.SetKeyName(2, "CDDrive");
            ImageListTreeView.Images.SetKeyName(3, "ClosedFolder");
            ImageListTreeView.Images.SetKeyName(4, "OpenedFolder");

            this.ImageList = ImageListTreeView;

            TreeNode RootNode = new TreeNode();
            RootNode.Name = "Computer";
            RootNode.Text = "My Computer";
            RootNode.ImageIndex = RootNode.SelectedImageIndex = this.ImageList.Images.IndexOfKey("Computer");
            RootNode.Tag = null;

            this.Nodes.Add(RootNode);
        }

        private void AddDirectories(string path, TreeNode parent)
        {
            string[] directories;

            try
            {
                if (path == null)
                    directories = Directory.GetLogicalDrives();
                else
                    directories = Directory.GetDirectories(path);

                parent.Nodes.Clear();

                foreach (string directory in directories)
                {
                    TreeNode node = new TreeNode()
                    {
                        Text = (path == null) ? directory : Path.GetFileName(directory),
                        Tag = directory
                    };

                    if (path == null)
                    {
                        node.ImageIndex = node.SelectedImageIndex =
                            (new DriveInfo(directory).DriveType == DriveType.CDRom) ?
                            this.ImageList.Images.IndexOfKey("CDDrive") : this.ImageList.Images.IndexOfKey("HardDrive");
                    }
                    else
                    {
                        node.ImageIndex = node.SelectedImageIndex = this.ImageList.Images.IndexOfKey("ClosedFolder");
                    }

                    parent.Nodes.Add(node);
                }
            }
            catch
            {

            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            // important
            if (this.DesignMode)
                return;

            Initialize();
            AddDirectories(null, this.Nodes[0]);
            this.Nodes[0].Expand();
        }

        protected override void OnAfterExpand(TreeViewEventArgs e)
        {
            if (e.Node.Level > 1)
                e.Node.ImageIndex = e.Node.SelectedImageIndex = this.ImageList.Images.IndexOfKey("OpenedFolder");

            foreach (TreeNode node in e.Node.Nodes)
            {
                AddDirectories((string)node.Tag, node);
            }

            base.OnAfterExpand(e);
        }

        protected override void OnAfterCollapse(TreeViewEventArgs e)
        {
            if (e.Node.Level > 1)
                e.Node.ImageIndex = e.Node.SelectedImageIndex = this.ImageList.Images.IndexOfKey("ClosedFolder");

            base.OnAfterCollapse(e);
        }
    }
}
