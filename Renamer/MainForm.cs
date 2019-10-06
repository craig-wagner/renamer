using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Environment;

namespace Renamer
{
    public partial class MainForm : Form
    {
        private FolderBrowserDialog _folderBrowser = new FolderBrowserDialog()
        {
            RootFolder = SpecialFolder.MyComputer,
            ShowNewFolderButton = false
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (_folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = _folderBrowser.SelectedPath;
                PopulateGrid(txtFolder.Text);
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            var renamedFiles = (IEnumerable<RenamedFile>)dataGridView.DataSource;

            foreach (var renamedFile in renamedFiles.Where(rf => rf.Rename))
            { File.Move(Path.Combine(txtFolder.Text, renamedFile.OldName), Path.Combine(txtFolder.Text, renamedFile.NewName)); }

            PopulateGrid(txtFolder.Text);

            Cursor = Cursors.Default;

            MessageBox.Show("Files have been renamed.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PopulateGrid(string path)
        {
            var renamedFiles = GenerateNewFileNames(path);
            dataGridView.DataSource = renamedFiles;
        }

        private IEnumerable<RenamedFile> GenerateNewFileNames(string path)
        {
            var renamedFiles = new List<RenamedFile>();

            var filesInFolder = Directory.GetFiles(path);

            foreach (var fileInFolder in filesInFolder)
            {
                var oldName = Path.GetFileName(fileInFolder);
                var newName = Guid.NewGuid().ToString() + Path.GetExtension(fileInFolder);
                renamedFiles.Add(new RenamedFile(oldName, newName));
            }

            return renamedFiles;
        }

        private class RenamedFile
        {
            public bool Rename { get; set; }
            public string OldName { get; private set; }
            public string NewName { get; private set; }

            public RenamedFile(string oldName, string newName)
            {
                Rename = true;
                OldName = oldName;
                NewName = newName;
            }
        }
    }
}
