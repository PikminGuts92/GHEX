using System;
using System.Drawing;
using System.Windows.Forms;

public class GClass7 : GClass2
{
	public GClass7()
	{
		this.size_0 = new Size(13, 13);
		this.bool_0 = true;
	}

	protected Rectangle method_16(GEnum38 genum38_0, GEnum39 genum39_0)
	{
		Rectangle result = new Rectangle(this.imethod_0().Location, this.method_19());
		if (result.Height > this.imethod_0().Height)
		{
			result.Height = this.imethod_0().Height;
			result.Width = result.Height;
		}
		switch (genum38_0)
		{
		case GEnum38.const_1:
			result.Y += (this.imethod_0().Height - result.Height) / 2;
			break;
		case GEnum38.const_2:
			result.Y = this.imethod_0().Bottom - result.Height;
			break;
		}
		if (!this.method_20())
		{
			if (genum39_0 == GEnum39.const_1)
			{
				result.X += (this.imethod_0().Width - result.Width) / 2;
			}
			else if (genum39_0 == GEnum39.const_2)
			{
				result.X = this.imethod_0().Right - result.Width;
			}
		}
		return result;
	}

	protected GClass124 method_17(GClass97 gclass97_0)
	{
		object obj = base.method_9(gclass97_0);
		if (obj == null || !(obj is GClass124))
		{
			if (gclass97_0.method_29() == CheckState.Unchecked)
			{
				obj = new GClass124(GEnum60.const_0);
			}
			else if (gclass97_0.method_29() == CheckState.Indeterminate && gclass97_0.method_31())
			{
				obj = new GClass124(GEnum60.const_8);
			}
			else
			{
				obj = new GClass124(GEnum60.const_4);
			}
			base.method_10(gclass97_0, obj);
		}
		this.method_18(gclass97_0, (GClass124)obj);
		return (GClass124)obj;
	}

	void method_18(GClass97 gclass97_0, GClass124 gclass124_0)
	{
		switch (gclass97_0.method_29())
		{
		case CheckState.Checked:
			if (gclass124_0.method_0() <= GEnum60.const_3)
			{
				gclass124_0.method_1(gclass124_0.method_0() | GEnum60.const_3);
				return;
			}
			if (gclass124_0.method_0() >= GEnum60.const_8)
			{
				gclass124_0.method_1(gclass124_0.method_0() - 4);
				return;
			}
			break;
		case CheckState.Indeterminate:
			if (gclass124_0.method_0() <= GEnum60.const_3)
			{
				gclass124_0.method_1(gclass124_0.method_0() | GEnum60.const_7);
				return;
			}
			if (gclass124_0.method_0() <= GEnum60.const_7)
			{
				gclass124_0.method_1(gclass124_0.method_0() | GEnum60.const_3);
				return;
			}
			break;
		default:
			if (gclass124_0.method_0() >= GEnum60.const_8)
			{
				gclass124_0.method_1(gclass124_0.method_0() - 8);
				return;
			}
			if (gclass124_0.method_0() >= GEnum60.const_4)
			{
				gclass124_0.method_1(gclass124_0.method_0() - 4);
			}
			break;
		}
	}

	protected Size method_19()
	{
		return this.size_0;
	}

	public bool method_20()
	{
		return this.bool_0;
	}

	public override void imethod_16(GEventArgs17 geventArgs17_0)
	{
		base.imethod_16(geventArgs17_0);
		if (geventArgs17_0.KeyData == Keys.Space && geventArgs17_0.method_1().method_125(geventArgs17_0.method_5()))
		{
			GClass124 gclass = this.method_17(geventArgs17_0.method_0());
			if (geventArgs17_0.method_0().method_29() == CheckState.Checked)
			{
				gclass.method_1(GEnum60.const_6);
			}
			else if (geventArgs17_0.method_0().method_29() == CheckState.Indeterminate)
			{
				gclass.method_1(GEnum60.const_10);
			}
			else
			{
				gclass.method_1(GEnum60.const_2);
			}
			geventArgs17_0.method_1().Invalidate(geventArgs17_0.method_4());
		}
	}

	public override void imethod_17(GEventArgs17 geventArgs17_0)
	{
		base.imethod_17(geventArgs17_0);
		if (geventArgs17_0.KeyData == Keys.Space && geventArgs17_0.method_1().method_125(geventArgs17_0.method_5()))
		{
			GClass124 gclass = this.method_17(geventArgs17_0.method_0());
			if (geventArgs17_0.method_0().method_29() == CheckState.Checked)
			{
				if (geventArgs17_0.method_0().method_31() && geventArgs17_0.method_1().method_166().method_23().method_8(geventArgs17_0.method_3()) is GClass24)
				{
					if (((GClass24)geventArgs17_0.method_1().method_166().method_23().method_8(geventArgs17_0.method_3())).method_50() != GEnum4.const_1)
					{
						gclass.method_1(GEnum60.const_8);
						geventArgs17_0.method_0().method_30(CheckState.Indeterminate);
						goto IL_102;
					}
				}
				gclass.method_1(GEnum60.const_0);
				geventArgs17_0.method_0().method_30(CheckState.Unchecked);
			}
			else if (geventArgs17_0.method_0().method_29() == CheckState.Indeterminate)
			{
				gclass.method_1(GEnum60.const_0);
				geventArgs17_0.method_0().method_30(CheckState.Unchecked);
			}
			else
			{
				gclass.method_1(GEnum60.const_4);
				geventArgs17_0.method_0().method_30(CheckState.Checked);
			}
			IL_102:
			geventArgs17_0.method_1().Invalidate(geventArgs17_0.method_4());
		}
	}

