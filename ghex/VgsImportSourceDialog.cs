using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public partial class VgsImportSourceDialog : Form
{
	public VgsImportSourceDialog()
	{
		this.InitializeComponent();
	}

	public void method_0(bool bool_0)
	{
		this.nudOffset.Enabled = bool_0;
	}

	public bool method_1()
	{
		return this.nudOffset.Enabled;
	}

	public int method_2()
	{
		return (int)this.nudOffset.Value;
	}

	public void method_3(int int_0)
	{
		this.nudOffset.Value = int_0;
	}

	public float method_4()
	{
		return (float)this.nudVolume.Value / 100f;
	}

	public void method_5(float float_0)
	{
		this.nudVolume.Value = (int)(float_0 * 100f);
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
