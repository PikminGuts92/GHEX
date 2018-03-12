using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class GClass12 : GClass2
{
	public GClass12()
	{
		base.method_4().Trimming = StringTrimming.None;
		base.method_12("G");
		this.int_1 = 15;
		this.bool_0 = false;
		this.leftRightAlignment_0 = LeftRightAlignment.Right;
		this.decimal_0 = 100m;
		this.decimal_1 = 0m;
	}

	protected Rectangle method_16()
	{
		Rectangle result = this.imethod_0();
		result.Width = this.method_21();
		if (this.method_25() == LeftRightAlignment.Right)
		{
			result.X = this.imethod_0().Right - result.Width;
		}
		if (result.Width > this.imethod_0().Width)
		{
			result = this.imethod_0();
		}
		return result;
	}

	protected Rectangle method_17()
	{
		Rectangle result = this.method_16();
		result.Height /= 2;
		return result;
	}

	protected Rectangle method_18()
	{
		Rectangle result = this.method_16();
		int num = result.Height / 2;
		result.Height -= num;
		result.Y += num;
		return result;
	}

	protected GClass92 method_19(GClass97 gclass97_0)
	{
		object obj = base.method_9(gclass97_0);
		if (obj == null || !(obj is GClass92))
		{
			obj = new GClass92();
			base.method_10(gclass97_0, obj);
		}
		return (GClass92)obj;
	}

	internal bool method_20(GControl2 gcontrol2_0, GStruct9 gstruct9_0)
	{
		return gcontrol2_0.method_175() && GStruct9.smethod_0(gstruct9_0, gcontrol2_0.method_176()) && gcontrol2_0.method_177() is GClass51;
	}

	protected internal int method_21()
	{
		return this.int_1;
	}

	protected internal void method_22(int int_2)
	{
		this.int_1 = int_2;
	}

	protected bool method_23()
	{
		return this.bool_0;
	}

	protected void method_24(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	protected LeftRightAlignment method_25()
	{
		return this.leftRightAlignment_0;
	}

	protected void method_26(LeftRightAlignment leftRightAlignment_1)
	{
		if (!Enum.IsDefined(typeof(LeftRightAlignment), leftRightAlignment_1))
		{
			throw new InvalidEnumArgumentException("value", (int)leftRightAlignment_1, typeof(LeftRightAlignment));
		}
		this.leftRightAlignment_0 = leftRightAlignment_1;
	}

	protected decimal method_27()
	{
		return this.decimal_0;
	}

	protected void method_28(decimal decimal_2)
	{
		this.decimal_0 = decimal_2;
		if (this.decimal_1 > this.decimal_0)
		{
			this.decimal_1 = this.decimal_0;
		}
	}

	protected decimal method_29()
	{
		return this.decimal_1;
	}

	protected void method_30(decimal decimal_2)
	{
		this.decimal_1 = decimal_2;
		if (this.decimal_1 > this.decimal_0)
		{
			this.decimal_0 = decimal_2;
		}
	}

	public override void imethod_19(GEventArgs10 geventArgs10_0)
	{
		base.imethod_19(geventArgs10_0);
		if ((this.method_23() || this.method_20(geventArgs10_0.method_1(), geventArgs10_0.method_5())) && geventArgs10_0.method_1().method_125(geventArgs10_0.method_5()))
		{
			GClass92 gclass = this.method_19(geventArgs10_0.method_0());
			if (gclass.method_0() != GEnum41.const_0)
			{
				gclass.method_1(GEnum41.const_0);
				geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
				return;
			}
			if (gclass.method_2() != GEnum41.const_0)
			{
				gclass.method_3(GEnum41.const_0);
				geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
			}
		}
	}

	public override void imethod_20(GEventArgs10 geventArgs10_0)
	{
		base.imethod_20(geventArgs10_0);
		if ((this.method_23() || this.method_20(geventArgs10_0.method_1(), geventArgs10_0.method_5())) && geventArgs10_0.method_1().method_125(geventArgs10_0.method_5()))
		{
			GClass92 gclass = this.method_19(geventArgs10_0.method_0());
			gclass.method_5(new Point(-1, -1));
			if (this.method_17().Contains(geventArgs10_0.X, geventArgs10_0.Y))
			{
				gclass.method_1(GEnum41.const_1);
				if (!geventArgs10_0.method_1().method_175())
				{
					geventArgs10_0.method_1().method_121(geventArgs10_0.method_5());
				}
				((GInterface6)geventArgs10_0.method_1().method_177()).imethod_1(this, geventArgs10_0);
				geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
				return;
			}
			if (this.method_18().Contains(geventArgs10_0.X, geventArgs10_0.Y))
			{
				gclass.method_3(GEnum41.const_1);
				if (!geventArgs10_0.method_1().method_175())
				{
					geventArgs10_0.method_1().method_121(geventArgs10_0.method_5());
				}
				((GInterface6)geventArgs10_0.method_1().method_177()).imethod_1(this, geventArgs10_0);
				geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
			}
		}
	}

	public override void imethod_21(GEventArgs10 geventArgs10_0)
	{
		base.imethod_21(geventArgs10_0);
		if ((this.method_23() || this.method_20(geventArgs10_0.method_1(), geventArgs10_0.method_5())) && geventArgs10_0.method_1().method_125(geventArgs10_0.method_5()))
		{
			GClass92 gclass = this.method_19(geventArgs10_0.method_0());
			gclass.method_5(new Point(geventArgs10_0.X, geventArgs10_0.Y));
			if (this.method_16().Contains(geventArgs10_0.X, geventArgs10_0.Y))
			{
				if (!(geventArgs10_0.method_1().method_166().method_12(geventArgs10_0.method_5().method_3()) is GClass51))
				{
					throw new InvalidOperationException("Cannot edit Cell as NumberCellRenderer requires a NumberColumn that uses a NumberCellEditor");
				}
				if (!geventArgs10_0.method_1().method_175())
				{
					geventArgs10_0.method_1().method_121(geventArgs10_0.method_5());
				}
				if (this.method_17().Contains(geventArgs10_0.X, geventArgs10_0.Y))
				{
					gclass.method_1(GEnum41.const_2);
					((GInterface6)geventArgs10_0.method_1().method_177()).imethod_0(this, geventArgs10_0);
					geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
					return;
				}
				if (this.method_18().Contains(geventArgs10_0.X, geventArgs10_0.Y))
				{
					gclass.method_3(GEnum41.const_2);
					((GInterface6)geventArgs10_0.method_1().method_177()).imethod_0(this, geventArgs10_0);
					geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
				}
			}
		}
	}

	public override void imethod_22(GEventArgs10 geventArgs10_0)
	{
		base.imethod_22(geventArgs10_0);
		if ((this.method_23() || this.method_20(geventArgs10_0.method_1(), geventArgs10_0.method_5())) && geventArgs10_0.method_1().method_125(geventArgs10_0.method_5()))
		{
			GClass92 gclass = this.method_19(geventArgs10_0.method_0());
			if (this.method_17().Contains(geventArgs10_0.X, geventArgs10_0.Y))
			{
				if (gclass.method_0() == GEnum41.const_0)
				{
					if (geventArgs10_0.Button == MouseButtons.Left && geventArgs10_0.method_2() == geventArgs10_0.method_1().method_158().method_1() && geventArgs10_0.method_3() == geventArgs10_0.method_1().method_158().method_3())
					{
						if (this.method_17().Contains(gclass.method_4()))
						{
							gclass.method_1(GEnum41.const_2);
							if (this.method_20(geventArgs10_0.method_1(), geventArgs10_0.method_5()))
							{
								((GInterface6)geventArgs10_0.method_1().method_177()).imethod_0(this, geventArgs10_0);
							}
						}
						else if (this.method_18().Contains(gclass.method_4()))
						{
							gclass.method_3(GEnum41.const_0);
							if (this.method_20(geventArgs10_0.method_1(), geventArgs10_0.method_5()))
							{
								((GInterface6)geventArgs10_0.method_1().method_177()).imethod_1(this, geventArgs10_0);
							}
						}
					}
					else
					{
						gclass.method_1(GEnum41.const_1);
						if (gclass.method_2() == GEnum41.const_1)
						{
							gclass.method_3(GEnum41.const_0);
						}
					}
					geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
					return;
				}
			}
			else if (this.method_18().Contains(geventArgs10_0.X, geventArgs10_0.Y))
			{
				if (gclass.method_2() == GEnum41.const_0)
				{
					if (geventArgs10_0.Button == MouseButtons.Left && geventArgs10_0.method_2() == geventArgs10_0.method_1().method_158().method_1() && geventArgs10_0.method_3() == geventArgs10_0.method_1().method_158().method_3())
					{
						if (this.method_18().Contains(gclass.method_4()))
						{
							gclass.method_3(GEnum41.const_2);
							if (this.method_20(geventArgs10_0.method_1(), geventArgs10_0.method_5()))
							{
								((GInterface6)geventArgs10_0.method_1().method_177()).imethod_0(this, geventArgs10_0);
							}
						}
						else if (this.method_17().Contains(gclass.method_4()))
						{
							gclass.method_1(GEnum41.const_0);
							if (this.method_20(geventArgs10_0.method_1(), geventArgs10_0.method_5()))
							{
								((GInterface6)geventArgs10_0.method_1().method_177()).imethod_1(this, geventArgs10_0);
							}
						}
					}
					else
					{
						gclass.method_3(GEnum41.const_1);
						if (gclass.method_0() == GEnum41.const_1)
						{
							gclass.method_1(GEnum41.const_0);
						}
					}
					geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
					return;
				}
			}
			else if (gclass.method_0() != GEnum41.const_0 || gclass.method_2() != GEnum41.const_0)
			{
				gclass.method_1(GEnum41.const_0);
				gclass.method_3(GEnum41.const_0);
				if (this.method_20(geventArgs10_0.method_1(), geventArgs10_0.method_5()))
				{
					((GInterface6)geventArgs10_0.method_1().method_177()).imethod_1(this, geventArgs10_0);
				}
				geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
			}
		}
	}

	public override void imethod_13(GEventArgs8 geventArgs8_0)
	{
		if (geventArgs8_0.method_2().method_166().method_23().method_8(geventArgs8_0.method_6()) is GClass18)
		{
			GClass18 gclass = (GClass18)geventArgs8_0.method_2().method_166().method_23().method_8(geventArgs8_0.method_6());
			this.method_24(gclass.method_54());
			this.method_26(gclass.method_56());
			this.method_28(gclass.method_45());
			this.method_30(gclass.method_48());
			if (geventArgs8_0.method_2().method_175() && GStruct9.smethod_0(geventArgs8_0.method_2().method_176(), geventArgs8_0.method_20()) && geventArgs8_0.method_2().method_177() is GClass51)
			{
				this.method_24(true);
			}
		}
		else
		{
			this.method_24(false);
			this.method_26(LeftRightAlignment.Right);
			this.method_28(100m);
			this.method_30(0m);
		}
		base.imethod_13(geventArgs8_0);
	}

	protected override void vmethod_0(GEventArgs8 geventArgs8_0)
	{
		base.vmethod_0(geventArgs8_0);
		if (geventArgs8_0.method_0() == null)
		{
			return;
		}
		if (this.method_23())
		{
			GEnum41 genum41_ = this.method_19(geventArgs8_0.method_0()).method_0();
			GEnum41 genum41_2 = this.method_19(geventArgs8_0.method_0()).method_2();
			if (!geventArgs8_0.method_16())
			{
				genum41_ = GEnum41.const_3;
				genum41_2 = GEnum41.const_3;
			}
			GClass69.smethod_23(geventArgs8_0.Graphics, this.method_17(), genum41_, this.method_18(), genum41_2);
		}
	}

	protected override void vmethod_1(GEventArgs8 geventArgs8_0)
	{
		base.vmethod_1(geventArgs8_0);
		if (geventArgs8_0.method_0() == null)
		{
			return;
		}
		decimal d = decimal.MinValue;
		if (geventArgs8_0.method_0().method_7() != null && (geventArgs8_0.method_0().method_7() is int || geventArgs8_0.method_0().method_7() is double || geventArgs8_0.method_0().method_7() is float || geventArgs8_0.method_0().method_7() is decimal))
		{
			d = Convert.ToDecimal(geventArgs8_0.method_0().method_7());
		}
		if (d != -79228162514264337593543950335m)
		{
			Rectangle r = this.imethod_0();
			if (this.method_23())
			{
				r.Width -= this.method_16().Width - 1;
				if (this.method_25() == LeftRightAlignment.Left)
				{
					r.X = this.imethod_0().Right - r.Width;
				}
			}
			if (geventArgs8_0.method_16())
			{
				geventArgs8_0.Graphics.DrawString(d.ToString(base.method_11()), base.imethod_3(), base.method_3(), r, base.method_4());
			}
			else
			{
				geventArgs8_0.Graphics.DrawString(d.ToString(base.method_11()), base.imethod_3(), base.method_13(), r, base.method_4());
			}
		}
		if (geventArgs8_0.method_10() && geventArgs8_0.method_16())
		{
			Rectangle rectangle = this.imethod_0();
			if (this.method_23())
			{
				rectangle.Width -= this.method_16().Width;
				if (this.method_25() == LeftRightAlignment.Left)
				{
					rectangle.X = this.imethod_0().Right - rectangle.Width;
				}
			}
			ControlPaint.DrawFocusRectangle(geventArgs8_0.Graphics, rectangle);
		}
	}

	int int_1;

	bool bool_0;

	LeftRightAlignment leftRightAlignment_0;

	decimal decimal_0;

	decimal decimal_1;
}
