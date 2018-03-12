using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GClass49 : GClass46
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

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_32(DrawItemEventHandler drawItemEventHandler_1)
	{
		this.drawItemEventHandler_0 = (DrawItemEventHandler)Delegate.Combine(this.drawItemEventHandler_0, drawItemEventHandler_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_33(DrawItemEventHandler drawItemEventHandler_1)
	{
		this.drawItemEventHandler_0 = (DrawItemEventHandler)Delegate.Remove(this.drawItemEventHandler_0, drawItemEventHandler_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_34(MeasureItemEventHandler measureItemEventHandler_1)
	{
		this.measureItemEventHandler_0 = (MeasureItemEventHandler)Delegate.Combine(this.measureItemEventHandler_0, measureItemEventHandler_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_35(MeasureItemEventHandler measureItemEventHandler_1)
	{
		this.measureItemEventHandler_0 = (MeasureItemEventHandler)Delegate.Remove(this.measureItemEventHandler_0, measureItemEventHandler_1);
	}

	public GClass49()
	{
		this.listBox_0 = new ListBox();
		this.listBox_0.BorderStyle = BorderStyle.None;
		this.listBox_0.Location = new Point(0, 0);
		this.listBox_0.Size = new Size(100, 100);
		this.listBox_0.Dock = DockStyle.Fill;
		this.listBox_0.DrawItem += this.listBox_0_DrawItem;
		this.listBox_0.MeasureItem += this.listBox_0_MeasureItem;
		this.listBox_0.MouseEnter += this.listBox_0_MouseEnter;
		this.listBox_0.KeyDown += this.listBox_0_KeyDown;
		this.listBox_0.KeyPress += base.vmethod_12;
		this.listBox_0.Click += this.listBox_0_Click;
		base.method_12().KeyDown += this.listBox_0_KeyDown;
		base.method_12().MouseWheel += this.vmethod_14;
		this.int_1 = 8;
		this.int_2 = 0;
		base.method_13().method_4(this.listBox_0);
	}

	protected override void vmethod_0(Rectangle rectangle_1)
	{
		GInterface2 ginterface = base.method_9().method_166().method_17(base.method_10().method_3());
		int num = ((GClass5)ginterface).method_18();
		base.method_12().Size = new Size(rectangle_1.Width - 1 - num, rectangle_1.Height - 1);
		base.method_12().Location = rectangle_1.Location;
		this.int_2 = rectangle_1.Width;
	}

	protected override void vmethod_1()
	{
		base.method_12().Text = base.method_8().method_5();
		this.listBox_0.SelectedItem = base.method_8().method_5();
	}

	protected override void vmethod_2()
	{
		base.method_8().method_6(base.method_12().Text);
	}

	public override void imethod_1()
	{
		this.listBox_0.SelectedIndexChanged += this.listBox_0_SelectedIndexChanged;
		base.GInterface3.imethod_1();
	}

	public override void imethod_2()
	{
		this.listBox_0.SelectedIndexChanged -= this.listBox_0_SelectedIndexChanged;
		base.GInterface3.imethod_2();
	}

	public override void imethod_3()
	{
		this.listBox_0.SelectedIndexChanged -= this.listBox_0_SelectedIndexChanged;
		base.imethod_3();
	}

	protected override void vmethod_9()
	{
		if (base.method_18() == -1)
		{
			base.method_13().Width = this.int_2;
			this.listBox_0.Width = this.int_2;
		}
		if (this.method_40())
		{
			int num = this.listBox_0.Height / this.method_42();
			if (num > this.method_36())
			{
				num = this.method_36();
			}
			if (this.listBox_0.Items.Count < this.method_36())
			{
				num = this.listBox_0.Items.Count;
			}
			if (num == 0)
			{
				num = 1;
			}
			base.method_13().Height = num * this.method_42() + 2;
			this.listBox_0.Height = num * this.method_42();
		}
		base.vmethod_9();
	}

	public int method_36()
	{
		return this.int_1;
	}

	public void method_37(int int_3)
	{
		if (int_3 < 1 || int_3 > 100)
		{
			throw new ArgumentOutOfRangeException("MaxDropDownItems must be between 1 and 100");
		}
		this.int_1 = int_3;
	}

	public DrawMode method_38()
	{
		return this.listBox_0.DrawMode;
	}

	public void method_39(DrawMode drawMode_0)
	{
		if (!Enum.IsDefined(typeof(DrawMode), drawMode_0))
		{
			throw new InvalidEnumArgumentException("value", (int)drawMode_0, typeof(DrawMode));
		}
		this.listBox_0.DrawMode = drawMode_0;
	}

	public bool method_40()
	{
		return this.listBox_0.IntegralHeight;
	}

	public void method_41(bool bool_2)
	{
		this.listBox_0.IntegralHeight = bool_2;
	}

	public int method_42()
	{
		return this.listBox_0.ItemHeight;
	}

	public void method_43(int int_3)
	{
		this.listBox_0.ItemHeight = int_3;
	}

	public ListBox.ObjectCollection method_44()
	{
		return this.listBox_0.Items;
	}

	public int method_45()
	{
		return base.method_12().MaxLength;
	}

	public void method_46(int int_3)
	{
		base.method_12().MaxLength = int_3;
	}

	public int method_47()
	{
		return this.listBox_0.SelectedIndex;
	}

	public void method_48(int int_3)
	{
		this.listBox_0.SelectedIndex = int_3;
	}

	public object method_49()
	{
		return this.listBox_0.SelectedItem;
	}

	public void method_50(object object_0)
	{
		this.listBox_0.SelectedItem = object_0;
	}

	protected virtual void listBox_0_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyData == Keys.Up)
		{
			int num = this.method_47();
			if (num == -1)
			{
				this.method_48(0);
			}
			else if (num > 0)
			{
				this.method_48(this.method_47() - 1);
			}
			e.Handled = true;
			return;
		}
		if (e.KeyData == Keys.Down)
		{
			int num2 = this.method_47();
			if (num2 == -1)
			{
				this.method_48(0);
			}
			else if (num2 < this.method_44().Count - 1)
			{
				this.method_48(this.method_47() + 1);
			}
			e.Handled = true;
		}
	}

	protected virtual void vmethod_14(object sender, MouseEventArgs e)
	{
		int num = this.method_47();
		if (num == -1)
		{
			this.method_48(0);
			return;
		}
		if (e.Delta > 0)
		{
			if (num > 0)
			{
				this.method_48(this.method_47() - 1);
				return;
			}
		}
		else if (num < this.method_44().Count - 1)
		{
			this.method_48(this.method_47() + 1);
		}
	}

	protected virtual void vmethod_15(DrawItemEventArgs drawItemEventArgs_0)
	{
		if (this.drawItemEventHandler_0 != null)
		{
			this.drawItemEventHandler_0(this, drawItemEventArgs_0);
		}
	}

	protected virtual void vmethod_16(MeasureItemEventArgs measureItemEventArgs_0)
	{
		if (this.measureItemEventHandler_0 != null)
		{
			this.measureItemEventHandler_0(this, measureItemEventArgs_0);
		}
	}

	protected virtual void vmethod_17(EventArgs eventArgs_0)
	{
		if (this.eventHandler_0 != null)
		{
			this.eventHandler_0(this, eventArgs_0);
		}
		base.method_12().Text = this.method_49().ToString();
	}

	void listBox_0_Click(object sender, EventArgs e)
	{
		base.method_15(false);
		base.method_9().method_122();
	}

	void listBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		this.vmethod_17(e);
	}

	void listBox_0_MouseEnter(object sender, EventArgs e)
	{
		base.method_9().method_267(base.method_10());
	}

	void listBox_0_DrawItem(object sender, DrawItemEventArgs e)
	{
		this.vmethod_15(e);
	}

	void listBox_0_MeasureItem(object sender, MeasureItemEventArgs e)
	{
		this.vmethod_16(e);
	}

	EventHandler eventHandler_0;

	DrawItemEventHandler drawItemEventHandler_0;

	MeasureItemEventHandler measureItemEventHandler_0;

	ListBox listBox_0;

	int int_1;

	int int_2;
}
