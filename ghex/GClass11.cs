using System;
using System.Windows.Forms;

public class GClass11 : GClass2
{
	protected override void vmethod_1(GEventArgs8 geventArgs8_0)
	{
		base.vmethod_1(geventArgs8_0);
		if (geventArgs8_0.method_0() == null)
		{
			return;
		}
		string text = geventArgs8_0.method_0().method_5();
		if (text != null && text.Length != 0)
		{
			if (geventArgs8_0.method_16())
			{
				geventArgs8_0.Graphics.DrawString(text, base.GInterface1.imethod_3(), base.method_3(), this.imethod_0(), base.method_4());
			}
			else
			{
				geventArgs8_0.Graphics.DrawString(text, base.GInterface1.imethod_3(), base.method_13(), this.imethod_0(), base.method_4());
			}
		}
		if (geventArgs8_0.method_10() && geventArgs8_0.method_16())
		{
			ControlPaint.DrawFocusRectangle(geventArgs8_0.Graphics, this.imethod_0());
		}
	}
}
