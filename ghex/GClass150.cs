using System;
using System.Drawing;

public class GClass150
{
    public GClass150()
    {
        this.color_0 = Color.Empty;
        this.color_1 = Color.Empty;
        this.font_0 = null;
        this.gstruct13_0 = GStruct13.gstruct13_0;
    }

    public Font method_0()
    {
        return this.font_0;
    }

    public void method_1(Font font_1)
    {
        this.font_0 = font_1;
    }

    public Color method_2()
    {
        return this.color_0;
    }

    public void method_3(Color color_2)
    {
        this.color_0 = color_2;
    }

    public Color method_4()
    {
        return this.color_1;
    }

    public void method_5(Color color_2)
    {
        this.color_1 = color_2;
    }

    public GStruct13 method_6()
    {
        return this.gstruct13_0;
    }

    public void method_7(GStruct13 gstruct13_1)
    {
        this.gstruct13_0 = gstruct13_1;
    }

    Color color_0;

    Color color_1;

    Font font_0;

    GStruct13 gstruct13_0;
}
