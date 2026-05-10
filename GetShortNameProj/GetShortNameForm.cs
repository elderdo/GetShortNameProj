using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GetShortNameProj
{
    public partial class GetShortNameForm : Form
    {
        bool _isUpdating = false;

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetShortPathName(
            [MarshalAs(UnmanagedType.LPTStr)]
        string path,
            [MarshalAs(UnmanagedType.LPTStr)]
        StringBuilder shortPath,
            int shortPathLength
            );

        public GetShortNameForm()
        {
            InitializeComponent();
        }
        public GetShortNameForm(string[] args)
        {
            InitializeComponent();

            string path;

            // Check if a file was dropped on the icon
            if (args.Length > 0)
            {
                // The first argument (index 0) is usually the file path
                path = args[0];
                ProcessPath(path);
            }

        }

        private void ProcessPath(string path)
        {
            _isUpdating = true;
            if (File.Exists(path))
            {
                TextBoxLongFileName.Text = path;
                TextBoxShortName.Text = ShortName(path);

                TextBoxDirectoryLongPathname.Text = string.Empty;
            }
            else if (Directory.Exists(path))
            {
                // It's already a directory; use it as is
                TextBoxDirectoryLongPathname.Text = path;
                TextBoxShortName.Text = ShortName(path);
                TextBoxLongFileName.Text = string.Empty;
            }
            else
            {
                // Path does not exist or is invalid
                MessageBox.Show("File or directory does not exist: " + path);
            }
            _isUpdating = false;
        }

        private string ShortName(string path)
        {
            StringBuilder shortPath = new StringBuilder(255);
            GetShortPathName(path, shortPath, shortPath.Capacity);
            return shortPath.ToString();
        }
        private void ButtonGetLongFileName_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                ProcessPath(openFileDialog1.FileName);
            }
        }

        private void ButtonGetLongPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select the path that you want to use";
            folderBrowserDialog1.ShowNewFolderButton = false;
            folderBrowserDialog1.ShowDialog();
            ProcessPath(folderBrowserDialog1.SelectedPath);
        }

        private void ButtonSaveToCopyBuf_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TextBoxShortName.Text);
        }

        private void TextBoxDirectoryLongPathname_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating) { return; }
            TextBoxShortName.Text = ShortName(TextBoxDirectoryLongPathname.Text);

        }

        private void GetShortNameForm_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                for (int i = 1; i < args.Length; i++)
                {
                    if (File.Exists(args[i]))
                    {
                        TextBoxLongFileName.Text = args[i];
                    }
                    else if (Directory.Exists(args[i]))
                    {
                        TextBoxDirectoryLongPathname.Text = args[i];
                    }
                    else
                    {
                        MessageBox.Show(args[i] + " is not a valid file or directory.  Abort?", "Error");
                    }
                }
            }
        }

        private void TextBoxLongName_TextChanged(object sender, EventArgs e)
        {
            if (_isUpdating) { return; }
            TextBoxShortName.Text = ShortName(TextBoxLongFileName.Text);
        }

        private void GetShortNameForm_DragEnter(object sender, DragEventArgs e)
        {
            // Tell Windows that this form accepts the dragged item as a copy operation.
            // This does not copy the file immediately; it only signals that dropping is allowed
            // and shows the correct cursor feedback to the user. Without setting Effect here,
            // Windows may treat the drop as not allowed, and the file drop may not work correctly.
            e.Effect = DragDropEffects.Copy;
        }

        private void GetShortNameForm_DragDrop(object sender, DragEventArgs e)
        {
            // Get the array of dropped items
            string[] items = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (items != null && items.Length > 0)
            {
                string path = items[0]; // Process the first item dropped
                ProcessPath(path);
            }
        }
    }
}
