using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

class Class64 : GClass106
{
	public Class64(GInterface37 ginterface37_1, GClass123 gclass123_1, GClass35 gclass35_1) : base(ginterface37_1, gclass123_1)
	{
		this.gclass35_0 = gclass35_1;
		this.gclass35_0.method_5(new GDelegate0(this.method_20));
		this.gclass35_0.method_8(new GDelegate0(this.method_20));
		this.gclass35_0.method_13(new GDelegate0(this.method_20));
		this.gclass35_0.method_15(new EventHandler(this.method_21));
		base.method_1(this.gclass35_0.method_17());
		this.method_16();
		this.method_15();
		this.bool_1 = true;
		this.font_1 = new Font(Class109.smethod_15()[0], 11f);
		this.font_2 = new Font(Class109.smethod_15()[0], 20f);
		this.font_3 = new Font("Tahoma", 5.7f);
		this.int_8 = this.font_2.Height * 2;
		this.brush_0 = Brushes.Gray;
		this.brush_1 = Brushes.Black;
		this.brush_2 = Brushes.Red;
		this.pen_1 = Pens.Gray;
		this.pen_2 = Pens.DarkGray;
		this.pen_3 = Pens.LightGray;
		this.pen_0 = Pens.Black;
		this.pen_4 = Pens.Blue;
	}

	public override void Dispose()
	{
		this.timer_0.Dispose();
		this.brush_0.Dispose();
		this.pen_1.Dispose();
		this.pen_2.Dispose();
		this.pen_3.Dispose();
		this.pen_0.Dispose();
		this.pen_4.Dispose();
		this.brush_1.Dispose();
		this.brush_2.Dispose();
		this.font_3.Dispose();
		this.font_2.Dispose();
		this.font_1.Dispose();
		if (this.gclass71_0 != null)
		{
			this.gclass71_0.method_4(new EventHandler(this.method_19));
		}
		this.gclass35_0.method_6(new GDelegate0(this.method_20));
		this.gclass35_0.method_9(new GDelegate0(this.method_20));
		this.gclass35_0.method_14(new GDelegate0(this.method_20));
	}

	public override void vmethod_5(ToolStrip[] toolStrip_0)
	{
		base.vmethod_5(toolStrip_0);
		foreach (ToolStrip toolStrip in toolStrip_0)
		{
			if (toolStrip.Name == "tsNotesEditor")
			{
				ToolStripItem[] array = toolStrip.Items.Find("tsbEditNotes", false);
				this.toolStripButton_0 = (array[0] as ToolStripButton);
				array = toolStrip.Items.Find("tsbInsertNotes", false);
				this.toolStripButton_1 = (array[0] as ToolStripButton);
				array = toolStrip.Items.Find("tsbEditBeats", false);
				this.toolStripButton_2 = (array[0] as ToolStripButton);
			}
		}
		this.toolStripButton_0.Click += this.toolStripButton_1_Click;
		this.toolStripButton_2.Click += this.toolStripButton_1_Click;
		this.toolStripButton_1.Click += this.toolStripButton_1_Click;
		this.method_14();
	}

	public override void vmethod_6()
	{
		base.vmethod_6();
		this.toolStripButton_0.Click -= this.toolStripButton_1_Click;
		this.toolStripButton_2.Click -= this.toolStripButton_1_Click;
		this.toolStripButton_1.Click -= this.toolStripButton_1_Click;
		this.toolStripButton_2 = null;
		this.toolStripButton_0 = null;
		this.toolStripButton_1 = null;
	}

