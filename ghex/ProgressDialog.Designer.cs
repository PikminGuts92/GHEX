public partial class ProgressDialog : global::System.Windows.Forms.Form
{
	void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		this.label1 = new global::System.Windows.Forms.Label();
		this.label2 = new global::System.Windows.Forms.Label();
		this.progressBar1 = new global::System.Windows.Forms.ProgressBar();
		this.progressBar2 = new global::System.Windows.Forms.ProgressBar();
		this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		base.SuspendLayout();
		this.label1.AutoEllipsis = true;
		this.label1.Location = new global::System.Drawing.Point(12, 9);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(307, 15);
		this.label1.TabIndex = 0;
		this.label2.Location = new global::System.Drawing.Point(12, 60);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(307, 15);
		this.label2.TabIndex = 1;
		this.progressBar1.Location = new global::System.Drawing.Point(12, 27);
		this.progressBar1.Name = "progressBar1";
		this.progressBar1.Size = new global::System.Drawing.Size(307, 17);
		this.progressBar1.Style = global::System.Windows.Forms.ProgressBarStyle.Continuous;
		this.progressBar1.TabIndex = 2;
		this.progressBar2.Location = new global::System.Drawing.Point(12, 78);
		this.progressBar2.Name = "progressBar2";
		this.progressBar2.Size = new global::System.Drawing.Size(307, 17);
		this.progressBar2.Style = global::System.Windows.Forms.ProgressBarStyle.Continuous;
		this.progressBar2.TabIndex = 3;
		this.timer_0.Interval = 250;
		this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(331, 125);
		base.ControlBox = false;
		base.Controls.Add(this.progressBar2);
		base.Controls.Add(this.progressBar1);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
		base.Name = "ProgressDialog";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
		this.Text = "Progress";
		base.Shown += new global::System.EventHandler(this.ProgressDialog_Shown);
		base.ResumeLayout(false);
	}

	global::System.ComponentModel.IContainer icontainer_0;

	global::System.Windows.Forms.Label label1;

	global::System.Windows.Forms.Label label2;

	global::System.Windows.Forms.ProgressBar progressBar1;

	global::System.Windows.Forms.ProgressBar progressBar2;

	global::System.Windows.Forms.Timer timer_0;
}
