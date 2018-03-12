using System;

public class GClass80
{
	public static double smethod_0()
	{
		GClass80.uint_0 = (GClass80.uint_0 * 1103515245u + 12345u & 2147483647u);
		return GClass80.uint_0 * 4.6566128752457969E-10;
	}

	public static void smethod_1(float[] float_0, float[] float_1, ref int[] int_0, int int_1)
	{
		for (int i = 0; i < int_1; i++)
		{
			int num = (int)((double)float_1[i] + GClass80.random_0.NextDouble() - 0.5);
			if (num < -32768)
			{
				num = -32768;
			}
			else if (num > 32767)
			{
				num = 32767;
			}
			int num2 = (int)((double)float_0[i] + GClass80.random_0.NextDouble() - 0.5);
			if (num2 < -32768)
			{
				num2 = -32768;
			}
			else if (num2 > 32767)
			{
				num2 = 32767;
			}
			int_0[i] = (num << 16 | (int)((ushort)num2));
		}
	}

	public static void smethod_2(float[] float_0, float[] float_1, ref int[] int_0, int int_1)
	{
		for (int i = 0; i < int_1; i++)
		{
			int num = (int)float_1[i];
			if (num < -32768)
			{
				num = -32768;
			}
			else if (num > 32767)
			{
				num = 32767;
			}
			int num2 = (int)float_0[i];
			if (num2 < -32768)
			{
				num2 = -32768;
			}
			else if (num2 > 32767)
			{
				num2 = 32767;
			}
			int_0[i] = (num << 16 | (int)((ushort)num2));
		}
	}

	public static void smethod_3(ref byte[] byte_0, long long_0, ref float[] float_0, long long_1, ref long long_2, ref long long_3)
	{
		byte b = byte_0[(int)(checked((IntPtr)long_0))];
		byte b2 = b & 15;
		b = (byte)(b >> 4);
		for (int i = 0; i < 14; i++)
		{
			long num = (long)((ulong)byte_0[(int)(checked((IntPtr)(unchecked(long_0 + 2L + (long)i))))]);
			long num2 = (long)((short)(num << 8 & 61440L) >> (int)b2);
			num2 <<= 4;
			long num3 = (long)((short)(num << 12 & 61440L) >> (int)b2);
			num3 <<= 4;
			int num4 = (int)(-GClass80.double_1[(int)b] * 1024.0);
			int num5 = (int)(-GClass80.double_2[(int)b] * 1024.0);
			num3 -= (long)num4 * long_2 + (long)num5 * long_3 >> 10;
			long_3 = long_2;
			long_2 = num3;
			num2 -= (long)num4 * long_2 + (long)num5 * long_3 >> 10;
			long_3 = long_2;
			long_2 = num2;
			if (num3 < -524288L)
			{
				num3 = -524288L;
			}
			if (num3 > 524272L)
			{
				num3 = 524272L;
			}
			checked
			{
				float_0[(int)((IntPtr)(unchecked(long_1 + (long)(i * 2))))] = (float)(num3 >> 4);
				if (num2 < -524288L)
				{
					num2 = -524288L;
				}
				if (num2 > 524272L)
				{
					num2 = 524272L;
				}
				float_0[(int)((IntPtr)(unchecked(long_1 + (long)(i * 2) + 1L)))] = (float)(num2 >> 4);
			}
		}
	}

	public static void smethod_4(ref float[] float_0, long long_0, ref byte[] byte_0, long long_1, ref double double_5, ref double double_6, ref double double_7, ref double double_8)
	{
		GClass80.smethod_5(ref float_0, long_0, ref byte_0, long_1, ref double_5, ref double_6);
		GClass80.smethod_6(ref byte_0, long_1, ref float_0, long_0, ref double_7, ref double_8);
	}

