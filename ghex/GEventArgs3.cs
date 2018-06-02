using System;
using System.Drawing;

public class GEventArgs3 : GEventArgs0
{
    public GEventArgs3(GClass97 gclass97_1, GControl2 gcontrol2_1, int int_2, int int_3, Rectangle rectangle_1) : base(gclass97_1, int_3, int_2)
    {
        this.gcontrol2_0 = gcontrol2_1;
        this.rectangle_0 = rectangle_1;
    }

    public GControl2 method_6()
    {
        return this.gcontrol2_0;
    }

    public Rectangle method_7()
    {
        return this.rectangle_0;
    }

    GControl2 gcontrol2_0;

    Rectangle rectangle_0;
}
