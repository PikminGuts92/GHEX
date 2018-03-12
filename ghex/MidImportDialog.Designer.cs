public partial class MidImportDialog : global::System.Windows.Forms.Form
{
	void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MidImportDialog));
		this.btnCancel = new global::System.Windows.Forms.Button();
		this.btnOk = new global::System.Windows.Forms.Button();
		this.groupBox1 = new global::System.Windows.Forms.GroupBox();
		this.gbIssues = new global::System.Windows.Forms.GroupBox();
		this.lvIssues = new global::System.Windows.Forms.ListView();
		this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
		this.imageList_0 = new global::System.Windows.Forms.ImageList(this.icontainer_0);
		this.tblTracks = new global::GControl2();
		this.gclass32_0 = new global::GClass32();
		this.gclass25_0 = new global::GClass25();
		this.gclass20_0 = new global::GClass20();
		this.gclass20_1 = new global::GClass20();
		this.gclass20_2 = new global::GClass20();
		this.gclass20_3 = new global::GClass20();
		this.gclass104_0 = new global::GClass104();
		this.groupBox1.SuspendLayout();
		this.gbIssues.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.tblTracks).BeginInit();
		base.SuspendLayout();
		this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
		this.btnCancel.Location = new global::System.Drawing.Point(480, 299);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
		this.btnCancel.TabIndex = 3;
		this.btnCancel.Text = "Cancel";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.btnOk.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.btnOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
		this.btnOk.Location = new global::System.Drawing.Point(561, 299);
		this.btnOk.Name = "btnOk";
		this.btnOk.Size = new global::System.Drawing.Size(75, 23);
		this.btnOk.TabIndex = 2;
		this.btnOk.Text = "OK";
		this.btnOk.UseVisualStyleBackColor = true;
		this.groupBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.groupBox1.Controls.Add(this.tblTracks);
		this.groupBox1.Location = new global::System.Drawing.Point(12, 12);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new global::System.Drawing.Size(624, 108);
		this.groupBox1.TabIndex = 6;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Notes Track Mapping:";
		this.gbIssues.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.gbIssues.Controls.Add(this.lvIssues);
		this.gbIssues.Location = new global::System.Drawing.Point(12, 128);
		this.gbIssues.Name = "gbIssues";
		this.gbIssues.Size = new global::System.Drawing.Size(624, 165);
		this.gbIssues.TabIndex = 7;
		this.gbIssues.TabStop = false;
		this.gbIssues.Text = "Information/Issues:";
		this.lvIssues.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.lvIssues.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
		{
			this.columnHeader_0
		});
		this.lvIssues.FullRowSelect = true;
		this.lvIssues.GridLines = true;
		this.lvIssues.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.None;
		this.lvIssues.Location = new global::System.Drawing.Point(6, 19);
		this.lvIssues.MultiSelect = false;
		this.lvIssues.Name = "lvIssues";
		this.lvIssues.Size = new global::System.Drawing.Size(612, 140);
		this.lvIssues.SmallImageList = this.imageList_0;
		this.lvIssues.TabIndex = 5;
		this.lvIssues.UseCompatibleStateImageBehavior = false;
		this.lvIssues.View = global::System.Windows.Forms.View.Details;
		this.columnHeader_0.Width = 550;
		this.imageList_0.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
		this.imageList_0.TransparentColor = global::System.Drawing.Color.Transparent;
		this.imageList_0.Images.SetKeyName(0, "import_ok.bmp");
		this.imageList_0.Images.SetKeyName(1, "import_warn.bmp");
		this.imageList_0.Images.SetKeyName(2, "import_err.bmp");
		this.tblTracks.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.tblTracks.method_167(this.gclass32_0);
		this.tblTracks.method_201(false);
		this.tblTracks.method_183(global::GEnum3.const_3);
		this.tblTracks.method_191(global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable);
		this.tblTracks.method_224(true);
		this.tblTracks.Location = new global::System.Drawing.Point(6, 19);
		this.tblTracks.Name = "tblTracks";
		this.tblTracks.method_242("");
		this.tblTracks.Size = new global::System.Drawing.Size(612, 83);
		this.tblTracks.TabIndex = 6;
		this.tblTracks.method_240(this.gclass104_0);
		this.tblTracks.Text = "table1";
		this.gclass32_0.method_23().method_1(new global::GClass17[]
		{
			this.gclass25_0,
			this.gclass20_0,
			this.gclass20_1,
			this.gclass20_2,
			this.gclass20_3
		});
		this.gclass32_0.method_25(18);
		this.gclass25_0.vmethod_10(false);
		this.gclass25_0.vmethod_7(false);
		this.gclass25_0.method_6("Track");
		this.gclass25_0.method_10(100);
		this.gclass20_0.vmethod_7(false);
		this.gclass20_0.method_6("Expert");
		this.gclass20_0.method_10(110);
		this.gclass20_1.vmethod_7(false);
		this.gclass20_1.method_6("Hard");
		this.gclass20_1.method_10(110);
		this.gclass20_2.vmethod_7(false);
		this.gclass20_2.method_6("Medium");
		this.gclass20_2.method_10(110);
		this.gclass20_3.vmethod_7(false);
		this.gclass20_3.method_6("Easy");
		this.gclass20_3.method_10(110);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(648, 334);
		base.Controls.Add(this.gbIssues);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnOk);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "MidImportDialog";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
		this.groupBox1.ResumeLayout(false);
		this.gbIssues.ResumeLayout(false);
		((global::System.ComponentModel.ISupportInitialize)this.tblTracks).EndInit();
		base.ResumeLayout(false);
	}

	global::System.ComponentModel.IContainer icontainer_0;

	global::System.Windows.Forms.Button btnCancel;

	global::System.Windows.Forms.Button btnOk;

	global::GClass32 gclass32_0;

	global::GClass25 gclass25_0;

	global::GClass20 gclass20_0;

	global::GClass104 gclass104_0;

	global::GClass20 gclass20_1;

	global::GClass20 gclass20_2;

	global::GClass20 gclass20_3;

	global::System.Windows.Forms.GroupBox groupBox1;

	global::GControl2 tblTracks;

	global::System.Windows.Forms.GroupBox gbIssues;

	global::System.Windows.Forms.ListView lvIssues;

	global::System.Windows.Forms.ColumnHeader columnHeader_0;

	global::System.Windows.Forms.ImageList imageList_0;
}
