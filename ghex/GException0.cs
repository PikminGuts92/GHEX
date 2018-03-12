using System;

public class GException0 : Exception
{
	public GEnum48 method_0()
	{
		return this.genum48_0;
	}

	public GException0(string string_0) : base(string_0)
	{
	}

	public GException0(string string_0, GEnum48 genum48_1) : base(string_0)
	{
		this.genum48_0 = genum48_1;
	}

	GEnum48 genum48_0;
}
