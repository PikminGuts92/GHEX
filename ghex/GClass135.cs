using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

[ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip)]
public class GClass135 : ToolStripButton
{
    public GClass135()
    {
        this.method_0();
    }

    public GClass135(Image image_0) : base(image_0)
    {
        this.method_0();
    }

    public GClass135(string string_0) : base(string_0)
    {
        this.method_0();
    }

    public GClass135(string string_0, Image image_0) : base(string_0, image_0)
    {
        this.method_0();
    }

    public GClass135(string string_0, Image image_0, EventHandler eventHandler_0) : base(string_0, image_0, eventHandler_0)
    {
        this.method_0();
    }

    public GClass135(string string_0, Image image_0, EventHandler eventHandler_0, string string_1) : base(string_0, image_0, eventHandler_0, string_1)
    {
        this.method_0();
    }

    void method_0()
    {
        this.font_0 = this.Font;
    }

    public override Size GetPreferredSize(Size constrainingSize)
    {
        Size preferredSize = base.GetPreferredSize(constrainingSize);
        if (base.Owner != null && base.Owner.Orientation == Orientation.Vertical)
        {
            preferredSize.Width += 3;
            preferredSize.Height += 10;
        }
        return preferredSize;
    }

    protected override Padding DefaultMargin
    {
        get
        {
            return new Padding(0);
        }
    }

    public Padding method_1()
    {
        return base.Margin;
    }

    public void method_2(Padding padding_0)
    {
    }

    public Padding method_3()
    {
        return base.Padding;
    }

    public void method_4(Padding padding_0)
    {
    }

    public Color method_5()
    {
        return this.color_0;
    }

    public void method_6(Color color_2)
    {
        this.color_0 = color_2;
    }

    public Color method_7()
    {
        return this.color_1;
    }

    public void method_8(Color color_2)
    {
        this.color_1 = color_2;
    }

    public Font method_9()
    {
        if (this.font_0 != null)
        {
            return this.font_0;
        }
        return this.Font;
    }

    public void method_10(Font font_1)
    {
        this.font_0 = font_1;
    }

    public bool method_11()
    {
        return this.method_13();
    }

    public void method_12(bool bool_0)
    {
    }

    public bool method_13()
    {
        GClass134 gclass = base.Owner as GClass134;
        return gclass != null && this == gclass.method_16();
    }

    public void method_14(bool bool_0)
    {
        if (!bool_0)
        {
            return;
        }
        GClass134 gclass = base.Owner as GClass134;
        if (gclass == null)
        {
            return;
        }
        gclass.method_17(this);
    }

    protected override void OnOwnerChanged(EventArgs eventArgs_0)
    {
        if (base.Owner != null && !(base.Owner is GClass134))
        {
            throw new Exception("Cannot add TabStripButton to " + base.Owner.GetType().Name);
        }
        base.OnOwnerChanged(eventArgs_0);
    }

    Color color_0 = Control.DefaultForeColor;

    Color color_1 = Control.DefaultForeColor;

    Font font_0;
}