	void toolStripButton_1_Click(object sender, EventArgs e)
	{
		Class64.Enum13 @enum = this.enum13_0;
		if (sender == this.toolStripButton_0)
		{
			this.enum13_0 = Class64.Enum13.const_0;
		}
		else if (sender == this.toolStripButton_2)
		{
			this.enum13_0 = Class64.Enum13.const_2;
		}
		else if (sender == this.toolStripButton_1)
		{
			this.enum13_0 = Class64.Enum13.const_1;
		}
		if (this.enum13_0 == @enum)
		{
			return;
		}
		this.method_14();
		if (this.enum13_0 == Class64.Enum13.const_2 || ((this.enum13_0 == Class64.Enum13.const_0 || this.enum13_0 == Class64.Enum13.const_1) && @enum == Class64.Enum13.const_2))
		{
			this.method_25();
		}
	}

	void method_14()
	{
		this.toolStripButton_2.Enabled = (this.enum13_0 != Class64.Enum13.const_2);
		this.toolStripButton_2.Checked = (this.enum13_0 == Class64.Enum13.const_2);
		this.toolStripButton_0.Enabled = (this.enum13_0 != Class64.Enum13.const_0);
		this.toolStripButton_0.Checked = (this.enum13_0 == Class64.Enum13.const_0);
		this.toolStripButton_1.Enabled = (this.enum13_0 != Class64.Enum13.const_1);
		this.toolStripButton_1.Checked = (this.enum13_0 == Class64.Enum13.const_1);
	}

	public override void vmethod_1()
	{
		this.method_15();
		this.method_25();
	}

	void method_15()
	{
		int num = base.method_10().Top;
		this.int_1 = num;
		num += 1 + this.int_2;
		this.int_3 = num;
		num += 1 + this.int_4;
		this.int_5 = num;
		num += 1 + this.int_6;
		this.int_7 = num;
		num += 1 + this.int_8;
		this.rectangle_1 = new Rectangle(base.method_10().Left, this.int_1, base.method_10().Width, this.int_2);
		this.rectangle_4 = new Rectangle(base.method_10().Left, this.int_5, base.method_10().Width, this.int_6);
		this.rectangle_2 = new Rectangle(base.method_10().Left, this.int_3, base.method_10().Width, this.int_4);
		this.rectangle_3 = new Rectangle(base.method_10().Left, this.int_7, base.method_10().Width, this.int_8);
	}

	void method_16()
	{
		base.method_9(this.int_2 + 1 + this.int_4 + 1 + this.int_8 + 1 + this.int_6 + 1 + 2 + 8);
	}

	public override bool vmethod_0()
	{
		return true;
	}

	public GClass71 method_17()
	{
		return this.gclass71_0;
	}

	public void method_18(GClass71 gclass71_1)
	{
		if (gclass71_1 == this.gclass71_0)
		{
			return;
		}
		if (this.gclass71_0 != null)
		{
			this.gclass71_0.method_4(new EventHandler(this.method_19));
		}
		this.gclass71_0 = gclass71_1;
		this.gclass71_0.method_3(new EventHandler(this.method_19));
		this.method_22();
	}

	void method_19(object sender, EventArgs e)
	{
		this.method_22();
	}

	void method_20(GClass33 gclass33_0)
	{
		this.vmethod_2();
		this.method_23();
	}

	void method_21(object sender, EventArgs e)
	{
		base.method_1(this.gclass35_0.method_17());
		base.method_0().Invalidate(base.method_10());
	}

	void method_22()
	{
		base.method_0().Invalidate(this.rectangle_1);
	}

	void method_23()
	{
		base.method_0().Invalidate(this.rectangle_4);
	}

	void method_24()
	{
		base.method_0().Invalidate(this.rectangle_2);
	}

