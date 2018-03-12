public partial class ArkRelinkDialog : global::System.Windows.Forms.Form
{
	void InitializeComponent()
	{
		this.panel1 = new global::System.Windows.Forms.Panel();
		this.cbSwap = new global::System.Windows.Forms.CheckBox();
		this.btnOk = new global::System.Windows.Forms.Button();
		this.btnCancel = new global::System.Windows.Forms.Button();
		this.tvFiles = new global::System.Windows.Forms.TreeView();
		this.panel1.SuspendLayout();
		base.SuspendLayout();
		this.panel1.Controls.Add(this.cbSwap);
		this.panel1.Controls.Add(this.btnOk);
		this.panel1.Controls.Add(this.btnCancel);
		this.panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
		this.panel1.Location = new global::System.Drawing.Point(0, 223);
		this.panel1.Name = "panel1";
		this.panel1.Size = new global::System.Drawing.Size(291, 135);
		this.panel1.TabIndex = 0;
		this.cbSwap.AutoSize = true;
		this.cbSwap.Checked = true;
		this.cbSwap.CheckState = global::System.Windows.Forms.CheckState.Checked;
		this.cbSwap.Location = new global::System.Drawing.Point(12, 6);
		this.cbSwap.Name = "cbSwap";
		this.cbSwap.Size = new global::System.Drawing.Size(74, 17);
		this.cbSwap.TabIndex = 2;
		this.cbSwap.Text = "Swap files";
		this.cbSwap.UseVisualStyleBackColor = true;
		this.cbSwap.CheckedChanged += new global::System.EventHandler(this.cbSwap_CheckedChanged);
		this.btnOk.Location = new global::System.Drawing.Point(132, 109);
		this.btnOk.Name = "btnOk";
		this.btnOk.Size = new global::System.Drawing.Size(75, 23);
		this.btnOk.TabIndex = 1;
		this.btnOk.Text = "Ok";
		this.btnOk.UseVisualStyleBackColor = true;
		this.btnOk.Click += new global::System.EventHandler(this.btnOk_Click);
		this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
		this.btnCancel.Location = new global::System.Drawing.Point(213, 109);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
		this.btnCancel.TabIndex = 0;
		this.btnCancel.Text = "Cancel";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.tvFiles.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.tvFiles.HideSelection = false;
		this.tvFiles.Location = new global::System.Drawing.Point(0, 0);
		this.tvFiles.Name = "tvFiles";
		this.tvFiles.PathSeparator = "/";
		this.tvFiles.Size = new global::System.Drawing.Size(291, 223);
		this.tvFiles.TabIndex = 1;
		this.tvFiles.DoubleClick += new global::System.EventHandler(this.tvFiles_DoubleClick);
		this.tvFiles.AfterSelect += new global::System.Windows.Forms.TreeViewEventHandler(this.tvFiles_AfterSelect);
		base.AcceptButton = this.btnOk;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.btnCancel;
		base.ClientSize = new global::System.Drawing.Size(291, 358);
		base.Controls.Add(this.tvFiles);
		base.Controls.Add(this.panel1);
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "ArkRelinkDialog";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Re-link";
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		base.ResumeLayout(false);
	}

	global::System.Windows.Forms.Panel panel1;

	global::System.Windows.Forms.Button btnOk;

	global::System.Windows.Forms.Button btnCancel;

	global::System.Windows.Forms.TreeView tvFiles;

	global::System.Windows.Forms.CheckBox cbSwap;
}
