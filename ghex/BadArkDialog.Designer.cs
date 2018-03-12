public partial class BadArkDialog : global::System.Windows.Forms.Form
{
	void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		this.label1 = new global::System.Windows.Forms.Label();
		this.tvFiles = new global::System.Windows.Forms.TreeView();
		this.btnOk = new global::System.Windows.Forms.Button();
		this.btnCancel = new global::System.Windows.Forms.Button();
		this.lblInfo = new global::System.Windows.Forms.Label();
		this.folderBrowserDialog_0 = new global::System.Windows.Forms.FolderBrowserDialog();
		this.cmsFiles = new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.tsmiRecover = new global::System.Windows.Forms.ToolStripMenuItem();
		this.cbAll = new global::System.Windows.Forms.CheckBox();
		this.cmsFiles.SuspendLayout();
		base.SuspendLayout();
		this.label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new global::System.Drawing.Point(12, 9);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(256, 47);
		this.label1.TabIndex = 0;
		this.label1.Text = "The archive you tried to load contained bad data, but you can recover any files that are not damaged by extracting them here.";
		this.tvFiles.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.tvFiles.ContextMenuStrip = this.cmsFiles;
		this.tvFiles.Location = new global::System.Drawing.Point(15, 59);
		this.tvFiles.Name = "tvFiles";
		this.tvFiles.PathSeparator = "/";
		this.tvFiles.ShowNodeToolTips = true;
		this.tvFiles.Size = new global::System.Drawing.Size(253, 223);
		this.tvFiles.TabIndex = 1;
		this.tvFiles.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.tvFiles_MouseClick);
		this.tvFiles.DoubleClick += new global::System.EventHandler(this.tvFiles_DoubleClick);
		this.btnOk.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.btnOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
		this.btnOk.Location = new global::System.Drawing.Point(193, 327);
		this.btnOk.Name = "btnOk";
		this.btnOk.Size = new global::System.Drawing.Size(75, 23);
		this.btnOk.TabIndex = 2;
		this.btnOk.Text = "Recover";
		this.btnOk.UseVisualStyleBackColor = true;
		this.btnOk.Click += new global::System.EventHandler(this.btnOk_Click);
		this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
		this.btnCancel.Location = new global::System.Drawing.Point(112, 327);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
		this.btnCancel.TabIndex = 3;
		this.btnCancel.Text = "Cancel";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.lblInfo.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.lblInfo.Location = new global::System.Drawing.Point(12, 296);
		this.lblInfo.Name = "lblInfo";
		this.lblInfo.Size = new global::System.Drawing.Size(256, 17);
		this.lblInfo.TabIndex = 4;
		this.lblInfo.Text = "..";
		this.folderBrowserDialog_0.Description = "Locate the target folder where all recovered files will be stored. Please note that any existing files will be overwritten.";
		this.cmsFiles.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.tsmiRecover
		});
		this.cmsFiles.Name = "cmsFiles";
		this.cmsFiles.Size = new global::System.Drawing.Size(115, 26);
		this.cmsFiles.Opening += new global::System.ComponentModel.CancelEventHandler(this.cmsFiles_Opening);
		this.tsmiRecover.Name = "tsmiRecover";
		this.tsmiRecover.Size = new global::System.Drawing.Size(114, 22);
		this.tsmiRecover.Text = "Recover";
		this.tsmiRecover.Click += new global::System.EventHandler(this.tsmiRecover_Click);
		this.cbAll.AutoSize = true;
		this.cbAll.Location = new global::System.Drawing.Point(15, 327);
		this.cbAll.Name = "cbAll";
		this.cbAll.Size = new global::System.Drawing.Size(80, 17);
		this.cbAll.TabIndex = 6;
		this.cbAll.Text = "Recover all";
		this.cbAll.UseVisualStyleBackColor = true;
		this.cbAll.CheckedChanged += new global::System.EventHandler(this.cbAll_CheckedChanged);
		base.AcceptButton = this.btnOk;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.btnCancel;
		base.ClientSize = new global::System.Drawing.Size(280, 362);
		base.ControlBox = false;
		base.Controls.Add(this.lblInfo);
		base.Controls.Add(this.cbAll);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnOk);
		base.Controls.Add(this.tvFiles);
		base.Controls.Add(this.label1);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "BadArkDialog";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Recover files..";
		base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.BadArkDialog_FormClosing);
		this.cmsFiles.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	global::System.ComponentModel.IContainer icontainer_0;

	global::System.Windows.Forms.Label label1;

	global::System.Windows.Forms.TreeView tvFiles;

	global::System.Windows.Forms.Button btnOk;

	global::System.Windows.Forms.Button btnCancel;

	global::System.Windows.Forms.Label lblInfo;

	global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_0;

	global::System.Windows.Forms.ContextMenuStrip cmsFiles;

	global::System.Windows.Forms.ToolStripMenuItem tsmiRecover;

	global::System.Windows.Forms.CheckBox cbAll;
}
