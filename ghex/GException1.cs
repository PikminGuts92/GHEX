using System;

public class GException1 : Exception
{
	public GException1()
	{
	}

	public GException1(string string_0) : base("csorbis: " + string_0)
	{
	}
}
