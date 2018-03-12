using System;
using System.Collections;

class Class10 : IComparer
{
	public int Compare(object object_0, object object_1)
	{
		GClass83 gclass = (GClass83)object_0;
		GClass83 gclass2 = (GClass83)object_1;
		if (gclass == null && gclass2 == null)
		{
			return 0;
		}
		if (gclass == null)
		{
			return -1;
		}
		if (gclass2 == null)
		{
			return 1;
		}
		if (gclass.method_35() < gclass2.method_35())
		{
			return -1;
		}
		if (gclass.method_35() < gclass2.method_35())
		{
			return 1;
		}
		return 0;
	}
}
