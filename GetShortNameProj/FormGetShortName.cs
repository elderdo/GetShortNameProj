using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Diagnostics;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApplication1
{
    public partial class frmGetShortname : Form
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetShortPathName(
            [MarshalAs(UnmanagedType.LPTStr)]
        string path,
            [MarshalAs(UnmanagedType.LPTStr)]
        StringBuilder shortPath,
            int shortPathLength
            );

        public frmGetShortname()
        {
            InitializeComponent();
        }

        private void buttonGetLongName_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                textBoxLongName.Text = openFileDialog1.FileName;
                StringBuilder shortPath = new StringBuilder(255);
                GetShortPathName(textBoxLongName.Text, shortPath, shortPath.Capacity);
                textBoxShortName.Text = shortPath.ToString();
            }
        }

        private void buttonGetLongPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select the path that you want to use";
            folderBrowserDialog1.ShowNewFolderButton = false;
            folderBrowserDialog1.ShowDialog();
            textBoxLongPathName.Text = folderBrowserDialog1.SelectedPath;
            StringBuilder shortPath = new StringBuilder(255);
            GetShortPathName(textBoxLongPathName.Text, shortPath, shortPath.Capacity);
            textBoxShortName.Text = shortPath.ToString();
        }

        private void buttonSaveToCopyBuf_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxShortName.Text);
        }

        private void textBoxLongPathName_TextChanged(object sender, EventArgs e)
        {
            StringBuilder shortPath = new StringBuilder(255);
            GetShortPathName(textBoxLongPathName.Text, shortPath, shortPath.Capacity);
            textBoxShortName.Text = shortPath.ToString();

        }

        private void frmGetShortname_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                for(int i = 1;i < args.Length; i++)
                {
                    if (File.Exists(args[i]))
                    {
                        textBoxLongName.Text = args[i];
                    }
                    else if (Directory.Exists(args[i]))
                    {
                        textBoxLongPathName.Text = args[i];
                    }
                    else
                    {
                        MessageBox.Show(args[i] + " is not a valid file or directory.  Abort?", "Error");
                    }
                }
            }
        }

        private void textBoxLongName_TextChanged(object sender, EventArgs e)
        {
            StringBuilder shortName = new StringBuilder(255);
            GetShortPathName(textBoxLongName.Text, shortName, shortName.Capacity);
            textBoxShortName.Text = shortName.ToString();
        }
    }
}
