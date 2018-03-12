using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DefaultEvent("Changed")]
[DefaultProperty("Title")]
[ToolboxItem(false)]
public class GClass98 : Panel
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

	public Size method_2()
	{
		return base.Size;
	}

	public void method_3(Size size_0)
	{
		base.Size = size_0;
	}

	public bool method_4()
	{
		return this.bool_2;
	}

	public void method_5(bool bool_4)
	{
		if (this.bool_2 == bool_4)
		{
			return;
		}
		this.bool_2 = bool_4;
		this.vmethod_0();
	}

	internal RectangleF method_6()
	{
		return this.rectangleF_0;
	}

	internal void method_7(RectangleF rectangleF_1)
	{
		this.rectangleF_0 = rectangleF_1;
	}

	public bool method_8()
	{
		return this.bool_3;
	}

	public void method_9(bool bool_4)
	{
		if (this.bool_3 == bool_4)
		{
			return;
		}
		this.bool_3 = bool_4;
	}

	public Image method_10()
	{
		return this.image_0;
	}

	public void method_11(Image image_1)
	{
		this.image_0 = image_1;
	}

	public bool method_12()
	{
		return this.bool_0;
	}

	public void method_13(bool bool_4)
	{
		this.bool_0 = bool_4;
	}

	public string method_14()
	{
		return this.string_0;
	}

	public void method_15(string string_1)
	{
		if (this.string_0 == string_1)
		{
			return;
		}
		this.string_0 = string_1;
		this.vmethod_0();
	}

	public bool method_16()
	{
		return this.bool_1;
	}

	public void method_17(bool bool_4)
	{
		if (this.bool_1 == bool_4)
		{
			return;
		}
		this.bool_1 = bool_4;
	}

	public string method_18()
	{
		return this.method_14();
	}

	public GClass98() : this(string.Empty, null)
	{
	}

	public GClass98(Control control_0) : this(string.Empty, control_0)
	{
	}

	public GClass98(string string_1, Control control_0)
	{
		base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
		base.SetStyle(ControlStyles.ResizeRedraw, true);
		base.SetStyle(ControlStyles.UserPaint, true);
		base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
		base.SetStyle(ControlStyles.ContainerControl, true);
		this.bool_1 = false;
		this.method_5(true);
		this.method_23(string_1, control_0);
		if (control_0 != null)
		{
			base.Controls.Add(control_0);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (disposing && this.image_0 != null)
		{
			this.image_0.Dispose();
		}
	}

	public bool method_19()
	{
		return false;
	}

	public bool method_20()
	{
		return false;
	}

	public bool method_21()
	{
		return base.Controls != null && base.Controls.Count > 0;
	}

	public bool method_22()
	{
		return true;
	}

	void method_23(string string_1, Control control_0)
	{
		if (string_1.Length <= 0 && control_0 != null)
		{
			this.method_15(control_0.Text);
			return;
		}
		if (string_1 != null)
		{
			this.method_15(string_1);
			return;
		}
		this.method_15(string.Empty);
	}

	public void method_24(GClass98 gclass98_0)
	{
		this.method_5(gclass98_0.method_4());
		this.Text = gclass98_0.Text;
		this.method_13(gclass98_0.method_12());
		base.Tag = gclass98_0.Tag;
	}

	protected internal virtual void vmethod_0()
	{
		if (this.eventHandler_0 != null)
		{
			this.eventHandler_0(this, EventArgs.Empty);
		}
	}

	public virtual string ToString()
	{
		return this.method_18();
	}

	EventHandler eventHandler_0;

	RectangleF rectangleF_0 = Rectangle.Empty;

	Image image_0;

	bool bool_0 = true;

	bool bool_1;

	bool bool_2 = true;

	bool bool_3;

	string string_0 = string.Empty;
}
