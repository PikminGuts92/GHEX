using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public abstract class GClass34
{
	protected GClass34(GClass136 gclass136_1)
	{
		this.gclass136_0 = gclass136_1;
	}

	public GClass136 method_0()
	{
		return this.gclass136_0;
	}

	protected List<GClass114> method_1()
	{
		return this.list_0;
	}

	public List<GClass114> method_2(GEnum50 genum50_0, int int_0, int int_1)
	{
		GClass34.Class1 @class = new GClass34.Class1();
		@class.genum50_0 = genum50_0;
		@class.int_0 = int_0;
		@class.int_1 = int_1;
		return this.method_1().FindAll(new Predicate<GClass114>(@class.method_0));
	}

	public GClass114[] method_3()
	{
		return this.method_1().ToArray();
	}

	public GClass114 method_4(GEnum50 genum50_0)
	{
		int i = this.method_1().Count - 1;
		while (i >= 0)
		{
			if (genum50_0 != GEnum50.const_5)
			{
				if (this.method_1()[i].method_1() != genum50_0)
				{
					i--;
					continue;
				}
			}
			return this.method_1()[i];
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_5(GDelegate0 gdelegate0_3)
	{
		this.gdelegate0_0 = (GDelegate0)Delegate.Combine(this.gdelegate0_0, gdelegate0_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_6(GDelegate0 gdelegate0_3)
	{
		this.gdelegate0_0 = (GDelegate0)Delegate.Remove(this.gdelegate0_0, gdelegate0_3);
	}

	public void method_7(GClass114 gclass114_0)
	{
		int num = 0;
		while (num < this.method_1().Count && this.method_1()[num].method_2() <= gclass114_0.method_2())
		{
			num++;
		}
		if (num == this.method_1().Count)
		{
			this.method_1().Add(gclass114_0);
		}
		else
		{
			this.method_1().Insert(num, gclass114_0);
		}
		if (this.gdelegate0_0 != null)
		{
			this.gdelegate0_0(new GClass33(gclass114_0, GEnum5.flag_0));
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_8(GDelegate0 gdelegate0_3)
	{
		this.gdelegate0_1 = (GDelegate0)Delegate.Combine(this.gdelegate0_1, gdelegate0_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_9(GDelegate0 gdelegate0_3)
	{
		this.gdelegate0_1 = (GDelegate0)Delegate.Remove(this.gdelegate0_1, gdelegate0_3);
	}

	public void method_10(GClass114 gclass114_0)
	{
		this.method_1().Remove(gclass114_0);
		if (this.gdelegate0_1 != null)
		{
			this.gdelegate0_1(new GClass33(gclass114_0, GEnum5.flag_1));
		}
	}

	protected void method_11(GClass33 gclass33_0)
	{
		if (this.gdelegate0_2 != null)
		{
			this.gdelegate0_2(gclass33_0);
		}
	}

	internal void method_12(GClass114 gclass114_0, GEnum5 genum5_0)
	{
		if ((genum5_0 & GEnum5.flag_3) != (GEnum5)0)
		{
			this.method_1().Sort(new GClass113());
		}
		this.vmethod_0(gclass114_0, genum5_0);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_13(GDelegate0 gdelegate0_3)
	{
		this.gdelegate0_2 = (GDelegate0)Delegate.Combine(this.gdelegate0_2, gdelegate0_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_14(GDelegate0 gdelegate0_3)
	{
		this.gdelegate0_2 = (GDelegate0)Delegate.Remove(this.gdelegate0_2, gdelegate0_3);
	}

	protected virtual void vmethod_0(GClass114 gclass114_0, GEnum5 genum5_0)
	{
		if (this.gdelegate0_2 != null)
		{
			this.gdelegate0_2(new GClass33(gclass114_0, GEnum5.flag_2 | genum5_0));
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_15(EventHandler eventHandler_1)
	{
		this.eventHandler_0 = (EventHandler)Delegate.Combine(this.eventHandler_0, eventHandler_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_16(EventHandler eventHandler_1)
	{
		this.eventHandler_0 = (EventHandler)Delegate.Remove(this.eventHandler_0, eventHandler_1);
	}

	public string method_17()
	{
		return this.string_0;
	}

	public void method_18(string string_1)
	{
		this.string_0 = string_1;
		if (this.eventHandler_0 != null)
		{
			this.eventHandler_0(this, EventArgs.Empty);
		}
	}

	GClass136 gclass136_0;

	List<GClass114> list_0 = new List<GClass114>(100);

	GDelegate0 gdelegate0_0;

	GDelegate0 gdelegate0_1;

	GDelegate0 gdelegate0_2;

	string string_0;

	EventHandler eventHandler_0;

	[CompilerGenerated]
	sealed class Class1
	{
		public bool method_0(GClass114 gclass114_0)
		{
			if (this.genum50_0 != GEnum50.const_5 && gclass114_0.method_1() != this.genum50_0)
			{
				return false;
			}
			if (gclass114_0.method_7() == 0)
			{
				return gclass114_0.method_2() >= this.int_0 && gclass114_0.method_2() < this.int_1;
			}
			int num = Math.Min(gclass114_0.method_2() + gclass114_0.method_7(), this.int_1) - Math.Max(gclass114_0.method_2(), this.int_0);
			return num > 0;
		}

		public GEnum50 genum50_0;

		public int int_0;

		public int int_1;
	}
}
