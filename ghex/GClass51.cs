using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

public class GClass51 : GClass45, GInterface6
{
    public GClass51()
    {
        base.method_7(new TextBox
        {
            AutoSize = false,
            BorderStyle = BorderStyle.None
        });
        this.decimal_0 = 0m;
        this.decimal_1 = 1m;
        this.decimal_3 = 0m;
        this.decimal_2 = 100m;
        this.string_0 = "G";
        this.int_3 = 0;
        this.bool_0 = true;
        this.bool_2 = false;
        this.bool_1 = false;
        this.rectangle_1 = Rectangle.Empty;
        this.int_5 = 0;
        this.int_4 = 500;
    }

    public override bool imethod_0(GClass97 gclass97_1, GControl2 gcontrol2_1, GStruct9 gstruct9_1, Rectangle rectangle_2, bool bool_3)
    {
        if (!(gcontrol2_1.method_166().method_23().method_8(gstruct9_1.method_3()) is GClass18))
        {
            throw new InvalidOperationException("Cannot edit Cell as NumberCellEditor can only be used with a NumberColumn");
        }
        if (!(gcontrol2_1.method_166().method_17(gstruct9_1.method_3()) is GClass12))
        {
            throw new InvalidOperationException("Cannot edit Cell as NumberCellEditor can only be used with a NumberColumn that uses a NumberCellRenderer");
        }
        this.method_27(((GClass18)gcontrol2_1.method_166().method_23().method_8(gstruct9_1.method_3())).method_48());
        this.method_25(((GClass18)gcontrol2_1.method_166().method_23().method_8(gstruct9_1.method_3())).method_45());
        this.method_23(((GClass18)gcontrol2_1.method_166().method_23().method_8(gstruct9_1.method_3())).method_51());
        return base.imethod_0(gclass97_1, gcontrol2_1, gstruct9_1, rectangle_2, bool_3);
    }

    protected override void vmethod_1()
    {
        this.method_21(this.method_26());
        this.method_21(Convert.ToDecimal(base.method_8().method_7()));
    }

    protected override void vmethod_2()
    {
        base.method_8().method_8(this.method_20());
    }

    public override void imethod_1()
    {
        this.method_19().MouseWheel += this.vmethod_10;
        this.method_19().KeyDown += this.vmethod_11;
        this.method_19().KeyPress += this.vmethod_12;
        this.method_19().LostFocus += this.vmethod_13;
        base.imethod_1();
        this.method_19().Focus();
    }

    public override void imethod_2()
    {
        this.method_19().MouseWheel -= this.vmethod_10;
        this.method_19().KeyDown -= this.vmethod_11;
        this.method_19().KeyPress -= this.vmethod_12;
        this.method_19().LostFocus -= this.vmethod_13;
        base.imethod_2();
    }

    public override void imethod_3()
    {
        this.method_19().MouseWheel -= this.vmethod_10;
        this.method_19().KeyDown -= this.vmethod_11;
        this.method_19().KeyPress -= this.vmethod_12;
        this.method_19().LostFocus -= this.vmethod_13;
        base.imethod_3();
    }

    protected override void vmethod_0(Rectangle rectangle_2)
    {
        GInterface2 ginterface = base.method_9().method_166().method_17(base.method_10().method_3());
        int num = ((GClass12)ginterface).method_21();
        this.method_19().Size = new Size(rectangle_2.Width - 1 - num, rectangle_2.Height - 1);
        this.method_19().Location = rectangle_2.Location;
        this.rectangle_1 = new Rectangle(this.method_19().Left + 1, this.method_19().Top, num, this.method_19().Height);
        if (((GClass18)base.method_9().method_166().method_23().method_8(base.method_10().method_3())).method_56() == LeftRightAlignment.Left)
        {
            this.method_19().Location = new Point(rectangle_2.Left + num, rectangle_2.Top);
            this.rectangle_1.Location = new Point(rectangle_2.Left, rectangle_2.Top);
        }
    }

