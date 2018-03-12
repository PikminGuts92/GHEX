using System;

public class GEventArgs11 : EventArgs
{
	public GEventArgs11(GClass98 gclass98_1)
	{
		this.gclass98_0 = gclass98_1;
	}

	public GClass98 method_0()
	{
		return this.gclass98_0;
	}

	public void method_1(GClass98 gclass98_1)
	{
		this.gclass98_0 = gclass98_1;
	}

	public bool method_2()
	{
		return this.bool_0;
	}

	public void method_3(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	bool bool_0;

	GClass98 gclass98_0;
}
