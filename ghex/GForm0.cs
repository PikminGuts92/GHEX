using System;
using System.ComponentModel;
using System.Windows.Forms;

[ToolboxItem(false)]
public partial class GForm0 : Form
{
	public GForm0(GClass46 gclass46_1)
	{
		if (gclass46_1 == null)
		{
			throw new ArgumentNullException("editor", "DropDownCellEditor cannot be null");
		}
		this.gclass46_0 = gclass46_1;
		base.ControlBox = false;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.FormBorderStyle = FormBorderStyle.None;
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.Manual;
		base.TabStop = false;
		base.TopMost = true;
		this.control_0 = null;
		this.panel_0 = new Panel();
		this.panel_0.AutoScroll = false;
		this.panel_0.BorderStyle = BorderStyle.FixedSingle;
		this.panel_0.Size = base.Size;
		base.Controls.Add(this.panel_0);
		base.SizeChanged += this.GForm0_SizeChanged;
	}

	public void method_0()
	{
		this.method_2();
		base.Show();
	}

	public void method_1()
	{
		this.method_2();
		base.Hide();
	}

	void method_2()
	{
		Struct1 @struct = default(Struct1);
		while (Class96.PeekMessage(ref @struct, IntPtr.Zero, 15, 15, 1))
		{
			Class96.TranslateMessage(ref @struct);
			Class96.DispatchMessage(ref @struct);
		}
	}

	public Control method_3()
	{
		return this.control_0;
	}

	public void method_4(Control control_1)
	{
		if (control_1 != this.control_0)
		{
			this.panel_0.Controls.Clear();
			this.control_0 = control_1;
			if (control_1 != null)
			{
				this.panel_0.Controls.Add(control_1);
			}
		}
	}

	protected virtual CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = base.CreateParams;
			createParams.ExStyle |= 128;
			if (Environment.OSVersion.Platform != PlatformID.Win32NT || Environment.OSVersion.Version.Major > 5)
			{
				createParams.ExStyle |= 134217728;
			}
			createParams.ClassStyle |= 2048;
			return createParams;
		}
	}

	void GForm0_SizeChanged(object sender, EventArgs e)
	{
		this.panel_0.Size = base.Size;
	}

	GClass46 gclass46_0;

	Control control_0;

	Panel panel_0;
}
