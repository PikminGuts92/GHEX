using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public abstract class GClass45 : GInterface3, GInterface4, GInterface5
{
    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_0(GDelegate27 gdelegate27_3)
    {
        this.gdelegate27_0 = (GDelegate27)Delegate.Combine(this.gdelegate27_0, gdelegate27_3);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_1(GDelegate27 gdelegate27_3)
    {
        this.gdelegate27_0 = (GDelegate27)Delegate.Remove(this.gdelegate27_0, gdelegate27_3);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_2(GDelegate27 gdelegate27_3)
    {
        this.gdelegate27_1 = (GDelegate27)Delegate.Combine(this.gdelegate27_1, gdelegate27_3);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_3(GDelegate27 gdelegate27_3)
    {
        this.gdelegate27_1 = (GDelegate27)Delegate.Remove(this.gdelegate27_1, gdelegate27_3);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_4(GDelegate27 gdelegate27_3)
    {
        this.gdelegate27_2 = (GDelegate27)Delegate.Combine(this.gdelegate27_2, gdelegate27_3);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_5(GDelegate27 gdelegate27_3)
    {
        this.gdelegate27_2 = (GDelegate27)Delegate.Remove(this.gdelegate27_2, gdelegate27_3);
    }

    protected GClass45()
    {
        this.control_0 = null;
        this.gclass97_0 = null;
        this.gcontrol2_0 = null;
        this.gstruct9_0 = GStruct9.gstruct9_0;
        this.rectangle_0 = Rectangle.Empty;
        this.class62_0 = new Class62(this);
        this.class21_0 = new Class21(this);
    }

    public virtual bool imethod_0(GClass97 gclass97_1, GControl2 gcontrol2_1, GStruct9 gstruct9_1, Rectangle rectangle_1, bool bool_0)
    {
        this.gclass97_0 = gclass97_1;
        this.gcontrol2_0 = gcontrol2_1;
        this.gstruct9_0 = gstruct9_1;
        this.rectangle_0 = rectangle_1;
        if (!bool_0)
        {
            this.vmethod_1();
        }
        this.vmethod_0(rectangle_1);
        GEventArgs5 geventArgs = new GEventArgs5(gclass97_1, this, gcontrol2_1, gstruct9_1.method_1(), gstruct9_1.method_3(), rectangle_1);
        geventArgs.method_12(bool_0);
        this.vmethod_6(geventArgs);
        if (geventArgs.method_9())
        {
            this.vmethod_5();
            return false;
        }
        return true;
    }

    protected abstract void vmethod_0(Rectangle rectangle_1);

    protected abstract void vmethod_1();

    protected abstract void vmethod_2();

    protected virtual void vmethod_3()
    {
        this.control_0.Parent = this.gcontrol2_0;
        this.control_0.Visible = true;
    }

    protected virtual void vmethod_4()
    {
        this.control_0.Visible = false;
    }

    protected virtual void vmethod_5()
    {
        this.control_0.Visible = false;
        this.control_0.Parent = null;
        this.gcontrol2_0.Focus();
        this.gclass97_0 = null;
        this.gcontrol2_0 = null;
        this.gstruct9_0 = GStruct9.gstruct9_0;
        this.rectangle_0 = Rectangle.Empty;
    }

    public virtual void imethod_1()
    {
        this.vmethod_3();
        Application.AddMessageFilter(this.class21_0);
        Application.AddMessageFilter(this.class62_0);
    }

    public virtual void imethod_2()
    {
        Application.RemoveMessageFilter(this.class21_0);
        Application.RemoveMessageFilter(this.class62_0);
        GEventArgs5 geventArgs = new GEventArgs5(this.gclass97_0, this, this.gcontrol2_0, this.gstruct9_0.method_1(), this.gstruct9_0.method_3(), this.rectangle_0);
        this.gcontrol2_0.vmethod_29(geventArgs);
        this.vmethod_7(geventArgs);
        if (!geventArgs.method_9() && !geventArgs.method_11())
        {
            this.vmethod_2();
        }
        this.vmethod_5();
    }

    public virtual void imethod_3()
    {
        Application.RemoveMessageFilter(this.class21_0);
        Application.RemoveMessageFilter(this.class62_0);
        GEventArgs5 geventArgs5_ = new GEventArgs5(this.gclass97_0, this, this.gcontrol2_0, this.gstruct9_0.method_1(), this.gstruct9_0.method_3(), this.rectangle_0);
        this.gcontrol2_0.vmethod_30(geventArgs5_);
        this.vmethod_8(geventArgs5_);
        this.vmethod_5();
    }

    public virtual bool imethod_4(Control control_1, GEnum8 genum8_0, int int_0, int int_1)
    {
        if (genum8_0 == GEnum8.const_26 || genum8_0 == GEnum8.const_29 || genum8_0 == GEnum8.const_32 || genum8_0 == GEnum8.const_35 || genum8_0 == GEnum8.const_7 || genum8_0 == GEnum8.const_10 || genum8_0 == GEnum8.const_13 || genum8_0 == GEnum8.const_16)
        {
            Point position = Cursor.Position;
            if (control_1 != this.method_9() && control_1 != this.method_6())
            {
                this.method_9().method_122();
            }
        }
        return false;
    }

    public virtual bool imethod_0(Control control_1, GEnum8 genum8_0, int int_0, int int_1)
    {
        return false;
    }

    protected Control method_6()
    {
        return this.control_0;
    }

    protected void method_7(Control control_1)
    {
        this.control_0 = control_1;
    }

    public GClass97 method_8()
    {
        return this.gclass97_0;
    }

    public GControl2 method_9()
    {
        return this.gcontrol2_0;
    }

    public GStruct9 method_10()
    {
        return this.gstruct9_0;
    }

    public bool method_11()
    {
        return this.gclass97_0 != null;
    }

    protected virtual void vmethod_6(GEventArgs5 geventArgs5_0)
    {
        if (this.gdelegate27_0 != null)
        {
            this.gdelegate27_0(this, geventArgs5_0);
        }
    }

    protected virtual void vmethod_7(GEventArgs5 geventArgs5_0)
    {
        if (this.gdelegate27_1 != null)
        {
            this.gdelegate27_1(this, geventArgs5_0);
        }
    }

    protected virtual void vmethod_8(GEventArgs5 geventArgs5_0)
    {
        if (this.gdelegate27_2 != null)
        {
            this.gdelegate27_2(this, geventArgs5_0);
        }
    }

    GDelegate27 gdelegate27_0;

    GDelegate27 gdelegate27_1;

    GDelegate27 gdelegate27_2;

    Control control_0;

    internal GClass97 gclass97_0;

    GControl2 gcontrol2_0;

    GStruct9 gstruct9_0;

    Rectangle rectangle_0;

    Class62 class62_0;

    Class21 class21_0;
}
