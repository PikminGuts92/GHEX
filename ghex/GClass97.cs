using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignTimeVisible(true)]
[TypeConverter(typeof(GClass84))]
public class GClass97 : IDisposable
{
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_0(GDelegate7 gdelegate7_1)
	{
		this.gdelegate7_0 = (GDelegate7)Delegate.Combine(this.gdelegate7_0, gdelegate7_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_1(GDelegate7 gdelegate7_1)
	{
		this.gdelegate7_0 = (GDelegate7)Delegate.Remove(this.gdelegate7_0, gdelegate7_1);
	}

	public GClass97()
	{
		this.method_2();
	}

	public GClass97(string string_2)
	{
		this.method_2();
		this.string_0 = string_2;
	}

	public GClass97(object object_3)
	{
		this.method_2();
		this.object_0 = object_3;
	}

	public GClass97(string string_2, object object_3)
	{
		this.method_2();
		this.string_0 = string_2;
		this.object_0 = object_3;
	}

	public GClass97(string string_2, bool bool_1)
	{
		this.method_2();
		this.string_0 = string_2;
		this.method_28(bool_1);
	}

	public GClass97(string string_2, Image image_0)
	{
		this.method_2();
		this.string_0 = string_2;
		this.method_34(image_0);
	}

	public GClass97(string string_2, Color color_0, Color color_1, Font font_0)
	{
		this.method_2();
		this.string_0 = string_2;
		this.method_19(color_0);
		this.method_16(color_1);
		this.method_22(font_0);
	}

	public GClass97(string string_2, GClass150 gclass150_1)
	{
		this.method_2();
		this.string_0 = string_2;
		this.gclass150_0 = gclass150_1;
	}

	public GClass97(object object_3, Color color_0, Color color_1, Font font_0)
	{
		this.method_2();
		this.object_0 = object_3;
		this.method_19(color_0);
		this.method_16(color_1);
		this.method_22(font_0);
	}

	public GClass97(object object_3, GClass150 gclass150_1)
	{
		this.method_2();
		this.object_0 = object_3;
		this.gclass150_0 = gclass150_1;
	}

	public GClass97(string string_2, object object_3, Color color_0, Color color_1, Font font_0)
	{
		this.method_2();
		this.string_0 = string_2;
		this.object_0 = object_3;
		this.method_19(color_0);
		this.method_16(color_1);
		this.method_22(font_0);
	}

	public GClass97(string string_2, object object_3, GClass150 gclass150_1)
	{
		this.method_2();
		this.string_0 = string_2;
		this.object_0 = object_3;
		this.gclass150_0 = gclass150_1;
	}

	public GClass97(string string_2, bool bool_1, Color color_0, Color color_1, Font font_0)
	{
		this.method_2();
		this.string_0 = string_2;
		this.method_28(bool_1);
		this.method_19(color_0);
		this.method_16(color_1);
		this.method_22(font_0);
	}

	public GClass97(string string_2, bool bool_1, GClass150 gclass150_1)
	{
		this.method_2();
		this.string_0 = string_2;
		this.method_28(bool_1);
		this.gclass150_0 = gclass150_1;
	}

	public GClass97(string string_2, Image image_0, Color color_0, Color color_1, Font font_0)
	{
		this.method_2();
		this.string_0 = string_2;
		this.method_34(image_0);
		this.method_19(color_0);
		this.method_16(color_1);
		this.method_22(font_0);
	}

	public GClass97(string string_2, Image image_0, GClass150 gclass150_1)
	{
		this.method_2();
		this.string_0 = string_2;
		this.method_34(image_0);
		this.gclass150_0 = gclass150_1;
	}

	void method_2()
	{
		this.string_0 = null;
		this.object_0 = null;
		this.object_2 = null;
		this.object_1 = null;
		this.gclass83_0 = null;
		this.int_3 = -1;
		this.gclass150_0 = null;
		this.class101_0 = null;
		this.class115_0 = null;
		this.string_1 = null;
		this.byte_0 = (byte)(GClass97.int_0 | GClass97.int_1);
	}

	public void Dispose()
	{
		if (!this.bool_0)
		{
			this.string_0 = null;
			this.object_0 = null;
			this.object_1 = null;
			this.object_2 = null;
			if (this.gclass83_0 != null)
			{
				this.gclass83_0.method_9().method_2(this);
			}
			this.gclass83_0 = null;
			this.int_3 = -1;
			this.gclass150_0 = null;
			this.class101_0 = null;
			this.class115_0 = null;
			this.string_1 = null;
			this.byte_0 = 0;
			this.bool_0 = true;
		}
	}

	internal bool method_3(int int_4)
	{
		return ((int)this.byte_0 & int_4) != 0;
	}

	internal void method_4(int int_4, bool bool_1)
	{
		this.byte_0 = (byte)(bool_1 ? ((int)this.byte_0 | int_4) : ((int)this.byte_0 & ~int_4));
	}

	public string method_5()
	{
		return this.string_0;
	}

	public void method_6(string string_2)
	{
		if (this.string_0 == null || !this.string_0.Equals(string_2))
		{
			string text = this.method_5();
			this.string_0 = string_2;
			this.vmethod_0(new GEventArgs1(this, GEnum6.const_1, text));
		}
	}

	public object method_7()
	{
		return this.object_0;
	}

	public void method_8(object object_3)
	{
		if (this.object_0 != object_3)
		{
			object obj = this.method_7();
			this.object_0 = object_3;
			this.vmethod_0(new GEventArgs1(this, GEnum6.const_1, obj));
		}
	}

	public object method_9()
	{
		return this.object_1;
	}

	public void method_10(object object_3)
	{
		this.object_1 = object_3;
	}

	public GClass150 method_11()
	{
		return this.gclass150_0;
	}

	public void method_12(GClass150 gclass150_1)
	{
		if (this.gclass150_0 != gclass150_1)
		{
			GClass150 gclass = this.method_11();
			this.gclass150_0 = gclass150_1;
			this.vmethod_0(new GEventArgs1(this, GEnum6.const_5, gclass));
		}
	}

	public bool method_13()
	{
		return this.method_3(GClass97.int_2);
	}

	internal void method_14(bool bool_1)
	{
		this.method_4(GClass97.int_2, bool_1);
	}

	public Color method_15()
	{
		if (this.method_11() != null)
		{
			return this.method_11().method_2();
		}
		if (this.method_47() != null)
		{
			return this.method_47().method_14();
		}
		return Color.Transparent;
	}

	public void method_16(Color color_0)
	{
		if (this.method_11() == null)
		{
			this.method_12(new GClass150());
		}
		if (this.method_11().method_2() != color_0)
		{
			Color color = this.method_15();
			this.method_11().method_3(color_0);
			this.vmethod_0(new GEventArgs1(this, GEnum6.const_3, color));
		}
	}

	bool method_17()
	{
		return this.gclass150_0 != null && this.gclass150_0.method_2() != Color.Empty;
	}

	public Color method_18()
	{
		if (this.method_11() == null)
		{
			if (this.method_47() != null)
			{
				return this.method_47().method_17();
			}
			return Color.Transparent;
		}
		else
		{
			if ((this.method_11().method_4() == Color.Empty || this.method_11().method_4() == Color.Transparent) && this.method_47() != null)
			{
				return this.method_47().method_17();
			}
			return this.method_11().method_4();
		}
	}

	public void method_19(Color color_0)
	{
		if (this.method_11() == null)
		{
			this.method_12(new GClass150());
		}
		if (this.method_11().method_4() != color_0)
		{
			Color color = this.method_18();
			this.method_11().method_5(color_0);
			this.vmethod_0(new GEventArgs1(this, GEnum6.const_4, color));
		}
	}

	bool method_20()
	{
		return this.gclass150_0 != null && this.gclass150_0.method_4() != Color.Empty;
	}

	public Font method_21()
	{
		if (this.method_11() == null)
		{
			if (this.method_47() != null)
			{
				return this.method_47().method_22();
			}
			return null;
		}
		else
		{
			if (this.method_11().method_0() == null && this.method_47() != null)
			{
				return this.method_47().method_22();
			}
			return this.method_11().method_0();
		}
	}

	public void method_22(Font font_0)
	{
		if (this.method_11() == null)
		{
			this.method_12(new GClass150());
		}
		if (this.method_11().method_0() != font_0)
		{
			Font font = this.method_21();
			this.method_11().method_1(font_0);
			this.vmethod_0(new GEventArgs1(this, GEnum6.const_2, font));
		}
	}

	bool method_23()
	{
		return this.gclass150_0 != null && this.gclass150_0.method_0() != null;
	}

	public GStruct13 method_24()
	{
		if (this.method_11() == null)
		{
			return GStruct13.gstruct13_0;
		}
		return this.method_11().method_6();
	}

	public void method_25(GStruct13 gstruct13_0)
	{
		if (this.method_11() == null)
		{
			this.method_12(new GClass150());
		}
		if (GStruct13.smethod_1(this.method_11().method_6(), gstruct13_0))
		{
			GStruct13 gstruct = this.method_24();
			this.method_11().method_7(gstruct13_0);
			this.vmethod_0(new GEventArgs1(this, GEnum6.const_6, gstruct));
		}
	}

	bool method_26()
	{
		return GStruct13.smethod_1(this.method_24(), GStruct13.gstruct13_0);
	}

	public bool method_27()
	{
		return this.class101_0 != null && this.class101_0.method_0();
	}

	public void method_28(bool bool_1)
	{
		if (this.class101_0 == null)
		{
			this.class101_0 = new Class101();
		}
		if (this.class101_0.method_0() != bool_1)
		{
			bool flag = this.method_27();
			this.class101_0.method_1(bool_1);
			this.vmethod_0(new GEventArgs1(this, GEnum6.const_10, flag));
		}
	}

	public CheckState method_29()
	{
		if (this.class101_0 == null)
		{
			return CheckState.Unchecked;
		}
		return this.class101_0.method_2();
	}

	public void method_30(CheckState checkState_0)
	{
		if (!Enum.IsDefined(typeof(CheckState), checkState_0))
		{
			throw new InvalidEnumArgumentException("value", (int)checkState_0, typeof(CheckState));
		}
		if (this.class101_0 == null)
		{
			this.class101_0 = new Class101();
		}
		if (this.class101_0.method_2() != checkState_0)
		{
			CheckState checkState = this.method_29();
			this.class101_0.method_3(checkState_0);
			this.vmethod_0(new GEventArgs1(this, GEnum6.const_10, checkState));
		}
	}

	public bool method_31()
	{
		return this.class101_0 != null && this.class101_0.method_4();
	}

	public void method_32(bool bool_1)
	{
		if (this.class101_0 == null)
		{
			this.class101_0 = new Class101();
		}
		if (this.class101_0.method_4() != bool_1)
		{
			bool flag = this.method_31();
			this.class101_0.method_5(bool_1);
			this.vmethod_0(new GEventArgs1(this, GEnum6.const_11, flag));
		}
	}

	public Image method_33()
	{
		if (this.class115_0 == null)
		{
			return null;
		}
		return this.class115_0.method_0();
	}

	public void method_34(Image image_0)
	{
		if (this.class115_0 == null)
		{
			this.class115_0 = new Class115();
		}
		if (this.class115_0.method_0() != image_0)
		{
			Image image = this.method_33();
			this.class115_0.method_1(image_0);
			this.vmethod_0(new GEventArgs1(this, GEnum6.const_12, image));
		}
	}

	public GEnum34 method_35()
	{
		if (this.class115_0 == null)
		{
			return GEnum34.const_0;
		}
		return this.class115_0.method_2();
	}

	public void method_36(GEnum34 genum34_0)
	{
		if (this.class115_0 == null)
		{
			this.class115_0 = new Class115();
		}
		if (this.class115_0.method_2() != genum34_0)
		{
			GEnum34 genum = this.method_35();
			this.class115_0.method_3(genum34_0);
			this.vmethod_0(new GEventArgs1(this, GEnum6.const_13, genum));
		}
	}

	public bool method_37()
	{
		if (!this.method_3(GClass97.int_0))
		{
			return false;
		}
		if (this.method_47() == null)
		{
			return this.method_40();
		}
		return this.method_40() && this.method_47().method_25();
	}

	public void method_38(bool bool_1)
	{
		bool flag = this.method_37();
		this.method_4(GClass97.int_0, bool_1);
		if (flag != bool_1)
		{
			this.vmethod_0(new GEventArgs1(this, GEnum6.const_7, flag));
		}
	}

	bool method_39()
	{
		return !this.method_3(GClass97.int_0);
	}

	public bool method_40()
	{
		return this.method_3(GClass97.int_1) && (this.method_47() == null || this.method_47().method_28());
	}

	public void method_41(bool bool_1)
	{
		bool flag = this.method_40();
		this.method_4(GClass97.int_1, bool_1);
		if (flag != bool_1)
		{
			this.vmethod_0(new GEventArgs1(this, GEnum6.const_8, flag));
		}
	}

	bool method_42()
	{
		return !this.method_3(GClass97.int_1);
	}

	public string method_43()
	{
		return this.string_1;
	}

	public void method_44(string string_2)
	{
		if (this.string_1 != string_2)
		{
			string text = this.string_1;
			this.string_1 = string_2;
			this.vmethod_0(new GEventArgs1(this, GEnum6.const_9, text));
		}
	}

	protected internal object method_45()
	{
		return this.object_2;
	}

	protected internal void method_46(object object_3)
	{
		this.object_2 = object_3;
	}

	public GClass83 method_47()
	{
		return this.gclass83_0;
	}

	internal GClass83 method_48()
	{
		return this.gclass83_0;
	}

	internal void method_49(GClass83 gclass83_1)
	{
		this.gclass83_0 = gclass83_1;
	}

	public int method_50()
	{
		return this.int_3;
	}

	internal int method_51()
	{
		return this.int_3;
	}

	internal void method_52(int int_4)
	{
		this.int_3 = int_4;
	}

	protected internal bool method_53()
	{
		return this.method_47() == null || this.method_47().method_38();
	}

	protected virtual void vmethod_0(GEventArgs1 geventArgs1_0)
	{
		geventArgs1_0.method_2(this.method_50());
		if (this.method_47() != null)
		{
			geventArgs1_0.method_4(this.method_47().method_34());
		}
		if (this.method_53())
		{
			if (this.method_47() != null)
			{
				this.method_47().method_47(geventArgs1_0);
			}
			if (this.gdelegate7_0 != null)
			{
				this.gdelegate7_0(this, geventArgs1_0);
			}
		}
	}

	GDelegate7 gdelegate7_0;

	static readonly int int_0 = 1;

	static readonly int int_1 = 2;

	static readonly int int_2 = 4;

	string string_0;

	object object_0;

	object object_1;

	object object_2;

	GClass83 gclass83_0;

	int int_3;

	byte byte_0;

	GClass150 gclass150_0;

	Class101 class101_0;

	Class115 class115_0;

	string string_1;

	bool bool_0;
}
