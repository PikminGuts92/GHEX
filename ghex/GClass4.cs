using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class GClass4 : GClass3
{
    public GClass4()
    {
        this.dateTimePickerFormat_0 = DateTimePickerFormat.Long;
        base.method_12(GClass22.string_3);
    }

    public DateTimePickerFormat method_22()
    {
        return this.dateTimePickerFormat_0;
    }

    public void method_23(DateTimePickerFormat dateTimePickerFormat_1)
    {
        if (!Enum.IsDefined(typeof(DateTimePickerFormat), dateTimePickerFormat_1))
        {
            throw new InvalidEnumArgumentException("value", (int)dateTimePickerFormat_1, typeof(DateTimePickerFormat));
        }
        this.dateTimePickerFormat_0 = dateTimePickerFormat_1;
    }

    public override void imethod_13(GEventArgs8 geventArgs8_0)
    {
        if (geventArgs8_0.method_2().method_166().method_23().method_8(geventArgs8_0.method_6()) is GClass22)
        {
            GClass22 gclass = (GClass22)geventArgs8_0.method_2().method_166().method_23().method_8(geventArgs8_0.method_6());
            this.method_23(gclass.method_48());
            base.method_12(gclass.method_50());
        }
        else
        {
            this.method_23(DateTimePickerFormat.Long);
            base.method_12("");
        }
        base.imethod_13(geventArgs8_0);
    }

    protected override void vmethod_1(GEventArgs8 geventArgs8_0)
    {
        base.vmethod_1(geventArgs8_0);
        if (geventArgs8_0.method_0() != null && geventArgs8_0.method_0().method_7() != null && geventArgs8_0.method_0().method_7() is DateTime)
        {
            Rectangle rectangle = base.method_16();
            Rectangle rectangle_ = this.imethod_0();
            if (base.method_20())
            {
                rectangle_.Width -= rectangle.Width - 1;
            }
            if (geventArgs8_0.method_16())
            {
                this.method_24((DateTime)geventArgs8_0.method_0().method_7(), geventArgs8_0.Graphics, base.method_3(), rectangle_);
            }
            else
            {
                this.method_24((DateTime)geventArgs8_0.method_0().method_7(), geventArgs8_0.Graphics, base.method_13(), rectangle_);
            }
            if (geventArgs8_0.method_10() && geventArgs8_0.method_16())
            {
                Rectangle rectangle2 = this.imethod_0();
                if (base.method_20())
                {
                    rectangle2.Width -= rectangle.Width;
                }
                ControlPaint.DrawFocusRectangle(geventArgs8_0.Graphics, rectangle2);
            }
            return;
        }
    }

    protected void method_24(DateTime dateTime_0, Graphics graphics_0, Brush brush_0, Rectangle rectangle_1)
    {
        string text = base.method_11();
        if (text.Length == 0)
        {
            switch (this.method_22())
            {
            case DateTimePickerFormat.Long:
                text = GClass22.string_3;
                break;
            case DateTimePickerFormat.Short:
                text = GClass22.string_4;
                break;
            case DateTimePickerFormat.Time:
                text = GClass22.string_5;
                break;
            }
        }
        graphics_0.DrawString(dateTime_0.ToString(text), base.imethod_3(), brush_0, rectangle_1, base.method_4());
    }

    DateTimePickerFormat dateTimePickerFormat_0;
}
