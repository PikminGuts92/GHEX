using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

[TypeConverter(typeof(GClass110))]
[DesignTimeVisible(true)]
public class GClass83 : IDisposable
{
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_0(GDelegate3 gdelegate3_3)
	{
		this.gdelegate3_0 = (GDelegate3)Delegate.Combine(this.gdelegate3_0, gdelegate3_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_1(GDelegate3 gdelegate3_3)
	{
		this.gdelegate3_0 = (GDelegate3)Delegate.Remove(this.gdelegate3_0, gdelegate3_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_2(GDelegate3 gdelegate3_3)
	{
		this.gdelegate3_1 = (GDelegate3)Delegate.Combine(this.gdelegate3_1, gdelegate3_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_3(GDelegate3 gdelegate3_3)
	{
		this.gdelegate3_1 = (GDelegate3)Delegate.Remove(this.gdelegate3_1, gdelegate3_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_4(GDelegate3 gdelegate3_3)
	{
		this.gdelegate3_2 = (GDelegate3)Delegate.Combine(this.gdelegate3_2, gdelegate3_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_5(GDelegate3 gdelegate3_3)
	{
		this.gdelegate3_2 = (GDelegate3)Delegate.Remove(this.gdelegate3_2, gdelegate3_3);
	}

	public GClass83()
	{
		this.method_6();
	}

	public GClass83(string[] string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("items", "string[] cannot be null");
		}
		this.method_6();
		if (string_0.Length > 0)
		{
			GClass97[] array = new GClass97[string_0.Length];
			for (int i = 0; i < string_0.Length; i++)
			{
				array[i] = new GClass97(string_0[i]);
			}
			this.method_9().method_1(array);
		}
	}

	public GClass83(GClass97[] gclass97_0)
	{
		if (gclass97_0 == null)
		{
			throw new ArgumentNullException("cells", "Cell[] cannot be null");
		}
		this.method_6();
		if (gclass97_0.Length > 0)
		{
			this.method_9().method_1(gclass97_0);
		}
	}

	public GClass83(string[] string_0, Color color_0, Color color_1, Font font_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("items", "string[] cannot be null");
		}
		this.method_6();
		this.method_18(color_0);
		this.method_15(color_1);
		this.method_23(font_0);
		if (string_0.Length > 0)
		{
			GClass97[] array = new GClass97[string_0.Length];
			for (int i = 0; i < string_0.Length; i++)
			{
				array[i] = new GClass97(string_0[i]);
			}
			this.method_9().method_1(array);
		}
	}

	public GClass83(GClass97[] gclass97_0, Color color_0, Color color_1, Font font_0)
	{
		if (gclass97_0 == null)
		{
			throw new ArgumentNullException("cells", "Cell[] cannot be null");
		}
		this.method_6();
		this.method_18(color_0);
		this.method_15(color_1);
		this.method_23(font_0);
		if (gclass97_0.Length > 0)
		{
			this.method_9().method_1(gclass97_0);
		}
	}

	void method_6()
	{
		this.gclass70_0 = null;
		this.object_0 = null;
		this.gclass104_0 = null;
		this.int_2 = -1;
		this.gclass61_0 = null;
		this.int_3 = 0;
		this.byte_0 = (byte)(GClass83.int_0 | GClass83.int_1);
	}

	public void Dispose()
	{
		if (!this.bool_0)
		{
			this.object_0 = null;
			if (this.gclass104_0 != null)
			{
				this.gclass104_0.method_12().method_2(this);
			}
			this.gclass104_0 = null;
			this.int_2 = -1;
			if (this.gclass70_0 != null)
			{
				for (int i = 0; i < this.gclass70_0.Count; i++)
				{
					GClass97 gclass = this.gclass70_0.method_9(i);
					gclass.method_49(null);
					gclass.System.IDisposable.Dispose();
				}
				this.gclass70_0 = null;
			}
			this.gclass61_0 = null;
			this.byte_0 = 0;
			this.bool_0 = true;
		}
	}

	internal bool method_7(int int_4)
	{
		return ((int)this.byte_0 & int_4) != 0;
	}

	internal void method_8(int int_4, bool bool_1)
	{
		this.byte_0 = (byte)(bool_1 ? ((int)this.byte_0 | int_4) : ((int)this.byte_0 & ~int_4));
	}

	public GClass70 method_9()
	{
		if (this.gclass70_0 == null)
		{
			this.gclass70_0 = new GClass70(this);
		}
		return this.gclass70_0;
	}

	public object method_10()
	{
		return this.object_0;
	}

	public void method_11(object object_1)
	{
		this.object_0 = object_1;
	}

	public GClass61 method_12()
	{
		return this.gclass61_0;
	}

	public void method_13(GClass61 gclass61_1)
	{
		if (this.gclass61_0 != gclass61_1)
		{
			this.gclass61_0 = gclass61_1;
			this.vmethod_0(new GEventArgs6(this, GEnum65.const_4));
		}
	}

	public Color method_14()
	{
		if (this.method_12() == null)
		{
			return Color.Transparent;
		}
		return this.method_12().method_2();
	}

	public void method_15(Color color_0)
	{
		if (this.method_12() == null)
		{
			this.method_13(new GClass61());
		}
		if (this.method_12().method_2() != color_0)
		{
			this.method_12().method_3(color_0);
			this.vmethod_0(new GEventArgs6(this, GEnum65.const_1));
		}
	}

	bool method_16()
	{
		return this.gclass61_0 != null && this.gclass61_0.method_2() != Color.Empty;
	}

	public Color method_17()
	{
		if (this.method_12() == null)
		{
			if (this.method_31() != null && this.method_31().method_18() != null)
			{
				return this.method_31().method_18().ForeColor;
			}
			return Color.Black;
		}
		else
		{
			if ((this.method_12().method_4() == Color.Empty || this.method_12().method_4() == Color.Transparent) && this.method_31() != null && this.method_31().method_18() != null)
			{
				return this.method_31().method_18().ForeColor;
			}
			return this.method_12().method_4();
		}
	}

	public void method_18(Color color_0)
	{
		if (this.method_12() == null)
		{
			this.method_13(new GClass61());
		}
		if (this.method_12().method_4() != color_0)
		{
			this.method_12().method_5(color_0);
			this.vmethod_0(new GEventArgs6(this, GEnum65.const_2));
		}
	}

	bool method_19()
	{
		return this.gclass61_0 != null && this.gclass61_0.method_4() != Color.Empty;
	}

	public GEnum38 method_20()
	{
		if (this.method_12() == null)
		{
			return GEnum38.const_1;
		}
		return this.method_12().method_6();
	}

	public void method_21(GEnum38 genum38_0)
	{
		if (!Enum.IsDefined(typeof(GEnum38), genum38_0))
		{
			throw new InvalidEnumArgumentException("value", (int)genum38_0, typeof(GEnum38));
		}
		if (this.method_12() == null)
		{
			this.method_13(new GClass61());
		}
		if (this.method_12().method_6() != genum38_0)
		{
			this.method_12().method_7(genum38_0);
			this.vmethod_0(new GEventArgs6(this, GEnum65.const_5));
		}
	}

	public Font method_22()
	{
		if (this.method_12() == null)
		{
			if (this.method_31() != null && this.method_31().method_18() != null)
			{
				return this.method_31().method_18().Font;
			}
			return null;
		}
		else
		{
			if (this.method_12().method_0() == null && this.method_31() != null && this.method_31().method_18() != null)
			{
				return this.method_31().method_18().Font;
			}
			return this.method_12().method_0();
		}
	}

	public void method_23(Font font_0)
	{
		if (this.method_12() == null)
		{
			this.method_13(new GClass61());
		}
		if (this.method_12().method_0() != font_0)
		{
			this.method_12().method_1(font_0);
			this.vmethod_0(new GEventArgs6(this, GEnum65.const_3));
		}
	}

	bool method_24()
	{
		return this.gclass61_0 != null && this.gclass61_0.method_0() != null;
	}

	public bool method_25()
	{
		return this.method_7(GClass83.int_0) && this.method_28();
	}

	public void method_26(bool bool_1)
	{
		bool flag = this.method_25();
		this.method_8(GClass83.int_0, bool_1);
		if (flag != bool_1)
		{
			this.vmethod_0(new GEventArgs6(this, GEnum65.const_7));
		}
	}

	bool method_27()
	{
		return !this.method_7(GClass83.int_0);
	}

	public bool method_28()
	{
		return this.method_7(GClass83.int_1) && (this.method_31() == null || this.method_31().method_22());
	}

	public void method_29(bool bool_1)
	{
		bool flag = this.method_28();
		this.method_8(GClass83.int_1, bool_1);
		if (flag != bool_1)
		{
			this.vmethod_0(new GEventArgs6(this, GEnum65.const_6));
		}
	}

	bool method_30()
	{
		return !this.method_7(GClass83.int_1);
	}

	public GClass104 method_31()
	{
		return this.gclass104_0;
	}

	internal GClass104 method_32()
	{
		return this.gclass104_0;
	}

	internal void method_33(GClass104 gclass104_1)
	{
		this.gclass104_0 = gclass104_1;
	}

	public int method_34()
	{
		return this.int_2;
	}

	internal int method_35()
	{
		return this.int_2;
	}

	internal void method_36(int int_4)
	{
		this.int_2 = int_4;
	}

	internal void method_37(int int_4)
	{
		if (int_4 == -1)
		{
			int_4 = 0;
		}
		for (int i = int_4; i < this.method_9().Count; i++)
		{
			this.method_9().method_9(i).method_52(i);
		}
	}

	protected internal bool method_38()
	{
		return this.method_31() == null || this.method_31().method_21();
	}

	public int method_39()
	{
		return this.int_3;
	}

	internal int method_40()
	{
		return this.int_3;
	}

	internal void method_41(int int_4)
	{
		this.int_3 = int_4;
	}

	public bool method_42()
	{
		return this.int_3 > 0;
	}

	public bool method_43(int int_4)
	{
		return this.method_9().Count != 0 && (int_4 >= 0 && int_4 < this.method_9().Count) && this.method_9().method_9(int_4).method_13();
	}

	internal void method_44()
	{
		this.int_3 = 0;
		for (int i = 0; i < this.method_9().Count; i++)
		{
			this.method_9().method_9(i).method_14(false);
		}
	}

	public GClass97[] method_45()
	{
		if (this.method_39() != 0 && this.method_9().Count != 0)
		{
			GClass97[] array = new GClass97[this.method_39()];
			int num = 0;
			for (int i = 0; i < this.method_9().Count; i++)
			{
				if (this.method_9().method_9(i).method_13())
				{
					array[num] = this.method_9().method_9(i);
					num++;
				}
			}
			return array;
		}
		return new GClass97[0];
	}

	public int[] method_46()
	{
		if (this.method_9().Count == 0)
		{
			return new int[0];
		}
		int[] array = new int[this.method_39()];
		int num = 0;
		for (int i = 0; i < this.method_9().Count; i++)
		{
			if (this.method_9().method_9(i).method_13())
			{
				array[num] = i;
				num++;
			}
		}
		return array;
	}

	protected virtual void vmethod_0(GEventArgs6 geventArgs6_0)
	{
		geventArgs6_0.method_2(this.method_34());
		if (this.method_38())
		{
			if (this.method_31() != null)
			{
				this.method_31().method_24(geventArgs6_0);
			}
			if (this.gdelegate3_2 != null)
			{
				this.gdelegate3_2(this, geventArgs6_0);
			}
		}
	}

	protected internal virtual void vmethod_1(GEventArgs6 geventArgs6_0)
	{
		geventArgs6_0.method_2(this.method_34());
		geventArgs6_0.method_3().method_49(this);
		geventArgs6_0.method_3().method_52(geventArgs6_0.method_4());
		geventArgs6_0.method_3().method_14(false);
		this.method_37(geventArgs6_0.method_4());
		if (this.method_38())
		{
			if (this.method_31() != null)
			{
				this.method_31().method_25(geventArgs6_0);
			}
			if (this.gdelegate3_0 != null)
			{
				this.gdelegate3_0(this, geventArgs6_0);
			}
		}
	}

	protected internal virtual void vmethod_2(GEventArgs6 geventArgs6_0)
	{
		geventArgs6_0.method_2(this.method_34());
		if (geventArgs6_0.method_3() != null)
		{
			if (geventArgs6_0.method_3().method_47() == this)
			{
				geventArgs6_0.method_3().method_49(null);
				geventArgs6_0.method_3().method_52(-1);
				if (geventArgs6_0.method_3().method_13())
				{
					geventArgs6_0.method_3().method_14(false);
					this.method_41(this.method_40() - 1);
					if (this.method_39() == 0 && this.method_31() != null)
					{
						this.method_31().method_13().method_21(this);
					}
				}
			}
		}
		else if (geventArgs6_0.method_4() == -1 && geventArgs6_0.method_5() == -1 && this.method_39() != 0 && this.method_31() != null)
		{
			this.method_41(0);
			this.method_31().method_13().method_21(this);
		}
		this.method_37(geventArgs6_0.method_4());
		if (this.method_38())
		{
			if (this.method_31() != null)
			{
				this.method_31().method_26(geventArgs6_0);
			}
			if (this.gdelegate3_1 != null)
			{
				this.gdelegate3_1(this, geventArgs6_0);
			}
		}
	}

	internal void method_47(GEventArgs1 geventArgs1_0)
	{
		if (this.method_31() != null)
		{
			this.method_31().method_27(geventArgs1_0);
		}
	}

	GDelegate3 gdelegate3_0;

	GDelegate3 gdelegate3_1;

	GDelegate3 gdelegate3_2;

	static readonly int int_0 = 1;

	static readonly int int_1 = 2;

	GClass70 gclass70_0;

	object object_0;

	GClass104 gclass104_0;

	int int_2;

	byte byte_0;

	GClass61 gclass61_0;

	int int_3;

	bool bool_0;
}
