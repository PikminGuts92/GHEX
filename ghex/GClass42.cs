using System;
using System.Windows.Forms;

public class GClass42 : GClass38
{
	public GClass42(GClass104 gclass104_1, int int_1, SortOrder sortOrder_1) : base(gclass104_1, int_1, sortOrder_1)
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
		int num = 0;
		if (gclass.method_7() == null && gclass2.method_7() == null)
		{
			num = 0;
		}
		else if (gclass.method_7() == null)
		{
			num = -1;
		}
		else if (gclass2.method_7() == null)
		{
			num = 1;
		}
		if (num == 0 && ((GClass27)base.method_0().method_18().method_166().method_23().method_8(base.method_1())).method_45())
		{
			if (gclass.method_5() == null && gclass2.method_5() == null)
			{
				return 0;
			}
			if (gclass.method_5() == null)
			{
				return -1;
			}
			num = gclass.method_5().CompareTo(gclass2.method_5());
		}
		return num;
	}
}
