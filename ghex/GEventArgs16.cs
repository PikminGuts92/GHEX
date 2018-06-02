using System;
using System.Drawing;
using System.Windows.Forms;

public class GEventArgs16 : MouseEventArgs
{
    public GEventArgs16(GClass17 gclass17_1, GControl2 gcontrol2_1, int int_1, Rectangle rectangle_1) : base(MouseButtons.None, 0, -1, -1, 0)
    {
        this.gclass17_0 = gclass17_1;
        this.gcontrol2_0 = gcontrol2_1;
        this.int_0 = int_1;
        this.rectangle_0 = rectangle_1;
    }

    public GEventArgs16(GClass17 gclass17_1, GControl2 gcontrol2_1, int int_1, Rectangle rectangle_1, MouseEventArgs mouseEventArgs_0) : base(mouseEventArgs_0.Button, mouseEventArgs_0.Clicks, mouseEventArgs_0.X, mouseEventArgs_0.Y, mouseEventArgs_0.Delta)
    {
        this.gclass17_0 = gclass17_1;
        this.gcontrol2_0 = gcontrol2_1;
        this.int_0 = int_1;
        this.rectangle_0 = rectangle_1;
    }

    public GClass17 method_0()
    {
        return this.gclass17_0;
    }

    public GControl2 method_1()
    {
        return this.gcontrol2_0;
    }

    public int method_2()
    {
        return this.int_0;
    }

    public Rectangle method_3()
    {
        return this.rectangle_0;
    }

    GClass17 gclass17_0;

    GControl2 gcontrol2_0;

    int int_0;

    Rectangle rectangle_0;
}
