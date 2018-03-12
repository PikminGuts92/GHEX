using System;
using System.Drawing;
using System.Windows.Forms;

public class GClass10 : GClass2
{
	public GClass10()
	{
		this.contentAlignment_0 = ContentAlignment.MiddleCenter;
	}

	protected GClass76 method_16(GClass97 gclass97_0)
	{
		object obj = base.method_9(gclass97_0);
		if (obj == null || !(obj is GClass76))
		{
			obj = new GClass76();
			base.method_10(gclass97_0, obj);
		}
		return (GClass76)obj;
	}

	protected virtual Rectangle vmethod_3()
	{
		return this.imethod_0();
	}

	protected Rectangle method_17(Image image_0, ContentAlignment contentAlignment_1)
	{
		Rectangle result = new Rectangle(this.imethod_0().X, this.imethod_0().Y, image_0.Width, image_0.Height);
		if (contentAlignment_1 <= ContentAlignment.MiddleCenter)
		{
			switch (contentAlignment_1)
			{
			case ContentAlignment.TopCenter:
				break;
			case (ContentAlignment)3:
				goto IL_AD;
			case ContentAlignment.TopRight:
				goto IL_90;
			default:
				if (contentAlignment_1 != ContentAlignment.MiddleCenter)
				{
					goto IL_AD;
				}
				break;
			}
		}
		else
		{
			if (contentAlignment_1 == ContentAlignment.MiddleRight)
			{
				goto IL_90;
			}
			if (contentAlignment_1 != ContentAlignment.BottomCenter)
			{
				if (contentAlignment_1 != ContentAlignment.BottomRight)
				{
					goto IL_AD;
				}
				goto IL_90;
			}
		}
		result.X += (this.imethod_0().Width - image_0.Width) / 2;
		goto IL_AD;
		IL_90:
		result.X = this.imethod_0().Right - image_0.Width;
		IL_AD:
		if (contentAlignment_1 > ContentAlignment.MiddleCenter)
		{
			if (contentAlignment_1 <= ContentAlignment.BottomLeft)
			{
				if (contentAlignment_1 == ContentAlignment.MiddleRight)
				{
					goto IL_10B;
				}
				if (contentAlignment_1 != ContentAlignment.BottomLeft)
				{
					return result;
				}
			}
			else if (contentAlignment_1 != ContentAlignment.BottomCenter && contentAlignment_1 != ContentAlignment.BottomRight)
			{
				return result;
			}
			result.Y = this.imethod_0().Bottom - image_0.Height - 2;
			return result;
		}
		switch (contentAlignment_1)
		{
		case ContentAlignment.TopLeft:
		case ContentAlignment.TopCenter:
		case ContentAlignment.TopRight:
			result.Y += 2;
			return result;
		case (ContentAlignment)3:
			return result;
		default:
			if (contentAlignment_1 != ContentAlignment.MiddleLeft && contentAlignment_1 != ContentAlignment.MiddleCenter)
			{
				return result;
			}
			break;
		}
		IL_10B:
		result.Y += (this.imethod_0().Height - image_0.Height) / 2;
		return result;
	}

	public ContentAlignment method_18()
	{
		return this.contentAlignment_0;
	}

	public void method_19(ContentAlignment contentAlignment_1)
	{
		this.contentAlignment_0 = contentAlignment_1;
	}

	public override void imethod_14(GEventArgs3 geventArgs3_0)
	{
		base.GInterface2.imethod_14(geventArgs3_0);
		geventArgs3_0.method_6().Invalidate(geventArgs3_0.method_7());
	}

	public override void imethod_15(GEventArgs3 geventArgs3_0)
	{
		base.GInterface2.imethod_15(geventArgs3_0);
		geventArgs3_0.method_6().Invalidate(geventArgs3_0.method_7());
	}

	public override void imethod_16(GEventArgs17 geventArgs17_0)
	{
		base.imethod_16(geventArgs17_0);
		GClass76 gclass = this.method_16(geventArgs17_0.method_0());
		if (geventArgs17_0.KeyData == Keys.Return || geventArgs17_0.KeyData == Keys.Space)
		{
			gclass.method_1(GEnum11.const_2);
			geventArgs17_0.method_1().Invalidate(geventArgs17_0.method_4());
		}
	}

