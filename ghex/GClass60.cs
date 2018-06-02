using System;
using System.ComponentModel;
using System.Drawing;

public class GClass60
{
    public GClass60()
    {
        this.genum55_0 = GEnum55.const_0;
        this.int_0 = -1;
        this.int_1 = -1;
    }

    public GEnum55 method_0()
    {
        return this.genum55_0;
    }

    public void method_1(GEnum55 genum55_1)
    {
        if (!Enum.IsDefined(typeof(GEnum55), genum55_1))
        {
            throw new InvalidEnumArgumentException("value", (int)genum55_1, typeof(GEnum55));
        }
        this.genum55_0 = genum55_1;
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

    GEnum55 genum55_0;

    int int_0;

    int int_1;
}
