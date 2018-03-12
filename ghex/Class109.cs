using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

class Class109
{
	public static string smethod_0(DateTime dateTime_0, long long_0, long long_1)
	{
		float num = (float)((DateTime.Now.Ticks - dateTime_0.Ticks) / 10000000L);
		string text = "";
		if (num > 0f)
		{
			float num2 = (float)long_0 / num;
			float float_ = (float)(long_1 - long_0) / num2;
			text = Class109.smethod_1(float_);
			if (text[0] == '0')
			{
				text = text.Substring(2);
			}
			if (!text.Equals(string.Empty))
			{
				text = " (~" + text + " left)";
			}
		}
		return text;
	}

	public static string smethod_1(float float_0)
	{
		int num = (int)(float_0 / 60f);
		int num2 = (int)(float_0 - (float)(num * 60));
		return ((num > 0) ? (num + "m") : "") + num2 + "s";
	}

	public static string smethod_2(float float_0)
	{
		int num = (int)(float_0 / 60f);
		int num2 = (int)(float_0 - (float)(num * 60));
		return string.Concat(new object[]
		{
			num,
			":",
			(num2 < 10) ? "0" : "",
			num2
		});
	}

	public static string smethod_3(long long_0)
	{
		string str = "";
		float num = (float)long_0;
		foreach (string text in Class109.string_0)
		{
			if (num < 1024f)
			{
				str = text;
				return num.ToString("#,###.##") + str;
			}
			num /= 1024f;
		}
        return num.ToString("#,###.##") + str;
    }

	public static Color smethod_4(int int_0, Color color_2, Color color_3)
	{
		return Color.FromArgb((int)color_2.R + (int)(color_3.R - color_2.R) * (255 - int_0) / 255, (int)color_2.G + (int)(color_3.G - color_2.G) * (255 - int_0) / 255, (int)color_2.B + (int)(color_3.B - color_2.B) * (255 - int_0) / 255);
	}

	public static string smethod_5(string string_2)
	{
		return string_2.Substring(0, string_2.LastIndexOf('\\'));
	}

	public static string smethod_6(TreeNode treeNode_0)
	{
		string text = "";
		while (treeNode_0.Parent != null)
		{
			text = treeNode_0.Text + "/" + text;
			treeNode_0 = treeNode_0.Parent;
		}
		if (text.EndsWith("/"))
		{
			text = text.Substring(0, text.Length - 1);
		}
		return text;
	}

	public static string smethod_7(GEnum53 genum53_0)
	{
		return Class109.string_1[(int)genum53_0];
	}

	public static int smethod_8(uint uint_0)
	{
		return (int)(uint_0 >> 24 | uint_0 << 24 | (uint_0 >> 8 & 65280u) | (uint_0 << 8 & 16711680u));
	}

	public static int smethod_9(ushort ushort_0)
	{
		return (ushort_0 >> 8 | (int)ushort_0 << 8) & 65535;
	}

	public static double smethod_10(double double_0, double double_1, double double_2)
	{
		return double_0 + (double_1 - double_0) * double_2;
	}

	public static float smethod_11(float float_0, float float_1, float float_2)
	{
		return float_0 + (float_1 - float_0) * float_2;
	}

	public static float smethod_12(int int_0)
	{
		return 6E+07f / (float)int_0;
	}

	public static int smethod_13(float float_0)
	{
		return (int)(6E+07f / float_0);
	}

	public static void smethod_14(Color color_2)
	{
		Class109.color_0 = new Color[5];
		Class109.color_0[0] = Color.Green;
		Class109.color_0[1] = Color.Red;
		Class109.color_0[2] = Color.FromArgb(250, 230, 0);
		Class109.color_0[3] = Color.Blue;
		Class109.color_0[4] = Color.Orange;
		Class109.color_1 = new Color[5];
		Class109.color_1[0] = Color.DarkGreen;
		Class109.color_1[1] = Color.FromArgb(212, 0, 0);
		Class109.color_1[2] = Color.FromArgb(255, 216, 0);
		Class109.color_1[3] = Color.FromArgb(0, 0, 212);
		Class109.color_1[4] = Color.DarkOrange;
		Class109.pen_2 = Pens.Black;
		Class109.pen_3 = new Pen(Color.FromArgb(128, Color.Black));
		Class109.brush_0 = new Brush[5];
		Class109.pen_1 = new Pen[5];
		Class109.brush_1 = new Brush[5];
		Class109.pen_0 = new Pen[5];
		for (int i = 0; i < 5; i++)
		{
			Class109.brush_0[i] = new SolidBrush(Class109.color_0[i]);
			Class109.pen_1[i] = new Pen(Class109.color_1[i]);
			Class109.brush_1[i] = new SolidBrush(Class109.smethod_4(96, Class109.color_0[i], color_2));
			Class109.pen_0[i] = new Pen(Class109.smethod_4(96, Class109.color_1[i], color_2));
		}
	}

	public static FontFamily[] smethod_15()
	{
		return Class109.privateFontCollection_0.Families;
	}

