using System;

public class GClass132 : GInterface7
{
	public bool imethod_0()
	{
		return true;
	}

	public bool imethod_1()
	{
		return true;
	}

	public void Dispose()
	{
	}

	public GClass132(GClass115 gclass115_1, GEnum51 genum51_1)
	{
		this.gclass115_0 = gclass115_1;
		this.genum51_0 = genum51_1;
	}

	public void imethod_2(GClass122 gclass122_0)
	{
		this.gclass123_0 = (gclass122_0 as GClass123);
		this.GInterface7.imethod_4();
	}

	public void imethod_3()
	{
		this.GInterface7.imethod_4();
	}

	public void imethod_4()
	{
		this.gclass115_0.method_11(this.genum51_0, !this.gclass115_0.method_10(this.genum51_0));
	}

	public string imethod_5()
	{
		return "Toggle Note " + this.genum51_0.ToString();
	}

	GClass115 gclass115_0;

	GEnum51 genum51_0;

	GClass123 gclass123_0;
}
