public partial class ArkCopyDialog : global::System.Windows.Forms.Form
{
	void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		this.folderBrowserDialog_0 = new global::System.Windows.Forms.FolderBrowserDialog();
		this.groupBox1 = new global::System.Windows.Forms.GroupBox();
		this.lblSource = new global::System.Windows.Forms.Label();
		this.cbDrives = new global::System.Windows.Forms.ComboBox();
		this.groupBox2 = new global::System.Windows.Forms.GroupBox();
		this.lblTarget = new global::System.Windows.Forms.Label();
		this.btnBrowser = new global::System.Windows.Forms.Button();
		this.btnOk = new global::System.Windows.Forms.Button();
		this.btnCancel = new global::System.Windows.Forms.Button();
		this.cbAddToList = new global::System.Windows.Forms.CheckBox();
		this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		this.cbAllFiles = new global::System.Windows.Forms.CheckBox();
		this.groupBox1.SuspendLayout();
		this.groupBox2.SuspendLayout();
		base.SuspendLayout();
		this.folderBrowserDialog_0.Description = "Choose where to store the archive files on your hard drive.";
		this.groupBox1.Controls.Add(this.lblSource);
		this.groupBox1.Controls.Add(this.cbDrives);
		this.groupBox1.Location = new global::System.Drawing.Point(12, 12);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new global::System.Drawing.Size(110, 68);
		this.groupBox1.TabIndex = 6;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "From:";
		this.lblSource.Location = new global::System.Drawing.Point(12, 43);
		this.lblSource.Name = "lblSource";
		this.lblSource.Size = new global::System.Drawing.Size(81, 19);
		this.lblSource.TabIndex = 4;
		this.lblSource.Text = "N/A";
		this.lblSource.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
		this.cbDrives.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbDrives.Enabled = false;
		this.cbDrives.FormattingEnabled = true;
		this.cbDrives.Location = new global::System.Drawing.Point(15, 19);
		this.cbDrives.Name = "cbDrives";
		this.cbDrives.Size = new global::System.Drawing.Size(78, 21);
		this.cbDrives.TabIndex = 3;
		this.cbDrives.SelectedIndexChanged += new global::System.EventHandler(this.cbDrives_SelectedIndexChanged);
		this.groupBox2.Controls.Add(this.lblTarget);
		this.groupBox2.Controls.Add(this.btnBrowser);
		this.groupBox2.Location = new global::System.Drawing.Point(128, 12);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new global::System.Drawing.Size(166, 68);
		this.groupBox2.TabIndex = 7;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "To:";
		this.lblTarget.Location = new global::System.Drawing.Point(6, 43);
		this.lblTarget.Name = "lblTarget";
		this.lblTarget.Size = new global::System.Drawing.Size(154, 19);
		this.lblTarget.TabIndex = 6;
		this.lblTarget.Text = "N/A";
		this.lblTarget.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
		this.btnBrowser.Enabled = false;
		this.btnBrowser.Location = new global::System.Drawing.Point(36, 18);
		this.btnBrowser.Name = "btnBrowser";
		this.btnBrowser.Size = new global::System.Drawing.Size(89, 21);
		this.btnBrowser.TabIndex = 5;
		this.btnBrowser.Text = "Locate Folder";
		this.btnBrowser.UseVisualStyleBackColor = true;
		this.btnBrowser.Click += new global::System.EventHandler(this.btnBrowser_Click);
		this.btnOk.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.btnOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
		this.btnOk.Enabled = false;
		this.btnOk.Location = new global::System.Drawing.Point(219, 105);
		this.btnOk.Name = "btnOk";
		this.btnOk.Size = new global::System.Drawing.Size(75, 23);
		this.btnOk.TabIndex = 8;
		this.btnOk.Text = "Start";
		this.btnOk.UseVisualStyleBackColor = true;
		this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
		this.btnCancel.Location = new global::System.Drawing.Point(138, 105);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
		this.btnCancel.TabIndex = 9;
		this.btnCancel.Text = "Cancel";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.cbAddToList.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
		this.cbAddToList.AutoSize = true;
		this.cbAddToList.Checked = true;
		this.cbAddToList.CheckState = global::System.Windows.Forms.CheckState.Checked;
		this.cbAddToList.Location = new global::System.Drawing.Point(12, 109);
		this.cbAddToList.Name = "cbAddToList";
		this.cbAddToList.Size = new global::System.Drawing.Size(72, 17);
		this.cbAddToList.TabIndex = 10;
		this.cbAddToList.Text = "Add to list";
		this.cbAddToList.UseVisualStyleBackColor = true;
		this.timer_0.Interval = 500;
		this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
		this.cbAllFiles.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
		this.cbAllFiles.AutoSize = true;
		this.cbAllFiles.Checked = true;
		this.cbAllFiles.CheckState = global::System.Windows.Forms.CheckState.Checked;
		this.cbAllFiles.Location = new global::System.Drawing.Point(12, 90);
		this.cbAllFiles.Name = "cbAllFiles";
		this.cbAllFiles.Size = new global::System.Drawing.Size(84, 17);
		this.cbAllFiles.TabIndex = 11;
		this.cbAllFiles.Text = "Copy all files";
		this.cbAllFiles.UseVisualStyleBackColor = true;
		this.cbAllFiles.CheckedChanged += new global::System.EventHandler(this.cbAllFiles_CheckedChanged);
		base.AcceptButton = this.btnOk;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.btnCancel;
		base.ClientSize = new global::System.Drawing.Size(307, 140);
		base.ControlBox = false;
		base.Controls.Add(this.cbAllFiles);
		base.Controls.Add(this.cbAddToList);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnOk);
		base.Controls.Add(this.groupBox2);
		base.Controls.Add(this.groupBox1);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Name = "ArkCopyDialog";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Copy Archive";
		this.groupBox1.ResumeLayout(false);
		this.groupBox2.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	global::System.ComponentModel.IContainer icontainer_0;

	global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_0;

	global::System.Windows.Forms.GroupBox groupBox1;

	global::System.Windows.Forms.Label lblSource;

	global::System.Windows.Forms.ComboBox cbDrives;

	global::System.Windows.Forms.GroupBox groupBox2;

	global::System.Windows.Forms.Button btnBrowser;

	global::System.Windows.Forms.Label lblTarget;

	global::System.Windows.Forms.Button btnOk;

	global::System.Windows.Forms.Button btnCancel;

	global::System.Windows.Forms.CheckBox cbAddToList;

	global::System.Windows.Forms.Timer timer_0;

	global::System.Windows.Forms.CheckBox cbAllFiles;
}