	public override void vmethod_2()
	{
		this.list_0.Clear();
		this.list_1.Clear();
		double num = base.method_0().imethod_0();
		int num2 = base.method_0().imethod_1();
		int num3 = base.method_0().imethod_11().method_11().method_22(base.method_0().imethod_0() + base.method_0().imethod_9(base.method_10().Width));
		foreach (GClass151 gclass in base.method_0().imethod_11().method_11().method_23())
		{
			if (gclass.int_1 >= num2 && gclass.int_1 + base.method_0().imethod_11().method_9() <= num3)
			{
				Class64.Class116 @class = new Class64.Class116();
				@class.enum14_0 = Class64.Enum14.const_2;
				@class.gclass151_0 = gclass;
				@class.double_0 = gclass.double_0;
				@class.int_0 = base.method_0().imethod_10(@class.double_0 - base.method_0().imethod_0());
				this.list_1.Add(@class);
			}
		}
		List<GClass114> list = this.gclass35_0.method_2((GEnum50)this.genum53_0, num2, num3);
		if (list.Count > 0)
		{
			foreach (GClass114 gclass2 in list)
			{
				GClass115 gclass3 = gclass2 as GClass115;
				if (gclass3 != null)
				{
					double num4 = gclass3.method_5();
					int x = base.method_10().Left + base.method_0().imethod_10(num4 - num);
					Class64.Class117 class2 = new Class64.Class117();
					class2.gclass115_0 = gclass3;
					class2.double_0 = num4;
					class2.rectangle_0 = new Rectangle(x, this.int_5 + 2, Math.Max(12, base.method_0().imethod_10(gclass3.method_9())), 60);
					this.list_0.Add(class2);
				}
			}
		}
		List<GClass114> list2 = base.method_0().imethod_11().method_11().method_2(GEnum50.const_4, num2, num3);
		if (list2.Count > 0)
		{
			foreach (GClass114 gclass4 in list2)
			{
				Class64.Class116 class3 = null;
				if (gclass4 is GClass116)
				{
					class3 = new Class64.Class116();
					class3.enum14_0 = Class64.Enum14.const_0;
					class3.string_0 = "d=" + Class109.smethod_12((gclass4 as GClass116).method_10()).ToString(".00");
				}
				else if (gclass4 is GClass117)
				{
					class3 = new Class64.Class116();
					class3.enum14_0 = Class64.Enum14.const_1;
					class3.string_0 = "" + this.char_0[(gclass4 as GClass117).method_14() - 1] + this.char_1[(int)(gclass4 as GClass117).method_16()];
				}
				if (class3 != null)
				{
					class3.gclass114_0 = gclass4;
					class3.double_0 = gclass4.method_5();
					class3.int_0 = base.method_0().imethod_10(class3.double_0 - base.method_0().imethod_0());
					this.list_1.Add(class3);
				}
			}
		}
		this.method_25();
	}

