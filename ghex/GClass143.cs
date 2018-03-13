using System;

public class GClass143 : GClass139
{
	public override int vmethod_0()
	{
		return this.int_1;
	}

	public override void vmethod_1(int int_2)
	{
		this.int_1 = int_2;
	}

	public override GEnum63 vmethod_2()
	{
		return GEnum63.const_3;
	}

	public override string ToString()
	{
		return string.Concat(new object[]
		{
			this.int_0.ToString(),
			": ",
			this.byte_0,
			"@",
			this.byte_1,
			" + ",
			this.vmethod_0(),
			" (",
			this.bool_0 ? "on" : "off",
			")"
		});
	}

	public byte byte_0;

	public byte byte_1;

	int int_1;

	public bool bool_0 = true;

	public bool bool_1 = true;
}
