using System;

class PointerHelper
{
	public static void AssertNotNull(int int_0)
	{
        // So this literally just asserts whether pointer is not null
        // TODO: Throw this out after replacing WinMM
        if (int_0 != 0) throw new Exception(int_0.ToString());
	}
}
