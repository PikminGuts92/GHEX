using System;
using System.ComponentModel;
using System.Drawing;

[ToolboxItem(false)]
[DesignTimeVisible(false)]
public class GClass23 : GClass17
{
    public GClass23()
    {
        this.method_44();
    }

    public GClass23(string string_3) : base(string_3)
    {
        this.method_44();
    }

    public GClass23(string string_3, int int_11) : base(string_3, int_11)
    {
        this.method_44();
    }

    public GClass23(string string_3, int int_11, bool bool_1) : base(string_3, int_11, bool_1)
    {
        this.method_44();
    }

    public GClass23(string string_3, Image image_1) : base(string_3, image_1)
    {
        this.method_44();
    }

    public GClass23(string string_3, Image image_1, int int_11) : base(string_3, image_1, int_11)
    {
        this.method_44();
    }

    public GClass23(string string_3, Image image_1, int int_11, bool bool_1) : base(string_3, image_1, int_11, bool_1)
    {
        this.method_44();
    }

    void method_44()
    {
        this.vmethod_5(GEnum39.const_1);
        this.contentAlignment_0 = ContentAlignment.MiddleCenter;
        this.vmethod_10(false);
        this.vmethod_12(false);
    }

    public override string vmethod_0()
    {
        return "BUTTON";
    }

    public override GInterface2 vmethod_1()
    {
        return new GClass10();
    }

    public override string vmethod_2()
    {
        return null;
    }

    public override GInterface3 vmethod_3()
    {
        return null;
    }

    public override GEnum39 vmethod_4()
    {
        return base.vmethod_4();
    }

    public override void vmethod_5(GEnum39 genum39_1)
    {
        base.vmethod_5(genum39_1);
    }

    public ContentAlignment method_45()
    {
        return this.contentAlignment_0;
    }

    public void method_46(ContentAlignment contentAlignment_1)
    {
        if (!Enum.IsDefined(typeof(ContentAlignment), contentAlignment_1))
        {
            throw new InvalidEnumArgumentException("value", (int)contentAlignment_1, typeof(ContentAlignment));
        }
        if (this.contentAlignment_0 != contentAlignment_1)
        {
            this.contentAlignment_0 = contentAlignment_1;
            this.vmethod_13(new GClass93(this, GEnum13.const_9, null));
        }
    }

    public override bool vmethod_9()
    {
        return base.vmethod_9();
    }

    public override void vmethod_10(bool bool_1)
    {
        base.vmethod_10(bool_1);
    }

    public override bool vmethod_11()
    {
        return base.vmethod_11();
    }

    public override void vmethod_12(bool bool_1)
    {
        base.vmethod_12(bool_1);
    }

    public override Type vmethod_8()
    {
        return typeof(GClass43);
    }

    ContentAlignment contentAlignment_0;
}
