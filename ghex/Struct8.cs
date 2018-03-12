using System;
using System.Drawing;

struct Struct8
{
	public Struct8(int int_4, int int_5, int int_6, int int_7)
	{
		this.int_0 = int_4;
		this.int_1 = int_5;
		this.int_2 = int_6;
		this.int_3 = int_7;
	}

	public static Struct8 smethod_0(Rectangle rectangle_0)
	{
		return new Struct8(rectangle_0.Left, rectangle_0.Top, rectangle_0.Right, rectangle_0.Bottom);
	}

	public static Struct8 smethod_1(int int_4, int int_5, int int_6, int int_7)
	{
		return new Struct8(int_4, int_5, int_4 + int_6, int_5 + int_7);
	}

	public Rectangle method_0()
	{
		return new Rectangle(this.int_0, this.int_1, this.int_2 - this.int_0, this.int_3 - this.int_1);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;
}
