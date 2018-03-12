using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public abstract class GClass46 : GClass45, GInterface6
{
	public GClass46()
	{
		TextBox textBox = new TextBox();
		textBox.AutoSize = false;
		textBox.BackColor = SystemColors.Window;
		textBox.BorderStyle = BorderStyle.None;
		textBox.MouseEnter += this.method_29;
		base.method_7(textBox);
		this.gform0_0 = new GForm0(this);
		this.bool_0 = false;
		this.method_20(GEnum56.const_1);
		this.int_0 = -1;
		this.form_0 = null;
		this.class8_0 = new GClass46.Class8(this);
		this.bool_1 = false;
	}

	public override bool imethod_0(GClass97 gclass97_1, GControl2 gcontrol2_1, GStruct9 gstruct9_1, Rectangle rectangle_1, bool bool_2)
	{
		if (!(gcontrol2_1.method_166().method_23().method_8(gstruct9_1.method_3()) is GClass19))
		{
			throw new InvalidOperationException("Cannot edit Cell as DropDownCellEditor can only be used with a DropDownColumn");
		}
		return base.imethod_0(gclass97_1, gcontrol2_1, gstruct9_1, rectangle_1, bool_2);
	}

	public override void imethod_1()
	{
		this.method_12().KeyPress += this.vmethod_12;
		this.method_12().LostFocus += this.vmethod_13;
		base.GInterface3.imethod_1();
		this.form_0 = base.method_9().FindForm();
		if (this.method_14())
		{
			this.vmethod_9();
		}
		this.method_12().Focus();
	}

	public override void imethod_2()
	{
		this.method_12().KeyPress -= this.vmethod_12;
		this.method_12().LostFocus -= this.vmethod_13;
		base.GInterface3.imethod_2();
		this.method_15(false);
		this.form_0 = null;
	}

	public override void imethod_3()
	{
		this.method_12().KeyPress -= this.vmethod_12;
		this.method_12().LostFocus -= this.vmethod_13;
		base.imethod_3();
		this.method_15(false);
		this.form_0 = null;
	}

	protected virtual void vmethod_9()
	{
		Point point = base.method_9().PointToScreen(this.method_12().Location);
		point.Y += this.method_12().Height + 1;
		Rectangle bounds = Screen.GetBounds(point);
		if (point.Y + this.gform0_0.Height > bounds.Bottom)
		{
			point.Y -= this.method_12().Height + this.gform0_0.Height + 1;
		}
		if (point.X + this.gform0_0.Width > bounds.Right)
		{
			GInterface2 ginterface = base.method_9().method_166().method_17(base.method_10().method_3());
			int num = ((GClass3)ginterface).method_18();
			point.X = point.X + this.method_12().Width + num - this.gform0_0.Width;
		}
		this.gform0_0.Location = point;
		this.form_0.AddOwnedForm(this.gform0_0);
		this.class8_0.method_0(this.form_0.Handle);
		this.gform0_0.method_0();
		this.gform0_0.Activate();
		Class96.keybd_event(9, 0, (Enum9)0, 0);
		Class96.keybd_event(9, 0, Enum9.const_1, 0);
		Class96.keybd_event(16, 0, (Enum9)0, 0);
		Class96.keybd_event(9, 0, (Enum9)0, 0);
		Class96.keybd_event(9, 0, Enum9.const_1, 0);
		Class96.keybd_event(16, 0, Enum9.const_1, 0);
	}

	protected virtual void vmethod_10()
	{
		this.gform0_0.method_1();
		this.form_0.RemoveOwnedForm(this.gform0_0);
		this.class8_0.method_1();
		this.form_0.Activate();
	}

	protected virtual bool vmethod_11(Control control_1, Point point_0)
	{
		return true;
	}

	public override bool imethod_4(Control control_1, GEnum8 genum8_0, int int_1, int int_2)
	{
		if (this.method_14())
		{
			if (genum8_0 != GEnum8.const_26 && genum8_0 != GEnum8.const_29 && genum8_0 != GEnum8.const_32 && genum8_0 != GEnum8.const_35 && genum8_0 != GEnum8.const_7 && genum8_0 != GEnum8.const_10 && genum8_0 != GEnum8.const_13)
			{
				if (genum8_0 != GEnum8.const_16)
				{
					if (genum8_0 != GEnum8.const_25)
					{
						return false;
					}
					Point position = Cursor.Position;
					if (!this.method_13().Bounds.Contains(position))
					{
						this.bool_1 = true;
						return false;
					}
					if (!this.bool_1)
					{
						this.bool_1 = true;
						base.method_9().method_267(base.method_10());
						return false;
					}
					return false;
				}
			}
			Point position2 = Cursor.Position;
			if (!this.method_13().Bounds.Contains(position2) && control_1 != base.method_9() && control_1 != this.method_12() && this.vmethod_11(control_1, position2))
			{
				base.method_9().method_122();
			}
		}
		return false;
	}

	public override bool imethod_0(Control control_1, GEnum8 genum8_0, int int_1, int int_2)
	{
		if (genum8_0 == GEnum8.const_19 && int_1 == 115 && (this.method_12().Focused || this.method_13().ContainsFocus))
		{
			this.method_15(!this.method_14());
			return true;
		}
		return false;
	}

	protected TextBox method_12()
	{
		return base.method_6() as TextBox;
	}

	protected GForm0 method_13()
	{
		return this.gform0_0;
	}

	public bool method_14()
	{
		return this.bool_0;
	}

	public void method_15(bool bool_2)
	{
		if (this.bool_0 != bool_2)
		{
			this.bool_0 = bool_2;
			if (bool_2)
			{
				this.vmethod_9();
				return;
			}
			this.vmethod_10();
		}
	}

	public int method_16()
	{
		if (this.int_0 != -1)
		{
			return this.int_0;
		}
		return this.gform0_0.Width;
	}

	public void method_17(int int_1)
	{
		this.int_0 = int_1;
		this.gform0_0.Width = int_1;
	}

	internal int method_18()
	{
		return this.int_0;
	}

	public GEnum56 method_19()
	{
		return this.genum56_0;
	}

	public void method_20(GEnum56 genum56_1)
	{
		if (!Enum.IsDefined(typeof(GEnum56), genum56_1))
		{
			throw new InvalidEnumArgumentException("value", (int)genum56_1, typeof(GEnum56));
		}
		if (this.genum56_0 != genum56_1)
		{
			this.genum56_0 = genum56_1;
			this.method_12().ReadOnly = (genum56_1 == GEnum56.const_1);
		}
	}

	public string method_21()
	{
		if (this.method_19() == GEnum56.const_1)
		{
			return "";
		}
		return this.method_12().SelectedText;
	}

	public void method_22(string string_0)
	{
		if (this.method_19() != GEnum56.const_1 && string_0 != null)
		{
			this.method_12().SelectedText = string_0;
		}
	}

	public int method_23()
	{
		return this.method_12().SelectionLength;
	}

	public void method_24(int int_1)
	{
		this.method_12().SelectionLength = int_1;
	}

	public int method_25()
	{
		return this.method_12().SelectionStart;
	}

	public void method_26(int int_1)
	{
		this.method_12().SelectionStart = int_1;
	}

	public string method_27()
	{
		return this.method_12().Text;
	}

	public void method_28(string string_0)
	{
		this.method_12().Text = string_0;
	}

	protected virtual void vmethod_12(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == GClass68.char_13)
		{
			if (base.method_9() != null)
			{
				base.method_9().method_122();
				return;
			}
		}
		else if (e.KeyChar == GClass68.char_27 && base.method_9() != null)
		{
			base.method_9().method_123();
		}
	}

	protected virtual void vmethod_13(object sender, EventArgs e)
	{
		if (!this.method_12().Focused && !this.method_13().ContainsFocus)
		{
			if (base.method_9() != null)
			{
				base.method_9().method_122();
			}
			return;
		}
	}

	public virtual void imethod_0(object sender, GEventArgs10 e)
	{
		this.method_15(!this.method_14());
	}

	public virtual void imethod_1(object sender, GEventArgs10 e)
	{
	}

	void method_29(object sender, EventArgs e)
	{
		base.method_9().method_267(base.method_10());
	}

	GForm0 gform0_0;

	bool bool_0;

	GEnum56 genum56_0;

	int int_0;

	GClass46.Class8 class8_0;

	Form form_0;

	bool bool_1;

	internal class Class8 : Class7
	{
		public Class8(GClass46 gclass46_1)
		{
			this.gclass46_0 = gclass46_1;
		}

		public GClass46 method_5()
		{
			return this.gclass46_0;
		}

		public void method_6(GClass46 gclass46_1)
		{
			this.gclass46_0 = gclass46_1;
		}

		protected override void vmethod_0(ref Message message_0)
		{
			base.vmethod_0(ref message_0);
			if (this.gclass46_0 != null && this.gclass46_0.method_14())
			{
				if (message_0.Msg == 134)
				{
					if ((int)message_0.WParam == 0)
					{
						Class96.SendMessage(base.method_4(), 134, 1, 0);
						return;
					}
				}
				else if (message_0.Msg == 28 && (int)message_0.WParam == 0)
				{
					this.gclass46_0.method_15(false);
					Class96.PostMessage(base.method_4(), 134, 0, 0);
				}
			}
		}

		GClass46 gclass46_0;
	}
}
