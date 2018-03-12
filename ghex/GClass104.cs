using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;

[DesignTimeVisible(true)]
[DefaultMember("Item")]
[ToolboxItem(true)]
[ToolboxBitmap(typeof(GClass104))]
public class GClass104 : Component
{
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_0(GDelegate8 gdelegate8_2)
	{
		this.gdelegate8_0 = (GDelegate8)Delegate.Combine(this.gdelegate8_0, gdelegate8_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_1(GDelegate8 gdelegate8_2)
	{
		this.gdelegate8_0 = (GDelegate8)Delegate.Remove(this.gdelegate8_0, gdelegate8_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_2(GDelegate8 gdelegate8_2)
	{
		this.gdelegate8_1 = (GDelegate8)Delegate.Combine(this.gdelegate8_1, gdelegate8_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_3(GDelegate8 gdelegate8_2)
	{
		this.gdelegate8_1 = (GDelegate8)Delegate.Remove(this.gdelegate8_1, gdelegate8_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_4(GDelegate18 gdelegate18_1)
	{
		this.gdelegate18_0 = (GDelegate18)Delegate.Combine(this.gdelegate18_0, gdelegate18_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_5(GDelegate18 gdelegate18_1)
	{
		this.gdelegate18_0 = (GDelegate18)Delegate.Remove(this.gdelegate18_0, gdelegate18_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_6(EventHandler eventHandler_1)
	{
		this.eventHandler_0 = (EventHandler)Delegate.Combine(this.eventHandler_0, eventHandler_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_7(EventHandler eventHandler_1)
	{
		this.eventHandler_0 = (EventHandler)Delegate.Remove(this.eventHandler_0, eventHandler_1);
	}

	public GClass104()
	{
		this.method_8();
	}

	public GClass104(GClass83[] gclass83_0)
	{
		if (gclass83_0 == null)
		{
			throw new ArgumentNullException("rows", "Row[] cannot be null");
		}
		this.method_8();
		if (gclass83_0.Length > 0)
		{
			this.method_12().method_1(gclass83_0);
		}
	}

	void method_8()
	{
		this.gclass82_0 = null;
		this.gclass105_0 = new GClass104.GClass105(this);
		this.gcontrol2_0 = null;
		this.int_3 = GClass104.int_0;
	}

	protected virtual void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	public int method_9(int int_4)
	{
		int num = int_4 / this.method_14();
		if (num >= 0 && num <= this.method_12().Count - 1)
		{
			return num;
		}
		return -1;
	}

	public GClass97 method_10(int int_4, int int_5)
	{
		if (int_4 < 0 || int_4 >= this.method_12().Count)
		{
			return null;
		}
		if (int_5 >= 0 && int_5 < this.method_12().method_9(int_4).method_9().Count)
		{
			return this.method_12().method_9(int_4).method_9().method_9(int_5);
		}
		return null;
	}

	public GClass97 method_11(GStruct9 gstruct9_0)
	{
		return this.method_10(gstruct9_0.method_1(), gstruct9_0.method_3());
	}

	public GClass82 method_12()
	{
		if (this.gclass82_0 == null)
		{
			this.gclass82_0 = new GClass82(this);
		}
		return this.gclass82_0;
	}

	public GClass104.GClass105 method_13()
	{
		if (this.gclass105_0 == null)
		{
			this.gclass105_0 = new GClass104.GClass105(this);
		}
		return this.gclass105_0;
	}

	public int method_14()
	{
		return this.int_3;
	}

	public void method_15(int int_4)
	{
		if (int_4 < GClass104.int_1)
		{
			int_4 = GClass104.int_1;
		}
		else if (int_4 > GClass104.int_2)
		{
			int_4 = GClass104.int_2;
		}
		if (this.int_3 != int_4)
		{
			this.int_3 = int_4;
			this.vmethod_3(EventArgs.Empty);
		}
	}

	bool method_16()
	{
		return this.int_3 != GClass104.int_0;
	}

	public int method_17()
	{
		return this.method_12().Count * this.method_14();
	}

	public GControl2 method_18()
	{
		return this.gcontrol2_0;
	}

	internal GControl2 method_19()
	{
		return this.gcontrol2_0;
	}

	internal void method_20(GControl2 gcontrol2_1)
	{
		this.gcontrol2_0 = gcontrol2_1;
	}

	protected internal bool method_21()
	{
		return this.method_18() == null || this.method_18().method_246();
	}

	internal bool method_22()
	{
		return this.method_18() == null || this.method_18().Enabled;
	}

	internal void method_23(int int_4)
	{
		if (int_4 == -1)
		{
			int_4 = 0;
		}
		for (int i = int_4; i < this.method_12().Count; i++)
		{
			this.method_12().method_9(i).method_36(i);
		}
	}

	protected internal virtual void vmethod_0(GEventArgs9 geventArgs9_0)
	{
		geventArgs9_0.method_1().method_33(this);
		geventArgs9_0.method_1().method_36(geventArgs9_0.method_2());
		geventArgs9_0.method_1().method_44();
		this.method_23(geventArgs9_0.method_2());
		if (this.method_21())
		{
			if (this.method_18() != null)
			{
				this.method_18().vmethod_43(geventArgs9_0);
			}
			if (this.gdelegate8_0 != null)
			{
				this.gdelegate8_0(this, geventArgs9_0);
			}
		}
	}

	protected internal virtual void vmethod_1(GEventArgs9 geventArgs9_0)
	{
		if (geventArgs9_0.method_1() != null && geventArgs9_0.method_1().method_31() == this)
		{
			geventArgs9_0.method_1().method_33(null);
			geventArgs9_0.method_1().method_36(-1);
			if (geventArgs9_0.method_1().method_42())
			{
				geventArgs9_0.method_1().method_44();
				this.method_13().method_21(geventArgs9_0.method_1());
			}
		}
		this.method_23(geventArgs9_0.method_2());
		if (this.method_21())
		{
			if (this.method_18() != null)
			{
				this.method_18().vmethod_44(geventArgs9_0);
			}
			if (this.gdelegate8_1 != null)
			{
				this.gdelegate8_1(this, geventArgs9_0);
			}
		}
	}

	protected virtual void vmethod_2(GEventArgs13 geventArgs13_0)
	{
		if (this.method_21())
		{
			if (this.method_18() != null)
			{
				this.method_18().vmethod_41(geventArgs13_0);
			}
			if (this.gdelegate18_0 != null)
			{
				this.gdelegate18_0(this, geventArgs13_0);
			}
		}
	}

	protected virtual void vmethod_3(EventArgs eventArgs_0)
	{
		if (this.method_21())
		{
			if (this.method_18() != null)
			{
				this.method_18().vmethod_42(eventArgs_0);
			}
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, eventArgs_0);
			}
		}
	}

	internal void method_24(GEventArgs6 geventArgs6_0)
	{
		if (this.method_18() != null)
		{
			this.method_18().vmethod_35(geventArgs6_0);
		}
	}

	internal void method_25(GEventArgs6 geventArgs6_0)
	{
		if (this.method_18() != null)
		{
			this.method_18().vmethod_36(geventArgs6_0);
		}
	}

	internal void method_26(GEventArgs6 geventArgs6_0)
	{
		if (this.method_18() != null)
		{
			this.method_18().vmethod_37(geventArgs6_0);
		}
	}

	internal void method_27(GEventArgs1 geventArgs1_0)
	{
		if (this.method_18() != null)
		{
			this.method_18().vmethod_0(geventArgs1_0);
		}
	}

	GDelegate8 gdelegate8_0;

	GDelegate8 gdelegate8_1;

	GDelegate18 gdelegate18_0;

	EventHandler eventHandler_0;

	public static readonly int int_0 = 15;

	public static readonly int int_1 = 14;

	public static readonly int int_2 = 1024;

	GClass82 gclass82_0;

	GControl2 gcontrol2_0;

	GClass104.GClass105 gclass105_0;

	int int_3;

	public class GClass105
	{
		public GClass105(GClass104 gclass104_1)
		{
			if (gclass104_1 == null)
			{
				throw new ArgumentNullException("owner", "owner cannot be null");
			}
			this.gclass104_0 = gclass104_1;
			this.arrayList_0 = new ArrayList();
			this.gstruct9_0 = GStruct9.gstruct9_0;
			this.gstruct9_1 = GStruct9.gstruct9_0;
		}

		public void method_0(int int_0, int int_1)
		{
			if (this.arrayList_0.Count == 1)
			{
				GClass83 gclass = (GClass83)this.arrayList_0[0];
				if (gclass.method_35() == int_0 && gclass.method_39() == 1 && int_1 >= 0 && int_1 < gclass.method_9().Count && gclass.method_9().method_9(int_1).method_13())
				{
					return;
				}
			}
			this.method_2(int_0, int_1, int_0, int_1);
		}

		public void method_1(GStruct9 gstruct9_2)
		{
			this.method_0(gstruct9_2.method_1(), gstruct9_2.method_3());
		}

		public void method_2(int int_0, int int_1, int int_2, int int_3)
		{
			int[] int_4 = this.method_26();
			this.method_14();
			if (this.method_9(int_0, int_1, int_2, int_3))
			{
				this.gclass104_0.vmethod_2(new GEventArgs13(this.gclass104_0, int_4, this.method_26()));
			}
			this.gstruct9_0 = new GStruct9(int_0, int_1);
			this.gstruct9_1 = new GStruct9(int_2, int_3);
		}

		public void method_3(GStruct9 gstruct9_2, GStruct9 gstruct9_3)
		{
			this.method_2(gstruct9_2.method_1(), gstruct9_2.method_3(), gstruct9_3.method_1(), gstruct9_3.method_3());
		}

		public void method_4(int int_0, int int_1)
		{
			this.method_6(int_0, int_1, int_0, int_1);
		}

		public void method_5(GStruct9 gstruct9_2)
		{
			this.method_4(gstruct9_2.method_1(), gstruct9_2.method_3());
		}

		public void method_6(int int_0, int int_1, int int_2, int int_3)
		{
			int[] int_4 = this.method_26();
			if (this.method_9(int_0, int_1, int_2, int_3))
			{
				this.gclass104_0.vmethod_2(new GEventArgs13(this.gclass104_0, int_4, this.method_26()));
			}
			this.gstruct9_0 = new GStruct9(int_0, int_1);
			this.gstruct9_1 = new GStruct9(int_2, int_3);
		}

		public void method_7(GStruct9 gstruct9_2, GStruct9 gstruct9_3)
		{
			this.method_6(gstruct9_2.method_1(), gstruct9_2.method_3(), gstruct9_3.method_1(), gstruct9_3.method_3());
		}

		bool method_8(GStruct9 gstruct9_2, GStruct9 gstruct9_3)
		{
			return this.method_9(gstruct9_2.method_1(), gstruct9_2.method_3(), gstruct9_3.method_1(), gstruct9_3.method_3());
		}

		bool method_9(int int_0, int int_1, int int_2, int int_3)
		{
			this.method_12(ref int_0, ref int_2);
			this.method_12(ref int_1, ref int_3);
			bool result = false;
			bool flag = false;
			int num = int_0;
			while (num <= int_2 && num < this.gclass104_0.method_12().Count)
			{
				GClass83 gclass = this.gclass104_0.method_12().method_9(num);
				int num2 = int_1;
				while (num2 <= int_3 && num2 < gclass.method_9().Count)
				{
					if (!gclass.method_9().method_9(num2).method_13() && gclass.method_9().method_9(num2).method_40() && (this.gclass104_0.method_18() == null || this.gclass104_0.method_18().method_126(num, num2)))
					{
						gclass.method_9().method_9(num2).method_14(true);
						GClass83 gclass2 = gclass;
						gclass2.method_41(gclass2.method_40() + 1);
						result = true;
						flag = true;
					}
					num2++;
				}
				if (flag && !this.arrayList_0.Contains(gclass))
				{
					this.arrayList_0.Add(gclass);
				}
				flag = false;
				num++;
			}
			return result;
		}

		public void method_10(int int_0, int int_1)
		{
			int[] int_2 = this.method_26();
			if (GStruct9.smethod_0(this.gstruct9_0, GStruct9.gstruct9_0))
			{
				this.gstruct9_0 = new GStruct9(0, 0);
			}
			bool flag;
			if (GStruct9.smethod_1(this.gstruct9_1, GStruct9.gstruct9_0))
			{
				flag = (this.method_19(this.gstruct9_0, this.gstruct9_1) | this.method_8(this.gstruct9_0, new GStruct9(int_0, int_1)));
			}
			else
			{
				flag = this.method_9(0, 0, int_0, int_1);
			}
			if (flag)
			{
				this.gclass104_0.vmethod_2(new GEventArgs13(this.gclass104_0, int_2, this.method_26()));
			}
			this.gstruct9_1 = new GStruct9(int_0, int_1);
		}

		public void method_11(GStruct9 gstruct9_2)
		{
			this.method_10(gstruct9_2.method_1(), gstruct9_2.method_3());
		}

		void method_12(ref int int_0, ref int int_1)
		{
			if (int_0 < 0)
			{
				int_0 = 0;
			}
			if (int_1 < 0)
			{
				int_1 = 0;
			}
			if (int_1 < int_0)
			{
				int num = int_0;
				int_0 = int_1;
				int_1 = num;
			}
		}

		public void method_13()
		{
			if (this.arrayList_0.Count > 0)
			{
				int[] int_ = this.method_26();
				this.method_14();
				this.gstruct9_0 = GStruct9.gstruct9_0;
				this.gstruct9_1 = GStruct9.gstruct9_0;
				this.gclass104_0.vmethod_2(new GEventArgs13(this.gclass104_0, int_, this.method_26()));
			}
		}

		void method_14()
		{
			if (this.arrayList_0.Count > 0)
			{
				for (int i = 0; i < this.arrayList_0.Count; i++)
				{
					((GClass83)this.arrayList_0[i]).method_44();
				}
				this.arrayList_0.Clear();
				this.arrayList_0.Capacity = 0;
			}
		}

		public void method_15(int int_0, int int_1)
		{
			this.method_17(int_0, int_1, int_0, int_1);
		}

		public void method_16(GStruct9 gstruct9_2)
		{
			this.method_15(gstruct9_2.method_1(), gstruct9_2.method_3());
		}

		public void method_17(int int_0, int int_1, int int_2, int int_3)
		{
			if (this.arrayList_0.Count > 0)
			{
				int[] int_4 = this.method_26();
				if (this.method_20(int_0, int_1, int_2, int_3))
				{
					this.gclass104_0.vmethod_2(new GEventArgs13(this.gclass104_0, int_4, this.method_26()));
				}
				this.gstruct9_0 = new GStruct9(int_0, int_1);
				this.gstruct9_1 = new GStruct9(int_2, int_3);
			}
		}

		public void method_18(GStruct9 gstruct9_2, GStruct9 gstruct9_3)
		{
			this.method_17(gstruct9_2.method_1(), gstruct9_2.method_3(), gstruct9_3.method_1(), gstruct9_3.method_3());
		}

		bool method_19(GStruct9 gstruct9_2, GStruct9 gstruct9_3)
		{
			return this.method_20(gstruct9_2.method_1(), gstruct9_2.method_3(), gstruct9_3.method_1(), gstruct9_3.method_3());
		}

		bool method_20(int int_0, int int_1, int int_2, int int_3)
		{
			this.method_12(ref int_0, ref int_2);
			this.method_12(ref int_1, ref int_3);
			bool result = false;
			int num = int_0;
			while (num <= int_2 && num < this.gclass104_0.method_12().Count)
			{
				GClass83 gclass = this.gclass104_0.method_12().method_9(num);
				int num2 = int_1;
				while (num2 <= int_3 && num2 < gclass.method_9().Count)
				{
					if (gclass.method_9().method_9(num2).method_13())
					{
						gclass.method_9().method_9(num2).method_14(false);
						GClass83 gclass2 = gclass;
						gclass2.method_41(gclass2.method_40() - 1);
						result = true;
					}
					num2++;
				}
				if (!gclass.method_42() && this.arrayList_0.Contains(gclass))
				{
					this.arrayList_0.Remove(gclass);
				}
				num++;
			}
			return result;
		}

		internal void method_21(GClass83 gclass83_0)
		{
			if (this.arrayList_0.Contains(gclass83_0))
			{
				int[] int_ = this.method_26();
				this.arrayList_0.Remove(gclass83_0);
				this.gclass104_0.vmethod_2(new GEventArgs13(this.gclass104_0, int_, this.method_26()));
			}
		}

		public bool method_22(int int_0, int int_1)
		{
			return int_0 >= 0 && int_0 < this.gclass104_0.method_12().Count && this.gclass104_0.method_12().method_9(int_0).method_43(int_1);
		}

		public bool method_23(GStruct9 gstruct9_2)
		{
			return this.method_22(gstruct9_2.method_1(), gstruct9_2.method_3());
		}

		public bool method_24(int int_0)
		{
			return int_0 >= 0 && int_0 < this.gclass104_0.method_12().Count && this.gclass104_0.method_12().method_9(int_0).method_42();
		}

		public GClass83[] method_25()
		{
			if (this.arrayList_0.Count == 0)
			{
				return new GClass83[0];
			}
			this.arrayList_0.Sort(new Class10());
			return (GClass83[])this.arrayList_0.ToArray(typeof(GClass83));
		}

		public int[] method_26()
		{
			if (this.arrayList_0.Count == 0)
			{
				return new int[0];
			}
			this.arrayList_0.Sort(new Class10());
			int[] array = new int[this.arrayList_0.Count];
			for (int i = 0; i < this.arrayList_0.Count; i++)
			{
				array[i] = ((GClass83)this.arrayList_0[i]).method_35();
			}
			return array;
		}

		public Rectangle method_27()
		{
			if (this.arrayList_0.Count == 0)
			{
				return Rectangle.Empty;
			}
			int[] array = this.method_26();
			return this.method_28(array[0], array[array.Length - 1]);
		}

		internal Rectangle method_28(int int_0, int int_1)
		{
			this.method_12(ref int_0, ref int_1);
			Rectangle result = default(Rectangle);
			if (this.gclass104_0.method_18() != null && this.gclass104_0.method_18().method_166() != null)
			{
				result.Width = this.gclass104_0.method_18().method_166().method_29();
			}
			result.Y = int_0 * this.gclass104_0.method_14();
			if (int_0 == int_1)
			{
				result.Height = this.gclass104_0.method_14();
			}
			else
			{
				result.Height = (int_1 + 1) * this.gclass104_0.method_14() - result.Y;
			}
			return result;
		}

		GClass104 gclass104_0;

		ArrayList arrayList_0;

		GStruct9 gstruct9_0;

		GStruct9 gstruct9_1;
	}
}
