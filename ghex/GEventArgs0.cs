using System;

public class GEventArgs0 : EventArgs
{
	public GEventArgs0(GClass97 gclass97_1) : this(gclass97_1, -1, -1)
	{
	}

	public GEventArgs0(GClass97 gclass97_1, int int_2, int int_3)
	{
		this.gclass97_0 = gclass97_1;
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public GClass97 method_0()
	{
		return this.gclass97_0;
	}

	public int method_1()
	{
		return this.int_0;
	}

	internal void method_2(int int_2)
	{
		this.int_0 = int_2;
	}

	public int method_3()
	{
		return this.int_1;
	}

	internal void method_4(int int_2)
	{
		this.int_1 = int_2;
	}

	public GStruct9 method_5()
	{
		return new GStruct9(this.method_3(), this.method_1());
	}

	GClass97 gclass97_0;

	int int_0;

	int int_1;
}
