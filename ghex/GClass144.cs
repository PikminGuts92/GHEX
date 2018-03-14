using System;

public class GClass144 : MidiEvent
{
	public GClass144(int int_3, int int_4, int int_5)
	{
		this.int_0 = int_3;
		this.vmethod_1(int_4);
		this.int_2 = int_5;
	}

	public override int vmethod_0()
	{
		return this.int_1;
	}

	public override void vmethod_1(int int_3)
	{
		this.int_1 = int_3;
	}

	public override GEnum63 vmethod_2()
	{
		return GEnum63.const_8;
	}

	public override string ToString()
	{
		return string.Concat(new object[]
		{
			this.int_0.ToString(),
			": T=",
			this.int_2,
			" + ",
			this.vmethod_0()
		});
	}

	int int_1;

	public int int_2;
}
