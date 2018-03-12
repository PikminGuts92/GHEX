public partial class MainWindow : global::System.Windows.Forms.Form
{
	void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MainWindow));
		this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
		this.tslVersion = new global::System.Windows.Forms.ToolStripStatusLabel();
		this.cmArkFileList = new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.cmiFileListNA = new global::System.Windows.Forms.ToolStripMenuItem();
		this.cmiFileListMakeWritable = new global::System.Windows.Forms.ToolStripMenuItem();
		this.cmiFileListReLink = new global::System.Windows.Forms.ToolStripMenuItem();
		this.cmiFileListReplace = new global::System.Windows.Forms.ToolStripMenuItem();
		this.cmiFileListImport = new global::System.Windows.Forms.ToolStripMenuItem();
		this.cmiFileListExportNoteCharts = new global::System.Windows.Forms.ToolStripMenuItem();
		this.cmiFileListShrinkArchive = new global::System.Windows.Forms.ToolStripMenuItem();
		this.cmiFileListRemove = new global::System.Windows.Forms.ToolStripMenuItem();
		this.cmiFileListExtract = new global::System.Windows.Forms.ToolStripMenuItem();
		this.cmiFileListSave = new global::System.Windows.Forms.ToolStripMenuItem();
		this.imageList_0 = new global::System.Windows.Forms.ImageList(this.icontainer_0);
		this.openFileDialog_0 = new global::System.Windows.Forms.OpenFileDialog();
		this.imageList_1 = new global::System.Windows.Forms.ImageList(this.icontainer_0);
		this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		this.toolStripContainer1 = new global::System.Windows.Forms.ToolStripContainer();
		this.splitContainer1 = new global::System.Windows.Forms.SplitContainer();
		this.propertyGrid1 = new global::System.Windows.Forms.PropertyGrid();
		this.arkFileList = new global::System.Windows.Forms.TreeView();
		this.tsLeft = new global::GClass134();
		this.tsbExplorer = new global::GClass135();
		this.tsbPropertyGrid = new global::GClass135();
		this.tsDocuments = new global::GControl1();
		this.tsiPreview = new global::GClass98();
		this.scPreview = new global::System.Windows.Forms.SplitContainer();
		this.lvPreviewProperties = new global::System.Windows.Forms.ListView();
		this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
		this.tsFile = new global::System.Windows.Forms.ToolStrip();
		this.newToolStripButton = new global::System.Windows.Forms.ToolStripButton();
		this.openToolStripButton = new global::System.Windows.Forms.ToolStripButton();
		this.saveToolStripButton = new global::System.Windows.Forms.ToolStripButton();
		this.tsNotesEditor = new global::System.Windows.Forms.ToolStrip();
		this.tsbEditNotes = new global::System.Windows.Forms.ToolStripButton();
		this.tsbInsertNotes = new global::System.Windows.Forms.ToolStripButton();
		this.tsbEditBeats = new global::System.Windows.Forms.ToolStripButton();
		this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
		this.tsmiFile = new global::System.Windows.Forms.ToolStripMenuItem();
		this.customSongsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.tsmiFileNewSong = new global::System.Windows.Forms.ToolStripMenuItem();
		this.openToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.tsmiFileOpenSong = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
		this.tsmiFileSave = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator8 = new global::System.Windows.Forms.ToolStripSeparator();
		this.locArkToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.tsmiFileLocateArk = new global::System.Windows.Forms.ToolStripMenuItem();
		this.tsmiFileCopyArchive = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
		this.tsmiFileExit = new global::System.Windows.Forms.ToolStripMenuItem();
		this.helpToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.tsmiHelpWebsite = new global::System.Windows.Forms.ToolStripMenuItem();
		this.tsmiHelpChanges = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
		this.tsmiHelpReportBug = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
		this.tsmiHelpAbout = new global::System.Windows.Forms.ToolStripMenuItem();
		this.tsmiEdit = new global::System.Windows.Forms.ToolStripMenuItem();
		this.tsmiEditUndo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.tsmiEditRedo = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator5 = new global::System.Windows.Forms.ToolStripSeparator();
		this.tsmiEditCut = new global::System.Windows.Forms.ToolStripMenuItem();
		this.tsmiEditCopy = new global::System.Windows.Forms.ToolStripMenuItem();
		this.tsmiEditPaste = new global::System.Windows.Forms.ToolStripMenuItem();
		this.tsmiEditDelete = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator6 = new global::System.Windows.Forms.ToolStripSeparator();
		this.tsmiEditSelectAll = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator7 = new global::System.Windows.Forms.ToolStripSeparator();
		this.statusStrip1.SuspendLayout();
		this.cmArkFileList.SuspendLayout();
		this.toolStripContainer1.ContentPanel.SuspendLayout();
		this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
		this.toolStripContainer1.SuspendLayout();
		this.splitContainer1.Panel1.SuspendLayout();
		this.splitContainer1.Panel2.SuspendLayout();
		this.splitContainer1.SuspendLayout();
		this.tsLeft.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.tsDocuments).BeginInit();
		this.tsDocuments.SuspendLayout();
		this.tsiPreview.SuspendLayout();
		this.scPreview.Panel2.SuspendLayout();
		this.scPreview.SuspendLayout();
		this.tsFile.SuspendLayout();
		this.tsNotesEditor.SuspendLayout();
		this.menuStrip1.SuspendLayout();
		base.SuspendLayout();
		this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.tslVersion
		});
		this.statusStrip1.Location = new global::System.Drawing.Point(0, 487);
		this.statusStrip1.Name = "statusStrip1";
		this.statusStrip1.ShowItemToolTips = true;
		this.statusStrip1.Size = new global::System.Drawing.Size(581, 22);
		this.statusStrip1.TabIndex = 0;
		this.statusStrip1.Text = "statusStrip1";
		this.tslVersion.ActiveLinkColor = global::System.Drawing.Color.Blue;
		this.tslVersion.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.tslVersion.DoubleClickEnabled = true;
		this.tslVersion.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tslVersion.Image");
		this.tslVersion.ImageScaling = global::System.Windows.Forms.ToolStripItemImageScaling.None;
		this.tslVersion.ImageTransparentColor = global::System.Drawing.Color.Black;
		this.tslVersion.LinkBehavior = global::System.Windows.Forms.LinkBehavior.HoverUnderline;
		this.tslVersion.LinkColor = global::System.Drawing.Color.Blue;
		this.tslVersion.Name = "tslVersion";
		this.tslVersion.Size = new global::System.Drawing.Size(13, 17);
		this.tslVersion.Text = "v";
		this.tslVersion.TextImageRelation = global::System.Windows.Forms.TextImageRelation.TextBeforeImage;
		this.tslVersion.VisitedLinkColor = global::System.Drawing.Color.Blue;
		this.tslVersion.DoubleClick += new global::System.EventHandler(this.tslVersion_DoubleClick);
		this.cmArkFileList.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.cmiFileListNA,
			this.cmiFileListMakeWritable,
			this.cmiFileListReLink,
			this.cmiFileListReplace,
			this.cmiFileListImport,
			this.cmiFileListExportNoteCharts,
			this.cmiFileListShrinkArchive,
			this.cmiFileListRemove,
			this.cmiFileListExtract,
			this.cmiFileListSave
		});
		this.cmArkFileList.Name = "cmArkFileList";
		this.cmArkFileList.Size = new global::System.Drawing.Size(168, 246);
		this.cmArkFileList.Opening += new global::System.ComponentModel.CancelEventHandler(this.cmArkFileList_Opening);
		this.cmiFileListNA.Enabled = false;
		this.cmiFileListNA.Name = "cmiFileListNA";
		this.cmiFileListNA.Size = new global::System.Drawing.Size(167, 22);
		this.cmiFileListNA.Text = "N/A";
		this.cmiFileListNA.Visible = false;
		this.cmiFileListMakeWritable.Name = "cmiFileListMakeWritable";
		this.cmiFileListMakeWritable.Size = new global::System.Drawing.Size(167, 22);
		this.cmiFileListMakeWritable.Text = "Make Writable";
		this.cmiFileListMakeWritable.Click += new global::System.EventHandler(this.cmiFileListMakeWritable_Click);
		this.cmiFileListReLink.Name = "cmiFileListReLink";
		this.cmiFileListReLink.Size = new global::System.Drawing.Size(167, 22);
		this.cmiFileListReLink.Text = "Re-link";
		this.cmiFileListReLink.Click += new global::System.EventHandler(this.cmiFileListReLink_Click);
		this.cmiFileListReplace.Name = "cmiFileListReplace";
		this.cmiFileListReplace.Size = new global::System.Drawing.Size(167, 22);
		this.cmiFileListReplace.Text = "Replace";
		this.cmiFileListReplace.Click += new global::System.EventHandler(this.cmiFileListReplace_Click);
		this.cmiFileListImport.Name = "cmiFileListImport";
		this.cmiFileListImport.Size = new global::System.Drawing.Size(167, 22);
		this.cmiFileListImport.Text = "Import";
		this.cmiFileListImport.Click += new global::System.EventHandler(this.cmiFileListImport_Click);
		this.cmiFileListExportNoteCharts.Name = "cmiFileListExportNoteCharts";
		this.cmiFileListExportNoteCharts.Size = new global::System.Drawing.Size(167, 22);
		this.cmiFileListExportNoteCharts.Text = "Export Note Charts";
		this.cmiFileListExportNoteCharts.Click += new global::System.EventHandler(this.cmiFileListExportNoteCharts_Click);
		this.cmiFileListShrinkArchive.Name = "cmiFileListShrinkArchive";
		this.cmiFileListShrinkArchive.Size = new global::System.Drawing.Size(167, 22);
		this.cmiFileListShrinkArchive.Text = "Shrink Archive";
		this.cmiFileListShrinkArchive.Click += new global::System.EventHandler(this.cmiFileListShrinkArchive_Click);
		this.cmiFileListRemove.Name = "cmiFileListRemove";
		this.cmiFileListRemove.Size = new global::System.Drawing.Size(167, 22);
		this.cmiFileListRemove.Text = "Remove";
		this.cmiFileListRemove.Click += new global::System.EventHandler(this.cmiFileListRemove_Click);
		this.cmiFileListExtract.Name = "cmiFileListExtract";
		this.cmiFileListExtract.Size = new global::System.Drawing.Size(167, 22);
		this.cmiFileListExtract.Text = "Extract";
		this.cmiFileListExtract.Click += new global::System.EventHandler(this.cmiFileListExtract_Click);
		this.cmiFileListSave.Name = "cmiFileListSave";
		this.cmiFileListSave.Size = new global::System.Drawing.Size(167, 22);
		this.cmiFileListSave.Text = "Save";
		this.cmiFileListSave.Click += new global::System.EventHandler(this.cmiFileListSave_Click);
		this.imageList_0.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("ilArkFileList.ImageStream");
		this.imageList_0.TransparentColor = global::System.Drawing.Color.FromArgb(200, 200, 200);
		this.imageList_0.Images.SetKeyName(0, "");
		this.imageList_0.Images.SetKeyName(1, "");
		this.imageList_0.Images.SetKeyName(2, "");
		this.imageList_0.Images.SetKeyName(3, "");
		this.imageList_0.Images.SetKeyName(4, "");
		this.imageList_0.Images.SetKeyName(5, "");
		this.imageList_0.Images.SetKeyName(6, "");
		this.imageList_0.Images.SetKeyName(7, "");
		this.imageList_0.Images.SetKeyName(8, "");
		this.imageList_0.Images.SetKeyName(9, "");
		this.imageList_0.Images.SetKeyName(10, "");
		this.imageList_0.Images.SetKeyName(11, "");
		this.imageList_0.Images.SetKeyName(12, "file_milo_1.bmp");
		this.imageList_0.Images.SetKeyName(13, "file_folder_song.bmp");
		this.openFileDialog_0.Filter = "GH Archive|main.hdr";
		this.openFileDialog_0.Title = "Locate Archive";
		this.imageList_1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("ilLogo.ImageStream");
		this.imageList_1.TransparentColor = global::System.Drawing.Color.Transparent;
		this.imageList_1.Images.SetKeyName(0, "logo.bmp");
		this.timer_0.Enabled = true;
		this.timer_0.Interval = 1000;
		this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
		this.toolStripContainer1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
		this.toolStripContainer1.ContentPanel.Size = new global::System.Drawing.Size(581, 463);
		this.toolStripContainer1.Location = new global::System.Drawing.Point(0, 24);
		this.toolStripContainer1.Name = "toolStripContainer1";
		this.toolStripContainer1.Size = new global::System.Drawing.Size(581, 463);
		this.toolStripContainer1.TabIndex = 4;
		this.toolStripContainer1.Text = "toolStripContainer1";
		this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tsNotesEditor);
		this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tsFile);
		this.splitContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.splitContainer1.FixedPanel = global::System.Windows.Forms.FixedPanel.Panel1;
		this.splitContainer1.Location = new global::System.Drawing.Point(0, 0);
		this.splitContainer1.Name = "splitContainer1";
		this.splitContainer1.Panel1.Controls.Add(this.propertyGrid1);
		this.splitContainer1.Panel1.Controls.Add(this.arkFileList);
		this.splitContainer1.Panel1.Controls.Add(this.tsLeft);
		this.splitContainer1.Panel2.Controls.Add(this.tsDocuments);
		this.splitContainer1.Size = new global::System.Drawing.Size(581, 463);
		this.splitContainer1.SplitterDistance = 225;
		this.splitContainer1.TabIndex = 4;
		this.propertyGrid1.Enabled = false;
		this.propertyGrid1.Location = new global::System.Drawing.Point(29, 212);
		this.propertyGrid1.Name = "propertyGrid1";
		this.propertyGrid1.Size = new global::System.Drawing.Size(169, 152);
		this.propertyGrid1.TabIndex = 2;
		this.propertyGrid1.Visible = false;
		this.propertyGrid1.PropertyValueChanged += new global::System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
		this.arkFileList.BackColor = global::System.Drawing.Color.White;
		this.arkFileList.ContextMenuStrip = this.cmArkFileList;
		this.arkFileList.Enabled = false;
		this.arkFileList.HideSelection = false;
		this.arkFileList.ImageIndex = 0;
		this.arkFileList.ImageList = this.imageList_0;
		this.arkFileList.Location = new global::System.Drawing.Point(3, 3);
		this.arkFileList.Name = "arkFileList";
		this.arkFileList.PathSeparator = "/";
		this.arkFileList.SelectedImageIndex = 0;
		this.arkFileList.ShowNodeToolTips = true;
		this.arkFileList.Size = new global::System.Drawing.Size(219, 177);
		this.arkFileList.TabIndex = 0;
		this.arkFileList.Visible = false;
		this.arkFileList.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.arkFileList_MouseClick);
		this.arkFileList.BeforeExpand += new global::System.Windows.Forms.TreeViewCancelEventHandler(this.arkFileList_BeforeExpand);
		this.arkFileList.AfterSelect += new global::System.Windows.Forms.TreeViewEventHandler(this.arkFileList_AfterSelect);
		this.arkFileList.BeforeSelect += new global::System.Windows.Forms.TreeViewCancelEventHandler(this.arkFileList_BeforeSelect);
		this.tsLeft.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.tsLeft.method_15(true);
		this.tsLeft.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
		this.tsLeft.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.tsbExplorer,
			this.tsbPropertyGrid
		});
		this.tsLeft.Location = new global::System.Drawing.Point(0, 438);
		this.tsLeft.Name = "tsLeft";
		this.tsLeft.method_9(global::System.Windows.Forms.ToolStripRenderMode.Custom);
		this.tsLeft.method_17(this.tsbExplorer);
		this.tsLeft.Size = new global::System.Drawing.Size(225, 25);
		this.tsLeft.TabIndex = 1;
		this.tsLeft.Text = "tabStrip1";
		this.tsLeft.method_13(false);
		this.tsLeft.method_18(new global::System.EventHandler<global::GEventArgs15>(this.method_26));
		this.tsbExplorer.method_12(true);
		this.tsbExplorer.method_6(global::System.Drawing.SystemColors.ControlText);
		this.tsbExplorer.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tsbExplorer.Image");
		this.tsbExplorer.ImageTransparentColor = global::System.Drawing.Color.White;
		this.tsbExplorer.method_14(true);
		this.tsbExplorer.method_2(new global::System.Windows.Forms.Padding(0));
		this.tsbExplorer.Name = "tsbExplorer";
		this.tsbExplorer.method_4(new global::System.Windows.Forms.Padding(0));
		this.tsbExplorer.method_10(new global::System.Drawing.Font("Tahoma", 8.25f));
		this.tsbExplorer.method_8(global::System.Drawing.SystemColors.ControlText);
		this.tsbExplorer.Size = new global::System.Drawing.Size(68, 25);
		this.tsbExplorer.Text = "Archives";
		this.tsbPropertyGrid.method_6(global::System.Drawing.SystemColors.ControlText);
		this.tsbPropertyGrid.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tsbPropertyGrid.Image");
		this.tsbPropertyGrid.ImageTransparentColor = global::System.Drawing.Color.White;
		this.tsbPropertyGrid.method_14(false);
		this.tsbPropertyGrid.method_2(new global::System.Windows.Forms.Padding(0));
		this.tsbPropertyGrid.Name = "tsbPropertyGrid";
		this.tsbPropertyGrid.method_4(new global::System.Windows.Forms.Padding(0));
		this.tsbPropertyGrid.method_10(new global::System.Drawing.Font("Tahoma", 8.25f));
		this.tsbPropertyGrid.method_8(global::System.Drawing.SystemColors.ControlText);
		this.tsbPropertyGrid.Size = new global::System.Drawing.Size(76, 25);
		this.tsbPropertyGrid.Text = "Properties";
		this.tsbPropertyGrid.Visible = false;
		this.tsDocuments.method_34(false);
		this.tsDocuments.method_32(false);
		this.tsDocuments.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.tsDocuments.Font = new global::System.Drawing.Font("Tahoma", 8.25f);
		this.tsDocuments.method_35().vmethod_7(new global::GClass98[]
		{
			this.tsiPreview
		});
		this.tsDocuments.Location = new global::System.Drawing.Point(0, 0);
		this.tsDocuments.Name = "tsDocuments";
		this.tsDocuments.Padding = new global::System.Windows.Forms.Padding(1, 20, 1, 1);
		this.tsDocuments.method_30(this.tsiPreview);
		this.tsDocuments.method_37(new global::System.Drawing.Size(352, 463));
		this.tsDocuments.TabIndex = 1;
		this.tsDocuments.Text = "faTabStrip2";
		this.tsDocuments.method_7(new global::GDelegate15(this.method_25));
		this.tsDocuments.method_5(new global::GDelegate16(this.method_1));
		this.tsiPreview.method_13(false);
		this.tsiPreview.Controls.Add(this.scPreview);
		this.tsiPreview.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.tsiPreview.method_9(true);
		this.tsiPreview.Location = new global::System.Drawing.Point(1, 20);
		this.tsiPreview.Name = "tsiPreview";
		this.tsiPreview.method_17(true);
		this.tsiPreview.method_3(new global::System.Drawing.Size(350, 442));
		this.tsiPreview.TabIndex = 0;
		this.tsiPreview.method_15("Preview");
		this.scPreview.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.scPreview.FixedPanel = global::System.Windows.Forms.FixedPanel.Panel2;
		this.scPreview.Location = new global::System.Drawing.Point(0, 0);
		this.scPreview.Name = "scPreview";
		this.scPreview.Orientation = global::System.Windows.Forms.Orientation.Horizontal;
		this.scPreview.Panel1.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
		this.scPreview.Panel2.Controls.Add(this.lvPreviewProperties);
		this.scPreview.Panel2.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
		this.scPreview.Size = new global::System.Drawing.Size(350, 442);
		this.scPreview.SplitterDistance = 347;
		this.scPreview.TabIndex = 1;
		this.lvPreviewProperties.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
		{
			this.columnHeader_0,
			this.columnHeader_1
		});
		this.lvPreviewProperties.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.lvPreviewProperties.FullRowSelect = true;
		this.lvPreviewProperties.GridLines = true;
		this.lvPreviewProperties.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
		this.lvPreviewProperties.LabelWrap = false;
		this.lvPreviewProperties.Location = new global::System.Drawing.Point(0, 0);
		this.lvPreviewProperties.MultiSelect = false;
		this.lvPreviewProperties.Name = "lvPreviewProperties";
		this.lvPreviewProperties.Size = new global::System.Drawing.Size(350, 91);
		this.lvPreviewProperties.TabIndex = 0;
		this.lvPreviewProperties.UseCompatibleStateImageBehavior = false;
		this.lvPreviewProperties.View = global::System.Windows.Forms.View.Details;
		this.columnHeader_0.Text = "Name";
		this.columnHeader_0.Width = 164;
		this.columnHeader_1.Text = "Value";
		this.columnHeader_1.Width = 88;
		this.tsFile.Dock = global::System.Windows.Forms.DockStyle.None;
		this.tsFile.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.newToolStripButton,
			this.openToolStripButton,
			this.saveToolStripButton
		});
		this.tsFile.Location = new global::System.Drawing.Point(3, 0);
		this.tsFile.Name = "tsFile";
		this.tsFile.Size = new global::System.Drawing.Size(79, 25);
		this.tsFile.TabIndex = 4;
		this.tsFile.Visible = false;
		this.newToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.newToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("newToolStripButton.Image");
		this.newToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
		this.newToolStripButton.Name = "newToolStripButton";
		this.newToolStripButton.Size = new global::System.Drawing.Size(23, 22);
		this.newToolStripButton.Text = "&New";
		this.openToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.openToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("openToolStripButton.Image");
		this.openToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
		this.openToolStripButton.Name = "openToolStripButton";
		this.openToolStripButton.Size = new global::System.Drawing.Size(23, 22);
		this.openToolStripButton.Text = "&Open";
		this.saveToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.saveToolStripButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("saveToolStripButton.Image");
		this.saveToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
		this.saveToolStripButton.Name = "saveToolStripButton";
		this.saveToolStripButton.Size = new global::System.Drawing.Size(23, 22);
		this.saveToolStripButton.Text = "&Save";
		this.tsNotesEditor.Dock = global::System.Windows.Forms.DockStyle.None;
		this.tsNotesEditor.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.tsbEditNotes,
			this.tsbInsertNotes,
			this.tsbEditBeats
		});
		this.tsNotesEditor.Location = new global::System.Drawing.Point(3, 0);
		this.tsNotesEditor.Name = "tsNotesEditor";
		this.tsNotesEditor.Size = new global::System.Drawing.Size(200, 25);
		this.tsNotesEditor.TabIndex = 5;
		this.tsNotesEditor.Visible = false;
		this.tsbEditNotes.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.tsbEditNotes.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tsbEditNotes.Image");
		this.tsbEditNotes.ImageTransparentColor = global::System.Drawing.Color.Magenta;
		this.tsbEditNotes.Name = "tsbEditNotes";
		this.tsbEditNotes.Size = new global::System.Drawing.Size(60, 22);
		this.tsbEditNotes.Text = "Edit Notes";
		this.tsbInsertNotes.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.tsbInsertNotes.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tsbInsertNotes.Image");
		this.tsbInsertNotes.ImageTransparentColor = global::System.Drawing.Color.Magenta;
		this.tsbInsertNotes.Name = "tsbInsertNotes";
		this.tsbInsertNotes.Size = new global::System.Drawing.Size(71, 22);
		this.tsbInsertNotes.Text = "Insert Notes";
		this.tsbEditBeats.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
		this.tsbEditBeats.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("tsbEditBeats.Image");
		this.tsbEditBeats.ImageTransparentColor = global::System.Drawing.Color.Magenta;
		this.tsbEditBeats.Name = "tsbEditBeats";
		this.tsbEditBeats.Size = new global::System.Drawing.Size(59, 22);
		this.tsbEditBeats.Text = "Edit Beats";
		this.menuStrip1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.menuStrip1.AutoSize = false;
		this.menuStrip1.Dock = global::System.Windows.Forms.DockStyle.None;
		this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.tsmiFile,
			this.helpToolStripMenuItem,
			this.tsmiEdit
		});
		this.menuStrip1.Location = new global::System.Drawing.Point(0, 0);
		this.menuStrip1.Name = "menuStrip1";
		this.menuStrip1.Size = new global::System.Drawing.Size(581, 24);
		this.menuStrip1.TabIndex = 5;
		this.menuStrip1.Text = "menuStrip1";
		this.tsmiFile.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.customSongsToolStripMenuItem,
			this.openToolStripMenuItem,
			this.toolStripSeparator2,
			this.tsmiFileSave,
			this.toolStripSeparator8,
			this.locArkToolStripMenuItem,
			this.toolStripSeparator4,
			this.tsmiFileExit
		});
		this.tsmiFile.Name = "tsmiFile";
		this.tsmiFile.Size = new global::System.Drawing.Size(35, 20);
		this.tsmiFile.Text = "File";
		this.customSongsToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.tsmiFileNewSong
		});
		this.customSongsToolStripMenuItem.Name = "customSongsToolStripMenuItem";
		this.customSongsToolStripMenuItem.Size = new global::System.Drawing.Size(110, 22);
		this.customSongsToolStripMenuItem.Text = "New";
		this.customSongsToolStripMenuItem.Visible = false;
		this.tsmiFileNewSong.Name = "tsmiFileNewSong";
		this.tsmiFileNewSong.Size = new global::System.Drawing.Size(98, 22);
		this.tsmiFileNewSong.Text = "Song";
		this.tsmiFileNewSong.Click += new global::System.EventHandler(this.tsmiFileNewSong_Click);
		this.openToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.tsmiFileOpenSong
		});
		this.openToolStripMenuItem.Name = "openToolStripMenuItem";
		this.openToolStripMenuItem.Size = new global::System.Drawing.Size(110, 22);
		this.openToolStripMenuItem.Text = "Open";
		this.openToolStripMenuItem.Visible = false;
		this.tsmiFileOpenSong.Name = "tsmiFileOpenSong";
		this.tsmiFileOpenSong.Size = new global::System.Drawing.Size(98, 22);
		this.tsmiFileOpenSong.Text = "Song";
		this.tsmiFileOpenSong.Click += new global::System.EventHandler(this.tsmiFileOpenSong_Click);
		this.toolStripSeparator2.Name = "toolStripSeparator2";
		this.toolStripSeparator2.Size = new global::System.Drawing.Size(107, 6);
		this.toolStripSeparator2.Visible = false;
		this.tsmiFileSave.Name = "tsmiFileSave";
		this.tsmiFileSave.Size = new global::System.Drawing.Size(110, 22);
		this.tsmiFileSave.Text = "Save";
		this.tsmiFileSave.Visible = false;
		this.tsmiFileSave.Click += new global::System.EventHandler(this.tsmiFileSave_Click);
		this.toolStripSeparator8.Name = "toolStripSeparator8";
		this.toolStripSeparator8.Size = new global::System.Drawing.Size(107, 6);
		this.toolStripSeparator8.Visible = false;
		this.locArkToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.tsmiFileLocateArk,
			this.tsmiFileCopyArchive
		});
		this.locArkToolStripMenuItem.Name = "locArkToolStripMenuItem";
		this.locArkToolStripMenuItem.Size = new global::System.Drawing.Size(110, 22);
		this.locArkToolStripMenuItem.Text = "Archive";
		this.tsmiFileLocateArk.Name = "tsmiFileLocateArk";
		this.tsmiFileLocateArk.Size = new global::System.Drawing.Size(149, 22);
		this.tsmiFileLocateArk.Text = "Add";
		this.tsmiFileLocateArk.Click += new global::System.EventHandler(this.tsmiFileLocateArk_Click);
		this.tsmiFileCopyArchive.Name = "tsmiFileCopyArchive";
		this.tsmiFileCopyArchive.Size = new global::System.Drawing.Size(149, 22);
		this.tsmiFileCopyArchive.Text = "Copy From DVD";
		this.tsmiFileCopyArchive.Click += new global::System.EventHandler(this.tsmiFileCopyArchive_Click);
		this.toolStripSeparator4.Name = "toolStripSeparator4";
		this.toolStripSeparator4.Size = new global::System.Drawing.Size(107, 6);
		this.tsmiFileExit.Name = "tsmiFileExit";
		this.tsmiFileExit.Size = new global::System.Drawing.Size(110, 22);
		this.tsmiFileExit.Text = "Exit";
		this.tsmiFileExit.Click += new global::System.EventHandler(this.tsmiFileExit_Click);
		this.helpToolStripMenuItem.Alignment = global::System.Windows.Forms.ToolStripItemAlignment.Right;
		this.helpToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.tsmiHelpWebsite,
			this.tsmiHelpChanges,
			this.toolStripSeparator1,
			this.tsmiHelpReportBug,
			this.toolStripSeparator3,
			this.tsmiHelpAbout
		});
		this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
		this.helpToolStripMenuItem.Size = new global::System.Drawing.Size(40, 20);
		this.helpToolStripMenuItem.Text = "Help";
		this.tsmiHelpWebsite.Name = "tsmiHelpWebsite";
		this.tsmiHelpWebsite.Size = new global::System.Drawing.Size(141, 22);
		this.tsmiHelpWebsite.Text = "Visit Website";
		this.tsmiHelpWebsite.Click += new global::System.EventHandler(this.tsmiHelpWebsite_Click);
		this.tsmiHelpChanges.Name = "tsmiHelpChanges";
		this.tsmiHelpChanges.Size = new global::System.Drawing.Size(141, 22);
		this.tsmiHelpChanges.Text = "View Changes";
		this.tsmiHelpChanges.Click += new global::System.EventHandler(this.tsmiHelpChanges_Click);
		this.toolStripSeparator1.Name = "toolStripSeparator1";
		this.toolStripSeparator1.Size = new global::System.Drawing.Size(138, 6);
		this.tsmiHelpReportBug.Name = "tsmiHelpReportBug";
		this.tsmiHelpReportBug.Size = new global::System.Drawing.Size(141, 22);
		this.tsmiHelpReportBug.Text = "Report A Bug";
		this.tsmiHelpReportBug.Click += new global::System.EventHandler(this.tsmiHelpReportBug_Click);
		this.toolStripSeparator3.Name = "toolStripSeparator3";
		this.toolStripSeparator3.Size = new global::System.Drawing.Size(138, 6);
		this.tsmiHelpAbout.Name = "tsmiHelpAbout";
		this.tsmiHelpAbout.Size = new global::System.Drawing.Size(141, 22);
		this.tsmiHelpAbout.Text = "About ghex";
		this.tsmiHelpAbout.Click += new global::System.EventHandler(this.tsmiHelpAbout_Click);
		this.tsmiEdit.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.tsmiEditUndo,
			this.tsmiEditRedo,
			this.toolStripSeparator5,
			this.tsmiEditCut,
			this.tsmiEditCopy,
			this.tsmiEditPaste,
			this.tsmiEditDelete,
			this.toolStripSeparator6,
			this.tsmiEditSelectAll,
			this.toolStripSeparator7
		});
		this.tsmiEdit.Name = "tsmiEdit";
		this.tsmiEdit.Size = new global::System.Drawing.Size(37, 20);
		this.tsmiEdit.Text = "Edit";
		this.tsmiEdit.Visible = false;
		this.tsmiEdit.DropDownOpening += new global::System.EventHandler(this.tsmiEdit_DropDownOpening);
		this.tsmiEditUndo.Name = "tsmiEditUndo";
		this.tsmiEditUndo.ShortcutKeys = (global::System.Windows.Forms.Keys)131162;
		this.tsmiEditUndo.Size = new global::System.Drawing.Size(156, 22);
		this.tsmiEditUndo.Text = "Undo";
		this.tsmiEditUndo.Click += new global::System.EventHandler(this.tsmiEditUndo_Click);
		this.tsmiEditRedo.Name = "tsmiEditRedo";
		this.tsmiEditRedo.ShortcutKeys = (global::System.Windows.Forms.Keys)131161;
		this.tsmiEditRedo.Size = new global::System.Drawing.Size(156, 22);
		this.tsmiEditRedo.Text = "Redo";
		this.tsmiEditRedo.Click += new global::System.EventHandler(this.tsmiEditRedo_Click);
		this.toolStripSeparator5.Name = "toolStripSeparator5";
		this.toolStripSeparator5.Size = new global::System.Drawing.Size(153, 6);
		this.tsmiEditCut.Name = "tsmiEditCut";
		this.tsmiEditCut.ShortcutKeys = (global::System.Windows.Forms.Keys)131160;
		this.tsmiEditCut.Size = new global::System.Drawing.Size(156, 22);
		this.tsmiEditCut.Text = "Cut";
		this.tsmiEditCopy.Name = "tsmiEditCopy";
		this.tsmiEditCopy.ShortcutKeys = (global::System.Windows.Forms.Keys)131139;
		this.tsmiEditCopy.Size = new global::System.Drawing.Size(156, 22);
		this.tsmiEditCopy.Text = "Copy";
		this.tsmiEditPaste.Name = "tsmiEditPaste";
		this.tsmiEditPaste.ShortcutKeys = (global::System.Windows.Forms.Keys)131158;
		this.tsmiEditPaste.Size = new global::System.Drawing.Size(156, 22);
		this.tsmiEditPaste.Text = "Paste";
		this.tsmiEditDelete.Name = "tsmiEditDelete";
		this.tsmiEditDelete.ShortcutKeys = global::System.Windows.Forms.Keys.Delete;
		this.tsmiEditDelete.Size = new global::System.Drawing.Size(156, 22);
		this.tsmiEditDelete.Text = "Delete";
		this.toolStripSeparator6.Name = "toolStripSeparator6";
		this.toolStripSeparator6.Size = new global::System.Drawing.Size(153, 6);
		this.tsmiEditSelectAll.Name = "tsmiEditSelectAll";
		this.tsmiEditSelectAll.ShortcutKeys = (global::System.Windows.Forms.Keys)131137;
		this.tsmiEditSelectAll.Size = new global::System.Drawing.Size(156, 22);
		this.tsmiEditSelectAll.Text = "Select All";
		this.toolStripSeparator7.Name = "toolStripSeparator7";
		this.toolStripSeparator7.Size = new global::System.Drawing.Size(153, 6);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(581, 509);
		base.Controls.Add(this.toolStripContainer1);
		base.Controls.Add(this.statusStrip1);
		base.Controls.Add(this.menuStrip1);
		base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
		base.Name = "MainWindow";
		this.Text = "Guitar Hero Explorer";
		base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
		base.Shown += new global::System.EventHandler(this.MainWindow_Shown);
		base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
		base.Load += new global::System.EventHandler(this.MainWindow_Load);
		this.statusStrip1.ResumeLayout(false);
		this.statusStrip1.PerformLayout();
		this.cmArkFileList.ResumeLayout(false);
		this.toolStripContainer1.ContentPanel.ResumeLayout(false);
		this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
		this.toolStripContainer1.TopToolStripPanel.PerformLayout();
		this.toolStripContainer1.ResumeLayout(false);
		this.toolStripContainer1.PerformLayout();
		this.splitContainer1.Panel1.ResumeLayout(false);
		this.splitContainer1.Panel1.PerformLayout();
		this.splitContainer1.Panel2.ResumeLayout(false);
		this.splitContainer1.ResumeLayout(false);
		this.tsLeft.ResumeLayout(false);
		this.tsLeft.PerformLayout();
		((global::System.ComponentModel.ISupportInitialize)this.tsDocuments).EndInit();
		this.tsDocuments.ResumeLayout(false);
		this.tsiPreview.ResumeLayout(false);
		this.scPreview.Panel2.ResumeLayout(false);
		this.scPreview.ResumeLayout(false);
		this.tsFile.ResumeLayout(false);
		this.tsFile.PerformLayout();
		this.tsNotesEditor.ResumeLayout(false);
		this.tsNotesEditor.PerformLayout();
		this.menuStrip1.ResumeLayout(false);
		this.menuStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	global::System.ComponentModel.IContainer icontainer_0;

	global::System.Windows.Forms.StatusStrip statusStrip1;

	global::System.Windows.Forms.OpenFileDialog openFileDialog_0;

	global::System.Windows.Forms.ContextMenuStrip cmArkFileList;

	global::System.Windows.Forms.ToolStripMenuItem cmiFileListRemove;

	global::System.Windows.Forms.ImageList imageList_0;

	global::System.Windows.Forms.ImageList imageList_1;

	global::System.Windows.Forms.ToolStripMenuItem cmiFileListSave;

	global::System.Windows.Forms.ToolStripMenuItem cmiFileListReLink;

	global::System.Windows.Forms.ToolStripMenuItem cmiFileListReplace;

	global::System.Windows.Forms.Timer timer_0;

	global::System.Windows.Forms.ToolStripStatusLabel tslVersion;

	global::System.Windows.Forms.ToolStripMenuItem cmiFileListExtract;

	global::System.Windows.Forms.ToolStripMenuItem cmiFileListNA;

	global::System.Windows.Forms.ToolStripMenuItem cmiFileListExportNoteCharts;

	global::System.Windows.Forms.ToolStripMenuItem cmiFileListImport;

	global::System.Windows.Forms.ToolStripContainer toolStripContainer1;

	global::System.Windows.Forms.ToolStrip tsFile;

	global::System.Windows.Forms.SplitContainer splitContainer1;

	global::System.Windows.Forms.TreeView arkFileList;

	global::GControl1 tsDocuments;

	global::GClass98 tsiPreview;

	global::System.Windows.Forms.SplitContainer scPreview;

	global::System.Windows.Forms.ListView lvPreviewProperties;

	global::System.Windows.Forms.ColumnHeader columnHeader_0;

	global::System.Windows.Forms.ColumnHeader columnHeader_1;

	global::System.Windows.Forms.ToolStripButton newToolStripButton;

	global::System.Windows.Forms.ToolStripButton openToolStripButton;

	global::System.Windows.Forms.ToolStripButton saveToolStripButton;

	global::System.Windows.Forms.MenuStrip menuStrip1;

	global::System.Windows.Forms.ToolStripMenuItem tsmiFile;

	global::System.Windows.Forms.ToolStripMenuItem customSongsToolStripMenuItem;

	global::System.Windows.Forms.ToolStripMenuItem tsmiFileNewSong;

	global::System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;

	global::System.Windows.Forms.ToolStripMenuItem tsmiFileOpenSong;

	global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

	global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

	global::System.Windows.Forms.ToolStripMenuItem tsmiFileExit;

	global::System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

	global::System.Windows.Forms.ToolStripMenuItem tsmiHelpWebsite;

	global::System.Windows.Forms.ToolStripMenuItem tsmiHelpChanges;

	global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

	global::System.Windows.Forms.ToolStripMenuItem tsmiHelpReportBug;

	global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

	global::System.Windows.Forms.ToolStripMenuItem tsmiHelpAbout;

	global::System.Windows.Forms.ToolStripMenuItem tsmiEdit;

	global::System.Windows.Forms.ToolStripMenuItem tsmiEditUndo;

	global::System.Windows.Forms.ToolStripMenuItem tsmiEditRedo;

	global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

	global::System.Windows.Forms.ToolStripMenuItem tsmiEditCut;

	global::System.Windows.Forms.ToolStripMenuItem tsmiEditCopy;

	global::System.Windows.Forms.ToolStripMenuItem tsmiEditPaste;

	global::System.Windows.Forms.ToolStripMenuItem tsmiEditDelete;

	global::System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

	global::System.Windows.Forms.ToolStripMenuItem tsmiEditSelectAll;

	global::System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

	global::System.Windows.Forms.ToolStripMenuItem tsmiFileSave;

	global::System.Windows.Forms.ToolStripSeparator toolStripSeparator8;

	global::GClass134 tsLeft;

	global::GClass135 tsbExplorer;

	global::GClass135 tsbPropertyGrid;

	global::System.Windows.Forms.PropertyGrid propertyGrid1;

	global::System.Windows.Forms.ToolStrip tsNotesEditor;

	global::System.Windows.Forms.ToolStripButton tsbEditNotes;

	global::System.Windows.Forms.ToolStripButton tsbInsertNotes;

	global::System.Windows.Forms.ToolStripButton tsbEditBeats;

	global::System.Windows.Forms.ToolStripMenuItem locArkToolStripMenuItem;

	global::System.Windows.Forms.ToolStripMenuItem tsmiFileLocateArk;

	global::System.Windows.Forms.ToolStripMenuItem tsmiFileCopyArchive;

	global::System.Windows.Forms.ToolStripMenuItem cmiFileListShrinkArchive;

	global::System.Windows.Forms.ToolStripMenuItem cmiFileListMakeWritable;
}
