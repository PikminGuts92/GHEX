using System;
using System.Drawing;
using System.Windows.Forms;

public abstract class GClass2 : GClass1, GInterface2
{
    protected GClass2()
    {
        this.string_0 = "";
        this.solidBrush_2 = new SolidBrush(SystemColors.GrayText);
        this.gstruct13_0 = GStruct13.gstruct13_0;
    }

    public override void Dispose()
    {
        base.Dispose();
        if (this.solidBrush_2 != null)
        {
            this.solidBrush_2.Dispose();
            this.solidBrush_2 = null;
        }
    }

    protected object method_9(GClass97 gclass97_0)
    {
        return gclass97_0.method_45();
    }

    protected void method_10(GClass97 gclass97_0, object object_0)
    {
        gclass97_0.method_46(object_0);
    }

    public override Rectangle imethod_0()
    {
        Rectangle result = new Rectangle(base.imethod_1().Location, base.imethod_1().Size);
        result.Width -= GClass1.int_0;
        result.Height -= GClass1.int_0;
        result.X += this.method_14().method_0() + 1;
        result.Y += this.method_14().method_4();
        result.Width -= this.method_14().method_0() + this.method_14().method_2() + 1;
        result.Height -= this.method_14().method_4() + this.method_14().method_6();
        return result;
    }

    protected string method_11()
    {
        return this.string_0;
    }

    protected void method_12(string string_1)
    {
        this.string_0 = string_1;
    }

    protected Brush method_13()
    {
        return this.solidBrush_2;
    }

    protected GStruct13 method_14()
    {
        return this.gstruct13_0;
    }

    protected void method_15(GStruct13 gstruct13_1)
    {
        this.gstruct13_0 = gstruct13_1;
    }

    public virtual void imethod_14(GEventArgs3 geventArgs3_0)
    {
        base.imethod_2(geventArgs3_0.method_7());
        if (geventArgs3_0.method_0() == null)
        {
            this.method_15(GStruct13.gstruct13_0);
        }
        else
        {
            this.method_15(geventArgs3_0.method_0().method_24());
        }
        geventArgs3_0.method_6().Invalidate(geventArgs3_0.method_7());
    }

    public virtual void imethod_15(GEventArgs3 geventArgs3_0)
    {
        base.imethod_2(geventArgs3_0.method_7());
        if (geventArgs3_0.method_0() == null)
        {
            this.method_15(GStruct13.gstruct13_0);
        }
        else
        {
            this.method_15(geventArgs3_0.method_0().method_24());
        }
        geventArgs3_0.method_6().Invalidate(geventArgs3_0.method_7());
    }

    public virtual void imethod_16(GEventArgs17 geventArgs17_0)
    {
    }

    public virtual void imethod_17(GEventArgs17 geventArgs17_0)
    {
    }

    public virtual void imethod_18(GEventArgs10 geventArgs10_0)
    {
        base.imethod_2(geventArgs10_0.method_4());
        if (geventArgs10_0.method_0() == null)
        {
            this.method_15(GStruct13.gstruct13_0);
        }
        else
        {
            this.method_15(geventArgs10_0.method_0().method_24());
        }
        bool active;
        if (active = geventArgs10_0.method_1().method_249().Active)
        {
            geventArgs10_0.method_1().method_249().Active = false;
        }
        geventArgs10_0.method_1().method_138();
        geventArgs10_0.method_1().method_249().SetToolTip(geventArgs10_0.method_1(), geventArgs10_0.method_0().method_43());
        if (active)
        {
            geventArgs10_0.method_1().method_249().Active = true;
        }
    }

    public virtual void imethod_19(GEventArgs10 geventArgs10_0)
    {
        base.imethod_2(geventArgs10_0.method_4());
        if (geventArgs10_0.method_0() == null)
        {
            this.method_15(GStruct13.gstruct13_0);
            return;
        }
        this.method_15(geventArgs10_0.method_0().method_24());
    }

