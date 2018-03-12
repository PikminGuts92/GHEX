using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public abstract class GClass69
{
	public static void smethod_0(Graphics graphics_0, Rectangle rectangle_0, GEnum11 genum11_0)
	{
		GClass69.smethod_1(graphics_0, rectangle_0, rectangle_0, genum11_0);
	}

	public static void smethod_1(Graphics graphics_0, Rectangle rectangle_0, Rectangle rectangle_1, GEnum11 genum11_0)
	{
		if (graphics_0 == null || rectangle_0.Width <= 0 || rectangle_0.Height <= 0 || rectangle_1.Width <= 0 || rectangle_1.Height <= 0)
		{
			return;
		}
		if (GClass69.smethod_29())
		{
			GClass69.smethod_27(graphics_0, GClass81.smethod_0(), 1, (int)genum11_0, rectangle_0, rectangle_1);
			return;
		}
		ControlPaint.DrawButton(graphics_0, rectangle_0, GClass69.smethod_2(genum11_0));
	}

	static ButtonState smethod_2(GEnum11 genum11_0)
	{
		switch (genum11_0)
		{
		case GEnum11.const_2:
			return ButtonState.Pushed;
		case GEnum11.const_3:
			return ButtonState.Inactive;
		default:
			return ButtonState.Normal;
		}
	}

	public static void smethod_3(Graphics graphics_0, Rectangle rectangle_0, GEnum60 genum60_0)
	{
		GClass69.smethod_4(graphics_0, rectangle_0, rectangle_0, genum60_0);
	}

	public static void smethod_4(Graphics graphics_0, Rectangle rectangle_0, Rectangle rectangle_1, GEnum60 genum60_0)
	{
		if (graphics_0 == null || rectangle_0.Width <= 0 || rectangle_0.Height <= 0)
		{
			return;
		}
		if (GClass69.smethod_29())
		{
			GClass69.smethod_27(graphics_0, GClass81.smethod_0(), 3, (int)genum60_0, rectangle_0, rectangle_1);
			return;
		}
		if (GClass69.smethod_6(genum60_0))
		{
			ControlPaint.DrawMixedCheckBox(graphics_0, rectangle_0, GClass69.smethod_5(genum60_0));
			return;
		}
		ControlPaint.DrawCheckBox(graphics_0, rectangle_0, GClass69.smethod_5(genum60_0));
	}

	static ButtonState smethod_5(GEnum60 genum60_0)
	{
		switch (genum60_0)
		{
		case GEnum60.const_2:
			return ButtonState.Pushed;
		case GEnum60.const_3:
			return ButtonState.Inactive;
		case GEnum60.const_4:
		case GEnum60.const_5:
			return ButtonState.Checked;
		case GEnum60.const_6:
			return ButtonState.Checked | ButtonState.Pushed;
		case GEnum60.const_7:
			return ButtonState.Checked | ButtonState.Inactive;
		case GEnum60.const_8:
		case GEnum60.const_9:
			return ButtonState.Checked;
		case GEnum60.const_10:
			return ButtonState.Checked | ButtonState.Pushed;
		case GEnum60.const_11:
			return ButtonState.Checked | ButtonState.Inactive;
		default:
			return ButtonState.Normal;
		}
	}

	static bool smethod_6(GEnum60 genum60_0)
	{
		switch (genum60_0)
		{
		case GEnum60.const_8:
		case GEnum60.const_9:
		case GEnum60.const_10:
		case GEnum60.const_11:
			return true;
		default:
			return false;
		}
	}

	public static void smethod_7(Graphics graphics_0, Rectangle rectangle_0, GEnum12 genum12_0)
	{
		GClass69.smethod_8(graphics_0, rectangle_0, rectangle_0, genum12_0);
	}

	public static void smethod_8(Graphics graphics_0, Rectangle rectangle_0, Rectangle rectangle_1, GEnum12 genum12_0)
	{
		if (graphics_0 == null || rectangle_0.Width <= 0 || rectangle_0.Height <= 0 || rectangle_1.Width <= 0 || rectangle_1.Height <= 0)
		{
			return;
		}
		if (GClass69.smethod_29())
		{
			GClass69.smethod_27(graphics_0, GClass81.smethod_3(), 1, (int)genum12_0, rectangle_0, rectangle_1);
			return;
		}
		graphics_0.FillRectangle(SystemBrushes.Control, rectangle_0);
		if (genum12_0 == GEnum12.const_2)
		{
			graphics_0.DrawRectangle(SystemPens.ControlDark, rectangle_0.X, rectangle_0.Y, rectangle_0.Width - 1, rectangle_0.Height - 1);
			return;
		}
		ControlPaint.DrawBorder3D(graphics_0, rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height, Border3DStyle.RaisedInner);
	}

	public static void smethod_9(Graphics graphics_0, Rectangle rectangle_0, GEnum55 genum55_0)
	{
		GClass69.smethod_10(graphics_0, rectangle_0, rectangle_0, genum55_0);
	}

	public static void smethod_10(Graphics graphics_0, Rectangle rectangle_0, Rectangle rectangle_1, GEnum55 genum55_0)
	{
		if (graphics_0 == null || rectangle_0.Width <= 0 || rectangle_0.Height <= 0 || rectangle_1.Width <= 0 || rectangle_1.Height <= 0)
		{
			return;
		}
		if (GClass69.smethod_29())
		{
			GClass69.smethod_27(graphics_0, GClass81.smethod_1(), 1, (int)genum55_0, rectangle_0, rectangle_1);
			return;
		}
		ControlPaint.DrawComboButton(graphics_0, rectangle_0, GClass69.smethod_11(genum55_0));
	}

	static ButtonState smethod_11(GEnum55 genum55_0)
	{
		switch (genum55_0)
		{
		case GEnum55.const_2:
			return ButtonState.Pushed;
		case GEnum55.const_3:
			return ButtonState.Inactive;
		default:
			return ButtonState.Normal;
		}
	}

	public static void smethod_12(Graphics graphics_0, Rectangle rectangle_0)
	{
		GClass69.smethod_13(graphics_0, rectangle_0, rectangle_0);
	}

	public static void smethod_13(Graphics graphics_0, Rectangle rectangle_0, Rectangle rectangle_1)
	{
		if (graphics_0 == null || rectangle_0.Width <= 0 || rectangle_0.Height <= 0 || rectangle_1.Width <= 0 || rectangle_1.Height <= 0)
		{
			return;
		}
		if (GClass69.smethod_29())
		{
			GClass69.smethod_27(graphics_0, GClass81.smethod_5(), 1, 0, rectangle_0, rectangle_1);
			return;
		}
		graphics_0.FillRectangle(Brushes.White, rectangle_0);
		graphics_0.DrawRectangle(SystemPens.ControlDark, rectangle_0.Left, rectangle_0.Top, rectangle_0.Width - 1, rectangle_0.Height - 1);
	}

	public static void smethod_14(Graphics graphics_0, Rectangle rectangle_0)
	{
		GClass69.smethod_15(graphics_0, rectangle_0, rectangle_0);
	}

	public static void smethod_15(Graphics graphics_0, Rectangle rectangle_0, Rectangle rectangle_1)
	{
		if (graphics_0 == null || rectangle_0.Width <= 0 || rectangle_0.Height <= 0 || rectangle_1.Width <= 0 || rectangle_1.Height <= 0)
		{
			return;
		}
		if (GClass69.smethod_29())
		{
			GClass69.smethod_27(graphics_0, GClass81.smethod_5(), 3, 0, rectangle_0, rectangle_1);
			return;
		}
		graphics_0.FillRectangle(SystemBrushes.Highlight, rectangle_0);
	}

	public static void smethod_16(Graphics graphics_0, Rectangle rectangle_0, GEnum0 genum0_0)
	{
		GClass69.smethod_17(graphics_0, rectangle_0, rectangle_0, genum0_0);
	}

	public static void smethod_17(Graphics graphics_0, Rectangle rectangle_0, Rectangle rectangle_1, GEnum0 genum0_0)
	{
		if (graphics_0 == null || rectangle_0.Width <= 0 || rectangle_0.Height <= 0)
		{
			return;
		}
		if (GClass69.smethod_29())
		{
			GClass69.smethod_27(graphics_0, GClass81.smethod_0(), 2, (int)genum0_0, rectangle_0, rectangle_1);
			return;
		}
		ControlPaint.DrawRadioButton(graphics_0, rectangle_0, GClass69.smethod_18(genum0_0));
	}

	static ButtonState smethod_18(GEnum0 genum0_0)
	{
		switch (genum0_0)
		{
		case GEnum0.const_2:
			return ButtonState.Pushed;
		case GEnum0.const_3:
			return ButtonState.Inactive;
		case GEnum0.const_4:
		case GEnum0.const_5:
			return ButtonState.Checked;
		case GEnum0.const_6:
			return ButtonState.Checked | ButtonState.Pushed;
		case GEnum0.const_7:
			return ButtonState.Checked | ButtonState.Inactive;
		default:
			return ButtonState.Normal;
		}
	}

	internal static void smethod_19(Graphics graphics_0, Rectangle rectangle_0)
	{
		GClass69.smethod_20(graphics_0, rectangle_0, rectangle_0);
	}

	internal static void smethod_20(Graphics graphics_0, Rectangle rectangle_0, Rectangle rectangle_1)
	{
		if (graphics_0 == null || rectangle_0.Width <= 0 || rectangle_0.Height <= 0 || rectangle_1.Width <= 0 || rectangle_1.Height <= 0)
		{
			return;
		}
		if (GClass69.smethod_29())
		{
			GClass69.smethod_27(graphics_0, GClass81.smethod_6(), 10, 0, rectangle_0, rectangle_1);
			return;
		}
		graphics_0.FillRectangle(SystemBrushes.Control, Rectangle.Intersect(rectangle_1, rectangle_0));
	}

	public static void smethod_21(Graphics graphics_0, Rectangle rectangle_0, GEnum58 genum58_0)
	{
		GClass69.smethod_22(graphics_0, rectangle_0, rectangle_0, genum58_0);
	}

	public static void smethod_22(Graphics graphics_0, Rectangle rectangle_0, Rectangle rectangle_1, GEnum58 genum58_0)
	{
		if (graphics_0 == null || rectangle_0.Width <= 0 || rectangle_0.Height <= 0 || rectangle_1.Width <= 0 || rectangle_1.Height <= 0)
		{
			return;
		}
		if (GClass69.smethod_29())
		{
			GClass69.smethod_27(graphics_0, GClass81.smethod_2(), 1, (int)genum58_0, rectangle_0, rectangle_1);
			return;
		}
		ControlPaint.DrawBorder3D(graphics_0, rectangle_0, Border3DStyle.Sunken);
	}

	public static void smethod_23(Graphics graphics_0, Rectangle rectangle_0, GEnum41 genum41_0, Rectangle rectangle_1, GEnum41 genum41_1)
	{
		GClass69.smethod_24(graphics_0, rectangle_0, rectangle_0, genum41_0, rectangle_1, rectangle_1, genum41_1);
	}

	public static void smethod_24(Graphics graphics_0, Rectangle rectangle_0, Rectangle rectangle_1, GEnum41 genum41_0, Rectangle rectangle_2, Rectangle rectangle_3, GEnum41 genum41_1)
	{
		if (graphics_0 == null)
		{
			return;
		}
		if (rectangle_0.Width > 0 && rectangle_0.Height > 0 && rectangle_1.Width > 0 && rectangle_1.Height > 0)
		{
			if (GClass69.smethod_29())
			{
				GClass69.smethod_27(graphics_0, GClass81.smethod_7(), 1, (int)genum41_0, rectangle_0, rectangle_1);
			}
			else
			{
				ControlPaint.DrawScrollButton(graphics_0, rectangle_0, ScrollButton.Up, GClass69.smethod_25(genum41_0));
			}
		}
		if (rectangle_2.Width > 0 && rectangle_2.Height > 0 && rectangle_3.Width > 0 && rectangle_3.Height > 0)
		{
			if (GClass69.smethod_29())
			{
				GClass69.smethod_27(graphics_0, GClass81.smethod_7(), 2, (int)genum41_1, rectangle_2, rectangle_3);
				return;
			}
			ControlPaint.DrawScrollButton(graphics_0, rectangle_2, ScrollButton.Down, GClass69.smethod_25(genum41_1));
		}
	}

	static ButtonState smethod_25(GEnum41 genum41_0)
	{
		switch (genum41_0)
		{
		case GEnum41.const_2:
			return ButtonState.Pushed;
		case GEnum41.const_3:
			return ButtonState.Inactive;
		default:
			return ButtonState.Normal;
		}
	}

	public static void smethod_26(Graphics graphics_0, string string_0, int int_0, int int_1, Rectangle rectangle_0)
	{
		GClass69.smethod_27(graphics_0, string_0, int_0, int_1, rectangle_0, rectangle_0);
	}

	public static void smethod_27(Graphics graphics_0, string string_0, int int_0, int int_1, Rectangle rectangle_0, Rectangle rectangle_1)
	{
		if (graphics_0 != null && rectangle_0.Width > 0 && rectangle_0.Height > 0 && rectangle_1.Width > 0 && rectangle_1.Height > 0)
		{
			IntPtr intPtr = IntPtr.Zero;
			intPtr = Class96.OpenThemeData(intPtr, string_0);
			if (intPtr != IntPtr.Zero)
			{
				IntPtr hdc = graphics_0.GetHdc();
				Struct8 @struct = Struct8.smethod_0(rectangle_0);
				Struct8 struct2 = Struct8.smethod_0(rectangle_1);
				Class96.DrawThemeBackground(intPtr, hdc, int_0, int_1, ref @struct, ref struct2);
				graphics_0.ReleaseHdc(hdc);
			}
			Class96.CloseThemeData(intPtr);
			return;
		}
	}

	public static bool smethod_28()
	{
		return OSFeature.Feature.IsPresent(OSFeature.Themes);
	}

	public static bool smethod_29()
	{
		return GClass69.smethod_28() && Class96.IsThemeActive() && Class96.IsAppThemed() && GClass69.smethod_30().Major >= 6;
	}

	static Version smethod_30()
	{
		Struct5 @struct = default(Struct5);
		@struct.int_0 = Marshal.SizeOf(typeof(Struct5));
		if (Class96.DllGetVersion(ref @struct) == 0)
		{
			return new Version(@struct.int_1, @struct.int_2, @struct.int_3);
		}
		return new Version();
	}
}
