using System;
using System.Collections.Generic;

public class GClass113 : IComparer<GClass114>
{
	public int Compare(GClass114 gclass114_0, GClass114 gclass114_1)
	{
		double num = (double)(gclass114_0.method_2() - gclass114_1.method_2());
		if (num < 0.0)
		{
			return -1;
		}
		if (num <= 0.0)
		{
			return 0;
		}
		return 1;
	}
}
