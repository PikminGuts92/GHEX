using System;
using System.ComponentModel;
using System.Drawing;

[DesignTimeVisible(false)]
[ToolboxItem(false)]
public class GClass24 : GClass17
{
    public GClass24()
    {
        this.method_44();
    }

    public GClass24(string string_3) : base(string_3)
    {
        this.method_44();
    }

    public GClass24(string string_3, int int_11) : base(string_3, int_11)
    {
        this.method_44();
    }

    public GClass24(string string_3, int int_11, bool bool_2) : base(string_3, int_11, bool_2)
    {
        this.method_44();
    }

    public GClass24(string string_3, Image image_1) : base(string_3, image_1)
    {
        this.method_44();
    }

    public GClass24(string string_3, Image image_1, int int_11) : base(string_3, image_1, int_11)
    {
        this.method_44();
    }

    public GClass24(string string_3, Image image_1, int int_11, bool bool_2) : base(string_3, image_1, int_11, bool_2)
    {
        this.method_44();
    }

    void method_44()
    {
        this.size_0 = new Size(13, 13);
        this.bool_1 = true;
        this.genum4_0 = GEnum4.const_0;
    }

    public override string vmethod_0()
    {
        return "CHECKBOX";
    }

    public override GInterface2 vmethod_1()
    {
        return new GClass7();
    }

    public override string vmethod_2()
    {
        return null;
    }

    public override GInterface3 vmethod_3()
    {
        return null;
    }

    public Size method_45()
    {
        return this.size_0;
    }

    public void method_46(Size size_1)
    {
        if (size_1.Width < 0 || size_1.Height < 0)
        {
            size_1 = new Size(13, 13);
        }
        if (this.size_0 != size_1)
        {
            this.size_0 = size_1;
            this.vmethod_13(new GClass93(this, GEnum13.const_9, null));
        }
    }

    bool method_47()
    {
        return this.size_0.Width != 13 || this.size_0.Height != 13;
    }

    public bool method_48()
    {
        return this.bool_1;
    }

    public void method_49(bool bool_2)
    {
        if (this.bool_1 != bool_2)
        {
            this.bool_1 = bool_2;
            this.vmethod_13(new GClass93(this, GEnum13.const_9, null));
        }
    }

    public GEnum4 method_50()
    {
        return this.genum4_0;
    }

    public void method_51(GEnum4 genum4_1)
    {
        if (!Enum.IsDefined(typeof(GEnum4), genum4_1))
        {
            throw new InvalidEnumArgumentException("value", (int)genum4_1, typeof(GEnum4));
        }
        if (this.genum4_0 != genum4_1)
        {
            this.genum4_0 = genum4_1;
            this.vmethod_13(new GClass93(this, GEnum13.const_9, null));
        }
    }

    public override Type vmethod_8()
    {
        return typeof(GClass41);
    }

    Size size_0;

    bool bool_1;

    GEnum4 genum4_0;
}
