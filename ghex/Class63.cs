using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

class Class63 : GClass106
{
    public Class63(GInterface37 ginterface37_1, GClass123 gclass123_1, GClass36 gclass36_1) : base(ginterface37_1, gclass123_1)
    {
        this.gclass36_0 = gclass36_1;
        this.font_1 = new Font(Class109.smethod_15()[0], 11f);
        this.font_2 = new Font(Class109.smethod_15()[0], 20f);
        this.font_3 = new Font("Tahoma", 5.7f);
        this.brush_1 = Brushes.Black;
        this.brush_2 = Brushes.Red;
        this.method_14();
        this.method_15();
    }

    public override void Dispose()
    {
        this.font_3.Dispose();
        this.font_2.Dispose();
        this.font_1.Dispose();
        this.brush_1.Dispose();
        this.brush_2.Dispose();
    }

    void method_14()
    {
        base.method_9(this.int_2 + 1 + this.int_4 + 1 + 2);
    }

    void method_15()
    {
        this.int_3 = base.method_10().Top;
        this.int_1 = this.int_3 + this.int_4 + 1;
        this.rectangle_1 = new Rectangle(base.method_10().Left, this.int_1, base.method_10().Width, this.int_2);
        this.rectangle_2 = new Rectangle(base.method_10().Left, this.int_3, base.method_10().Width, this.int_4);
    }

    public override bool vmethod_0()
    {
        return true;
    }

    public override void vmethod_1()
    {
        this.method_15();
    }

    public override void vmethod_2()
    {
        this.list_0.Clear();
        int num = base.method_0().imethod_1();
        int num2 = this.gclass36_0.method_22(base.method_0().imethod_0() + base.method_0().imethod_9(base.method_10().Width));
        foreach (GClass151 gclass in this.gclass36_0.method_23())
        {
            if (gclass.int_1 >= num && gclass.int_1 + base.method_0().imethod_11().method_9() <= num2)
            {
                Class63.Class103 @class = new Class63.Class103();
                @class.enum10_0 = Class63.Enum10.const_2;
                @class.double_0 = gclass.double_0;
                @class.int_0 = base.method_0().imethod_10(@class.double_0 - base.method_0().imethod_0());
                this.list_0.Add(@class);
            }
        }
        List<GClass114> list = this.gclass36_0.method_2(GEnum50.const_4, num, num2);
        if (list.Count == 0)
        {
            return;
        }
        foreach (GClass114 gclass2 in list)
        {
            Class63.Class103 class2 = null;
            if (gclass2 is GClass116)
            {
                class2 = new Class63.Class103();
                class2.enum10_0 = Class63.Enum10.const_0;
                class2.string_0 = "d=" + Class109.smethod_12((gclass2 as GClass116).method_10());
            }
            else if (gclass2 is GClass117)
            {
                class2 = new Class63.Class103();
                class2.enum10_0 = Class63.Enum10.const_1;
                class2.string_0 = "" + this.char_0[(gclass2 as GClass117).method_14() - 1] + this.char_1[(int)(gclass2 as GClass117).method_16()];
            }
            if (class2 != null)
            {
                class2.gclass114_0 = gclass2;
                class2.double_0 = gclass2.method_5();
                class2.int_0 = base.method_0().imethod_10(class2.double_0 - base.method_0().imethod_0());
                this.list_0.Add(class2);
            }
        }
    }

    void method_16()
    {
        base.method_0().Invalidate(this.rectangle_1);
    }

    void method_17()
    {
        base.method_0().Invalidate(this.rectangle_2);
    }

    public override Cursor vmethod_3(MouseEventArgs mouseEventArgs_0, KeyEventArgs keyEventArgs_0)
    {
        return Cursors.Default;
    }

    public override void vmethod_7(MouseEventArgs mouseEventArgs_0)
    {
        base.vmethod_7(mouseEventArgs_0);
    }

    public override void vmethod_12()
    {
        base.vmethod_12();
    }

    void method_18(Graphics graphics_0, Rectangle rectangle_3)
    {
        int num = this.int_3;
        int num2 = num + this.int_4;
        foreach (Class63.Class103 @class in this.list_0)
        {
            switch (@class.enum10_0)
            {
            case Class63.Enum10.const_0:
                graphics_0.DrawLine(this.pen_1, @class.int_0, num + 2, @class.int_0, num + 2 + 10);
                graphics_0.DrawString(@class.string_0, this.font_1, this.brush_1, (float)@class.int_0, (float)(num + 5));
                break;
            case Class63.Enum10.const_1:
                graphics_0.DrawLine(Pens.LightGray, @class.int_0, num + 2, @class.int_0, num + 2 + 10);
                graphics_0.DrawString(@class.string_0, this.font_2, this.brush_1, (float)@class.int_0, (float)(num2 - this.font_2.Height - 2));
                break;
            case Class63.Enum10.const_2:
                graphics_0.DrawLine(Pens.LightGray, @class.int_0, num + 13, @class.int_0, num2 - 2);
                break;
            }
        }
    }

    public override void vmethod_17(PaintEventArgs paintEventArgs_0)
    {
        if (paintEventArgs_0.ClipRectangle.IntersectsWith(this.rectangle_1))
        {
            base.method_13(paintEventArgs_0.Graphics, this.rectangle_1, paintEventArgs_0.ClipRectangle);
        }
        if (paintEventArgs_0.ClipRectangle.IntersectsWith(this.rectangle_2))
        {
            this.method_18(paintEventArgs_0.Graphics, paintEventArgs_0.ClipRectangle);
        }
    }

    GClass36 gclass36_0;

    int int_1;

    int int_2 = 10;

    Rectangle rectangle_1;

    int int_3;

    int int_4 = 50;

    Rectangle rectangle_2;

    Font font_1;

    Font font_2;

    Font font_3;

    Brush brush_1;

    Brush brush_2;

    char[] char_0 = new char[]
    {
        'Q',
        'W',
        'E',
        'R',
        'T',
        'Y',
        'U',
        'I',
        'O',
        'P',
        'Å'
    };

    char[] char_1 = new char[]
    {
        'q',
        'w',
        'r',
        'i',
        'å'
    };

    List<Class63.Class103> list_0 = new List<Class63.Class103>();

    enum Enum10
    {
        const_0,
        const_1,
        const_2,
        const_3
    }

    class Class103
    {
        public GClass114 gclass114_0;

        public Class63.Enum10 enum10_0;

        public int int_0;

        public double double_0;

        public string string_0;
    }
}
