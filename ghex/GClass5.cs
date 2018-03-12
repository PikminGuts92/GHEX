using System;
using System.Drawing;
using System.Windows.Forms;

public class GClass5 : GClass3
{
	protected override void vmethod_1(GEventArgs8 geventArgs8_0)
	{
		base.vmethod_1(geventArgs8_0);
		if (geventArgs8_0.method_0() == null)
		{
			return;
		}
		Rectangle rectangle = base.method_16();
		Rectangle r = this.imethod_0();
		if (base.method_20())
		{
			r.Width -= rectangle.Width - 1;
		}
		if (geventArgs8_0.method_0().method_5() != null && geventArgs8_0.method_0().method_5().Length != 0)
		{
			if (geventArgs8_0.method_16())
			{
				geventArgs8_0.Graphics.DrawString(geventArgs8_0.method_0().method_5(), base.imethod_3(), base.method_3(), r, base.method_4());
			}
			else
			{
				geventArgs8_0.Graphics.DrawString(geventArgs8_0.method_0().method_5(), base.imethod_3(), base.method_13(), r, base.method_4());
			}
		}
		if (geventArgs8_0.method_10() && geventArgs8_0.method_16())
		{
			Rectangle rectangle2 = this.imethod_0();
			if (base.method_20())
			{
				rectangle2.Width -= rectangle.Width;
			}
			ControlPaint.DrawFocusRectangle(geventArgs8_0.Graphics, rectangle2);
		}
	}
}
