using System;
using System.Drawing;
using System.Windows.Forms;

public class GClass16 : GClass13
{
	protected override void vmethod_0(GEventArgs7 geventArgs7_0)
	{
		base.vmethod_0(geventArgs7_0);
		if (geventArgs7_0.method_0() == null)
		{
			GClass69.smethod_7(geventArgs7_0.Graphics, geventArgs7_0.method_8(), GEnum12.const_0);
			return;
		}
		GClass69.smethod_7(geventArgs7_0.Graphics, geventArgs7_0.method_8(), (GEnum12)geventArgs7_0.method_0().method_16());
	}

	protected override void vmethod_1(GEventArgs7 geventArgs7_0)
	{
		base.vmethod_1(geventArgs7_0);
		if (geventArgs7_0.method_0() == null)
		{
			return;
		}
		Rectangle r = this.imethod_0();
		Rectangle rectangle_ = Rectangle.Empty;
		if (geventArgs7_0.method_0().method_12() != null)
		{
			rectangle_ = base.method_9();
			r.Width -= rectangle_.Width;
			r.X += rectangle_.Width;
			if (geventArgs7_0.method_0().method_14())
			{
				rectangle_.X = this.imethod_0().Right - rectangle_.Width;
				r.X = this.imethod_0().X;
			}
			if (!GClass69.smethod_29() && geventArgs7_0.method_0().method_16() == GEnum62.const_2)
			{
				rectangle_.X++;
				rectangle_.Y++;
			}
			base.method_11(geventArgs7_0.Graphics, geventArgs7_0.method_0().method_12(), rectangle_, geventArgs7_0.method_0().method_31());
		}
		if (!GClass69.smethod_29() && geventArgs7_0.method_0().method_16() == GEnum62.const_2)
		{
			r.X++;
			r.Y++;
		}
		if (geventArgs7_0.method_0().method_27() != SortOrder.None)
		{
			Rectangle rectangle_2 = base.method_10();
			rectangle_2.X = r.Right - rectangle_2.Width;
			r.Width -= rectangle_2.Width;
			this.vmethod_2(geventArgs7_0.Graphics, rectangle_2, geventArgs7_0.method_0().method_27(), geventArgs7_0.method_0().method_31());
		}
		if (geventArgs7_0.method_0().method_5() == null)
		{
			return;
		}
		if (geventArgs7_0.method_0().method_5().Length > 0 && r.Width > 0)
		{
			if (geventArgs7_0.method_0().method_31())
			{
				geventArgs7_0.Graphics.DrawString(geventArgs7_0.method_0().method_5(), base.imethod_3(), base.method_3(), r, base.method_4());
				return;
			}
			using (SolidBrush solidBrush = new SolidBrush(SystemPens.GrayText.Color))
			{
				geventArgs7_0.Graphics.DrawString(geventArgs7_0.method_0().method_5(), base.imethod_3(), solidBrush, r, base.method_4());
			}
		}
	}
}
