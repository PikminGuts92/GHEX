using System;
using System.Collections;
using System.Windows.Forms;

public abstract class GClass38 : IComparer
{
	public GClass38(GClass104 gclass104_1, int int_1, SortOrder sortOrder_1)
	{
		this.gclass104_0 = gclass104_1;
		this.int_0 = int_1;
		this.sortOrder_0 = sortOrder_1;
	}

	public abstract int Compare(object object_0, object object_1);

	public GClass104 method_0()
	{
		return this.gclass104_0;
	}

	public int method_1()
	{
		return this.int_0;
	}

	public SortOrder method_2()
	{
		return this.sortOrder_0;
	}

	GClass104 gclass104_0;

	int int_0;

	SortOrder sortOrder_0;
}
