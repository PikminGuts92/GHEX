using System;
using System.ComponentModel;
using System.Drawing;

public class GClass76
{
    public GClass76()
    {
        this.genum11_0 = GEnum11.const_0;
        this.int_0 = -1;
        this.int_1 = -1;
    }

    public GEnum11 method_0()
    {
        return this.genum11_0;
    }

    public void method_1(GEnum11 genum11_1)
    {
        if (!Enum.IsDefined(typeof(GEnum11), genum11_1))
        {
            throw new InvalidEnumArgumentException("value", (int)genum11_1, typeof(GEnum11));
        }
        this.genum11_0 = genum11_1;
    }

    public Point method_2()
    {
        return new Point(this.int_0, this.int_1);
    }

    public void method_3(Point point_0)
    {
        this.int_0 = point_0.X;
        this.int_1 = point_0.Y;
    }

    GEnum11 genum11_0;

    int int_0;

    int int_1;
}
