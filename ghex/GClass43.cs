using System;
using System.Windows.Forms;

public class GClass43 : GClass38
{
	public GClass43(GClass104 gclass104_1, int int_1, SortOrder sortOrder_1) : base(gclass104_1, int_1, sortOrder_1)
	{
	}

	public virtual int Compare(object object_0, object object_1)
	{
		GClass97 gclass = (GClass97)object_0;
		GClass97 gclass2 = (GClass97)object_1;
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
		if (gclass.method_5() == null && gclass2.method_5() == null)
		{
			return 0;
		}
		if (gclass.method_5() == null)
		{
			return -1;
		}
		return gclass.method_5().CompareTo(gclass2.method_5());
	}
}
