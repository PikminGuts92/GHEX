using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public partial class ArkShrinkDialog : Form
{
	public ArkShrinkDialog()
	{
		this.InitializeComponent();
		this.cbMenuMusic_CheckedChanged(null, null);
	}

	public bool method_0()
	{
		return this.cbTutorials.Checked;
	}

	public bool method_1()
	{
		return this.cbMenuMusic.Checked;
	}

	public bool method_2()
	{
		return this.cbSongs.Checked;
	}

	public int method_3()
	{
		return (int)this.nudSongLength.Value;
	}

	void cbMenuMusic_CheckedChanged(object sender, EventArgs e)
	{
		this.nudSongLength.Enabled = this.cbSongs.Checked;
		this.btnOk.Enabled = (this.cbSongs.Checked || this.cbMenuMusic.Checked || this.cbTutorials.Checked);
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
}
