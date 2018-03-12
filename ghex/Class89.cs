using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class Class89
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

	internal Class89(ToolStripProfessionalRenderer toolStripProfessionalRenderer_1)
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
		SmoothingMode smoothingMode = graphics_0.SmoothingMode;
		graphics_0.SmoothingMode = SmoothingMode.Default;
		using (Pen pen = new Pen(Color.Black))
		{
			pen.Width = 2f;
			graphics_0.DrawLine(pen, new Point(this.rectangle_0.Left + this.rectangle_0.Width / 3 - 2, this.rectangle_0.Height / 2 - 1), new Point(this.rectangle_0.Right - this.rectangle_0.Width / 3, this.rectangle_0.Height / 2 - 1));
		}
		graphics_0.FillPolygon(Brushes.Black, new Point[]
		{
			new Point(this.rectangle_0.Left + this.rectangle_0.Width / 3 - 2, this.rectangle_0.Height / 2 + 2),
			new Point(this.rectangle_0.Right - this.rectangle_0.Width / 3, this.rectangle_0.Height / 2 + 2),
			new Point(this.rectangle_0.Left + this.rectangle_0.Width / 2 - 1, this.rectangle_0.Bottom - 4)
		});
		graphics_0.SmoothingMode = smoothingMode;
	}

	Rectangle rectangle_0 = Rectangle.Empty;

	bool bool_0;

	ToolStripProfessionalRenderer toolStripProfessionalRenderer_0;
}