	static void smethod_5(ref float[] float_0, long long_0, ref byte[] byte_0, long long_1, ref double double_5, ref double double_6)
	{
		double[] array = new double[140];
		double num = 10000000000.0;
		double[] array2 = new double[5];
		double[] array3 = array2;
		double num2 = 0.0;
		double num3 = 0.0;
		byte b = 0;
		for (int i = 0; i < 5; i++)
		{
			num2 = double_5;
			num3 = double_6;
			for (int j = 0; j < 28; j++)
			{
				double num4 = (double)float_0[(int)(checked((IntPtr)(unchecked(long_0 + (long)j))))];
				if (num4 < -30720.0)
				{
					num4 = -30720.0;
				}
				else if (num4 > 30719.0)
				{
					num4 = 30719.0;
				}
				double num5 = num4 + num2 * GClass80.double_3[i] + num3 * GClass80.double_4[i];
				array[j + i * 28] = num5;
				if (Math.Abs(num5) > array3[i])
				{
					array3[i] = Math.Abs(num5);
				}
				num3 = num2;
				num2 = num4;
			}
			if (array3[i] < num)
			{
				num = array3[i];
				b = (byte)i;
			}
			if (num <= 7.0)
			{
				b = 0;
				IL_113:
				double_5 = num2;
				double_6 = num3;
				for (int k = 0; k < 28; k++)
				{
					float_0[(int)(checked((IntPtr)(unchecked(long_0 + (long)k))))] = (float)array[k + (int)(b * 28)];
				}
				int num6 = (int)num;
				int num7 = 16384;
				byte b2 = 0;
				while (b2 < 12 && (num7 & num6 + (num7 >> 3)) == 0)
				{
					b2 += 1;
					num7 >>= 1;
				}
				byte_0[(int)(checked((IntPtr)long_1))] = (byte)((int)b << 4 | (int)b2);
				return;
			}
		}
		goto IL_113;
	}

	static void smethod_6(ref byte[] byte_0, long long_0, ref float[] float_0, long long_1, ref double double_5, ref double double_6)
	{
		short[] array = new short[28];
		double num = double_5;
		double num2 = double_6;
		int num3;
		int num4;
		double num5;
		checked
		{
			num3 = byte_0[(int)((IntPtr)long_0)] >> 4;
			num4 = (int)(byte_0[(int)((IntPtr)long_0)] & 15);
			num5 = (double)(1 << num4);
		}
		for (int i = 0; i < 28; i++)
		{
			double num6 = (double)float_0[(int)(checked((IntPtr)(unchecked(long_1 + (long)i))))] + num * GClass80.double_3[num3] + num2 * GClass80.double_4[num3];
			double num7 = num6 * num5;
			int num8 = (int)((long)((int)num7 + 2048) & 4294963200L);
			if (num8 < -32768)
			{
				num8 = -32768;
			}
			else if (num8 > 32767)
			{
				num8 = 32767;
			}
			array[i] = (short)num8;
			num8 >>= num4;
			num2 = num;
			num = (double)num8 - num6;
		}
		for (int j = 0; j < 14; j++)
		{
			byte_0[(int)(checked((IntPtr)(unchecked(long_0 + 2L + (long)j))))] = (byte)((array[j * 2 + 1] >> 8 & 240) | (array[j * 2] >> 12 & 15));
		}
		double_5 = num;
		double_6 = num2;
	}

	internal static double double_0 = 6755399441055744.0;

	internal static uint uint_0 = 381296920u;

	internal static Random random_0 = new Random();

	static double[] double_1 = new double[]
	{
		0.0,
		0.9375,
		1.796875,
		1.53125,
		1.90625
	};

	static double[] double_2 = new double[]
	{
		0.0,
		0.0,
		-0.8125,
		-0.859375,
		-0.9375
	};

	static double[] double_3 = new double[]
	{
		0.0,
		-0.9375,
		-1.796875,
		-1.53125,
		-1.90625
	};

	static double[] double_4 = new double[]
	{
		0.0,
		0.0,
		0.8125,
		0.859375,
		0.9375
	};
}
