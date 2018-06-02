using System;
using System.Drawing;
using System.Windows.Forms;

public class GClass8 : GClass2
{
    public GClass8()
    {
        this.bool_0 = true;
    }

    protected Rectangle method_16(Image image_0, GEnum34 genum34_0, GEnum38 genum38_0, GEnum39 genum39_0)
    {
        if (this.method_17())
        {
            genum34_0 = GEnum34.const_2;
        }
        Rectangle result = this.imethod_0();
        if (genum34_0 == GEnum34.const_0)
        {
            if (image_0.Width < result.Width)
            {
                result.Width = image_0.Width;
            }
            if (image_0.Height < result.Height)
            {
                result.Height = image_0.Height;
            }
        }
        else if (genum34_0 == GEnum34.const_2)
        {
            if (image_0.Width < result.Width && image_0.Height < result.Height)
            {
                result.Width = image_0.Width;
                result.Height = image_0.Height;
            }
            else
            {
                double val = (double)result.Width / (double)image_0.Width;
                double val2 = (double)result.Height / (double)image_0.Height;
                double num = Math.Min(val, val2);
                result.Width = (int)((double)image_0.Width * num);
                result.Height = (int)((double)image_0.Height * num);
            }
        }
        if (genum38_0 == GEnum38.const_1)
        {
            result.Y += (this.imethod_0().Height - result.Height) / 2;
        }
        else if (genum38_0 == GEnum38.const_2)
        {
            result.Y = this.imethod_0().Bottom - result.Height;
        }
        if (!this.method_17())
        {
            if (genum39_0 == GEnum39.const_1)
            {
                result.X += (this.imethod_0().Width - result.Width) / 2;
            }
            else if (genum39_0 == GEnum39.const_2)
            {
                result.X = this.imethod_0().Width - result.Width;
            }
        }
        return result;
    }

    public bool method_17()
    {
        return this.bool_0;
    }

    public override void imethod_13(GEventArgs8 geventArgs8_0)
    {
        if (geventArgs8_0.method_2().method_166().method_23().method_8(geventArgs8_0.method_6()) is GClass27)
        {
            this.bool_0 = ((GClass27)geventArgs8_0.method_2().method_166().method_23().method_8(geventArgs8_0.method_6())).method_45();
        }
        else
        {
            this.bool_0 = true;
        }
        base.imethod_13(geventArgs8_0);
    }

    protected override void vmethod_1(GEventArgs8 geventArgs8_0)
    {
        base.vmethod_1(geventArgs8_0);
        if (geventArgs8_0.method_0() != null && geventArgs8_0.method_0().method_33() != null)
        {
            Rectangle rectangle_ = this.method_16(geventArgs8_0.method_0().method_33(), geventArgs8_0.method_0().method_35(), base.imethod_11(), base.imethod_9());
            bool bool_ = this.method_17() || geventArgs8_0.method_0().method_35() != GEnum34.const_0;
            this.method_18(geventArgs8_0.Graphics, geventArgs8_0.method_0().method_33(), rectangle_, bool_, geventArgs8_0.method_2().Enabled);
            if (this.method_17() && geventArgs8_0.method_0().method_5() != null && geventArgs8_0.method_0().method_5().Length != 0)
            {
                Rectangle r = this.imethod_0();
                r.X += rectangle_.Width;
                r.Width -= rectangle_.Width;
                if (r.Width > 0)
                {
                    if (geventArgs8_0.method_16())
                    {
                        geventArgs8_0.Graphics.DrawString(geventArgs8_0.method_0().method_5(), base.imethod_3(), base.method_3(), r, base.method_4());
                    }
                    else
                    {
                        geventArgs8_0.Graphics.DrawString(geventArgs8_0.method_0().method_5(), base.imethod_3(), base.method_13(), r, base.method_4());
                    }
                }
            }
            if (geventArgs8_0.method_10() && geventArgs8_0.method_16())
            {
                ControlPaint.DrawFocusRectangle(geventArgs8_0.Graphics, this.imethod_0());
            }
            return;
        }
    }

    protected void method_18(Graphics graphics_0, Image image_0, Rectangle rectangle_1, bool bool_1, bool bool_2)
    {
        if (bool_1)
        {
            if (bool_2)
            {
                graphics_0.DrawImage(image_0, rectangle_1);
                return;
            }
            using (Image image = new Bitmap(image_0, rectangle_1.Width, rectangle_1.Height))
            {
                ControlPaint.DrawImageDisabled(graphics_0, image, rectangle_1.X, rectangle_1.Y, base.method_2().Color);
                return;
            }
        }
        if (bool_2)
        {
            graphics_0.DrawImageUnscaled(image_0, rectangle_1);
            return;
        }
        ControlPaint.DrawImageDisabled(graphics_0, image_0, rectangle_1.X, rectangle_1.Y, base.method_2().Color);
    }

    bool bool_0;
}
