using System;

public class GClass137
{
	public GClass137()
	{
		this.string_0 = null;
		this.uint_0 = 0u;
	}

	public GClass137(string string_1, uint uint_1)
	{
		this.string_0 = string_1;
		this.uint_0 = uint_1;
	}

	public static uint smethod_0(GClass137 gclass137_0)
	{
		return gclass137_0.uint_0;
	}

	public static GClass137 smethod_1(uint uint_1)
	{
		return new GClass137(uint_1.ToString(), uint_1);
	}

	public string method_0()
	{
		return this.string_0;
	}

	public uint method_1()
	{
		return this.uint_0;
	}

	public override string ToString()
	{
		return this.string_0;
	}

	protected string string_0;

	protected uint uint_0;
}