	void method_25()
	{
		this.list_2.Clear();
		switch (this.enum13_0)
		{
		case Class64.Enum13.const_0:
		case Class64.Enum13.const_1:
			using (List<Class64.Class117>.Enumerator enumerator = this.list_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Class64.Class117 @class = enumerator.Current;
					Rectangle rectangle_ = new Rectangle(@class.rectangle_0.X, @class.rectangle_0.Y, 6, @class.rectangle_0.Height);
					Class64.Class118 class2;
					if (rectangle_.IntersectsWith(base.method_10()))
					{
						class2 = new Class64.Class118();
						class2.rectangle_0 = rectangle_;
						class2.object_0 = @class;
						class2.enum18_0 = (Class64.Enum18.flag_0 | Class64.Enum18.flag_3);
						class2.enum17_0 = Class64.Enum17.const_0;
						class2.cursor_0 = Cursors.Hand;
						this.list_2.Add(class2);
					}
					Rectangle rectangle_2 = new Rectangle(@class.rectangle_0.Right - 4, @class.rectangle_0.Y, 4, @class.rectangle_0.Height);
					if (rectangle_2.IntersectsWith(base.method_10()))
					{
						class2 = new Class64.Class118();
						class2.rectangle_0 = rectangle_2;
						class2.object_0 = @class;
						class2.enum18_0 = Class64.Enum18.flag_2;
						class2.enum17_0 = Class64.Enum17.const_3;
						class2.cursor_0 = Cursors.SizeWE;
						this.list_2.Add(class2);
					}
					class2 = new Class64.Class118();
					class2.rectangle_0 = @class.rectangle_0;
					class2.object_0 = @class;
					class2.enum18_0 = Class64.Enum18.flag_1;
					class2.enum17_0 = Class64.Enum17.const_1;
					class2.cursor_0 = Cursors.SizeAll;
					this.list_2.Add(class2);
				}
				return;
			}
			break;
		case Class64.Enum13.const_2:
			break;
		default:
			return;
		}
		foreach (Class64.Class116 class3 in this.list_1)
		{
			if (class3.enum14_0 == Class64.Enum14.const_2)
			{
				Rectangle rectangle_3 = new Rectangle(class3.int_0 - 3, this.int_5 + 2 + 6, 6, 48);
				if (rectangle_3.IntersectsWith(base.method_10()))
				{
					Class64.Class118 class2 = new Class64.Class118();
					class2.rectangle_0 = rectangle_3;
					class2.object_0 = class3.gclass151_0;
					class2.enum18_0 = Class64.Enum18.flag_1;
					class2.enum17_0 = Class64.Enum17.const_2;
					class2.cursor_0 = Cursors.VSplit;
					this.list_2.Add(class2);
				}
			}
		}
	}

	public override void vmethod_7(MouseEventArgs mouseEventArgs_1)
	{
		bool flag = false;
		if ((this.enum16_0 == Class64.Enum16.const_0 || this.enum16_0 == Class64.Enum16.const_4) && this.mouseEventArgs_0 != null && this.class118_1 != null)
		{
			if ((this.class118_1.enum18_0 & Class64.Enum18.flag_1) != (Class64.Enum18)0)
			{
				this.enum16_0 = Class64.Enum16.const_2;
			}
			else if ((this.class118_1.enum18_0 & Class64.Enum18.flag_2) != (Class64.Enum18)0)
			{
				this.enum16_0 = Class64.Enum16.const_3;
			}
		}
		switch (this.enum16_0)
		{
		case Class64.Enum16.const_0:
		case Class64.Enum16.const_4:
		{
			Class64.Class118 @class = null;
			foreach (Class64.Class118 class2 in this.list_2)
			{
				if (class2.rectangle_0.Contains(mouseEventArgs_1.Location))
				{
					@class = class2;
					break;
				}
			}
			if (@class != this.class118_0)
			{
				this.class118_0 = @class;
				flag = true;
			}
			else if (@class != null)
			{
				this.enum16_0 = Class64.Enum16.const_4;
				if ((@class.enum18_0 & Class64.Enum18.flag_3) != (Class64.Enum18)0)
				{
					flag = true;
				}
			}
			break;
		}
		case Class64.Enum16.const_2:
		case Class64.Enum16.const_3:
			this.class118_1.rectangle_1 = this.class118_1.rectangle_0;
			this.class118_1.rectangle_1.Offset(mouseEventArgs_1.X - this.mouseEventArgs_0.X, 0);
			break;
		}
		if (this.enum16_0 == Class64.Enum16.const_2 || this.enum16_0 == Class64.Enum16.const_3)
		{
			int num = -1;
			switch (this.class118_1.enum17_0)
			{
			case Class64.Enum17.const_1:
				num = this.class118_1.rectangle_1.Left;
				break;
			case Class64.Enum17.const_2:
				num = this.class118_1.rectangle_1.Left + this.class118_1.rectangle_1.Width / 2;
				break;
			case Class64.Enum17.const_3:
				num = this.class118_1.rectangle_1.Right;
				break;
			}
			if (num != -1)
			{
				base.method_12(base.method_0().imethod_0() + base.method_0().imethod_9(num - base.method_10().Left));
			}
			else
			{
				base.method_12(-1.0);
			}
		}
		if (flag)
		{
			this.method_23();
		}
	}

	public override Cursor vmethod_3(MouseEventArgs mouseEventArgs_1, KeyEventArgs keyEventArgs_0)
	{
		Cursor result = Cursors.Default;
		if (this.class118_0 != null)
		{
			result = this.class118_0.cursor_0;
		}
		else if (this.enum13_0 == Class64.Enum13.const_1 && mouseEventArgs_1.Y >= this.int_5 + 2 && mouseEventArgs_1.Y < this.int_5 + 2 + 60)
		{
			result = Cursors.Hand;
		}
		return result;
	}

	public override void vmethod_11()
	{
		base.vmethod_11();
	}

	void method_26()
	{
		this.enum16_0 = Class64.Enum16.const_0;
		this.mouseEventArgs_0 = null;
		if (this.class118_1 != null)
		{
			this.class118_1.rectangle_1 = Rectangle.Empty;
		}
		this.class118_1 = null;
		base.method_12(-1.0);
	}

	public override void vmethod_12()
	{
		base.vmethod_12();
		this.method_26();
	}

	public override void vmethod_10(MouseEventArgs mouseEventArgs_1)
	{
	}

	public override void vmethod_8(MouseEventArgs mouseEventArgs_1)
	{
		base.vmethod_8(mouseEventArgs_1);
		this.class118_1 = this.class118_0;
		this.mouseEventArgs_0 = mouseEventArgs_1;
		if (this.enum13_0 == Class64.Enum13.const_1)
		{
		}
	}

	public override void vmethod_9(MouseEventArgs mouseEventArgs_1)
	{
		base.vmethod_9(mouseEventArgs_1);
		if (this.class118_0 == this.class118_1 && this.class118_0 != null)
		{
			switch (this.enum16_0)
			{
			case Class64.Enum16.const_0:
			case Class64.Enum16.const_4:
				if ((this.class118_0.enum18_0 & Class64.Enum18.flag_0) != (Class64.Enum18)0 && this.class118_0.object_0 is Class64.Class117)
				{
					int num = (mouseEventArgs_1.Y - this.class118_0.rectangle_0.Top) / 12;
					GClass115 gclass115_ = (this.class118_0.object_0 as Class64.Class117).gclass115_0;
					if (gclass115_.method_10((GEnum51)num) && !gclass115_.method_12())
					{
						base.method_3().method_17(new GClass52(gclass115_));
					}
					else
					{
						base.method_3().method_17(new GClass132(gclass115_, (GEnum51)num));
					}
				}
				break;
			case Class64.Enum16.const_2:
				if (this.class118_0.object_0 is Class64.Class117)
				{
					int num2 = Math.Max(0, base.method_0().imethod_11().method_11().method_22(base.method_0().imethod_0() + base.method_0().imethod_9(this.class118_0.rectangle_1.Left - base.method_10().Left)));
					base.method_3().method_17(new GClass53((this.class118_0.object_0 as Class64.Class117).gclass115_0, num2 - (this.class118_0.object_0 as Class64.Class117).gclass115_0.method_2(), false));
				}
				break;
			case Class64.Enum16.const_3:
				if (this.class118_0.object_0 is Class64.Class117)
				{
					int num3 = Math.Max(0, base.method_0().imethod_11().method_11().method_22(base.method_0().imethod_0() + base.method_0().imethod_9(this.class118_0.rectangle_1.Right - base.method_10().Left)));
					base.method_3().method_17(new GClass152((this.class118_0.object_0 as Class64.Class117).gclass115_0, num3 - (this.class118_0.object_0 as Class64.Class117).gclass115_0.method_4(), false));
				}
				break;
			}
		}
		this.method_26();
	}

	public override void vmethod_13(KeyEventArgs keyEventArgs_0)
	{
		base.vmethod_13(keyEventArgs_0);
		this.keys_0 = keyEventArgs_0.Modifiers;
	}

	public override void vmethod_14(KeyPressEventArgs keyPressEventArgs_0)
	{
		base.vmethod_14(keyPressEventArgs_0);
		this.keys_0 = Keys.None;
	}

	public override void vmethod_15(KeyEventArgs keyEventArgs_0)
	{
		base.vmethod_15(keyEventArgs_0);
		this.keys_0 = Keys.None;
	}

	public override void vmethod_4(GInterface7 ginterface7_0)
	{
		base.vmethod_4(ginterface7_0);
	}

	void method_27(Graphics graphics_0, Rectangle rectangle_5)
	{
		int num = this.int_7;
		int num2 = num + this.int_8;
		foreach (Class64.Class116 @class in this.list_1)
		{
			switch (@class.enum14_0)
			{
			case Class64.Enum14.const_0:
				graphics_0.DrawLine(this.pen_1, @class.int_0, num + 2, @class.int_0, num + 2 + 10);
				graphics_0.DrawString(@class.string_0, this.font_1, this.brush_1, (float)@class.int_0, (float)(num + 5));
				break;
			case Class64.Enum14.const_1:
				graphics_0.DrawLine(this.pen_3, @class.int_0, num + 2, @class.int_0, num + 2 + 10);
				graphics_0.DrawString(@class.string_0, this.font_2, this.brush_1, (float)@class.int_0, (float)(num2 - this.font_2.Height - 2));
				break;
			}
		}
	}

	void method_28(Graphics graphics_0, Rectangle rectangle_5)
	{
		int num = this.int_5 + 2 + 6;
		for (int i = 0; i < 5; i++)
		{
			graphics_0.DrawLine(this.pen_2, rectangle_5.Left, num + i * 12, rectangle_5.Right, num + i * 12);
		}
		base.method_0().imethod_1();
		base.method_0().imethod_11().method_11().method_22(base.method_0().imethod_0() + base.method_0().imethod_9(base.method_10().Width));
		foreach (Class64.Class116 @class in this.list_1)
		{
			if (@class.enum14_0 == Class64.Enum14.const_2)
			{
				int int_ = @class.int_0;
				if ((@class.gclass151_0.genum66_0 & GEnum66.const_0) != (GEnum66)0)
				{
					graphics_0.DrawLine(this.pen_0, int_, num, int_, num + 48);
				}
				else
				{
					graphics_0.DrawLine(this.pen_3, int_, num, int_, num + 48);
				}
			}
		}
		if (this.list_0.Count == 0)
		{
			return;
		}
		foreach (Class64.Class117 class2 in this.list_0)
		{
			double double_ = class2.double_0;
			double num2 = (double)class2.gclass115_0.method_7();
			Rectangle rectangle_6 = class2.rectangle_0;
			Class109.Enum12 @enum = (Class109.Enum12)0;
			bool flag = (class2.enum15_0 & Class64.Enum15.flag_2) != (Class64.Enum15)0;
			int left = rectangle_6.Left;
			if (flag)
			{
				graphics_0.DrawRectangle(this.pen_3, rectangle_6);
				if ((class2.enum15_0 & Class64.Enum15.flag_1) != (Class64.Enum15)0)
				{
					graphics_0.FillRectangle(this.brush_0, rectangle_6.Right - 4, rectangle_6.Top, 4, rectangle_6.Height);
				}
				else if ((class2.enum15_0 & Class64.Enum15.flag_3) != (Class64.Enum15)0)
				{
					int num3 = (class2.point_0.Y - rectangle_6.Top) / 12;
					Class109.smethod_19(graphics_0, (GEnum51)num3, (float)left, (float)num + (float)num3 * 12f, 6f, Class109.Enum12.flag_2);
				}
				graphics_0.DrawString(double_.ToString(), this.font_0, this.brush_0, (float)(left + 8), (float)(rectangle_6.Top + 6));
				graphics_0.DrawString(num2.ToString(), this.font_0, this.brush_0, (float)(left + 8), (float)(rectangle_6.Top + 6 + 12));
			}
			using (IEnumerator<GEnum51> enumerator3 = class2.gclass115_0.System.Collections.Generic.IEnumerable<GEnum51>.GetEnumerator())
			{
				while (enumerator3.MoveNext())
				{
					GEnum51 genum = enumerator3.Current;
					float float_ = (float)num + (float)genum * 12f;
					int num4 = Math.Max(left, base.method_10().Left);
					int num5 = Math.Min(rectangle_6.Right, base.method_10().Right) - num4;
					if (num5 > 0)
					{
						Class109.smethod_20(graphics_0, genum, (float)num4, float_, (float)num5, 3f, @enum | ((!class2.gclass115_0.method_13()) ? Class109.Enum12.flag_4 : ((Class109.Enum12)0)));
					}
					if (left >= rectangle_5.Left)
					{
						Class109.smethod_19(graphics_0, genum, (float)left, float_, 6f, @enum);
					}
				}
			}
		}
	}

	void method_29(Graphics graphics_0, Rectangle rectangle_5)
	{
		int num = this.int_1;
		graphics_0.DrawLine(this.pen_2, rectangle_5.Left, num + this.int_2 / 2, rectangle_5.Right, num + this.int_2 / 2);
		graphics_0.DrawLine(this.pen_3, rectangle_5.Left, num + this.int_2 / 4, rectangle_5.Right, num + this.int_2 / 4);
		graphics_0.DrawLine(this.pen_3, rectangle_5.Left, num + this.int_2 * 3 / 4, rectangle_5.Right, num + this.int_2 * 3 / 4);
		if (this.gclass71_0 == null)
		{
			return;
		}
		double num2 = base.method_0().imethod_9(1);
		base.method_0().imethod_0();
		base.method_0().imethod_9(rectangle_5.Left - base.method_10().Left);
		if (!this.bool_1)
		{
			graphics_0.DrawString("Delaying preview..", SystemFonts.MenuFont, this.brush_0, (float)(base.method_10().Left + 2), (float)(num + 14));
			return;
		}
		GClass64.GClass65[] array = this.gclass71_0.method_0().method_1(num2, new EventHandler(this.method_30));
		if (array == null)
		{
			graphics_0.DrawString("Generating preview..", SystemFonts.MenuFont, this.brush_0, (float)(base.method_10().Left + 2), (float)(num + 14));
			return;
		}
		float num3 = (float)(base.method_0().imethod_0() / num2);
		graphics_0.TranslateTransform((float)base.method_10().Left - num3, (float)this.int_1);
		foreach (GClass64.GClass65 gclass in array)
		{
			Rectangle rectangle = Rectangle.Round(gclass.graphicsPath_0.GetBounds());
			rectangle.Offset((int)(-(int)num3), base.method_10().Top);
			if (rectangle.IntersectsWith(rectangle_5))
			{
				graphics_0.DrawPath(this.pen_4, gclass.graphicsPath_0);
			}
		}
		graphics_0.TranslateTransform(num3 - (float)base.method_10().Left, (float)(-(float)this.int_1));
	}

	public override void vmethod_17(PaintEventArgs paintEventArgs_0)
	{
		if (paintEventArgs_0.ClipRectangle.IntersectsWith(this.rectangle_1))
		{
			this.method_29(paintEventArgs_0.Graphics, paintEventArgs_0.ClipRectangle);
		}
		if (paintEventArgs_0.ClipRectangle.IntersectsWith(this.rectangle_2))
		{
			base.method_13(paintEventArgs_0.Graphics, this.rectangle_2, paintEventArgs_0.ClipRectangle);
		}
		if (paintEventArgs_0.ClipRectangle.IntersectsWith(this.rectangle_3))
		{
			this.method_27(paintEventArgs_0.Graphics, paintEventArgs_0.ClipRectangle);
		}
		if (paintEventArgs_0.ClipRectangle.IntersectsWith(this.rectangle_4))
		{
			this.method_28(paintEventArgs_0.Graphics, paintEventArgs_0.ClipRectangle);
		}
		if (this.class118_0 != null)
		{
			if (this.class118_0.rectangle_0.IntersectsWith(paintEventArgs_0.ClipRectangle))
			{
				paintEventArgs_0.Graphics.DrawRectangle(Pens.Blue, this.class118_0.rectangle_0);
			}
			if (!this.class118_0.rectangle_1.IsEmpty && this.class118_0.rectangle_1.IntersectsWith(paintEventArgs_0.ClipRectangle))
			{
				paintEventArgs_0.Graphics.DrawRectangle(Pens.Red, this.class118_0.rectangle_1);
			}
		}
		base.vmethod_17(paintEventArgs_0);
	}

	[CompilerGenerated]
	void method_30(object sender, EventArgs e)
	{
		this.method_22();
	}

	int int_1;

	int int_2 = 100;

	int int_3;

	int int_4 = 10;

	int int_5;

	int int_6 = 64;

	int int_7;

	int int_8 = 50;

	Rectangle rectangle_1;

	Rectangle rectangle_2;

	Rectangle rectangle_3;

	Rectangle rectangle_4;

	Font font_1;

	Font font_2;

	Font font_3;

	Pen pen_2;

	Pen pen_3;

	Pen pen_4;

	Brush brush_1;

	Brush brush_2;

	Timer timer_0;

	bool bool_1;

	Class64.Enum13 enum13_0;

	GClass35 gclass35_0;

	GEnum53 genum53_0 = GEnum53.const_3;

	List<Class64.Class117> list_0 = new List<Class64.Class117>();

	List<Class64.Class116> list_1 = new List<Class64.Class116>();

	ToolStripButton toolStripButton_0;

	ToolStripButton toolStripButton_1;

	ToolStripButton toolStripButton_2;

	GClass71 gclass71_0;

	char[] char_0 = new char[]
	{
		'Q',
		'W',
		'E',
		'R',
		'T',
		'Y',
		'U',
		'I',
		'O',
		'P',
		'Å'
	};

	char[] char_1 = new char[]
	{
		'q',
		'w',
		'r',
		'i',
		'å'
	};

	List<Class64.Class118> list_2 = new List<Class64.Class118>();

	Class64.Class118 class118_0;

	Class64.Enum16 enum16_0;

	Class64.Class118 class118_1;

	MouseEventArgs mouseEventArgs_0;

	Keys keys_0;

	enum Enum13
	{
		const_0,
		const_1,
		const_2
	}

	enum Enum14
	{
		const_0,
		const_1,
		const_2,
		const_3
	}

	class Class116
	{
		public GClass114 gclass114_0;

		public GClass151 gclass151_0;

		public Class64.Enum14 enum14_0;

		public int int_0;

		public double double_0;

		public string string_0;
	}

	[Flags]
	enum Enum15
	{
		flag_0 = 1,
		flag_1 = 2,
		flag_2 = 4,
		flag_3 = 8
	}

	class Class117
	{
		public GClass115 gclass115_0;

		public Rectangle rectangle_0;

		public Class64.Enum15 enum15_0;

		public Point point_0;

		public double double_0;
	}

	enum Enum16
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4
	}

	enum Enum17
	{
		const_0,
		const_1,
		const_2,
		const_3
	}

	[Flags]
	enum Enum18
	{
		flag_0 = 1,
		flag_1 = 2,
		flag_2 = 4,
		flag_3 = 8
	}

	class Class118
	{
		public Rectangle rectangle_0;

		public Rectangle rectangle_1;

		public Class64.Enum18 enum18_0;

		public Class64.Enum17 enum17_0;

		public Cursor cursor_0;

		public object object_0;
	}
}
