using System;
using System.Drawing;
using System.Windows.Forms;

public class GEventArgs7 : PaintEventArgs
{
	public GEventArgs7(Graphics graphics_0, Rectangle rectangle_1) : this(graphics_0, null, null, -1, ColumnHeaderStyle.None, rectangle_1)
	{
	}

	public GEventArgs7(Graphics graphics_0, GClass17 gclass17_1, GControl2 gcontrol2_1, int int_1, ColumnHeaderStyle columnHeaderStyle_1, Rectangle rectangle_1) : base(graphics_0, rectangle_1)
	{
		this.gclass17_0 = gclass17_1;
		this.gcontrol2_0 = gcontrol2_1;
		this.int_0 = int_1;
		this.gclass17_0 = gclass17_1;
		this.columnHeaderStyle_0 = columnHeaderStyle_1;
		this.rectangle_0 = rectangle_1;
		this.bool_0 = false;
	}

	public GClass17 method_0()
	{
		return this.gclass17_0;
	}

	internal void method_1(GClass17 gclass17_1)
	{
		this.gclass17_0 = gclass17_1;
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

	internal void method_5(int int_1)
	{
		this.int_0 = int_1;
	}

	public ColumnHeaderStyle method_6()
	{
		return this.columnHeaderStyle_0;
	}

	internal void method_7(ColumnHeaderStyle columnHeaderStyle_1)
	{
		this.columnHeaderStyle_0 = columnHeaderStyle_1;
	}

	public Rectangle method_8()
	{
		return this.rectangle_0;
	}

	internal void method_9(Rectangle rectangle_1)
	{
		this.rectangle_0 = rectangle_1;
	}

	public bool method_10()
	{
		return this.bool_0;
	}

	public void method_11(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	GClass17 gclass17_0;

	GControl2 gcontrol2_0;

	int int_0;

	ColumnHeaderStyle columnHeaderStyle_0;

	Rectangle rectangle_0;

	bool bool_0;
}
