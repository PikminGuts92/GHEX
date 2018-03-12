using System;
using System.Drawing;

struct Struct6
{
	public Struct6(int int_2, int int_3)
	{
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public static Struct6 smethod_0(Point point_0)
	{
		return new Struct6(point_0.X, point_0.Y);
	}

	public Point method_0()
	{
		return new Point(this.int_0, this.int_1);
	}

	public int int_0;

	public int int_1;
}
