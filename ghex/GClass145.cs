using System;
using System.Collections.Generic;

public class GClass145 : GClass139
{
	public GClass145(GClass88 gclass88_1)
	{
		this.list_0 = new List<GEnum51>(5);
		this.gclass88_0 = gclass88_1;
	}

	public bool method_0()
	{
		return this.vmethod_0() > this.gclass88_0.method_0().method_1() / 3;
	}

	public bool method_1()
	{
		return this.list_0.Count > 1;
	}

	public override int vmethod_0()
	{
		return this.int_1;
	}

	public override void vmethod_1(int int_2)
	{
		this.int_1 = int_2;
	}

	public override GEnum63 vmethod_2()
	{
		return GEnum63.const_4;
	}

	public override string ToString()
	{
		string text = this.int_0.ToString() + ": ";
		foreach (GEnum51 genum in this.list_0)
		{
			text += genum.ToString()[0];
		}
		text = text + " + " + this.int_1;
		return text;
	}

	GClass88 gclass88_0;

	public List<GEnum51> list_0;

	public bool bool_0 = true;

	int int_1;
}
