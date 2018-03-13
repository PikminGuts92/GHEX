using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public partial class BugReportDialog : Form
{
	public BugReportDialog()
	{
		this.InitializeComponent();
		this.MinimumSize = base.Size;
		this.MaximumSize = new Size(base.Size.Width * 2, base.Size.Height * 2);
	}

	void btnReport_Click(object sender, EventArgs e)
	{
		BugReportDialog.Class28 @class = new BugReportDialog.Class28();
		@class.string_0 = this.textBox1.Text.Trim();
		if (@class.string_0.Length == 0)
		{
			MessageBox.Show("Empty report not sent", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		ProgressDialog progressDialog = new ProgressDialog(new ProgressDialog.GDelegate6(@class.method_0));
		progressDialog.ShowDialog();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	IContainer icontainer_0;

	[CompilerGenerated]
	sealed class Class28
	{
		public void method_0(ref ProgressDialog.GClass73 gclass73_0)
		{
			ExceptionDialog.smethod_2("Bug Report", "=== User-supplied message ===" + ExceptionDialog.smethod_1() + ExceptionDialog.smethod_1() + this.string_0, ref gclass73_0);
		}

		public string string_0;
	}
}
