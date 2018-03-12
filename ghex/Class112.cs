using System;
using System.Runtime.CompilerServices;

class Class112
{
	internal int method_0(int int_4, GClass37 gclass37_0)
	{
		gclass37_0.method_6(this.int_2[int_4], this.class90_0.int_2[int_4]);
		return this.class90_0.int_2[int_4];
	}

	internal int method_1(float[] float_1)
	{
		int num = this.method_10(float_1, 1);
		for (int i = 0; i < this.int_0; i++)
		{
			float_1[i] = this.float_0[num * this.int_0 + i];
		}
		return num;
	}

	internal int method_2(int int_4, float[] float_1, GClass37 gclass37_0)
	{
		for (int i = 0; i < this.int_0; i++)
		{
			float_1[i] = this.float_0[int_4 * this.int_0 + i];
		}
		return this.method_0(int_4, gclass37_0);
	}

	internal int method_3(float[] float_1, GClass37 gclass37_0, int int_4, int int_5)
	{
		int int_6 = this.method_11(float_1, int_4, int_5);
		return this.method_0(int_6, gclass37_0);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal int method_4(float[] float_1, int int_4, GClass37 gclass37_0, int int_5)
	{
		int num = int_5 / this.int_0;
		if (this.int_3.Length < num)
		{
			this.int_3 = new int[num];
		}
		int i;
		for (i = 0; i < num; i++)
		{
			int num2 = this.method_8(gclass37_0);
			if (num2 == -1)
			{
				return -1;
			}
			this.int_3[i] = num2 * this.int_0;
		}
		i = 0;
		int num3 = 0;
		while (i < this.int_0)
		{
			for (int j = 0; j < num; j++)
			{
				float_1[int_4 + num3 + j] += this.float_0[this.int_3[j] + i];
			}
			i++;
			num3 += num;
		}
		return 0;
	}

	internal int method_5(float[] float_1, int int_4, GClass37 gclass37_0, int int_5)
	{
		if (this.int_0 > 8)
		{
			int i = 0;
			while (i < int_5)
			{
				int num = this.method_8(gclass37_0);
				if (num == -1)
				{
					return -1;
				}
				int num2 = num * this.int_0;
				int j = 0;
				while (j < this.int_0)
				{
					float_1[int_4 + i++] += this.float_0[num2 + j++];
				}
			}
		}
		else
		{
			int i = 0;
			while (i < int_5)
			{
				int num = this.method_8(gclass37_0);
				if (num == -1)
				{
					return -1;
				}
				int num2 = num * this.int_0;
				int j = 0;
				for (int k = 0; k < this.int_0; k++)
				{
					float_1[int_4 + i++] += this.float_0[num2 + j++];
				}
			}
		}
		return 0;
	}

	internal int method_6(float[] float_1, int int_4, GClass37 gclass37_0, int int_5)
	{
		int i = 0;
		while (i < int_5)
		{
			int num = this.method_8(gclass37_0);
			if (num == -1)
			{
				return -1;
			}
			int num2 = num * this.int_0;
			int j = 0;
			while (j < this.int_0)
			{
				float_1[int_4 + i++] = this.float_0[num2 + j++];
			}
		}
		return 0;
	}

	internal int method_7(float[][] float_1, int int_4, int int_5, GClass37 gclass37_0, int int_6)
	{
		int num = 0;
		int i = int_4 / int_5;
		while (i < (int_4 + int_6) / int_5)
		{
			int num2 = this.method_8(gclass37_0);
			if (num2 == -1)
			{
				return -1;
			}
			int num3 = num2 * this.int_0;
			for (int j = 0; j < this.int_0; j++)
			{
				float_1[num][i] += this.float_0[num3 + j];
				num++;
				if (num == int_5)
				{
					num = 0;
					i++;
				}
			}
		}
		return 0;
	}

	internal int method_8(GClass37 gclass37_0)
	{
		int num = 0;
		Class113 @class = this.class113_0;
		int num2 = gclass37_0.method_7(@class.int_2);
		if (num2 >= 0)
		{
			num = @class.int_0[num2];
			gclass37_0.method_9(@class.int_1[num2]);
			if (num <= 0)
			{
				return -num;
			}
		}
		do
		{
			switch (gclass37_0.method_13())
			{
			default:
				return -1;
			case 0:
				num = @class.int_3[num];
				break;
			case 1:
				num = @class.int_4[num];
				break;
			}
		}
		while (num > 0);
		return -num;
	}

	internal int method_9(float[] float_1, int int_4, GClass37 gclass37_0, int int_5, int int_6)
	{
		int num = this.method_8(gclass37_0);
		if (num == -1)
		{
			return -1;
		}
		switch (int_6)
		{
		case -1:
		{
			int i = 0;
			int num2 = 0;
			while (i < this.int_0)
			{
				float_1[int_4 + num2] = this.float_0[num * this.int_0 + i];
				i++;
				num2 += int_5;
			}
			break;
		}
		case 0:
		{
			int j = 0;
			int num3 = 0;
			while (j < this.int_0)
			{
				float_1[int_4 + num3] += this.float_0[num * this.int_0 + j];
				j++;
				num3 += int_5;
			}
			break;
		}
		case 1:
		{
			int k = 0;
			int num4 = 0;
			while (k < this.int_0)
			{
				float_1[int_4 + num4] *= this.float_0[num * this.int_0 + k];
				k++;
				num4 += int_5;
			}
			break;
		}
		}
		return num;
	}

	internal int method_10(float[] float_1, int int_4)
	{
		Class107 class107_ = this.class90_0.class107_0;
		Class18 class18_ = this.class90_0.class18_0;
		int num = 0;
		if (class18_ != null)
		{
			int num2 = 0;
			int i = 0;
			int num3 = int_4 * (this.int_0 - 1);
			while (i < this.int_0)
			{
				int num4 = 0;
				while (num4 < class18_.int_2 - 1 && float_1[num3] >= class18_.float_0[num4])
				{
					num4++;
				}
				num2 = num2 * class18_.int_1 + class18_.int_0[num4];
				i++;
				num3 -= int_4;
			}
			if (this.class90_0.int_2[num2] > 0)
			{
				return num2;
			}
		}
		if (class107_ != null)
		{
			do
			{
				double num5 = 0.0;
				int num6 = class107_.int_2[num];
				int num7 = class107_.int_3[num];
				int j = 0;
				int num8 = 0;
				while (j < this.int_0)
				{
					num5 += (double)(this.float_0[num6 + j] - this.float_0[num7 + j]) * ((double)float_1[num8] - (double)(this.float_0[num6 + j] + this.float_0[num7 + j]) * 0.5);
					j++;
					num8 += int_4;
				}
				if (num5 > 0.0)
				{
					num = -class107_.int_0[num];
				}
				else
				{
					num = -class107_.int_1[num];
				}
			}
			while (num > 0);
			return -num;
		}
		int num9 = -1;
		float num10 = 0f;
		int num11 = 0;
		for (int k = 0; k < this.int_1; k++)
		{
			if (this.class90_0.int_2[k] > 0)
			{
				float num12 = Class112.smethod_0(this.int_0, this.float_0, num11, float_1, int_4);
				if (num9 == -1 || num12 < num10)
				{
					num10 = num12;
					num9 = k;
				}
			}
			num11 += this.int_0;
		}
		return num9;
	}

	internal int method_11(float[] float_1, int int_4, int int_5)
	{
		int num = this.method_10(float_1, int_4);
		switch (int_5)
		{
		case 0:
		{
			int i = 0;
			int num2 = 0;
			while (i < this.int_0)
			{
				float_1[num2] -= this.float_0[num * this.int_0 + i];
				i++;
				num2 += int_4;
			}
			break;
		}
		case 1:
		{
			int j = 0;
			int num3 = 0;
			while (j < this.int_0)
			{
				float num4 = this.float_0[num * this.int_0 + j];
				if (num4 == 0f)
				{
					float_1[num3] = 0f;
				}
				else
				{
					float_1[num3] /= num4;
				}
				j++;
				num3 += int_4;
			}
			break;
		}
		}
		return num;
	}

	internal void method_12()
	{
	}

	internal static float smethod_0(int int_4, float[] float_1, int int_5, float[] float_2, int int_6)
	{
		float num = 0f;
		for (int i = 0; i < int_4; i++)
		{
			float num2 = float_1[int_5 + i] - float_2[i * int_6];
			num += num2 * num2;
		}
		return num;
	}

	internal int method_13(Class90 class90_1)
	{
		this.class90_0 = class90_1;
		this.int_1 = class90_1.int_1;
		this.int_0 = class90_1.int_0;
		this.float_0 = class90_1.method_4();
		this.class113_0 = this.method_14();
		if (this.class113_0 == null)
		{
			this.method_12();
			return -1;
		}
		return 0;
	}

	internal static int[] smethod_1(int[] int_4, int int_5)
	{
		int[] array = new int[33];
		int[] array2 = new int[int_5];
		for (int i = 0; i < int_5; i++)
		{
			int num = int_4[i];
			if (num > 0)
			{
				int num2 = array[num];
				if (num >= 32 || (uint)num2 >> num == 0u)
				{
					array2[i] = num2;
					for (int j = num; j > 0; j--)
					{
						if ((array[j] & 1) != 0)
						{
							if (j == 1)
							{
								array[1]++;
							}
							else
							{
								array[j] = array[j - 1] << 1;
							}

							int num3 = num + 1;
							while (num3 < 33 && (ulong)((uint)array[num3] >> 1) == (ulong)((long)num2))
							{
								num2 = array[num3];
								array[num3] = array[num3 - 1] << 1;
								num3++;
							}
							goto IL_C3;
						}
						array[j]++;
					}

                    int num3_0 = num + 1;
                    while (num3_0 < 33 && (ulong)((uint)array[num3_0] >> 1) == (ulong)((long)num2))
                    {
                        num2 = array[num3_0];
                        array[num3_0] = array[num3_0 - 1] << 1;
                        num3_0++;
                    }
                    goto IL_C3;
                }
				return null;
			}
			IL_C3:;
		}
		for (int k = 0; k < int_5; k++)
		{
			int num4 = 0;
			for (int l = 0; l < int_4[k]; l++)
			{
				num4 <<= 1;
				num4 |= (int)((uint)array2[k] >> l & 1u);
			}
			array2[k] = num4;
		}
		return array2;
	}

	internal Class113 method_14()
	{
		int num = 0;
		Class113 @class = new Class113();
		int[] array = @class.int_3 = new int[this.int_1 * 2];
		int[] array2 = @class.int_4 = new int[this.int_1 * 2];
		int[] array3 = Class112.smethod_1(this.class90_0.int_2, this.class90_0.int_1);
		if (array3 == null)
		{
			return null;
		}
		@class.int_5 = this.int_1 * 2;
		for (int i = 0; i < this.int_1; i++)
		{
			if (this.class90_0.int_2[i] > 0)
			{
				int num2 = 0;
				int j;
				for (j = 0; j < this.class90_0.int_2[i] - 1; j++)
				{
					if (((uint)array3[i] >> j & 1u) == 0u)
					{
						if (array[num2] == 0)
						{
							num = (array[num2] = num + 1);
						}
						num2 = array[num2];
					}
					else
					{
						if (array2[num2] == 0)
						{
							num = (array2[num2] = num + 1);
						}
						num2 = array2[num2];
					}
				}
				if (((uint)array3[i] >> j & 1u) == 0u)
				{
					array[num2] = -i;
				}
				else
				{
					array2[num2] = -i;
				}
			}
		}
		@class.int_2 = Class112.smethod_2(this.int_1) - 4;
		if (@class.int_2 < 5)
		{
			@class.int_2 = 5;
		}
		int num3 = 1 << @class.int_2;
		@class.int_0 = new int[num3];
		@class.int_1 = new int[num3];
		for (int k = 0; k < num3; k++)
		{
			int num4 = 0;
			int num5 = 0;
			while (num5 < @class.int_2 && (num4 > 0 || num5 == 0))
			{
				if ((k & 1 << num5) != 0)
				{
					num4 = array2[num4];
				}
				else
				{
					num4 = array[num4];
				}
				num5++;
			}
			@class.int_0[k] = num4;
			@class.int_1[k] = num5;
		}
		return @class;
	}

	internal static int smethod_2(int int_4)
	{
		int num = 0;
		while (int_4 != 0)
		{
			num++;
			int_4 = (int)((uint)int_4 >> 1);
		}
		return num;
	}

	internal int int_0;

	internal int int_1;

	internal Class90 class90_0 = new Class90();

	internal float[] float_0;

	internal int[] int_2;

	internal Class113 class113_0;

	internal int[] int_3 = new int[15];
}