    protected void method_12()
    {
        if (this.method_34())
        {
            this.method_15();
        }
        decimal num = this.decimal_0;
        if (num > 79228162514264337593543950335m - this.decimal_1)
        {
            num = decimal.MaxValue;
        }
        else
        {
            num += this.decimal_1;
            if (num > this.decimal_2)
            {
                num = this.decimal_2;
            }
        }
        this.method_21(num);
    }

    protected void method_13()
    {
        if (this.method_34())
        {
            this.method_15();
        }
        decimal num = this.decimal_0;
        if (num < -79228162514264337593543950335m + this.decimal_1)
        {
            num = decimal.MinValue;
        }
        else
        {
            num -= this.decimal_1;
            if (num < this.decimal_3)
            {
                num = this.decimal_3;
            }
        }
        this.method_21(num);
    }

    protected void method_14()
    {
        if (this.method_34())
        {
            this.method_15();
        }
        this.method_31(true);
        base.method_6().Text = this.decimal_0.ToString(this.method_28());
    }

    protected virtual void vmethod_9()
    {
        this.method_15();
        this.method_14();
    }

    protected void method_15()
    {
        try
        {
            this.method_21(this.method_16(decimal.Parse(base.method_6().Text)));
        }
        catch (Exception)
        {
        }
        finally
        {
            this.method_35(false);
        }
    }

    decimal method_16(decimal decimal_4)
    {
        if (decimal_4 < this.decimal_3)
        {
            decimal_4 = this.decimal_3;
        }
        if (decimal_4 > this.decimal_2)
        {
            decimal_4 = this.decimal_2;
        }
        return decimal_4;
    }

    protected void method_17()
    {
        if (this.timer_0 == null)
        {
            this.timer_0 = new Timer();
            this.timer_0.Tick += this.timer_0_Tick;
        }
        this.int_4 = 500;
        this.timer_0.Interval = this.int_4;
        this.timer_0.Start();
    }

    protected void method_18()
    {
        if (this.timer_0 != null)
        {
            this.timer_0.Stop();
            this.timer_0.Dispose();
            this.timer_0 = null;
        }
    }

    public TextBox method_19()
    {
        return base.method_6() as TextBox;
    }

    protected decimal method_20()
    {
        if (this.method_34())
        {
            this.vmethod_9();
        }
        return this.decimal_0;
    }

    protected void method_21(decimal decimal_4)
    {
        if (decimal_4 != this.decimal_0)
        {
            if (decimal_4 < this.decimal_3)
            {
                decimal_4 = this.decimal_2;
            }
            if (decimal_4 > this.decimal_2)
            {
                decimal_4 = this.decimal_2;
            }
            this.decimal_0 = decimal_4;
            this.method_14();
        }
    }

    protected decimal method_22()
    {
        return this.decimal_1;
    }

    protected void method_23(decimal decimal_4)
    {
        if (decimal_4 < 0m)
        {
            throw new ArgumentException("increment must be greater than zero");
        }
        this.decimal_1 = decimal_4;
    }

    protected decimal method_24()
    {
        return this.decimal_2;
    }

    protected void method_25(decimal decimal_4)
    {
        this.decimal_2 = decimal_4;
        if (this.decimal_3 > this.decimal_2)
        {
            this.decimal_3 = this.decimal_2;
        }
    }

    protected decimal method_26()
    {
        return this.decimal_3;
    }

    protected void method_27(decimal decimal_4)
    {
        this.decimal_3 = decimal_4;
        if (this.decimal_3 > this.decimal_2)
        {
            this.decimal_2 = decimal_4;
        }
    }

    protected string method_28()
    {
        return this.string_0;
    }

    protected void method_29(string string_1)
    {
        if (string_1 == null)
        {
            throw new ArgumentNullException("value");
        }
        this.string_0 = string_1;
        this.method_14();
    }

    protected bool method_30()
    {
        return this.bool_1;
    }

    protected void method_31(bool bool_3)
    {
        this.bool_1 = bool_3;
    }

