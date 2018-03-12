using System;
using System.Drawing;
using System.Windows.Forms;

public class GEventArgs8 : PaintEventArgs
{
	public GEventArgs8(Graphics graphics_0, Rectangle rectangle_1) : this(graphics_0, null, null, -1, -1, false, false, false, false, true, rectangle_1)
	{
	}

	public GEventArgs8(Graphics graphics_0, GClass97 gclass97_1, GControl2 gcontrol2_1, int int_2, int int_3, bool bool_6, bool bool_7, bool bool_8, bool bool_9, bool bool_10, Rectangle rectangle_1) : base(graphics_0, rectangle_1)
	{
		this.gclass97_0 = gclass97_1;
		this.gcontrol2_0 = gcontrol2_1;
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.bool_0 = bool_6;
		this.bool_1 = bool_7;
		this.bool_2 = bool_8;
		this.bool_3 = bool_9;
		this.bool_4 = bool_10;
		this.rectangle_0 = rectangle_1;
		this.bool_5 = false;
	}

	public GClass97 method_0()
	{
		return this.gclass97_0;
	}

	internal void method_1(GClass97 gclass97_1)
	{
		this.gclass97_0 = gclass97_1;
	}

	public GControl2 method_2()
	{
		return this.gcontrol2_0;
	}

	internal void method_3(GControl2 gcontrol2_1)
	{
		this.gcontrol2_0 = gcontrol2_1;
	}

	public int method_4()
	{
		return this.int_0;
	}

	internal void method_5(int int_2)
	{
		this.int_0 = int_2;
	}

	public int method_6()
	{
		return this.int_1;
	}

	internal void method_7(int int_2)
	{
		this.int_1 = int_2;
	}

	public bool method_8()
	{
		return this.bool_0;
	}

	internal void method_9(bool bool_6)
	{
		this.bool_0 = bool_6;
	}

	public bool method_10()
	{
		return this.bool_1;
	}

	internal void method_11(bool bool_6)
	{
		this.bool_1 = bool_6;
	}

	public bool method_12()
	{
		return this.bool_2;
	}

	internal void method_13(bool bool_6)
	{
		this.bool_2 = bool_6;
	}

	public bool method_14()
	{
		return this.bool_3;
	}

	internal void method_15(bool bool_6)
	{
		this.bool_3 = bool_6;
	}

	public bool method_16()
	{
		return this.bool_4;
	}

	internal void method_17(bool bool_6)
	{
		this.bool_4 = bool_6;
	}

	public Rectangle method_18()
	{
		return this.rectangle_0;
	}

	internal void method_19(Rectangle rectangle_1)
	{
		this.rectangle_0 = rectangle_1;
	}

	public GStruct9 method_20()
	{
		return new GStruct9(this.method_4(), this.method_6());
	}

	public bool method_21()
	{
		return this.bool_5;
	}

	public void method_22(bool bool_6)
	{
		this.bool_5 = bool_6;
	}

	GClass97 gclass97_0;

	GControl2 gcontrol2_0;

	int int_0;

	int int_1;

	bool bool_0;

	bool bool_1;

	bool bool_2;

	bool bool_3;

	bool bool_4;

	Rectangle rectangle_0;

	bool bool_5;
}
