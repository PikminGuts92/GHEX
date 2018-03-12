using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

class Class102 : ToolStripRenderer
{
	public ToolStripRenderMode method_0()
	{
		return this.toolStripRenderMode_0;
	}

	public void method_1(ToolStripRenderMode toolStripRenderMode_1)
	{
		this.toolStripRenderMode_0 = toolStripRenderMode_1;
		switch (this.toolStripRenderMode_0)
		{
		case ToolStripRenderMode.System:
			this.toolStripRenderer_0 = new ToolStripSystemRenderer();
			return;
		case ToolStripRenderMode.Professional:
			this.toolStripRenderer_0 = new ToolStripProfessionalRenderer();
			return;
		default:
			this.toolStripRenderer_0 = null;
			return;
		}
	}

	public bool method_2()
	{
		return this.bool_0;
	}

	public void method_3(bool bool_2)
	{
		this.bool_0 = bool_2;
	}

	public bool method_4()
	{
		return this.bool_1;
	}

	public void method_5(bool bool_2)
	{
		if (bool_2 && !Application.RenderWithVisualStyles)
		{
			return;
		}
		this.bool_1 = bool_2;
	}

	protected virtual void Initialize(ToolStrip toolStrip)
	{
		base.Initialize(toolStrip);
	}

	protected virtual void OnRenderToolStripBorder(ToolStripRenderEventArgs toolStripRenderEventArgs_0)
	{
		Color color = SystemColors.AppWorkspace;
		if (this.method_4())
		{
			VisualStyleRenderer visualStyleRenderer = new VisualStyleRenderer(VisualStyleElement.Tab.Pane.Normal);
			color = visualStyleRenderer.GetColor(ColorProperty.BorderColorHint);
		}
		using (Pen pen = new Pen(color))
		{
			using (Pen pen2 = new Pen(toolStripRenderEventArgs_0.BackColor))
			{
				Rectangle bounds = toolStripRenderEventArgs_0.ToolStrip.Bounds;
				int num = this.method_2() ? 0 : (bounds.Width - 1 - toolStripRenderEventArgs_0.ToolStrip.Padding.Horizontal);
				int num2 = this.method_2() ? 0 : (bounds.Height - 1);
				if (toolStripRenderEventArgs_0.ToolStrip.Orientation == Orientation.Horizontal)
				{
					toolStripRenderEventArgs_0.Graphics.DrawLine(pen, 0, num2, bounds.Width, num2);
				}
				else
				{
					toolStripRenderEventArgs_0.Graphics.DrawLine(pen, num, 0, num, bounds.Height);
					if (!this.method_2())
					{
						for (int i = num + 1; i < bounds.Width; i++)
						{
							toolStripRenderEventArgs_0.Graphics.DrawLine(pen2, i, 0, i, bounds.Height);
						}
					}
				}
				foreach (object obj in toolStripRenderEventArgs_0.ToolStrip.Items)
				{
					ToolStripItem toolStripItem = (ToolStripItem)obj;
					if (!toolStripItem.IsOnOverflow)
					{
						GClass135 gclass = toolStripItem as GClass135;
						if (gclass != null)
						{
							Rectangle bounds2 = gclass.Bounds;
							int num3 = this.method_2() ? bounds2.Left : bounds2.Right;
							int num4 = this.method_2() ? bounds2.Top : (bounds2.Bottom - 1);
							int num5 = this.method_2() ? 0 : 1;
							if (toolStripRenderEventArgs_0.ToolStrip.Orientation == Orientation.Horizontal)
							{
								toolStripRenderEventArgs_0.Graphics.DrawLine(pen, bounds2.Left, num4, bounds2.Right, num4);
								if (gclass.method_11())
								{
									toolStripRenderEventArgs_0.Graphics.DrawLine(pen2, bounds2.Left + 2 - num5, num4, bounds2.Right - 2 - num5, num4);
								}
							}
							else
							{
								toolStripRenderEventArgs_0.Graphics.DrawLine(pen, num3, bounds2.Top, num3, bounds2.Bottom);
								if (gclass.method_11())
								{
									toolStripRenderEventArgs_0.Graphics.DrawLine(pen2, num3, bounds2.Top + 2 - num5, num3, bounds2.Bottom - 2 - num5);
								}
							}
						}
					}
				}
			}
		}
	}

