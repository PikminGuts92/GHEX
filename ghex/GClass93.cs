using System;

public class GClass93
{
	public GClass93(GClass17 gclass17_1, GEnum13 genum13_1, object object_1) : this(gclass17_1, -1, genum13_1, object_1)
	{
	}

	public GClass93(GClass17 gclass17_1, int int_1, GEnum13 genum13_1, object object_1)
	{
		this.gclass17_0 = gclass17_1;
		this.int_0 = int_1;
		this.genum13_0 = genum13_1;
		this.object_0 = object_1;
	}

	public GClass17 method_0()
	{
		return this.gclass17_0;
	}

	internal void method_1(GClass17 gclass17_1)
	{
		this.gclass17_0 = gclass17_1;
	}

	public int method_2()
	{
		return this.int_0;
	}

	internal void method_3(int int_1)
	{
		this.int_0 = int_1;
	}

	public GEnum13 method_4()
	{
		return this.genum13_0;
	}

	public object method_5()
	{
		return this.object_0;
	}

	GClass17 gclass17_0;

	int int_0;

	object object_0;

	GEnum13 genum13_0;
}
