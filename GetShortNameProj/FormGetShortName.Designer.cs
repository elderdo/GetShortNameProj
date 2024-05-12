namespace WindowsFormsApplication1
{
    partial class frmGetShortname
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLongName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxShortName = new System.Windows.Forms.TextBox();
            this.buttonGetLongName = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonGetLongPath = new System.Windows.Forms.Button();
            this.textBoxLongPathName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonSaveToCopyBuf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Long File Name:";
            // 
            // textBoxLongName
            // 
            this.textBoxLongName.Location = new System.Drawing.Point(165, 80);
            this.textBoxLongName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLongName.Name = "textBoxLongName";
            this.textBoxLongName.Size = new System.Drawing.Size(725, 26);
            this.textBoxLongName.TabIndex = 1;
            this.textBoxLongName.TextChanged += new System.EventHandler(this.textBoxLongName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Short Name:";
            // 
            // textBoxShortName
            // 
            this.textBoxShortName.Location = new System.Drawing.Point(165, 150);
            this.textBoxShortName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxShortName.Name = "textBoxShortName";
            this.textBoxShortName.Size = new System.Drawing.Size(725, 26);
            this.textBoxShortName.TabIndex = 3;
            // 
            // buttonGetLongName
            // 
            this.buttonGetLongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetLongName.Location = new System.Drawing.Point(919, 78);
            this.buttonGetLongName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGetLongName.Name = "buttonGetLongName";
            this.buttonGetLongName.Size = new System.Drawing.Size(159, 34);
            this.buttonGetLongName.TabIndex = 4;
            this.buttonGetLongName.Text = "Select File ...";
            this.buttonGetLongName.UseVisualStyleBackColor = true;
            this.buttonGetLongName.Click += new System.EventHandler(this.buttonGetLongName_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonGetLongPath
            // 
            this.buttonGetLongPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetLongPath.Location = new System.Drawing.Point(919, 25);
            this.buttonGetLongPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGetLongPath.Name = "buttonGetLongPath";
            this.buttonGetLongPath.Size = new System.Drawing.Size(159, 34);
            this.buttonGetLongPath.TabIndex = 7;
            this.buttonGetLongPath.Text = "Select Path ...";
            this.buttonGetLongPath.UseVisualStyleBackColor = true;
            this.buttonGetLongPath.Click += new System.EventHandler(this.buttonGetLongPath_Click);
            // 
            // textBoxLongPathName
            // 
            this.textBoxLongPathName.Location = new System.Drawing.Point(165, 28);
            this.textBoxLongPathName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLongPathName.Name = "textBoxLongPathName";
            this.textBoxLongPathName.Size = new System.Drawing.Size(725, 26);
            this.textBoxLongPathName.TabIndex = 6;
            this.textBoxLongPathName.TextChanged += new System.EventHandler(this.textBoxLongPathName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Long Path Name:";
            // 
            // buttonSaveToCopyBuf
            // 
            this.buttonSaveToCopyBuf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveToCopyBuf.Location = new System.Drawing.Point(919, 134);
            this.buttonSaveToCopyBuf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSaveToCopyBuf.Name = "buttonSaveToCopyBuf";
            this.buttonSaveToCopyBuf.Size = new System.Drawing.Size(159, 60);
            this.buttonSaveToCopyBuf.TabIndex = 8;
            this.buttonSaveToCopyBuf.Text = "Save to Clipboard";
            this.buttonSaveToCopyBuf.UseVisualStyleBackColor = true;
            this.buttonSaveToCopyBuf.Click += new System.EventHandler(this.buttonSaveToCopyBuf_Click);
            // 
            // frmGetShortname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 225);
            this.Controls.Add(this.buttonSaveToCopyBuf);
            this.Controls.Add(this.buttonGetLongPath);
            this.Controls.Add(this.textBoxLongPathName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonGetLongName);
            this.Controls.Add(this.textBoxShortName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLongName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGetShortname";
            this.Text = "Get Short Name";
            this.Load += new System.EventHandler(this.frmGetShortname_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLongName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxShortName;
        private System.Windows.Forms.Button buttonGetLongName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonGetLongPath;
        private System.Windows.Forms.TextBox textBoxLongPathName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonSaveToCopyBuf;
    }
}

