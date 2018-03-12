using System;
using System.Drawing;
using System.Windows.Forms;

public abstract class GClass3 : GClass2
{
	protected GClass3()
	{
		this.int_1 = 15;
		this.bool_0 = true;
	}

	protected internal Rectangle method_16()
	{
		Rectangle result = this.imethod_0();
		result.Width = this.method_18();
		result.X = this.imethod_0().Right - result.Width;
		if (result.Width > this.imethod_0().Width)
		{
			result = this.imethod_0();
		}
		return result;
	}

	protected GClass60 method_17(GClass97 gclass97_0)
	{
		object obj = base.method_9(gclass97_0);
		if (obj == null || !(obj is GClass60))
		{
			obj = new GClass60();
			base.method_10(gclass97_0, obj);
		}
		return (GClass60)obj;
	}

	protected internal int method_18()
	{
		return this.int_1;
	}

	protected internal void method_19(int int_2)
	{
		this.int_1 = int_2;
	}

	protected bool method_20()
	{
		return this.bool_0;
	}

	protected void method_21(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	public override void imethod_19(GEventArgs10 geventArgs10_0)
	{
		base.imethod_19(geventArgs10_0);
		if ((this.method_20() || (geventArgs10_0.method_1().method_175() && GStruct9.smethod_0(geventArgs10_0.method_5(), geventArgs10_0.method_1().method_176()))) && geventArgs10_0.method_1().method_125(geventArgs10_0.method_5()))
		{
			GClass60 gclass = this.method_17(geventArgs10_0.method_0());
			if (gclass.method_0() != GEnum55.const_0)
			{
				gclass.method_1(GEnum55.const_0);
				geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
			}
		}
	}

	public override void imethod_20(GEventArgs10 geventArgs10_0)
	{
		base.GInterface2.imethod_20(geventArgs10_0);
		if ((this.method_20() || (geventArgs10_0.method_1().method_175() && GStruct9.smethod_0(geventArgs10_0.method_5(), geventArgs10_0.method_1().method_176()))) && geventArgs10_0.method_1().method_125(geventArgs10_0.method_5()))
		{
			GClass60 gclass = this.method_17(geventArgs10_0.method_0());
			if (this.method_16().Contains(geventArgs10_0.X, geventArgs10_0.Y))
			{
				gclass.method_1(GEnum55.const_1);
				geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
			}
		}
	}

	public override void imethod_21(GEventArgs10 geventArgs10_0)
	{
		base.GInterface2.imethod_21(geventArgs10_0);
		if ((this.method_20() || (geventArgs10_0.method_1().method_175() && GStruct9.smethod_0(geventArgs10_0.method_5(), geventArgs10_0.method_1().method_176()))) && geventArgs10_0.method_1().method_125(geventArgs10_0.method_5()))
		{
			GClass60 gclass = this.method_17(geventArgs10_0.method_0());
			if (this.method_16().Contains(geventArgs10_0.X, geventArgs10_0.Y))
			{
				if (!(geventArgs10_0.method_1().method_166().method_12(geventArgs10_0.method_5().method_3()) is GClass46))
				{
					throw new InvalidOperationException("Cannot edit Cell as DropDownCellRenderer requires a DropDownColumn that uses a DropDownCellEditor");
				}
				gclass.method_1(GEnum55.const_2);
				if (!geventArgs10_0.method_1().method_175())
				{
					geventArgs10_0.method_1().method_121(geventArgs10_0.method_5());
				}
				((GInterface6)geventArgs10_0.method_1().method_177()).imethod_0(this, geventArgs10_0);
				geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
			}
		}
	}

	public override void imethod_22(GEventArgs10 geventArgs10_0)
	{
		base.GInterface2.imethod_22(geventArgs10_0);
		if ((this.method_20() || (geventArgs10_0.method_1().method_175() && GStruct9.smethod_0(geventArgs10_0.method_5(), geventArgs10_0.method_1().method_176()))) && geventArgs10_0.method_1().method_125(geventArgs10_0.method_5()))
		{
			GClass60 gclass = this.method_17(geventArgs10_0.method_0());
			if (this.method_16().Contains(geventArgs10_0.X, geventArgs10_0.Y))
			{
				if (gclass.method_0() == GEnum55.const_0)
				{
					if (geventArgs10_0.Button == MouseButtons.Left && geventArgs10_0.method_2() == geventArgs10_0.method_1().method_158().method_1() && geventArgs10_0.method_3() == geventArgs10_0.method_1().method_158().method_3())
					{
						gclass.method_1(GEnum55.const_2);
					}
					else
					{
						gclass.method_1(GEnum55.const_1);
					}
					geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
					return;
				}
			}
			else if (gclass.method_0() != GEnum55.const_0)
			{
				gclass.method_1(GEnum55.const_0);
				geventArgs10_0.method_1().Invalidate(geventArgs10_0.method_4());
			}
		}
	}

	public override void imethod_13(GEventArgs8 geventArgs8_0)
	{
		if (geventArgs8_0.method_2().method_166().method_23().method_8(geventArgs8_0.method_6()) is GClass19)
		{
			this.bool_0 = ((GClass19)geventArgs8_0.method_2().method_166().method_23().method_8(geventArgs8_0.method_6())).method_45();
		}
		else
		{
			this.bool_0 = true;
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
		if (this.method_20() || (geventArgs8_0.method_2().method_175() && GStruct9.smethod_0(geventArgs8_0.method_20(), geventArgs8_0.method_2().method_176())))
		{
			GEnum55 genum55_ = this.method_17(geventArgs8_0.method_0()).method_0();
			if (!geventArgs8_0.method_16())
			{
				genum55_ = GEnum55.const_3;
			}
			GClass69.smethod_9(geventArgs8_0.Graphics, this.method_16(), genum55_);
		}
	}

	int int_1;

	bool bool_0;
}
