using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class SongEditorControl : Control, GInterface37
{
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	void InitializeComponent()
	{
		this.hScrollBar1 = new HScrollBar();
		this.vScrollBar1 = new VScrollBar();
		this.zoomControl1 = new ZoomControl();
		base.SuspendLayout();
		this.hScrollBar1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.hScrollBar1.Location = new Point(155, 387);
		this.hScrollBar1.Name = "hScrollBar1";
		this.hScrollBar1.Size = new Size(359, 16);
		this.hScrollBar1.TabIndex = 0;
		this.hScrollBar1.ValueChanged += this.hScrollBar1_ValueChanged;
		this.vScrollBar1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
		this.vScrollBar1.Location = new Point(514, 0);
		this.vScrollBar1.Name = "vScrollBar1";
		this.vScrollBar1.Size = new Size(16, 387);
		this.vScrollBar1.SmallChange = 2;
		this.vScrollBar1.TabIndex = 4;
		this.vScrollBar1.ValueChanged += this.vScrollBar1_ValueChanged;
		this.zoomControl1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this.zoomControl1.Location = new Point(0, 387);
		this.zoomControl1.MaximumSize = new Size(400, 16);
		this.zoomControl1.MinimumSize = new Size(100, 16);
		this.zoomControl1.Name = "zoomControl1";
		this.zoomControl1.Size = new Size(155, 16);
		this.zoomControl1.TabIndex = 3;
		this.zoomControl1.method_1(new EventHandler(this.method_11));
		base.Controls.Add(this.zoomControl1);
		base.Controls.Add(this.hScrollBar1);
		base.Controls.Add(this.vScrollBar1);
		base.Name = "SongEditorControl";
		base.Size = new Size(530, 403);
		base.ResumeLayout(false);
	}

	public SongEditorControl(GClass136 gclass136_1)
	{
		this.InitializeComponent();
		base.SetStyle(ControlStyles.Selectable | ControlStyles.OptimizedDoubleBuffer, true);
		this.gclass136_0 = gclass136_1;
		this.gclass136_0.method_1(new EventHandler(this.method_0));
	}

	void method_0(object sender, EventArgs e)
	{
		this.method_7(true);
	}

	void method_1(GClass106 gclass106_2)
	{
		this.method_9(false);
		this.method_10();
	}

	public double imethod_0()
	{
		return (double)this.hScrollBar1.Value / 100.0;
	}

	public int imethod_1()
	{
		return this.int_0;
	}

	public int imethod_2()
	{
		return this.int_1;
	}

	public double imethod_3()
	{
		return this.double_0;
	}

	public Point imethod_4()
	{
		return this.mouseEventArgs_0.Location;
	}

	public int imethod_5()
	{
		return 0;
	}

	public void imethod_6(int int_2)
	{
	}

	public double imethod_7()
	{
		return 0.0;
	}

	public void imethod_8(double double_1)
	{
	}

	public GClass136 imethod_11()
	{
		return this.gclass136_0;
	}

	public int imethod_10(double double_1)
	{
		double num = this.method_4() + double.Epsilon;
		double num2 = double_1 * num;
		double num3 = Math.Round(num2);
		double num4 = Math.Abs(num3 - num2);
		return (int)((num4 < 1E-10) ? num3 : num2);
	}

	public double imethod_9(int int_2)
	{
		return (double)int_2 / this.method_4();
	}

	public void method_2(GClass106 gclass106_2)
	{
		gclass106_2.method_6(new GDelegate17(this.method_1));
		this.list_0.Add(gclass106_2);
		this.method_13(gclass106_2);
		this.method_9(false);
	}

	float method_3()
	{
		float num = this.zoomControl1.method_3() * 4f;
		int num2 = (int)(num + 0.5f);
		return Class109.smethod_11(this.float_0[(int)num], this.float_0[num2], num - (float)num2);
	}

	double method_4()
	{
		float num = this.zoomControl1.method_3() * 4f;
		int num2 = (int)(num + 0.5f);
		return Class109.smethod_10((double)this.float_0[(int)num], (double)this.float_0[num2], (double)(num - (float)num2));
	}

	void method_5(object sender, EventArgs e)
	{
		this.method_9(false);
		this.method_10();
	}

	public void method_6(GClass106 gclass106_2)
	{
		this.list_0.Remove(gclass106_2);
		gclass106_2.method_7(new GDelegate17(this.method_1));
		gclass106_2.Dispose();
		this.method_9(false);
	}

	void method_7(bool bool_0)
	{
		if (this.gclass136_0 == null)
		{
			return;
		}
		float num = (float)this.hScrollBar1.Value / (float)this.hScrollBar1.Maximum;
		int num2 = (int)(this.gclass136_0.method_3() * 111.0);
		int num3 = (this.list_0.Count > 0) ? ((int)((float)(this.list_0[0].method_10().Width * 100) / this.method_3())) : 0;
		this.hScrollBar1.SuspendLayout();
		this.hScrollBar1.Maximum = num2 - num3;
		this.hScrollBar1.Minimum = 0;
		this.hScrollBar1.SmallChange = (int)(Class109.smethod_11(0.1f, 1f, 1f - this.zoomControl1.method_3()) * 100f);
		this.hScrollBar1.LargeChange = (int)(Class109.smethod_11(1f, 10f, 1f - this.zoomControl1.method_3()) * 100f);
		if (bool_0)
		{
			this.hScrollBar1.Value = (int)(num * (float)this.hScrollBar1.Maximum);
		}
		this.hScrollBar1.ResumeLayout();
	}

	void method_8()
	{
		if (this.list_0.Count == 0)
		{
			this.vScrollBar1.Enabled = false;
			return;
		}
		int value = this.vScrollBar1.Value;
		int num = 0;
		foreach (GClass106 gclass in this.list_0)
		{
			num += gclass.method_10().Height;
		}
		num += this.hScrollBar1.Height;
		this.vScrollBar1.SuspendLayout();
		this.vScrollBar1.Enabled = true;
		this.vScrollBar1.Maximum = num - this.hScrollBar1.Top;
		this.vScrollBar1.SmallChange = this.vScrollBar1.Maximum / this.list_0.Count;
		if (value <= this.vScrollBar1.Maximum && value >= this.vScrollBar1.Minimum)
		{
			this.vScrollBar1.Value = value;
		}
		this.vScrollBar1.ResumeLayout();
	}

	void method_9(bool bool_0)
	{
		base.SuspendLayout();
		int num = -this.vScrollBar1.Value;
		foreach (GClass106 gclass in this.list_0)
		{
			gclass.method_11(new Rectangle(base.ClientRectangle.Left, num, this.vScrollBar1.Left - base.ClientRectangle.Left, gclass.method_8()));
			num += gclass.method_8() + 2;
		}
		if (!bool_0)
		{
			if (num + this.vScrollBar1.Value > this.hScrollBar1.Top)
			{
				this.method_8();
				this.vScrollBar1.Enabled = true;
			}
			else
			{
				this.vScrollBar1.Enabled = false;
				this.vScrollBar1.Value = this.vScrollBar1.Minimum;
			}
		}
		base.ResumeLayout();
	}

	protected virtual void OnSizeChanged(EventArgs eventArgs_0)
	{
		base.OnSizeChanged(eventArgs_0);
		this.method_9(false);
		this.method_7(false);
	}

	void vScrollBar1_ValueChanged(object sender, EventArgs e)
	{
		this.int_0 = this.gclass136_0.method_11().method_22(this.imethod_0());
		this.method_9(true);
	}

	void method_10()
	{
		foreach (GClass106 gclass in this.list_0)
		{
			gclass.vmethod_2();
			base.Invalidate(gclass.method_10());
		}
	}

	void hScrollBar1_ValueChanged(object sender, EventArgs e)
	{
		this.method_10();
	}

	void method_11(object sender, EventArgs e)
	{
		this.method_7(true);
		this.method_10();
	}

	protected virtual void OnPaintBackground(PaintEventArgs pevent)
	{
		base.OnPaintBackground(pevent);
		foreach (GClass106 gclass in this.list_0)
		{
			Rectangle clipRect = Rectangle.Intersect(gclass.method_10(), pevent.ClipRectangle);
			if (!clipRect.IsEmpty)
			{
				gclass.vmethod_16(new PaintEventArgs(pevent.Graphics, clipRect));
			}
		}
	}

	protected virtual void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		foreach (GClass106 gclass in this.list_0)
		{
			Rectangle clip = Rectangle.Intersect(gclass.method_10(), paintEventArgs_0.ClipRectangle);
			if (!clip.IsEmpty)
			{
				ControlPaint.DrawBorder3D(paintEventArgs_0.Graphics, gclass.method_10().Left, gclass.method_10().Top, gclass.method_10().Width, gclass.method_10().Height + 2, Border3DStyle.Etched, Border3DSide.Bottom);
				RectangleF visibleClipBounds = paintEventArgs_0.Graphics.VisibleClipBounds;
				paintEventArgs_0.Graphics.SetClip(clip);
				gclass.vmethod_17(paintEventArgs_0);
				paintEventArgs_0.Graphics.SetClip(visibleClipBounds);
				if (gclass == this.gclass106_0)
				{
					ControlPaint.DrawSelectionFrame(paintEventArgs_0.Graphics, true, Rectangle.Inflate(gclass.method_10(), -1, -1), Rectangle.Inflate(gclass.method_10(), -2, -2), Color.White);
				}
			}
		}
	}

	protected virtual void OnResize(EventArgs eventArgs_0)
	{
		base.OnResize(eventArgs_0);
		this.method_9(false);
		base.Invalidate(base.ClientRectangle);
	}

	protected virtual void OnKeyDown(KeyEventArgs keyEventArgs_2)
	{
		base.OnKeyDown(keyEventArgs_2);
		this.keyEventArgs_1 = keyEventArgs_2;
		if (this.gclass106_0 != null)
		{
			this.gclass106_0.vmethod_13(keyEventArgs_2);
		}
		if (this.gclass106_1 != null)
		{
			Cursor.Current = this.gclass106_1.vmethod_3(this.mouseEventArgs_0, keyEventArgs_2);
		}
	}

	protected virtual void OnKeyUp(KeyEventArgs keyEventArgs_2)
	{
		base.OnKeyUp(keyEventArgs_2);
		if (this.gclass106_0 != null)
		{
			this.gclass106_0.vmethod_15(keyEventArgs_2);
		}
		if (this.gclass106_1 != null)
		{
			Cursor.Current = this.gclass106_1.vmethod_3(this.mouseEventArgs_0, keyEventArgs_2);
		}
		this.keyEventArgs_1 = this.keyEventArgs_0;
	}

	protected virtual void OnKeyPress(KeyPressEventArgs keyPressEventArgs_0)
	{
		base.OnKeyPress(keyPressEventArgs_0);
		if (this.gclass106_0 != null)
		{
			this.gclass106_0.vmethod_14(keyPressEventArgs_0);
		}
		if (this.gclass106_1 != null)
		{
			Cursor.Current = this.gclass106_1.vmethod_3(this.mouseEventArgs_0, this.keyEventArgs_1);
		}
		this.keyEventArgs_1 = this.keyEventArgs_0;
	}

	protected virtual void OnMouseMove(MouseEventArgs mouseEventArgs_2)
	{
		base.OnMouseMove(mouseEventArgs_2);
		this.method_12(mouseEventArgs_2);
		GClass106 gclass = null;
		foreach (GClass106 gclass2 in this.list_0)
		{
			if (gclass2.method_10().Contains(mouseEventArgs_2.Location))
			{
				gclass = gclass2;
				break;
			}
		}
		if (gclass != this.gclass106_1 && this.gclass106_1 != null)
		{
			this.gclass106_1.vmethod_12();
		}
		if (gclass != null)
		{
			if (this.gclass106_1 == null)
			{
				gclass.vmethod_11();
			}
			gclass.vmethod_7(mouseEventArgs_2);
			Cursor.Current = gclass.vmethod_3(mouseEventArgs_2, this.keyEventArgs_1);
		}
		else
		{
			Cursor.Current = Cursors.Default;
		}
		this.gclass106_1 = gclass;
		this.method_13(gclass);
	}

	protected virtual void OnMouseDown(MouseEventArgs mouseEventArgs_2)
	{
		base.OnMouseDown(mouseEventArgs_2);
		this.method_12(mouseEventArgs_2);
		this.method_13(this.gclass106_1);
		base.Focus();
		base.Invalidate();
		if (this.gclass106_1 != null)
		{
			this.gclass106_1.vmethod_8(mouseEventArgs_2);
			Cursor.Current = this.gclass106_1.vmethod_3(mouseEventArgs_2, this.keyEventArgs_1);
		}
	}

	protected virtual void OnMouseUp(MouseEventArgs mouseEventArgs_2)
	{
		base.OnMouseUp(mouseEventArgs_2);
		this.method_12(mouseEventArgs_2);
		if (this.gclass106_1 != null)
		{
			this.gclass106_1.vmethod_9(mouseEventArgs_2);
			Cursor.Current = this.gclass106_1.vmethod_3(mouseEventArgs_2, this.keyEventArgs_1);
		}
	}

	protected virtual void OnMouseClick(MouseEventArgs mouseEventArgs_2)
	{
		base.OnMouseClick(mouseEventArgs_2);
		base.Focus();
		this.method_12(mouseEventArgs_2);
		this.method_13(this.gclass106_1);
		base.Invalidate();
		if (this.gclass106_1 != null)
		{
			this.gclass106_1.vmethod_10(mouseEventArgs_2);
			Cursor.Current = this.gclass106_1.vmethod_3(mouseEventArgs_2, this.keyEventArgs_1);
		}
	}

	protected virtual void OnMouseLeave(EventArgs eventArgs_0)
	{
		base.OnMouseLeave(eventArgs_0);
		this.method_12(this.mouseEventArgs_1);
		if (this.gclass106_1 != null)
		{
			this.gclass106_1.vmethod_12();
			this.gclass106_1 = null;
			Cursor.Current = Cursors.Default;
		}
	}

	void method_12(MouseEventArgs mouseEventArgs_2)
	{
		this.mouseEventArgs_0 = mouseEventArgs_2;
		double num = -1.0;
		int num2 = -1;
		if (mouseEventArgs_2.X >= base.ClientRectangle.Left)
		{
			num = this.imethod_0() + this.imethod_9(mouseEventArgs_2.X - base.ClientRectangle.Left);
			num2 = this.gclass136_0.method_11().method_22(num);
		}
		if (num2 != this.int_1 || num != this.double_0)
		{
			this.double_0 = num;
			this.int_1 = num2;
			if (this.gclass106_1 != null)
			{
				base.Invalidate(this.gclass106_1.method_10());
			}
		}
	}

	void method_13(GClass106 gclass106_2)
	{
		if (gclass106_2 == this.gclass106_0)
		{
			return;
		}
		if (this.gclass106_0 != null)
		{
			this.gclass106_0.method_5(false);
		}
		this.gclass106_0 = gclass106_2;
		if (this.gclass106_0 != null)
		{
			this.gclass106_0.method_5(true);
		}
	}

	void GInterface37.Invalidate(Rectangle rect)
	{
		base.Invalidate(rect);
	}

	IContainer icontainer_0;

	HScrollBar hScrollBar1;

	ZoomControl zoomControl1;

	VScrollBar vScrollBar1;

	List<GClass106> list_0 = new List<GClass106>();

	GClass106 gclass106_0;

	GClass136 gclass136_0;

	int int_0;

	int int_1 = -1;

	double double_0 = -1.0;

	float[] float_0 = new float[]
	{
		100f,
		160f,
		220f,
		360f,
		550f
	};

	MouseEventArgs mouseEventArgs_0 = new MouseEventArgs(MouseButtons.None, 0, -1, -1, 0);

	MouseEventArgs mouseEventArgs_1 = new MouseEventArgs(MouseButtons.None, 0, -1, -1, 0);

	KeyEventArgs keyEventArgs_0 = new KeyEventArgs(Keys.None);

	KeyEventArgs keyEventArgs_1 = new KeyEventArgs(Keys.None);

	GClass106 gclass106_1;
}
