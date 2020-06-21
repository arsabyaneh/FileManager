namespace FileManager.Controls
{
    partial class SearchResult
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FoundText = new System.Windows.Forms.Label();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Path = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // FoundText
            // 
            this.FoundText.BackColor = System.Drawing.SystemColors.Window;
            this.FoundText.Location = new System.Drawing.Point(190, 16);
            this.FoundText.Name = "FoundText";
            this.FoundText.Size = new System.Drawing.Size(370, 15);
            this.FoundText.TabIndex = 11;
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(7, 8);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(50, 50);
            this.Picture.TabIndex = 8;
            this.Picture.TabStop = false;
            // 
            // Path
            // 
            this.Path.BackColor = System.Drawing.SystemColors.Window;
            this.Path.Location = new System.Drawing.Point(63, 43);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(497, 15);
            this.Path.TabIndex = 10;
            // 
            // FileName
            // 
            this.FileName.BackColor = System.Drawing.SystemColors.Window;
            this.FileName.Location = new System.Drawing.Point(63, 16);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(100, 15);
            this.FileName.TabIndex = 9;
            // 
            // SearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FoundText);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.FileName);
            this.Name = "SearchResult";
            this.Size = new System.Drawing.Size(566, 68);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FoundText;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Label Path;
        private System.Windows.Forms.Label FileName;
    }
}