    public virtual void imethod_20(GEventArgs10 geventArgs10_0)
    {
        base.imethod_2(geventArgs10_0.method_4());
        if (geventArgs10_0.method_0() == null)
        {
            this.method_15(GStruct13.gstruct13_0);
            return;
        }
        this.method_15(geventArgs10_0.method_0().method_24());
    }

    public virtual void imethod_21(GEventArgs10 geventArgs10_0)
    {
        if (!geventArgs10_0.method_1().Focused && (!geventArgs10_0.method_1().method_175() || !GStruct9.smethod_0(geventArgs10_0.method_1().method_176(), geventArgs10_0.method_5()) || !(geventArgs10_0.method_1().method_177() is GInterface6)))
        {
            geventArgs10_0.method_1().Focus();
        }
        base.imethod_2(geventArgs10_0.method_4());
        if (geventArgs10_0.method_0() == null)
        {
            this.method_15(GStruct13.gstruct13_0);
            return;
        }
        this.method_15(geventArgs10_0.method_0().method_24());
    }

    public virtual void imethod_22(GEventArgs10 geventArgs10_0)
    {
        base.imethod_2(geventArgs10_0.method_4());
        if (geventArgs10_0.method_0() == null)
        {
            this.method_15(GStruct13.gstruct13_0);
            return;
        }
        this.method_15(geventArgs10_0.method_0().method_24());
    }

    public virtual void imethod_23(GEventArgs10 geventArgs10_0)
    {
        base.imethod_2(geventArgs10_0.method_4());
        if (geventArgs10_0.method_0() == null)
        {
            this.method_15(GStruct13.gstruct13_0);
        }
        else
        {
            this.method_15(geventArgs10_0.method_0().method_24());
        }
        if (geventArgs10_0.method_1().method_178() == GEnum7.const_1 && geventArgs10_0.method_1().method_125(geventArgs10_0.method_5()))
        {
            geventArgs10_0.method_1().method_121(geventArgs10_0.method_5());
        }
    }

    public virtual void imethod_24(GEventArgs10 geventArgs10_0)
    {
        base.imethod_2(geventArgs10_0.method_4());
        if (geventArgs10_0.method_0() == null)
        {
            this.method_15(GStruct13.gstruct13_0);
        }
        else
        {
            this.method_15(geventArgs10_0.method_0().method_24());
        }
        if (geventArgs10_0.method_1().method_178() == GEnum7.const_0 && geventArgs10_0.method_1().method_125(geventArgs10_0.method_5()))
        {
            geventArgs10_0.method_1().method_121(geventArgs10_0.method_5());
        }
    }

    public virtual void imethod_13(GEventArgs8 geventArgs8_0)
    {
        base.imethod_2(geventArgs8_0.method_18());
        if (geventArgs8_0.method_0() != null)
        {
            this.method_15(geventArgs8_0.method_0().method_24());
            base.imethod_10(geventArgs8_0.method_2().method_166().method_23().method_8(geventArgs8_0.method_6()).vmethod_4());
            base.imethod_12(geventArgs8_0.method_2().method_239().method_12().method_9(geventArgs8_0.method_4()).method_20());
            this.method_12(geventArgs8_0.method_2().method_166().method_23().method_8(geventArgs8_0.method_6()).method_7());
            base.imethod_4(geventArgs8_0.method_0().method_21());
        }
        else
        {
            this.method_15(GStruct13.gstruct13_0);
            base.imethod_10(GEnum39.const_0);
            base.imethod_12(GEnum38.const_1);
            this.method_12("");
            base.imethod_4(null);
        }
        if (base.imethod_3() == null)
        {
            base.imethod_4(Control.DefaultFont);
        }
        this.vmethod_0(geventArgs8_0);
        this.vmethod_1(geventArgs8_0);
    }

