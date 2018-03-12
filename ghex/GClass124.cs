using System;
using System.ComponentModel;

public class GClass124
{
	public GClass124(GEnum60 genum60_1)
	{
		this.genum60_0 = genum60_1;
	}

	public GEnum60 method_0()
	{
		return this.genum60_0;
	}

	public void method_1(GEnum60 genum60_1)
	{
		if (!Enum.IsDefined(typeof(GEnum60), genum60_1))
		{
			throw new InvalidEnumArgumentException("value", (int)genum60_1, typeof(GEnum60));
		}
		this.genum60_0 = genum60_1;
	}

	GEnum60 genum60_0;
}
