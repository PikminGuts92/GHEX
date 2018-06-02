using System;
using System.Windows.Forms;

public class GClass39 : GClass38
{
    public GClass39(GClass104 gclass104_1, int int_1, SortOrder sortOrder_1) : base(gclass104_1, int_1, sortOrder_1)
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
        if (gclass.method_7() == null && gclass2.method_7() == null)
        {
            return 0;
        }
        if (gclass.method_7() == null)
        {
            return -1;
        }
        if (gclass2.method_7() == null)
        {
            return 1;
        }
        return Convert.ToDecimal(gclass.method_7()).CompareTo(Convert.ToDecimal(gclass2.method_7()));
    }
}