	public override void imethod_19(GEventArgs10 geventArgs10_0)
	{
		base.imethod_19(geventArgs10_0);
		if (geventArgs10_0.method_1().method_125(geventArgs10_0.method_5()))
		{
			GClass124 gclass = this.method_17(geventArgs10_0.method_0());
			if (geventArgs10_0.method_0().method_29() == CheckState.Checked)
			{
				if (gclass.method_0() != GEnum60.const_4)
				{
					gclass.method_1(GEnum60.const_4);
					geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
					return;
				}
			}
			else if (geventArgs10_0.method_0().method_29() == CheckState.Indeterminate)
			{
				if (gclass.method_0() != GEnum60.const_8)
				{
					gclass.method_1(GEnum60.const_8);
					geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
					return;
				}
			}
			else if (gclass.method_0() != GEnum60.const_0)
			{
				gclass.method_1(GEnum60.const_0);
				geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
			}
		}
	}

	public override void imethod_20(GEventArgs10 geventArgs10_0)
	{
		base.GInterface2.imethod_20(geventArgs10_0);
		if (geventArgs10_0.method_1().method_125(geventArgs10_0.method_5()))
		{
			GClass124 gclass = this.method_17(geventArgs10_0.method_0());
			if (this.method_16(geventArgs10_0.method_1().method_239().method_12().method_9(geventArgs10_0.method_2()).method_20(), geventArgs10_0.method_1().method_166().method_23().method_8(geventArgs10_0.method_3()).vmethod_4()).Contains(geventArgs10_0.X, geventArgs10_0.Y) && geventArgs10_0.Button == MouseButtons.Left && geventArgs10_0.method_1().method_158().method_1() == geventArgs10_0.method_2() && geventArgs10_0.method_1().method_158().method_3() == geventArgs10_0.method_3())
			{
				if (geventArgs10_0.method_0().method_29() == CheckState.Checked)
				{
					if (geventArgs10_0.method_0().method_31() && geventArgs10_0.method_1().method_166().method_23().method_8(geventArgs10_0.method_3()) is GClass24)
					{
						if (((GClass24)geventArgs10_0.method_1().method_166().method_23().method_8(geventArgs10_0.method_3())).method_50() != GEnum4.const_1)
						{
							gclass.method_1(GEnum60.const_9);
							geventArgs10_0.method_0().method_30(CheckState.Indeterminate);
							goto IL_1A0;
						}
					}
					gclass.method_1(GEnum60.const_1);
					geventArgs10_0.method_0().method_30(CheckState.Unchecked);
				}
				else if (geventArgs10_0.method_0().method_29() == CheckState.Indeterminate)
				{
					gclass.method_1(GEnum60.const_1);
					geventArgs10_0.method_0().method_30(CheckState.Unchecked);
				}
				else
				{
					gclass.method_1(GEnum60.const_5);
					geventArgs10_0.method_0().method_30(CheckState.Checked);
				}
				IL_1A0:
				geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
			}
		}
	}

	public override void imethod_21(GEventArgs10 geventArgs10_0)
	{
		base.GInterface2.imethod_21(geventArgs10_0);
		if (geventArgs10_0.method_1().method_125(geventArgs10_0.method_5()))
		{
			GClass124 gclass = this.method_17(geventArgs10_0.method_0());
			if (this.method_16(geventArgs10_0.method_1().method_239().method_12().method_9(geventArgs10_0.method_2()).method_20(), geventArgs10_0.method_1().method_166().method_23().method_8(geventArgs10_0.method_3()).vmethod_4()).Contains(geventArgs10_0.X, geventArgs10_0.Y))
			{
				if (geventArgs10_0.method_0().method_29() == CheckState.Checked)
				{
					gclass.method_1(GEnum60.const_6);
				}
				else if (geventArgs10_0.method_0().method_29() == CheckState.Indeterminate)
				{
					gclass.method_1(GEnum60.const_10);
				}
				else
				{
					gclass.method_1(GEnum60.const_2);
				}
				geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
			}
		}
	}

