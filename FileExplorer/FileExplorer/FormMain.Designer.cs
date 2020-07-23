namespace FileExplorer
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageListTree = new System.Windows.Forms.ImageList(this.components);
            this.panelFilesTop = new System.Windows.Forms.Panel();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.groupBoxPreview = new System.Windows.Forms.GroupBox();
            this.textBoxPreview = new System.Windows.Forms.TextBox();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelAttributesData = new System.Windows.Forms.Label();
            this.labelAttributes = new System.Windows.Forms.Label();
            this.labelSizeData = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelLastWriteData = new System.Windows.Forms.Label();
            this.labelLastWrite = new System.Windows.Forms.Label();
            this.labelLastAccessData = new System.Windows.Forms.Label();
            this.labelLastAccess = new System.Windows.Forms.Label();
            this.labelCreationDateData = new System.Windows.Forms.Label();
            this.labelCreationDate = new System.Windows.Forms.Label();
            this.labelReadOnly = new System.Windows.Forms.Label();
            this.labelExtensionData = new System.Windows.Forms.Label();
            this.labelExtension = new System.Windows.Forms.Label();
            this.labelPathData = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelNameData = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.checkBoxReadOnly = new System.Windows.Forms.CheckBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanelFiles = new System.Windows.Forms.TableLayoutPanel();
            this.buttonExpand = new System.Windows.Forms.Button();
            this.buttonCollapse = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.buttonCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBoxFiles.SuspendLayout();
            this.panelFilesTop.SuspendLayout();
            this.groupBoxPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.groupBoxDetails.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanelFiles.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.groupBoxFiles);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.groupBoxPreview);
            this.splitContainer.Panel2.Controls.Add(this.groupBoxDetails);
            this.splitContainer.Size = new System.Drawing.Size(800, 428);
            this.splitContainer.SplitterDistance = 266;
            this.splitContainer.TabIndex = 0;
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.Controls.Add(this.treeView);
            this.groupBoxFiles.Controls.Add(this.tableLayoutPanelFiles);
            this.groupBoxFiles.Controls.Add(this.panelFilesTop);
            this.groupBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFiles.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Size = new System.Drawing.Size(266, 428);
            this.groupBoxFiles.TabIndex = 0;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Explorer";
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageListTree;
            this.treeView.Location = new System.Drawing.Point(3, 46);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(260, 351);
            this.treeView.TabIndex = 1;
            this.treeView.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterCollapse);
            this.treeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterExpand);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // imageListTree
            // 
            this.imageListTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTree.ImageStream")));
            this.imageListTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTree.Images.SetKeyName(0, "Folder.png");
            this.imageListTree.Images.SetKeyName(1, "FolderOpen.png");
            this.imageListTree.Images.SetKeyName(2, "Document.png");
            // 
            // panelFilesTop
            // 
            this.panelFilesTop.Controls.Add(this.buttonBrowse);
            this.panelFilesTop.Controls.Add(this.labelDirectory);
            this.panelFilesTop.Controls.Add(this.textBoxPath);
            this.panelFilesTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilesTop.Location = new System.Drawing.Point(3, 16);
            this.panelFilesTop.Name = "panelFilesTop";
            this.panelFilesTop.Size = new System.Drawing.Size(260, 30);
            this.panelFilesTop.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(226, 1);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(31, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelDirectory
            // 
            this.labelDirectory.AutoSize = true;
            this.labelDirectory.Location = new System.Drawing.Point(9, 6);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(52, 13);
            this.labelDirectory.TabIndex = 1;
            this.labelDirectory.Text = "Directory:";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Location = new System.Drawing.Point(67, 3);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(153, 20);
            this.textBoxPath.TabIndex = 0;
            this.textBoxPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPath_KeyDown);
            // 
            // groupBoxPreview
            // 
            this.groupBoxPreview.Controls.Add(this.textBoxPreview);
            this.groupBoxPreview.Controls.Add(this.pictureBoxPreview);
            this.groupBoxPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPreview.Location = new System.Drawing.Point(0, 252);
            this.groupBoxPreview.Name = "groupBoxPreview";
            this.groupBoxPreview.Size = new System.Drawing.Size(530, 176);
            this.groupBoxPreview.TabIndex = 1;
            this.groupBoxPreview.TabStop = false;
            this.groupBoxPreview.Text = "Preview";
            // 
            // textBoxPreview
            // 
            this.textBoxPreview.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPreview.Location = new System.Drawing.Point(3, 16);
            this.textBoxPreview.Multiline = true;
            this.textBoxPreview.Name = "textBoxPreview";
            this.textBoxPreview.ReadOnly = true;
            this.textBoxPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPreview.Size = new System.Drawing.Size(524, 157);
            this.textBoxPreview.TabIndex = 1;
            this.textBoxPreview.Visible = false;
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPreview.Location = new System.Drawing.Point(3, 16);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(524, 157);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 0;
            this.pictureBoxPreview.TabStop = false;
            this.pictureBoxPreview.Visible = false;
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.tableLayoutPanel);
            this.groupBoxDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDetails.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(530, 252);
            this.groupBoxDetails.TabIndex = 0;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.labelAttributesData, 1, 8);
            this.tableLayoutPanel.Controls.Add(this.labelAttributes, 0, 8);
            this.tableLayoutPanel.Controls.Add(this.labelSizeData, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.labelSize, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.labelLastWriteData, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.labelLastWrite, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.labelLastAccessData, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.labelLastAccess, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.labelCreationDateData, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.labelCreationDate, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.labelReadOnly, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.labelExtensionData, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelExtension, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelPathData, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelPath, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelNameData, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.checkBoxReadOnly, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.panelDetails, 1, 9);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 10;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(524, 233);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelAttributesData
            // 
            this.labelAttributesData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAttributesData.Location = new System.Drawing.Point(109, 184);
            this.labelAttributesData.Name = "labelAttributesData";
            this.labelAttributesData.Size = new System.Drawing.Size(412, 23);
            this.labelAttributesData.TabIndex = 17;
            this.labelAttributesData.Text = "label18";
            this.labelAttributesData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAttributes
            // 
            this.labelAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAttributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttributes.Location = new System.Drawing.Point(3, 184);
            this.labelAttributes.Name = "labelAttributes";
            this.labelAttributes.Size = new System.Drawing.Size(100, 23);
            this.labelAttributes.TabIndex = 16;
            this.labelAttributes.Text = "Attributes:";
            this.labelAttributes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSizeData
            // 
            this.labelSizeData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSizeData.Location = new System.Drawing.Point(109, 161);
            this.labelSizeData.Name = "labelSizeData";
            this.labelSizeData.Size = new System.Drawing.Size(412, 23);
            this.labelSizeData.TabIndex = 15;
            this.labelSizeData.Text = "label16";
            this.labelSizeData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSize
            // 
            this.labelSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(3, 161);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(100, 23);
            this.labelSize.TabIndex = 14;
            this.labelSize.Text = "Size:";
            this.labelSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLastWriteData
            // 
            this.labelLastWriteData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLastWriteData.Location = new System.Drawing.Point(109, 138);
            this.labelLastWriteData.Name = "labelLastWriteData";
            this.labelLastWriteData.Size = new System.Drawing.Size(412, 23);
            this.labelLastWriteData.TabIndex = 13;
            this.labelLastWriteData.Text = "label14";
            this.labelLastWriteData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLastWrite
            // 
            this.labelLastWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLastWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastWrite.Location = new System.Drawing.Point(3, 138);
            this.labelLastWrite.Name = "labelLastWrite";
            this.labelLastWrite.Size = new System.Drawing.Size(100, 23);
            this.labelLastWrite.TabIndex = 12;
            this.labelLastWrite.Text = "Last write:";
            this.labelLastWrite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLastAccessData
            // 
            this.labelLastAccessData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLastAccessData.Location = new System.Drawing.Point(109, 115);
            this.labelLastAccessData.Name = "labelLastAccessData";
            this.labelLastAccessData.Size = new System.Drawing.Size(412, 23);
            this.labelLastAccessData.TabIndex = 11;
            this.labelLastAccessData.Text = "label12";
            this.labelLastAccessData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLastAccess
            // 
            this.labelLastAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLastAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastAccess.Location = new System.Drawing.Point(3, 115);
            this.labelLastAccess.Name = "labelLastAccess";
            this.labelLastAccess.Size = new System.Drawing.Size(100, 23);
            this.labelLastAccess.TabIndex = 10;
            this.labelLastAccess.Text = "Last access:";
            this.labelLastAccess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCreationDateData
            // 
            this.labelCreationDateData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCreationDateData.Location = new System.Drawing.Point(109, 92);
            this.labelCreationDateData.Name = "labelCreationDateData";
            this.labelCreationDateData.Size = new System.Drawing.Size(412, 23);
            this.labelCreationDateData.TabIndex = 9;
            this.labelCreationDateData.Text = "label10";
            this.labelCreationDateData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCreationDate
            // 
            this.labelCreationDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreationDate.Location = new System.Drawing.Point(3, 92);
            this.labelCreationDate.Name = "labelCreationDate";
            this.labelCreationDate.Size = new System.Drawing.Size(100, 23);
            this.labelCreationDate.TabIndex = 8;
            this.labelCreationDate.Text = "Creation date:";
            this.labelCreationDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelReadOnly
            // 
            this.labelReadOnly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReadOnly.Location = new System.Drawing.Point(3, 69);
            this.labelReadOnly.Name = "labelReadOnly";
            this.labelReadOnly.Size = new System.Drawing.Size(100, 23);
            this.labelReadOnly.TabIndex = 6;
            this.labelReadOnly.Text = "Read only:";
            this.labelReadOnly.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelExtensionData
            // 
            this.labelExtensionData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelExtensionData.Location = new System.Drawing.Point(109, 46);
            this.labelExtensionData.Name = "labelExtensionData";
            this.labelExtensionData.Size = new System.Drawing.Size(412, 23);
            this.labelExtensionData.TabIndex = 5;
            this.labelExtensionData.Text = "label6";
            this.labelExtensionData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelExtension
            // 
            this.labelExtension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtension.Location = new System.Drawing.Point(3, 46);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(100, 23);
            this.labelExtension.TabIndex = 4;
            this.labelExtension.Text = "Extension:";
            this.labelExtension.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPathData
            // 
            this.labelPathData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPathData.Location = new System.Drawing.Point(109, 23);
            this.labelPathData.Name = "labelPathData";
            this.labelPathData.Size = new System.Drawing.Size(412, 23);
            this.labelPathData.TabIndex = 3;
            this.labelPathData.Text = "label4";
            this.labelPathData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPath
            // 
            this.labelPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPath.Location = new System.Drawing.Point(3, 23);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(100, 23);
            this.labelPath.TabIndex = 2;
            this.labelPath.Text = "Path:";
            this.labelPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNameData
            // 
            this.labelNameData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNameData.Location = new System.Drawing.Point(109, 0);
            this.labelNameData.Name = "labelNameData";
            this.labelNameData.Size = new System.Drawing.Size(412, 23);
            this.labelNameData.TabIndex = 1;
            this.labelNameData.Text = "label2";
            this.labelNameData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxReadOnly
            // 
            this.checkBoxReadOnly.AutoSize = true;
            this.checkBoxReadOnly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxReadOnly.Enabled = false;
            this.checkBoxReadOnly.Location = new System.Drawing.Point(109, 72);
            this.checkBoxReadOnly.Name = "checkBoxReadOnly";
            this.checkBoxReadOnly.Size = new System.Drawing.Size(412, 17);
            this.checkBoxReadOnly.TabIndex = 18;
            this.checkBoxReadOnly.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusStripStatus
            // 
            this.statusStripStatus.Name = "statusStripStatus";
            this.statusStripStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // tableLayoutPanelFiles
            // 
            this.tableLayoutPanelFiles.ColumnCount = 2;
            this.tableLayoutPanelFiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFiles.Controls.Add(this.buttonCollapse, 1, 0);
            this.tableLayoutPanelFiles.Controls.Add(this.buttonExpand, 0, 0);
            this.tableLayoutPanelFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelFiles.Location = new System.Drawing.Point(3, 397);
            this.tableLayoutPanelFiles.Name = "tableLayoutPanelFiles";
            this.tableLayoutPanelFiles.RowCount = 2;
            this.tableLayoutPanelFiles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFiles.Size = new System.Drawing.Size(260, 28);
            this.tableLayoutPanelFiles.TabIndex = 2;
            // 
            // buttonExpand
            // 
            this.buttonExpand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExpand.Location = new System.Drawing.Point(3, 3);
            this.buttonExpand.Name = "buttonExpand";
            this.buttonExpand.Size = new System.Drawing.Size(124, 23);
            this.buttonExpand.TabIndex = 0;
            this.buttonExpand.Text = "Expand all";
            this.buttonExpand.UseVisualStyleBackColor = true;
            this.buttonExpand.Click += new System.EventHandler(this.buttonExpand_Click);
            // 
            // buttonCollapse
            // 
            this.buttonCollapse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCollapse.Location = new System.Drawing.Point(133, 3);
            this.buttonCollapse.Name = "buttonCollapse";
            this.buttonCollapse.Size = new System.Drawing.Size(124, 23);
            this.buttonCollapse.TabIndex = 1;
            this.buttonCollapse.Text = "Collapse all";
            this.buttonCollapse.UseVisualStyleBackColor = true;
            this.buttonCollapse.Click += new System.EventHandler(this.buttonCollapse_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.Location = new System.Drawing.Point(340, 3);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 19;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.buttonCopy);
            this.panelDetails.Controls.Add(this.buttonExport);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(106, 207);
            this.panelDetails.Margin = new System.Windows.Forms.Padding(0);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(418, 33);
            this.panelDetails.TabIndex = 20;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopy.Location = new System.Drawing.Point(259, 3);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 20;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStrip);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileExplorer";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBoxFiles.ResumeLayout(false);
            this.panelFilesTop.ResumeLayout(false);
            this.panelFilesTop.PerformLayout();
            this.groupBoxPreview.ResumeLayout(false);
            this.groupBoxPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.groupBoxDetails.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanelFiles.ResumeLayout(false);
            this.panelDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox groupBoxFiles;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Panel panelFilesTop;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelDirectory;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.GroupBox groupBoxPreview;
        private System.Windows.Forms.TextBox textBoxPreview;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelAttributesData;
        private System.Windows.Forms.Label labelAttributes;
        private System.Windows.Forms.Label labelSizeData;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelLastWriteData;
        private System.Windows.Forms.Label labelLastWrite;
        private System.Windows.Forms.Label labelLastAccessData;
        private System.Windows.Forms.Label labelLastAccess;
        private System.Windows.Forms.Label labelCreationDateData;
        private System.Windows.Forms.Label labelCreationDate;
        private System.Windows.Forms.Label labelReadOnly;
        private System.Windows.Forms.Label labelExtensionData;
        private System.Windows.Forms.Label labelExtension;
        private System.Windows.Forms.Label labelPathData;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelNameData;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.CheckBox checkBoxReadOnly;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripStatus;
        private System.Windows.Forms.ImageList imageListTree;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFiles;
        private System.Windows.Forms.Button buttonCollapse;
        private System.Windows.Forms.Button buttonExpand;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonExport;
    }
}

