using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace FileExplorer
{
    /// <summary>
    /// Provides the code for the interaction with the UI
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// The info timer to show an info message in the status strip
        /// </summary>
        private readonly Timer _infoTimer = new Timer(TimeSpan.FromSeconds(10).TotalMilliseconds);

        /// <summary>
        /// Creates a new instance of the <see cref="FormMain"/>
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

            // Resets the info message
            _infoTimer.Elapsed += (sender, e) =>
            {
                _infoTimer.Stop();
                statusStripStatus.Text = "";
            };
        }

        /// <summary>
        /// Shows a info
        /// </summary>
        /// <param name="message">The message</param>
        private void ShowInfo(string message)
        {
            statusStripStatus.Text = message;
            _infoTimer.Start();
        }

        /// <summary>
        /// Loads the content of the desired directory and creates the tree
        /// </summary>
        private async void LoadData()
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxPath.Text))
                    return;

                treeView.Nodes.Clear();

                var rootDir = new DirectoryInfo(textBoxPath.Text);

                if (!rootDir.Exists)
                {
                    MessageBox.Show("The given path doesn't exist. Please enter another path and try again.",
                        "Wrong directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create the root node
                var rootNode = new TreeNode(rootDir.Name)
                {
                    Tag = rootDir
                };

                // Disable the file group box to prevent errors
                groupBoxFiles.Enabled = false;
                Cursor = Cursors.WaitCursor;
                statusStripStatus.Text = "Loading...";

                await Task.Run(() => CreateTreeView(rootNode, rootDir));

                groupBoxFiles.Enabled = true;
                Cursor = Cursors.Default;
                statusStripStatus.Text = "";

                rootNode.Expand();
                treeView.Nodes.Add(rootNode);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error has occured. Message: \r\n\r\n{ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Creates the elements of the tree view and adds them to the given <paramref name="rootNode"/>
        /// </summary>
        /// <param name="rootNode">The root node</param>
        /// <param name="rootDir">The root directory</param>
        private void CreateTreeView(TreeNode rootNode, DirectoryInfo rootDir)
        {
            var subDirectories = GetDirectories(rootDir);

            if (subDirectories != null && subDirectories.Length > 0)
            {
                foreach (var subDirectory in subDirectories)
                {
                    var dirNode = new TreeNode(subDirectory.Name)
                    {
                        Tag = subDirectory,
                        ImageIndex = 0,
                        SelectedImageIndex = 0
                    };

                    CreateTreeView(dirNode, subDirectory);

                    rootNode.Nodes.Add(dirNode);
                }
            }

            var files = GetFiles(rootDir);

            if (files == null) 
                return;

            foreach (var file in files)
            {
                var fileNode = new TreeNode(file.Name)
                {
                    Tag = file,
                    ImageIndex = 2,
                    SelectedImageIndex = 2
                };

                rootNode.Nodes.Add(fileNode);
            }
        }

        /// <summary>
        /// Gets all sub directories of the given directory.
        /// This method is needed, because it's possible to get an exception when you try to gather information about a special directory
        /// </summary>
        /// <param name="dir">The directory</param>
        /// <returns>The list with the sub directories</returns>
        private static DirectoryInfo[] GetDirectories(DirectoryInfo dir)
        {
            if (dir == null)
                return null;

            try
            {
                return dir.GetDirectories();
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Gets all files of the given directory.
        /// This method is needed, because it's possible to get an exception when you try to gather information about a special directory
        /// </summary>
        /// <param name="dir">The directory</param>
        /// <returns>The list with the files</returns>
        private static FileInfo[] GetFiles(DirectoryInfo dir)
        {
            if (dir == null)
                return null;

            try
            {
                return dir.GetFiles();
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Clears the preview
        /// </summary>
        private void ClearPreview()
        {
            // Reset the text of every data label
            foreach (var label in tableLayoutPanel.Controls.OfType<Label>().Where(w => w.Name.EndsWith("Data")))
            {
                label.Text = "/";
            }

            // Reset the checkbox
            checkBoxReadOnly.Checked = false;

            pictureBoxPreview.Visible = false;
            textBoxPreview.Visible = false;
        }

        /// <summary>
        /// Shows the details of the selected entry (file or dir)
        /// </summary>
        /// <param name="entry">The selected entry (file or dir)</param>
        private void ShowMainDetails(FileSystemInfo entry)
        {
            labelNameData.Text = entry.Name;
            labelPathData.Text = entry.FullName;
            labelCreationDateData.Text = $"{entry.CreationTime:G} / {entry.CreationTimeUtc:G} UTC";
            labelLastAccessData.Text = $"{entry.LastAccessTime:G} / {entry.LastAccessTimeUtc:G} UTC";
            labelLastWriteData.Text = $"{entry.LastWriteTime:G} / {entry.LastWriteTimeUtc:G} UTC";
            labelAttributesData.Text = entry.Attributes.ToString();
        }

        /// <summary>
        /// Shows the details of a file
        /// </summary>
        /// <param name="file">The selected file</param>
        private void ShowDetails(FileInfo file)
        {
            bool IsImage()
            {
                var imgExtensions = new[] {".jpg", ".jpeg", ".png", ".bmp", ".gif", ".img"};

                return imgExtensions.Any(a => a.Equals(file.Extension, StringComparison.OrdinalIgnoreCase));
            }

            bool IsText()
            {
                var textExtensions = new[]
                {
                    ".txt", ".json", ".md", ".log", ".csv", ".xml", ".cs", ".sql", ".config", ".sln", ".csproj",
                    ".xaml", ".ini", ".ps1"
                };

                return textExtensions.Any(a => a.Equals(file.Extension, StringComparison.OrdinalIgnoreCase));
            }

            string LoadContent()
            {
                try
                {
                    return File.ReadAllText(file.FullName);
                }
                catch
                {
                    return "Can't load file content.";
                }
            }

            labelExtensionData.Text = file.Extension;
            labelSizeData.Text = ConvertFileSize(file.Length);
            checkBoxReadOnly.Checked = file.IsReadOnly;

            if (IsImage())
            {
                pictureBoxPreview.Visible = true;
                pictureBoxPreview.Image = Image.FromFile(file.FullName);
            }
            else if (IsText())
            {
                textBoxPreview.Visible = true;
                textBoxPreview.Text = LoadContent();
            }
            else
            {
                textBoxPreview.Visible = true;
                textBoxPreview.Text = "No preview available. File extension not known.";
            }
        }

        /// <summary>
        /// Converts the size of a file into a read able format
        /// </summary>
        /// <param name="size">The size of a file</param>
        /// <returns>The read able format</returns>
        private string ConvertFileSize(long size)
        {
            var kbSize = (double) size / 1024;
            switch (size)
            {
                case var _ when size < 1024:
                    return $"{size:N0} Bytes";
                case var _ when size >= 1024 && size < Math.Pow(1024, 2):
                    return $"{size / 1024d:N2} KB ({size:N0} Bytes)";
                case var _ when size >= Math.Pow(1024, 2) && size < Math.Pow(1024, 3):
                    return $"{size / Math.Pow(1024, 2):N2} MB ({kbSize:N2} KB)";
                case var _ when size >= Math.Pow(1024, 3):
                    return $"{size / Math.Pow(1024, 3):N2} GB ({kbSize:N2} KB)";
                default:
                    return size.ToString();
            }
        }

        /// <summary>
        /// Gets the current details as string
        /// </summary>
        /// <returns>The string with the details</returns>
        private string GetDetails()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Details");
            sb.AppendLine($"Name.........: {labelNameData.Text}");
            sb.AppendLine($"Path.........: {labelPathData.Text}");
            sb.AppendLine($"Extension....: {labelExtensionData.Text}");
            sb.AppendLine($"Read only....: {checkBoxReadOnly.Checked}");
            sb.AppendLine($"Creation date: {labelCreationDateData.Text}");
            sb.AppendLine($"Last access..: {labelLastAccessData.Text}");
            sb.AppendLine($"Last write...: {labelLastWriteData.Text}");
            sb.AppendLine($"Size.........: {labelSizeData.Text}");
            sb.AppendLine($"Attributes...: {labelAttributesData.Text}");

            return sb.ToString();
        }

        /// <summary>
        /// Copies the shown details to the clipboard
        /// </summary>
        private void CopyDetailsToClipboard()
        {
            Clipboard.SetText(GetDetails(), TextDataFormat.Text);
            ShowInfo("Details copied...");
        }

        /// <summary>
        /// Exports the details to the desired file
        /// </summary>
        private void ExportDetails()
        {
            var dialog = new SaveFileDialog
            {
                Title = "Select the desired destination",
                DefaultExt = ".txt",
                Filter = "Text file (*.txt)|*.txt"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            File.WriteAllText(dialog.FileName, GetDetails());
        }

        /// <summary>
        /// Occurs when the user hits the browse button
        /// </summary>
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog
            {
                Description = "Selected the desired directory",
                ShowNewFolderButton = false
            };

            // The user hits cancel, so skip the rest of this method
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            textBoxPath.Text = dialog.SelectedPath;

            LoadData();
        }

        /// <summary>
        /// Occurs when the user hits a key while the path text box has the focus
        /// </summary>
        private void textBoxPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoadData();
        }

        /// <summary>
        /// Occurs when the user selects a node from the tree
        /// </summary>
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null)
                return;

            ClearPreview();

            switch (e.Node.Tag)
            {
                case FileInfo file:
                    ShowMainDetails(file);
                    ShowDetails(file);
                    break;
                case DirectoryInfo dir:
                    ShowMainDetails(dir);
                    break;
            }
        }

        /// <summary>
        /// Occurs when the window was loaded
        /// </summary>
        private void FormMain_Load(object sender, EventArgs e)
        {
            ClearPreview();
        }

        /// <summary>
        /// Occurs when a node was expand
        /// </summary>
        private void treeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 1;
            e.Node.SelectedImageIndex = 1;
        }

        /// <summary>
        /// Occurs when a node was collapsed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 0;
            e.Node.SelectedImageIndex = 0;
        }

        /// <summary>
        /// Occurs when the user hits the expand all button
        /// </summary>
        private void buttonExpand_Click(object sender, EventArgs e)
        {
            treeView.ExpandAll();
        }

        /// <summary>
        /// Occurs when the user hits the collapse all button
        /// </summary>
        private void buttonCollapse_Click(object sender, EventArgs e)
        {
            treeView.CollapseAll();
        }

        /// <summary>
        /// Occurs when the user hits the copy button
        /// </summary>
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            CopyDetailsToClipboard();
        }

        /// <summary>
        /// Occurs when the user hits the export button
        /// </summary>
        private void buttonExport_Click(object sender, EventArgs e)
        {
            ExportDetails();
        }
    }
}
