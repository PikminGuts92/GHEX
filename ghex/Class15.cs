using System;
using System.Drawing;
using System.Windows.Forms;

class Class15
{
    public bool method_0()
    {
        return this.bool_0;
    }

    public void method_1(bool bool_1)
    {
        this.bool_0 = bool_1;
    }

    public Rectangle method_2()
    {
        return this.rectangle_0;
    }

    public void method_3(Rectangle rectangle_1)
    {
        this.rectangle_0 = rectangle_1;
    }

    internal Class15(ToolStripProfessionalRenderer toolStripProfessionalRenderer_1)
    {
        this.toolStripProfessionalRenderer_0 = toolStripProfessionalRenderer_1;
    }

    public void method_4(Graphics graphics_0)
    {
        if (this.bool_0)
        {
            Color buttonSelectedHighlight = this.toolStripProfessionalRenderer_0.ColorTable.ButtonSelectedHighlight;
            graphics_0.FillRectangle(new SolidBrush(buttonSelectedHighlight), this.rectangle_0);
            Rectangle rect = this.rectangle_0;
            rect.Width--;
            rect.Height--;
            graphics_0.DrawRectangle(SystemPens.Highlight, rect);
        }
        using (Pen pen = new Pen(Color.Black, 1.6f))
        {
            graphics_0.DrawLine(pen, this.rectangle_0.Left + 3, this.rectangle_0.Top + 3, this.rectangle_0.Right - 5, this.rectangle_0.Bottom - 4);
            graphics_0.DrawLine(pen, this.rectangle_0.Right - 5, this.rectangle_0.Top + 3, this.rectangle_0.Left + 3, this.rectangle_0.Bottom - 4);
        }
    }

    Rectangle rectangle_0 = Rectangle.Empty;

    bool bool_0;

    ToolStripProfessionalRenderer toolStripProfessionalRenderer_0;
}
