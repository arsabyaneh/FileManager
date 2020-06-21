namespace FileManager
{
    partial class SearchDialog
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
            this.SearchQuery = new System.Windows.Forms.TextBox();
            this.QueryLabel = new System.Windows.Forms.Label();
            this.DirectoryComboBox = new System.Windows.Forms.ComboBox();
            this.NameContentComboBox = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Button();
            this.ResultPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // SearchQuery
            // 
            this.SearchQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchQuery.Location = new System.Drawing.Point(46, 14);
            this.SearchQuery.Multiline = true;
            this.SearchQuery.Name = "SearchQuery";
            this.SearchQuery.Size = new System.Drawing.Size(222, 21);
            this.SearchQuery.TabIndex = 0;
            // 
            // QueryLabel
            // 
            this.QueryLabel.AutoSize = true;
            this.QueryLabel.Location = new System.Drawing.Point(7, 16);
            this.QueryLabel.Name = "QueryLabel";
            this.QueryLabel.Size = new System.Drawing.Size(38, 13);
            this.QueryLabel.TabIndex = 1;
            this.QueryLabel.Text = "Query:";
            // 
            // DirectoryComboBox
            // 
            this.DirectoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectoryComboBox.FormattingEnabled = true;
            this.DirectoryComboBox.Items.AddRange(new object[] {
            "Current Directory",
            "All Sub Directories",
            "This PC"});
            this.DirectoryComboBox.Location = new System.Drawing.Point(274, 14);
            this.DirectoryComboBox.Name = "DirectoryComboBox";
            this.DirectoryComboBox.Size = new System.Drawing.Size(120, 21);
            this.DirectoryComboBox.TabIndex = 2;
            // 
            // NameContentComboBox
            // 
            this.NameContentComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameContentComboBox.FormattingEnabled = true;
            this.NameContentComboBox.Items.AddRange(new object[] {
            "Name",
            "Content",
            "Name and Content"});
            this.NameContentComboBox.Location = new System.Drawing.Point(400, 14);
            this.NameContentComboBox.Name = "NameContentComboBox";
            this.NameContentComboBox.Size = new System.Drawing.Size(120, 21);
            this.NameContentComboBox.TabIndex = 3;
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Location = new System.Drawing.Point(533, 13);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 4;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // ResultPanel
            // 
            this.ResultPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultPanel.AutoScroll = true;
            this.ResultPanel.BackColor = System.Drawing.SystemColors.Window;
            this.ResultPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultPanel.Location = new System.Drawing.Point(10, 47);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(596, 342);
            this.ResultPanel.TabIndex = 6;
            this.ResultPanel.Resize += new System.EventHandler(this.ResultPanel_Resize);
            // 
            // SearchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 396);
            this.Controls.Add(this.ResultPanel);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.NameContentComboBox);
            this.Controls.Add(this.DirectoryComboBox);
            this.Controls.Add(this.QueryLabel);
            this.Controls.Add(this.SearchQuery);
            this.Name = "SearchDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchDialog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchQuery;
        private System.Windows.Forms.Label QueryLabel;
        private System.Windows.Forms.ComboBox DirectoryComboBox;
        private System.Windows.Forms.ComboBox NameContentComboBox;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.FlowLayoutPanel ResultPanel;
    }
}