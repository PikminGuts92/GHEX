using System;

public class GClass117 : GClass114
{
    public GClass117(GClass36 gclass36_0, GEnum50 genum50_1) : base(gclass36_0, genum50_1)
    {
        this.bool_0 = false;
    }

    public GClass117(GClass36 gclass36_0, GEnum50 genum50_1, int int_5, GEnum52 genum52_1, int int_6, int int_7, int int_8) : base(gclass36_0, genum50_1, int_8, 0)
    {
        this.bool_0 = false;
        this.int_4 = int_5;
        this.genum52_0 = genum52_1;
        this.int_3 = int_6;
        this.int_2 = int_7;
    }

    public int method_10()
    {
        return this.int_2;
    }

    public void method_11(int int_5)
    {
        if (int_5 != this.int_2)
        {
            this.int_2 = int_5;
            base.method_0().method_12(this, GEnum5.flag_2);
        }
    }

    public int method_12()
    {
        return this.int_3;
    }

    public void method_13(int int_5)
    {
        if (int_5 != this.int_3)
        {
            this.int_3 = int_5;
            base.method_0().method_12(this, GEnum5.flag_2);
        }
    }

    public int method_14()
    {
        return this.int_4;
    }

    public void method_15(int int_5)
    {
        if (int_5 != this.int_4)
        {
            this.int_4 = int_5;
            base.method_0().method_12(this, GEnum5.flag_2);
        }
    }

    public GEnum52 method_16()
    {
        return this.genum52_0;
    }

    public void method_17(GEnum52 genum52_1)
    {
        if (genum52_1 != this.genum52_0)
        {
            this.genum52_0 = genum52_1;
            base.method_0().method_12(this, GEnum5.flag_2);
        }
    }

    int int_2 = 24;

    int int_3 = 8;

    int int_4 = 4;

    GEnum52 genum52_0 = GEnum52.const_2;
}
