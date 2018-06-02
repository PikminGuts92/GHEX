using System;
using System.ComponentModel;
using System.Drawing;

[ToolboxItem(false)]
[DesignTimeVisible(false)]
public class GClass27 : GClass17
{
    public GClass27()
    {
        this.method_44();
    }

    public GClass27(string string_3) : base(string_3)
    {
        this.method_44();
    }

    public GClass27(string string_3, int int_11) : base(string_3, int_11)
    {
        this.method_44();
    }

    public GClass27(string string_3, int int_11, bool bool_2) : base(string_3, int_11, bool_2)
    {
        this.method_44();
    }

    public GClass27(string string_3, Image image_1) : base(string_3, image_1)
    {
        this.method_44();
    }

    public GClass27(string string_3, Image image_1, int int_11) : base(string_3, image_1, int_11)
    {
        this.method_44();
    }

    public GClass27(string string_3, Image image_1, int int_11, bool bool_2) : base(string_3, image_1, int_11, bool_2)
    {
        this.method_44();
    }

    void method_44()
    {
        this.bool_1 = true;
        this.method_48(false);
    }

    public override string vmethod_0()
    {
        return "IMAGE";
    }

    public override GInterface2 vmethod_1()
    {
        return new GClass8();
    }

    public override string vmethod_2()
    {
        return null;
    }

    public override GInterface3 vmethod_3()
    {
        return null;
    }

    public bool method_45()
    {
        return this.bool_1;
    }

    public void method_46(bool bool_2)
    {
        if (this.bool_1 != bool_2)
        {
            this.bool_1 = bool_2;
            this.vmethod_13(new GClass93(this, GEnum13.const_9, null));
        }
    }

    public override Type vmethod_8()
    {
        return typeof(GClass42);
    }

    public bool method_47()
    {
        return base.vmethod_9();
    }

    public void method_48(bool bool_2)
    {
        base.vmethod_10(bool_2);
    }

    bool bool_1;
}
