using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class ZoomControl : UserControl
{
    public ZoomControl()
    {
        this.InitializeComponent();
        base.SetStyle(ControlStyles.Selectable, false);
        Assembly executingAssembly = Assembly.GetExecutingAssembly();
        this.icon_0 = new Icon(executingAssembly.GetManifestResourceStream("gh.ZoomMinus.ico"));
        this.icon_1 = new Icon(executingAssembly.GetManifestResourceStream("gh.ZoomPlus.ico"));
        this.icon_2 = new Icon(executingAssembly.GetManifestResourceStream("gh.ZoomMin.ico"));
        this.icon_3 = new Icon(executingAssembly.GetManifestResourceStream("gh.ZoomNorm.ico"));
        this.icon_4 = new Icon(executingAssembly.GetManifestResourceStream("gh.ZoomMax.ico"));
        this.bitmap_0 = this.icon_0.ToBitmap();
        this.bitmap_1 = this.icon_1.ToBitmap();
        this.bitmap_2 = this.icon_2.ToBitmap();
        this.bitmap_3 = this.icon_3.ToBitmap();
        this.bitmap_4 = this.icon_4.ToBitmap();
        this.method_0(0);
    }

    void method_0(int int_2)
    {
        this.int_1 = int_2;
        this.bool_0 = (this.int_1 != 100);
        this.bool_1 = (this.int_1 != 0);
        this.bool_2 = (this.int_1 != this.int_0);
        this.bool_3 = (this.int_1 > 0);
        this.bool_4 = (this.int_1 < 100);
        base.Invalidate();
        if (this.eventHandler_0 != null)
        {
            this.eventHandler_0(this, EventArgs.Empty);
        }
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_1(EventHandler eventHandler_1)
    {
        this.eventHandler_0 = (EventHandler)Delegate.Combine(this.eventHandler_0, eventHandler_1);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_2(EventHandler eventHandler_1)
    {
        this.eventHandler_0 = (EventHandler)Delegate.Remove(this.eventHandler_0, eventHandler_1);
    }

    public float method_3()
    {
        return (float)this.int_1 / 100f;
    }

    public int method_4()
    {
        return 5;
    }

    protected override void OnMouseMove(MouseEventArgs mouseEventArgs_0)
    {
        base.OnMouseMove(mouseEventArgs_0);
        this.point_0 = mouseEventArgs_0.Location;
        base.Invalidate();
    }

    protected override void OnMouseLeave(EventArgs eventArgs_0)
    {
        base.OnMouseLeave(eventArgs_0);
        this.point_0 = new Point(-1, -1);
        base.Invalidate();
    }

    protected override void OnMouseClick(MouseEventArgs mouseEventArgs_0)
    {
        base.OnMouseClick(mouseEventArgs_0);
        if (mouseEventArgs_0.Button != MouseButtons.Left)
        {
            return;
        }
        if (mouseEventArgs_0.X >= 0 && mouseEventArgs_0.X < 16)
        {
            if (this.int_1 - 20 >= 0)
            {
                this.method_0(this.int_1 - 20);
                return;
            }
        }
        else
        {
            if (mouseEventArgs_0.X >= 16 && mouseEventArgs_0.X < base.Bounds.Right - 64)
            {
                this.method_0((int)((float)(100 * (mouseEventArgs_0.X - 16)) / (float)(base.Bounds.Right - 80) + 10f) / 20 * 20);
                return;
            }
            if (mouseEventArgs_0.X >= base.Bounds.Right - 64 && mouseEventArgs_0.X < base.Bounds.Right - 48)
            {
                if (this.int_1 + 20 <= 100)
                {
                    this.method_0(this.int_1 + 20);
                    return;
                }
            }
            else if (mouseEventArgs_0.X >= base.Bounds.Right - 48 && mouseEventArgs_0.X < base.Bounds.Right - 32)
            {
                if (this.int_1 != 0)
                {
                    this.method_0(0);
                    return;
                }
            }
            else if (mouseEventArgs_0.X >= base.Bounds.Right - 32 && mouseEventArgs_0.X < base.Bounds.Right - 16)
            {
                if (this.int_1 != this.int_0)
                {
                    this.method_0(this.int_0);
                    return;
                }
            }
            else if (mouseEventArgs_0.X >= base.Bounds.Right - 16 && mouseEventArgs_0.X < base.Bounds.Right && this.int_1 != 100)
            {
                this.method_0(100);
            }
        }
    }

    protected override void OnPaint(PaintEventArgs paintEventArgs_0)
    {
        base.OnPaint(paintEventArgs_0);
        if (this.bool_3)
        {
            if (this.point_0.X >= 0 && this.point_0.X < 16)
            {
                ControlPaint.DrawBorder3D(paintEventArgs_0.Graphics, 0, 0, 16, 16, Border3DStyle.Flat, Border3DSide.All);
            }
            paintEventArgs_0.Graphics.DrawIcon(this.icon_0, 0, 0);
        }
        else
        {
            ControlPaint.DrawImageDisabled(paintEventArgs_0.Graphics, this.bitmap_0, 0, 0, this.BackColor);
        }
        if (this.bool_4)
        {
            if (this.point_0.X >= base.Bounds.Right - 64 && this.point_0.X < base.Bounds.Right - 48)
            {
                ControlPaint.DrawBorder3D(paintEventArgs_0.Graphics, base.Bounds.Right - 64, 0, 16, 16, Border3DStyle.Flat, Border3DSide.All);
            }
            paintEventArgs_0.Graphics.DrawIcon(this.icon_1, base.Bounds.Right - 64, 0);
        }
        else
        {
            ControlPaint.DrawImageDisabled(paintEventArgs_0.Graphics, this.bitmap_1, base.Bounds.Right - 64, 0, this.BackColor);
        }
        if (this.bool_1)
        {
            if (this.point_0.X >= base.Bounds.Right - 48 && this.point_0.X < base.Bounds.Right - 32)
            {
                ControlPaint.DrawBorder3D(paintEventArgs_0.Graphics, base.Bounds.Right - 48, 0, 16, 16, Border3DStyle.Flat, Border3DSide.All);
            }
            paintEventArgs_0.Graphics.DrawIcon(this.icon_2, base.Bounds.Right - 48, 0);
        }
        else
        {
            ControlPaint.DrawImageDisabled(paintEventArgs_0.Graphics, this.bitmap_2, base.Bounds.Right - 48, 0, this.BackColor);
        }
        if (this.bool_2)
        {
            if (this.point_0.X >= base.Bounds.Right - 32 && this.point_0.X < base.Bounds.Right - 16)
            {
                ControlPaint.DrawBorder3D(paintEventArgs_0.Graphics, base.Bounds.Right - 32, 0, 16, 16, Border3DStyle.Flat, Border3DSide.All);
            }
            paintEventArgs_0.Graphics.DrawIcon(this.icon_3, base.Bounds.Right - 32, 0);
        }
        else
        {
            ControlPaint.DrawImageDisabled(paintEventArgs_0.Graphics, this.bitmap_3, base.Bounds.Right - 32, 0, this.BackColor);
        }
        if (this.bool_0)
        {
            if (this.point_0.X >= base.Bounds.Right - 16 && this.point_0.X < base.Bounds.Right)
            {
                ControlPaint.DrawBorder3D(paintEventArgs_0.Graphics, base.Bounds.Right - 16, 0, 16, 16, Border3DStyle.Flat, Border3DSide.All);
            }
            paintEventArgs_0.Graphics.DrawIcon(this.icon_4, base.Bounds.Right - 16, 0);
        }
        else
        {
            ControlPaint.DrawImageDisabled(paintEventArgs_0.Graphics, this.bitmap_4, base.Bounds.Right - 16, 0, this.BackColor);
        }
        int num = 16 + (base.Bounds.Right - 80) * this.int_1 / 100;
        float num2 = 14f / (float)(base.Bounds.Right - 64);
        float num3 = 0f;
        int i = 16;
        while (i < base.Bounds.Right - 64)
        {
            paintEventArgs_0.Graphics.DrawLine((i > num) ? Pens.Gray : Pens.Black, i, (int)(14f - num3), i, 14);
            i += 2;
            num3 += num2 * 2f;
        }
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    void InitializeComponent()
    {
        base.SuspendLayout();
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        this.DoubleBuffered = true;
        this.MaximumSize = new Size(400, 16);
        this.MinimumSize = new Size(100, 16);
        base.Name = "ZoomControl";
        base.Size = new Size(200, 16);
        base.ResumeLayout(false);
    }

    Icon icon_0;

    Icon icon_1;

    Icon icon_2;

    Icon icon_3;

    Icon icon_4;

    Bitmap bitmap_0;

    Bitmap bitmap_1;

    Bitmap bitmap_2;

    Bitmap bitmap_3;

    Bitmap bitmap_4;

    int int_0 = 20;

    int int_1;

    bool bool_0;

    bool bool_1;

    bool bool_2;

    bool bool_3;

    bool bool_4;

    EventHandler eventHandler_0;

    Point point_0 = Point.Empty;

    IContainer icontainer_0;
}
