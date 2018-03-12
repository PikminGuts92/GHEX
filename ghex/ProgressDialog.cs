using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

public partial class ProgressDialog : Form
{
	public ProgressDialog(ProgressDialog.GDelegate6 gdelegate6_1)
	{
		this.InitializeComponent();
		this.gclass73_0 = new ProgressDialog.GClass73();
		this.gdelegate6_0 = gdelegate6_1;
	}

	void timer_0_Tick(object sender, EventArgs e)
	{
		if (!this.thread_0.IsAlive)
		{
			this.timer_0.Enabled = false;
			base.Close();
			return;
		}
		lock (this.gclass73_0)
		{
			if (this.gclass73_0.string_0 != null)
			{
				this.Text = this.gclass73_0.string_0;
			}
			else
			{
				this.Text = "Progress";
			}
			if (this.gclass73_0.string_1 != null)
			{
				this.label1.Text = this.gclass73_0.string_1;
			}
			else
			{
				this.label1.Text = "";
			}
			if (this.gclass73_0.string_2 != null)
			{
				this.label2.Text = this.gclass73_0.string_2;
			}
			else
			{
				this.label2.Text = "";
			}
			if (this.gclass73_0.int_0 != -1)
			{
				this.progressBar1.Style = ProgressBarStyle.Blocks;
				this.progressBar1.Value = Math.Min(this.gclass73_0.int_0, this.progressBar1.Maximum);
			}
			else
			{
				this.progressBar1.Style = ProgressBarStyle.Marquee;
			}
			if (this.gclass73_0.int_1 != -1)
			{
				this.progressBar2.Style = ProgressBarStyle.Blocks;
				this.progressBar2.Value = Math.Min(this.gclass73_0.int_1, this.progressBar2.Maximum);
			}
			else
			{
				this.progressBar2.Style = ProgressBarStyle.Marquee;
			}
		}
	}

	void ProgressDialog_Shown(object sender, EventArgs e)
	{
		this.timer_0.Enabled = true;
		this.thread_0 = new Thread(new ParameterizedThreadStart(this.method_0));
		this.thread_0.Start();
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	[CompilerGenerated]
	void method_0(object object_0)
	{
		this.gdelegate6_0(ref this.gclass73_0);
	}

	Thread thread_0;

	ProgressDialog.GDelegate6 gdelegate6_0;

	ProgressDialog.GClass73 gclass73_0;

	public class GClass73
	{
		public string string_0;

		public string string_1;

		public string string_2;

		public int int_0 = -1;

		public int int_1 = -1;
	}

	public delegate void GDelegate6(ref ProgressDialog.GClass73 gclass73_0);
}
