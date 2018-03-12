using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public partial class BatchExportChooseTracksDialog : Form
{
	public BatchExportChooseTracksDialog(GClass120 gclass120_1, string[] string_0)
	{
		this.InitializeComponent();
		this.gclass120_0 = gclass120_1;
		this.bool_0 = true;
		MidPreview.smethod_0(gclass120_1, this.cbTrack1, string_0[1]);
		MidPreview.smethod_0(gclass120_1, this.cbTrack2, string_0[0]);
		this.bool_0 = false;
	}

	public void method_0(bool bool_1)
	{
		this.cbTrack1.Enabled = true;
		this.cbTrack2.Enabled = bool_1;
		this.cbTrack2.Visible = bool_1;
	}

	public string[] method_1()
	{
		return new string[]
		{
			this.cbTrack1.SelectedItem.ToString(),
			this.cbTrack2.Enabled ? this.cbTrack2.SelectedItem.ToString() : null
		};
	}

	void cbTrack1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.bool_0)
		{
			return;
		}
		MidPreview.smethod_0(this.gclass120_0, this.cbTrack2, this.cbTrack1.SelectedItem.ToString());
		this.cbTrack2.SelectedIndex = 0;
	}

	void cbTrack2_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	GClass120 gclass120_0;

	bool bool_0;

	IContainer icontainer_0;
}
