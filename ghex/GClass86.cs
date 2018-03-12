using System;
using System.Collections.Generic;

public abstract class GClass86
{
	public GClass86(GClass120 gclass120_1)
	{
		this.list_0 = new List<GClass139>();
		this.gclass120_0 = gclass120_1;
	}

	public GClass86(GClass120 gclass120_1, string string_1) : this(gclass120_1)
	{
		this.string_0 = string_1;
	}

	public GClass120 method_0()
	{
		return this.gclass120_0;
	}

	public string method_1()
	{
		return this.string_0;
	}

	public void method_2(string string_1)
	{
		this.string_0 = string_1;
	}

	public List<GClass139> method_3()
	{
		return this.list_0;
	}

	public abstract void vmethod_0(List<GClass139> list_1);

	public abstract void vmethod_1(List<GClass139> list_1);

	protected void method_4(GClass139 gclass139_0, int int_0, List<GClass139> list_1)
	{
		list_1.Add(new GClass143
		{
			int_0 = gclass139_0.int_0,
			bool_0 = true,
			byte_0 = (byte)int_0,
			byte_1 = 100
		});
		if (gclass139_0.vmethod_0() > 0)
		{
			list_1.Add(new GClass143
			{
				int_0 = gclass139_0.int_0 + gclass139_0.vmethod_0(),
				bool_0 = false,
				byte_0 = (byte)int_0,
				byte_1 = 0
			});
		}
	}

	internal static List<GClass139> smethod_0(List<GClass139> list_1, int int_0, int int_1, GEnum63 genum63_0)
	{
		int num = int_0 + int_1;
		List<GClass139> list = new List<GClass139>(list_1.Count);
		foreach (GClass139 gclass in list_1)
		{
			GEnum63 genum = gclass.vmethod_2();
			if (genum == genum63_0 || genum63_0 == GEnum63.const_9)
			{
				int num2 = gclass.int_0 + gclass.vmethod_0();
				if (gclass.int_0 >= int_0 && gclass.int_0 < num)
				{
					list.Add(gclass);
				}
				else if (num2 >= int_0 && num2 <= num)
				{
					list.Add(gclass);
				}
				else if (gclass.int_0 < int_0 && num2 >= num)
				{
					list.Add(gclass);
				}
			}
		}
		return list;
	}

	public List<GClass139> method_5(int int_0, int int_1, GEnum63 genum63_0)
	{
		return GClass86.smethod_0(this.list_0, int_0, int_1, genum63_0);
	}

	public List<GClass139> method_6(int int_0, int int_1)
	{
		return GClass86.smethod_0(this.list_0, int_0, int_1, GEnum63.const_9);
	}

	public virtual string ToString()
	{
		return this.method_1();
	}

	GClass120 gclass120_0;

	string string_0;

	List<GClass139> list_0;
}
