using System;

public class GEventArgs9 : EventArgs
{
    public GEventArgs9(GClass104 gclass104_1) : this(gclass104_1, null, -1, -1)
    {
    }

    public GEventArgs9(GClass104 gclass104_1, int int_2, int int_3) : this(gclass104_1, null, int_2, int_3)
    {
    }

    public GEventArgs9(GClass104 gclass104_1, GClass83 gclass83_1, int int_2, int int_3)
    {
        this.gclass104_0 = gclass104_1;
        this.gclass83_0 = gclass83_1;
        this.int_1 = int_2;
        this.int_0 = int_3;
    }

    public GClass104 method_0()
    {
        return this.gclass104_0;
    }

    public GClass83 method_1()
    {
        return this.gclass83_0;
    }

    public int method_2()
    {
        return this.int_1;
    }

    public int method_3()
    {
        return this.int_0;
    }

    GClass104 gclass104_0;

    GClass83 gclass83_0;

    int int_0;

    int int_1;
}
