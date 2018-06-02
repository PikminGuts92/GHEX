using System;
using System.Collections;
using System.Windows.Forms;

public class GClass57 : GClass55
{
    public GClass57(GClass104 gclass104_1, int int_1, IComparer icomparer_1, SortOrder sortOrder_1) : base(gclass104_1, int_1, icomparer_1, sortOrder_1)
    {
    }

    public override void vmethod_0()
    {
        this.method_8(0, base.method_4().method_12().Count - 1);
    }

    void method_8(int int_1, int int_2)
    {
        if (int_1 < int_2)
        {
            int num = (int_1 + int_2) / 2;
            this.method_8(int_1, num);
            this.method_8(num + 1, int_2);
            int num2 = num;
            int num3 = num + 1;
            while (int_1 <= num2 & num3 <= int_2)
            {
                if (base.method_0(base.method_4().method_10(int_1, base.method_5()), base.method_4().method_10(num3, base.method_5())) < 0)
                {
                    int_1++;
                }
                else
                {
                    GClass83 gclass83_ = base.method_4().method_12().method_9(num3);
                    for (int i = num3 - 1; i >= int_1; i--)
                    {
                        base.method_3(i + 1, base.method_4().method_12().method_9(i));
                    }
                    base.method_3(int_1, gclass83_);
                    int_1++;
                    num2++;
                    num3++;
                }
            }
        }
    }
}
