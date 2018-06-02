using System;

public class GEventArgs12 : EventArgs
{
    public GEventArgs12(GClass98 gclass98_1, GEnum32 genum32_1)
    {
        this.genum32_0 = genum32_1;
        this.gclass98_0 = gclass98_1;
    }

    public GEnum32 method_0()
    {
        return this.genum32_0;
    }

    public GClass98 method_1()
    {
        return this.gclass98_0;
    }

    GClass98 gclass98_0;

    GEnum32 genum32_0;
}
