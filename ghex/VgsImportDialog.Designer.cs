public partial class VgsImportDialog : global::System.Windows.Forms.Form
{
	void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		this.btnOk = new global::System.Windows.Forms.Button();
		this.btnCancel = new global::System.Windows.Forms.Button();
		this.cmSource = new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.tsmiSourceAdd = new global::System.Windows.Forms.ToolStripMenuItem();
		this.tsmiSourceRemove = new global::System.Windows.Forms.ToolStripMenuItem();
		this.tsmiSourceProperties = new global::System.Windows.Forms.ToolStripMenuItem();
		this.groupBox1 = new global::System.Windows.Forms.GroupBox();
		this.lvSources = new global::System.Windows.Forms.ListView();
		this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_3 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_4 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_5 = new global::System.Windows.Forms.ColumnHeader();
		this.label1 = new global::System.Windows.Forms.Label();
		this.groupBox2 = new global::System.Windows.Forms.GroupBox();
		this.lMapping = new global::System.Windows.Forms.Label();
		this.cbChannel7 = new global::System.Windows.Forms.ComboBox();
		this.label9 = new global::System.Windows.Forms.Label();
		this.cbChannel6 = new global::System.Windows.Forms.ComboBox();
		this.label10 = new global::System.Windows.Forms.Label();
		this.cbChannel5 = new global::System.Windows.Forms.ComboBox();
		this.label7 = new global::System.Windows.Forms.Label();
		this.cbChannel4 = new global::System.Windows.Forms.ComboBox();
		this.label8 = new global::System.Windows.Forms.Label();
		this.cbChannel3 = new global::System.Windows.Forms.ComboBox();
		this.label5 = new global::System.Windows.Forms.Label();
		this.cbChannel2 = new global::System.Windows.Forms.ComboBox();
		this.label6 = new global::System.Windows.Forms.Label();
		this.cbChannel1 = new global::System.Windows.Forms.ComboBox();
		this.label4 = new global::System.Windows.Forms.Label();
		this.cbChannel0 = new global::System.Windows.Forms.ComboBox();
		this.label3 = new global::System.Windows.Forms.Label();
		this.label2 = new global::System.Windows.Forms.Label();
		this.cbNormalize = new global::System.Windows.Forms.CheckBox();
		this.openFileDialog_0 = new global::System.Windows.Forms.OpenFileDialog();
		this.cmSource.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.groupBox2.SuspendLayout();
		base.SuspendLayout();
		this.btnOk.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.btnOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
		this.btnOk.Location = new global::System.Drawing.Point(246, 359);
		this.btnOk.Name = "btnOk";
		this.btnOk.Size = new global::System.Drawing.Size(75, 23);
		this.btnOk.TabIndex = 0;
		this.btnOk.Text = "OK";
		this.btnOk.UseVisualStyleBackColor = true;
		this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
		this.btnCancel.Location = new global::System.Drawing.Point(165, 359);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
		this.btnCancel.TabIndex = 1;
		this.btnCancel.Text = "Cancel";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.cmSource.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.tsmiSourceAdd,
			this.tsmiSourceRemove,
			this.tsmiSourceProperties
		});
		this.cmSource.Name = "cmSource";
		this.cmSource.Size = new global::System.Drawing.Size(124, 70);
		this.cmSource.Opening += new global::System.ComponentModel.CancelEventHandler(this.cmSource_Opening);
		this.tsmiSourceAdd.Name = "tsmiSourceAdd";
		this.tsmiSourceAdd.Size = new global::System.Drawing.Size(123, 22);
		this.tsmiSourceAdd.Text = "Add";
		this.tsmiSourceAdd.Click += new global::System.EventHandler(this.tsmiSourceAdd_Click);
		this.tsmiSourceRemove.Name = "tsmiSourceRemove";
		this.tsmiSourceRemove.Size = new global::System.Drawing.Size(123, 22);
		this.tsmiSourceRemove.Text = "Remove";
		this.tsmiSourceRemove.Click += new global::System.EventHandler(this.tsmiSourceRemove_Click);
		this.tsmiSourceProperties.Name = "tsmiSourceProperties";
		this.tsmiSourceProperties.Size = new global::System.Drawing.Size(123, 22);
		this.tsmiSourceProperties.Text = "Properties";
		this.tsmiSourceProperties.Click += new global::System.EventHandler(this.tsmiSourceProperties_Click);
		this.groupBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.groupBox1.Controls.Add(this.lvSources);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Location = new global::System.Drawing.Point(12, 12);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new global::System.Drawing.Size(309, 152);
		this.groupBox1.TabIndex = 4;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Source";
		this.lvSources.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.lvSources.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
		{
			this.columnHeader_0,
			this.columnHeader_1,
			this.columnHeader_2,
			this.columnHeader_3,
			this.columnHeader_4,
			this.columnHeader_5
		});
		this.lvSources.ContextMenuStrip = this.cmSource;
		this.lvSources.FullRowSelect = true;
		this.lvSources.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
		this.lvSources.Location = new global::System.Drawing.Point(6, 60);
		this.lvSources.Name = "lvSources";
		this.lvSources.ShowGroups = false;
		this.lvSources.ShowItemToolTips = true;
		this.lvSources.Size = new global::System.Drawing.Size(297, 86);
		this.lvSources.TabIndex = 5;
		this.lvSources.UseCompatibleStateImageBehavior = false;
		this.lvSources.View = global::System.Windows.Forms.View.Details;
		this.columnHeader_0.Text = "#";
		this.columnHeader_0.Width = 20;
		this.columnHeader_1.Text = "Channels";
		this.columnHeader_1.Width = 30;
		this.columnHeader_2.Text = "SampleRate";
		this.columnHeader_3.Text = "Resolution";
		this.columnHeader_3.Width = 50;
		this.columnHeader_4.Text = "Format";
		this.columnHeader_4.Width = 45;
		this.columnHeader_5.Text = "File";
		this.columnHeader_5.Width = 87;
		this.label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.label1.Location = new global::System.Drawing.Point(6, 16);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(297, 41);
		this.label1.TabIndex = 4;
		this.label1.Text = "Right-click on the list below and add source files to import into the different channels.\r\nYou can use VGS/WAV/MP3/WMA/OGG/ASF/WMV files.";
		this.groupBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.groupBox2.Controls.Add(this.lMapping);
		this.groupBox2.Controls.Add(this.cbChannel7);
		this.groupBox2.Controls.Add(this.label9);
		this.groupBox2.Controls.Add(this.cbChannel6);
		this.groupBox2.Controls.Add(this.label10);
		this.groupBox2.Controls.Add(this.cbChannel5);
		this.groupBox2.Controls.Add(this.label7);
		this.groupBox2.Controls.Add(this.cbChannel4);
		this.groupBox2.Controls.Add(this.label8);
		this.groupBox2.Controls.Add(this.cbChannel3);
		this.groupBox2.Controls.Add(this.label5);
		this.groupBox2.Controls.Add(this.cbChannel2);
		this.groupBox2.Controls.Add(this.label6);
		this.groupBox2.Controls.Add(this.cbChannel1);
		this.groupBox2.Controls.Add(this.label4);
		this.groupBox2.Controls.Add(this.cbChannel0);
		this.groupBox2.Controls.Add(this.label3);
		this.groupBox2.Controls.Add(this.label2);
		this.groupBox2.Location = new global::System.Drawing.Point(12, 170);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new global::System.Drawing.Size(309, 178);
		this.groupBox2.TabIndex = 5;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Target";
		this.lMapping.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.lMapping.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.lMapping.Location = new global::System.Drawing.Point(6, 49);
		this.lMapping.Name = "lMapping";
		this.lMapping.Size = new global::System.Drawing.Size(297, 19);
		this.lMapping.TabIndex = 17;
		this.lMapping.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
		this.cbChannel7.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.cbChannel7.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbChannel7.FormattingEnabled = true;
		this.cbChannel7.Location = new global::System.Drawing.Point(182, 152);
		this.cbChannel7.Name = "cbChannel7";
		this.cbChannel7.Size = new global::System.Drawing.Size(121, 21);
		this.cbChannel7.TabIndex = 16;
		this.cbChannel7.Visible = false;
		this.cbChannel7.SelectedIndexChanged += new global::System.EventHandler(this.cbChannel0_SelectedIndexChanged);
		this.label9.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.label9.AutoSize = true;
		this.label9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label9.Location = new global::System.Drawing.Point(158, 155);
		this.label9.Name = "label9";
		this.label9.Size = new global::System.Drawing.Size(18, 13);
		this.label9.TabIndex = 15;
		this.label9.Text = "7:";
		this.label9.Visible = false;
		this.cbChannel6.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
		this.cbChannel6.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbChannel6.Enabled = false;
		this.cbChannel6.FormattingEnabled = true;
		this.cbChannel6.Location = new global::System.Drawing.Point(30, 152);
		this.cbChannel6.Name = "cbChannel6";
		this.cbChannel6.Size = new global::System.Drawing.Size(121, 21);
		this.cbChannel6.TabIndex = 14;
		this.cbChannel6.SelectedIndexChanged += new global::System.EventHandler(this.cbChannel0_SelectedIndexChanged);
		this.label10.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
		this.label10.AutoSize = true;
		this.label10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label10.Location = new global::System.Drawing.Point(6, 155);
		this.label10.Name = "label10";
		this.label10.Size = new global::System.Drawing.Size(18, 13);
		this.label10.TabIndex = 13;
		this.label10.Text = "6:";
		this.cbChannel5.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.cbChannel5.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbChannel5.Enabled = false;
		this.cbChannel5.FormattingEnabled = true;
		this.cbChannel5.Location = new global::System.Drawing.Point(182, 125);
		this.cbChannel5.Name = "cbChannel5";
		this.cbChannel5.Size = new global::System.Drawing.Size(121, 21);
		this.cbChannel5.TabIndex = 12;
		this.cbChannel5.SelectedIndexChanged += new global::System.EventHandler(this.cbChannel0_SelectedIndexChanged);
		this.label7.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.label7.AutoSize = true;
		this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label7.Location = new global::System.Drawing.Point(158, 128);
		this.label7.Name = "label7";
		this.label7.Size = new global::System.Drawing.Size(18, 13);
		this.label7.TabIndex = 11;
		this.label7.Text = "5:";
		this.cbChannel4.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
		this.cbChannel4.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbChannel4.Enabled = false;
		this.cbChannel4.FormattingEnabled = true;
		this.cbChannel4.Location = new global::System.Drawing.Point(30, 125);
		this.cbChannel4.Name = "cbChannel4";
		this.cbChannel4.Size = new global::System.Drawing.Size(121, 21);
		this.cbChannel4.TabIndex = 10;
		this.cbChannel4.SelectedIndexChanged += new global::System.EventHandler(this.cbChannel0_SelectedIndexChanged);
		this.label8.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
		this.label8.AutoSize = true;
		this.label8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label8.Location = new global::System.Drawing.Point(6, 128);
		this.label8.Name = "label8";
		this.label8.Size = new global::System.Drawing.Size(18, 13);
		this.label8.TabIndex = 9;
		this.label8.Text = "4:";
		this.cbChannel3.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.cbChannel3.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbChannel3.Enabled = false;
		this.cbChannel3.FormattingEnabled = true;
		this.cbChannel3.Location = new global::System.Drawing.Point(182, 98);
		this.cbChannel3.Name = "cbChannel3";
		this.cbChannel3.Size = new global::System.Drawing.Size(121, 21);
		this.cbChannel3.TabIndex = 8;
		this.cbChannel3.SelectedIndexChanged += new global::System.EventHandler(this.cbChannel0_SelectedIndexChanged);
		this.label5.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.label5.AutoSize = true;
		this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label5.Location = new global::System.Drawing.Point(158, 101);
		this.label5.Name = "label5";
		this.label5.Size = new global::System.Drawing.Size(18, 13);
		this.label5.TabIndex = 7;
		this.label5.Text = "3:";
		this.cbChannel2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
		this.cbChannel2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbChannel2.Enabled = false;
		this.cbChannel2.FormattingEnabled = true;
		this.cbChannel2.Location = new global::System.Drawing.Point(30, 98);
		this.cbChannel2.Name = "cbChannel2";
		this.cbChannel2.Size = new global::System.Drawing.Size(121, 21);
		this.cbChannel2.TabIndex = 6;
		this.cbChannel2.SelectedIndexChanged += new global::System.EventHandler(this.cbChannel0_SelectedIndexChanged);
		this.label6.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
		this.label6.AutoSize = true;
		this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label6.Location = new global::System.Drawing.Point(6, 101);
		this.label6.Name = "label6";
		this.label6.Size = new global::System.Drawing.Size(18, 13);
		this.label6.TabIndex = 5;
		this.label6.Text = "2:";
		this.cbChannel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.cbChannel1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbChannel1.Enabled = false;
		this.cbChannel1.FormattingEnabled = true;
		this.cbChannel1.Location = new global::System.Drawing.Point(182, 71);
		this.cbChannel1.Name = "cbChannel1";
		this.cbChannel1.Size = new global::System.Drawing.Size(121, 21);
		this.cbChannel1.TabIndex = 4;
		this.cbChannel1.SelectedIndexChanged += new global::System.EventHandler(this.cbChannel0_SelectedIndexChanged);
		this.label4.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.label4.AutoSize = true;
		this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label4.Location = new global::System.Drawing.Point(158, 74);
		this.label4.Name = "label4";
		this.label4.Size = new global::System.Drawing.Size(18, 13);
		this.label4.TabIndex = 3;
		this.label4.Text = "1:";
		this.cbChannel0.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
		this.cbChannel0.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbChannel0.Enabled = false;
		this.cbChannel0.FormattingEnabled = true;
		this.cbChannel0.Location = new global::System.Drawing.Point(30, 71);
		this.cbChannel0.Name = "cbChannel0";
		this.cbChannel0.Size = new global::System.Drawing.Size(121, 21);
		this.cbChannel0.TabIndex = 2;
		this.cbChannel0.SelectedIndexChanged += new global::System.EventHandler(this.cbChannel0_SelectedIndexChanged);
		this.label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
		this.label3.AutoSize = true;
		this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label3.Location = new global::System.Drawing.Point(6, 74);
		this.label3.Name = "label3";
		this.label3.Size = new global::System.Drawing.Size(18, 13);
		this.label3.TabIndex = 1;
		this.label3.Text = "0:";
		this.label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label2.Location = new global::System.Drawing.Point(6, 16);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(297, 30);
		this.label2.TabIndex = 0;
		this.label2.Text = "Choose which source channel to map to which VGS channel.\r\nThe most likely mapping for this number of channels is:";
		this.cbNormalize.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
		this.cbNormalize.AutoSize = true;
		this.cbNormalize.Enabled = false;
		this.cbNormalize.Location = new global::System.Drawing.Point(18, 363);
		this.cbNormalize.Name = "cbNormalize";
		this.cbNormalize.Size = new global::System.Drawing.Size(72, 17);
		this.cbNormalize.TabIndex = 6;
		this.cbNormalize.Text = "Normalize";
		this.cbNormalize.UseVisualStyleBackColor = true;
		this.openFileDialog_0.Filter = "Supported Files|*.wav;*.mpe;*.wma;*.asf;*.wmv;*.mp3;*.vgs;*.ogg";
		this.openFileDialog_0.Multiselect = true;
		this.openFileDialog_0.Title = "Locate source file(s)";
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(333, 394);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.cbNormalize);
		base.Controls.Add(this.btnOk);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "VgsImportDialog";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
		this.cmSource.ResumeLayout(false);
		this.groupBox1.ResumeLayout(false);
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	global::System.ComponentModel.IContainer icontainer_0;

	global::System.Windows.Forms.Button btnOk;

	global::System.Windows.Forms.Button btnCancel;

	global::System.Windows.Forms.ContextMenuStrip cmSource;

	global::System.Windows.Forms.ToolStripMenuItem tsmiSourceAdd;

	global::System.Windows.Forms.ToolStripMenuItem tsmiSourceRemove;

	global::System.Windows.Forms.GroupBox groupBox1;

	global::System.Windows.Forms.Label label1;

	global::System.Windows.Forms.GroupBox groupBox2;

	global::System.Windows.Forms.CheckBox cbNormalize;

	global::System.Windows.Forms.ComboBox cbChannel0;

	global::System.Windows.Forms.Label label3;

	global::System.Windows.Forms.Label label2;

	global::System.Windows.Forms.ComboBox cbChannel5;

	global::System.Windows.Forms.Label label7;

	global::System.Windows.Forms.ComboBox cbChannel4;

	global::System.Windows.Forms.Label label8;

	global::System.Windows.Forms.ComboBox cbChannel3;

	global::System.Windows.Forms.Label label5;

	global::System.Windows.Forms.ComboBox cbChannel2;

	global::System.Windows.Forms.Label label6;

	global::System.Windows.Forms.ComboBox cbChannel1;

	global::System.Windows.Forms.Label label4;

	global::System.Windows.Forms.ComboBox cbChannel7;

	global::System.Windows.Forms.Label label9;

	global::System.Windows.Forms.ComboBox cbChannel6;

	global::System.Windows.Forms.Label label10;

	global::System.Windows.Forms.Label lMapping;

	global::System.Windows.Forms.OpenFileDialog openFileDialog_0;

	global::System.Windows.Forms.ListView lvSources;

	global::System.Windows.Forms.ColumnHeader columnHeader_0;

	global::System.Windows.Forms.ColumnHeader columnHeader_1;

	global::System.Windows.Forms.ColumnHeader columnHeader_2;

	global::System.Windows.Forms.ColumnHeader columnHeader_3;

	global::System.Windows.Forms.ColumnHeader columnHeader_4;

	global::System.Windows.Forms.ColumnHeader columnHeader_5;

	global::System.Windows.Forms.ToolStripMenuItem tsmiSourceProperties;
}