	public override void imethod_17(GEventArgs17 geventArgs17_0)
	{
		base.imethod_17(geventArgs17_0);
		GClass76 gclass = this.method_16(geventArgs17_0.method_0());
		if (geventArgs17_0.KeyData == Keys.Return || geventArgs17_0.KeyData == Keys.Space)
		{
			gclass.method_1(GEnum11.const_0);
			geventArgs17_0.method_1().Invalidate(geventArgs17_0.method_4());
			geventArgs17_0.method_1().vmethod_1(new GEventArgs2(geventArgs17_0.method_0(), geventArgs17_0.method_3(), geventArgs17_0.method_2()));
		}
	}

	public override void imethod_18(GEventArgs10 geventArgs10_0)
	{
		base.GInterface2.imethod_18(geventArgs10_0);
		GClass76 gclass = this.method_16(geventArgs10_0.method_0());
		if (this.vmethod_3().Contains(geventArgs10_0.X, geventArgs10_0.Y))
		{
			if (gclass.method_0() != GEnum11.const_1)
			{
				gclass.method_1(GEnum11.const_1);
				geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
				return;
			}
		}
		else if (gclass.method_0() != GEnum11.const_0)
		{
			gclass.method_1(GEnum11.const_0);
			geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
		}
	}

	public override void imethod_19(GEventArgs10 geventArgs10_0)
	{
		base.imethod_19(geventArgs10_0);
		GClass76 gclass = this.method_16(geventArgs10_0.method_0());
		if (gclass.method_0() != GEnum11.const_0)
		{
			gclass.method_1(GEnum11.const_0);
			geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
		}
	}

	public override void imethod_20(GEventArgs10 geventArgs10_0)
	{
		base.GInterface2.imethod_20(geventArgs10_0);
		GClass76 gclass = this.method_16(geventArgs10_0.method_0());
		if (geventArgs10_0.Button == MouseButtons.Left)
		{
			Rectangle rectangle = this.vmethod_3();
			if (rectangle.Contains(geventArgs10_0.X, geventArgs10_0.Y))
			{
				gclass.method_1(GEnum11.const_1);
				geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
				if (rectangle.Contains(gclass.method_2()))
				{
					geventArgs10_0.method_1().vmethod_1(new GEventArgs2(geventArgs10_0.method_0(), geventArgs10_0.method_3(), geventArgs10_0.method_2()));
				}
			}
			else if (gclass.method_0() != GEnum11.const_0)
			{
				gclass.method_1(GEnum11.const_0);
				geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
			}
		}
		gclass.method_3(Point.Empty);
	}

	public override void imethod_21(GEventArgs10 geventArgs10_0)
	{
		base.GInterface2.imethod_21(geventArgs10_0);
		GClass76 gclass = this.method_16(geventArgs10_0.method_0());
		if (geventArgs10_0.Button == MouseButtons.Left)
		{
			gclass.method_3(new Point(geventArgs10_0.X, geventArgs10_0.Y));
			if (this.vmethod_3().Contains(gclass.method_2()))
			{
				gclass.method_1(GEnum11.const_2);
				geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
			}
		}
	}

	public override void imethod_22(GEventArgs10 geventArgs10_0)
	{
		base.GInterface2.imethod_22(geventArgs10_0);
		GClass76 gclass = this.method_16(geventArgs10_0.method_0());
		Rectangle rectangle = this.vmethod_3();
		if (geventArgs10_0.Button == MouseButtons.Left)
		{
			if (rectangle.Contains(gclass.method_2()))
			{
				if (rectangle.Contains(geventArgs10_0.X, geventArgs10_0.Y))
				{
					if (gclass.method_0() != GEnum11.const_2)
					{
						gclass.method_1(GEnum11.const_2);
						geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
						return;
					}
				}
				else if (gclass.method_0() != GEnum11.const_1)
				{
					gclass.method_1(GEnum11.const_1);
					geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
					return;
				}
			}
		}
		else if (rectangle.Contains(geventArgs10_0.X, geventArgs10_0.Y))
		{
			if (gclass.method_0() != GEnum11.const_1)
			{
				gclass.method_1(GEnum11.const_1);
				geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
				return;
			}
		}
		else if (gclass.method_0() != GEnum11.const_0)
		{
			gclass.method_1(GEnum11.const_0);
			geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
		}
	}

