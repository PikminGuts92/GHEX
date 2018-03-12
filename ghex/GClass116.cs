using System;

public class GClass116 : GClass114
{
	public GClass116(GClass36 gclass36_0, GEnum50 genum50_1) : base(gclass36_0, genum50_1)
	{
		this.bool_0 = false;
	}

	public GClass116(GClass36 gclass36_0, GEnum50 genum50_1, int int_4, int int_5) : base(gclass36_0, genum50_1, int_5, 0)
	{
		this.bool_0 = false;
		this.int_2 = int_4;
	}

	public int method_10()
	{
		return this.int_2;
	}

	public void method_11(int int_4)
	{
		if (int_4 != this.int_2)
		{
			this.int_2 = int_4;
			base.method_0().method_12(this, GEnum5.flag_2 | GEnum5.flag_4);
		}
	}

	int int_2 = 6000000;

	public int int_3;
}
