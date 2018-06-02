using System;
using System.ComponentModel;
using System.Drawing;

[ToolboxItem(false)]
[DesignTimeVisible(false)]
public class GClass21 : GClass19
{
    public GClass21()
    {
        this.method_47();
    }

    public GClass21(string string_3) : base(string_3)
    {
        this.method_47();
    }

    public GClass21(string string_3, int int_11) : base(string_3, int_11)
    {
        this.method_47();
    }

    public GClass21(string string_3, int int_11, bool bool_4) : base(string_3, int_11, bool_4)
    {
        this.method_47();
    }

    public GClass21(string string_3, Image image_1) : base(string_3, image_1)
    {
        this.method_47();
    }

    public GClass21(string string_3, Image image_1, int int_11) : base(string_3, image_1, int_11)
    {
        this.method_47();
    }

    public GClass21(string string_3, Image image_1, int int_11, bool bool_4) : base(string_3, image_1, int_11, bool_4)
    {
        this.method_47();
    }

    void method_47()
    {
        this.bool_2 = true;
        this.bool_3 = true;
    }

    public override string vmethod_0()
    {
        return "COLOR";
    }

    public override GInterface2 vmethod_1()
    {
        return new GClass6();
    }

    public override string vmethod_2()
    {
        return "COLOR";
    }

    public override GInterface3 vmethod_3()
    {
        return new GClass47();
    }

    public bool method_48()
    {
        return this.bool_2;
    }

    public void method_49(bool bool_4)
    {
        if (this.bool_2 != bool_4)
        {
            this.bool_2 = bool_4;
            this.vmethod_13(new GClass93(this, GEnum13.const_9, null));
        }
    }

    public bool method_50()
    {
        return this.bool_3;
    }

    public void method_51(bool bool_4)
    {
        if (this.bool_3 != bool_4)
        {
            this.bool_3 = bool_4;
            this.vmethod_13(new GClass93(this, GEnum13.const_9, null));
        }
    }

    public override Type vmethod_8()
    {
        return typeof(GClass44);
    }

    bool bool_2;

    bool bool_3;
}
