using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

[DesignTimeVisible(false)]
[ToolboxItem(false)]
public class GClass22 : GClass19
{
    public GClass22()
    {
        this.method_47();
    }

    public GClass22(string string_7) : base(string_7)
    {
        this.method_47();
    }

    public GClass22(string string_7, int int_11) : base(string_7, int_11)
    {
        this.method_47();
    }

    public GClass22(string string_7, int int_11, bool bool_2) : base(string_7, int_11, bool_2)
    {
        this.method_47();
    }

    public GClass22(string string_7, Image image_1) : base(string_7, image_1)
    {
        this.method_47();
    }

    public GClass22(string string_7, Image image_1, int int_11) : base(string_7, image_1, int_11)
    {
        this.method_47();
    }

    public GClass22(string string_7, Image image_1, int int_11, bool bool_2) : base(string_7, image_1, int_11, bool_2)
    {
        this.method_47();
    }

    internal void method_47()
    {
        this.dateTimePickerFormat_0 = DateTimePickerFormat.Long;
        this.string_6 = DateTimeFormatInfo.CurrentInfo.ShortDatePattern + " " + DateTimeFormatInfo.CurrentInfo.LongTimePattern;
    }

    public override string vmethod_0()
    {
        return "DATETIME";
    }

    public override GInterface2 vmethod_1()
    {
        return new GClass4();
    }

    public override string vmethod_2()
    {
        return "DATETIME";
    }

    public override GInterface3 vmethod_3()
    {
        return new GClass48();
    }

    public DateTimePickerFormat method_48()
    {
        return this.dateTimePickerFormat_0;
    }

    public void method_49(DateTimePickerFormat dateTimePickerFormat_1)
    {
        if (!Enum.IsDefined(typeof(DateTimePickerFormat), dateTimePickerFormat_1))
        {
            throw new InvalidEnumArgumentException("value", (int)dateTimePickerFormat_1, typeof(DateTimePickerFormat));
        }
        if (this.dateTimePickerFormat_0 != dateTimePickerFormat_1)
        {
            this.dateTimePickerFormat_0 = dateTimePickerFormat_1;
            this.vmethod_13(new GClass93(this, GEnum13.const_9, null));
        }
    }

    public string method_50()
    {
        return this.string_6;
    }

    public void method_51(string string_7)
    {
        if (string_7 == null)
        {
            throw new ArgumentNullException("CustomFormat cannot be null");
        }
        if (!this.string_6.Equals(string_7))
        {
            this.string_6 = string_7;
            this.vmethod_13(new GClass93(this, GEnum13.const_9, null));
        }
        DateTime.Now.ToString(DateTimeFormatInfo.CurrentInfo.ShortDatePattern);
    }

    bool method_52()
    {
        return !this.string_6.Equals(DateTimeFormatInfo.CurrentInfo.ShortDatePattern + " " + DateTimeFormatInfo.CurrentInfo.LongTimePattern);
    }

    public string method_53()
    {
        return this.method_50();
    }

    public void method_54(string string_7)
    {
        this.method_51(string_7);
    }

    public override Type vmethod_8()
    {
        return typeof(GClass40);
    }

    public static readonly string string_3 = DateTimeFormatInfo.CurrentInfo.LongDatePattern;

    public static readonly string string_4 = DateTimeFormatInfo.CurrentInfo.ShortDatePattern;

    public static readonly string string_5 = DateTimeFormatInfo.CurrentInfo.LongTimePattern;

    DateTimePickerFormat dateTimePickerFormat_0;

    string string_6;
}
