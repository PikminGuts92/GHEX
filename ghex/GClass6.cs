using System;
using System.Drawing;
using System.Windows.Forms;

public class GClass6 : GClass3
{
	public GClass6()
	{
		this.bool_1 = true;
		this.bool_2 = true;
	}

	protected Rectangle method_22(GEnum38 genum38_0, GEnum39 genum39_0)
	{
		Rectangle result = this.imethod_0();
		result.X += 2;
		result.Y += 2;
		result.Height -= 6;
		result.Width = 16;
		return result;
	}

	public bool method_23()
	{
		return this.bool_1;
	}

	public void method_24(bool bool_3)
	{
		this.bool_1 = bool_3;
	}

	public bool method_25()
	{
		return this.bool_2;
	}

	public void method_26(bool bool_3)
	{
		this.bool_2 = bool_3;
	}

	public override void imethod_13(GEventArgs8 geventArgs8_0)
	{
		if (geventArgs8_0.method_2().method_166().method_23().method_8(geventArgs8_0.method_6()) is GClass21)
		{
			GClass21 gclass = (GClass21)geventArgs8_0.method_2().method_166().method_23().method_8(geventArgs8_0.method_6());
			this.method_24(gclass.method_48());
			this.method_26(gclass.method_50());
		}
		else
		{
			this.method_24(false);
			this.method_26(true);
		}
		base.GInterface2.imethod_13(geventArgs8_0);
	}

	protected override void vmethod_1(GEventArgs8 geventArgs8_0)
	{
		base.vmethod_1(geventArgs8_0);
		if (geventArgs8_0.method_0() == null)
		{
			return;
		}
		Color color = Color.Empty;
		if (geventArgs8_0.method_0().method_7() != null && geventArgs8_0.method_0().method_7() is Color)
		{
			color = (Color)geventArgs8_0.method_0().method_7();
		}
		Rectangle rectangle = base.method_16();
		Rectangle rectangle2 = this.imethod_0();
		if (base.method_20())
		{
			rectangle2.Width -= rectangle.Width - 1;
		}
		geventArgs8_0.Graphics.SetClip(rectangle2);
		if (this.method_23())
		{
			Rectangle rect = this.method_22(geventArgs8_0.method_2().method_239().method_12().method_9(geventArgs8_0.method_4()).method_20(), geventArgs8_0.method_2().method_166().method_23().method_8(geventArgs8_0.method_6()).vmethod_4());
			if (color != Color.Empty)
			{
				using (SolidBrush solidBrush = new SolidBrush(color))
				{
					if (geventArgs8_0.method_16())
					{
						geventArgs8_0.Graphics.FillRectangle(solidBrush, rect);
						geventArgs8_0.Graphics.DrawRectangle(SystemPens.ControlText, rect);
					}
					else
					{
						using (Bitmap bitmap = new Bitmap(rect.Width, rect.Height))
						{
							using (Graphics graphics = Graphics.FromImage(bitmap))
							{
								graphics.FillRectangle(solidBrush, 0, 0, rect.Width, rect.Height);
								graphics.DrawRectangle(SystemPens.ControlText, 0, 0, rect.Width - 1, rect.Height - 1);
							}
							ControlPaint.DrawImageDisabled(geventArgs8_0.Graphics, bitmap, rect.X, rect.Y, base.GInterface1.imethod_7());
						}
					}
				}
				rectangle2.X = rect.Right + 2;
				rectangle2.Width -= rect.Width + 4;
			}
		}
		if (this.method_25())
		{
			string text = "";
			if (color.IsEmpty)
			{
				text = "Empty";
			}
			else if (!color.IsNamedColor && !color.IsSystemColor)
			{
				if (color.A != 255)
				{
					text = text + color.A + ", ";
				}
				object obj = text;
				text = string.Concat(new object[]
				{
					obj,
					color.R,
					", ",
					color.G,
					", ",
					color.B
				});
			}
			else
			{
				text = color.Name;
			}
			if (geventArgs8_0.method_16())
			{
				geventArgs8_0.Graphics.DrawString(text, base.GInterface1.imethod_3(), base.method_3(), rectangle2, base.method_4());
			}
			else
			{
				geventArgs8_0.Graphics.DrawString(text, base.GInterface1.imethod_3(), base.method_13(), rectangle2, base.method_4());
			}
		}
		if (geventArgs8_0.method_10() && geventArgs8_0.method_16())
		{
			Rectangle rectangle3 = this.imethod_0();
			if (base.method_20())
			{
				rectangle3.Width -= rectangle.Width;
			}
			ControlPaint.DrawFocusRectangle(geventArgs8_0.Graphics, rectangle3);
		}
	}

	bool bool_1;

	bool bool_2;
}
