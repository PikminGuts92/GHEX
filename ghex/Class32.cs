using System;
using System.Runtime.InteropServices;

class Class32
{
	internal static void smethod_0(float[] float_1, int[] int_0, int int_1, int int_2, float[] float_2, int int_3, float float_3, float float_4)
	{
		float num = Class32.float_0 / (float)int_2;
		int i;
		for (i = 0; i < int_3; i++)
		{
			float_2[i] = Class119.smethod_0(float_2[i]);
		}
		int num2 = int_3 / 2 * 2;
		i = 0;
		while (i < int_1)
		{
			Class32.Struct0 @struct = default(Class32.Struct0);
			int num3 = int_0[i];
			float num4 = 0.707106769f;
			float num5 = 0.707106769f;
			float num6 = Class119.smethod_0(num * (float)num3);
			for (int j = 0; j < num2; j += 2)
			{
				num5 *= float_2[j] - num6;
				num4 *= float_2[j + 1] - num6;
			}
			if ((int_3 & 1) != 0)
			{
				num5 *= float_2[int_3 - 1] - num6;
				num5 *= num5;
				num4 *= num4 * (1f - num6 * num6);
			}
			else
			{
				num5 *= num5 * (1f + num6);
				num4 *= num4 * (1f - num6);
			}
			num5 = num4 + num5;
			@struct.float_0 = num5;
			int num7 = @struct.int_0;
			int num8 = int.MaxValue & num7;
			int num9 = 0;
			if (num8 < 2139095040 && num8 != 0)
			{
				if (num8 < 8388608)
				{
					num5 *= 33554432f;
					@struct.float_0 = num5;
					num7 = @struct.int_0;
					num8 = (int.MaxValue & num7);
					num9 = -25;
				}
				num9 += (int)(((uint)num8 >> 23) - 126u);
				num7 = (int)(((long)num7 & 2155872255L) | 1056964608L);
				@struct.int_0 = num7;
				num5 = @struct.float_0;
			}
			num5 = Class119.smethod_3(float_3 * Class119.smethod_1(num5) * Class119.smethod_2(num9 + int_3) - float_4);
			do
			{
				float_1[i] *= num5;
				i++;
				if (i >= int_1)
				{
					break;
				}
			}
			while (int_0[i] == num3);
		}
	}

	static float float_0 = 3.14159274f;

	[StructLayout(LayoutKind.Explicit, Size = 32)]
	struct Struct0
	{
		[FieldOffset(0)]
		public float float_0;

		[FieldOffset(0)]
		public int int_0;
	}
}
