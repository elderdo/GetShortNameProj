namespace GetShortNameProj
{
    partial class GetShortNameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetShortNameForm));
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxLongFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxShortName = new System.Windows.Forms.TextBox();
            this.ButtonGetLongFileName = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ButtonGetDirectoryLongPathname = new System.Windows.Forms.Button();
            this.TextBoxDirectoryLongPathname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ButtonSaveToCopyBuf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Long File Name:";
            // 
            // TextBoxLongFileName
            // 
            this.TextBoxLongFileName.Location = new System.Drawing.Point(229, 80);
            this.TextBoxLongFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxLongFileName.Name = "TextBoxLongFileName";
            this.TextBoxLongFileName.Size = new System.Drawing.Size(725, 26);
            this.TextBoxLongFileName.TabIndex = 1;
            this.TextBoxLongFileName.TextChanged += new System.EventHandler(this.TextBoxLongName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Short Name:";
            // 
            // TextBoxShortName
            // 
            this.TextBoxShortName.Location = new System.Drawing.Point(229, 150);
            this.TextBoxShortName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxShortName.Name = "TextBoxShortName";
            this.TextBoxShortName.ReadOnly = true;
            this.TextBoxShortName.Size = new System.Drawing.Size(725, 26);
            this.TextBoxShortName.TabIndex = 3;
            // 
            // ButtonGetLongFileName
            // 
            this.ButtonGetLongFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGetLongFileName.Location = new System.Drawing.Point(983, 78);
            this.ButtonGetLongFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonGetLongFileName.Name = "ButtonGetLongFileName";
            this.ButtonGetLongFileName.Size = new System.Drawing.Size(159, 34);
            this.ButtonGetLongFileName.TabIndex = 4;
            this.ButtonGetLongFileName.Text = "Select File ...";
            this.ButtonGetLongFileName.UseVisualStyleBackColor = true;
            this.ButtonGetLongFileName.Click += new System.EventHandler(this.ButtonGetLongFileName_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ButtonGetDirectoryLongPathname
            // 
            this.ButtonGetDirectoryLongPathname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGetDirectoryLongPathname.Location = new System.Drawing.Point(983, 25);
            this.ButtonGetDirectoryLongPathname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonGetDirectoryLongPathname.Name = "ButtonGetDirectoryLongPathname";
            this.ButtonGetDirectoryLongPathname.Size = new System.Drawing.Size(159, 34);
            this.ButtonGetDirectoryLongPathname.TabIndex = 7;
            this.ButtonGetDirectoryLongPathname.Text = "Select Path ...";
            this.ButtonGetDirectoryLongPathname.UseVisualStyleBackColor = true;
            this.ButtonGetDirectoryLongPathname.Click += new System.EventHandler(this.ButtonGetLongPath_Click);
            // 
            // TextBoxDirectoryLongPathname
            // 
            this.TextBoxDirectoryLongPathname.Location = new System.Drawing.Point(229, 28);
            this.TextBoxDirectoryLongPathname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxDirectoryLongPathname.Name = "TextBoxDirectoryLongPathname";
            this.TextBoxDirectoryLongPathname.Size = new System.Drawing.Size(725, 26);
            this.TextBoxDirectoryLongPathname.TabIndex = 6;
            this.TextBoxDirectoryLongPathname.TextChanged += new System.EventHandler(this.TextBoxDirectoryLongPathname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Long Path Directory Name:";
            // 
            // ButtonSaveToCopyBuf
            // 
            this.ButtonSaveToCopyBuf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSaveToCopyBuf.Location = new System.Drawing.Point(983, 134);
            this.ButtonSaveToCopyBuf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSaveToCopyBuf.Name = "ButtonSaveToCopyBuf";
            this.ButtonSaveToCopyBuf.Size = new System.Drawing.Size(159, 77);
            this.ButtonSaveToCopyBuf.TabIndex = 8;
            this.ButtonSaveToCopyBuf.Text = "Save to Clipboard";
            this.ButtonSaveToCopyBuf.UseVisualStyleBackColor = true;
            this.ButtonSaveToCopyBuf.Click += new System.EventHandler(this.ButtonSaveToCopyBuf_Click);
            // 
            // GetShortNameForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 225);
            this.Controls.Add(this.ButtonSaveToCopyBuf);
            this.Controls.Add(this.ButtonGetDirectoryLongPathname);
            this.Controls.Add(this.TextBoxDirectoryLongPathname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonGetLongFileName);
            this.Controls.Add(this.TextBoxShortName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxLongFileName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GetShortNameForm";
            this.Text = "Get Short Name";
            this.Load += new System.EventHandler(this.GetShortNameForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.GetShortNameForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.GetShortNameForm_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxLongFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxShortName;
        private System.Windows.Forms.Button ButtonGetLongFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ButtonGetDirectoryLongPathname;
        private System.Windows.Forms.TextBox TextBoxDirectoryLongPathname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button ButtonSaveToCopyBuf;
    }
}

