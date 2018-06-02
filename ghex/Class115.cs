using System;
using System.ComponentModel;
using System.Drawing;

class Class115
{
    public Class115()
    {
        this.image_0 = null;
        this.genum34_0 = GEnum34.const_0;
    }

    public Image method_0()
    {
        return this.image_0;
    }

    public void method_1(Image image_1)
    {
        this.image_0 = image_1;
    }

    public GEnum34 method_2()
    {
        return this.genum34_0;
    }

    public void method_3(GEnum34 genum34_1)
    {
        if (!Enum.IsDefined(typeof(GEnum34), genum34_1))
        {
            throw new InvalidEnumArgumentException("value", (int)genum34_1, typeof(GEnum34));
        }
        if (this.genum34_0 != genum34_1)
        {
            this.genum34_0 = genum34_1;
        }
    }

    Image image_0;

    GEnum34 genum34_0;
}
