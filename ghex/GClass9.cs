using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GClass9 : GClass2
{
    public GClass9()
    {
        this.bool_0 = true;
    }

    public Rectangle method_16()
    {
        Rectangle result = base.imethod_0();
        result.Inflate(-1, -1);
        return result;
    }

    public bool method_17()
    {
        return this.bool_0;
    }

    public void method_18(bool bool_1)
    {
        this.bool_0 = bool_1;
    }

    public override void imethod_13(GEventArgs8 geventArgs8_0)
    {
        if (geventArgs8_0.method_2().method_166().method_23().method_8(geventArgs8_0.method_6()) is GClass26)
        {
            this.bool_0 = ((GClass26)geventArgs8_0.method_2().method_166().method_23().method_8(geventArgs8_0.method_6())).method_45();
        }
        else
        {
            this.bool_0 = false;
        }
        base.imethod_13(geventArgs8_0);
    }

    protected override void vmethod_0(GEventArgs8 geventArgs8_0)
    {
        base.vmethod_0(geventArgs8_0);
        if (geventArgs8_0.method_0() == null)
        {
            return;
        }
        geventArgs8_0.Graphics.FillRectangle(SystemBrushes.Window, this.method_16());
        Rectangle rectangle_ = this.method_16();
        if (geventArgs8_0.method_16())
        {
            if (GClass69.smethod_29())
            {
                rectangle_.Inflate(-1, -1);
            }
            GClass69.smethod_12(geventArgs8_0.Graphics, rectangle_);
            return;
        }
        using (Bitmap bitmap = new Bitmap(rectangle_.Width, rectangle_.Height))
        {
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                GClass69.smethod_12(graphics, new Rectangle(0, 0, rectangle_.Width, rectangle_.Height));
            }
            ControlPaint.DrawImageDisabled(geventArgs8_0.Graphics, bitmap, rectangle_.X, rectangle_.Y, base.method_2().Color);
        }
    }

    protected override void vmethod_1(GEventArgs8 geventArgs8_0)
    {
        base.vmethod_1(geventArgs8_0);
        if (geventArgs8_0.method_0() == null)
        {
            return;
        }
        int num = 0;
        if (geventArgs8_0.method_0().method_7() != null && geventArgs8_0.method_0().method_7() is int)
        {
            num = (int)geventArgs8_0.method_0().method_7();
        }
        if (num < 0)
        {
            num = 0;
        }
        else if (num > 100)
        {
            num = 100;
        }
        Rectangle rectangle_ = this.method_16();
        rectangle_.Inflate(-2, -2);
        if (GClass69.smethod_29())
        {
            rectangle_.Inflate(-1, -1);
        }
        rectangle_.Width = (int)((double)num / 100.0 * (double)rectangle_.Width);
        if (geventArgs8_0.method_16())
        {
            GClass69.smethod_14(geventArgs8_0.Graphics, rectangle_);
        }
        else
        {
            using (Bitmap bitmap = new Bitmap(rectangle_.Width, rectangle_.Height))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    GClass69.smethod_14(graphics, new Rectangle(0, 0, rectangle_.Width, rectangle_.Height));
                }
                ControlPaint.DrawImageDisabled(geventArgs8_0.Graphics, bitmap, rectangle_.X, rectangle_.Y, base.method_2().Color);
            }
        }
        if (this.method_17())
        {
            base.imethod_10(GEnum39.const_1);
            base.imethod_12(GEnum38.const_1);
            Font font = new Font(base.imethod_3().FontFamily, base.imethod_3().SizeInPoints, FontStyle.Bold);
            if (geventArgs8_0.method_16())
            {
                geventArgs8_0.Graphics.DrawString("" + num + "%", font, SystemBrushes.ControlText, this.method_16(), base.method_4());
            }
            else
            {
                geventArgs8_0.Graphics.DrawString("" + num + "%", font, Brushes.White, this.method_16(), base.method_4());
            }
            if (!GClass69.smethod_29())
            {
                Region clip = geventArgs8_0.Graphics.Clip;
                Rectangle clip2 = this.method_16();
                clip2.Width = rectangle_.Width + 2;
                geventArgs8_0.Graphics.SetClip(clip2);
                if (geventArgs8_0.method_2().Enabled)
                {
                    geventArgs8_0.Graphics.DrawString("" + num + "%", font, SystemBrushes.HighlightText, this.method_16(), base.method_4());
                }
                else
                {
                    geventArgs8_0.Graphics.DrawString("" + num + "%", font, Brushes.White, this.method_16(), base.method_4());
                }
                geventArgs8_0.Graphics.SetClip(clip, CombineMode.Replace);
            }
        }
        if (geventArgs8_0.method_10() && geventArgs8_0.method_16())
        {
            ControlPaint.DrawFocusRectangle(geventArgs8_0.Graphics, this.method_16());
        }
    }

    bool bool_0;
}
