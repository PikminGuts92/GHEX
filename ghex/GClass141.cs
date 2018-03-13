using System;

public class GClass141 : GClass139
{
	internal GClass141(int int_4, GEnum52 genum52_1, int int_5, int int_6)
	{
		this.int_1 = int_4;
		this.genum52_0 = genum52_1;
		this.int_2 = int_5;
		this.int_3 = int_6;
	}

	public override int vmethod_0()
	{
		return 0;
	}

	public override void vmethod_1(int int_4)
	{
	}

	public override GEnum63 vmethod_2()
	{
		return GEnum63.const_1;
	}

	public override string ToString()
	{
		return string.Concat(new object[]
		{
			this.int_0.ToString(),
			": ",
			this.int_1,
			"/",
			(int)this.genum52_0,
			", ",
			this.int_2,
			", ",
			this.int_3
		});
	}

	public int int_1;

	public GEnum52 genum52_0;

	public int int_2;

	public int int_3;
}