    public bool method_32()
    {
        return this.bool_0;
    }

    public void method_33(bool bool_3)
    {
        this.bool_0 = bool_3;
    }

    protected bool method_34()
    {
        return this.bool_2;
    }

    protected void method_35(bool bool_3)
    {
        this.bool_2 = bool_3;
    }

    protected internal virtual void vmethod_10(object sender, MouseEventArgs e)
    {
        bool flag = true;
        this.int_3 += e.Delta;
        if (Math.Abs(this.int_3) >= 120)
        {
            if (this.int_3 < 0)
            {
                flag = false;
            }
            if (flag)
            {
                this.method_12();
            }
            else
            {
                this.method_13();
            }
            this.int_3 = 0;
        }
    }

    protected virtual void vmethod_11(object sender, KeyEventArgs e)
    {
        if (this.bool_0)
        {
            if (e.KeyData == Keys.Up)
            {
                this.method_12();
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Down)
            {
                this.method_13();
                e.Handled = true;
            }
        }
        if (e.KeyCode == Keys.Return)
        {
            this.vmethod_9();
        }
    }

    protected virtual void vmethod_12(object sender, KeyPressEventArgs e)
    {
        char char_ = GClass68.char_13;
        char char_2 = GClass68.char_27;
        char char_3 = GClass68.char_9;
        NumberFormatInfo numberFormat = CultureInfo.CurrentCulture.NumberFormat;
        string numberDecimalSeparator = numberFormat.NumberDecimalSeparator;
        string numberGroupSeparator = numberFormat.NumberGroupSeparator;
        string negativeSign = numberFormat.NegativeSign;
        string text = e.KeyChar.ToString();
        if (!char.IsDigit(e.KeyChar) && !text.Equals(numberDecimalSeparator) && !text.Equals(numberGroupSeparator) && !text.Equals(negativeSign) && e.KeyChar != char_3 && (Control.ModifierKeys & (Keys.Control | Keys.Alt)) == Keys.None)
        {
            e.Handled = true;
            if (e.KeyChar == char_)
            {
                if (base.method_9() != null)
                {
                    base.method_9().method_122();
                    return;
                }
            }
            else if (e.KeyChar == char_2)
            {
                if (base.method_9() != null)
                {
                    base.method_9().method_123();
                    return;
                }
            }
            else
            {
                Class96.MessageBeep(0);
            }
        }
    }

    protected virtual void vmethod_13(object sender, EventArgs e)
    {
        if (this.method_34())
        {
            this.vmethod_9();
        }
        if (base.method_9() != null)
        {
            base.method_9().method_122();
        }
    }

    public void imethod_0(object sender, GEventArgs10 e)
    {
        this.method_15();
        if (e.Y < this.rectangle_1.Top + this.rectangle_1.Height / 2)
        {
            this.int_5 = GClass51.int_1;
            this.method_12();
        }
        else
        {
            this.int_5 = GClass51.int_2;
            this.method_13();
        }
        this.method_17();
    }

    public void imethod_1(object sender, GEventArgs10 e)
    {
        this.method_18();
        this.int_5 = 0;
    }

    void timer_0_Tick(object sender, EventArgs e)
    {
        if (this.int_5 == 0)
        {
            this.method_18();
            return;
        }
        if (this.int_5 == GClass51.int_1)
        {
            this.method_12();
        }
        else
        {
            this.method_13();
        }
        this.int_4 *= 7;
        this.int_4 /= 10;
        if (this.int_4 < 1)
        {
            this.int_4 = 1;
        }
        this.timer_0.Interval = this.int_4;
    }

    const int int_0 = 500;

    protected static readonly int int_1 = 1;

    protected static readonly int int_2 = 2;

    decimal decimal_0;

    decimal decimal_1;

    decimal decimal_2;

    decimal decimal_3;

    string string_0;

    int int_3;

    bool bool_0;

    bool bool_1;

    int int_4;

    bool bool_2;

    Rectangle rectangle_1;

    int int_5;

    Timer timer_0;
}
