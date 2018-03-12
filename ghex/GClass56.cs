using System;
using System.Collections;
using System.Windows.Forms;

public class GClass56 : GClass55
{
	public GClass56(GClass104 gclass104_1, int int_1, IComparer icomparer_1, SortOrder sortOrder_1) : base(gclass104_1, int_1, icomparer_1, sortOrder_1)
	{
	}

	public override void vmethod_0()
	{
		int num = base.method_4().method_12().Count;
		for (int i = num / 2; i > 0; i--)
		{
			this.method_8(i, num);
		}
		do
		{
			base.method_1(0, num - 1);
			num--;
			this.method_8(1, num);
		}
		while (num > 1);
	}

	void method_8(int int_1, int int_2)
	{
		bool flag = true;
		while (int_1 <= int_2 / 2 && flag)
		{
			int num = int_1 + int_1;
			if (num < int_2 && base.method_0(base.method_4().method_10(num - 1, base.method_5()), base.method_4().method_10(num, base.method_5())) < 0)
			{
				num++;
			}
			if (base.method_0(base.method_4().method_10(int_1 - 1, base.method_5()), base.method_4().method_10(num - 1, base.method_5())) >= 0)
			{
				flag = false;
			}
			else
			{
				base.method_1(int_1 - 1, num - 1);
				int_1 = num;
			}
		}
	}
}
