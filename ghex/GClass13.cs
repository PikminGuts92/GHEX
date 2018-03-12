using System;
using System.Drawing;
using System.Windows.Forms;

public abstract class GClass13 : GClass1, GInterface8
{
	protected GClass13()
	{
		base.method_4().Alignment = StringAlignment.Near;
	}

	protected Rectangle method_9()
	{
		Rectangle result = this.imethod_0();
		if (result.Width > 16)
		{
			result.Width = 16;
		}
		if (result.Height > 16)
		{
			result.Height = 16;
			result.Y += (this.imethod_0().Height - result.Height) / 2;
		}
		return result;
	}

	protected Rectangle method_10()
	{
		Rectangle result = this.imethod_0();
		result.Width = 12;
		result.X = this.imethod_0().Right - result.Width;
		return result;
	}

	public virtual Rectangle imethod_0()
	{
		Rectangle result = new Rectangle(base.GInterface1.imethod_1().Location, base.GInterface1.imethod_1().Size);
		result.Inflate(-2, -2);
		return result;
	}

	public virtual void imethod_14(GEventArgs16 geventArgs16_0)
	{
		base.imethod_2(geventArgs16_0.method_3());
		bool active;
		if (active = geventArgs16_0.method_1().method_249().Active)
		{
			geventArgs16_0.method_1().method_249().Active = false;
		}
		geventArgs16_0.method_1().method_138();
		geventArgs16_0.method_1().method_249().SetToolTip(geventArgs16_0.method_1(), geventArgs16_0.method_0().method_34());
		if (active)
		{
			geventArgs16_0.method_1().method_249().Active = true;
		}
	}

	public virtual void imethod_15(GEventArgs16 geventArgs16_0)
	{
		base.imethod_2(geventArgs16_0.method_3());
	}

	public virtual void imethod_16(GEventArgs16 geventArgs16_0)
	{
		base.imethod_2(geventArgs16_0.method_3());
	}

	public virtual void imethod_17(GEventArgs16 geventArgs16_0)
	{
		if (!geventArgs16_0.method_1().Focused)
		{
			geventArgs16_0.method_1().Focus();
		}
		base.imethod_2(geventArgs16_0.method_3());
	}

	public virtual void imethod_18(GEventArgs16 geventArgs16_0)
	{
		base.imethod_2(geventArgs16_0.method_3());
	}

	public virtual void imethod_19(GEventArgs16 geventArgs16_0)
	{
		base.imethod_2(geventArgs16_0.method_3());
	}

	public virtual void imethod_20(GEventArgs16 geventArgs16_0)
	{
		base.imethod_2(geventArgs16_0.method_3());
	}

	public virtual void imethod_13(GEventArgs7 geventArgs7_0)
	{
		this.vmethod_0(geventArgs7_0);
		this.vmethod_1(geventArgs7_0);
	}

	protected virtual void vmethod_0(GEventArgs7 geventArgs7_0)
	{
	}

	protected virtual void vmethod_1(GEventArgs7 geventArgs7_0)
	{
	}

	protected void method_11(Graphics graphics_0, Image image_0, Rectangle rectangle_1, bool bool_0)
	{
		if (bool_0)
		{
			graphics_0.DrawImage(image_0, rectangle_1);
			return;
		}
		using (Image image = new Bitmap(image_0, rectangle_1.Width, rectangle_1.Height))
		{
			ControlPaint.DrawImageDisabled(graphics_0, image, rectangle_1.X, rectangle_1.Y, base.method_2().Color);
		}
	}

	protected virtual void vmethod_2(Graphics graphics_0, Rectangle rectangle_1, SortOrder sortOrder_0, bool bool_0)
	{
		if (sortOrder_0 != SortOrder.None)
		{
			using (Font font = new Font("Marlett", 9f))
			{
				using (StringFormat stringFormat = new StringFormat())
				{
					stringFormat.Alignment = StringAlignment.Far;
					stringFormat.LineAlignment = StringAlignment.Center;
					if (sortOrder_0 == SortOrder.Ascending)
					{
						if (bool_0)
						{
							graphics_0.DrawString("t", font, SystemBrushes.ControlDarkDark, rectangle_1, stringFormat);
							goto IL_CA;
						}
						using (SolidBrush solidBrush = new SolidBrush(SystemPens.GrayText.Color))
						{
							graphics_0.DrawString("t", font, solidBrush, rectangle_1, stringFormat);
							goto IL_CA;
						}
					}
					if (bool_0)
					{
						graphics_0.DrawString("u", font, SystemBrushes.ControlDarkDark, rectangle_1, stringFormat);
					}
					else
					{
						using (SolidBrush solidBrush2 = new SolidBrush(SystemPens.GrayText.Color))
						{
							graphics_0.DrawString("u", font, solidBrush2, rectangle_1, stringFormat);
						}
					}
					IL_CA:;
				}
			}
		}
	}
}
