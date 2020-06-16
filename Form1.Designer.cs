namespace FileManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewLargeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewList = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewSmallIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewTiles = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.CurrentDirectoryLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentDirectory = new System.Windows.Forms.ToolStripStatusLabel();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.NavigationPanel = new FileManager.Controls.Navigation();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.EditMenuItem,
            this.ViewMenuItem,
            this.SearchMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "&File";
            // 
            // ViewMenuItem
            // 
            this.ViewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewDetails,
            this.ViewLargeIcons,
            this.ViewList,
            this.ViewSmallIcons,
            this.ViewTiles});
            this.ViewMenuItem.Name = "ViewMenuItem";
            this.ViewMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ViewMenuItem.Text = "&View";
            // 
            // ViewDetails
            // 
            this.ViewDetails.Checked = true;
            this.ViewDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ViewDetails.Name = "ViewDetails";
            this.ViewDetails.Size = new System.Drawing.Size(134, 22);
            this.ViewDetails.Text = "Details";
            // 
            // ViewLargeIcons
            // 
            this.ViewLargeIcons.Name = "ViewLargeIcons";
            this.ViewLargeIcons.Size = new System.Drawing.Size(134, 22);
            this.ViewLargeIcons.Text = "Large icons";
            // 
            // ViewList
            // 
            this.ViewList.Name = "ViewList";
            this.ViewList.Size = new System.Drawing.Size(134, 22);
            this.ViewList.Text = "List";
            // 
            // ViewSmallIcons
            // 
            this.ViewSmallIcons.Name = "ViewSmallIcons";
            this.ViewSmallIcons.Size = new System.Drawing.Size(134, 22);
            this.ViewSmallIcons.Text = "Small icons";
            // 
            // ViewTiles
            // 
            this.ViewTiles.Name = "ViewTiles";
            this.ViewTiles.Size = new System.Drawing.Size(134, 22);
            this.ViewTiles.Text = "Tiles";
            // 
            // SearchMenuItem
            // 
            this.SearchMenuItem.Name = "SearchMenuItem";
            this.SearchMenuItem.Size = new System.Drawing.Size(54, 20);
            this.SearchMenuItem.Text = "&Search";
            this.SearchMenuItem.Click += new System.EventHandler(this.SearchMenuItem_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentDirectoryLabel,
            this.CurrentDirectory});
            this.StatusStrip.Location = new System.Drawing.Point(0, 428);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(800, 22);
            this.StatusStrip.TabIndex = 1;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // CurrentDirectoryLabel
            // 
            this.CurrentDirectoryLabel.AutoSize = false;
            this.CurrentDirectoryLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CurrentDirectoryLabel.Name = "CurrentDirectoryLabel";
            this.CurrentDirectoryLabel.Size = new System.Drawing.Size(101, 17);
            this.CurrentDirectoryLabel.Text = "Current Directory:";
            // 
            // CurrentDirectory
            // 
            this.CurrentDirectory.AutoSize = false;
            this.CurrentDirectory.Name = "CurrentDirectory";
            this.CurrentDirectory.Size = new System.Drawing.Size(680, 17);
            this.CurrentDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SplitContainer
            // 
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 24);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.NavigationPanel);
            this.SplitContainer.Size = new System.Drawing.Size(800, 404);
            this.SplitContainer.SplitterDistance = 197;
            this.SplitContainer.TabIndex = 2;
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(197, 404);
            this.NavigationPanel.TabIndex = 0;
            this.NavigationPanel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.NavigationPanel_AfterSelect);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditMenuItem.Text = "&Edit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SplitContainer);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "File Manager";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.SplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchMenuItem;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel CurrentDirectoryLabel;
        private System.Windows.Forms.ToolStripStatusLabel CurrentDirectory;
        private System.Windows.Forms.ToolStripMenuItem ViewMenuItem;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.ToolStripMenuItem ViewDetails;
        private System.Windows.Forms.ToolStripMenuItem ViewLargeIcons;
        private System.Windows.Forms.ToolStripMenuItem ViewList;
        private System.Windows.Forms.ToolStripMenuItem ViewSmallIcons;
        private System.Windows.Forms.ToolStripMenuItem ViewTiles;
        private Controls.Navigation NavigationPanel;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
    }
}

