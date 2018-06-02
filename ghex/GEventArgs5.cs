using System;
using System.Drawing;

public class GEventArgs5 : GEventArgs0
{
    public GEventArgs5(GClass97 gclass97_1, GInterface3 ginterface3_1, GControl2 gcontrol2_1) : this(gclass97_1, ginterface3_1, gcontrol2_1, -1, -1, Rectangle.Empty)
    {
    }

    public GEventArgs5(GClass97 gclass97_1, GInterface3 ginterface3_1, GControl2 gcontrol2_1, int int_2, int int_3, Rectangle rectangle_1) : base(gclass97_1, int_3, int_2)
    {
        this.ginterface3_0 = ginterface3_1;
        this.gcontrol2_0 = gcontrol2_1;
        this.rectangle_0 = rectangle_1;
        this.bool_0 = false;
    }

    public GInterface3 method_6()
    {
        return this.ginterface3_0;
    }

    public GControl2 method_7()
    {
        return this.gcontrol2_0;
    }

    public Rectangle method_8()
    {
        return this.rectangle_0;
    }

    public bool method_9()
    {
        return this.bool_0;
    }

    public void method_10(bool bool_2)
    {
        this.bool_0 = bool_2;
    }

    public bool method_11()
    {
        return this.bool_1;
    }

    public void method_12(bool bool_2)
    {
        this.bool_1 = bool_2;
    }

    GInterface3 ginterface3_0;

    GControl2 gcontrol2_0;

    Rectangle rectangle_0;

    bool bool_0;

    bool bool_1;
}
