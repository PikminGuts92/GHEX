using System;
using System.Collections;
using System.Windows.Forms;

public class GClass59 : GClass55
{
    public GClass59(GClass104 gclass104_1, int int_1, IComparer icomparer_1, SortOrder sortOrder_1) : base(gclass104_1, int_1, icomparer_1, sortOrder_1)
    {
    }

    public override void vmethod_0()
    {
        for (int i = 1; i < base.method_4().method_12().Count; i++)
        {
            int num = i;
            GClass83 gclass = base.method_4().method_12().method_9(i);
            while (num > 0 && base.method_0(base.method_4().method_10(num - 1, base.method_5()), gclass.method_9().method_9(base.method_5())) > 0)
            {
                base.method_3(num, base.method_4().method_12().method_9(num - 1));
                num--;
            }
            base.method_3(num, gclass);
        }
    }
}
