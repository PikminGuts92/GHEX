using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public abstract class GClass106 : IDisposable
{
	public GClass106(GInterface37 ginterface37_1, GClass123 gclass123_1)
	{
		this.ginterface37_0 = ginterface37_1;
		this.gclass123_0 = gclass123_1;
		this.font_0 = new Font(FontFamily.GenericSansSerif, 7f, FontStyle.Regular);
		this.pen_0 = Pens.Black;
		this.pen_1 = Pens.Gray;
		this.brush_0 = Brushes.Gray;
	}

	protected GInterface37 method_0()
	{
		return this.ginterface37_0;
	}

	public void method_1(string string_1)
	{
		this.string_0 = string_1;
	}

	public string method_2()
	{
		return this.string_0;
	}

	public GClass123 method_3()
	{
		return this.gclass123_0;
	}

	public abstract bool vmethod_0();

	public bool method_4()
	{
		return this.bool_0;
	}

	public void method_5(bool bool_1)
	{
		if (bool_1 != this.bool_0)
		{
			this.bool_0 = bool_1;
			this.method_0().Invalidate(this.method_10());
		}
	}

	public virtual void Dispose()
	{
		this.font_0.Dispose();
		this.pen_0.Dispose();
		this.pen_1.Dispose();
		this.brush_0.Dispose();
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_6(GDelegate17 gdelegate17_1)
	{
		this.gdelegate17_0 = (GDelegate17)Delegate.Combine(this.gdelegate17_0, gdelegate17_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_7(GDelegate17 gdelegate17_1)
	{
		this.gdelegate17_0 = (GDelegate17)Delegate.Remove(this.gdelegate17_0, gdelegate17_1);
	}

	public int method_8()
	{
		return this.int_0;
	}

	public void method_9(int int_1)
	{
		if (int_1 == this.int_0)
		{
			return;
		}
		this.int_0 = int_1;
		if (this.gdelegate17_0 != null)
		{
			this.gdelegate17_0(this);
		}
	}

	public Rectangle method_10()
	{
		return this.rectangle_0;
	}

	public void method_11(Rectangle rectangle_1)
	{
		if (this.rectangle_0.Equals(rectangle_1))
		{
			return;
		}
		this.rectangle_0 = rectangle_1;
		this.vmethod_1();
		this.vmethod_2();
	}

	public abstract void vmethod_1();

	public abstract void vmethod_2();

	public abstract Cursor vmethod_3(MouseEventArgs mouseEventArgs_0, KeyEventArgs keyEventArgs_0);

	public virtual void vmethod_4(GInterface7 ginterface7_0)
	{
	}

	public virtual void vmethod_5(ToolStrip[] toolStrip_0)
	{
	}

	public virtual void vmethod_6()
	{
	}

	public virtual void vmethod_7(MouseEventArgs mouseEventArgs_0)
	{
	}

	public virtual void vmethod_8(MouseEventArgs mouseEventArgs_0)
	{
	}

	public virtual void vmethod_9(MouseEventArgs mouseEventArgs_0)
	{
	}

	public virtual void vmethod_10(MouseEventArgs mouseEventArgs_0)
	{
	}

	public virtual void vmethod_11()
	{
	}

	public virtual void vmethod_12()
	{
	}

	public virtual void vmethod_13(KeyEventArgs keyEventArgs_0)
	{
	}

	public virtual void vmethod_14(KeyPressEventArgs keyPressEventArgs_0)
	{
	}

	public virtual void vmethod_15(KeyEventArgs keyEventArgs_0)
	{
	}

	protected void method_12(double double_1)
	{
		this.double_0 = double_1;
	}

	protected void method_13(Graphics graphics_0, Rectangle rectangle_1, Rectangle rectangle_2)
	{
		int top = rectangle_1.Top;
		int bottom = rectangle_1.Bottom;
		graphics_0.DrawLine(this.pen_1, rectangle_2.Left, bottom, rectangle_2.Right, bottom);
		int num = -1;
		for (int i = this.method_10().Left; i < rectangle_2.Right; i++)
		{
			double num2 = this.method_0().imethod_0() + this.method_0().imethod_9(i - this.method_10().Left);
			int num3 = (int)Math.Floor(num2 * 10.0);
			if (num != num3 && num3 % 10 == 0)
			{
				graphics_0.DrawString((num3 / 10).ToString(), this.font_0, this.brush_0, (float)i, (float)(top - 1));
				graphics_0.DrawLine(this.pen_1, i, top, i, bottom);
			}
			else if (num != num3 && num3 % 2 == 0)
			{
				graphics_0.DrawLine(this.pen_1, i, top + rectangle_1.Height * 2 / 3, i, bottom);
			}
			num = num3;
		}
		if (this.method_4() && (this.method_0().imethod_3() != -1.0 || this.double_0 != -1.0))
		{
			int num4 = this.method_10().Left + this.method_0().imethod_10(((this.double_0 != -1.0) ? this.double_0 : this.method_0().imethod_3()) - this.method_0().imethod_0());
			graphics_0.DrawLine(this.pen_0, num4, top + rectangle_1.Height / 3, num4, bottom);
		}
	}

	public virtual void vmethod_16(PaintEventArgs paintEventArgs_0)
	{
		paintEventArgs_0.Graphics.FillRectangle(Brushes.White, paintEventArgs_0.ClipRectangle);
	}

	public virtual void vmethod_17(PaintEventArgs paintEventArgs_0)
	{
		paintEventArgs_0.Graphics.DrawString(this.string_0, SystemFonts.CaptionFont, SystemBrushes.AppWorkspace, (float)(this.method_10().Location.X + 1), (float)this.method_10().Location.Y);
	}

	protected Font font_0;

	protected Pen pen_0;

	protected Pen pen_1;

	protected Brush brush_0;

	GInterface37 ginterface37_0;

	string string_0 = "";

	GClass123 gclass123_0;

	bool bool_0;

	int int_0 = 100;

	GDelegate17 gdelegate17_0;

	Rectangle rectangle_0;

	double double_0 = -1.0;
}
