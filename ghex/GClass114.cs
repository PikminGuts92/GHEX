using System;

public abstract class GClass114
{
	protected GClass114(GClass34 gclass34_1, GEnum50 genum50_1) : this(gclass34_1, genum50_1, 0, 0)
	{
	}

	protected GClass114(GClass34 gclass34_1, GEnum50 genum50_1, int int_2) : this(gclass34_1, genum50_1, int_2, 0)
	{
	}

	protected GClass114(GClass34 gclass34_1, GEnum50 genum50_1, int int_2, int int_3)
	{
		this.gclass34_0 = gclass34_1;
		this.genum50_0 = genum50_1;
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public GClass34 method_0()
	{
		return this.gclass34_0;
	}

	public GEnum50 method_1()
	{
		return this.genum50_0;
	}

	public int method_2()
	{
		return this.int_0;
	}

	public void method_3(int int_2)
	{
		if (int_2 != this.int_0)
		{
			this.int_0 = int_2;
			this.vmethod_0();
		}
	}

	public int method_4()
	{
		return this.int_0 + this.int_1;
	}

	public double method_5()
	{
		if (this.int_0 != 0 && this.double_0 == 0.0)
		{
			this.double_0 = this.gclass34_0.method_0().method_11().method_20(this.int_0);
		}
		return this.double_0;
	}

	public double method_6()
	{
		return this.method_5() + this.method_9();
	}

	protected virtual void vmethod_0()
	{
		this.double_0 = this.gclass34_0.method_0().method_11().method_20(this.int_0);
		this.gclass34_0.method_12(this, GEnum5.flag_3);
	}

	public int method_7()
	{
		return this.int_1;
	}

	public void method_8(int int_2)
	{
		if (this.bool_0 && int_2 != this.int_1)
		{
			this.int_1 = int_2;
			this.vmethod_1();
		}
	}

	public double method_9()
	{
		if (this.int_1 != 0 && this.double_1 == 0.0)
		{
			this.double_1 = this.gclass34_0.method_0().method_11().method_20(this.int_0 + this.int_1) - this.method_5();
		}
		return this.double_1;
	}

	protected virtual void vmethod_1()
	{
		this.double_1 = this.gclass34_0.method_0().method_11().method_20(this.int_0 + this.int_1) - this.method_5();
		this.gclass34_0.method_12(this, GEnum5.flag_4);
	}

	GClass34 gclass34_0;

	GEnum50 genum50_0;

	int int_0;

	double double_0;

	protected bool bool_0 = true;

	int int_1;

	double double_1;
}
