using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public partial class AboutDialog : Form
{
	public AboutDialog()
	{
		this.InitializeComponent();
		string text = (Application.OpenForms["MainWindow"] as MainWindow).method_22();
		if (text != null)
		{
			this.linkLabel1.Text = text;
			this.linkLabel1.LinkArea = new LinkArea(0, text.Length);
		}
		this.lName.Text = this.lName.Text.Replace("<version>", Application.ProductVersion);
	}

	void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		(Application.OpenForms["MainWindow"] as MainWindow).method_23();
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}
}
