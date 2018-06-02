using System;
using System.Windows.Forms;

public class GClass41 : GClass38
{
    public GClass41(GClass104 gclass104_1, int int_1, SortOrder sortOrder_1) : base(gclass104_1, int_1, sortOrder_1)
    {
    }

    public override int Compare(object object_0, object object_1)
    {
        GClass97 gclass = (GClass97)object_0;
        GClass97 gclass2 = (GClass97)object_1;
        if (gclass == null && gclass2 == null)
        {
            return 0;
        }
        if (gclass == null)
        {
            return -1;
        }
        if (gclass2 == null)
        {
            return 1;
        }
        int num = 0;
        if (gclass.method_27() && !gclass2.method_27())
        {
            num = -1;
        }
        else if (!gclass.method_27() && gclass2.method_27())
        {
            num = 1;
        }
        if (num == 0 && ((GClass24)base.method_0().method_18().method_166().method_23().method_8(base.method_1())).method_48())
        {
            if (gclass.method_5() == null && gclass2.method_5() == null)
            {
                return 0;
            }
            if (gclass.method_5() == null)
            {
                return -1;
            }
            num = gclass.method_5().CompareTo(gclass2.method_5());
        }
        return num;
    }
}