	public static void smethod_16()
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Class109.privateFontCollection_0 = new PrivateFontCollection();
		Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("gh.notation.ttf");
		byte[] array = new byte[manifestResourceStream.Length];
		manifestResourceStream.Read(array, 0, (int)manifestResourceStream.Length);
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(byte)) * array.Length);
		Marshal.Copy(array, 0, intPtr, array.Length);
		Class109.privateFontCollection_0.AddMemoryFont(intPtr, array.Length);
		Marshal.FreeHGlobal(intPtr);
	}

	public static Brush smethod_17(GEnum51 genum51_0)
	{
		return Class109.brush_0[(int)genum51_0];
	}

	public static Pen smethod_18(GEnum51 genum51_0)
	{
		return Class109.pen_1[(int)genum51_0];
	}

	public static RectangleF smethod_19(Graphics graphics_0, GEnum51 genum51_0, float float_0, float float_1, float float_2, Class109.Enum12 enum12_0)
	{
		bool flag = (enum12_0 & Class109.Enum12.flag_2) != (Class109.Enum12)0;
		bool flag2 = (enum12_0 & Class109.Enum12.flag_0) != (Class109.Enum12)0;
		bool flag3 = (enum12_0 & Class109.Enum12.flag_1) != (Class109.Enum12)0;
		bool flag4 = (enum12_0 & Class109.Enum12.flag_1) != (Class109.Enum12)0;
		bool flag5 = (enum12_0 & Class109.Enum12.flag_4) != (Class109.Enum12)0;
		Brush brush = flag ? Class109.brush_1[(int)genum51_0] : Class109.brush_0[(int)genum51_0];
		Pen pen = flag ? Class109.pen_0[(int)genum51_0] : Class109.pen_1[(int)genum51_0];
		RectangleF rectangleF;
		if (flag5)
		{
			graphics_0.DrawLine(Pens.Black, float_0, float_1 - 2f, float_0, float_1 + 2f);
			graphics_0.DrawLine(Pens.Black, float_0, float_1, float_0 + float_2 / 2f, float_1);
			rectangleF = new RectangleF(float_0, float_1 - 2f, float_2 / 2f, 5f);
		}
		else if (!flag2)
		{
			rectangleF = new RectangleF(float_0 - float_2 / 2f, float_1 - float_2 / 2f, float_2, float_2);
			graphics_0.FillEllipse(brush, rectangleF);
			if (!flag3)
			{
				graphics_0.DrawEllipse(flag ? Class109.pen_3 : Class109.pen_2, rectangleF);
			}
			else
			{
				graphics_0.DrawEllipse(pen, rectangleF);
			}
		}
		else
		{
			float num = float_2 + (flag4 ? 2.25f : 1.5f);
			rectangleF = new RectangleF(float_0 - num / 2f, float_1 - num / 2f, num, num);
			PointF[] array = new PointF[10];
			array[0].X = rectangleF.X + rectangleF.Width / 2f;
			array[0].Y = rectangleF.Y;
			array[1].X = rectangleF.X + 42f * rectangleF.Width / 64f;
			array[1].Y = rectangleF.Y + 19f * rectangleF.Height / 64f;
			array[2].X = rectangleF.X + rectangleF.Width;
			array[2].Y = rectangleF.Y + 22f * rectangleF.Height / 64f;
			array[3].X = rectangleF.X + 48f * rectangleF.Width / 64f;
			array[3].Y = rectangleF.Y + 38f * rectangleF.Height / 64f;
			array[4].X = rectangleF.X + 52f * rectangleF.Width / 64f;
			array[4].Y = rectangleF.Y + rectangleF.Height;
			array[5].X = rectangleF.X + rectangleF.Width / 2f;
			array[5].Y = rectangleF.Y + 52f * rectangleF.Height / 64f;
			array[6].X = rectangleF.X + 12f * rectangleF.Width / 64f;
			array[6].Y = rectangleF.Y + rectangleF.Height;
			array[7].X = rectangleF.X + rectangleF.Width / 4f;
			array[7].Y = rectangleF.Y + 38f * rectangleF.Height / 64f;
			array[8].X = rectangleF.X;
			array[8].Y = rectangleF.Y + 22f * rectangleF.Height / 64f;
			array[9].X = rectangleF.X + 22f * rectangleF.Width / 64f;
			array[9].Y = rectangleF.Y + 19f * rectangleF.Height / 64f;
			graphics_0.FillPolygon(brush, array);
			if (!flag3)
			{
				graphics_0.DrawPolygon(flag ? Class109.pen_3 : Class109.pen_2, array);
			}
			else
			{
				graphics_0.DrawPolygon(pen, array);
			}
		}
		return rectangleF;
	}

	public static void smethod_20(Graphics graphics_0, GEnum51 genum51_0, float float_0, float float_1, float float_2, float float_3, Class109.Enum12 enum12_0)
	{
		bool flag = (enum12_0 & Class109.Enum12.flag_2) != (Class109.Enum12)0;
		bool flag2 = (enum12_0 & Class109.Enum12.flag_4) != (Class109.Enum12)0;
		RectangleF rect = new RectangleF(float_0, float_1 - float_3 / 2f, float_2, float_3);
		if (!flag2)
		{
			graphics_0.FillRectangle(flag ? Class109.brush_1[(int)genum51_0] : Class109.brush_0[(int)genum51_0], rect);
			return;
		}
		graphics_0.DrawLine(Pens.Black, float_0, float_1, float_0 + float_2, float_1);
		graphics_0.DrawLine(Pens.Black, float_0 + float_2, float_1 - 2f, float_0 + float_2, float_1 + 2f);
	}

	static string[] string_0 = new string[]
	{
		"B",
		"KiB",
		"MiB",
		"GiB",
		"TiB"
	};

	static string[] string_1 = new string[]
	{
		"Easy",
		"Medium",
		"Hard",
		"Expert"
	};

	static Color[] color_0;

	static Color[] color_1;

	static Brush[] brush_0;

	static Brush[] brush_1;

	static Pen[] pen_0;

	static Pen[] pen_1;

	static Pen pen_2;

	static Pen pen_3;

	static PrivateFontCollection privateFontCollection_0;

	[Flags]
	public enum Enum12
	{
		flag_0 = 1,
		flag_1 = 2,
		flag_2 = 4,
		flag_3 = 8,
		flag_4 = 16
	}
}