	public override void imethod_22(GEventArgs10 geventArgs10_0)
	{
		base.GInterface2.imethod_22(geventArgs10_0);
		if (geventArgs10_0.method_1().method_125(geventArgs10_0.method_5()))
		{
			GClass124 gclass = this.method_17(geventArgs10_0.method_0());
			if (this.method_16(geventArgs10_0.method_1().method_239().method_12().method_9(geventArgs10_0.method_2()).method_20(), geventArgs10_0.method_1().method_166().method_23().method_8(geventArgs10_0.method_3()).vmethod_4()).Contains(geventArgs10_0.X, geventArgs10_0.Y))
			{
				if (geventArgs10_0.method_0().method_29() == CheckState.Checked)
				{
					if (gclass.method_0() == GEnum60.const_4)
					{
						if (geventArgs10_0.Button == MouseButtons.Left && geventArgs10_0.method_2() == geventArgs10_0.method_1().method_158().method_1() && geventArgs10_0.method_3() == geventArgs10_0.method_1().method_158().method_3())
						{
							gclass.method_1(GEnum60.const_6);
						}
						else
						{
							gclass.method_1(GEnum60.const_5);
						}
						geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
						return;
					}
				}
				else if (geventArgs10_0.method_0().method_29() == CheckState.Indeterminate)
				{
					if (gclass.method_0() == GEnum60.const_8)
					{
						if (geventArgs10_0.Button == MouseButtons.Left && geventArgs10_0.method_2() == geventArgs10_0.method_1().method_158().method_1() && geventArgs10_0.method_3() == geventArgs10_0.method_1().method_158().method_3())
						{
							gclass.method_1(GEnum60.const_10);
						}
						else
						{
							gclass.method_1(GEnum60.const_9);
						}
						geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
						return;
					}
				}
				else if (gclass.method_0() == GEnum60.const_0)
				{
					if (geventArgs10_0.Button == MouseButtons.Left && geventArgs10_0.method_2() == geventArgs10_0.method_1().method_158().method_1() && geventArgs10_0.method_3() == geventArgs10_0.method_1().method_158().method_3())
					{
						gclass.method_1(GEnum60.const_2);
					}
					else
					{
						gclass.method_1(GEnum60.const_1);
					}
					geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
					return;
				}
			}
			else
			{
				if (geventArgs10_0.method_0().method_29() == CheckState.Checked)
				{
					gclass.method_1(GEnum60.const_4);
				}
				else if (geventArgs10_0.method_0().method_29() == CheckState.Indeterminate)
				{
					gclass.method_1(GEnum60.const_8);
				}
				else
				{
					gclass.method_1(GEnum60.const_0);
				}
				geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
			}
		}
	}

	public override void imethod_13(GEventArgs8 geventArgs8_0)
	{
		if (geventArgs8_0.method_2().method_166().method_23().method_8(geventArgs8_0.method_6()) is GClass24)
		{
			GClass24 gclass = (GClass24)geventArgs8_0.method_2().method_166().method_23().method_8(geventArgs8_0.method_6());
			this.size_0 = gclass.method_45();
			this.bool_0 = gclass.method_48();
		}
		else
		{
			this.size_0 = new Size(13, 13);
			this.bool_0 = true;
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
		Rectangle rectangle_ = this.method_16(base.GInterface1.imethod_11(), base.GInterface1.imethod_9());
		GEnum60 genum = this.method_17(geventArgs8_0.method_0()).method_0();
		if (!geventArgs8_0.method_16())
		{
			if (geventArgs8_0.method_0().method_29() == CheckState.Checked)
			{
				genum = GEnum60.const_7;
			}
			else if (geventArgs8_0.method_0().method_29() == CheckState.Indeterminate)
			{
				genum = GEnum60.const_11;
			}
			else
			{
				genum = GEnum60.const_3;
			}
		}
		if (geventArgs8_0.method_2().method_166().method_23().method_8(geventArgs8_0.method_6()) is GClass24 && ((GClass24)geventArgs8_0.method_2().method_166().method_23().method_8(geventArgs8_0.method_6())).method_50() != GEnum4.const_0)
		{
			switch (genum)
			{
			case GEnum60.const_8:
				genum = GEnum60.const_4;
				break;
			case GEnum60.const_9:
				genum = GEnum60.const_5;
				break;
			case GEnum60.const_10:
				genum = GEnum60.const_6;
				break;
			case GEnum60.const_11:
				genum = GEnum60.const_7;
				break;
			}
			GClass69.smethod_16(geventArgs8_0.Graphics, rectangle_, (GEnum0)genum);
		}
		else
		{
			GClass69.smethod_3(geventArgs8_0.Graphics, rectangle_, genum);
		}
		if (this.method_20())
		{
			string text = geventArgs8_0.method_0().method_5();
			if (text != null && text.Length != 0)
			{
				Rectangle r = this.imethod_0();
				r.X += rectangle_.Width + 1;
				r.Width -= rectangle_.Width + 1;
				if (geventArgs8_0.method_16())
				{
					geventArgs8_0.Graphics.DrawString(geventArgs8_0.method_0().method_5(), base.GInterface1.imethod_3(), base.method_3(), r, base.method_4());
				}
				else
				{
					geventArgs8_0.Graphics.DrawString(geventArgs8_0.method_0().method_5(), base.GInterface1.imethod_3(), base.method_13(), r, base.method_4());
				}
			}
		}
		if (geventArgs8_0.method_10() && geventArgs8_0.method_16())
		{
			ControlPaint.DrawFocusRectangle(geventArgs8_0.Graphics, this.imethod_0());
		}
	}

	Size size_0;

	bool bool_0;
}
