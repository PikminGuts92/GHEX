using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

[ToolboxItem(true)]
[ToolboxBitmap(typeof(GClass32))]
[DesignTimeVisible(true)]
public class GClass32 : Component
{
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_0(GDelegate9 gdelegate9_2)
	{
		this.gdelegate9_0 = (GDelegate9)Delegate.Combine(this.gdelegate9_0, gdelegate9_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_1(GDelegate9 gdelegate9_2)
	{
		this.gdelegate9_0 = (GDelegate9)Delegate.Remove(this.gdelegate9_0, gdelegate9_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_2(GDelegate9 gdelegate9_2)
	{
		this.gdelegate9_1 = (GDelegate9)Delegate.Combine(this.gdelegate9_1, gdelegate9_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_3(GDelegate9 gdelegate9_2)
	{
		this.gdelegate9_1 = (GDelegate9)Delegate.Remove(this.gdelegate9_1, gdelegate9_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_4(EventHandler eventHandler_1)
	{
		this.eventHandler_0 = (EventHandler)Delegate.Combine(this.eventHandler_0, eventHandler_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_5(EventHandler eventHandler_1)
	{
		this.eventHandler_0 = (EventHandler)Delegate.Remove(this.eventHandler_0, eventHandler_1);
	}

	public GClass32()
	{
		this.method_6();
	}

	public GClass32(string[] string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("columns", "string[] cannot be null");
		}
		this.method_6();
		if (string_0.Length > 0)
		{
			GClass17[] array = new GClass17[string_0.Length];
			for (int i = 0; i < string_0.Length; i++)
			{
				array[i] = new GClass25(string_0[i]);
			}
			this.method_23().method_1(array);
		}
	}

	public GClass32(GClass17[] gclass17_0)
	{
		if (gclass17_0 == null)
		{
			throw new ArgumentNullException("columns", "Column[] cannot be null");
		}
		this.method_6();
		if (gclass17_0.Length > 0)
		{
			this.method_23().method_1(gclass17_0);
		}
	}

	void method_6()
	{
		this.gclass85_0 = null;
		this.gcontrol2_0 = null;
		this.int_3 = GClass32.int_0;
		this.hashtable_0 = new Hashtable();
		this.method_18("TEXT", new GClass11());
		this.hashtable_1 = new Hashtable();
		this.method_13("TEXT", new GClass50());
	}

	public int method_7(int int_4)
	{
		if (int_4 >= 0 && int_4 <= this.method_29())
		{
			for (int i = 0; i < this.method_23().Count; i++)
			{
				if (this.method_23().method_8(i).method_19() && int_4 < this.method_23().method_8(i).method_39())
				{
					return i;
				}
			}
			return -1;
		}
		return -1;
	}

	public GClass17 method_8(int int_4)
	{
		if (int_4 < 0 || int_4 > this.method_29())
		{
			return null;
		}
		int num = this.method_7(int_4);
		if (num != -1)
		{
			return this.method_23().method_8(num);
		}
		return null;
	}

	public Rectangle method_9(int int_4)
	{
		if (int_4 >= 0 && int_4 < this.method_23().Count && this.method_23().method_8(int_4).method_19())
		{
			return new Rectangle(this.method_23().method_8(int_4).method_38(), 0, this.method_23().method_8(int_4).method_9(), this.method_24());
		}
		return Rectangle.Empty;
	}

	public Rectangle method_10(GClass17 gclass17_0)
	{
		int num = this.method_23().method_6(gclass17_0);
		if (num == -1)
		{
			return Rectangle.Empty;
		}
		return this.method_9(num);
	}

	protected virtual void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	public GInterface3 method_11(string string_0)
	{
		if (string_0 == null || string_0.Length == 0)
		{
			return null;
		}
		string_0 = string_0.ToUpper();
		if (!this.hashtable_1.ContainsKey(string_0))
		{
			if (this.hashtable_1.Count == 0)
			{
				this.method_13("TEXT", new GClass50());
			}
			return null;
		}
		return (GInterface3)this.hashtable_1[string_0];
	}

	public GInterface3 method_12(int int_4)
	{
		if (int_4 < 0 || int_4 >= this.method_23().Count)
		{
			return null;
		}
		if (this.method_23().method_8(int_4).method_23() != null)
		{
			return this.method_23().method_8(int_4).method_23();
		}
		return this.method_11(this.method_23().method_8(int_4).vmethod_2());
	}

	public void method_13(string string_0, GInterface3 ginterface3_0)
	{
		if (string_0 == null || string_0.Length == 0 || ginterface3_0 == null)
		{
			return;
		}
		string_0 = string_0.ToUpper();
		if (this.hashtable_1.ContainsKey(string_0))
		{
			this.hashtable_1.Remove(string_0);
			this.hashtable_1[string_0] = ginterface3_0;
			return;
		}
		this.hashtable_1.Add(string_0, ginterface3_0);
	}

	public bool method_14(string string_0)
	{
		return string_0 != null && this.hashtable_1.ContainsKey(string_0);
	}

	internal int method_15()
	{
		return this.hashtable_1.Count;
	}

	public GInterface2 method_16(string string_0)
	{
		if (string_0 == null)
		{
			string_0 = "TEXT";
		}
		string_0 = string_0.ToUpper();
		if (!this.hashtable_0.ContainsKey(string_0))
		{
			if (this.hashtable_0.Count == 0)
			{
				this.method_18("TEXT", new GClass11());
			}
			return (GInterface2)this.hashtable_0["TEXT"];
		}
		return (GInterface2)this.hashtable_0[string_0];
	}

	public GInterface2 method_17(int int_4)
	{
		if (int_4 < 0 || int_4 >= this.method_23().Count)
		{
			return null;
		}
		if (this.method_23().method_8(int_4).method_21() != null)
		{
			return this.method_23().method_8(int_4).method_21();
		}
		return this.method_16(this.method_23().method_8(int_4).vmethod_0());
	}

	public void method_18(string string_0, GInterface2 ginterface2_0)
	{
		if (string_0 == null || ginterface2_0 == null)
		{
			return;
		}
		string_0 = string_0.ToUpper();
		if (this.hashtable_0.ContainsKey(string_0))
		{
			this.hashtable_0.Remove(string_0);
			this.hashtable_0[string_0] = ginterface2_0;
			return;
		}
		this.hashtable_0.Add(string_0, ginterface2_0);
	}

	public bool method_19(string string_0)
	{
		return string_0 != null && this.hashtable_0.ContainsKey(string_0);
	}

	internal int method_20()
	{
		return this.hashtable_0.Count;
	}

	public int method_21(int int_4)
	{
		if (this.method_23().Count == 0)
		{
			return -1;
		}
		if (int_4 <= 0)
		{
			return -1;
		}
		if (int_4 >= this.method_23().Count)
		{
			if (this.method_23().method_8(this.method_23().Count - 1).method_19())
			{
				return this.method_23().Count - 1;
			}
			int_4 = this.method_23().Count - 1;
		}
		for (int i = int_4; i > 0; i--)
		{
			if (this.method_23().method_8(i - 1).method_19())
			{
				return i - 1;
			}
		}
		return -1;
	}

	public int method_22(int int_4)
	{
		if (this.method_23().Count == 0)
		{
			return -1;
		}
		if (int_4 >= this.method_23().Count - 1)
		{
			return -1;
		}
		for (int i = int_4; i < this.method_23().Count - 1; i++)
		{
			if (this.method_23().method_8(i + 1).method_19())
			{
				return i + 1;
			}
		}
		return -1;
	}

	public GClass85 method_23()
	{
		if (this.gclass85_0 == null)
		{
			this.gclass85_0 = new GClass85(this);
		}
		return this.gclass85_0;
	}

	public int method_24()
	{
		return this.int_3;
	}

	public void method_25(int int_4)
	{
		if (int_4 < GClass32.int_1)
		{
			int_4 = GClass32.int_1;
		}
		else if (int_4 > GClass32.int_2)
		{
			int_4 = GClass32.int_2;
		}
		if (this.int_3 != int_4)
		{
			this.int_3 = int_4;
			this.vmethod_2(EventArgs.Empty);
		}
	}

	bool method_26()
	{
		return this.int_3 != GClass32.int_0;
	}

	public Rectangle method_27()
	{
		if (this.method_31() == 0)
		{
			return Rectangle.Empty;
		}
		return new Rectangle(0, 0, this.method_29(), this.method_24());
	}

	public int method_28()
	{
		return this.method_23().method_10();
	}

	public int method_29()
	{
		return this.method_23().method_11();
	}

	public int method_30()
	{
		return this.method_23().method_13();
	}

	public int method_31()
	{
		return this.method_23().method_12();
	}

	public GControl2 method_32()
	{
		return this.gcontrol2_0;
	}

	internal GControl2 method_33()
	{
		return this.gcontrol2_0;
	}

	internal void method_34(GControl2 gcontrol2_1)
	{
		this.gcontrol2_0 = gcontrol2_1;
	}

	protected internal bool method_35()
	{
		return this.method_32() == null || this.method_32().method_246();
	}

	internal bool method_36()
	{
		return this.method_32() == null || this.method_32().Enabled;
	}

	protected internal virtual void vmethod_0(GClass90 gclass90_0)
	{
		gclass90_0.method_1().method_41(this);
		if (!this.method_19(gclass90_0.method_1().vmethod_0()))
		{
			this.method_18(gclass90_0.method_1().vmethod_0(), gclass90_0.method_1().vmethod_1());
		}
		if (!this.method_14(gclass90_0.method_1().vmethod_2()))
		{
			this.method_13(gclass90_0.method_1().vmethod_2(), gclass90_0.method_1().vmethod_3());
		}
		if (this.method_35())
		{
			if (this.method_32() != null)
			{
				this.method_32().vmethod_25(gclass90_0);
			}
			if (this.gdelegate9_0 != null)
			{
				this.gdelegate9_0(this, gclass90_0);
			}
		}
	}

	protected internal virtual void vmethod_1(GClass90 gclass90_0)
	{
		if (gclass90_0.method_1() != null && gclass90_0.method_1().method_40() == this)
		{
			gclass90_0.method_1().method_41(null);
		}
		if (this.method_35())
		{
			if (this.method_32() != null)
			{
				this.method_32().vmethod_26(gclass90_0);
			}
			if (this.gdelegate9_1 != null)
			{
				this.gdelegate9_1(this, gclass90_0);
			}
		}
	}

	protected virtual void vmethod_2(EventArgs eventArgs_0)
	{
		if (this.method_35())
		{
			if (this.method_32() != null)
			{
				this.method_32().vmethod_27(eventArgs_0);
			}
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, eventArgs_0);
			}
		}
	}

	internal void method_37(GClass93 gclass93_0)
	{
		if (gclass93_0.method_4() == GEnum13.const_4 || gclass93_0.method_4() == GEnum13.const_5)
		{
			this.method_23().method_7();
		}
		if (this.method_35() && this.method_32() != null)
		{
			this.method_32().vmethod_15(gclass93_0);
		}
	}

	GDelegate9 gdelegate9_0;

	GDelegate9 gdelegate9_1;

	EventHandler eventHandler_0;

	public static readonly int int_0 = 20;

	public static readonly int int_1 = 16;

	public static readonly int int_2 = 128;

	GClass85 gclass85_0;

	Hashtable hashtable_0;

	Hashtable hashtable_1;

	GControl2 gcontrol2_0;

	int int_3;
}
