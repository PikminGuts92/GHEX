public partial class BatchExportMidiDialog : global::System.Windows.Forms.Form
{
	void InitializeComponent()
	{
		this.btnExport = new global::System.Windows.Forms.Button();
		this.btnCancel = new global::System.Windows.Forms.Button();
		this.cbCoop = new global::System.Windows.Forms.CheckBox();
		this.tbFormat = new global::System.Windows.Forms.TextBox();
		this.label1 = new global::System.Windows.Forms.Label();
		this.cbDifficulty = new global::System.Windows.Forms.ComboBox();
		this.cbAllDifficulties = new global::System.Windows.Forms.CheckBox();
		this.cbLefty = new global::System.Windows.Forms.CheckBox();
		base.SuspendLayout();
		this.btnExport.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.btnExport.DialogResult = global::System.Windows.Forms.DialogResult.OK;
		this.btnExport.Location = new global::System.Drawing.Point(106, 165);
		this.btnExport.Name = "btnExport";
		this.btnExport.Size = new global::System.Drawing.Size(75, 23);
		this.btnExport.TabIndex = 4;
		this.btnExport.Text = "Export";
		this.btnExport.UseVisualStyleBackColor = true;
		this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
		this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
		this.btnCancel.Location = new global::System.Drawing.Point(25, 165);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
		this.btnCancel.TabIndex = 5;
		this.btnCancel.Text = "Cancel";
		this.btnCancel.UseVisualStyleBackColor = true;
		this.cbCoop.AutoSize = true;
		this.cbCoop.Location = new global::System.Drawing.Point(12, 101);
		this.cbCoop.Name = "cbCoop";
		this.cbCoop.Size = new global::System.Drawing.Size(80, 17);
		this.cbCoop.TabIndex = 1;
		this.cbCoop.Text = "Both tracks";
		this.cbCoop.UseVisualStyleBackColor = true;
		this.tbFormat.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.tbFormat.Location = new global::System.Drawing.Point(12, 12);
		this.tbFormat.Name = "tbFormat";
		this.tbFormat.Size = new global::System.Drawing.Size(169, 20);
		this.tbFormat.TabIndex = 0;
		this.tbFormat.Text = "%n_%1_%d";
		this.label1.AutoSize = true;
		this.label1.Location = new global::System.Drawing.Point(12, 35);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(110, 52);
		this.label1.TabIndex = 4;
		this.label1.Text = "%n - Short song name\r\n%d - Difficulty name\r\n%1 - Track 1 name\r\n%2 - Track 2 name";
		this.cbDifficulty.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
		this.cbDifficulty.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbDifficulty.FormattingEnabled = true;
		this.cbDifficulty.Items.AddRange(new object[]
		{
			"Easy",
			"Medium",
			"Hard",
			"Expert"
		});
		this.cbDifficulty.Location = new global::System.Drawing.Point(101, 113);
		this.cbDifficulty.Name = "cbDifficulty";
		this.cbDifficulty.Size = new global::System.Drawing.Size(80, 21);
		this.cbDifficulty.TabIndex = 3;
		this.cbAllDifficulties.AutoSize = true;
		this.cbAllDifficulties.Location = new global::System.Drawing.Point(12, 115);
		this.cbAllDifficulties.Name = "cbAllDifficulties";
		this.cbAllDifficulties.Size = new global::System.Drawing.Size(86, 17);
		this.cbAllDifficulties.TabIndex = 2;
		this.cbAllDifficulties.Text = "All difficulties";
		this.cbAllDifficulties.UseVisualStyleBackColor = true;
		this.cbAllDifficulties.CheckedChanged += new global::System.EventHandler(this.cbAllDifficulties_CheckedChanged);
		this.cbLefty.AutoSize = true;
		this.cbLefty.Location = new global::System.Drawing.Point(12, 129);
		this.cbLefty.Name = "cbLefty";
		this.cbLefty.Size = new global::System.Drawing.Size(65, 17);
		this.cbLefty.TabIndex = 6;
		this.cbLefty.Text = "Lefty flip";
		this.cbLefty.UseVisualStyleBackColor = true;
		base.AcceptButton = this.btnExport;
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.CancelButton = this.btnCancel;
		base.ClientSize = new global::System.Drawing.Size(193, 200);
		base.ControlBox = false;
		base.Controls.Add(this.cbLefty);
		base.Controls.Add(this.cbAllDifficulties);
		base.Controls.Add(this.cbDifficulty);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.tbFormat);
		base.Controls.Add(this.cbCoop);
		base.Controls.Add(this.btnCancel);
		base.Controls.Add(this.btnExport);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "BatchExportMidiDialog";
		base.ShowInTaskbar = false;
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Batch Export";
		base.TopMost = true;
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	global::System.Windows.Forms.Button btnExport;

	global::System.Windows.Forms.Button btnCancel;

	global::System.Windows.Forms.CheckBox cbCoop;

	global::System.Windows.Forms.TextBox tbFormat;

	global::System.Windows.Forms.Label label1;

	global::System.Windows.Forms.ComboBox cbDifficulty;

	global::System.Windows.Forms.CheckBox cbAllDifficulties;

	global::System.Windows.Forms.CheckBox cbLefty;
}
