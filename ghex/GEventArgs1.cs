using System;

public class GEventArgs1 : GEventArgs0
{
	public GEventArgs1(GClass97 gclass97_1, GEnum6 genum6_1, object object_1) : this(gclass97_1, -1, -1, genum6_1, object_1)
	{
	}

	public GEventArgs1(GClass97 gclass97_1, int int_2, int int_3, GEnum6 genum6_1, object object_1) : base(gclass97_1, int_2, int_3)
	{
		this.genum6_0 = genum6_1;
		this.object_0 = object_1;
	}

	public GEnum6 method_6()
	{
		return this.genum6_0;
	}

	public object method_7()
	{
		return this.object_0;
	}

	GEnum6 genum6_0;

	object object_0;
}
