using System;
using System.Drawing;

public class GEventArgs13 : EventArgs
{
	public GEventArgs13(GClass104 gclass104_1, int[] int_2, int[] int_3)
	{
		if (gclass104_1 == null)
		{
			throw new ArgumentNullException("source", "TableModel cannot be null");
		}
		this.gclass104_0 = gclass104_1;
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.rectangle_0 = Rectangle.Empty;
		this.rectangle_1 = Rectangle.Empty;
		if (int_2.Length > 0)
		{
			this.rectangle_0 = gclass104_1.method_13().method_28(int_2[0], int_2[int_2.Length - 1]);
		}
		if (int_3.Length > 0)
		{
			this.rectangle_1 = gclass104_1.method_13().method_28(int_3[0], int_3[int_3.Length - 1]);
		}
	}

	public GClass104 method_0()
	{
		return this.gclass104_0;
	}

	public int[] method_1()
	{
		return this.int_0;
	}

	public int[] method_2()
	{
		return this.int_1;
	}

	internal Rectangle method_3()
	{
		return this.rectangle_0;
	}

	internal Rectangle method_4()
	{
		return this.rectangle_1;
	}

	GClass104 gclass104_0;

	int[] int_0;

	int[] int_1;

	Rectangle rectangle_0;

	Rectangle rectangle_1;
}
