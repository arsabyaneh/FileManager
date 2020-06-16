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
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchQuery
            // 
            this.SearchQuery.Location = new System.Drawing.Point(67, 22);
            this.SearchQuery.Name = "SearchQuery";
            this.SearchQuery.Size = new System.Drawing.Size(201, 20);
            this.SearchQuery.TabIndex = 0;
            // 
            // QueryLabel
            // 
            this.QueryLabel.AutoSize = true;
            this.QueryLabel.Location = new System.Drawing.Point(17, 25);
            this.QueryLabel.Name = "QueryLabel";
            this.QueryLabel.Size = new System.Drawing.Size(38, 13);
            this.QueryLabel.TabIndex = 1;
            this.QueryLabel.Text = "Query:";
            // 
            // DirectoryComboBox
            // 
            this.DirectoryComboBox.FormattingEnabled = true;
            this.DirectoryComboBox.Items.AddRange(new object[] {
            "Current Directory",
            "All Sub Directories",
            "This PC"});
            this.DirectoryComboBox.Location = new System.Drawing.Point(20, 58);
            this.DirectoryComboBox.Name = "DirectoryComboBox";
            this.DirectoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.DirectoryComboBox.TabIndex = 2;
            // 
            // NameContentComboBox
            // 
            this.NameContentComboBox.FormattingEnabled = true;
            this.NameContentComboBox.Items.AddRange(new object[] {
            "Files Name",
            "Files Content",
            "Both"});
            this.NameContentComboBox.Location = new System.Drawing.Point(147, 58);
            this.NameContentComboBox.Name = "NameContentComboBox";
            this.NameContentComboBox.Size = new System.Drawing.Size(121, 21);
            this.NameContentComboBox.TabIndex = 3;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(290, 20);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 4;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(290, 58);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SearchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 106);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.NameContentComboBox);
            this.Controls.Add(this.DirectoryComboBox);
            this.Controls.Add(this.QueryLabel);
            this.Controls.Add(this.SearchQuery);
            this.Name = "SearchDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchQuery;
        private System.Windows.Forms.Label QueryLabel;
        private System.Windows.Forms.ComboBox DirectoryComboBox;
        private System.Windows.Forms.ComboBox NameContentComboBox;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Cancel;
    }
}