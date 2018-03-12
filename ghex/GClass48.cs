using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GClass48 : GClass46
{
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_30(DateRangeEventHandler dateRangeEventHandler_1)
	{
		this.dateRangeEventHandler_0 = (DateRangeEventHandler)Delegate.Combine(this.dateRangeEventHandler_0, dateRangeEventHandler_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_31(DateRangeEventHandler dateRangeEventHandler_1)
	{
		this.dateRangeEventHandler_0 = (DateRangeEventHandler)Delegate.Remove(this.dateRangeEventHandler_0, dateRangeEventHandler_1);
	}

	public GClass48()
	{
		this.monthCalendar_0 = new MonthCalendar();
		this.monthCalendar_0.Location = new Point(0, 0);
		this.monthCalendar_0.MaxSelectionCount = 1;
		base.method_13().Width = this.monthCalendar_0.Width + 2;
		base.method_13().Height = this.monthCalendar_0.Height + 2;
		base.method_13().method_4(this.monthCalendar_0);
		base.method_20(GEnum56.const_1);
	}

	protected override void vmethod_0(Rectangle rectangle_1)
	{
		GInterface2 ginterface = base.method_9().method_166().method_17(base.method_10().method_3());
		int num = ((GClass4)ginterface).method_18();
		base.method_12().Size = new Size(rectangle_1.Width - 1 - num, rectangle_1.Height - 1);
		base.method_12().Location = rectangle_1.Location;
	}

	protected override void vmethod_1()
	{
		DateTime selectionStart = DateTime.Now;
		string format = GClass22.string_3;
		if (base.method_8().method_7() != null && base.method_8().method_7() is DateTime)
		{
			selectionStart = (DateTime)base.method_8().method_7();
			if (base.method_9().method_166().method_23().method_8(base.method_10().method_3()) is GClass22)
			{
				GClass22 gclass = (GClass22)base.method_9().method_166().method_23().method_8(base.method_10().method_3());
				DateTimePickerFormat dateTimePickerFormat = gclass.method_48();
				switch (dateTimePickerFormat)
				{
				case DateTimePickerFormat.Short:
					format = GClass22.string_4;
					break;
				case (DateTimePickerFormat)3:
					break;
				case DateTimePickerFormat.Time:
					format = GClass22.string_5;
					break;
				default:
					if (dateTimePickerFormat == DateTimePickerFormat.Custom)
					{
						format = gclass.method_50();
					}
					break;
				}
			}
		}
		this.monthCalendar_0.SelectionStart = selectionStart;
		base.method_12().Text = selectionStart.ToString(format);
	}

	protected override void vmethod_2()
	{
		base.method_8().method_8(this.monthCalendar_0.SelectionStart);
	}

	public override void imethod_1()
	{
		this.monthCalendar_0.DateSelected += this.monthCalendar_0_DateSelected;
		base.method_12().SelectionLength = 0;
		base.GInterface3.imethod_1();
	}

	public override void imethod_2()
	{
		this.monthCalendar_0.DateSelected -= this.monthCalendar_0_DateSelected;
		base.GInterface3.imethod_2();
	}

	public override void imethod_3()
	{
		this.monthCalendar_0.DateSelected -= this.monthCalendar_0_DateSelected;
		base.imethod_3();
	}

	public GEnum56 method_32()
	{
		return base.method_19();
	}

	public void method_33(GEnum56 genum56_1)
	{
		throw new NotSupportedException();
	}

	protected virtual void vmethod_14(DateRangeEventArgs dateRangeEventArgs_0)
	{
		if (this.dateRangeEventHandler_0 != null)
		{
			this.dateRangeEventHandler_0(this, dateRangeEventArgs_0);
		}
	}

	void monthCalendar_0_DateSelected(object sender, DateRangeEventArgs e)
	{
		base.method_15(false);
		this.vmethod_14(e);
		base.method_9().method_122();
	}

	DateRangeEventHandler dateRangeEventHandler_0;

	MonthCalendar monthCalendar_0;
}
