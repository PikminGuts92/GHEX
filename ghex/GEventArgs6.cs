using System;

public class GEventArgs6 : EventArgs
{
	public GEventArgs6(GClass83 gclass83_1, GEnum65 genum65_1) : this(gclass83_1, -1, null, -1, -1, genum65_1)
	{
	}

	public GEventArgs6(GClass83 gclass83_1, GClass97 gclass97_1, int int_3, int int_4) : this(gclass83_1, -1, gclass97_1, int_3, int_4, GEnum65.const_0)
	{
	}

	public GEventArgs6(GClass83 gclass83_1, int int_3, GClass97 gclass97_1, int int_4, int int_5, GEnum65 genum65_1)
	{
		this.gclass83_0 = gclass83_1;
		this.int_0 = int_3;
		this.gclass97_0 = gclass97_1;
		this.int_2 = int_4;
		this.int_1 = int_5;
		this.genum65_0 = genum65_1;
	}

	public GClass83 method_0()
	{
		return this.gclass83_0;
	}

	public int method_1()
	{
		return this.int_0;
	}

	internal void method_2(int int_3)
	{
		this.int_0 = int_3;
	}

	public GClass97 method_3()
	{
		return this.gclass97_0;
	}

	public int method_4()
	{
		return this.int_2;
	}

	public int method_5()
	{
		return this.int_1;
	}

	public GEnum65 method_6()
	{
		return this.genum65_0;
	}

	GClass83 gclass83_0;

	int int_0;

	GClass97 gclass97_0;

	int int_1;

	int int_2;

	GEnum65 genum65_0;
}