	public override void imethod_13(GEventArgs8 geventArgs8_0)
	{
		if (geventArgs8_0.method_2().method_166().method_23().method_8(geventArgs8_0.method_6()) is GClass23)
		{
			this.method_19(((GClass23)geventArgs8_0.method_2().method_166().method_23().method_8(geventArgs8_0.method_6())).method_45());
		}
		else
		{
			this.method_19(ContentAlignment.MiddleLeft);
		}
		base.GInterface2.imethod_13(geventArgs8_0);
	}

	protected override void vmethod_0(GEventArgs8 geventArgs8_0)
	{
		base.vmethod_0(geventArgs8_0);
		if (geventArgs8_0.method_0() == null)
		{
			return;
		}
		GClass76 gclass = this.method_16(geventArgs8_0.method_0());
		GEnum11 genum = gclass.method_0();
		if (genum == GEnum11.const_0 && geventArgs8_0.method_10())
		{
			genum = GEnum11.const_4;
		}
		if (!geventArgs8_0.method_16())
		{
			genum = GEnum11.const_3;
		}
		GClass69.smethod_0(geventArgs8_0.Graphics, this.vmethod_3(), genum);
	}

	protected override void vmethod_1(GEventArgs8 geventArgs8_0)
	{
		base.vmethod_1(geventArgs8_0);
		if (geventArgs8_0.method_0() == null)
		{
			return;
		}
		Rectangle r = this.vmethod_3();
		r.Inflate(-4, -2);
		if (geventArgs8_0.method_0().method_33() != null)
		{
			Rectangle rectangle_ = this.method_17(geventArgs8_0.method_0().method_33(), this.method_18());
			if (this.method_16(geventArgs8_0.method_0()).method_0() == GEnum11.const_2 && !GClass69.smethod_29())
			{
				rectangle_.X++;
				rectangle_.Y++;
			}
			this.method_20(geventArgs8_0.Graphics, geventArgs8_0.method_0().method_33(), rectangle_, geventArgs8_0.method_16());
		}
		if (geventArgs8_0.method_0().method_5() != null && geventArgs8_0.method_0().method_5().Length != 0)
		{
			if (geventArgs8_0.method_16())
			{
				if (!GClass69.smethod_29() && this.method_16(geventArgs8_0.method_0()).method_0() == GEnum11.const_2)
				{
					r.X++;
					r.Y++;
				}
				if (geventArgs8_0.method_8())
				{
					base.GInterface1.imethod_6(geventArgs8_0.method_0().method_18());
				}
				geventArgs8_0.Graphics.DrawString(geventArgs8_0.method_0().method_5(), base.GInterface1.imethod_3(), base.method_3(), r, base.method_4());
			}
			else
			{
				geventArgs8_0.Graphics.DrawString(geventArgs8_0.method_0().method_5(), base.GInterface1.imethod_3(), base.method_13(), r, base.method_4());
			}
		}
		if (geventArgs8_0.method_10() && geventArgs8_0.method_16())
		{
			Rectangle rectangle = this.vmethod_3();
			if (GClass69.smethod_29())
			{
				rectangle.Inflate(-3, -3);
				if (this.method_16(geventArgs8_0.method_0()).method_0() != GEnum11.const_2)
				{
					ControlPaint.DrawFocusRectangle(geventArgs8_0.Graphics, rectangle);
					return;
				}
			}
			else
			{
				rectangle.Inflate(-4, -4);
				ControlPaint.DrawFocusRectangle(geventArgs8_0.Graphics, rectangle);
			}
		}
	}

	protected void method_20(Graphics graphics_0, Image image_0, Rectangle rectangle_1, bool bool_0)
	{
		if (bool_0)
		{
			graphics_0.DrawImageUnscaled(image_0, rectangle_1);
			return;
		}
		ControlPaint.DrawImageDisabled(graphics_0, image_0, rectangle_1.X, rectangle_1.Y, base.GInterface1.imethod_7());
	}

	ContentAlignment contentAlignment_0;
}
