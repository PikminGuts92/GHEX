using System;
using System.Drawing;
using System.Windows.Forms;

public class GClass50 : GClass45
{
	public GClass50()
	{
		base.method_7(new TextBox
		{
			AutoSize = false,
			BorderStyle = BorderStyle.None
		});
	}

	protected override void vmethod_0(Rectangle rectangle_1)
	{
		this.method_12().Location = rectangle_1.Location;
		this.method_12().Size = new Size(rectangle_1.Width - 1, rectangle_1.Height - 1);
	}

	protected override void vmethod_1()
	{
		this.method_12().Text = base.method_8().method_5();
	}

	protected override void vmethod_2()
	{
		base.method_8().method_6(this.method_12().Text);
	}

	public override void imethod_1()
	{
		this.method_12().KeyPress += this.vmethod_9;
		this.method_12().LostFocus += this.vmethod_10;
		base.imethod_1();
		this.method_12().Focus();
	}

	public override void imethod_2()
	{
		this.method_12().KeyPress -= this.vmethod_9;
		this.method_12().LostFocus -= this.vmethod_10;
		base.imethod_2();
	}

	public override void imethod_3()
	{
		this.method_12().KeyPress -= this.vmethod_9;
		this.method_12().LostFocus -= this.vmethod_10;
		base.imethod_3();
	}

	public TextBox method_12()
	{
		return base.method_6() as TextBox;
	}

	protected virtual void vmethod_9(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == GClass68.char_13)
		{
			if (base.method_9() != null)
			{
				base.method_9().method_122();
				return;
			}
		}
		else if (e.KeyChar == GClass68.char_27 && base.method_9() != null)
		{
			base.method_9().method_123();
		}
	}

	protected virtual void vmethod_10(object sender, EventArgs e)
	{
		if (base.method_9() != null)
		{
			base.method_9().method_122();
		}
	}
}
