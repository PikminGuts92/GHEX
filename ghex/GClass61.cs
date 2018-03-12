using System;
using System.Drawing;

public class GClass61
{
	public GClass61()
	{
		this.color_0 = Color.Empty;
		this.color_1 = Color.Empty;
		this.font_0 = null;
		this.genum38_0 = GEnum38.const_1;
	}

	public Font method_0()
	{
		return this.font_0;
	}

	public void method_1(Font font_1)
	{
		this.font_0 = font_1;
	}

	public Color method_2()
	{
		return this.color_0;
	}

	public void method_3(Color color_2)
	{
		this.color_0 = color_2;
	}

	public Color method_4()
	{
		return this.color_1;
	}

	public void method_5(Color color_2)
	{
		this.color_1 = color_2;
	}

	public GEnum38 method_6()
	{
		return this.genum38_0;
	}

	public void method_7(GEnum38 genum38_1)
	{
		this.genum38_0 = genum38_1;
	}

	Color color_0;

	Color color_1;

	Font font_0;

	GEnum38 genum38_0;
}
