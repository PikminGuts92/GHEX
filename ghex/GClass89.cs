using System;
using System.Collections.Generic;

public class GClass89 : GClass86
{
	public GClass89(GClass120 gclass120_1) : base(gclass120_1)
	{
	}

	public override void vmethod_0(List<GClass139> list_1)
	{
		base.method_3().AddRange(list_1);
		list_1.Clear();
	}

	public override void vmethod_1(List<GClass139> list_1)
	{
		list_1.AddRange(base.method_3());
	}
}
