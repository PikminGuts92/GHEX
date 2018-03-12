using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GClass47 : GClass46
{
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_30(EventHandler eventHandler_1)
	{
		this.eventHandler_0 = (EventHandler)Delegate.Combine(this.eventHandler_0, eventHandler_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_31(EventHandler eventHandler_1)
	{
		this.eventHandler_0 = (EventHandler)Delegate.Remove(this.eventHandler_0, eventHandler_1);
	}

	public GClass47()
	{
		this.colorPicker_0 = new GClass47.ColorPicker(this);
		this.colorPicker_0.Location = new Point(0, 0);
		this.colorPicker_0.Dock = DockStyle.Fill;
		this.colorPicker_0.KeyPress += base.vmethod_12;
		base.method_13().Width = this.colorPicker_0.Width + 2;
		base.method_13().Height = this.colorPicker_0.Height + 2;
		base.method_13().method_4(this.colorPicker_0);
		base.method_20(GEnum56.const_1);
		this.form_1 = null;
	}

	protected override void vmethod_0(Rectangle rectangle_1)
	{
		GInterface2 ginterface = base.method_9().method_166().method_17(base.method_10().method_3());
		int num = ((GClass6)ginterface).method_18();
		base.method_12().Size = new Size(rectangle_1.Width - 1 - num, rectangle_1.Height - 1);
		base.method_12().Location = rectangle_1.Location;
	}

	protected override void vmethod_1()
	{
		Color color = (Color)((base.method_8().method_7() != null) ? base.method_8().method_7() : Color.Empty);
		base.method_12().Text = this.method_32(color);
		this.colorPicker_0.method_6(color);
	}

	protected override void vmethod_2()
	{
		base.method_8().method_8(this.colorPicker_0.method_5());
	}

	public override void imethod_1()
	{
		this.colorPicker_0.method_0(new EventHandler(this.method_37));
		base.method_12().SelectionLength = 0;
		base.imethod_1();
	}

	public override void imethod_2()
	{
		this.colorPicker_0.method_1(new EventHandler(this.method_37));
		base.imethod_2();
	}

	public override void imethod_3()
	{
		this.colorPicker_0.method_1(new EventHandler(this.method_37));
		base.imethod_3();
	}

	protected string method_32(Color color_0)
	{
		if (color_0.IsEmpty)
		{
			return "Empty";
		}
		if (!color_0.IsNamedColor && !color_0.IsSystemColor)
		{
			string text = "";
			if (color_0.A != 255)
			{
				text = text + color_0.A + ", ";
			}
			object obj = text;
			return string.Concat(new object[]
			{
				obj,
				color_0.R,
				", ",
				color_0.G,
				", ",
				color_0.B
			});
		}
		return color_0.Name;
	}

	protected override bool vmethod_11(Control control_1, Point point_0)
	{
		if (this.method_35() != null)
		{
			if (control_1 == this.method_35())
			{
				return false;
			}
			if (this.method_35().Contains(control_1))
			{
				return false;
			}
		}
		return true;
	}

	public GEnum56 method_33()
	{
		return base.method_19();
	}

	public void method_34(GEnum56 genum56_1)
	{
		throw new NotSupportedException();
	}

	internal Form method_35()
	{
		return this.form_1;
	}

	internal void method_36(Form form_2)
	{
		this.form_1 = form_2;
	}

	protected virtual void vmethod_14(EventArgs eventArgs_0)
	{
		if (this.eventHandler_0 != null)
		{
			this.eventHandler_0(this, eventArgs_0);
		}
	}

	protected override void vmethod_12(object sender, KeyPressEventArgs e)
	{
		base.vmethod_12(sender, e);
	}

	protected override void vmethod_13(object sender, EventArgs e)
	{
		if (base.method_12().Focused || base.method_13().ContainsFocus)
		{
			return;
		}
		if (this.method_35() != null && this.method_35().ContainsFocus)
		{
			return;
		}
		if (base.method_9() != null)
		{
			base.method_9().method_122();
		}
	}

	void method_37(object sender, EventArgs e)
	{
		base.method_15(false);
		this.vmethod_14(e);
		base.method_9().method_122();
	}

	EventHandler eventHandler_0;

	GClass47.ColorPicker colorPicker_0;

	Form form_1;

	[ToolboxItem(false)]
	public class ColorPicker : Control
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		public void method_0(EventHandler eventHandler_1)
		{
			this.eventHandler_0 = (EventHandler)Delegate.Combine(this.eventHandler_0, eventHandler_1);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void method_1(EventHandler eventHandler_1)
		{
			this.eventHandler_0 = (EventHandler)Delegate.Remove(this.eventHandler_0, eventHandler_1);
		}

		public ColorPicker(GClass47 gclass47_1)
		{
			if (gclass47_1 == null)
			{
				throw new ArgumentNullException("editor", "editor cannot be null");
			}
			this.gclass47_0 = gclass47_1;
			this.bool_0 = false;
			this.bool_1 = false;
			this.tabControl = new TabControl();
			this.customTabPage = new GClass47.ColorPicker.Class53();
			this.control0_0 = new GClass47.ColorPicker.Control0(gclass47_1);
			this.webTabPage = new GClass47.ColorPicker.Class53();
			this.class52_0 = new GClass47.ColorPicker.Class52();
			this.systemTabPage = new GClass47.ColorPicker.Class53();
			this.class52_1 = new GClass47.ColorPicker.Class52();
			this.tabControl.SuspendLayout();
			base.SuspendLayout();
			this.tabControl.Controls.Add(this.customTabPage);
			this.tabControl.Controls.Add(this.webTabPage);
			this.tabControl.Controls.Add(this.systemTabPage);
			this.tabControl.Location = new Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new Size(this.DefaultSize.Width - 2, this.DefaultSize.Height - 2);
			this.tabControl.TabIndex = 0;
			this.tabControl.TabStop = false;
			this.tabControl.GotFocus += this.tabControl_GotFocus;
			this.customTabPage.Location = new Point(4, 22);
			this.customTabPage.Name = "customTabPage";
			this.customTabPage.Size = new Size(192, 214);
			this.customTabPage.TabIndex = 0;
			this.customTabPage.Text = "Custom";
			this.customTabPage.Controls.Add(this.control0_0);
			this.control0_0.Dock = DockStyle.Fill;
			this.control0_0.method_0(new EventHandler(this.method_12));
			this.control0_0.KeyPress += this.gclass47_0.vmethod_12;
			this.webTabPage.Location = new Point(4, 22);
			this.webTabPage.Name = "webTabPage";
			this.webTabPage.Size = new Size(192, 214);
			this.webTabPage.TabIndex = 1;
			this.webTabPage.Text = "Web";
			this.webTabPage.Controls.Add(this.class52_0);
			this.class52_0.DrawMode = DrawMode.OwnerDrawFixed;
			this.class52_0.BorderStyle = BorderStyle.FixedSingle;
			this.class52_0.IntegralHeight = false;
			this.class52_0.Sorted = false;
			this.class52_0.Dock = DockStyle.Fill;
			this.class52_0.Click += this.class52_1_Click;
			this.class52_0.DrawItem += this.class52_1_DrawItem;
			this.class52_0.KeyDown += this.class52_1_KeyDown;
			this.class52_0.KeyPress += this.gclass47_0.vmethod_12;
			this.systemTabPage.Location = new Point(4, 22);
			this.systemTabPage.Name = "systemTabPage";
			this.systemTabPage.Size = new Size(192, 214);
			this.systemTabPage.TabIndex = 2;
			this.systemTabPage.Text = "System";
			this.systemTabPage.Controls.Add(this.class52_1);
			this.class52_1.DrawMode = DrawMode.OwnerDrawFixed;
			this.class52_1.BorderStyle = BorderStyle.FixedSingle;
			this.class52_1.IntegralHeight = false;
			this.class52_1.Sorted = false;
			this.class52_1.Dock = DockStyle.Fill;
			this.class52_1.Click += this.class52_1_Click;
			this.class52_1.DrawItem += this.class52_1_DrawItem;
			this.class52_1.KeyDown += this.class52_1_KeyDown;
			this.class52_1.FontChanged += this.class52_1_FontChanged;
			this.class52_1.KeyPress += this.gclass47_0.vmethod_12;
			for (int i = 0; i < this.method_7().Length; i++)
			{
				this.class52_0.Items.Add(this.method_7()[i]);
			}
			Array.Sort(this.method_8(), new GClass47.ColorPicker.Class55());
			for (int j = 0; j < this.method_8().Length; j++)
			{
				this.class52_1.Items.Add(this.method_8()[j]);
			}
			base.Controls.Add(this.tabControl);
			base.Name = "ColorPicker";
			base.Size = this.DefaultSize;
			this.tabControl.ResumeLayout(false);
			base.ResumeLayout(false);
			this.method_4();
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing && this.container_0 != null)
			{
				this.container_0.Dispose();
			}
			base.Dispose(disposing);
		}

		Color[] method_2()
		{
			return new Color[]
			{
				Color.Transparent,
				Color.Black,
				Color.DimGray,
				Color.Gray,
				Color.DarkGray,
				Color.Silver,
				Color.LightGray,
				Color.Gainsboro,
				Color.WhiteSmoke,
				Color.White,
				Color.RosyBrown,
				Color.IndianRed,
				Color.Brown,
				Color.Firebrick,
				Color.LightCoral,
				Color.Maroon,
				Color.DarkRed,
				Color.Red,
				Color.Snow,
				Color.MistyRose,
				Color.Salmon,
				Color.Tomato,
				Color.DarkSalmon,
				Color.Coral,
				Color.OrangeRed,
				Color.LightSalmon,
				Color.Sienna,
				Color.SeaShell,
				Color.Chocolate,
				Color.SaddleBrown,
				Color.SandyBrown,
				Color.PeachPuff,
				Color.Peru,
				Color.Linen,
				Color.Bisque,
				Color.DarkOrange,
				Color.BurlyWood,
				Color.Tan,
				Color.AntiqueWhite,
				Color.NavajoWhite,
				Color.BlanchedAlmond,
				Color.PapayaWhip,
				Color.Moccasin,
				Color.Orange,
				Color.Wheat,
				Color.OldLace,
				Color.FloralWhite,
				Color.DarkGoldenrod,
				Color.Goldenrod,
				Color.Cornsilk,
				Color.Gold,
				Color.Khaki,
				Color.LemonChiffon,
				Color.PaleGoldenrod,
				Color.DarkKhaki,
				Color.Beige,
				Color.LightGoldenrodYellow,
				Color.Olive,
				Color.Yellow,
				Color.LightYellow,
				Color.Ivory,
				Color.OliveDrab,
				Color.YellowGreen,
				Color.DarkOliveGreen,
				Color.GreenYellow,
				Color.Chartreuse,
				Color.LawnGreen,
				Color.DarkSeaGreen,
				Color.ForestGreen,
				Color.LimeGreen,
				Color.LightGreen,
				Color.PaleGreen,
				Color.DarkGreen,
				Color.Green,
				Color.Lime,
				Color.Honeydew,
				Color.SeaGreen,
				Color.MediumSeaGreen,
				Color.SpringGreen,
				Color.MintCream,
				Color.MediumSpringGreen,
				Color.MediumAquamarine,
				Color.Aquamarine,
				Color.Turquoise,
				Color.LightSeaGreen,
				Color.MediumTurquoise,
				Color.DarkSlateGray,
				Color.PaleTurquoise,
				Color.Teal,
				Color.DarkCyan,
				Color.Aqua,
				Color.Cyan,
				Color.LightCyan,
				Color.Azure,
				Color.DarkTurquoise,
				Color.CadetBlue,
				Color.PowderBlue,
				Color.LightBlue,
				Color.DeepSkyBlue,
				Color.SkyBlue,
				Color.LightSkyBlue,
				Color.SteelBlue,
				Color.AliceBlue,
				Color.DodgerBlue,
				Color.SlateGray,
				Color.LightSlateGray,
				Color.LightSteelBlue,
				Color.CornflowerBlue,
				Color.RoyalBlue,
				Color.MidnightBlue,
				Color.Lavender,
				Color.Navy,
				Color.DarkBlue,
				Color.MediumBlue,
				Color.Blue,
				Color.GhostWhite,
				Color.SlateBlue,
				Color.DarkSlateBlue,
				Color.MediumSlateBlue,
				Color.MediumPurple,
				Color.BlueViolet,
				Color.Indigo,
				Color.DarkOrchid,
				Color.DarkViolet,
				Color.MediumOrchid,
				Color.Thistle,
				Color.Plum,
				Color.Violet,
				Color.Purple,
				Color.DarkMagenta,
				Color.Magenta,
				Color.Fuchsia,
				Color.Orchid,
				Color.MediumVioletRed,
				Color.DeepPink,
				Color.HotPink,
				Color.LavenderBlush,
				Color.PaleVioletRed,
				Color.Crimson,
				Color.Pink,
				Color.LightPink
			};
		}

		Color[] method_3()
		{
			int num = 26;
			Color[] array = new Color[26];
			for (int i = 1; i <= num; i++)
			{
				array[i - 1] = Color.FromKnownColor((KnownColor)i);
			}
			return array;
		}

		void method_4()
		{
			this.class52_0.ItemHeight = this.Font.Height + 2;
			this.class52_1.ItemHeight = this.Font.Height + 2;
		}

		public Color method_5()
		{
			return this.color_2;
		}

		public void method_6(Color color_3)
		{
			if (this.color_2 != color_3)
			{
				this.color_2 = color_3;
				if (color_3 != Color.Empty)
				{
					TabPage tabPage = this.customTabPage;
					for (int i = 0; i < this.method_7().Length; i++)
					{
						if (this.method_7()[i].Equals(color_3))
						{
							this.class52_0.SelectedItem = color_3;
							tabPage = this.webTabPage;

							if (tabPage == this.customTabPage)
							{
								for (int j = 0; j < this.method_8().Length; j++)
								{
									if (this.method_8()[j].Equals(color_3))
									{
										this.class52_1.SelectedItem = color_3;
										tabPage = this.systemTabPage;
										break;
									}
								}
							}
							this.tabControl.SelectedTab = tabPage;
							this.control0_0.method_14(color_3);
							goto IL_E8;
						}
					}

                    if (tabPage == this.customTabPage)
                    {
                        for (int j = 0; j < this.method_8().Length; j++)
                        {
                            if (this.method_8()[j].Equals(color_3))
                            {
                                this.class52_1.SelectedItem = color_3;
                                tabPage = this.systemTabPage;
                                break;
                            }
                        }
                    }
                    this.tabControl.SelectedTab = tabPage;
                    this.control0_0.method_14(color_3);
                    goto IL_E8;
                }
				IL_E8:
				this.method_9(EventArgs.Empty);
			}
		}

		Color[] method_7()
		{
			if (this.color_0 == null)
			{
				this.color_0 = this.method_2();
			}
			return this.color_0;
		}

		Color[] method_8()
		{
			if (this.color_1 == null)
			{
				this.color_1 = this.method_3();
			}
			return this.color_1;
		}

		protected virtual Size DefaultSize
		{
			get
			{
				return new Size(210, 242);
			}
		}

		protected void method_9(EventArgs eventArgs_0)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, eventArgs_0);
			}
		}

		protected virtual void OnFontChanged(EventArgs eventArgs_0)
		{
			base.OnFontChanged(eventArgs_0);
			this.method_4();
		}

		protected virtual void OnGotFocus(EventArgs eventArgs_0)
		{
			base.OnGotFocus(eventArgs_0);
			this.method_11(this, EventArgs.Empty);
		}

		void class52_1_Click(object sender, EventArgs e)
		{
			Color right = (Color)((ListBox)sender).SelectedItem;
			if (this.color_2 != right)
			{
				this.color_2 = right;
				this.method_9(EventArgs.Empty);
			}
		}

		void class52_1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.class52_1_Click(sender, EventArgs.Empty);
			}
		}

		void class52_1_DrawItem(object sender, DrawItemEventArgs e)
		{
			if (e.Index == -1)
			{
				return;
			}
			ListBox listBox = (ListBox)sender;
			object obj = listBox.Items[e.Index];
			if (listBox == this.class52_0 && !this.bool_0)
			{
				listBox.ItemHeight = listBox.Font.Height;
				this.bool_0 = true;
			}
			else if (listBox == this.class52_1 && !this.bool_1)
			{
				listBox.ItemHeight = listBox.Font.Height;
				this.bool_1 = true;
			}
			e.DrawBackground();
			using (SolidBrush solidBrush = new SolidBrush((Color)obj))
			{
				e.Graphics.FillRectangle(solidBrush, new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, 21, e.Bounds.Height - 4));
			}
			e.Graphics.DrawRectangle(SystemPens.WindowText, new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, 21, e.Bounds.Height - 4 - 1));
			using (Brush brush = new SolidBrush(e.ForeColor))
			{
				e.Graphics.DrawString(((Color)obj).Name, this.Font, brush, (float)(e.Bounds.X + 26), (float)e.Bounds.Y);
			}
		}

		void class52_1_FontChanged(object sender, EventArgs e)
		{
			this.bool_1 = false;
			this.bool_0 = false;
		}

		void method_10(object sender, EventArgs e)
		{
			Rectangle clientRectangle = this.tabControl.TabPages[0].ClientRectangle;
			this.tabControl.GetTabRect(1);
			clientRectangle.Y = 0;
			clientRectangle.Height -= clientRectangle.Y;
		}

		void method_11(object sender, EventArgs e)
		{
			TabPage selectedTab = this.tabControl.SelectedTab;
			if (selectedTab != null && selectedTab.Controls.Count > 0)
			{
				selectedTab.Controls[0].Focus();
			}
		}

		void tabControl_GotFocus(object sender, EventArgs e)
		{
			TabPage selectedTab = this.tabControl.SelectedTab;
			if (selectedTab != null && selectedTab.Controls.Count > 0)
			{
				selectedTab.Controls[0].Focus();
			}
		}

		void method_12(object sender, EventArgs e)
		{
			Color right = this.control0_0.method_13();
			if (this.color_2 != right)
			{
				this.color_2 = right;
				this.method_9(EventArgs.Empty);
			}
		}

		EventHandler eventHandler_0;

		Container container_0;

		GClass47 gclass47_0;

		TabControl tabControl;

		GClass47.ColorPicker.Class53 customTabPage;

		GClass47.ColorPicker.Control0 control0_0;

		GClass47.ColorPicker.Class53 webTabPage;

		GClass47.ColorPicker.Class52 class52_0;

		GClass47.ColorPicker.Class53 systemTabPage;

		GClass47.ColorPicker.Class52 class52_1;

		Color[] color_0;

		Color[] color_1;

		Color color_2;

		bool bool_0;

		bool bool_1;

		internal class Control0 : Control
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			public void method_0(EventHandler eventHandler_1)
			{
				this.eventHandler_0 = (EventHandler)Delegate.Combine(this.eventHandler_0, eventHandler_1);
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			public void method_1(EventHandler eventHandler_1)
			{
				this.eventHandler_0 = (EventHandler)Delegate.Remove(this.eventHandler_0, eventHandler_1);
			}

			public Control0(GClass47 gclass47_1)
			{
				if (gclass47_1 == null)
				{
					throw new ArgumentNullException("editor", "editor cannot be null");
				}
				this.gclass47_0 = gclass47_1;
				this.point_0 = new Point(0, 0);
				base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
				base.SetStyle(ControlStyles.UserPaint, true);
				base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
				base.SetStyle(ControlStyles.DoubleBuffer, true);
				this.BackColor = Color.Transparent;
				base.Size = new Size(200, 200);
			}

			Color method_2(int int_6)
			{
				if (int_6 < 0 || int_6 >= 64)
				{
					throw new IndexOutOfRangeException();
				}
				return this.color_1[int_6];
			}

			Color method_3(int int_6, int int_7)
			{
				return this.method_2(this.method_4(int_6, int_7));
			}

			int method_4(int int_6, int int_7)
			{
				int result = -1;
				if (int_6 != -1 && int_7 != -1)
				{
					result = int_6 + int_7 * 8;
				}
				return result;
			}

			int method_5(Point point_1)
			{
				return this.method_4(point_1.X, point_1.Y);
			}

			Point method_6(Color color_2)
			{
				for (int i = 0; i < 8; i++)
				{
					for (int j = 0; j < 8; j++)
					{
						if (this.method_3(j, i).Equals(color_2))
						{
							return new Point(j, i);
						}
					}
				}
				return Point.Empty;
			}

			Point method_7(int int_6, int int_7)
			{
				Rectangle rectangle = default(Rectangle);
				for (int i = 0; i < 8; i++)
				{
					for (int j = 0; j < 8; j++)
					{
						rectangle.X = 8 + j * 24;
						rectangle.Y = 12 + i * 24;
						rectangle.Width = 16;
						rectangle.Height = 16;
						if (i >= 6)
						{
							rectangle.Y += 8;
						}
						if (rectangle.Contains(int_6, int_7))
						{
							return new Point(j, i);
						}
					}
				}
				return new Point(-1, -1);
			}

			int method_8(int int_6, int int_7)
			{
				return this.method_5(this.method_7(int_6, int_7));
			}

			void method_9()
			{
				Rectangle rect = default(Rectangle);
				int i = 0;
				IL_92:
				while (i < 8)
				{
					for (int j = 0; j < 8; j++)
					{
						if (this.method_13().Equals(this.method_3(j, i)))
						{
							rect.X = 8 + j * 24;
							rect.Y = 12 + i * 24;
							rect.Width = 16;
							rect.Height = 16;
							if (i >= 6)
							{
								rect.Y += 8;
							}
							base.Invalidate(Rectangle.Inflate(rect, 5, 5));

							i++;
							goto IL_92;
						}
					}

                    i++;
                    goto IL_92;
                }
			}

			void method_10()
			{
				Rectangle rect = default(Rectangle);
				rect.X = 8 + this.point_0.X * 24;
				rect.Y = 12 + this.point_0.Y * 24;
				rect.Width = 16;
				rect.Height = 16;
				if (this.point_0.Y >= 6)
				{
					rect.Y += 8;
				}
				base.Invalidate(Rectangle.Inflate(rect, 5, 5));
				Class96.NotifyWinEvent(32773, base.Handle, -4, 1 + this.method_4(this.point_0.X, this.point_0.Y));
			}

			void method_11(Point point_1)
			{
				if (point_1.X < 0)
				{
					point_1.X = 0;
				}
				if (point_1.Y < 0)
				{
					point_1.Y = 0;
				}
				if (point_1.X >= 8)
				{
					point_1.X = 7;
				}
				if (point_1.Y >= 8)
				{
					point_1.Y = 7;
				}
				if (this.point_0 != point_1)
				{
					this.method_10();
					this.point_0 = point_1;
					this.method_10();
				}
			}

			protected virtual bool IsInputKey(Keys keyData)
			{
				if (keyData != Keys.Return)
				{
					switch (keyData)
					{
					case Keys.Left:
					case Keys.Up:
					case Keys.Right:
					case Keys.Down:
						break;
					default:
						return keyData != Keys.F2 && base.IsInputKey(keyData);
					}
				}
				return true;
			}

			protected virtual bool ProcessDialogKey(Keys keyData)
			{
				if (keyData == Keys.F2)
				{
					int num = -1;
					if (this.point_0.X != -1 && this.point_0.Y != -1)
					{
						num = this.point_0.X + 8 * this.point_0.Y;
					}
					if (num >= 48 && num < 64)
					{
						this.vmethod_0(num);
						return true;
					}
				}
				return base.ProcessDialogKey(keyData);
			}

			protected virtual void vmethod_0(int int_6)
			{
				base.Invalidate();
				GClass47.ColorPicker.Control0.frmColorPicker frmColorPicker = new GClass47.ColorPicker.Control0.frmColorPicker(this.method_2(int_6));
				this.gclass47_0.method_36(frmColorPicker);
				if (frmColorPicker.ShowDialog(this.gclass47_0.method_9().FindForm()) == DialogResult.OK)
				{
					this.color_1[int_6] = frmColorPicker.method_6();
					this.method_14(this.color_1[int_6]);
					this.method_16(EventArgs.Empty);
				}
				this.gclass47_0.method_36(null);
			}

			public Color[] method_12()
			{
				return this.color_1;
			}

			public Color method_13()
			{
				return this.color_0;
			}

			public void method_14(Color color_2)
			{
				if (!color_2.Equals(this.color_0))
				{
					this.method_9();
					this.color_0 = color_2;
					this.method_11(this.method_6(color_2));
					this.method_9();
				}
			}

			internal int method_15()
			{
				return this.point_0.X + this.point_0.Y * 8;
			}

			protected virtual void OnPaint(PaintEventArgs paintEventArgs_0)
			{
				Rectangle rect = new Rectangle(8, 8, 16, 16);
				bool flag = false;
				for (int i = 0; i < 8; i++)
				{
					for (int j = 0; j < 8; j++)
					{
						Color color = this.method_3(j, i);
						rect.X = 8 + j * 24;
						rect.Y = 12 + i * 24;
						rect.Width = 16;
						rect.Height = 16;
						if (i >= 6)
						{
							rect.Y += 8;
						}
						using (SolidBrush solidBrush = new SolidBrush(color))
						{
							paintEventArgs_0.Graphics.FillRectangle(solidBrush, rect.X, rect.Y, rect.Width + 1, rect.Height + 1);
						}
						paintEventArgs_0.Graphics.DrawRectangle(SystemPens.ControlDark, rect);
						if (color.Equals(this.method_13()) && !flag)
						{
							paintEventArgs_0.Graphics.DrawRectangle(SystemPens.ControlText, rect.X - 1, rect.Y - 1, rect.Width + 2, rect.Height + 2);
							flag = true;
						}
						if (this.point_0.X == j && this.point_0.Y == i && this.Focused)
						{
							ControlPaint.DrawFocusRectangle(paintEventArgs_0.Graphics, new Rectangle(rect.X - 3, rect.Y - 3, rect.Width + 7, rect.Height + 7));
						}
					}
				}
			}

			protected virtual void OnGotFocus(EventArgs eventArgs_0)
			{
				base.OnGotFocus(eventArgs_0);
				this.method_10();
			}

			protected virtual void OnLostFocus(EventArgs eventArgs_0)
			{
				base.OnLostFocus(eventArgs_0);
				this.method_10();
			}

			protected virtual void OnKeyDown(KeyEventArgs keyEventArgs_0)
			{
				base.OnKeyDown(keyEventArgs_0);
				if (keyEventArgs_0.KeyCode != Keys.Return)
				{
					switch (keyEventArgs_0.KeyCode)
					{
					case Keys.Space:
						this.method_14(this.method_3(this.point_0.X, this.point_0.Y));
						this.method_10();
						break;
					case Keys.Prior:
					case Keys.Next:
					case Keys.End:
					case Keys.Home:
						break;
					case Keys.Left:
						this.method_11(new Point(this.point_0.X - 1, this.point_0.Y));
						return;
					case Keys.Up:
						this.method_11(new Point(this.point_0.X, this.point_0.Y - 1));
						return;
					case Keys.Right:
						this.method_11(new Point(this.point_0.X + 1, this.point_0.Y));
						return;
					case Keys.Down:
						this.method_11(new Point(this.point_0.X, this.point_0.Y + 1));
						return;
					default:
						return;
					}
					return;
				}
				this.method_14(this.method_3(this.point_0.X, this.point_0.Y));
				this.method_10();
				this.method_16(EventArgs.Empty);
			}

			protected virtual void OnMouseDown(MouseEventArgs mouseEventArgs_0)
			{
				base.Focus();
				base.OnMouseDown(mouseEventArgs_0);
				if (mouseEventArgs_0.Button == MouseButtons.Left)
				{
					Point point = this.method_7(mouseEventArgs_0.X, mouseEventArgs_0.Y);
					if (point.X != -1 && point.Y != -1 && point != this.point_0)
					{
						this.method_11(point);
					}
				}
			}

			protected virtual void OnMouseMove(MouseEventArgs mouseEventArgs_0)
			{
				base.OnMouseMove(mouseEventArgs_0);
				if (mouseEventArgs_0.Button == MouseButtons.Left && base.Bounds.Contains(mouseEventArgs_0.X, mouseEventArgs_0.Y))
				{
					Point point = this.method_7(mouseEventArgs_0.X, mouseEventArgs_0.Y);
					if (point.X != -1 && point.Y != -1 && point != this.point_0)
					{
						this.method_11(point);
					}
				}
			}

			protected virtual void OnMouseUp(MouseEventArgs mouseEventArgs_0)
			{
				base.OnMouseUp(mouseEventArgs_0);
				if (mouseEventArgs_0.Button == MouseButtons.Left)
				{
					Point point_ = this.method_7(mouseEventArgs_0.X, mouseEventArgs_0.Y);
					if (point_.X != -1)
					{
						if (point_.Y != -1)
						{
							this.method_11(point_);
							this.method_14(this.method_3(this.point_0.X, this.point_0.Y));
							this.method_16(EventArgs.Empty);
							return;
						}
					}
					return;
				}
				if (mouseEventArgs_0.Button == MouseButtons.Right)
				{
					int num = this.method_8(mouseEventArgs_0.X, mouseEventArgs_0.Y);
					if (num != -1 && num >= 48 && num < 64)
					{
						this.vmethod_0(num);
					}
				}
			}

			protected void method_16(EventArgs eventArgs_0)
			{
				if (this.eventHandler_0 != null)
				{
					this.eventHandler_0(this, eventArgs_0);
				}
			}

			public const int int_0 = 16;

			public const int int_1 = 64;

			public const int int_2 = 8;

			public const int int_3 = 16;

			public const int int_4 = 8;

			public const int int_5 = 8;

			GClass47 gclass47_0;

			Point point_0;

			EventHandler eventHandler_0;

			Color color_0;

			Color[] color_1 = new Color[]
			{
				Color.FromArgb(255, 255, 255),
				Color.FromArgb(255, 192, 192),
				Color.FromArgb(255, 224, 192),
				Color.FromArgb(255, 255, 192),
				Color.FromArgb(192, 255, 192),
				Color.FromArgb(192, 255, 255),
				Color.FromArgb(192, 192, 255),
				Color.FromArgb(255, 192, 255),
				Color.FromArgb(224, 224, 224),
				Color.FromArgb(255, 128, 128),
				Color.FromArgb(255, 192, 128),
				Color.FromArgb(255, 255, 128),
				Color.FromArgb(128, 255, 128),
				Color.FromArgb(128, 255, 255),
				Color.FromArgb(128, 128, 255),
				Color.FromArgb(255, 128, 255),
				Color.FromArgb(192, 192, 192),
				Color.FromArgb(255, 0, 0),
				Color.FromArgb(255, 128, 0),
				Color.FromArgb(255, 255, 0),
				Color.FromArgb(0, 255, 0),
				Color.FromArgb(0, 255, 255),
				Color.FromArgb(0, 0, 255),
				Color.FromArgb(255, 0, 255),
				Color.FromArgb(128, 128, 128),
				Color.FromArgb(192, 0, 0),
				Color.FromArgb(192, 64, 0),
				Color.FromArgb(192, 192, 0),
				Color.FromArgb(0, 192, 0),
				Color.FromArgb(0, 192, 192),
				Color.FromArgb(0, 0, 192),
				Color.FromArgb(192, 0, 192),
				Color.FromArgb(64, 64, 64),
				Color.FromArgb(128, 0, 0),
				Color.FromArgb(128, 64, 0),
				Color.FromArgb(128, 128, 0),
				Color.FromArgb(0, 128, 0),
				Color.FromArgb(0, 128, 128),
				Color.FromArgb(0, 0, 128),
				Color.FromArgb(128, 0, 128),
				Color.FromArgb(0, 0, 0),
				Color.FromArgb(64, 0, 0),
				Color.FromArgb(128, 64, 64),
				Color.FromArgb(64, 64, 0),
				Color.FromArgb(0, 64, 0),
				Color.FromArgb(0, 64, 64),
				Color.FromArgb(0, 0, 64),
				Color.FromArgb(64, 0, 64),
				Color.White,
				Color.White,
				Color.White,
				Color.White,
				Color.White,
				Color.White,
				Color.White,
				Color.White,
				Color.White,
				Color.White,
				Color.White,
				Color.White,
				Color.White,
				Color.White,
				Color.White,
				Color.White
			};

			public class frmColorPicker : Form
			{
				public frmColorPicker(Color color_1)
				{
					this.InitializeComponent();
					this.color_0 = color_1;
					this.class50_0 = GClass47.ColorPicker.Control0.Class49.smethod_7(this.color_0);
					this.class51_0 = GClass47.ColorPicker.Control0.Class49.smethod_8(this.color_0);
					this.m_txt_Hue.Text = this.method_2(this.class50_0.method_0() * 360.0).ToString();
					this.m_txt_Sat.Text = this.method_2(this.class50_0.method_2() * 100.0).ToString();
					this.m_txt_Black.Text = this.method_2(this.class50_0.method_4() * 100.0).ToString();
					this.m_txt_Red.Text = this.color_0.R.ToString();
					this.m_txt_Green.Text = this.color_0.G.ToString();
					this.m_txt_Blue.Text = this.color_0.B.ToString();
					this.m_txt_Cyan.Text = this.method_2(this.class51_0.method_0() * 100.0).ToString();
					this.m_txt_Magenta.Text = this.method_2(this.class51_0.method_2() * 100.0).ToString();
					this.m_txt_Yellow.Text = this.method_2(this.class51_0.method_4() * 100.0).ToString();
					this.m_txt_K.Text = this.method_2(this.class51_0.method_6() * 100.0).ToString();
					this.m_txt_Hue.Update();
					this.m_txt_Sat.Update();
					this.m_txt_Lum.Update();
					this.m_txt_Red.Update();
					this.m_txt_Green.Update();
					this.m_txt_Blue.Update();
					this.m_txt_Cyan.Update();
					this.m_txt_Magenta.Update();
					this.m_txt_Yellow.Update();
					this.m_txt_K.Update();
					this.m_ctrl_BigBox.method_5(this.class50_0);
					this.m_ctrl_ThinBox.method_5(this.class50_0);
					this.m_lbl_Primary_Color.BackColor = color_1;
					this.m_lbl_Secondary_Color.BackColor = color_1;
					this.m_rbtn_Hue.Checked = true;
					this.method_3(this.color_0);
				}

				protected virtual void Dispose(bool disposing)
				{
					if (disposing && this.container_0 != null)
					{
						this.container_0.Dispose();
					}
					base.Dispose(disposing);
				}

				void InitializeComponent()
				{
					this.m_lbl_SelectColor = new Label();
					this.m_pbx_BlankBox = new PictureBox();
					this.m_cmd_OK = new Button();
					this.m_cmd_Cancel = new Button();
					this.m_txt_Hue = new TextBox();
					this.m_txt_Sat = new TextBox();
					this.m_txt_Black = new TextBox();
					this.m_txt_Red = new TextBox();
					this.m_txt_Green = new TextBox();
					this.m_txt_Blue = new TextBox();
					this.m_txt_Lum = new TextBox();
					this.m_txt_a = new TextBox();
					this.m_txt_b = new TextBox();
					this.m_txt_Cyan = new TextBox();
					this.m_txt_Magenta = new TextBox();
					this.m_txt_Yellow = new TextBox();
					this.m_txt_K = new TextBox();
					this.m_txt_Hex = new TextBox();
					this.m_rbtn_Hue = new RadioButton();
					this.m_rbtn_Sat = new RadioButton();
					this.m_rbtn_Black = new RadioButton();
					this.m_rbtn_Red = new RadioButton();
					this.m_rbtn_Green = new RadioButton();
					this.m_rbtn_Blue = new RadioButton();
					this.m_cbx_WebColorsOnly = new CheckBox();
					this.m_lbl_HexPound = new Label();
					this.m_rbtn_L = new RadioButton();
					this.m_rbtn_a = new RadioButton();
					this.m_rbtn_b = new RadioButton();
					this.m_lbl_Cyan = new Label();
					this.m_lbl_Magenta = new Label();
					this.m_lbl_Yellow = new Label();
					this.m_lbl_K = new Label();
					this.m_lbl_Primary_Color = new Label();
					this.m_lbl_Secondary_Color = new Label();
					this.m_ctrl_ThinBox = new GClass47.ColorPicker.Control0.ctrl1DColorBar();
					this.m_ctrl_BigBox = new GClass47.ColorPicker.Control0.ctrl2DColorBox();
					this.m_lbl_Hue_Symbol = new Label();
					this.m_lbl_Saturation_Symbol = new Label();
					this.m_lbl_Black_Symbol = new Label();
					this.m_lbl_Cyan_Symbol = new Label();
					this.m_lbl_Magenta_Symbol = new Label();
					this.m_lbl_Yellow_Symbol = new Label();
					this.m_lbl_Key_Symbol = new Label();
					base.SuspendLayout();
					this.m_lbl_SelectColor.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_lbl_SelectColor.Location = new Point(10, 10);
					this.m_lbl_SelectColor.Name = "m_lbl_SelectColor";
					this.m_lbl_SelectColor.Size = new Size(260, 20);
					this.m_lbl_SelectColor.TabIndex = 0;
					this.m_lbl_SelectColor.Text = "Select Color:";
					this.m_pbx_BlankBox.BackColor = Color.Black;
					this.m_pbx_BlankBox.BorderStyle = BorderStyle.Fixed3D;
					this.m_pbx_BlankBox.Location = new Point(316, 30);
					this.m_pbx_BlankBox.Name = "m_pbx_BlankBox";
					this.m_pbx_BlankBox.Size = new Size(62, 70);
					this.m_pbx_BlankBox.TabIndex = 3;
					this.m_pbx_BlankBox.TabStop = false;
					this.m_cmd_OK.FlatStyle = FlatStyle.System;
					this.m_cmd_OK.Location = new Point(412, 11);
					this.m_cmd_OK.Name = "m_cmd_OK";
					this.m_cmd_OK.Size = new Size(72, 23);
					this.m_cmd_OK.TabIndex = 4;
					this.m_cmd_OK.Text = "&OK";
					this.m_cmd_OK.Click += this.m_cmd_OK_Click;
					this.m_cmd_Cancel.DialogResult = DialogResult.Cancel;
					this.m_cmd_Cancel.FlatStyle = FlatStyle.System;
					this.m_cmd_Cancel.Location = new Point(412, 43);
					this.m_cmd_Cancel.Name = "m_cmd_Cancel";
					this.m_cmd_Cancel.Size = new Size(72, 23);
					this.m_cmd_Cancel.TabIndex = 5;
					this.m_cmd_Cancel.Text = "&Cancel";
					this.m_cmd_Cancel.Click += this.m_cmd_Cancel_Click;
					this.m_txt_Hue.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_txt_Hue.Location = new Point(351, 115);
					this.m_txt_Hue.Name = "m_txt_Hue";
					this.m_txt_Hue.Size = new Size(35, 21);
					this.m_txt_Hue.TabIndex = 6;
					this.m_txt_Hue.Text = "";
					this.m_txt_Hue.Leave += this.m_txt_Hue_Leave;
					this.m_txt_Sat.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_txt_Sat.Location = new Point(351, 140);
					this.m_txt_Sat.Name = "m_txt_Sat";
					this.m_txt_Sat.Size = new Size(35, 21);
					this.m_txt_Sat.TabIndex = 7;
					this.m_txt_Sat.Text = "";
					this.m_txt_Sat.Leave += this.m_txt_Sat_Leave;
					this.m_txt_Black.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_txt_Black.Location = new Point(351, 165);
					this.m_txt_Black.Name = "m_txt_Black";
					this.m_txt_Black.Size = new Size(35, 21);
					this.m_txt_Black.TabIndex = 8;
					this.m_txt_Black.Text = "";
					this.m_txt_Black.Leave += this.m_txt_Black_Leave;
					this.m_txt_Red.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_txt_Red.Location = new Point(351, 195);
					this.m_txt_Red.Name = "m_txt_Red";
					this.m_txt_Red.Size = new Size(35, 21);
					this.m_txt_Red.TabIndex = 9;
					this.m_txt_Red.Text = "";
					this.m_txt_Red.Leave += this.m_txt_Red_Leave;
					this.m_txt_Green.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_txt_Green.Location = new Point(351, 220);
					this.m_txt_Green.Name = "m_txt_Green";
					this.m_txt_Green.Size = new Size(35, 21);
					this.m_txt_Green.TabIndex = 10;
					this.m_txt_Green.Text = "";
					this.m_txt_Green.Leave += this.m_txt_Green_Leave;
					this.m_txt_Blue.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_txt_Blue.Location = new Point(351, 245);
					this.m_txt_Blue.Name = "m_txt_Blue";
					this.m_txt_Blue.Size = new Size(35, 21);
					this.m_txt_Blue.TabIndex = 11;
					this.m_txt_Blue.Text = "";
					this.m_txt_Blue.Leave += this.m_txt_Blue_Leave;
					this.m_txt_Lum.Enabled = false;
					this.m_txt_Lum.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_txt_Lum.Location = new Point(445, 115);
					this.m_txt_Lum.Name = "m_txt_Lum";
					this.m_txt_Lum.Size = new Size(35, 21);
					this.m_txt_Lum.TabIndex = 12;
					this.m_txt_Lum.Text = "";
					this.m_txt_a.Enabled = false;
					this.m_txt_a.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_txt_a.Location = new Point(445, 140);
					this.m_txt_a.Name = "m_txt_a";
					this.m_txt_a.Size = new Size(35, 21);
					this.m_txt_a.TabIndex = 13;
					this.m_txt_a.Text = "";
					this.m_txt_b.Enabled = false;
					this.m_txt_b.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_txt_b.Location = new Point(445, 165);
					this.m_txt_b.Name = "m_txt_b";
					this.m_txt_b.Size = new Size(35, 21);
					this.m_txt_b.TabIndex = 14;
					this.m_txt_b.Text = "";
					this.m_txt_Cyan.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_txt_Cyan.Location = new Point(445, 195);
					this.m_txt_Cyan.Name = "m_txt_Cyan";
					this.m_txt_Cyan.Size = new Size(35, 21);
					this.m_txt_Cyan.TabIndex = 15;
					this.m_txt_Cyan.Text = "";
					this.m_txt_Cyan.Leave += this.m_txt_Cyan_Leave;
					this.m_txt_Magenta.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_txt_Magenta.Location = new Point(445, 220);
					this.m_txt_Magenta.Name = "m_txt_Magenta";
					this.m_txt_Magenta.Size = new Size(35, 21);
					this.m_txt_Magenta.TabIndex = 16;
					this.m_txt_Magenta.Text = "";
					this.m_txt_Magenta.Leave += this.m_txt_Magenta_Leave;
					this.m_txt_Yellow.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_txt_Yellow.Location = new Point(445, 245);
					this.m_txt_Yellow.Name = "m_txt_Yellow";
					this.m_txt_Yellow.Size = new Size(35, 21);
					this.m_txt_Yellow.TabIndex = 17;
					this.m_txt_Yellow.Text = "";
					this.m_txt_Yellow.Leave += this.m_txt_Yellow_Leave;
					this.m_txt_K.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_txt_K.Location = new Point(445, 270);
					this.m_txt_K.Name = "m_txt_K";
					this.m_txt_K.Size = new Size(35, 21);
					this.m_txt_K.TabIndex = 18;
					this.m_txt_K.Text = "";
					this.m_txt_K.Leave += this.m_txt_K_Leave;
					this.m_txt_Hex.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_txt_Hex.Location = new Point(334, 278);
					this.m_txt_Hex.Name = "m_txt_Hex";
					this.m_txt_Hex.Size = new Size(56, 21);
					this.m_txt_Hex.TabIndex = 19;
					this.m_txt_Hex.Text = "";
					this.m_txt_Hex.Leave += this.m_txt_Hex_Leave;
					this.m_rbtn_Hue.FlatStyle = FlatStyle.System;
					this.m_rbtn_Hue.Location = new Point(314, 115);
					this.m_rbtn_Hue.Name = "m_rbtn_Hue";
					this.m_rbtn_Hue.Size = new Size(35, 24);
					this.m_rbtn_Hue.TabIndex = 20;
					this.m_rbtn_Hue.Text = "H:";
					this.m_rbtn_Hue.CheckedChanged += this.m_rbtn_Hue_CheckedChanged;
					this.m_rbtn_Sat.FlatStyle = FlatStyle.System;
					this.m_rbtn_Sat.Location = new Point(314, 140);
					this.m_rbtn_Sat.Name = "m_rbtn_Sat";
					this.m_rbtn_Sat.Size = new Size(35, 24);
					this.m_rbtn_Sat.TabIndex = 21;
					this.m_rbtn_Sat.Text = "S:";
					this.m_rbtn_Sat.CheckedChanged += this.m_rbtn_Sat_CheckedChanged;
					this.m_rbtn_Black.FlatStyle = FlatStyle.System;
					this.m_rbtn_Black.Location = new Point(314, 165);
					this.m_rbtn_Black.Name = "m_rbtn_Black";
					this.m_rbtn_Black.Size = new Size(35, 24);
					this.m_rbtn_Black.TabIndex = 22;
					this.m_rbtn_Black.Text = "B:";
					this.m_rbtn_Black.CheckedChanged += this.m_rbtn_Black_CheckedChanged;
					this.m_rbtn_Red.FlatStyle = FlatStyle.System;
					this.m_rbtn_Red.Location = new Point(314, 195);
					this.m_rbtn_Red.Name = "m_rbtn_Red";
					this.m_rbtn_Red.Size = new Size(35, 24);
					this.m_rbtn_Red.TabIndex = 23;
					this.m_rbtn_Red.Text = "R:";
					this.m_rbtn_Red.CheckedChanged += this.m_rbtn_Red_CheckedChanged;
					this.m_rbtn_Green.FlatStyle = FlatStyle.System;
					this.m_rbtn_Green.Location = new Point(314, 220);
					this.m_rbtn_Green.Name = "m_rbtn_Green";
					this.m_rbtn_Green.Size = new Size(35, 24);
					this.m_rbtn_Green.TabIndex = 24;
					this.m_rbtn_Green.Text = "G:";
					this.m_rbtn_Green.CheckedChanged += this.m_rbtn_Green_CheckedChanged;
					this.m_rbtn_Blue.FlatStyle = FlatStyle.System;
					this.m_rbtn_Blue.Location = new Point(314, 245);
					this.m_rbtn_Blue.Name = "m_rbtn_Blue";
					this.m_rbtn_Blue.Size = new Size(35, 24);
					this.m_rbtn_Blue.TabIndex = 25;
					this.m_rbtn_Blue.Text = "B:";
					this.m_rbtn_Blue.CheckedChanged += this.m_rbtn_Blue_CheckedChanged;
					this.m_cbx_WebColorsOnly.Enabled = false;
					this.m_cbx_WebColorsOnly.Location = new Point(10, 296);
					this.m_cbx_WebColorsOnly.Name = "m_cbx_WebColorsOnly";
					this.m_cbx_WebColorsOnly.Size = new Size(248, 24);
					this.m_cbx_WebColorsOnly.TabIndex = 26;
					this.m_cbx_WebColorsOnly.Text = "Only Web Colors (Not fixed yet)";
					this.m_cbx_WebColorsOnly.Visible = false;
					this.m_lbl_HexPound.Location = new Point(318, 282);
					this.m_lbl_HexPound.Name = "m_lbl_HexPound";
					this.m_lbl_HexPound.Size = new Size(16, 14);
					this.m_lbl_HexPound.TabIndex = 27;
					this.m_lbl_HexPound.Text = "#";
					this.m_rbtn_L.Enabled = false;
					this.m_rbtn_L.FlatStyle = FlatStyle.System;
					this.m_rbtn_L.Location = new Point(408, 115);
					this.m_rbtn_L.Name = "m_rbtn_L";
					this.m_rbtn_L.Size = new Size(35, 24);
					this.m_rbtn_L.TabIndex = 28;
					this.m_rbtn_L.Text = "L:";
					this.m_rbtn_a.Enabled = false;
					this.m_rbtn_a.FlatStyle = FlatStyle.System;
					this.m_rbtn_a.Location = new Point(408, 140);
					this.m_rbtn_a.Name = "m_rbtn_a";
					this.m_rbtn_a.Size = new Size(35, 24);
					this.m_rbtn_a.TabIndex = 29;
					this.m_rbtn_a.Text = "a:";
					this.m_rbtn_b.Enabled = false;
					this.m_rbtn_b.FlatStyle = FlatStyle.System;
					this.m_rbtn_b.Location = new Point(408, 165);
					this.m_rbtn_b.Name = "m_rbtn_b";
					this.m_rbtn_b.Size = new Size(35, 24);
					this.m_rbtn_b.TabIndex = 30;
					this.m_rbtn_b.Text = "b:";
					this.m_lbl_Cyan.Location = new Point(428, 200);
					this.m_lbl_Cyan.Name = "m_lbl_Cyan";
					this.m_lbl_Cyan.Size = new Size(16, 16);
					this.m_lbl_Cyan.TabIndex = 31;
					this.m_lbl_Cyan.Text = "C:";
					this.m_lbl_Magenta.Location = new Point(428, 224);
					this.m_lbl_Magenta.Name = "m_lbl_Magenta";
					this.m_lbl_Magenta.Size = new Size(16, 16);
					this.m_lbl_Magenta.TabIndex = 32;
					this.m_lbl_Magenta.Text = "M:";
					this.m_lbl_Yellow.Location = new Point(428, 248);
					this.m_lbl_Yellow.Name = "m_lbl_Yellow";
					this.m_lbl_Yellow.Size = new Size(16, 16);
					this.m_lbl_Yellow.TabIndex = 33;
					this.m_lbl_Yellow.Text = "Y:";
					this.m_lbl_K.Location = new Point(428, 272);
					this.m_lbl_K.Name = "m_lbl_K";
					this.m_lbl_K.Size = new Size(16, 16);
					this.m_lbl_K.TabIndex = 34;
					this.m_lbl_K.Text = "K:";
					this.m_lbl_Primary_Color.Location = new Point(317, 31);
					this.m_lbl_Primary_Color.Name = "m_lbl_Primary_Color";
					this.m_lbl_Primary_Color.Size = new Size(60, 34);
					this.m_lbl_Primary_Color.TabIndex = 36;
					this.m_lbl_Primary_Color.Click += this.m_lbl_Primary_Color_Click;
					this.m_lbl_Secondary_Color.Location = new Point(317, 65);
					this.m_lbl_Secondary_Color.Name = "m_lbl_Secondary_Color";
					this.m_lbl_Secondary_Color.Size = new Size(60, 34);
					this.m_lbl_Secondary_Color.TabIndex = 37;
					this.m_lbl_Secondary_Color.Click += this.m_lbl_Secondary_Color_Click;
					this.m_ctrl_ThinBox.method_3(GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_0);
					this.m_ctrl_ThinBox.Location = new Point(271, 28);
					this.m_ctrl_ThinBox.Name = "m_ctrl_ThinBox";
					this.m_ctrl_ThinBox.method_7(Color.Red);
					this.m_ctrl_ThinBox.Size = new Size(40, 264);
					this.m_ctrl_ThinBox.TabIndex = 38;
					this.m_ctrl_ThinBox.method_0(new EventHandler(this.method_1));
					this.m_ctrl_BigBox.method_3(GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_0);
					this.m_ctrl_BigBox.Location = new Point(10, 30);
					this.m_ctrl_BigBox.Name = "m_ctrl_BigBox";
					this.m_ctrl_BigBox.method_7(Color.FromArgb(255, 0, 0));
					this.m_ctrl_BigBox.Size = new Size(260, 260);
					this.m_ctrl_BigBox.TabIndex = 39;
					this.m_ctrl_BigBox.method_0(new EventHandler(this.method_0));
					this.m_lbl_Hue_Symbol.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_lbl_Hue_Symbol.Location = new Point(387, 115);
					this.m_lbl_Hue_Symbol.Name = "m_lbl_Hue_Symbol";
					this.m_lbl_Hue_Symbol.Size = new Size(16, 21);
					this.m_lbl_Hue_Symbol.TabIndex = 40;
					this.m_lbl_Hue_Symbol.Text = "°";
					this.m_lbl_Saturation_Symbol.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_lbl_Saturation_Symbol.Location = new Point(387, 140);
					this.m_lbl_Saturation_Symbol.Name = "m_lbl_Saturation_Symbol";
					this.m_lbl_Saturation_Symbol.Size = new Size(16, 21);
					this.m_lbl_Saturation_Symbol.TabIndex = 41;
					this.m_lbl_Saturation_Symbol.Text = "%";
					this.m_lbl_Black_Symbol.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_lbl_Black_Symbol.Location = new Point(387, 165);
					this.m_lbl_Black_Symbol.Name = "m_lbl_Black_Symbol";
					this.m_lbl_Black_Symbol.Size = new Size(16, 21);
					this.m_lbl_Black_Symbol.TabIndex = 42;
					this.m_lbl_Black_Symbol.Text = "%";
					this.m_lbl_Cyan_Symbol.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_lbl_Cyan_Symbol.Location = new Point(481, 195);
					this.m_lbl_Cyan_Symbol.Name = "m_lbl_Cyan_Symbol";
					this.m_lbl_Cyan_Symbol.Size = new Size(16, 21);
					this.m_lbl_Cyan_Symbol.TabIndex = 43;
					this.m_lbl_Cyan_Symbol.Text = "%";
					this.m_lbl_Magenta_Symbol.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_lbl_Magenta_Symbol.Location = new Point(481, 220);
					this.m_lbl_Magenta_Symbol.Name = "m_lbl_Magenta_Symbol";
					this.m_lbl_Magenta_Symbol.Size = new Size(16, 21);
					this.m_lbl_Magenta_Symbol.TabIndex = 44;
					this.m_lbl_Magenta_Symbol.Text = "%";
					this.m_lbl_Yellow_Symbol.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_lbl_Yellow_Symbol.Location = new Point(481, 245);
					this.m_lbl_Yellow_Symbol.Name = "m_lbl_Yellow_Symbol";
					this.m_lbl_Yellow_Symbol.Size = new Size(16, 21);
					this.m_lbl_Yellow_Symbol.TabIndex = 45;
					this.m_lbl_Yellow_Symbol.Text = "%";
					this.m_lbl_Key_Symbol.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
					this.m_lbl_Key_Symbol.Location = new Point(481, 270);
					this.m_lbl_Key_Symbol.Name = "m_lbl_Key_Symbol";
					this.m_lbl_Key_Symbol.TabIndex = 0;
					this.m_lbl_Key_Symbol.Text = "%";
					base.AcceptButton = this.m_cmd_OK;
					this.AutoScaleBaseSize = new Size(5, 13);
					base.CancelButton = this.m_cmd_Cancel;
					base.ClientSize = new Size(504, 321);
					base.Controls.Add(this.m_lbl_Key_Symbol);
					base.Controls.Add(this.m_lbl_Yellow_Symbol);
					base.Controls.Add(this.m_lbl_Magenta_Symbol);
					base.Controls.Add(this.m_lbl_Cyan_Symbol);
					base.Controls.Add(this.m_lbl_Black_Symbol);
					base.Controls.Add(this.m_lbl_Saturation_Symbol);
					base.Controls.Add(this.m_lbl_Hue_Symbol);
					base.Controls.Add(this.m_ctrl_BigBox);
					base.Controls.Add(this.m_ctrl_ThinBox);
					base.Controls.Add(this.m_txt_Hex);
					base.Controls.Add(this.m_txt_K);
					base.Controls.Add(this.m_txt_Yellow);
					base.Controls.Add(this.m_txt_Magenta);
					base.Controls.Add(this.m_txt_Cyan);
					base.Controls.Add(this.m_txt_b);
					base.Controls.Add(this.m_txt_a);
					base.Controls.Add(this.m_txt_Lum);
					base.Controls.Add(this.m_txt_Blue);
					base.Controls.Add(this.m_txt_Green);
					base.Controls.Add(this.m_txt_Red);
					base.Controls.Add(this.m_txt_Black);
					base.Controls.Add(this.m_txt_Sat);
					base.Controls.Add(this.m_txt_Hue);
					base.Controls.Add(this.m_lbl_Secondary_Color);
					base.Controls.Add(this.m_lbl_Primary_Color);
					base.Controls.Add(this.m_lbl_K);
					base.Controls.Add(this.m_lbl_Yellow);
					base.Controls.Add(this.m_lbl_Magenta);
					base.Controls.Add(this.m_lbl_Cyan);
					base.Controls.Add(this.m_rbtn_b);
					base.Controls.Add(this.m_rbtn_a);
					base.Controls.Add(this.m_rbtn_L);
					base.Controls.Add(this.m_lbl_HexPound);
					base.Controls.Add(this.m_cbx_WebColorsOnly);
					base.Controls.Add(this.m_rbtn_Blue);
					base.Controls.Add(this.m_rbtn_Green);
					base.Controls.Add(this.m_rbtn_Red);
					base.Controls.Add(this.m_rbtn_Black);
					base.Controls.Add(this.m_rbtn_Sat);
					base.Controls.Add(this.m_rbtn_Hue);
					base.Controls.Add(this.m_cmd_Cancel);
					base.Controls.Add(this.m_cmd_OK);
					base.Controls.Add(this.m_pbx_BlankBox);
					base.Controls.Add(this.m_lbl_SelectColor);
					this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					base.FormBorderStyle = FormBorderStyle.FixedDialog;
					base.MaximizeBox = false;
					base.MinimizeBox = false;
					base.Name = "frmColorPicker";
					base.ShowInTaskbar = false;
					base.StartPosition = FormStartPosition.CenterScreen;
					this.Text = "Color Picker";
					base.TopMost = true;
					base.Load += this.frmColorPicker_Load;
					base.ResumeLayout(false);
				}

				void frmColorPicker_Load(object sender, EventArgs e)
				{
				}

				void m_cmd_OK_Click(object sender, EventArgs e)
				{
					base.DialogResult = DialogResult.OK;
					base.Close();
				}

				void m_cmd_Cancel_Click(object sender, EventArgs e)
				{
					base.DialogResult = DialogResult.Cancel;
					base.Close();
				}

				void method_0(object sender, EventArgs e)
				{
					this.class50_0 = this.m_ctrl_BigBox.method_4();
					this.color_0 = GClass47.ColorPicker.Control0.Class49.smethod_6(this.class50_0);
					this.class51_0 = GClass47.ColorPicker.Control0.Class49.smethod_8(this.color_0);
					this.m_txt_Hue.Text = this.method_2(this.class50_0.method_0() * 360.0).ToString();
					this.m_txt_Sat.Text = this.method_2(this.class50_0.method_2() * 100.0).ToString();
					this.m_txt_Black.Text = this.method_2(this.class50_0.method_4() * 100.0).ToString();
					this.m_txt_Red.Text = this.color_0.R.ToString();
					this.m_txt_Green.Text = this.color_0.G.ToString();
					this.m_txt_Blue.Text = this.color_0.B.ToString();
					this.m_txt_Cyan.Text = this.method_2(this.class51_0.method_0() * 100.0).ToString();
					this.m_txt_Magenta.Text = this.method_2(this.class51_0.method_2() * 100.0).ToString();
					this.m_txt_Yellow.Text = this.method_2(this.class51_0.method_4() * 100.0).ToString();
					this.m_txt_K.Text = this.method_2(this.class51_0.method_6() * 100.0).ToString();
					this.m_txt_Hue.Update();
					this.m_txt_Sat.Update();
					this.m_txt_Black.Update();
					this.m_txt_Red.Update();
					this.m_txt_Green.Update();
					this.m_txt_Blue.Update();
					this.m_txt_Cyan.Update();
					this.m_txt_Magenta.Update();
					this.m_txt_Yellow.Update();
					this.m_txt_K.Update();
					this.m_ctrl_ThinBox.method_5(this.class50_0);
					this.m_lbl_Primary_Color.BackColor = this.color_0;
					this.m_lbl_Primary_Color.Update();
					this.method_3(this.color_0);
				}

				void method_1(object sender, EventArgs e)
				{
					this.class50_0 = this.m_ctrl_ThinBox.method_4();
					this.color_0 = GClass47.ColorPicker.Control0.Class49.smethod_6(this.class50_0);
					this.class51_0 = GClass47.ColorPicker.Control0.Class49.smethod_8(this.color_0);
					this.m_txt_Hue.Text = this.method_2(this.class50_0.method_0() * 360.0).ToString();
					this.m_txt_Sat.Text = this.method_2(this.class50_0.method_2() * 100.0).ToString();
					this.m_txt_Black.Text = this.method_2(this.class50_0.method_4() * 100.0).ToString();
					this.m_txt_Red.Text = this.color_0.R.ToString();
					this.m_txt_Green.Text = this.color_0.G.ToString();
					this.m_txt_Blue.Text = this.color_0.B.ToString();
					this.m_txt_Cyan.Text = this.method_2(this.class51_0.method_0() * 100.0).ToString();
					this.m_txt_Magenta.Text = this.method_2(this.class51_0.method_2() * 100.0).ToString();
					this.m_txt_Yellow.Text = this.method_2(this.class51_0.method_4() * 100.0).ToString();
					this.m_txt_K.Text = this.method_2(this.class51_0.method_6() * 100.0).ToString();
					this.m_txt_Hue.Update();
					this.m_txt_Sat.Update();
					this.m_txt_Black.Update();
					this.m_txt_Red.Update();
					this.m_txt_Green.Update();
					this.m_txt_Blue.Update();
					this.m_txt_Cyan.Update();
					this.m_txt_Magenta.Update();
					this.m_txt_Yellow.Update();
					this.m_txt_K.Update();
					this.m_ctrl_BigBox.method_5(this.class50_0);
					this.m_lbl_Primary_Color.BackColor = this.color_0;
					this.m_lbl_Primary_Color.Update();
					this.method_3(this.color_0);
				}

				void m_txt_Hex_Leave(object sender, EventArgs e)
				{
					string text = this.m_txt_Hex.Text.ToUpper();
					bool flag = false;
					if (text.Length <= 0)
					{
						flag = true;
					}
					string text2 = text;
					int i = 0;
					while (i < text2.Length)
					{
						char c = text2[i];
						if (char.IsNumber(c) || (c >= 'A' && c <= 'F'))
						{
							i++;
						}
						else
						{
							flag = true;

							if (flag)
							{
								MessageBox.Show("Hex must be a hex value between 0x000000 and 0xFFFFFF");
								this.method_3(this.color_0);
								return;
							}
							this.color_0 = this.method_4(text);
							this.class50_0 = GClass47.ColorPicker.Control0.Class49.smethod_7(this.color_0);
							this.class51_0 = GClass47.ColorPicker.Control0.Class49.smethod_8(this.color_0);
							this.m_ctrl_BigBox.method_5(this.class50_0);
							this.m_ctrl_ThinBox.method_5(this.class50_0);
							this.m_lbl_Primary_Color.BackColor = this.color_0;
							this.method_5();
							return;
						}
					}

                    if (flag)
                    {
                        MessageBox.Show("Hex must be a hex value between 0x000000 and 0xFFFFFF");
                        this.method_3(this.color_0);
                        return;
                    }
                    this.color_0 = this.method_4(text);
                    this.class50_0 = GClass47.ColorPicker.Control0.Class49.smethod_7(this.color_0);
                    this.class51_0 = GClass47.ColorPicker.Control0.Class49.smethod_8(this.color_0);
                    this.m_ctrl_BigBox.method_5(this.class50_0);
                    this.m_ctrl_ThinBox.method_5(this.class50_0);
                    this.m_lbl_Primary_Color.BackColor = this.color_0;
                    this.method_5();
                    return;
                }

				void m_lbl_Primary_Color_Click(object sender, EventArgs e)
				{
					this.color_0 = this.m_lbl_Primary_Color.BackColor;
					this.class50_0 = GClass47.ColorPicker.Control0.Class49.smethod_7(this.color_0);
					this.m_ctrl_BigBox.method_5(this.class50_0);
					this.m_ctrl_ThinBox.method_5(this.class50_0);
					this.class51_0 = GClass47.ColorPicker.Control0.Class49.smethod_8(this.color_0);
					this.m_txt_Hue.Text = this.method_2(this.class50_0.method_0() * 360.0).ToString();
					this.m_txt_Sat.Text = this.method_2(this.class50_0.method_2() * 100.0).ToString();
					this.m_txt_Black.Text = this.method_2(this.class50_0.method_4() * 100.0).ToString();
					this.m_txt_Red.Text = this.color_0.R.ToString();
					this.m_txt_Green.Text = this.color_0.G.ToString();
					this.m_txt_Blue.Text = this.color_0.B.ToString();
					this.m_txt_Cyan.Text = this.method_2(this.class51_0.method_0() * 100.0).ToString();
					this.m_txt_Magenta.Text = this.method_2(this.class51_0.method_2() * 100.0).ToString();
					this.m_txt_Yellow.Text = this.method_2(this.class51_0.method_4() * 100.0).ToString();
					this.m_txt_K.Text = this.method_2(this.class51_0.method_6() * 100.0).ToString();
					this.m_txt_Hue.Update();
					this.m_txt_Sat.Update();
					this.m_txt_Lum.Update();
					this.m_txt_Red.Update();
					this.m_txt_Green.Update();
					this.m_txt_Blue.Update();
					this.m_txt_Cyan.Update();
					this.m_txt_Magenta.Update();
					this.m_txt_Yellow.Update();
					this.m_txt_K.Update();
				}

				void m_lbl_Secondary_Color_Click(object sender, EventArgs e)
				{
					this.color_0 = this.m_lbl_Secondary_Color.BackColor;
					this.class50_0 = GClass47.ColorPicker.Control0.Class49.smethod_7(this.color_0);
					this.m_ctrl_BigBox.method_5(this.class50_0);
					this.m_ctrl_ThinBox.method_5(this.class50_0);
					this.m_lbl_Primary_Color.BackColor = this.color_0;
					this.m_lbl_Primary_Color.Update();
					this.class51_0 = GClass47.ColorPicker.Control0.Class49.smethod_8(this.color_0);
					this.m_txt_Hue.Text = this.method_2(this.class50_0.method_0() * 360.0).ToString();
					this.m_txt_Sat.Text = this.method_2(this.class50_0.method_2() * 100.0).ToString();
					this.m_txt_Black.Text = this.method_2(this.class50_0.method_4() * 100.0).ToString();
					this.m_txt_Red.Text = this.color_0.R.ToString();
					this.m_txt_Green.Text = this.color_0.G.ToString();
					this.m_txt_Blue.Text = this.color_0.B.ToString();
					this.m_txt_Cyan.Text = this.method_2(this.class51_0.method_0() * 100.0).ToString();
					this.m_txt_Magenta.Text = this.method_2(this.class51_0.method_2() * 100.0).ToString();
					this.m_txt_Yellow.Text = this.method_2(this.class51_0.method_4() * 100.0).ToString();
					this.m_txt_K.Text = this.method_2(this.class51_0.method_6() * 100.0).ToString();
					this.m_txt_Hue.Update();
					this.m_txt_Sat.Update();
					this.m_txt_Lum.Update();
					this.m_txt_Red.Update();
					this.m_txt_Green.Update();
					this.m_txt_Blue.Update();
					this.m_txt_Cyan.Update();
					this.m_txt_Magenta.Update();
					this.m_txt_Yellow.Update();
					this.m_txt_K.Update();
				}

				void m_rbtn_Hue_CheckedChanged(object sender, EventArgs e)
				{
					if (this.m_rbtn_Hue.Checked)
					{
						this.m_ctrl_ThinBox.method_3(GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_0);
						this.m_ctrl_BigBox.method_3(GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_0);
					}
				}

				void m_rbtn_Sat_CheckedChanged(object sender, EventArgs e)
				{
					if (this.m_rbtn_Sat.Checked)
					{
						this.m_ctrl_ThinBox.method_3(GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_1);
						this.m_ctrl_BigBox.method_3(GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_1);
					}
				}

				void m_rbtn_Black_CheckedChanged(object sender, EventArgs e)
				{
					if (this.m_rbtn_Black.Checked)
					{
						this.m_ctrl_ThinBox.method_3(GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_2);
						this.m_ctrl_BigBox.method_3(GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_2);
					}
				}

				void m_rbtn_Red_CheckedChanged(object sender, EventArgs e)
				{
					if (this.m_rbtn_Red.Checked)
					{
						this.m_ctrl_ThinBox.method_3(GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_3);
						this.m_ctrl_BigBox.method_3(GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_3);
					}
				}

				void m_rbtn_Green_CheckedChanged(object sender, EventArgs e)
				{
					if (this.m_rbtn_Green.Checked)
					{
						this.m_ctrl_ThinBox.method_3(GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_4);
						this.m_ctrl_BigBox.method_3(GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_4);
					}
				}

				void m_rbtn_Blue_CheckedChanged(object sender, EventArgs e)
				{
					if (this.m_rbtn_Blue.Checked)
					{
						this.m_ctrl_ThinBox.method_3(GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_5);
						this.m_ctrl_BigBox.method_3(GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_5);
					}
				}

				void m_txt_Hue_Leave(object sender, EventArgs e)
				{
					string text = this.m_txt_Hue.Text;
					bool flag = false;
					if (text.Length <= 0)
					{
						flag = true;
					}
					else
					{
						foreach (char c in text)
						{
							if (!char.IsNumber(c))
							{
								flag = true;
								break;
							}
						}
					}
					if (flag)
					{
						MessageBox.Show("Hue must be a number value between 0 and 360");
						this.method_5();
						return;
					}
					int num = int.Parse(text);
					if (num < 0)
					{
						MessageBox.Show("An integer between 0 and 360 is required.\nClosest value inserted.");
						this.m_txt_Hue.Text = "0";
						this.class50_0.method_1(0.0);
					}
					else if (num > 360)
					{
						MessageBox.Show("An integer between 0 and 360 is required.\nClosest value inserted.");
						this.m_txt_Hue.Text = "360";
						this.class50_0.method_1(1.0);
					}
					else
					{
						this.class50_0.method_1((double)num / 360.0);
					}
					this.color_0 = GClass47.ColorPicker.Control0.Class49.smethod_6(this.class50_0);
					this.class51_0 = GClass47.ColorPicker.Control0.Class49.smethod_8(this.color_0);
					this.m_ctrl_BigBox.method_5(this.class50_0);
					this.m_ctrl_ThinBox.method_5(this.class50_0);
					this.m_lbl_Primary_Color.BackColor = this.color_0;
					this.method_5();
				}

				void m_txt_Sat_Leave(object sender, EventArgs e)
				{
					string text = this.m_txt_Sat.Text;
					bool flag = false;
					if (text.Length <= 0)
					{
						flag = true;
					}
					else
					{
						foreach (char c in text)
						{
							if (!char.IsNumber(c))
							{
								flag = true;
								break;
							}
						}
					}
					if (flag)
					{
						MessageBox.Show("Saturation must be a number value between 0 and 100");
						this.method_5();
						return;
					}
					int num = int.Parse(text);
					if (num < 0)
					{
						MessageBox.Show("An integer between 0 and 100 is required.\nClosest value inserted.");
						this.m_txt_Sat.Text = "0";
						this.class50_0.method_3(0.0);
					}
					else if (num > 100)
					{
						MessageBox.Show("An integer between 0 and 100 is required.\nClosest value inserted.");
						this.m_txt_Sat.Text = "100";
						this.class50_0.method_3(1.0);
					}
					else
					{
						this.class50_0.method_3((double)num / 100.0);
					}
					this.color_0 = GClass47.ColorPicker.Control0.Class49.smethod_6(this.class50_0);
					this.class51_0 = GClass47.ColorPicker.Control0.Class49.smethod_8(this.color_0);
					this.m_ctrl_BigBox.method_5(this.class50_0);
					this.m_ctrl_ThinBox.method_5(this.class50_0);
					this.m_lbl_Primary_Color.BackColor = this.color_0;
					this.method_5();
				}

				void m_txt_Black_Leave(object sender, EventArgs e)
				{
					string text = this.m_txt_Black.Text;
					bool flag = false;
					if (text.Length <= 0)
					{
						flag = true;
					}
					else
					{
						foreach (char c in text)
						{
							if (!char.IsNumber(c))
							{
								flag = true;
								break;
							}
						}
					}
					if (flag)
					{
						MessageBox.Show("Black must be a number value between 0 and 360");
						this.method_5();
						return;
					}
					int num = int.Parse(text);
					if (num < 0)
					{
						MessageBox.Show("An integer between 0 and 100 is required.\nClosest value inserted.");
						this.m_txt_Black.Text = "0";
						this.class50_0.method_5(0.0);
					}
					else if (num > 100)
					{
						MessageBox.Show("An integer between 0 and 100 is required.\nClosest value inserted.");
						this.m_txt_Black.Text = "100";
						this.class50_0.method_5(1.0);
					}
					else
					{
						this.class50_0.method_5((double)num / 100.0);
					}
					this.color_0 = GClass47.ColorPicker.Control0.Class49.smethod_6(this.class50_0);
					this.class51_0 = GClass47.ColorPicker.Control0.Class49.smethod_8(this.color_0);
					this.m_ctrl_BigBox.method_5(this.class50_0);
					this.m_ctrl_ThinBox.method_5(this.class50_0);
					this.m_lbl_Primary_Color.BackColor = this.color_0;
					this.method_5();
				}

				void m_txt_Red_Leave(object sender, EventArgs e)
				{
					string text = this.m_txt_Red.Text;
					bool flag = false;
					if (text.Length <= 0)
					{
						flag = true;
					}
					else
					{
						foreach (char c in text)
						{
							if (!char.IsNumber(c))
							{
								flag = true;
								break;
							}
						}
					}
					if (flag)
					{
						MessageBox.Show("Red must be a number value between 0 and 255");
						this.method_5();
						return;
					}
					int num = int.Parse(text);
					if (num < 0)
					{
						MessageBox.Show("An integer between 0 and 255 is required.\nClosest value inserted.");
						this.m_txt_Sat.Text = "0";
						this.color_0 = Color.FromArgb(0, (int)this.color_0.G, (int)this.color_0.B);
					}
					else if (num > 255)
					{
						MessageBox.Show("An integer between 0 and 255 is required.\nClosest value inserted.");
						this.m_txt_Sat.Text = "255";
						this.color_0 = Color.FromArgb(255, (int)this.color_0.G, (int)this.color_0.B);
					}
					else
					{
						this.color_0 = Color.FromArgb(num, (int)this.color_0.G, (int)this.color_0.B);
					}
					this.class50_0 = GClass47.ColorPicker.Control0.Class49.smethod_7(this.color_0);
					this.class51_0 = GClass47.ColorPicker.Control0.Class49.smethod_8(this.color_0);
					this.m_ctrl_BigBox.method_5(this.class50_0);
					this.m_ctrl_ThinBox.method_5(this.class50_0);
					this.m_lbl_Primary_Color.BackColor = this.color_0;
					this.method_5();
				}

				void m_txt_Green_Leave(object sender, EventArgs e)
				{
					string text = this.m_txt_Green.Text;
					bool flag = false;
					if (text.Length <= 0)
					{
						flag = true;
					}
					else
					{
						foreach (char c in text)
						{
							if (!char.IsNumber(c))
							{
								flag = true;
								break;
							}
						}
					}
					if (flag)
					{
						MessageBox.Show("Green must be a number value between 0 and 255");
						this.method_5();
						return;
					}
					int num = int.Parse(text);
					if (num < 0)
					{
						MessageBox.Show("An integer between 0 and 255 is required.\nClosest value inserted.");
						this.m_txt_Green.Text = "0";
						this.color_0 = Color.FromArgb((int)this.color_0.R, 0, (int)this.color_0.B);
					}
					else if (num > 255)
					{
						MessageBox.Show("An integer between 0 and 255 is required.\nClosest value inserted.");
						this.m_txt_Green.Text = "255";
						this.color_0 = Color.FromArgb((int)this.color_0.R, 255, (int)this.color_0.B);
					}
					else
					{
						this.color_0 = Color.FromArgb((int)this.color_0.R, num, (int)this.color_0.B);
					}
					this.class50_0 = GClass47.ColorPicker.Control0.Class49.smethod_7(this.color_0);
					this.class51_0 = GClass47.ColorPicker.Control0.Class49.smethod_8(this.color_0);
					this.m_ctrl_BigBox.method_5(this.class50_0);
					this.m_ctrl_ThinBox.method_5(this.class50_0);
					this.m_lbl_Primary_Color.BackColor = this.color_0;
					this.method_5();
				}

				void m_txt_Blue_Leave(object sender, EventArgs e)
				{
					string text = this.m_txt_Blue.Text;
					bool flag = false;
					if (text.Length <= 0)
					{
						flag = true;
					}
					else
					{
						foreach (char c in text)
						{
							if (!char.IsNumber(c))
							{
								flag = true;
								break;
							}
						}
					}
					if (flag)
					{
						MessageBox.Show("Blue must be a number value between 0 and 255");
						this.method_5();
						return;
					}
					int num = int.Parse(text);
					if (num < 0)
					{
						MessageBox.Show("An integer between 0 and 255 is required.\nClosest value inserted.");
						this.m_txt_Blue.Text = "0";
						this.color_0 = Color.FromArgb((int)this.color_0.R, (int)this.color_0.G, 0);
					}
					else if (num > 255)
					{
						MessageBox.Show("An integer between 0 and 255 is required.\nClosest value inserted.");
						this.m_txt_Blue.Text = "255";
						this.color_0 = Color.FromArgb((int)this.color_0.R, (int)this.color_0.G, 255);
					}
					else
					{
						this.color_0 = Color.FromArgb((int)this.color_0.R, (int)this.color_0.G, num);
					}
					this.class50_0 = GClass47.ColorPicker.Control0.Class49.smethod_7(this.color_0);
					this.class51_0 = GClass47.ColorPicker.Control0.Class49.smethod_8(this.color_0);
					this.m_ctrl_BigBox.method_5(this.class50_0);
					this.m_ctrl_ThinBox.method_5(this.class50_0);
					this.m_lbl_Primary_Color.BackColor = this.color_0;
					this.method_5();
				}

				void m_txt_Cyan_Leave(object sender, EventArgs e)
				{
					string text = this.m_txt_Cyan.Text;
					bool flag = false;
					if (text.Length <= 0)
					{
						flag = true;
					}
					else
					{
						foreach (char c in text)
						{
							if (!char.IsNumber(c))
							{
								flag = true;
								break;
							}
						}
					}
					if (flag)
					{
						MessageBox.Show("Cyan must be a number value between 0 and 100");
						this.method_5();
						return;
					}
					int num = int.Parse(text);
					if (num < 0)
					{
						MessageBox.Show("An integer between 0 and 100 is required.\nClosest value inserted.");
						this.class51_0.method_1(0.0);
					}
					else if (num > 100)
					{
						MessageBox.Show("An integer between 0 and 100 is required.\nClosest value inserted.");
						this.class51_0.method_1(1.0);
					}
					else
					{
						this.class51_0.method_1((double)num / 100.0);
					}
					this.color_0 = GClass47.ColorPicker.Control0.Class49.smethod_9(this.class51_0);
					this.class50_0 = GClass47.ColorPicker.Control0.Class49.smethod_7(this.color_0);
					this.m_ctrl_BigBox.method_5(this.class50_0);
					this.m_ctrl_ThinBox.method_5(this.class50_0);
					this.m_lbl_Primary_Color.BackColor = this.color_0;
					this.method_5();
				}

				void m_txt_Magenta_Leave(object sender, EventArgs e)
				{
					string text = this.m_txt_Magenta.Text;
					bool flag = false;
					if (text.Length <= 0)
					{
						flag = true;
					}
					else
					{
						foreach (char c in text)
						{
							if (!char.IsNumber(c))
							{
								flag = true;
								break;
							}
						}
					}
					if (flag)
					{
						MessageBox.Show("Magenta must be a number value between 0 and 100");
						this.method_5();
						return;
					}
					int num = int.Parse(text);
					if (num < 0)
					{
						MessageBox.Show("An integer between 0 and 100 is required.\nClosest value inserted.");
						this.m_txt_Magenta.Text = "0";
						this.class51_0.method_3(0.0);
					}
					else if (num > 100)
					{
						MessageBox.Show("An integer between 0 and 100 is required.\nClosest value inserted.");
						this.m_txt_Magenta.Text = "100";
						this.class51_0.method_3(1.0);
					}
					else
					{
						this.class51_0.method_3((double)num / 100.0);
					}
					this.color_0 = GClass47.ColorPicker.Control0.Class49.smethod_9(this.class51_0);
					this.class50_0 = GClass47.ColorPicker.Control0.Class49.smethod_7(this.color_0);
					this.m_ctrl_BigBox.method_5(this.class50_0);
					this.m_ctrl_ThinBox.method_5(this.class50_0);
					this.m_lbl_Primary_Color.BackColor = this.color_0;
					this.method_5();
				}

				void m_txt_Yellow_Leave(object sender, EventArgs e)
				{
					string text = this.m_txt_Yellow.Text;
					bool flag = false;
					if (text.Length <= 0)
					{
						flag = true;
					}
					else
					{
						foreach (char c in text)
						{
							if (!char.IsNumber(c))
							{
								flag = true;
								break;
							}
						}
					}
					if (flag)
					{
						MessageBox.Show("Yellow must be a number value between 0 and 100");
						this.method_5();
						return;
					}
					int num = int.Parse(text);
					if (num < 0)
					{
						MessageBox.Show("An integer between 0 and 100 is required.\nClosest value inserted.");
						this.m_txt_Yellow.Text = "0";
						this.class51_0.method_5(0.0);
					}
					else if (num > 100)
					{
						MessageBox.Show("An integer between 0 and 100 is required.\nClosest value inserted.");
						this.m_txt_Yellow.Text = "100";
						this.class51_0.method_5(1.0);
					}
					else
					{
						this.class51_0.method_5((double)num / 100.0);
					}
					this.color_0 = GClass47.ColorPicker.Control0.Class49.smethod_9(this.class51_0);
					this.class50_0 = GClass47.ColorPicker.Control0.Class49.smethod_7(this.color_0);
					this.m_ctrl_BigBox.method_5(this.class50_0);
					this.m_ctrl_ThinBox.method_5(this.class50_0);
					this.m_lbl_Primary_Color.BackColor = this.color_0;
					this.method_5();
				}

				void m_txt_K_Leave(object sender, EventArgs e)
				{
					string text = this.m_txt_K.Text;
					bool flag = false;
					if (text.Length <= 0)
					{
						flag = true;
					}
					else
					{
						foreach (char c in text)
						{
							if (!char.IsNumber(c))
							{
								flag = true;
								break;
							}
						}
					}
					if (flag)
					{
						MessageBox.Show("Key must be a number value between 0 and 100");
						this.method_5();
						return;
					}
					int num = int.Parse(text);
					if (num < 0)
					{
						MessageBox.Show("An integer between 0 and 100 is required.\nClosest value inserted.");
						this.m_txt_K.Text = "0";
						this.class51_0.method_7(0.0);
					}
					else if (num > 100)
					{
						MessageBox.Show("An integer between 0 and 100 is required.\nClosest value inserted.");
						this.m_txt_K.Text = "100";
						this.class51_0.method_7(1.0);
					}
					else
					{
						this.class51_0.method_7((double)num / 100.0);
					}
					this.color_0 = GClass47.ColorPicker.Control0.Class49.smethod_9(this.class51_0);
					this.class50_0 = GClass47.ColorPicker.Control0.Class49.smethod_7(this.color_0);
					this.m_ctrl_BigBox.method_5(this.class50_0);
					this.m_ctrl_ThinBox.method_5(this.class50_0);
					this.m_lbl_Primary_Color.BackColor = this.color_0;
					this.method_5();
				}

				int method_2(double double_0)
				{
					int num = (int)double_0;
					int num2 = (int)(double_0 * 100.0);
					if (num2 % 100 >= 50)
					{
						num++;
					}
					return num;
				}

				void method_3(Color color_1)
				{
					string text = Convert.ToString(color_1.R, 16);
					if (text.Length < 2)
					{
						text = "0" + text;
					}
					string text2 = Convert.ToString(color_1.G, 16);
					if (text2.Length < 2)
					{
						text2 = "0" + text2;
					}
					string text3 = Convert.ToString(color_1.B, 16);
					if (text3.Length < 2)
					{
						text3 = "0" + text3;
					}
					this.m_txt_Hex.Text = text.ToUpper() + text2.ToUpper() + text3.ToUpper();
					this.m_txt_Hex.Update();
				}

				Color method_4(string string_0)
				{
					if (string_0.Length != 6)
					{
						return Color.Black;
					}
					string s = string_0.Substring(0, 2);
					string s2 = string_0.Substring(2, 2);
					string s3 = string_0.Substring(4, 2);
					int red = int.Parse(s, NumberStyles.HexNumber);
					int green = int.Parse(s2, NumberStyles.HexNumber);
					int blue = int.Parse(s3, NumberStyles.HexNumber);
					return Color.FromArgb(red, green, blue);
				}

				void method_5()
				{
					this.m_txt_Hue.Text = this.method_2(this.class50_0.method_0() * 360.0).ToString();
					this.m_txt_Sat.Text = this.method_2(this.class50_0.method_2() * 100.0).ToString();
					this.m_txt_Black.Text = this.method_2(this.class50_0.method_4() * 100.0).ToString();
					this.m_txt_Cyan.Text = this.method_2(this.class51_0.method_0() * 100.0).ToString();
					this.m_txt_Magenta.Text = this.method_2(this.class51_0.method_2() * 100.0).ToString();
					this.m_txt_Yellow.Text = this.method_2(this.class51_0.method_4() * 100.0).ToString();
					this.m_txt_K.Text = this.method_2(this.class51_0.method_6() * 100.0).ToString();
					this.m_txt_Red.Text = this.color_0.R.ToString();
					this.m_txt_Green.Text = this.color_0.G.ToString();
					this.m_txt_Blue.Text = this.color_0.B.ToString();
					this.m_txt_Red.Update();
					this.m_txt_Green.Update();
					this.m_txt_Blue.Update();
					this.m_txt_Hue.Update();
					this.m_txt_Sat.Update();
					this.m_txt_Black.Update();
					this.m_txt_Cyan.Update();
					this.m_txt_Magenta.Update();
					this.m_txt_Yellow.Update();
					this.m_txt_K.Update();
					this.method_3(this.color_0);
				}

				public Color method_6()
				{
					return this.color_0;
				}

				public void method_7(Color color_1)
				{
					this.color_0 = color_1;
					this.class50_0 = GClass47.ColorPicker.Control0.Class49.smethod_7(this.color_0);
					this.m_txt_Hue.Text = this.method_2(this.class50_0.method_0() * 360.0).ToString();
					this.m_txt_Sat.Text = this.method_2(this.class50_0.method_2() * 100.0).ToString();
					this.m_txt_Black.Text = this.method_2(this.class50_0.method_4() * 100.0).ToString();
					this.m_txt_Red.Text = this.color_0.R.ToString();
					this.m_txt_Green.Text = this.color_0.G.ToString();
					this.m_txt_Blue.Text = this.color_0.B.ToString();
					this.m_txt_Hue.Update();
					this.m_txt_Sat.Update();
					this.m_txt_Lum.Update();
					this.m_txt_Red.Update();
					this.m_txt_Green.Update();
					this.m_txt_Blue.Update();
					this.m_ctrl_BigBox.method_5(this.class50_0);
					this.m_ctrl_ThinBox.method_5(this.class50_0);
					this.m_lbl_Primary_Color.BackColor = this.color_0;
				}

				public GClass47.ColorPicker.Control0.frmColorPicker.Enum2 method_8()
				{
					if (this.m_rbtn_Hue.Checked)
					{
						return GClass47.ColorPicker.Control0.frmColorPicker.Enum2.const_0;
					}
					if (this.m_rbtn_Sat.Checked)
					{
						return GClass47.ColorPicker.Control0.frmColorPicker.Enum2.const_1;
					}
					if (this.m_rbtn_Black.Checked)
					{
						return GClass47.ColorPicker.Control0.frmColorPicker.Enum2.const_2;
					}
					if (this.m_rbtn_Red.Checked)
					{
						return GClass47.ColorPicker.Control0.frmColorPicker.Enum2.const_3;
					}
					if (this.m_rbtn_Green.Checked)
					{
						return GClass47.ColorPicker.Control0.frmColorPicker.Enum2.const_4;
					}
					if (this.m_rbtn_Blue.Checked)
					{
						return GClass47.ColorPicker.Control0.frmColorPicker.Enum2.const_5;
					}
					return GClass47.ColorPicker.Control0.frmColorPicker.Enum2.const_0;
				}

				public void method_9(GClass47.ColorPicker.Control0.frmColorPicker.Enum2 enum2_0)
				{
					switch (enum2_0)
					{
					case GClass47.ColorPicker.Control0.frmColorPicker.Enum2.const_0:
						this.m_rbtn_Hue.Checked = true;
						return;
					case GClass47.ColorPicker.Control0.frmColorPicker.Enum2.const_1:
						this.m_rbtn_Sat.Checked = true;
						return;
					case GClass47.ColorPicker.Control0.frmColorPicker.Enum2.const_2:
						this.m_rbtn_Black.Checked = true;
						return;
					case GClass47.ColorPicker.Control0.frmColorPicker.Enum2.const_3:
						this.m_rbtn_Red.Checked = true;
						return;
					case GClass47.ColorPicker.Control0.frmColorPicker.Enum2.const_4:
						this.m_rbtn_Green.Checked = true;
						return;
					case GClass47.ColorPicker.Control0.frmColorPicker.Enum2.const_5:
						this.m_rbtn_Blue.Checked = true;
						return;
					default:
						this.m_rbtn_Hue.Checked = true;
						return;
					}
				}

				GClass47.ColorPicker.Control0.Class49.Class50 class50_0;

				Color color_0;

				GClass47.ColorPicker.Control0.Class49.Class51 class51_0;

				Label m_lbl_SelectColor;

				PictureBox m_pbx_BlankBox;

				Button m_cmd_OK;

				Button m_cmd_Cancel;

				TextBox m_txt_Hue;

				TextBox m_txt_Sat;

				TextBox m_txt_Black;

				TextBox m_txt_Red;

				TextBox m_txt_Green;

				TextBox m_txt_Blue;

				TextBox m_txt_Lum;

				TextBox m_txt_a;

				TextBox m_txt_b;

				TextBox m_txt_Cyan;

				TextBox m_txt_Magenta;

				TextBox m_txt_Yellow;

				TextBox m_txt_K;

				TextBox m_txt_Hex;

				RadioButton m_rbtn_Hue;

				RadioButton m_rbtn_Sat;

				RadioButton m_rbtn_Black;

				RadioButton m_rbtn_Red;

				RadioButton m_rbtn_Green;

				RadioButton m_rbtn_Blue;

				CheckBox m_cbx_WebColorsOnly;

				Label m_lbl_HexPound;

				RadioButton m_rbtn_L;

				RadioButton m_rbtn_a;

				RadioButton m_rbtn_b;

				Label m_lbl_Cyan;

				Label m_lbl_Magenta;

				Label m_lbl_Yellow;

				Label m_lbl_K;

				Label m_lbl_Primary_Color;

				Label m_lbl_Secondary_Color;

				GClass47.ColorPicker.Control0.ctrl1DColorBar m_ctrl_ThinBox;

				GClass47.ColorPicker.Control0.ctrl2DColorBox m_ctrl_BigBox;

				Label m_lbl_Hue_Symbol;

				Label m_lbl_Saturation_Symbol;

				Label m_lbl_Black_Symbol;

				Label m_lbl_Cyan_Symbol;

				Label m_lbl_Magenta_Symbol;

				Label m_lbl_Yellow_Symbol;

				Label m_lbl_Key_Symbol;

				Container container_0;

				public enum Enum2
				{
					const_0,
					const_1,
					const_2,
					const_3,
					const_4,
					const_5
				}
			}

			[ToolboxItem(false)]
			public class ctrl2DColorBox : UserControl
			{
				public ctrl2DColorBox()
				{
					this.InitializeComponent();
					this.class50_0 = new GClass47.ColorPicker.Control0.Class49.Class50();
					this.class50_0.method_1(1.0);
					this.class50_0.method_3(1.0);
					this.class50_0.method_5(1.0);
					this.color_0 = GClass47.ColorPicker.Control0.Class49.smethod_6(this.class50_0);
					this.enum3_0 = GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_0;
				}

				protected override void Dispose(bool disposing)
				{
					if (disposing && this.container_0 != null)
					{
						this.container_0.Dispose();
					}
					base.Dispose(disposing);
				}

				void InitializeComponent()
				{
					base.Name = "ctrl2DColorBox";
					base.Size = new Size(260, 260);
					base.Resize += this.ctrl2DColorBox_Resize;
					base.Load += this.ctrl2DColorBox_Load;
					base.MouseUp += this.ctrl2DColorBox_MouseUp;
					base.Paint += this.ctrl2DColorBox_Paint;
					base.MouseMove += this.ctrl2DColorBox_MouseMove;
					base.MouseDown += this.ctrl2DColorBox_MouseDown;
				}

				void ctrl2DColorBox_Load(object sender, EventArgs e)
				{
					this.method_18();
				}

				void ctrl2DColorBox_MouseDown(object sender, MouseEventArgs e)
				{
					if (e.Button != MouseButtons.Left)
					{
						return;
					}
					this.bool_0 = true;
					int num = e.X - 2;
					int num2 = e.Y - 2;
					if (num < 0)
					{
						num = 0;
					}
					if (num > base.Width - 4)
					{
						num = base.Width - 4;
					}
					if (num2 < 0)
					{
						num2 = 0;
					}
					if (num2 > base.Height - 4)
					{
						num2 = base.Height - 4;
					}
					if (num == this.int_0 && num2 == this.int_1)
					{
						return;
					}
					this.method_9(num, num2, true);
					this.method_20();
					if (this.eventHandler_0 != null)
					{
						this.eventHandler_0(this, e);
					}
				}

				void ctrl2DColorBox_MouseMove(object sender, MouseEventArgs e)
				{
					if (!this.bool_0)
					{
						return;
					}
					int num = e.X - 2;
					int num2 = e.Y - 2;
					if (num < 0)
					{
						num = 0;
					}
					if (num > base.Width - 4)
					{
						num = base.Width - 4;
					}
					if (num2 < 0)
					{
						num2 = 0;
					}
					if (num2 > base.Height - 4)
					{
						num2 = base.Height - 4;
					}
					if (num == this.int_0 && num2 == this.int_1)
					{
						return;
					}
					this.method_9(num, num2, true);
					this.method_20();
					if (this.eventHandler_0 != null)
					{
						this.eventHandler_0(this, e);
					}
				}

				void ctrl2DColorBox_MouseUp(object sender, MouseEventArgs e)
				{
					if (e.Button != MouseButtons.Left)
					{
						return;
					}
					if (!this.bool_0)
					{
						return;
					}
					this.bool_0 = false;
					int num = e.X - 2;
					int num2 = e.Y - 2;
					if (num < 0)
					{
						num = 0;
					}
					if (num > base.Width - 4)
					{
						num = base.Width - 4;
					}
					if (num2 < 0)
					{
						num2 = 0;
					}
					if (num2 > base.Height - 4)
					{
						num2 = base.Height - 4;
					}
					if (num == this.int_0 && num2 == this.int_1)
					{
						return;
					}
					this.method_9(num, num2, true);
					this.method_20();
					if (this.eventHandler_0 != null)
					{
						this.eventHandler_0(this, e);
					}
				}

				void ctrl2DColorBox_Resize(object sender, EventArgs e)
				{
					this.method_18();
				}

				void ctrl2DColorBox_Paint(object sender, PaintEventArgs e)
				{
					this.method_18();
				}

				[MethodImpl(MethodImplOptions.Synchronized)]
				public void method_0(EventHandler eventHandler_1)
				{
					this.eventHandler_0 = (EventHandler)Delegate.Combine(this.eventHandler_0, eventHandler_1);
				}

				[MethodImpl(MethodImplOptions.Synchronized)]
				public void method_1(EventHandler eventHandler_1)
				{
					this.eventHandler_0 = (EventHandler)Delegate.Remove(this.eventHandler_0, eventHandler_1);
				}

				public GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3 method_2()
				{
					return this.enum3_0;
				}

				public void method_3(GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3 enum3_1)
				{
					this.enum3_0 = enum3_1;
					this.method_19(true);
					this.method_18();
				}

				public GClass47.ColorPicker.Control0.Class49.Class50 method_4()
				{
					return this.class50_0;
				}

				public void method_5(GClass47.ColorPicker.Control0.Class49.Class50 class50_1)
				{
					this.class50_0 = class50_1;
					this.color_0 = GClass47.ColorPicker.Control0.Class49.smethod_6(this.class50_0);
					this.method_19(true);
					this.method_18();
				}

				public Color method_6()
				{
					return this.color_0;
				}

				public void method_7(Color color_1)
				{
					this.color_0 = color_1;
					this.class50_0 = GClass47.ColorPicker.Control0.Class49.smethod_7(this.color_0);
					this.method_19(true);
					this.method_18();
				}

				void method_8()
				{
					Graphics graphics = base.CreateGraphics();
					GClass47.ColorPicker.Control0.Class49.Class50 @class = new GClass47.ColorPicker.Control0.Class49.Class50();
					GClass47.ColorPicker.Control0.Class49.Class50 class2 = new GClass47.ColorPicker.Control0.Class49.Class50();
					int num = this.int_0 - 5;
					int num2 = this.int_1 - 5;
					int num3 = this.int_0 + 5;
					int num4 = this.int_1 + 5;
					if (num < 0)
					{
						num = 0;
					}
					if (num2 < 0)
					{
						num2 = 0;
					}
					if (num3 > base.Width - 4)
					{
						num3 = base.Width - 4;
					}
					if (num4 > base.Height - 4)
					{
						num4 = base.Height - 4;
					}
					switch (this.enum3_0)
					{
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_0:
						@class.method_1(this.class50_0.method_0());
						class2.method_1(this.class50_0.method_0());
						@class.method_3((double)num / (double)(base.Width - 4));
						class2.method_3((double)num3 / (double)(base.Width - 4));
						for (int i = num2; i <= num4; i++)
						{
							@class.method_5(1.0 - (double)i / (double)(base.Height - 4));
							class2.method_5(@class.method_4());
							LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(num + 1, i + 2, num3 - num + 1, 1), GClass47.ColorPicker.Control0.Class49.smethod_6(@class), GClass47.ColorPicker.Control0.Class49.smethod_6(class2), 0f, false);
							graphics.FillRectangle(brush, new Rectangle(num + 2, i + 2, num3 - num + 1, 1));
						}
						return;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_1:
						@class.method_3(this.class50_0.method_2());
						class2.method_3(this.class50_0.method_2());
						@class.method_5(1.0 - (double)num2 / (double)(base.Height - 4));
						class2.method_5(1.0 - (double)num4 / (double)(base.Height - 4));
						for (int j = num; j <= num3; j++)
						{
							@class.method_1((double)j / (double)(base.Width - 4));
							class2.method_1(@class.method_0());
							LinearGradientBrush brush2 = new LinearGradientBrush(new Rectangle(j + 2, num2 + 1, 1, num4 - num2 + 2), GClass47.ColorPicker.Control0.Class49.smethod_6(@class), GClass47.ColorPicker.Control0.Class49.smethod_6(class2), 90f, false);
							graphics.FillRectangle(brush2, new Rectangle(j + 2, num2 + 2, 1, num4 - num2 + 1));
						}
						return;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_2:
						@class.method_5(this.class50_0.method_4());
						class2.method_5(this.class50_0.method_4());
						@class.method_3(1.0 - (double)num2 / (double)(base.Height - 4));
						class2.method_3(1.0 - (double)num4 / (double)(base.Height - 4));
						for (int k = num; k <= num3; k++)
						{
							@class.method_1((double)k / (double)(base.Width - 4));
							class2.method_1(@class.method_0());
							LinearGradientBrush brush3 = new LinearGradientBrush(new Rectangle(k + 2, num2 + 1, 1, num4 - num2 + 2), GClass47.ColorPicker.Control0.Class49.smethod_6(@class), GClass47.ColorPicker.Control0.Class49.smethod_6(class2), 90f, false);
							graphics.FillRectangle(brush3, new Rectangle(k + 2, num2 + 2, 1, num4 - num2 + 1));
						}
						return;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_3:
					{
						int red = (int)this.color_0.R;
						int blue = this.method_21(255.0 * (double)num / (double)(base.Width - 4));
						int blue2 = this.method_21(255.0 * (double)num3 / (double)(base.Width - 4));
						for (int l = num2; l <= num4; l++)
						{
							int green = this.method_21(255.0 - 255.0 * (double)l / (double)(base.Height - 4));
							LinearGradientBrush brush4 = new LinearGradientBrush(new Rectangle(num + 1, l + 2, num3 - num + 1, 1), Color.FromArgb(red, green, blue), Color.FromArgb(red, green, blue2), 0f, false);
							graphics.FillRectangle(brush4, new Rectangle(num + 2, l + 2, num3 - num + 1, 1));
						}
						return;
					}
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_4:
					{
						int green = (int)this.color_0.G;
						int blue3 = this.method_21(255.0 * (double)num / (double)(base.Width - 4));
						int blue4 = this.method_21(255.0 * (double)num3 / (double)(base.Width - 4));
						for (int m = num2; m <= num4; m++)
						{
							int red = this.method_21(255.0 - 255.0 * (double)m / (double)(base.Height - 4));
							LinearGradientBrush brush5 = new LinearGradientBrush(new Rectangle(num + 1, m + 2, num3 - num + 1, 1), Color.FromArgb(red, green, blue3), Color.FromArgb(red, green, blue4), 0f, false);
							graphics.FillRectangle(brush5, new Rectangle(num + 2, m + 2, num3 - num + 1, 1));
						}
						return;
					}
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_5:
					{
						int b = (int)this.color_0.B;
						int red2 = this.method_21(255.0 * (double)num / (double)(base.Width - 4));
						int red3 = this.method_21(255.0 * (double)num3 / (double)(base.Width - 4));
						for (int n = num2; n <= num4; n++)
						{
							int green = this.method_21(255.0 - 255.0 * (double)n / (double)(base.Height - 4));
							LinearGradientBrush brush6 = new LinearGradientBrush(new Rectangle(num + 1, n + 2, num3 - num + 1, 1), Color.FromArgb(red2, green, b), Color.FromArgb(red3, green, b), 0f, false);
							graphics.FillRectangle(brush6, new Rectangle(num + 2, n + 2, num3 - num + 1, 1));
						}
						return;
					}
					default:
						return;
					}
				}

				void method_9(int int_2, int int_3, bool bool_1)
				{
					if (int_2 < 0)
					{
						int_2 = 0;
					}
					if (int_2 > base.Width - 4)
					{
						int_2 = base.Width - 4;
					}
					if (int_3 < 0)
					{
						int_3 = 0;
					}
					if (int_3 > base.Height - 4)
					{
						int_3 = base.Height - 4;
					}
					if (this.int_1 == int_3 && this.int_0 == int_2 && !bool_1)
					{
						return;
					}
					this.method_8();
					this.int_0 = int_2;
					this.int_1 = int_3;
					Graphics graphics = base.CreateGraphics();
					GClass47.ColorPicker.Control0.Class49.Class50 @class = this.method_22(int_2, int_3);
					Pen pen;
					if (@class.method_4() < 0.78431372549019607)
					{
						pen = new Pen(Color.White);
					}
					else if (@class.method_0() >= 0.072222222222222215 && @class.method_0() <= 0.55555555555555558)
					{
						pen = new Pen(Color.Black);
					}
					else if (@class.method_2() > 0.27450980392156865)
					{
						pen = new Pen(Color.White);
					}
					else
					{
						pen = new Pen(Color.Black);
					}
					graphics.DrawEllipse(pen, int_2 - 3, int_3 - 3, 10, 10);
					this.method_10();
				}

				void method_10()
				{
					Graphics graphics = base.CreateGraphics();
					Pen pen = new Pen(Color.FromArgb(172, 168, 153));
					graphics.DrawLine(pen, base.Width - 2, 0, 0, 0);
					graphics.DrawLine(pen, 0, 0, 0, base.Height - 2);
					pen = new Pen(Color.White);
					graphics.DrawLine(pen, base.Width - 1, 0, base.Width - 1, base.Height - 1);
					graphics.DrawLine(pen, base.Width - 1, base.Height - 1, 0, base.Height - 1);
					pen = new Pen(Color.Black);
					graphics.DrawRectangle(pen, 1, 1, base.Width - 3, base.Height - 3);
				}

				void method_11()
				{
					switch (this.enum3_0)
					{
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_0:
						this.method_12();
						return;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_1:
						this.method_13();
						return;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_2:
						this.method_14();
						return;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_3:
						this.method_15();
						return;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_4:
						this.method_16();
						return;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_5:
						this.method_17();
						return;
					default:
						return;
					}
				}

				void method_12()
				{
					Graphics graphics = base.CreateGraphics();
					GClass47.ColorPicker.Control0.Class49.Class50 @class = new GClass47.ColorPicker.Control0.Class49.Class50();
					GClass47.ColorPicker.Control0.Class49.Class50 class2 = new GClass47.ColorPicker.Control0.Class49.Class50();
					@class.method_1(this.class50_0.method_0());
					class2.method_1(this.class50_0.method_0());
					@class.method_3(0.0);
					class2.method_3(1.0);
					for (int i = 0; i < base.Height - 4; i++)
					{
						@class.method_5(1.0 - (double)i / (double)(base.Height - 4));
						class2.method_5(@class.method_4());
						LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(2, 2, base.Width - 4, 1), GClass47.ColorPicker.Control0.Class49.smethod_6(@class), GClass47.ColorPicker.Control0.Class49.smethod_6(class2), 0f, false);
						graphics.FillRectangle(brush, new Rectangle(2, i + 2, base.Width - 4, 1));
					}
				}

				void method_13()
				{
					Graphics graphics = base.CreateGraphics();
					GClass47.ColorPicker.Control0.Class49.Class50 @class = new GClass47.ColorPicker.Control0.Class49.Class50();
					GClass47.ColorPicker.Control0.Class49.Class50 class2 = new GClass47.ColorPicker.Control0.Class49.Class50();
					@class.method_3(this.class50_0.method_2());
					class2.method_3(this.class50_0.method_2());
					@class.method_5(1.0);
					class2.method_5(0.0);
					for (int i = 0; i < base.Width - 4; i++)
					{
						@class.method_1((double)i / (double)(base.Width - 4));
						class2.method_1(@class.method_0());
						LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(2, 2, 1, base.Height - 4), GClass47.ColorPicker.Control0.Class49.smethod_6(@class), GClass47.ColorPicker.Control0.Class49.smethod_6(class2), 90f, false);
						graphics.FillRectangle(brush, new Rectangle(i + 2, 2, 1, base.Height - 4));
					}
				}

				void method_14()
				{
					Graphics graphics = base.CreateGraphics();
					GClass47.ColorPicker.Control0.Class49.Class50 @class = new GClass47.ColorPicker.Control0.Class49.Class50();
					GClass47.ColorPicker.Control0.Class49.Class50 class2 = new GClass47.ColorPicker.Control0.Class49.Class50();
					@class.method_5(this.class50_0.method_4());
					class2.method_5(this.class50_0.method_4());
					@class.method_3(1.0);
					class2.method_3(0.0);
					for (int i = 0; i < base.Width - 4; i++)
					{
						@class.method_1((double)i / (double)(base.Width - 4));
						class2.method_1(@class.method_0());
						LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(2, 2, 1, base.Height - 4), GClass47.ColorPicker.Control0.Class49.smethod_6(@class), GClass47.ColorPicker.Control0.Class49.smethod_6(class2), 90f, false);
						graphics.FillRectangle(brush, new Rectangle(i + 2, 2, 1, base.Height - 4));
					}
				}

				void method_15()
				{
					Graphics graphics = base.CreateGraphics();
					int r = (int)this.color_0.R;
					for (int i = 0; i < base.Height - 4; i++)
					{
						int green = this.method_21(255.0 - 255.0 * (double)i / (double)(base.Height - 4));
						LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(2, 2, base.Width - 4, 1), Color.FromArgb(r, green, 0), Color.FromArgb(r, green, 255), 0f, false);
						graphics.FillRectangle(brush, new Rectangle(2, i + 2, base.Width - 4, 1));
					}
				}

				void method_16()
				{
					Graphics graphics = base.CreateGraphics();
					int g = (int)this.color_0.G;
					for (int i = 0; i < base.Height - 4; i++)
					{
						int red = this.method_21(255.0 - 255.0 * (double)i / (double)(base.Height - 4));
						LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(2, 2, base.Width - 4, 1), Color.FromArgb(red, g, 0), Color.FromArgb(red, g, 255), 0f, false);
						graphics.FillRectangle(brush, new Rectangle(2, i + 2, base.Width - 4, 1));
					}
				}

				void method_17()
				{
					Graphics graphics = base.CreateGraphics();
					int b = (int)this.color_0.B;
					for (int i = 0; i < base.Height - 4; i++)
					{
						int green = this.method_21(255.0 - 255.0 * (double)i / (double)(base.Height - 4));
						LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(2, 2, base.Width - 4, 1), Color.FromArgb(0, green, b), Color.FromArgb(255, green, b), 0f, false);
						graphics.FillRectangle(brush, new Rectangle(2, i + 2, base.Width - 4, 1));
					}
				}

				void method_18()
				{
					this.method_10();
					switch (this.enum3_0)
					{
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_0:
						this.method_12();
						break;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_1:
						this.method_13();
						break;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_2:
						this.method_14();
						break;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_3:
						this.method_15();
						break;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_4:
						this.method_16();
						break;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_5:
						this.method_17();
						break;
					}
					this.method_9(this.int_0, this.int_1, true);
				}

				void method_19(bool bool_1)
				{
					switch (this.enum3_0)
					{
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_0:
						this.int_0 = this.method_21((double)(base.Width - 4) * this.class50_0.method_2());
						this.int_1 = this.method_21((double)(base.Height - 4) * (1.0 - this.class50_0.method_4()));
						break;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_1:
						this.int_0 = this.method_21((double)(base.Width - 4) * this.class50_0.method_0());
						this.int_1 = this.method_21((double)(base.Height - 4) * (1.0 - this.class50_0.method_4()));
						break;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_2:
						this.int_0 = this.method_21((double)(base.Width - 4) * this.class50_0.method_0());
						this.int_1 = this.method_21((double)(base.Height - 4) * (1.0 - this.class50_0.method_2()));
						break;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_3:
						this.int_0 = this.method_21((double)(base.Width - 4) * (double)this.color_0.B / 255.0);
						this.int_1 = this.method_21((double)(base.Height - 4) * (1.0 - (double)this.color_0.G / 255.0));
						break;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_4:
						this.int_0 = this.method_21((double)(base.Width - 4) * (double)this.color_0.B / 255.0);
						this.int_1 = this.method_21((double)(base.Height - 4) * (1.0 - (double)this.color_0.R / 255.0));
						break;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_5:
						this.int_0 = this.method_21((double)(base.Width - 4) * (double)this.color_0.R / 255.0);
						this.int_1 = this.method_21((double)(base.Height - 4) * (1.0 - (double)this.color_0.G / 255.0));
						break;
					}
					if (bool_1)
					{
						this.method_9(this.int_0, this.int_1, true);
					}
				}

				void method_20()
				{
					switch (this.enum3_0)
					{
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_0:
						this.class50_0.method_3((double)this.int_0 / (double)(base.Width - 4));
						this.class50_0.method_5(1.0 - (double)this.int_1 / (double)(base.Height - 4));
						this.color_0 = GClass47.ColorPicker.Control0.Class49.smethod_6(this.class50_0);
						return;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_1:
						this.class50_0.method_1((double)this.int_0 / (double)(base.Width - 4));
						this.class50_0.method_5(1.0 - (double)this.int_1 / (double)(base.Height - 4));
						this.color_0 = GClass47.ColorPicker.Control0.Class49.smethod_6(this.class50_0);
						return;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_2:
						this.class50_0.method_1((double)this.int_0 / (double)(base.Width - 4));
						this.class50_0.method_3(1.0 - (double)this.int_1 / (double)(base.Height - 4));
						this.color_0 = GClass47.ColorPicker.Control0.Class49.smethod_6(this.class50_0);
						return;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_3:
					{
						int blue = this.method_21(255.0 * (double)this.int_0 / (double)(base.Width - 4));
						int green = this.method_21(255.0 * (1.0 - (double)this.int_1 / (double)(base.Height - 4)));
						this.color_0 = Color.FromArgb((int)this.color_0.R, green, blue);
						this.class50_0 = GClass47.ColorPicker.Control0.Class49.smethod_7(this.color_0);
						return;
					}
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_4:
					{
						int blue = this.method_21(255.0 * (double)this.int_0 / (double)(base.Width - 4));
						int red = this.method_21(255.0 * (1.0 - (double)this.int_1 / (double)(base.Height - 4)));
						this.color_0 = Color.FromArgb(red, (int)this.color_0.G, blue);
						this.class50_0 = GClass47.ColorPicker.Control0.Class49.smethod_7(this.color_0);
						return;
					}
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_5:
					{
						int red = this.method_21(255.0 * (double)this.int_0 / (double)(base.Width - 4));
						int green = this.method_21(255.0 * (1.0 - (double)this.int_1 / (double)(base.Height - 4)));
						this.color_0 = Color.FromArgb(red, green, (int)this.color_0.B);
						this.class50_0 = GClass47.ColorPicker.Control0.Class49.smethod_7(this.color_0);
						return;
					}
					default:
						return;
					}
				}

				int method_21(double double_0)
				{
					int num = (int)double_0;
					int num2 = (int)(double_0 * 100.0);
					if (num2 % 100 >= 50)
					{
						num++;
					}
					return num;
				}

				GClass47.ColorPicker.Control0.Class49.Class50 method_22(int int_2, int int_3)
				{
					GClass47.ColorPicker.Control0.Class49.Class50 @class = new GClass47.ColorPicker.Control0.Class49.Class50();
					switch (this.enum3_0)
					{
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_0:
						@class.method_1(this.class50_0.method_0());
						@class.method_3((double)int_2 / (double)(base.Width - 4));
						@class.method_5(1.0 - (double)int_3 / (double)(base.Height - 4));
						break;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_1:
						@class.method_3(this.class50_0.method_2());
						@class.method_1((double)int_2 / (double)(base.Width - 4));
						@class.method_5(1.0 - (double)int_3 / (double)(base.Height - 4));
						break;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_2:
						@class.method_5(this.class50_0.method_4());
						@class.method_1((double)int_2 / (double)(base.Width - 4));
						@class.method_3(1.0 - (double)int_3 / (double)(base.Height - 4));
						break;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_3:
						@class = GClass47.ColorPicker.Control0.Class49.smethod_7(Color.FromArgb((int)this.color_0.R, this.method_21(255.0 * (1.0 - (double)int_3 / (double)(base.Height - 4))), this.method_21(255.0 * (double)int_2 / (double)(base.Width - 4))));
						break;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_4:
						@class = GClass47.ColorPicker.Control0.Class49.smethod_7(Color.FromArgb(this.method_21(255.0 * (1.0 - (double)int_3 / (double)(base.Height - 4))), (int)this.color_0.G, this.method_21(255.0 * (double)int_2 / (double)(base.Width - 4))));
						break;
					case GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3.const_5:
						@class = GClass47.ColorPicker.Control0.Class49.smethod_7(Color.FromArgb(this.method_21(255.0 * (double)int_2 / (double)(base.Width - 4)), this.method_21(255.0 * (1.0 - (double)int_3 / (double)(base.Height - 4))), (int)this.color_0.B));
						break;
					}
					return @class;
				}

				int int_0;

				int int_1;

				bool bool_0;

				GClass47.ColorPicker.Control0.ctrl2DColorBox.Enum3 enum3_0;

				GClass47.ColorPicker.Control0.Class49.Class50 class50_0;

				Color color_0;

				Container container_0;

				EventHandler eventHandler_0;

				public enum Enum3
				{
					const_0,
					const_1,
					const_2,
					const_3,
					const_4,
					const_5
				}
			}

			[ToolboxItem(false)]
			public class ctrl1DColorBar : UserControl
			{
				public ctrl1DColorBar()
				{
					this.InitializeComponent();
					this.class50_0 = new GClass47.ColorPicker.Control0.Class49.Class50();
					this.class50_0.method_1(1.0);
					this.class50_0.method_3(1.0);
					this.class50_0.method_5(1.0);
					this.color_0 = GClass47.ColorPicker.Control0.Class49.smethod_6(this.class50_0);
					this.enum4_0 = GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_0;
				}

				protected override void Dispose(bool disposing)
				{
					if (disposing && this.container_0 != null)
					{
						this.container_0.Dispose();
					}
					base.Dispose(disposing);
				}

				void InitializeComponent()
				{
					base.Name = "ctrl1DColorBar";
					base.Size = new Size(40, 264);
					base.Resize += this.ctrl1DColorBar_Resize;
					base.Load += this.ctrl1DColorBar_Load;
					base.MouseUp += this.ctrl1DColorBar_MouseUp;
					base.Paint += this.ctrl1DColorBar_Paint;
					base.MouseMove += this.ctrl1DColorBar_MouseMove;
					base.MouseDown += this.ctrl1DColorBar_MouseDown;
				}

				void ctrl1DColorBar_Load(object sender, EventArgs e)
				{
					this.method_18();
				}

				void ctrl1DColorBar_MouseDown(object sender, MouseEventArgs e)
				{
					if (e.Button != MouseButtons.Left)
					{
						return;
					}
					this.bool_0 = true;
					int num = e.Y;
					num -= 4;
					if (num < 0)
					{
						num = 0;
					}
					if (num > base.Height - 9)
					{
						num = base.Height - 9;
					}
					if (num == this.int_0)
					{
						return;
					}
					this.method_9(num, false);
					this.method_20();
					if (this.eventHandler_0 != null)
					{
						this.eventHandler_0(this, e);
					}
				}

				void ctrl1DColorBar_MouseMove(object sender, MouseEventArgs e)
				{
					if (!this.bool_0)
					{
						return;
					}
					int num = e.Y;
					num -= 4;
					if (num < 0)
					{
						num = 0;
					}
					if (num > base.Height - 9)
					{
						num = base.Height - 9;
					}
					if (num == this.int_0)
					{
						return;
					}
					this.method_9(num, false);
					this.method_20();
					if (this.eventHandler_0 != null)
					{
						this.eventHandler_0(this, e);
					}
				}

				void ctrl1DColorBar_MouseUp(object sender, MouseEventArgs e)
				{
					if (e.Button != MouseButtons.Left)
					{
						return;
					}
					this.bool_0 = false;
					int num = e.Y;
					num -= 4;
					if (num < 0)
					{
						num = 0;
					}
					if (num > base.Height - 9)
					{
						num = base.Height - 9;
					}
					if (num == this.int_0)
					{
						return;
					}
					this.method_9(num, false);
					this.method_20();
					if (this.eventHandler_0 != null)
					{
						this.eventHandler_0(this, e);
					}
				}

				void ctrl1DColorBar_Paint(object sender, PaintEventArgs e)
				{
					this.method_18();
				}

				void ctrl1DColorBar_Resize(object sender, EventArgs e)
				{
					this.method_18();
				}

				[MethodImpl(MethodImplOptions.Synchronized)]
				public void method_0(EventHandler eventHandler_1)
				{
					this.eventHandler_0 = (EventHandler)Delegate.Combine(this.eventHandler_0, eventHandler_1);
				}

				[MethodImpl(MethodImplOptions.Synchronized)]
				public void method_1(EventHandler eventHandler_1)
				{
					this.eventHandler_0 = (EventHandler)Delegate.Remove(this.eventHandler_0, eventHandler_1);
				}

				public GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4 method_2()
				{
					return this.enum4_0;
				}

				public void method_3(GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4 enum4_1)
				{
					this.enum4_0 = enum4_1;
					this.method_19(true);
					this.method_18();
				}

				public GClass47.ColorPicker.Control0.Class49.Class50 method_4()
				{
					return this.class50_0;
				}

				public void method_5(GClass47.ColorPicker.Control0.Class49.Class50 class50_1)
				{
					this.class50_0 = class50_1;
					this.color_0 = GClass47.ColorPicker.Control0.Class49.smethod_6(this.class50_0);
					this.method_19(true);
					this.method_11();
				}

				public Color method_6()
				{
					return this.color_0;
				}

				public void method_7(Color color_1)
				{
					this.color_0 = color_1;
					this.class50_0 = GClass47.ColorPicker.Control0.Class49.smethod_7(this.color_0);
					this.method_19(true);
					this.method_11();
				}

				void method_8()
				{
					Graphics graphics = base.CreateGraphics();
					Brush control = SystemBrushes.Control;
					graphics.FillRectangle(control, 0, 0, 8, base.Height);
					graphics.FillRectangle(control, base.Width - 8, 0, 8, base.Height);
				}

				void method_9(int int_1, bool bool_1)
				{
					if (int_1 < 0)
					{
						int_1 = 0;
					}
					if (int_1 > base.Height - 9)
					{
						int_1 = base.Height - 9;
					}
					if (this.int_0 == int_1 && !bool_1)
					{
						return;
					}
					this.int_0 = int_1;
					this.method_8();
					Graphics graphics = base.CreateGraphics();
					Pen pen = new Pen(Color.FromArgb(116, 114, 106));
					Brush white = Brushes.White;
					Point[] array = new Point[]
					{
						new Point(1, int_1),
						new Point(3, int_1),
						new Point(7, int_1 + 4),
						new Point(3, int_1 + 8),
						new Point(1, int_1 + 8),
						new Point(0, int_1 + 7),
						new Point(0, int_1 + 1)
					};
					graphics.FillPolygon(white, array);
					graphics.DrawPolygon(pen, array);
					array[0] = new Point(base.Width - 2, int_1);
					array[1] = new Point(base.Width - 4, int_1);
					array[2] = new Point(base.Width - 8, int_1 + 4);
					array[3] = new Point(base.Width - 4, int_1 + 8);
					array[4] = new Point(base.Width - 2, int_1 + 8);
					array[5] = new Point(base.Width - 1, int_1 + 7);
					array[6] = new Point(base.Width - 1, int_1 + 1);
					graphics.FillPolygon(white, array);
					graphics.DrawPolygon(pen, array);
				}

				void method_10()
				{
					Graphics graphics = base.CreateGraphics();
					Pen pen = new Pen(Color.FromArgb(172, 168, 153));
					graphics.DrawLine(pen, base.Width - 10, 2, 9, 2);
					graphics.DrawLine(pen, 9, 2, 9, base.Height - 4);
					pen = new Pen(Color.White);
					graphics.DrawLine(pen, base.Width - 9, 2, base.Width - 9, base.Height - 3);
					graphics.DrawLine(pen, base.Width - 9, base.Height - 3, 9, base.Height - 3);
					pen = new Pen(Color.Black);
					graphics.DrawRectangle(pen, 10, 3, base.Width - 20, base.Height - 7);
				}

				void method_11()
				{
					switch (this.enum4_0)
					{
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_0:
						this.method_12();
						return;
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_1:
						this.method_13();
						return;
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_2:
						this.method_14();
						return;
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_3:
						this.method_15();
						return;
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_4:
						this.method_16();
						return;
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_5:
						this.method_17();
						return;
					default:
						return;
					}
				}

				void method_12()
				{
					Graphics graphics = base.CreateGraphics();
					GClass47.ColorPicker.Control0.Class49.Class50 @class = new GClass47.ColorPicker.Control0.Class49.Class50();
					@class.method_3(1.0);
					@class.method_5(1.0);
					for (int i = 0; i < base.Height - 8; i++)
					{
						@class.method_1(1.0 - (double)i / (double)(base.Height - 8));
						Pen pen = new Pen(GClass47.ColorPicker.Control0.Class49.smethod_6(@class));
						graphics.DrawLine(pen, 11, i + 4, base.Width - 11, i + 4);
					}
				}

				void method_13()
				{
					Graphics graphics = base.CreateGraphics();
					GClass47.ColorPicker.Control0.Class49.Class50 @class = new GClass47.ColorPicker.Control0.Class49.Class50();
					@class.method_1(this.class50_0.method_0());
					@class.method_5(this.class50_0.method_4());
					for (int i = 0; i < base.Height - 8; i++)
					{
						@class.method_3(1.0 - (double)i / (double)(base.Height - 8));
						Pen pen = new Pen(GClass47.ColorPicker.Control0.Class49.smethod_6(@class));
						graphics.DrawLine(pen, 11, i + 4, base.Width - 11, i + 4);
					}
				}

				void method_14()
				{
					Graphics graphics = base.CreateGraphics();
					GClass47.ColorPicker.Control0.Class49.Class50 @class = new GClass47.ColorPicker.Control0.Class49.Class50();
					@class.method_1(this.class50_0.method_0());
					@class.method_3(this.class50_0.method_2());
					for (int i = 0; i < base.Height - 8; i++)
					{
						@class.method_5(1.0 - (double)i / (double)(base.Height - 8));
						Pen pen = new Pen(GClass47.ColorPicker.Control0.Class49.smethod_6(@class));
						graphics.DrawLine(pen, 11, i + 4, base.Width - 11, i + 4);
					}
				}

				void method_15()
				{
					Graphics graphics = base.CreateGraphics();
					for (int i = 0; i < base.Height - 8; i++)
					{
						int red = 255 - this.method_21(255.0 * (double)i / (double)(base.Height - 8));
						Pen pen = new Pen(Color.FromArgb(red, (int)this.color_0.G, (int)this.color_0.B));
						graphics.DrawLine(pen, 11, i + 4, base.Width - 11, i + 4);
					}
				}

				void method_16()
				{
					Graphics graphics = base.CreateGraphics();
					for (int i = 0; i < base.Height - 8; i++)
					{
						int green = 255 - this.method_21(255.0 * (double)i / (double)(base.Height - 8));
						Pen pen = new Pen(Color.FromArgb((int)this.color_0.R, green, (int)this.color_0.B));
						graphics.DrawLine(pen, 11, i + 4, base.Width - 11, i + 4);
					}
				}

				void method_17()
				{
					Graphics graphics = base.CreateGraphics();
					for (int i = 0; i < base.Height - 8; i++)
					{
						int blue = 255 - this.method_21(255.0 * (double)i / (double)(base.Height - 8));
						Pen pen = new Pen(Color.FromArgb((int)this.color_0.R, (int)this.color_0.G, blue));
						graphics.DrawLine(pen, 11, i + 4, base.Width - 11, i + 4);
					}
				}

				void method_18()
				{
					this.method_9(this.int_0, true);
					this.method_10();
					switch (this.enum4_0)
					{
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_0:
						this.method_12();
						return;
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_1:
						this.method_13();
						return;
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_2:
						this.method_14();
						return;
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_3:
						this.method_15();
						return;
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_4:
						this.method_16();
						return;
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_5:
						this.method_17();
						return;
					default:
						return;
					}
				}

				void method_19(bool bool_1)
				{
					switch (this.enum4_0)
					{
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_0:
						this.int_0 = base.Height - 8 - this.method_21((double)(base.Height - 8) * this.class50_0.method_0());
						break;
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_1:
						this.int_0 = base.Height - 8 - this.method_21((double)(base.Height - 8) * this.class50_0.method_2());
						break;
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_2:
						this.int_0 = base.Height - 8 - this.method_21((double)(base.Height - 8) * this.class50_0.method_4());
						break;
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_3:
						this.int_0 = base.Height - 8 - this.method_21((double)(base.Height - 8) * (double)this.color_0.R / 255.0);
						break;
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_4:
						this.int_0 = base.Height - 8 - this.method_21((double)(base.Height - 8) * (double)this.color_0.G / 255.0);
						break;
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_5:
						this.int_0 = base.Height - 8 - this.method_21((double)(base.Height - 8) * (double)this.color_0.B / 255.0);
						break;
					}
					if (bool_1)
					{
						this.method_9(this.int_0, true);
					}
				}

				void method_20()
				{
					switch (this.enum4_0)
					{
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_0:
						this.class50_0.method_1(1.0 - (double)this.int_0 / (double)(base.Height - 9));
						this.color_0 = GClass47.ColorPicker.Control0.Class49.smethod_6(this.class50_0);
						return;
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_1:
						this.class50_0.method_3(1.0 - (double)this.int_0 / (double)(base.Height - 9));
						this.color_0 = GClass47.ColorPicker.Control0.Class49.smethod_6(this.class50_0);
						return;
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_2:
						this.class50_0.method_5(1.0 - (double)this.int_0 / (double)(base.Height - 9));
						this.color_0 = GClass47.ColorPicker.Control0.Class49.smethod_6(this.class50_0);
						return;
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_3:
						this.color_0 = Color.FromArgb(255 - this.method_21(255.0 * (double)this.int_0 / (double)(base.Height - 9)), (int)this.color_0.G, (int)this.color_0.B);
						this.class50_0 = GClass47.ColorPicker.Control0.Class49.smethod_7(this.color_0);
						return;
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_4:
						this.color_0 = Color.FromArgb((int)this.color_0.R, 255 - this.method_21(255.0 * (double)this.int_0 / (double)(base.Height - 9)), (int)this.color_0.B);
						this.class50_0 = GClass47.ColorPicker.Control0.Class49.smethod_7(this.color_0);
						return;
					case GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4.const_5:
						this.color_0 = Color.FromArgb((int)this.color_0.R, (int)this.color_0.G, 255 - this.method_21(255.0 * (double)this.int_0 / (double)(base.Height - 9)));
						this.class50_0 = GClass47.ColorPicker.Control0.Class49.smethod_7(this.color_0);
						return;
					default:
						return;
					}
				}

				int method_21(double double_0)
				{
					int num = (int)double_0;
					int num2 = (int)(double_0 * 100.0);
					if (num2 % 100 >= 50)
					{
						num++;
					}
					return num;
				}

				int int_0;

				bool bool_0;

				GClass47.ColorPicker.Control0.ctrl1DColorBar.Enum4 enum4_0;

				GClass47.ColorPicker.Control0.Class49.Class50 class50_0;

				Color color_0;

				Container container_0;

				EventHandler eventHandler_0;

				public enum Enum4
				{
					const_0,
					const_1,
					const_2,
					const_3,
					const_4,
					const_5
				}
			}

			public class Class49
			{
				public static Color smethod_0(Color color_0, double double_0)
				{
					GClass47.ColorPicker.Control0.Class49.Class50 @class = GClass47.ColorPicker.Control0.Class49.smethod_7(color_0);
					@class.method_5(double_0);
					return GClass47.ColorPicker.Control0.Class49.smethod_6(@class);
				}

				public static Color smethod_1(Color color_0, double double_0)
				{
					GClass47.ColorPicker.Control0.Class49.Class50 @class = GClass47.ColorPicker.Control0.Class49.smethod_7(color_0);
					GClass47.ColorPicker.Control0.Class49.Class50 class2 = @class;
					class2.method_5(class2.method_4() * double_0);
					return GClass47.ColorPicker.Control0.Class49.smethod_6(@class);
				}

				public static Color smethod_2(Color color_0, double double_0)
				{
					GClass47.ColorPicker.Control0.Class49.Class50 @class = GClass47.ColorPicker.Control0.Class49.smethod_7(color_0);
					@class.method_3(double_0);
					return GClass47.ColorPicker.Control0.Class49.smethod_6(@class);
				}

				public static Color smethod_3(Color color_0, double double_0)
				{
					GClass47.ColorPicker.Control0.Class49.Class50 @class = GClass47.ColorPicker.Control0.Class49.smethod_7(color_0);
					GClass47.ColorPicker.Control0.Class49.Class50 class2 = @class;
					class2.method_3(class2.method_2() * double_0);
					return GClass47.ColorPicker.Control0.Class49.smethod_6(@class);
				}

				public static Color smethod_4(Color color_0, double double_0)
				{
					GClass47.ColorPicker.Control0.Class49.Class50 @class = GClass47.ColorPicker.Control0.Class49.smethod_7(color_0);
					@class.method_1(double_0);
					return GClass47.ColorPicker.Control0.Class49.smethod_6(@class);
				}

				public static Color smethod_5(Color color_0, double double_0)
				{
					GClass47.ColorPicker.Control0.Class49.Class50 @class = GClass47.ColorPicker.Control0.Class49.smethod_7(color_0);
					GClass47.ColorPicker.Control0.Class49.Class50 class2 = @class;
					class2.method_1(class2.method_0() * double_0);
					return GClass47.ColorPicker.Control0.Class49.smethod_6(@class);
				}

				public static Color smethod_6(GClass47.ColorPicker.Control0.Class49.Class50 class50_0)
				{
					int num = GClass47.ColorPicker.Control0.Class49.smethod_10(class50_0.method_4() * 255.0);
					int num2 = GClass47.ColorPicker.Control0.Class49.smethod_10((1.0 - class50_0.method_2()) * (class50_0.method_4() / 1.0) * 255.0);
					double num3 = (double)(num - num2) / 255.0;
					if (class50_0.method_0() >= 0.0 && class50_0.method_0() <= 0.16666666666666666)
					{
						int num4 = GClass47.ColorPicker.Control0.Class49.smethod_10((class50_0.method_0() - 0.0) * num3 * 1530.0 + (double)num2);
						return Color.FromArgb(num, num4, num2);
					}
					if (class50_0.method_0() <= 0.33333333333333331)
					{
						int num4 = GClass47.ColorPicker.Control0.Class49.smethod_10(-((class50_0.method_0() - 0.16666666666666666) * num3) * 1530.0 + (double)num);
						return Color.FromArgb(num4, num, num2);
					}
					if (class50_0.method_0() <= 0.5)
					{
						int num4 = GClass47.ColorPicker.Control0.Class49.smethod_10((class50_0.method_0() - 0.33333333333333331) * num3 * 1530.0 + (double)num2);
						return Color.FromArgb(num2, num, num4);
					}
					if (class50_0.method_0() <= 0.66666666666666663)
					{
						int num4 = GClass47.ColorPicker.Control0.Class49.smethod_10(-((class50_0.method_0() - 0.5) * num3) * 1530.0 + (double)num);
						return Color.FromArgb(num2, num4, num);
					}
					if (class50_0.method_0() <= 0.83333333333333337)
					{
						int num4 = GClass47.ColorPicker.Control0.Class49.smethod_10((class50_0.method_0() - 0.66666666666666663) * num3 * 1530.0 + (double)num2);
						return Color.FromArgb(num4, num2, num);
					}
					if (class50_0.method_0() <= 1.0)
					{
						int num4 = GClass47.ColorPicker.Control0.Class49.smethod_10(-((class50_0.method_0() - 0.83333333333333337) * num3) * 1530.0 + (double)num);
						return Color.FromArgb(num, num2, num4);
					}
					return Color.FromArgb(0, 0, 0);
				}

				public static GClass47.ColorPicker.Control0.Class49.Class50 smethod_7(Color color_0)
				{
					GClass47.ColorPicker.Control0.Class49.Class50 @class = new GClass47.ColorPicker.Control0.Class49.Class50();
					int num;
					int num2;
					if (color_0.R > color_0.G)
					{
						num = (int)color_0.R;
						num2 = (int)color_0.G;
					}
					else
					{
						num = (int)color_0.G;
						num2 = (int)color_0.R;
					}
					if ((int)color_0.B > num)
					{
						num = (int)color_0.B;
					}
					else if ((int)color_0.B < num2)
					{
						num2 = (int)color_0.B;
					}
					int num3 = num - num2;
					@class.method_5((double)num / 255.0);
					if (num == 0)
					{
						@class.method_3(0.0);
					}
					else
					{
						@class.method_3((double)num3 / (double)num);
					}
					double num4;
					if (num3 == 0)
					{
						num4 = 0.0;
					}
					else
					{
						num4 = 60.0 / (double)num3;
					}
					if (num == (int)color_0.R)
					{
						if (color_0.G < color_0.B)
						{
							@class.method_1((360.0 + num4 * (double)(color_0.G - color_0.B)) / 360.0);
						}
						else
						{
							@class.method_1(num4 * (double)(color_0.G - color_0.B) / 360.0);
						}
					}
					else if (num == (int)color_0.G)
					{
						@class.method_1((120.0 + num4 * (double)(color_0.B - color_0.R)) / 360.0);
					}
					else if (num == (int)color_0.B)
					{
						@class.method_1((240.0 + num4 * (double)(color_0.R - color_0.G)) / 360.0);
					}
					else
					{
						@class.method_1(0.0);
					}
					return @class;
				}

				public static GClass47.ColorPicker.Control0.Class49.Class51 smethod_8(Color color_0)
				{
					GClass47.ColorPicker.Control0.Class49.Class51 @class = new GClass47.ColorPicker.Control0.Class49.Class51();
					double num = 1.0;
					@class.method_1((double)(byte.MaxValue - color_0.R) / 255.0);
					if (num > @class.method_0())
					{
						num = @class.method_0();
					}
					@class.method_3((double)(byte.MaxValue - color_0.G) / 255.0);
					if (num > @class.method_2())
					{
						num = @class.method_2();
					}
					@class.method_5((double)(byte.MaxValue - color_0.B) / 255.0);
					if (num > @class.method_4())
					{
						num = @class.method_4();
					}
					if (num > 0.0)
					{
						@class.method_7(num);
					}
					return @class;
				}

				public static Color smethod_9(GClass47.ColorPicker.Control0.Class49.Class51 class51_0)
				{
					int red = GClass47.ColorPicker.Control0.Class49.smethod_10(255.0 - 255.0 * class51_0.method_0());
					int green = GClass47.ColorPicker.Control0.Class49.smethod_10(255.0 - 255.0 * class51_0.method_2());
					int blue = GClass47.ColorPicker.Control0.Class49.smethod_10(255.0 - 255.0 * class51_0.method_4());
					return Color.FromArgb(red, green, blue);
				}

				static int smethod_10(double double_0)
				{
					int num = (int)double_0;
					int num2 = (int)(double_0 * 100.0);
					if (num2 % 100 >= 50)
					{
						num++;
					}
					return num;
				}

				public class Class50
				{
					public Class50()
					{
						this.double_0 = 0.0;
						this.double_1 = 0.0;
						this.double_2 = 0.0;
					}

					public double method_0()
					{
						return this.double_0;
					}

					public void method_1(double double_3)
					{
						this.double_0 = double_3;
						this.double_0 = ((this.double_0 > 1.0) ? 1.0 : ((this.double_0 < 0.0) ? 0.0 : this.double_0));
					}

					public double method_2()
					{
						return this.double_1;
					}

					public void method_3(double double_3)
					{
						this.double_1 = double_3;
						this.double_1 = ((this.double_1 > 1.0) ? 1.0 : ((this.double_1 < 0.0) ? 0.0 : this.double_1));
					}

					public double method_4()
					{
						return this.double_2;
					}

					public void method_5(double double_3)
					{
						this.double_2 = double_3;
						this.double_2 = ((this.double_2 > 1.0) ? 1.0 : ((this.double_2 < 0.0) ? 0.0 : this.double_2));
					}

					double double_0;

					double double_1;

					double double_2;
				}

				public class Class51
				{
					public Class51()
					{
						this.double_0 = 0.0;
						this.double_1 = 0.0;
						this.double_2 = 0.0;
						this.double_3 = 0.0;
					}

					public double method_0()
					{
						return this.double_0;
					}

					public void method_1(double double_4)
					{
						this.double_0 = double_4;
						this.double_0 = ((this.double_0 > 1.0) ? 1.0 : ((this.double_0 < 0.0) ? 0.0 : this.double_0));
					}

					public double method_2()
					{
						return this.double_1;
					}

					public void method_3(double double_4)
					{
						this.double_1 = double_4;
						this.double_1 = ((this.double_1 > 1.0) ? 1.0 : ((this.double_1 < 0.0) ? 0.0 : this.double_1));
					}

					public double method_4()
					{
						return this.double_2;
					}

					public void method_5(double double_4)
					{
						this.double_2 = double_4;
						this.double_2 = ((this.double_2 > 1.0) ? 1.0 : ((this.double_2 < 0.0) ? 0.0 : this.double_2));
					}

					public double method_6()
					{
						return this.double_3;
					}

					public void method_7(double double_4)
					{
						this.double_3 = double_4;
						this.double_3 = ((this.double_3 > 1.0) ? 1.0 : ((this.double_3 < 0.0) ? 0.0 : this.double_3));
					}

					double double_0;

					double double_1;

					double double_2;

					double double_3;
				}
			}
		}

		internal class Class52 : ListBox
		{
			protected override bool IsInputKey(Keys keyData)
			{
				return keyData == Keys.Return || base.IsInputKey(keyData);
			}
		}

		internal class Class53 : TabPage
		{
			protected virtual void OnPaintBackground(PaintEventArgs paintEventArgs_0)
			{
				if (GClass69.smethod_29())
				{
					int num = (int)paintEventArgs_0.Graphics.VisibleClipBounds.Left;
					int num2 = (int)paintEventArgs_0.Graphics.VisibleClipBounds.Top;
					int num3 = (int)paintEventArgs_0.Graphics.VisibleClipBounds.Width;
					int num4 = (int)paintEventArgs_0.Graphics.VisibleClipBounds.Height;
					if (num == 0 && num2 == 0 && num3 == base.Width)
					{
						if (num4 == base.Height)
						{
							GClass69.smethod_19(paintEventArgs_0.Graphics, new Rectangle(0, 0, base.Width, base.Height));
							return;
						}
					}
					this.method_0(paintEventArgs_0.Graphics, this, new Rectangle(num, num2, num3, num4), 0, 0);
					return;
				}
				base.OnPaintBackground(paintEventArgs_0);
			}

			bool method_0(Graphics graphics_0, Control control_0, Rectangle rectangle_0, int int_0, int int_1)
			{
				foreach (object obj in control_0.Controls)
				{
					Control control = (Control)obj;
					Rectangle rectangle = new Rectangle(control.Location, control.Size);
					if (rectangle.Contains(rectangle_0))
					{
						Rectangle rectangle_ = rectangle_0;
						rectangle_.Offset(-control.Left, -control.Top);
						if (this.method_0(graphics_0, control, rectangle_, int_0 + control.Left, int_1 + control.Top))
						{
							return true;
						}
						GClass69.smethod_20(graphics_0, new Rectangle(-int_0, -int_1, base.Width, base.Height), new Rectangle(control.Left, control.Top, control.Width, control.Height));
						return true;
					}
				}
				return false;
			}
		}

		class Class54 : IComparer
		{
			public int Compare(object object_0, object object_1)
			{
				Color color = (Color)object_0;
				Color color2 = (Color)object_1;
				if (color.A < color2.A)
				{
					return -1;
				}
				if (color.A > color2.A)
				{
					return 1;
				}
				if (color.GetHue() < color2.GetHue())
				{
					return -1;
				}
				if (color.GetHue() > color2.GetHue())
				{
					return 1;
				}
				if (color.GetSaturation() < color2.GetSaturation())
				{
					return -1;
				}
				if (color.GetSaturation() > color2.GetSaturation())
				{
					return 1;
				}
				if (color.GetBrightness() < color2.GetBrightness())
				{
					return -1;
				}
				if (color.GetBrightness() > color2.GetBrightness())
				{
					return 1;
				}
				return 0;
			}
		}

		class Class55 : IComparer
		{
			public int Compare(object object_0, object object_1)
			{
				return string.Compare(((Color)object_0).Name, ((Color)object_1).Name, false, CultureInfo.InvariantCulture);
			}
		}
	}
}
