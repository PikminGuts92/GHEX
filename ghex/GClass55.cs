using System;
using System.Collections;
using System.Windows.Forms;

public abstract class GClass55
{
    public GClass55(GClass104 gclass104_1, int int_1, IComparer icomparer_1, SortOrder sortOrder_1)
    {
        this.gclass104_0 = gclass104_1;
        this.int_0 = int_1;
        this.icomparer_0 = icomparer_1;
        this.sortOrder_0 = sortOrder_1;
    }

    protected int method_0(GClass97 gclass97_0, GClass97 gclass97_1)
    {
        switch (this.method_7())
        {
        case SortOrder.None:
            return 0;
        case SortOrder.Descending:
            return -this.method_6().Compare(gclass97_0, gclass97_1);
        }
        return this.method_6().Compare(gclass97_0, gclass97_1);
    }

    public abstract void vmethod_0();

    protected void method_1(int int_1, int int_2)
    {
        GClass83 gclass83_ = this.method_4().method_12().method_9(int_1);
        this.method_4().method_12().method_10(int_1, this.method_4().method_12().method_9(int_2));
        this.method_4().method_12().method_10(int_2, gclass83_);
    }

    protected void method_2(int int_1, int int_2)
    {
        this.method_4().method_12().method_10(int_1, this.method_4().method_12().method_9(int_2));
    }

    protected void method_3(int int_1, GClass83 gclass83_0)
    {
        this.method_4().method_12().method_10(int_1, gclass83_0);
    }

    public GClass104 method_4()
    {
        return this.gclass104_0;
    }

    public int method_5()
    {
        return this.int_0;
    }

    public IComparer method_6()
    {
        return this.icomparer_0;
    }

    public SortOrder method_7()
    {
        return this.sortOrder_0;
    }

    GClass104 gclass104_0;

    int int_0;

    IComparer icomparer_0;

    SortOrder sortOrder_0;
}