    protected virtual void vmethod_0(GEventArgs8 geventArgs8_0)
    {
        if (geventArgs8_0.method_8() && (!geventArgs8_0.method_2().method_223() || (geventArgs8_0.method_2().method_223() && (geventArgs8_0.method_2().Focused || geventArgs8_0.method_2().method_175()))))
        {
            if (!geventArgs8_0.method_2().Focused && !geventArgs8_0.method_2().method_175())
            {
                base.imethod_8(geventArgs8_0.method_2().method_231());
                base.imethod_6(geventArgs8_0.method_2().method_234());
            }
            else
            {
                base.imethod_6(geventArgs8_0.method_2().method_228());
                base.imethod_8(geventArgs8_0.method_2().method_225());
            }
            if (base.imethod_7().A != 0)
            {
                geventArgs8_0.Graphics.FillRectangle(base.method_2(), geventArgs8_0.method_18());
                return;
            }
        }
        else
        {
            base.imethod_6((geventArgs8_0.method_0() != null) ? geventArgs8_0.method_0().method_18() : Color.Black);
            if (geventArgs8_0.method_12() && (!geventArgs8_0.method_12() || geventArgs8_0.method_2().method_172().A >= 255))
            {
                base.imethod_8(geventArgs8_0.method_2().method_172());
                geventArgs8_0.Graphics.FillRectangle(base.method_2(), geventArgs8_0.method_18());
            }
            else
            {
                if (geventArgs8_0.method_0() != null)
                {
                    if (geventArgs8_0.method_0().method_15().A < 255)
                    {
                        if (geventArgs8_0.method_4() % 2 == 1 && geventArgs8_0.method_2().method_209().A != 0)
                        {
                            base.imethod_8(geventArgs8_0.method_2().method_209());
                            geventArgs8_0.Graphics.FillRectangle(base.method_2(), geventArgs8_0.method_18());
                        }
                        base.imethod_8(geventArgs8_0.method_0().method_15());
                        if (geventArgs8_0.method_0().method_15().A != 0)
                        {
                            geventArgs8_0.Graphics.FillRectangle(base.method_2(), geventArgs8_0.method_18());
                        }
                    }
                    else
                    {
                        base.imethod_8(geventArgs8_0.method_0().method_15());
                        if (geventArgs8_0.method_0().method_15().A != 0)
                        {
                            geventArgs8_0.Graphics.FillRectangle(base.method_2(), geventArgs8_0.method_18());
                        }
                    }
                }
                else if (geventArgs8_0.method_4() % 2 == 1 && geventArgs8_0.method_2().method_209().A != 0)
                {
                    base.imethod_8(geventArgs8_0.method_2().method_209());
                    geventArgs8_0.Graphics.FillRectangle(base.method_2(), geventArgs8_0.method_18());
                }
                if (geventArgs8_0.method_12())
                {
                    base.imethod_8(geventArgs8_0.method_2().method_172());
                    if (geventArgs8_0.method_2().method_172().A != 0)
                    {
                        geventArgs8_0.Graphics.FillRectangle(base.method_2(), geventArgs8_0.method_18());
                        return;
                    }
                }
            }
        }
    }

    protected virtual void vmethod_1(GEventArgs8 geventArgs8_0)
    {
    }

    protected virtual void vmethod_2(GEventArgs8 geventArgs8_0, Pen pen_0)
    {
        geventArgs8_0.Graphics.DrawLine(pen_0, geventArgs8_0.method_18().Left, geventArgs8_0.method_18().Bottom, geventArgs8_0.method_18().Right, geventArgs8_0.method_18().Bottom);
        geventArgs8_0.Graphics.DrawLine(pen_0, geventArgs8_0.method_18().Right, geventArgs8_0.method_18().Top, geventArgs8_0.method_18().Right, geventArgs8_0.method_18().Bottom);
    }

    string string_0;

    SolidBrush solidBrush_2;

    GStruct13 gstruct13_0;
}
