using System;
using System.Drawing;
using System.Windows.Forms;

public class GEventArgs17 : KeyEventArgs
{
    public GEventArgs17(GClass97 gclass97_1, GControl2 gcontrol2_1, int int_2, int int_3, Rectangle rectangle_1, KeyEventArgs keyEventArgs_0) : base(keyEventArgs_0.KeyData)
    {
        this.gclass97_0 = gclass97_1;
        this.gcontrol2_0 = gcontrol2_1;
        this.int_0 = int_2;
        this.int_1 = int_3;
        this.rectangle_0 = rectangle_1;
    }

    public GEventArgs17(GClass97 gclass97_1, GControl2 gcontrol2_1, GStruct9 gstruct9_0, Rectangle rectangle_1, KeyEventArgs keyEventArgs_0) : base(keyEventArgs_0.KeyData)
    {
        this.gclass97_0 = gclass97_1;
        this.gcontrol2_0 = gcontrol2_1;
        this.int_0 = gstruct9_0.method_1();
        this.int_1 = gstruct9_0.method_3();
        this.rectangle_0 = rectangle_1;
    }

    public GClass97 method_0()
    {
        return this.gclass97_0;
    }

    public GControl2 method_1()
    {
        return this.gcontrol2_0;
    }

    public int method_2()
    {
        return this.int_0;
    }

    public int method_3()
    {
        return this.int_1;
    }

    public Rectangle method_4()
    {
        return this.rectangle_0;
    }

    public GStruct9 method_5()
    {
        return new GStruct9(this.method_2(), this.method_3());
    }

    GClass97 gclass97_0;

    GControl2 gcontrol2_0;

    int int_0;

    int int_1;

    Rectangle rectangle_0;
}
