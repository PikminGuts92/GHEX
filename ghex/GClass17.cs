using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignTimeVisible(false)]
[ToolboxItem(false)]
public abstract class GClass17 : Component
{
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_0(GDelegate11 gdelegate11_1)
	{
		this.gdelegate11_0 = (GDelegate11)Delegate.Combine(this.gdelegate11_0, gdelegate11_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_1(GDelegate11 gdelegate11_1)
	{
		this.gdelegate11_0 = (GDelegate11)Delegate.Remove(this.gdelegate11_0, gdelegate11_1);
	}

	public GClass17()
	{
		this.method_2();
	}

	public GClass17(string string_3)
	{
		this.method_2();
		this.string_0 = string_3;
	}

	public GClass17(string string_3, int int_11)
	{
		this.method_2();
		this.string_0 = string_3;
		this.int_9 = int_11;
	}

	public GClass17(string string_3, int int_11, bool bool_1)
	{
		this.method_2();
		this.string_0 = string_3;
		this.int_9 = int_11;
		this.method_20(bool_1);
	}

	public GClass17(string string_3, Image image_1)
	{
		this.method_2();
		this.string_0 = string_3;
		this.image_0 = image_1;
	}

	public GClass17(string string_3, Image image_1, int int_11)
	{
		this.method_2();
		this.string_0 = string_3;
		this.image_0 = image_1;
		this.int_9 = int_11;
	}

	public GClass17(string string_3, Image image_1, int int_11, bool bool_1)
	{
		this.method_2();
		this.string_0 = string_3;
		this.image_0 = image_1;
		this.int_9 = int_11;
		this.method_20(bool_1);
	}

	void method_2()
	{
		this.string_0 = null;
		this.int_9 = GClass17.int_6;
		this.genum62_0 = GEnum62.const_0;
		this.genum39_0 = GEnum39.const_0;
		this.image_0 = null;
		this.bool_0 = false;
		this.gclass32_0 = null;
		this.int_10 = 0;
		this.string_2 = null;
		this.string_1 = "";
		this.sortOrder_0 = SortOrder.None;
		this.ginterface2_0 = null;
		this.ginterface3_0 = null;
		this.type_0 = null;
		this.byte_0 = (byte)(GClass17.int_1 | GClass17.int_0 | GClass17.int_2 | GClass17.int_3 | GClass17.int_4);
	}

	public abstract string vmethod_0();

	public abstract GInterface2 vmethod_1();

	public abstract string vmethod_2();

	public abstract GInterface3 vmethod_3();

	internal bool method_3(int int_11)
	{
		return ((int)this.byte_0 & int_11) != 0;
	}

	internal void method_4(int int_11, bool bool_1)
	{
		this.byte_0 = (byte)(bool_1 ? ((int)this.byte_0 | int_11) : ((int)this.byte_0 & ~int_11));
	}

	public string method_5()
	{
		return this.string_0;
	}

	public void method_6(string string_3)
	{
		if (string_3 == null)
		{
			string_3 = "";
		}
		if (!string_3.Equals(this.string_0))
		{
			string object_ = this.string_0;
			this.string_0 = string_3;
			this.vmethod_13(new GClass93(this, GEnum13.const_1, object_));
		}
	}

	public string method_7()
	{
		return this.string_1;
	}

	public void method_8(string string_3)
	{
		if (string_3 == null)
		{
			string_3 = "";
		}
		if (!string_3.Equals(this.string_1))
		{
			string object_ = this.string_1;
			this.string_1 = string_3;
			this.vmethod_13(new GClass93(this, GEnum13.const_7, object_));
		}
	}

	public virtual GEnum39 vmethod_4()
	{
		return this.genum39_0;
	}

	public virtual void vmethod_5(GEnum39 genum39_1)
	{
		if (!Enum.IsDefined(typeof(GEnum39), genum39_1))
		{
			throw new InvalidEnumArgumentException("value", (int)genum39_1, typeof(GEnum39));
		}
		if (this.genum39_0 != genum39_1)
		{
			GEnum39 genum = this.genum39_0;
			this.genum39_0 = genum39_1;
			this.vmethod_13(new GClass93(this, GEnum13.const_2, genum));
		}
	}

	public int method_9()
	{
		return this.int_9;
	}

	public void method_10(int int_11)
	{
		if (this.int_9 != int_11)
		{
			int num = this.method_9();
			this.int_9 = Math.Min(Math.Max(int_11, GClass17.int_8), GClass17.int_7);
			this.vmethod_13(new GClass93(this, GEnum13.const_4, num));
		}
	}

	bool method_11()
	{
		return this.method_9() != GClass17.int_6;
	}

	public Image method_12()
	{
		return this.image_0;
	}

	public void method_13(Image image_1)
	{
		if (this.image_0 != image_1)
		{
			Image object_ = this.method_12();
			this.image_0 = image_1;
			this.vmethod_13(new GClass93(this, GEnum13.const_6, object_));
		}
	}

	public bool method_14()
	{
		return this.bool_0;
	}

	public void method_15(bool bool_1)
	{
		if (this.bool_0 != bool_1)
		{
			this.bool_0 = bool_1;
			this.vmethod_13(new GClass93(this, GEnum13.const_6, null));
		}
	}

	public GEnum62 method_16()
	{
		return this.genum62_0;
	}

	internal GEnum62 method_17()
	{
		return this.method_16();
	}

	internal void method_18(GEnum62 genum62_1)
	{
		if (!Enum.IsDefined(typeof(GEnum62), genum62_1))
		{
			throw new InvalidEnumArgumentException("value", (int)genum62_1, typeof(GEnum62));
		}
		if (this.genum62_0 != genum62_1)
		{
			GEnum62 genum = this.genum62_0;
			this.genum62_0 = genum62_1;
			this.vmethod_13(new GClass93(this, GEnum13.const_8, genum));
		}
	}

	public bool method_19()
	{
		return this.method_3(GClass17.int_2);
	}

	public void method_20(bool bool_1)
	{
		bool flag = this.method_19();
		this.method_4(GClass17.int_2, bool_1);
		if (flag != bool_1)
		{
			this.vmethod_13(new GClass93(this, GEnum13.const_5, flag));
		}
	}

	public virtual bool vmethod_6()
	{
		return this.method_3(GClass17.int_4);
	}

	public virtual void vmethod_7(bool bool_1)
	{
		bool flag = this.vmethod_6();
		this.method_4(GClass17.int_4, bool_1);
		if (flag != bool_1)
		{
			this.vmethod_13(new GClass93(this, GEnum13.const_15, flag));
		}
	}

	public GInterface2 method_21()
	{
		return this.ginterface2_0;
	}

	public void method_22(GInterface2 ginterface2_1)
	{
		if (this.ginterface2_0 != ginterface2_1)
		{
			this.ginterface2_0 = ginterface2_1;
			this.vmethod_13(new GClass93(this, GEnum13.const_9, null));
		}
	}

	public GInterface3 method_23()
	{
		return this.ginterface3_0;
	}

	public void method_24(GInterface3 ginterface3_1)
	{
		if (this.ginterface3_0 != ginterface3_1)
		{
			this.ginterface3_0 = ginterface3_1;
			this.vmethod_13(new GClass93(this, GEnum13.const_10, null));
		}
	}

	public Type method_25()
	{
		return this.type_0;
	}

	public void method_26(Type type_1)
	{
		if (this.type_0 != type_1)
		{
			this.type_0 = type_1;
			this.vmethod_13(new GClass93(this, GEnum13.const_11, null));
		}
	}

	public abstract Type vmethod_8();

	public SortOrder method_27()
	{
		return this.sortOrder_0;
	}

	internal SortOrder method_28()
	{
		return this.method_27();
	}

	internal void method_29(SortOrder sortOrder_1)
	{
		if (!Enum.IsDefined(typeof(SortOrder), sortOrder_1))
		{
			throw new InvalidEnumArgumentException("value", (int)sortOrder_1, typeof(SortOrder));
		}
		if (this.sortOrder_0 != sortOrder_1)
		{
			SortOrder sortOrder = this.sortOrder_0;
			this.sortOrder_0 = sortOrder_1;
			this.vmethod_13(new GClass93(this, GEnum13.const_16, sortOrder));
		}
	}

	public virtual bool vmethod_9()
	{
		return this.method_3(GClass17.int_0) && this.method_19() && this.method_31();
	}

	public virtual void vmethod_10(bool bool_1)
	{
		bool flag = this.method_3(GClass17.int_0);
		this.method_4(GClass17.int_0, bool_1);
		if (flag != bool_1)
		{
			this.vmethod_13(new GClass93(this, GEnum13.const_13, flag));
		}
	}

	bool method_30()
	{
		return !this.method_3(GClass17.int_0);
	}

	public bool method_31()
	{
		return this.method_3(GClass17.int_1) && (this.method_40() == null || this.method_40().method_36());
	}

	public void method_32(bool bool_1)
	{
		bool flag = this.method_3(GClass17.int_1);
		this.method_4(GClass17.int_1, bool_1);
		if (flag != bool_1)
		{
			this.vmethod_13(new GClass93(this, GEnum13.const_12, flag));
		}
	}

	bool method_33()
	{
		return !this.method_3(GClass17.int_1);
	}

	public virtual bool vmethod_11()
	{
		return this.method_3(GClass17.int_3);
	}

	public virtual void vmethod_12(bool bool_1)
	{
		bool flag = this.vmethod_11();
		this.method_4(GClass17.int_3, bool_1);
		if (flag != bool_1)
		{
			this.vmethod_13(new GClass93(this, GEnum13.const_14, flag));
		}
	}

	public string method_34()
	{
		return this.string_2;
	}

	public void method_35(string string_3)
	{
		if (string_3 == null)
		{
			string_3 = "";
		}
		if (!string_3.Equals(this.string_2))
		{
			string object_ = this.string_2;
			this.string_2 = string_3;
			this.vmethod_13(new GClass93(this, GEnum13.const_17, object_));
		}
	}

	internal int method_36()
	{
		return this.int_10;
	}

	internal void method_37(int int_11)
	{
		this.int_10 = int_11;
	}

	public int method_38()
	{
		return this.method_36();
	}

	public int method_39()
	{
		return this.method_38() + this.method_9();
	}

	protected internal GClass32 method_40()
	{
		return this.gclass32_0;
	}

	protected internal void method_41(GClass32 gclass32_1)
	{
		this.gclass32_0 = gclass32_1;
	}

	public GClass32 method_42()
	{
		return this.method_40();
	}

	protected bool method_43()
	{
		return this.method_40() == null || this.method_40().method_35();
	}

	protected virtual void vmethod_13(GClass93 gclass93_0)
	{
		if (this.method_40() != null)
		{
			gclass93_0.method_3(this.method_40().method_23().method_6(this));
		}
		if (this.method_43())
		{
			if (this.method_40() != null)
			{
				this.method_40().method_37(gclass93_0);
			}
			if (this.gdelegate11_0 != null)
			{
				this.gdelegate11_0(this, gclass93_0);
			}
		}
	}

	GDelegate11 gdelegate11_0;

	static readonly int int_0 = 1;

	static readonly int int_1 = 2;

	static readonly int int_2 = 4;

	static readonly int int_3 = 8;

	static readonly int int_4 = 16;

	public static readonly int int_5 = 8;

	public static readonly int int_6 = 75;

	public static readonly int int_7 = 1024;

	public static readonly int int_8 = GClass17.int_5 * 2;

	public byte byte_0;

	string string_0;

	string string_1;

	GEnum39 genum39_0;

	int int_9;

	Image image_0;

	bool bool_0;

	GEnum62 genum62_0;

	string string_2;

	GClass32 gclass32_0;

	int int_10;

	SortOrder sortOrder_0;

	GInterface2 ginterface2_0;

	GInterface3 ginterface3_0;

	Type type_0;
}
