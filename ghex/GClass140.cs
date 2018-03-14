using System;

public class GClass140 : MidiEvent
{
	public GClass140()
	{
	}

	public GClass140(int int_1, GEnum64 genum64_1, string string_1)
	{
		this.int_0 = int_1;
		this.genum64_0 = genum64_1;
		if (genum64_1 == GEnum64.const_0 && string_1.StartsWith("[") && string_1.EndsWith("]"))
		{
			this.string_0 = string_1.Trim(new char[]
			{
				'[',
				']'
			});
			return;
		}
		this.string_0 = string_1;
	}

	public override int vmethod_0()
	{
		return 0;
	}

	public override void vmethod_1(int int_1)
	{
	}

	public override GEnum63 vmethod_2()
	{
		return GEnum63.const_0;
	}

	public override string ToString()
	{
		return this.int_0.ToString() + ": \"" + this.string_0 + "\"";
	}

	public string string_0;

	public GEnum64 genum64_0;
}
