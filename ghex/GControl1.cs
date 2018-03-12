using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[ToolboxItem(true)]
[ToolboxBitmap("FATabStrip.bmp")]
[DefaultEvent("TabStripItemSelectionChanged")]
[DefaultProperty("Items")]
public class GControl1 : GControl0, IDisposable, ISupportInitialize
{
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_5(GDelegate16 gdelegate16_1)
	{
		this.gdelegate16_0 = (GDelegate16)Delegate.Combine(this.gdelegate16_0, gdelegate16_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_6(GDelegate16 gdelegate16_1)
	{
		this.gdelegate16_0 = (GDelegate16)Delegate.Remove(this.gdelegate16_0, gdelegate16_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_7(GDelegate15 gdelegate15_1)
	{
		this.gdelegate15_0 = (GDelegate15)Delegate.Combine(this.gdelegate15_0, gdelegate15_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_8(GDelegate15 gdelegate15_1)
	{
		this.gdelegate15_0 = (GDelegate15)Delegate.Remove(this.gdelegate15_0, gdelegate15_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_9(HandledEventHandler handledEventHandler_1)
	{
		this.handledEventHandler_0 = (HandledEventHandler)Delegate.Combine(this.handledEventHandler_0, handledEventHandler_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_10(HandledEventHandler handledEventHandler_1)
	{
		this.handledEventHandler_0 = (HandledEventHandler)Delegate.Remove(this.handledEventHandler_0, handledEventHandler_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_11(EventHandler eventHandler_3)
	{
		this.eventHandler_1 = (EventHandler)Delegate.Combine(this.eventHandler_1, eventHandler_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_12(EventHandler eventHandler_3)
	{
		this.eventHandler_1 = (EventHandler)Delegate.Remove(this.eventHandler_1, eventHandler_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_13(EventHandler eventHandler_3)
	{
		this.eventHandler_2 = (EventHandler)Delegate.Combine(this.eventHandler_2, eventHandler_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_14(EventHandler eventHandler_3)
	{
		this.eventHandler_2 = (EventHandler)Delegate.Remove(this.eventHandler_2, eventHandler_3);
	}

	public GEnum30 method_15(Point point_0)
	{
		if (this.class15_0.method_2().Contains(point_0))
		{
			return GEnum30.const_0;
		}
		if (this.class89_0.method_2().Contains(point_0))
		{
			return GEnum30.const_1;
		}
		if (this.method_19(point_0) != null)
		{
			return GEnum30.const_2;
		}
		return GEnum30.const_3;
	}

	public void method_16(GClass98 gclass98_1)
	{
		this.method_17(gclass98_1, false);
	}

	public void method_17(GClass98 gclass98_1, bool bool_4)
	{
		gclass98_1.Dock = DockStyle.Fill;
		this.method_35().vmethod_9(gclass98_1);
		if ((bool_4 && gclass98_1.method_4()) || (gclass98_1.method_4() && this.method_35().vmethod_0() < 1))
		{
			this.method_30(gclass98_1);
			this.method_21(gclass98_1);
		}
	}

	public void method_18(GClass98 gclass98_1)
	{
		int num = this.method_35().vmethod_12(gclass98_1);
		if (num >= 0)
		{
			this.method_22(gclass98_1);
			this.method_35().vmethod_10(gclass98_1);
		}
		if (this.method_35().Count > 0)
		{
			if (this.RightToLeft == RightToLeft.No)
			{
				if (this.method_35().method_18(num - 1) != null)
				{
					this.method_30(this.method_35().method_18(num - 1));
					return;
				}
				this.method_30(this.method_35().vmethod_2());
				return;
			}
			else
			{
				if (this.method_35().method_18(num + 1) != null)
				{
					this.method_30(this.method_35().method_18(num + 1));
					return;
				}
				this.method_30(this.method_35().vmethod_1());
			}
		}
	}

	public GClass98 method_19(Point point_0)
	{
		GClass98 result = null;
		bool flag = false;
		for (int i = 0; i < this.method_35().Count; i++)
		{
			GClass98 gclass = this.method_35().method_18(i);
			if (gclass.method_6().Contains(point_0) && gclass.method_4() && gclass.method_8())
			{
				result = gclass;
				flag = true;
			}
			if (flag)
			{
				break;
			}
		}
		return result;
	}

	public virtual void vmethod_1()
	{
		if (!this.contextMenuStrip_0.Visible && this.contextMenuStrip_0.Items.Count > 0)
		{
			if (this.RightToLeft == RightToLeft.No)
			{
				this.contextMenuStrip_0.Show(this, new Point(this.class89_0.method_2().Left, this.class89_0.method_2().Bottom));
			}
			else
			{
				this.contextMenuStrip_0.Show(this, new Point(this.class89_0.method_2().Right, this.class89_0.method_2().Bottom));
			}
			this.bool_3 = true;
		}
	}

	internal void method_20()
	{
		for (int i = 0; i < this.method_35().Count; i++)
		{
			this.method_35().method_18(i).method_9(false);
		}
	}

	internal void method_21(GClass98 gclass98_1)
	{
		gclass98_1.Dock = DockStyle.Fill;
		gclass98_1.method_5(true);
		gclass98_1.method_17(true);
	}

	internal void method_22(GClass98 gclass98_1)
	{
		gclass98_1.method_17(false);
	}

	protected internal virtual void vmethod_2(GEventArgs11 geventArgs11_0)
	{
		if (this.gdelegate16_0 != null)
		{
			this.gdelegate16_0(geventArgs11_0);
		}
	}

	protected internal virtual void vmethod_3(EventArgs eventArgs_0)
	{
		if (this.eventHandler_2 != null)
		{
			this.eventHandler_2(this, eventArgs_0);
		}
	}

	protected virtual void vmethod_4(HandledEventArgs handledEventArgs_0)
	{
		if (this.handledEventHandler_0 != null)
		{
			this.handledEventHandler_0(this, handledEventArgs_0);
		}
	}

	protected virtual void vmethod_5(EventArgs eventArgs_0)
	{
		if (this.eventHandler_1 != null)
		{
			this.eventHandler_1(this, eventArgs_0);
		}
	}

	protected virtual void vmethod_6(GEventArgs12 geventArgs12_0)
	{
		if (this.gdelegate15_0 != null)
		{
			this.gdelegate15_0(geventArgs12_0);
		}
	}

	protected virtual void vmethod_7(EventArgs eventArgs_0)
	{
		this.contextMenuStrip_0.RightToLeft = this.RightToLeft;
		this.contextMenuStrip_0.Items.Clear();
		for (int i = 0; i < this.method_35().Count; i++)
		{
			GClass98 gclass = this.method_35().method_18(i);
			if (gclass.method_4())
			{
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(gclass.method_14());
				toolStripMenuItem.Tag = gclass;
				toolStripMenuItem.Image = gclass.method_10();
				this.contextMenuStrip_0.Items.Add(toolStripMenuItem);
			}
		}
		this.vmethod_5(EventArgs.Empty);
	}

	protected override void OnRightToLeftChanged(EventArgs eventArgs_0)
	{
		base.OnRightToLeftChanged(eventArgs_0);
		this.method_27();
		base.Invalidate();
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		this.method_24();
		Rectangle clientRectangle = base.ClientRectangle;
		clientRectangle.Width--;
		clientRectangle.Height--;
		if (this.RightToLeft == RightToLeft.No)
		{
			this.int_4 = 10;
		}
		else
		{
			this.int_4 = this.rectangle_0.Right;
		}
		paintEventArgs_0.Graphics.DrawRectangle(SystemPens.ControlDark, clientRectangle);
		paintEventArgs_0.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
		for (int i = 0; i < this.method_35().Count; i++)
		{
			GClass98 gclass = this.method_35().method_18(i);
			if (gclass.method_4() || base.DesignMode)
			{
				this.method_25(paintEventArgs_0.Graphics, gclass);
				gclass.method_9(false);
				if (this.method_23(gclass))
				{
					this.method_26(paintEventArgs_0.Graphics, gclass);
				}
			}
		}
		if (this.RightToLeft == RightToLeft.No)
		{
			if (this.method_35().vmethod_0() != 0 && this.method_35().vmethod_3() != 0)
			{
				if (this.method_29() != null && this.method_29().method_8())
				{
					Point point = new Point((int)this.method_29().method_6().Left - 9, 19);
					paintEventArgs_0.Graphics.DrawLine(SystemPens.ControlDark, new Point(0, 19), point);
					point.X += (int)this.method_29().method_6().Width + 10;
					paintEventArgs_0.Graphics.DrawLine(SystemPens.ControlDark, point, new Point(base.ClientRectangle.Width, 19));
				}
			}
			else
			{
				paintEventArgs_0.Graphics.DrawLine(SystemPens.ControlDark, new Point(0, 19), new Point(base.ClientRectangle.Width, 19));
			}
		}
		else if (this.method_35().vmethod_0() != 0 && this.method_35().vmethod_3() != 0)
		{
			if (this.method_29() != null && this.method_29().method_8())
			{
				Point point2 = new Point((int)this.method_29().method_6().Left, 19);
				paintEventArgs_0.Graphics.DrawLine(SystemPens.ControlDark, new Point(0, 19), point2);
				point2.X += (int)this.method_29().method_6().Width + 20;
				paintEventArgs_0.Graphics.DrawLine(SystemPens.ControlDark, point2, new Point(base.ClientRectangle.Width, 19));
			}
		}
		else
		{
			paintEventArgs_0.Graphics.DrawLine(SystemPens.ControlDark, new Point(0, 19), new Point(base.ClientRectangle.Width, 19));
		}
		if (this.method_31() || this.method_35().vmethod_0() > this.method_35().vmethod_3())
		{
			this.class89_0.method_4(paintEventArgs_0.Graphics);
		}
		if (this.method_33() || (this.method_29() != null && this.method_29().method_12()))
		{
			this.class15_0.method_4(paintEventArgs_0.Graphics);
		}
	}

	protected override void OnMouseDown(MouseEventArgs mouseEventArgs_0)
	{
		base.OnMouseDown(mouseEventArgs_0);
		if (mouseEventArgs_0.Button != MouseButtons.Left)
		{
			return;
		}
		GEnum30 genum = this.method_15(mouseEventArgs_0.Location);
		if (genum == GEnum30.const_1)
		{
			HandledEventArgs handledEventArgs = new HandledEventArgs(false);
			this.vmethod_4(handledEventArgs);
			if (!handledEventArgs.Handled)
			{
				this.vmethod_7(EventArgs.Empty);
			}
			this.vmethod_1();
		}
		else if (genum == GEnum30.const_0)
		{
			if (this.method_29() != null)
			{
				GEventArgs11 geventArgs = new GEventArgs11(this.method_29());
				this.vmethod_2(geventArgs);
				if (!geventArgs.method_2() && this.method_29().method_12())
				{
					this.method_18(this.method_29());
					this.vmethod_3(EventArgs.Empty);
				}
			}
		}
		else if (genum == GEnum30.const_2)
		{
			GClass98 gclass = this.method_19(mouseEventArgs_0.Location);
			if (gclass != null)
			{
				this.method_30(gclass);
			}
		}
		base.Invalidate();
	}

	protected override void OnMouseMove(MouseEventArgs mouseEventArgs_0)
	{
		base.OnMouseMove(mouseEventArgs_0);
		if (this.class89_0.method_2().Contains(mouseEventArgs_0.Location))
		{
			this.class89_0.method_1(true);
			base.Invalidate(this.class89_0.method_2());
		}
		else if (this.class89_0.method_0() && !this.bool_3)
		{
			this.class89_0.method_1(false);
			base.Invalidate(this.class89_0.method_2());
		}
		if (this.class15_0.method_2().Contains(mouseEventArgs_0.Location))
		{
			this.class15_0.method_1(true);
			base.Invalidate(this.class15_0.method_2());
			return;
		}
		if (this.class15_0.method_0())
		{
			this.class15_0.method_1(false);
			base.Invalidate(this.class15_0.method_2());
		}
	}

	protected override void OnMouseLeave(EventArgs eventArgs_0)
	{
		base.OnMouseLeave(eventArgs_0);
		this.class89_0.method_1(false);
		base.Invalidate(this.class89_0.method_2());
		this.class15_0.method_1(false);
		base.Invalidate(this.class15_0.method_2());
	}

	protected override void OnSizeChanged(EventArgs eventArgs_0)
	{
		base.OnSizeChanged(eventArgs_0);
		if (this.bool_1)
		{
			return;
		}
		this.method_27();
	}

	bool method_23(GClass98 gclass98_1)
	{
		bool result = true;
		if (this.RightToLeft == RightToLeft.No)
		{
			if (gclass98_1.method_6().Right >= (float)this.rectangle_0.Width)
			{
				result = false;
			}
		}
		else if (gclass98_1.method_6().Left <= (float)this.rectangle_0.Left)
		{
			return false;
		}
		return result;
	}

	void method_24()
	{
		if (this.gclass98_0 == null && this.method_35().Count > 0)
		{
			this.method_30(this.method_35().method_18(0));
		}
		for (int i = 0; i < this.method_35().Count; i++)
		{
			GClass98 gclass = this.method_35().method_18(i);
			gclass.Dock = DockStyle.Fill;
		}
	}

	void contextMenuStrip_0_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
	{
		GClass98 gclass98_ = (GClass98)e.ClickedItem.Tag;
		this.method_30(gclass98_);
	}

	void contextMenuStrip_0_VisibleChanged(object sender, EventArgs e)
	{
		if (!this.contextMenuStrip_0.Visible)
		{
			this.bool_3 = false;
		}
	}

	void method_25(Graphics graphics_0, GClass98 gclass98_1)
	{
		Font font = this.Font;
		if (gclass98_1 == this.method_29())
		{
			font = new Font(this.Font, FontStyle.Bold);
		}
		SizeF sizeF = graphics_0.MeasureString(gclass98_1.method_14(), font, new SizeF(200f, 10f), this.stringFormat_0);
		sizeF.Width += 20f;
		if (this.RightToLeft == RightToLeft.No)
		{
			RectangleF rectangleF_ = new RectangleF((float)this.int_4, 3f, sizeF.Width, 17f);
			gclass98_1.method_7(rectangleF_);
			this.int_4 += (int)sizeF.Width;
			return;
		}
		RectangleF rectangleF_2 = new RectangleF((float)this.int_4 - sizeF.Width + 1f, 3f, sizeF.Width - 1f, 17f);
		gclass98_1.method_7(rectangleF_2);
		this.int_4 -= (int)sizeF.Width;
	}

	void method_26(Graphics graphics_0, GClass98 gclass98_1)
	{
		bool flag = this.method_35().vmethod_12(gclass98_1) == 0;
		Font font = this.Font;
		if (gclass98_1 == this.method_29())
		{
			font = new Font(this.Font, FontStyle.Bold);
		}
		SizeF sizeF = graphics_0.MeasureString(gclass98_1.method_14(), font, new SizeF(200f, 10f), this.stringFormat_0);
		sizeF.Width += 20f;
		RectangleF rectangleF = gclass98_1.method_6();
		GraphicsPath graphicsPath = new GraphicsPath();
		int num = 3;
		if (this.RightToLeft == RightToLeft.No)
		{
			if (gclass98_1 != this.method_29() && !flag)
			{
				graphicsPath.AddLine(rectangleF.Left, rectangleF.Bottom - 1f, rectangleF.Left, rectangleF.Bottom - rectangleF.Height / 2f - 2f);
				graphicsPath.AddLine(rectangleF.Left, rectangleF.Bottom - rectangleF.Height / 2f - 3f, rectangleF.Left + rectangleF.Height / 2f - 4f, (float)(num + 3));
			}
			else
			{
				graphicsPath.AddLine(rectangleF.Left - 10f, rectangleF.Bottom - 1f, rectangleF.Left + rectangleF.Height / 2f - 4f, (float)(num + 4));
			}
			graphicsPath.AddLine(rectangleF.Left + rectangleF.Height / 2f + 2f, (float)num, rectangleF.Right - 3f, (float)num);
			graphicsPath.AddLine(rectangleF.Right, (float)(num + 2), rectangleF.Right, rectangleF.Bottom - 1f);
			graphicsPath.AddLine(rectangleF.Right - 4f, rectangleF.Bottom - 1f, rectangleF.Left, rectangleF.Bottom - 1f);
			graphicsPath.CloseFigure();
			LinearGradientBrush brush;
			if (gclass98_1 == this.method_29())
			{
				brush = new LinearGradientBrush(rectangleF, SystemColors.ControlLightLight, SystemColors.Window, LinearGradientMode.Vertical);
			}
			else
			{
				brush = new LinearGradientBrush(rectangleF, SystemColors.ControlLightLight, SystemColors.Control, LinearGradientMode.Vertical);
			}
			graphics_0.FillPath(brush, graphicsPath);
			graphics_0.DrawPath(SystemPens.ControlDark, graphicsPath);
			if (gclass98_1 == this.method_29())
			{
				graphics_0.DrawLine(new Pen(brush), rectangleF.Left - 9f, rectangleF.Height + 2f, rectangleF.Left + rectangleF.Width - 1f, rectangleF.Height + 2f);
			}
			PointF location = new PointF(rectangleF.Left + rectangleF.Height - 4f, rectangleF.Top + rectangleF.Height / 2f - sizeF.Height / 2f - 3f);
			RectangleF layoutRectangle = rectangleF;
			layoutRectangle.Location = location;
			layoutRectangle.Width = rectangleF.Width - (layoutRectangle.Left - rectangleF.Left) - 4f;
			layoutRectangle.Height = sizeF.Height + font.Size / 2f;
			if (gclass98_1 == this.method_29())
			{
				graphics_0.DrawString(gclass98_1.method_14(), font, new SolidBrush(this.ForeColor), layoutRectangle, this.stringFormat_0);
			}
			else
			{
				graphics_0.DrawString(gclass98_1.method_14(), font, new SolidBrush(this.ForeColor), layoutRectangle, this.stringFormat_0);
			}
		}
		if (this.RightToLeft == RightToLeft.Yes)
		{
			if (gclass98_1 != this.method_29() && !flag)
			{
				graphicsPath.AddLine(rectangleF.Right, rectangleF.Bottom - 1f, rectangleF.Right, rectangleF.Bottom - rectangleF.Height / 2f - 2f);
				graphicsPath.AddLine(rectangleF.Right, rectangleF.Bottom - rectangleF.Height / 2f - 3f, rectangleF.Right - rectangleF.Height / 2f + 4f, (float)(num + 3));
			}
			else
			{
				graphicsPath.AddLine(rectangleF.Right + 10f, rectangleF.Bottom - 1f, rectangleF.Right - rectangleF.Height / 2f + 4f, (float)(num + 4));
			}
			graphicsPath.AddLine(rectangleF.Right - rectangleF.Height / 2f - 2f, (float)num, rectangleF.Left + 3f, (float)num);
			graphicsPath.AddLine(rectangleF.Left, (float)(num + 2), rectangleF.Left, rectangleF.Bottom - 1f);
			graphicsPath.AddLine(rectangleF.Left + 4f, rectangleF.Bottom - 1f, rectangleF.Right, rectangleF.Bottom - 1f);
			graphicsPath.CloseFigure();
			LinearGradientBrush brush;
			if (gclass98_1 == this.method_29())
			{
				brush = new LinearGradientBrush(rectangleF, SystemColors.ControlLightLight, SystemColors.Window, LinearGradientMode.Vertical);
			}
			else
			{
				brush = new LinearGradientBrush(rectangleF, SystemColors.ControlLightLight, SystemColors.Control, LinearGradientMode.Vertical);
			}
			graphics_0.FillPath(brush, graphicsPath);
			graphics_0.DrawPath(SystemPens.ControlDark, graphicsPath);
			if (gclass98_1 == this.method_29())
			{
				graphics_0.DrawLine(new Pen(brush), rectangleF.Right + 9f, rectangleF.Height + 2f, rectangleF.Right - rectangleF.Width + 1f, rectangleF.Height + 2f);
			}
			PointF location2 = new PointF(rectangleF.Left + 2f, rectangleF.Top + rectangleF.Height / 2f - sizeF.Height / 2f - 2f);
			RectangleF layoutRectangle2 = rectangleF;
			layoutRectangle2.Location = location2;
			layoutRectangle2.Width = rectangleF.Width - (layoutRectangle2.Left - rectangleF.Left) - 10f;
			layoutRectangle2.Height = sizeF.Height + font.Size / 2f;
			if (gclass98_1 == this.method_29())
			{
				layoutRectangle2.Y -= 1f;
				graphics_0.DrawString(gclass98_1.method_14(), font, new SolidBrush(this.ForeColor), layoutRectangle2, this.stringFormat_0);
			}
			else
			{
				graphics_0.DrawString(gclass98_1.method_14(), font, new SolidBrush(this.ForeColor), layoutRectangle2, this.stringFormat_0);
			}
		}
		gclass98_1.method_9(true);
	}

	void method_27()
	{
		if (this.RightToLeft == RightToLeft.No)
		{
			this.stringFormat_0.Trimming = StringTrimming.EllipsisCharacter;
			this.stringFormat_0.FormatFlags |= StringFormatFlags.NoWrap;
			this.stringFormat_0.FormatFlags &= StringFormatFlags.DirectionRightToLeft;
			this.rectangle_0 = new Rectangle(0, 0, base.ClientSize.Width - 40 - 2, 10);
			this.class89_0.method_3(new Rectangle(base.ClientSize.Width - 40, 2, 16, 16));
			this.class15_0.method_3(new Rectangle(base.ClientSize.Width - 20, 2, 16, 16));
		}
		else
		{
			this.stringFormat_0.Trimming = StringTrimming.EllipsisCharacter;
			this.stringFormat_0.FormatFlags |= StringFormatFlags.NoWrap;
			this.stringFormat_0.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
			this.rectangle_0 = new Rectangle(42, 0, base.ClientSize.Width - 40 - 15, 10);
			this.class15_0.method_3(new Rectangle(4, 2, 16, 16));
			this.class89_0.method_3(new Rectangle(24, 2, 16, 16));
		}
		base.DockPadding.Top = 20;
		base.DockPadding.Bottom = 1;
		base.DockPadding.Right = 1;
		base.DockPadding.Left = 1;
	}

	void method_28(object sender, CollectionChangeEventArgs e)
	{
		GClass98 gclass = (GClass98)e.Element;
		if (e.Action == CollectionChangeAction.Add)
		{
			this.method_38().Add(gclass);
			this.vmethod_6(new GEventArgs12(gclass, GEnum32.const_0));
		}
		else if (e.Action == CollectionChangeAction.Remove)
		{
			this.method_38().Remove(gclass);
			this.vmethod_6(new GEventArgs12(gclass, GEnum32.const_1));
		}
		else
		{
			this.vmethod_6(new GEventArgs12(gclass, GEnum32.const_2));
		}
		this.method_27();
		base.Invalidate();
	}

	public GControl1()
	{
		this.System.ComponentModel.ISupportInitialize.BeginInit();
		base.SetStyle(ControlStyles.ContainerControl, true);
		base.SetStyle(ControlStyles.UserPaint, true);
		base.SetStyle(ControlStyles.ResizeRedraw, true);
		base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
		base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
		base.SetStyle(ControlStyles.Selectable, true);
		this.gclass112_0 = new GClass112();
		this.gclass112_0.method_16(new CollectionChangeEventHandler(this.method_28));
		base.Size = new Size(350, 200);
		this.contextMenuStrip_0 = new ContextMenuStrip();
		this.contextMenuStrip_0.Renderer = base.method_3();
		this.contextMenuStrip_0.ItemClicked += this.contextMenuStrip_0_ItemClicked;
		this.contextMenuStrip_0.VisibleChanged += this.contextMenuStrip_0_VisibleChanged;
		this.class89_0 = new Class89(base.method_3());
		this.class15_0 = new Class15(base.method_3());
		this.Font = GControl1.font_0;
		this.stringFormat_0 = new StringFormat();
		this.System.ComponentModel.ISupportInitialize.EndInit();
		this.method_27();
	}

	public GClass98 method_29()
	{
		return this.gclass98_0;
	}

	public void method_30(GClass98 gclass98_1)
	{
		if (this.gclass98_0 == gclass98_1)
		{
			return;
		}
		if (gclass98_1 == null && this.method_35().Count > 0)
		{
			GClass98 gclass = this.method_35().method_18(0);
			if (gclass.method_4())
			{
				this.gclass98_0 = gclass;
				this.gclass98_0.method_17(true);
				this.gclass98_0.Dock = DockStyle.Fill;
			}
		}
		else
		{
			this.gclass98_0 = gclass98_1;
		}
		foreach (object obj in this.method_35())
		{
			GClass98 gclass2 = (GClass98)obj;
			if (gclass2 == this.gclass98_0)
			{
				this.method_21(gclass2);
				gclass2.Dock = DockStyle.Fill;
				gclass2.Show();
			}
			else
			{
				this.method_22(gclass2);
				gclass2.Hide();
			}
		}
		this.method_21(this.gclass98_0);
		base.Invalidate();
		if (!this.gclass98_0.method_8())
		{
			this.method_35().vmethod_11(0, this.gclass98_0);
			base.Invalidate();
		}
		this.vmethod_6(new GEventArgs12(this.gclass98_0, GEnum32.const_3));
	}

	public bool method_31()
	{
		return this.bool_2;
	}

	public void method_32(bool bool_4)
	{
		if (this.bool_2 == bool_4)
		{
			return;
		}
		this.bool_2 = bool_4;
		base.Invalidate();
	}

	public bool method_33()
	{
		return this.bool_0;
	}

	public void method_34(bool bool_4)
	{
		if (this.bool_0 == bool_4)
		{
			return;
		}
		this.bool_0 = bool_4;
		base.Invalidate();
	}

	public GClass112 method_35()
	{
		return this.gclass112_0;
	}

	public Size method_36()
	{
		return base.Size;
	}

	public void method_37(Size size_0)
	{
		if (base.Size == size_0)
		{
			return;
		}
		base.Size = size_0;
		this.method_27();
	}

	public Control.ControlCollection method_38()
	{
		return base.Controls;
	}

	public bool method_39()
	{
		return this.Font != null && !this.Font.Equals(GControl1.font_0);
	}

	public bool method_40()
	{
		return true;
	}

	public bool method_41()
	{
		return this.gclass112_0.Count > 0;
	}

	public void method_42()
	{
		this.Font = GControl1.font_0;
	}

	public void BeginInit()
	{
		this.bool_1 = true;
	}

	public void EndInit()
	{
		this.bool_1 = false;
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			this.gclass112_0.method_17(new CollectionChangeEventHandler(this.method_28));
			this.contextMenuStrip_0.ItemClicked -= this.contextMenuStrip_0_ItemClicked;
			this.contextMenuStrip_0.VisibleChanged -= this.contextMenuStrip_0_VisibleChanged;
			foreach (object obj in this.gclass112_0)
			{
				GClass98 gclass = (GClass98)obj;
				if (gclass != null && !gclass.IsDisposed)
				{
					gclass.Dispose();
				}
			}
			if (this.contextMenuStrip_0 != null && !this.contextMenuStrip_0.IsDisposed)
			{
				this.contextMenuStrip_0.Dispose();
			}
			if (this.stringFormat_0 != null)
			{
				this.stringFormat_0.Dispose();
			}
		}
		base.Dispose(disposing);
	}

	const int int_0 = 19;

	const int int_1 = 40;

	internal static int int_2 = 350;

	internal static int int_3 = 200;

	int int_4 = 10;

	GDelegate16 gdelegate16_0;

	GDelegate15 gdelegate15_0;

	HandledEventHandler handledEventHandler_0;

	EventHandler eventHandler_1;

	EventHandler eventHandler_2;

	Rectangle rectangle_0 = Rectangle.Empty;

	GClass98 gclass98_0;

	ContextMenuStrip contextMenuStrip_0;

	Class89 class89_0;

	Class15 class15_0;

	GClass112 gclass112_0;

	StringFormat stringFormat_0;

	static Font font_0 = new Font("Tahoma", 8.25f, FontStyle.Regular);

	bool bool_0 = true;

	bool bool_1;

	bool bool_2 = true;

	bool bool_3;
}
