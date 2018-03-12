using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GClass14 : GClass13
{
	public GClass14()
	{
		this.color_0 = Color.FromArgb(200, 209, 215);
		this.color_1 = Color.FromArgb(239, 239, 239);
		this.color_2 = Color.Empty;
	}

	public Color method_12()
	{
		return this.color_0;
	}

	public void method_13(Color color_3)
	{
		if (this.color_0 != color_3)
		{
			this.color_0 = color_3;
		}
	}

	public Color method_14()
	{
		return this.color_1;
	}

	public void method_15(Color color_3)
	{
		if (this.color_1 != color_3)
		{
			this.color_1 = color_3;
		}
	}

	public Color method_16()
	{
		return this.color_2;
	}

	public void method_17(Color color_3)
	{
		if (this.color_2 != color_3)
		{
			this.color_2 = color_3;
		}
	}

	protected override void vmethod_0(GEventArgs7 geventArgs7_0)
	{
		base.vmethod_0(geventArgs7_0);
		if (geventArgs7_0.method_0() != null)
		{
			if (geventArgs7_0.method_0().method_16() == GEnum62.const_2)
			{
				Color color = this.method_16();
				if (color == Color.Empty)
				{
					color = ControlPaint.Light(this.color_0);
				}
				using (SolidBrush solidBrush = new SolidBrush(color))
				{
					geventArgs7_0.Graphics.FillRectangle(solidBrush, geventArgs7_0.method_8());
				}
				using (Pen pen = new Pen(this.method_12()))
				{
					geventArgs7_0.Graphics.DrawRectangle(pen, geventArgs7_0.method_8().X, geventArgs7_0.method_8().Y, geventArgs7_0.method_8().Width - 1, geventArgs7_0.method_8().Height - 1);
					return;
				}
			}
		}
		using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(geventArgs7_0.method_8(), this.method_12(), this.method_14(), LinearGradientMode.Vertical))
		{
			geventArgs7_0.Graphics.FillRectangle(linearGradientBrush, geventArgs7_0.method_8());
		}
		using (Pen pen2 = new Pen(this.method_14()))
		{
			geventArgs7_0.Graphics.DrawLine(pen2, geventArgs7_0.method_8().Left, geventArgs7_0.method_8().Top, geventArgs7_0.method_8().Right - 2, geventArgs7_0.method_8().Top);
			geventArgs7_0.Graphics.DrawLine(pen2, geventArgs7_0.method_8().Left, geventArgs7_0.method_8().Top, geventArgs7_0.method_8().Left, geventArgs7_0.method_8().Bottom - 1);
		}
		using (Pen pen3 = new Pen(this.method_12()))
		{
			geventArgs7_0.Graphics.DrawLine(pen3, geventArgs7_0.method_8().Right - 1, geventArgs7_0.method_8().Top, geventArgs7_0.method_8().Right - 1, geventArgs7_0.method_8().Bottom - 1);
			geventArgs7_0.Graphics.DrawLine(pen3, geventArgs7_0.method_8().Left + 1, geventArgs7_0.method_8().Bottom - 1, geventArgs7_0.method_8().Right - 1, geventArgs7_0.method_8().Bottom - 1);
		}
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
			if (geventArgs7_0.method_0().method_16() == GEnum62.const_2)
			{
				rectangle_.X++;
				rectangle_.Y++;
			}
			base.method_11(geventArgs7_0.Graphics, geventArgs7_0.method_0().method_12(), rectangle_, geventArgs7_0.method_0().method_31());
		}
		if (geventArgs7_0.method_0().method_16() == GEnum62.const_2)
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
				geventArgs7_0.Graphics.DrawString(geventArgs7_0.method_0().method_5(), base.GInterface1.imethod_3(), base.method_3(), r, base.method_4());
				return;
			}
			using (SolidBrush solidBrush = new SolidBrush(SystemPens.GrayText.Color))
			{
				geventArgs7_0.Graphics.DrawString(geventArgs7_0.method_0().method_5(), base.GInterface1.imethod_3(), solidBrush, r, base.method_4());
			}
		}
	}

	Color color_0;

	Color color_1;

	Color color_2;
}
