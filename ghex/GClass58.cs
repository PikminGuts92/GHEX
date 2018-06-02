using System;
using System.Collections;
using System.Windows.Forms;

public class GClass58 : GClass55
{
    public GClass58(GClass104 gclass104_1, int int_1, IComparer icomparer_1, SortOrder sortOrder_1) : base(gclass104_1, int_1, icomparer_1, sortOrder_1)
    {
    }

    public override void vmethod_0()
    {
        int i = 1;
        while (i * 3 + 1 <= base.method_4().method_12().Count)
        {
            i = 3 * i + 1;
        }
        while (i > 0)
        {
            for (int j = i - 1; j < base.method_4().method_12().Count; j++)
            {
                GClass83 gclass = base.method_4().method_12().method_9(j);
                int num = j;
                bool flag = true;
                while (flag)
                {
                    if (num >= i)
                    {
                        if (base.method_0(base.method_4().method_10(num - i, base.method_5()), gclass.method_9().method_9(base.method_5())) > 0)
                        {
                            base.method_2(num, num - i);
                            num -= i;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                    else
                    {
                        flag = false;
                    }
                }
                base.method_3(num, gclass);
            }
            i /= 3;
        }
    }
}
