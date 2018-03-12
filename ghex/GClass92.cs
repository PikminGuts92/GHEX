using System;
using System.ComponentModel;
using System.Drawing;

public class GClass92
{
	public GClass92()
	{
		this.genum41_0 = GEnum41.const_0;
		this.genum41_1 = GEnum41.const_0;
		this.int_0 = -1;
		this.int_1 = -1;
	}

	public GEnum41 method_0()
	{
		return this.genum41_0;
	}

	public void method_1(GEnum41 genum41_2)
	{
		if (!Enum.IsDefined(typeof(GEnum41), genum41_2))
		{
			throw new InvalidEnumArgumentException("value", (int)genum41_2, typeof(GEnum41));
		}
		this.genum41_0 = genum41_2;
	}

	public GEnum41 method_2()
	{
		return this.genum41_1;
	}

	public void method_3(GEnum41 genum41_2)
	{
		if (!Enum.IsDefined(typeof(GEnum41), genum41_2))
		{
			throw new InvalidEnumArgumentException("value", (int)genum41_2, typeof(GEnum41));
		}
		this.genum41_1 = genum41_2;
	}

	public Point method_4()
	{
		return new Point(this.int_0, this.int_1);
	}

	public void method_5(Point point_0)
	{
		this.int_0 = point_0.X;
		this.int_1 = point_0.Y;
	}

	GEnum41 genum41_0;

	GEnum41 genum41_1;

	int int_0;

	int int_1;
}
