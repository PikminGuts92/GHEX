public partial class BatchExportChooseTracksDialog : global::System.Windows.Forms.Form
{
	void InitializeComponent()
	{
		this.cbTrack1 = new global::System.Windows.Forms.ComboBox();
		this.cbTrack2 = new global::System.Windows.Forms.ComboBox();
		this.btnOk = new global::System.Windows.Forms.Button();
		this.btnCancel = new global::System.Windows.Forms.Button();
		base.SuspendLayout();
		this.cbTrack1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbTrack1.FormattingEnabled = true;
		this.cbTrack1.Location = new global::System.Drawing.Point(12, 12);
		this.cbTrack1.Name = "cbTrack1";
		this.cbTrack1.Size = new global::System.Drawing.Size(109, 21);
		this.cbTrack1.TabIndex = 0;
		this.cbTrack1.SelectedIndexChanged += new global::System.EventHandler(this.cbTrack1_SelectedIndexChanged);
		this.cbTrack2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbTrack2.FormattingEnabled = true;
		this.cbTrack2.Location = new global::System.Drawing.Point(127, 12);
		this.cbTrack2.Name = "cbTrack2";
		this.cbTrack2.Size = new global::System.Drawing.Size(109, 21);
		this.cbTrack2.TabIndex = 1;
		this.cbTrack2.SelectedIndexChanged += new global::System.EventHandler(this.cbTrack2_SelectedIndexChanged);
		this.btnOk.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.btnOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
		this.btnOk.Location = new global::System.Drawing.Point(162, 43);
		this.btnOk.Name = "btnOk";
		this.btnOk.Size = new global::System.Drawing.Size(75, 23);
		this.btnOk.TabIndex = 2;
		this.btnOk.Text = "OK";
		this.btnOk.UseVisualStyleBackColor = true;
		this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
		this.btnCancel.Location = new global::System.Drawing.Point(81, 43);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
		this.btnCancel.TabIndex = 3;
		this.btnCancel.Text = "Cancel";
		this.btnCancel.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnOk;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.btnCancel;
		base.ClientSize = new global::System.Drawing.Size(249, 78);
		base.ControlBox = false;
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnOk);
		base.Controls.Add(this.cbTrack2);
		base.Controls.Add(this.cbTrack1);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
		base.Name = "BatchExportChooseTracksDialog";
		base.ShowInTaskbar = false;
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Choose Tracks";
		base.TopMost = true;
		base.ResumeLayout(false);
	}

	global::System.Windows.Forms.ComboBox cbTrack1;

	global::System.Windows.Forms.ComboBox cbTrack2;

	global::System.Windows.Forms.Button btnOk;

	global::System.Windows.Forms.Button btnCancel;
}
