using System;
using System.Drawing;
using System.Windows.Forms;

public abstract class GClass1 : GInterface1, IDisposable
{
    protected GClass1()
    {
        this.rectangle_0 = Rectangle.Empty;
        this.font_0 = null;
        this.stringFormat_0 = new StringFormat();
        this.stringFormat_0.LineAlignment = StringAlignment.Center;
        this.stringFormat_0.Alignment = StringAlignment.Near;
        this.stringFormat_0.FormatFlags = StringFormatFlags.NoWrap;
        this.stringFormat_0.Trimming = StringTrimming.EllipsisCharacter;
        this.solidBrush_0 = new SolidBrush(Color.Transparent);
        this.solidBrush_1 = new SolidBrush(Color.Black);
    }

    public virtual void Dispose()
    {
        if (this.solidBrush_0 != null)
        {
            this.solidBrush_0.Dispose();
            this.solidBrush_0 = null;
        }
        if (this.solidBrush_1 != null)
        {
            this.solidBrush_1.Dispose();
            this.solidBrush_1 = null;
        }
    }

    protected void method_0(Color color_0)
    {
        if (this.method_2().Color != color_0)
        {
            this.method_2().Color = color_0;
        }
    }

    protected void method_1(Color color_0)
    {
        if (this.method_3().Color != color_0)
        {
            this.method_3().Color = color_0;
        }
    }

    public abstract Rectangle imethod_0();

    public Rectangle imethod_1()
    {
        return this.rectangle_0;
    }

    public void imethod_2(Rectangle rectangle_1)
    {
        this.rectangle_0 = rectangle_1;
    }

    public Font imethod_3()
    {
        return this.font_0;
    }

    public void imethod_4(Font font_1)
    {
        if (font_1 == null)
        {
            font_1 = Control.DefaultFont;
        }
        if (this.font_0 != font_1)
        {
            this.font_0 = font_1;
        }
    }

    protected SolidBrush method_2()
    {
        return this.solidBrush_0;
    }

    protected SolidBrush method_3()
    {
        return this.solidBrush_1;
    }

    public Color imethod_5()
    {
        return this.method_3().Color;
    }

    public void imethod_6(Color color_0)
    {
        this.method_1(color_0);
    }

    public Color imethod_7()
    {
        return this.method_2().Color;
    }

    public void imethod_8(Color color_0)
    {
        this.method_0(color_0);
    }

    protected StringFormat method_4()
    {
        return this.stringFormat_0;
    }

    protected void method_5(StringFormat stringFormat_1)
    {
        this.stringFormat_0 = stringFormat_1;
    }

    public StringTrimming method_6()
    {
        return this.stringFormat_0.Trimming;
    }

    public void method_7(StringTrimming stringTrimming_0)
    {
        this.stringFormat_0.Trimming = stringTrimming_0;
    }

    public GEnum39 imethod_9()
    {
        switch (this.stringFormat_0.Alignment)
        {
        case StringAlignment.Near:
            return GEnum39.const_0;
        case StringAlignment.Center:
            return GEnum39.const_1;
        case StringAlignment.Far:
            return GEnum39.const_2;
        default:
            return GEnum39.const_0;
        }
    }

    public void imethod_10(GEnum39 genum39_0)
    {
        switch (genum39_0)
        {
        case GEnum39.const_0:
            this.stringFormat_0.Alignment = StringAlignment.Near;
            return;
        case GEnum39.const_1:
            this.stringFormat_0.Alignment = StringAlignment.Center;
            return;
        case GEnum39.const_2:
            this.stringFormat_0.Alignment = StringAlignment.Far;
            return;
        default:
            return;
        }
    }

    public GEnum38 imethod_11()
    {
        switch (this.stringFormat_0.LineAlignment)
        {
        case StringAlignment.Near:
            return GEnum38.const_0;
        case StringAlignment.Center:
            return GEnum38.const_1;
        case StringAlignment.Far:
            return GEnum38.const_2;
        default:
            return GEnum38.const_1;
        }
    }

    public void imethod_12(GEnum38 genum38_0)
    {
        switch (genum38_0)
        {
        case GEnum38.const_0:
            this.stringFormat_0.LineAlignment = StringAlignment.Near;
            return;
        case GEnum38.const_1:
            this.stringFormat_0.LineAlignment = StringAlignment.Center;
            return;
        case GEnum38.const_2:
            this.stringFormat_0.LineAlignment = StringAlignment.Far;
            return;
        default:
            return;
        }
    }

    protected bool method_8()
    {
        return GClass69.smethod_29();
    }

    StringFormat stringFormat_0;

    SolidBrush solidBrush_0;

    SolidBrush solidBrush_1;

    Rectangle rectangle_0;

    Font font_0;

    protected static int int_0 = 1;
}
