using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

[DesignTimeVisible(false)]
[ToolboxItem(false)]
public class GClass18 : GClass17
{
    public GClass18()
    {
        this.method_44();
    }

    public GClass18(string string_3) : base(string_3)
    {
        this.method_44();
    }

    public GClass18(string string_3, int int_11) : base(string_3, int_11)
    {
        this.method_44();
    }

    public GClass18(string string_3, int int_11, bool bool_2) : base(string_3, int_11, bool_2)
    {
        this.method_44();
    }

    public GClass18(string string_3, Image image_1) : base(string_3, image_1)
    {
        this.method_44();
    }

    public GClass18(string string_3, Image image_1, int int_11) : base(string_3, image_1, int_11)
    {
        this.method_44();
    }

    public GClass18(string string_3, Image image_1, int int_11, bool bool_2) : base(string_3, image_1, int_11, bool_2)
    {
        this.method_44();
    }

    void method_44()
    {
        this.method_59("G");
        this.decimal_1 = 100m;
        this.decimal_2 = 0m;
        this.decimal_0 = 1m;
        this.bool_1 = false;
        this.leftRightAlignment_0 = LeftRightAlignment.Right;
    }

    public override string vmethod_0()
    {
        return "NUMBER";
    }

    public override GInterface2 vmethod_1()
    {
        return new GClass12();
    }

    public override string vmethod_2()
    {
        return "NUMBER";
    }

    public override GInterface3 vmethod_3()
    {
        return new GClass51();
    }

    public decimal method_45()
    {
        return this.decimal_1;
    }

    public void method_46(decimal decimal_3)
    {
        this.decimal_1 = decimal_3;
        if (this.decimal_2 > this.decimal_1)
        {
            this.decimal_2 = this.decimal_1;
        }
        this.vmethod_13(new GClass93(this, GEnum13.const_9, null));
    }

    bool method_47()
    {
        return this.decimal_1 != 100m;
    }

    public decimal method_48()
    {
        return this.decimal_2;
    }

    public void method_49(decimal decimal_3)
    {
        this.decimal_2 = decimal_3;
        if (this.decimal_2 > this.decimal_1)
        {
            this.decimal_1 = decimal_3;
        }
        this.vmethod_13(new GClass93(this, GEnum13.const_9, null));
    }

    bool method_50()
    {
        return this.decimal_2 != 0m;
    }

    public decimal method_51()
    {
        return this.decimal_0;
    }

    public void method_52(decimal decimal_3)
    {
        if (decimal_3 < 0m)
        {
            throw new ArgumentException("value must be greater than zero");
        }
        this.decimal_0 = decimal_3;
    }

    bool method_53()
    {
        return this.decimal_0 != 1m;
    }

    public bool method_54()
    {
        return this.bool_1;
    }

    public void method_55(bool bool_2)
    {
        if (this.bool_1 != bool_2)
        {
            this.bool_1 = bool_2;
            this.vmethod_13(new GClass93(this, GEnum13.const_9, null));
        }
    }

    public LeftRightAlignment method_56()
    {
        return this.leftRightAlignment_0;
    }

    public void method_57(LeftRightAlignment leftRightAlignment_1)
    {
        if (!Enum.IsDefined(typeof(LeftRightAlignment), leftRightAlignment_1))
        {
            throw new InvalidEnumArgumentException("value", (int)leftRightAlignment_1, typeof(LeftRightAlignment));
        }
        if (this.leftRightAlignment_0 != leftRightAlignment_1)
        {
            this.leftRightAlignment_0 = leftRightAlignment_1;
            this.vmethod_13(new GClass93(this, GEnum13.const_9, null));
        }
    }

    public string method_58()
    {
        return base.method_7();
    }

    public void method_59(string string_3)
    {
        base.method_8(string_3);
    }

    public override Type vmethod_8()
    {
        return typeof(GClass39);
    }

    decimal decimal_0;

    decimal decimal_1;

    decimal decimal_2;

    LeftRightAlignment leftRightAlignment_0;

    bool bool_1;
}