	protected virtual void OnRenderToolStripBackground(ToolStripRenderEventArgs toolStripRenderEventArgs_0)
	{
		if (this.toolStripRenderer_0 != null)
		{
			this.toolStripRenderer_0.DrawToolStripBackground(toolStripRenderEventArgs_0);
			return;
		}
		base.OnRenderToolStripBackground(toolStripRenderEventArgs_0);
	}

	protected virtual void OnRenderButtonBackground(ToolStripItemRenderEventArgs toolStripItemRenderEventArgs_0)
	{
		Graphics graphics = toolStripItemRenderEventArgs_0.Graphics;
		GClass134 gclass = toolStripItemRenderEventArgs_0.ToolStrip as GClass134;
		GClass135 gclass2 = toolStripItemRenderEventArgs_0.Item as GClass135;
		if (gclass != null && gclass2 != null)
		{
			bool flag = gclass2.method_11();
			bool selected = gclass2.Selected;
			int num = 0;
			int num2 = 0;
			int num3 = gclass2.Bounds.Width - 1;
			int num4 = gclass2.Bounds.Height - 1;
			Rectangle bounds;
			if (this.method_4())
			{
				if (gclass.Orientation == Orientation.Horizontal)
				{
					if (!flag)
					{
						num = 2;
						num4--;
					}
					else
					{
						num = 1;
					}
					bounds = new Rectangle(0, 0, num3, num4);
				}
				else
				{
					if (!flag)
					{
						num2 = 2;
						num3--;
					}
					else
					{
						num2 = 1;
					}
					bounds = new Rectangle(0, 0, num4, num3);
				}
				using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
				{
					VisualStyleElement element = VisualStyleElement.Tab.TabItem.Normal;
					if (flag)
					{
						element = VisualStyleElement.Tab.TabItem.Pressed;
					}
					if (selected)
					{
						element = VisualStyleElement.Tab.TabItem.Hot;
					}
					if (!gclass2.Enabled)
					{
						element = VisualStyleElement.Tab.TabItem.Disabled;
					}
					if (flag && !selected)
					{
						bounds.Height++;
					}
					else
					{
						bounds.Width++;
					}
					using (Graphics graphics2 = Graphics.FromImage(bitmap))
					{
						VisualStyleRenderer visualStyleRenderer = new VisualStyleRenderer(element);
						visualStyleRenderer.DrawBackground(graphics2, bounds);
						if (gclass.Orientation == Orientation.Vertical)
						{
							if (this.method_2())
							{
								bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
							}
							else
							{
								bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
							}
						}
						else if (this.method_2())
						{
							bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
						}
						if (this.method_2())
						{
							num2 = gclass2.Bounds.Width - bitmap.Width - num2;
							num = gclass2.Bounds.Height - bitmap.Height - num;
						}
						graphics.DrawImage(bitmap, num2, num);
					}
					return;
				}
			}
			if (gclass.Orientation == Orientation.Horizontal)
			{
				if (!flag)
				{
					num = 2;
					num4--;
				}
				else
				{
					num = 1;
				}
				if (this.method_2())
				{
					num2 = 1;
					num = 0;
				}
				else
				{
					num++;
				}
				num3--;
			}
			else
			{
				if (!flag)
				{
					num2 = 2;
					num3--;
				}
				else
				{
					num2 = 1;
				}
				if (this.method_2())
				{
					num2 = 0;
					num = 1;
				}
			}
			num4--;
			bounds = new Rectangle(num2, num, num3, num4);
			using (GraphicsPath graphicsPath = new GraphicsPath())
			{
				if (this.method_2() && gclass.Orientation == Orientation.Horizontal)
				{
					graphicsPath.AddLine(bounds.Left, bounds.Top, bounds.Left, bounds.Bottom - 2);
					graphicsPath.AddArc(bounds.Left, bounds.Bottom - 3, 2, 2, 90f, 90f);
					graphicsPath.AddLine(bounds.Left + 2, bounds.Bottom, bounds.Right - 2, bounds.Bottom);
					graphicsPath.AddArc(bounds.Right - 2, bounds.Bottom - 3, 2, 2, 0f, 90f);
					graphicsPath.AddLine(bounds.Right, bounds.Bottom - 2, bounds.Right, bounds.Top);
				}
				else if (!this.method_2() && gclass.Orientation == Orientation.Horizontal)
				{
					graphicsPath.AddLine(bounds.Left, bounds.Bottom, bounds.Left, bounds.Top + 2);
					graphicsPath.AddArc(bounds.Left, bounds.Top + 1, 2, 2, 180f, 90f);
					graphicsPath.AddLine(bounds.Left + 2, bounds.Top, bounds.Right - 2, bounds.Top);
					graphicsPath.AddArc(bounds.Right - 2, bounds.Top + 1, 2, 2, 270f, 90f);
					graphicsPath.AddLine(bounds.Right, bounds.Top + 2, bounds.Right, bounds.Bottom);
				}
				else if (this.method_2() && gclass.Orientation == Orientation.Vertical)
				{
					graphicsPath.AddLine(bounds.Left, bounds.Top, bounds.Right - 2, bounds.Top);
					graphicsPath.AddArc(bounds.Right - 2, bounds.Top + 1, 2, 2, 270f, 90f);
					graphicsPath.AddLine(bounds.Right, bounds.Top + 2, bounds.Right, bounds.Bottom - 2);
					graphicsPath.AddArc(bounds.Right - 2, bounds.Bottom - 3, 2, 2, 0f, 90f);
					graphicsPath.AddLine(bounds.Right - 2, bounds.Bottom, bounds.Left, bounds.Bottom);
				}
				else
				{
					graphicsPath.AddLine(bounds.Right, bounds.Top, bounds.Left + 2, bounds.Top);
					graphicsPath.AddArc(bounds.Left, bounds.Top + 1, 2, 2, 180f, 90f);
					graphicsPath.AddLine(bounds.Left, bounds.Top + 2, bounds.Left, bounds.Bottom - 2);
					graphicsPath.AddArc(bounds.Left, bounds.Bottom - 3, 2, 2, 90f, 90f);
					graphicsPath.AddLine(bounds.Left + 2, bounds.Bottom, bounds.Right, bounds.Bottom);
				}
				if (flag || selected)
				{
					Color color = selected ? Color.WhiteSmoke : Color.White;
					if (this.toolStripRenderMode_0 == ToolStripRenderMode.Professional)
					{
						color = (selected ? ProfessionalColors.ButtonCheckedGradientBegin : ProfessionalColors.ButtonCheckedGradientEnd);
						using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(gclass2.ContentRectangle, color, ProfessionalColors.ButtonCheckedGradientMiddle, LinearGradientMode.Vertical))
						{
							graphics.FillPath(linearGradientBrush, graphicsPath);
							goto IL_605;
						}
					}
					using (SolidBrush solidBrush = new SolidBrush(color))
					{
						graphics.FillPath(solidBrush, graphicsPath);
					}
				}
				IL_605:
				using (Pen pen = new Pen(flag ? ControlPaint.Dark(SystemColors.AppWorkspace) : SystemColors.AppWorkspace))
				{
					graphics.DrawPath(pen, graphicsPath);
				}
			}
			return;
		}
		if (this.toolStripRenderer_0 != null)
		{
			this.toolStripRenderer_0.DrawButtonBackground(toolStripItemRenderEventArgs_0);
			return;
		}
		base.OnRenderButtonBackground(toolStripItemRenderEventArgs_0);
	}

	protected virtual void OnRenderItemImage(ToolStripItemImageRenderEventArgs toolStripItemImageRenderEventArgs_0)
	{
		Rectangle imageRectangle = toolStripItemImageRenderEventArgs_0.ImageRectangle;
		GClass135 gclass = toolStripItemImageRenderEventArgs_0.Item as GClass135;
		if (gclass != null)
		{
			int num = (this.method_2() ? -1 : 1) * (gclass.method_11() ? 1 : 2);
			if (toolStripItemImageRenderEventArgs_0.ToolStrip.Orientation == Orientation.Horizontal)
			{
				imageRectangle.Offset(this.method_2() ? 2 : 1, num + (this.method_2() ? 1 : 0));
			}
			else
			{
				imageRectangle.Offset(num + 2, 0);
			}
		}
		ToolStripItemImageRenderEventArgs e = new ToolStripItemImageRenderEventArgs(toolStripItemImageRenderEventArgs_0.Graphics, toolStripItemImageRenderEventArgs_0.Item, toolStripItemImageRenderEventArgs_0.Image, imageRectangle);
		if (this.toolStripRenderer_0 != null)
		{
			this.toolStripRenderer_0.DrawItemImage(e);
			return;
		}
		base.OnRenderItemImage(e);
	}

	protected virtual void OnRenderItemText(ToolStripItemTextRenderEventArgs toolStripItemTextRenderEventArgs_0)
	{
		Rectangle textRectangle = toolStripItemTextRenderEventArgs_0.TextRectangle;
		GClass135 gclass = toolStripItemTextRenderEventArgs_0.Item as GClass135;
		Color textColor = toolStripItemTextRenderEventArgs_0.TextColor;
		Font textFont = toolStripItemTextRenderEventArgs_0.TextFont;
		if (gclass != null)
		{
			int num = (this.method_2() ? -1 : 1) * (gclass.method_11() ? 1 : 2);
			if (toolStripItemTextRenderEventArgs_0.ToolStrip.Orientation == Orientation.Horizontal)
			{
				textRectangle.Offset(this.method_2() ? 2 : 1, num + (this.method_2() ? 1 : -1));
			}
			else
			{
				textRectangle.Offset(num + 2, 0);
			}
			if (gclass.Selected)
			{
				textColor = gclass.method_5();
			}
			else if (gclass.method_11())
			{
				textColor = gclass.method_7();
			}
			if (gclass.method_11())
			{
				textFont = gclass.method_9();
			}
		}
		ToolStripItemTextRenderEventArgs toolStripItemTextRenderEventArgs = new ToolStripItemTextRenderEventArgs(toolStripItemTextRenderEventArgs_0.Graphics, toolStripItemTextRenderEventArgs_0.Item, toolStripItemTextRenderEventArgs_0.Text, textRectangle, textColor, textFont, toolStripItemTextRenderEventArgs_0.TextFormat);
		toolStripItemTextRenderEventArgs.TextDirection = toolStripItemTextRenderEventArgs_0.TextDirection;
		if (this.toolStripRenderer_0 != null)
		{
			this.toolStripRenderer_0.DrawItemText(toolStripItemTextRenderEventArgs);
			return;
		}
		base.OnRenderItemText(toolStripItemTextRenderEventArgs);
	}

	protected virtual void OnRenderArrow(ToolStripArrowRenderEventArgs toolStripArrowRenderEventArgs_0)
	{
		if (this.toolStripRenderer_0 != null)
		{
			this.toolStripRenderer_0.DrawArrow(toolStripArrowRenderEventArgs_0);
			return;
		}
		base.OnRenderArrow(toolStripArrowRenderEventArgs_0);
	}

	protected virtual void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs toolStripItemRenderEventArgs_0)
	{
		if (this.toolStripRenderer_0 != null)
		{
			this.toolStripRenderer_0.DrawDropDownButtonBackground(toolStripItemRenderEventArgs_0);
			return;
		}
		base.OnRenderDropDownButtonBackground(toolStripItemRenderEventArgs_0);
	}

	protected virtual void OnRenderGrip(ToolStripGripRenderEventArgs toolStripGripRenderEventArgs_0)
	{
		if (this.toolStripRenderer_0 != null)
		{
			this.toolStripRenderer_0.DrawGrip(toolStripGripRenderEventArgs_0);
			return;
		}
		base.OnRenderGrip(toolStripGripRenderEventArgs_0);
	}

	protected virtual void OnRenderImageMargin(ToolStripRenderEventArgs toolStripRenderEventArgs_0)
	{
		if (this.toolStripRenderer_0 != null)
		{
			this.toolStripRenderer_0.DrawImageMargin(toolStripRenderEventArgs_0);
			return;
		}
		base.OnRenderImageMargin(toolStripRenderEventArgs_0);
	}

	protected virtual void OnRenderItemBackground(ToolStripItemRenderEventArgs toolStripItemRenderEventArgs_0)
	{
		if (this.toolStripRenderer_0 != null)
		{
			this.toolStripRenderer_0.DrawItemBackground(toolStripItemRenderEventArgs_0);
			return;
		}
		base.OnRenderItemBackground(toolStripItemRenderEventArgs_0);
	}

	protected virtual void OnRenderItemCheck(ToolStripItemImageRenderEventArgs toolStripItemImageRenderEventArgs_0)
	{
		if (this.toolStripRenderer_0 != null)
		{
			this.toolStripRenderer_0.DrawItemCheck(toolStripItemImageRenderEventArgs_0);
			return;
		}
		base.OnRenderItemCheck(toolStripItemImageRenderEventArgs_0);
	}

	protected virtual void OnRenderLabelBackground(ToolStripItemRenderEventArgs toolStripItemRenderEventArgs_0)
	{
		if (this.toolStripRenderer_0 != null)
		{
			this.toolStripRenderer_0.DrawLabelBackground(toolStripItemRenderEventArgs_0);
			return;
		}
		base.OnRenderLabelBackground(toolStripItemRenderEventArgs_0);
	}

	protected virtual void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs toolStripItemRenderEventArgs_0)
	{
		if (this.toolStripRenderer_0 != null)
		{
			this.toolStripRenderer_0.DrawMenuItemBackground(toolStripItemRenderEventArgs_0);
			return;
		}
		base.OnRenderMenuItemBackground(toolStripItemRenderEventArgs_0);
	}

	protected virtual void OnRenderOverflowButtonBackground(ToolStripItemRenderEventArgs toolStripItemRenderEventArgs_0)
	{
		if (this.toolStripRenderer_0 != null)
		{
			this.toolStripRenderer_0.DrawOverflowButtonBackground(toolStripItemRenderEventArgs_0);
			return;
		}
		base.OnRenderOverflowButtonBackground(toolStripItemRenderEventArgs_0);
	}

	protected virtual void OnRenderSeparator(ToolStripSeparatorRenderEventArgs toolStripSeparatorRenderEventArgs_0)
	{
		if (this.toolStripRenderer_0 != null)
		{
			this.toolStripRenderer_0.DrawSeparator(toolStripSeparatorRenderEventArgs_0);
			return;
		}
		base.OnRenderSeparator(toolStripSeparatorRenderEventArgs_0);
	}

	protected virtual void OnRenderSplitButtonBackground(ToolStripItemRenderEventArgs toolStripItemRenderEventArgs_0)
	{
		if (this.toolStripRenderer_0 != null)
		{
			this.toolStripRenderer_0.DrawSplitButton(toolStripItemRenderEventArgs_0);
			return;
		}
		base.OnRenderSplitButtonBackground(toolStripItemRenderEventArgs_0);
	}

	protected virtual void OnRenderStatusStripSizingGrip(ToolStripRenderEventArgs toolStripRenderEventArgs_0)
	{
		if (this.toolStripRenderer_0 != null)
		{
			this.toolStripRenderer_0.DrawStatusStripSizingGrip(toolStripRenderEventArgs_0);
			return;
		}
		base.OnRenderStatusStripSizingGrip(toolStripRenderEventArgs_0);
	}

	protected virtual void OnRenderToolStripContentPanelBackground(ToolStripContentPanelRenderEventArgs toolStripContentPanelRenderEventArgs_0)
	{
		if (this.toolStripRenderer_0 != null)
		{
			this.toolStripRenderer_0.DrawToolStripContentPanelBackground(toolStripContentPanelRenderEventArgs_0);
			return;
		}
		base.OnRenderToolStripContentPanelBackground(toolStripContentPanelRenderEventArgs_0);
	}

	protected virtual void OnRenderToolStripPanelBackground(ToolStripPanelRenderEventArgs toolStripPanelRenderEventArgs_0)
	{
		if (this.toolStripRenderer_0 != null)
		{
			this.toolStripRenderer_0.DrawToolStripPanelBackground(toolStripPanelRenderEventArgs_0);
			return;
		}
		base.OnRenderToolStripPanelBackground(toolStripPanelRenderEventArgs_0);
	}

	protected virtual void OnRenderToolStripStatusLabelBackground(ToolStripItemRenderEventArgs toolStripItemRenderEventArgs_0)
	{
		if (this.toolStripRenderer_0 != null)
		{
			this.toolStripRenderer_0.DrawToolStripStatusLabelBackground(toolStripItemRenderEventArgs_0);
			return;
		}
		base.OnRenderToolStripStatusLabelBackground(toolStripItemRenderEventArgs_0);
	}

	const int int_0 = 2;

	ToolStripRenderer toolStripRenderer_0;

	ToolStripRenderMode toolStripRenderMode_0;

	bool bool_0;

	bool bool_1 = Application.RenderWithVisualStyles;
}
