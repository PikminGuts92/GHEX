using System;

public class GClass152 : GInterface7
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

	public GClass152(GClass114 gclass114_1, int int_1, bool bool_1)
	{
		this.gclass114_0 = gclass114_1;
		this.int_0 = int_1;
		this.bool_0 = bool_1;
	}

	public void imethod_2(GClass122 gclass122_0)
	{
		this.imethod_4();
	}

	public void imethod_3()
	{
		GClass114 gclass = this.gclass114_0;
		gclass.method_8(gclass.method_7() - this.int_0);
	}

	public void imethod_4()
	{
		GClass114 gclass = this.gclass114_0;
		gclass.method_8(gclass.method_7() + this.int_0);
	}

	public string imethod_5()
	{
		return "Resize Event " + this.gclass114_0.ToString();
	}

	GClass114 gclass114_0;

	int int_0;

	bool bool_0;
}
