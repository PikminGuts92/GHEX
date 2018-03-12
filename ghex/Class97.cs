using System;

class Class97
{
	internal void method_0(float[] float_6)
	{
		if (this.int_0 == 1)
		{
			return;
		}
		Class97.smethod_10(this.int_0, float_6, this.float_0, this.float_0, this.int_0, this.int_1);
	}

	internal void method_1(int int_3)
	{
		this.int_0 = int_3;
		this.float_0 = new float[3 * int_3];
		this.int_1 = new int[32];
		Class97.smethod_1(int_3, this.float_0, this.int_1);
	}

	internal void method_2()
	{
		if (this.float_0 != null)
		{
			this.float_0 = null;
		}
		if (this.int_1 != null)
		{
			this.int_1 = null;
		}
	}

	static void smethod_0(int int_3, float[] float_6, int int_4, int[] int_5)
	{
		int num = 0;
		int i = -1;
		int num2 = int_3;
		int num3 = 0;
		for (;;)
		{
			i++;
			if (i < 4)
			{
				num = Class97.int_2[i];
			}
			else
			{
				num += 2;
			}
			for (;;)
			{
				int num4 = num2 / num;
				if (num2 - num * num4 != 0)
				{
					break;
				}
				num3++;
				int_5[num3 + 1] = num;
				num2 = num4;
				if (num == 2 && num3 != 1)
				{
					for (int j = 1; j < num3; j++)
					{
						int num5 = num3 - j + 1;
						int_5[num5 + 1] = int_5[num5];
					}
					int_5[2] = 2;
				}
				if (num2 == 1)
				{
					goto Block_4;
				}
			}
		}
		Block_4:
		int_5[0] = int_3;
		int_5[1] = num3;
		float num6 = Class97.float_1 / (float)int_3;
		int num7 = 0;
		int num8 = num3 - 1;
		int num9 = 1;
		if (num8 == 0)
		{
			return;
		}
		for (int k = 0; k < num8; k++)
		{
			int num10 = int_5[k + 2];
			int num11 = 0;
			int num12 = num9 * num10;
			int num13 = int_3 / num12;
			int num14 = num10 - 1;
			for (i = 0; i < num14; i++)
			{
				num11 += num9;
				int j = num7;
				float num15 = (float)num11 * num6;
				float num16 = 0f;
				for (int l = 2; l < num13; l += 2)
				{
					num16 += 1f;
					float num17 = num16 * num15;
					float_6[int_4 + j++] = (float)Math.Cos((double)num17);
					float_6[int_4 + j++] = (float)Math.Sin((double)num17);
				}
				num7 += num13;
			}
			num9 = num12;
		}
	}

	static void smethod_1(int int_3, float[] float_6, int[] int_4)
	{
		if (int_3 == 1)
		{
			return;
		}
		Class97.smethod_0(int_3, float_6, int_3, int_4);
	}

	static void smethod_2(int int_3, int int_4, float[] float_6, float[] float_7, float[] float_8, int int_5)
	{
		int num = 0;
		int num3;
		int num2 = num3 = int_4 * int_3;
		int num4 = int_3 << 1;
		for (int i = 0; i < int_4; i++)
		{
			float_7[num << 1] = float_6[num] + float_6[num2];
			float_7[(num << 1) + num4 - 1] = float_6[num] - float_6[num2];
			num += int_3;
			num2 += int_3;
		}
		if (int_3 < 2)
		{
			return;
		}
		if (int_3 != 2)
		{
			num = 0;
			num2 = num3;
			for (int i = 0; i < int_4; i++)
			{
				num4 = num2;
				int num5 = (num << 1) + (int_3 << 1);
				int num6 = num;
				int num7 = num + num;
				for (int j = 2; j < int_3; j += 2)
				{
					num4 += 2;
					num5 -= 2;
					num6 += 2;
					num7 += 2;
					float num8 = float_8[int_5 + j - 2] * float_6[num4 - 1] + float_8[int_5 + j - 1] * float_6[num4];
					float num9 = float_8[int_5 + j - 2] * float_6[num4] - float_8[int_5 + j - 1] * float_6[num4 - 1];
					float_7[num7] = float_6[num6] + num9;
					float_7[num5] = num9 - float_6[num6];
					float_7[num7 - 1] = float_6[num6 - 1] + num8;
					float_7[num5 - 1] = float_6[num6 - 1] - num8;
				}
				num += int_3;
				num2 += int_3;
			}
			if (int_3 % 2 == 1)
			{
				return;
			}
		}
		num = int_3;
		num2 = (num4 = int_3 - 1) + num3;
		for (int i = 0; i < int_4; i++)
		{
			float_7[num] = -float_6[num2];
			float_7[num - 1] = float_6[num4];
			num += int_3 << 1;
			num2 += int_3;
			num4 += int_3;
		}
	}

	static void smethod_3(int int_3, int int_4, float[] float_6, float[] float_7, float[] float_8, int int_5, float[] float_9, int int_6, float[] float_10, int int_7)
	{
		int num = int_4 * int_3;
		int num2 = num;
		int num3 = num2 << 1;
		int num4 = num2 + (num2 << 1);
		int num5 = 0;
		int num8;
		for (int i = 0; i < int_4; i++)
		{
			float num6 = float_6[num2] + float_6[num4];
			float num7 = float_6[num5] + float_6[num3];
			float_7[num8 = num5 << 2] = num6 + num7;
			float_7[(int_3 << 2) + num8 - 1] = num7 - num6;
			float_7[(num8 += int_3 << 1) - 1] = float_6[num5] - float_6[num3];
			float_7[num8] = float_6[num4] - float_6[num2];
			num2 += int_3;
			num4 += int_3;
			num5 += int_3;
			num3 += int_3;
		}
		if (int_3 < 2)
		{
			return;
		}
		int num9;
		if (int_3 != 2)
		{
			num2 = 0;
			for (int i = 0; i < int_4; i++)
			{
				num4 = num2;
				num3 = num2 << 2;
				num8 = (num9 = int_3 << 1) + num3;
				for (int j = 2; j < int_3; j += 2)
				{
					num4 = (num5 = num4 + 2);
					num3 += 2;
					num8 -= 2;
					num5 += num;
					float num10 = float_8[int_5 + j - 2] * float_6[num5 - 1] + float_8[int_5 + j - 1] * float_6[num5];
					float num11 = float_8[int_5 + j - 2] * float_6[num5] - float_8[int_5 + j - 1] * float_6[num5 - 1];
					num5 += num;
					float num12 = float_9[int_6 + j - 2] * float_6[num5 - 1] + float_9[int_6 + j - 1] * float_6[num5];
					float num13 = float_9[int_6 + j - 2] * float_6[num5] - float_9[int_6 + j - 1] * float_6[num5 - 1];
					num5 += num;
					float num14 = float_10[int_7 + j - 2] * float_6[num5 - 1] + float_10[int_7 + j - 1] * float_6[num5];
					float num15 = float_10[int_7 + j - 2] * float_6[num5] - float_10[int_7 + j - 1] * float_6[num5 - 1];
					float num6 = num10 + num14;
					float num16 = num14 - num10;
					float num17 = num11 + num15;
					float num18 = num11 - num15;
					float num19 = float_6[num4] + num13;
					float num20 = float_6[num4] - num13;
					float num7 = float_6[num4 - 1] + num12;
					float num21 = float_6[num4 - 1] - num12;
					float_7[num3 - 1] = num6 + num7;
					float_7[num3] = num17 + num19;
					float_7[num8 - 1] = num21 - num18;
					float_7[num8] = num16 - num20;
					float_7[num3 + num9 - 1] = num18 + num21;
					float_7[num3 + num9] = num16 + num20;
					float_7[num8 + num9 - 1] = num7 - num6;
					float_7[num8 + num9] = num17 - num19;
				}
				num2 += int_3;
			}
			if ((int_3 & 1) != 0)
			{
				return;
			}
		}
		num4 = (num2 = num + int_3 - 1) + (num << 1);
		num5 = int_3 << 2;
		num3 = int_3;
		num8 = int_3 << 1;
		num9 = int_3;
		for (int i = 0; i < int_4; i++)
		{
			float num17 = -Class97.float_2 * (float_6[num2] + float_6[num4]);
			float num6 = Class97.float_2 * (float_6[num2] - float_6[num4]);
			float_7[num3 - 1] = num6 + float_6[num9 - 1];
			float_7[num3 + num8 - 1] = float_6[num9 - 1] - num6;
			float_7[num3] = num17 - float_6[num2 + num];
			float_7[num3 + num8] = num17 + float_6[num2 + num];
			num2 += int_3;
			num4 += int_3;
			num3 += num5;
			num9 += int_3;
		}
	}

	static void smethod_4(int int_3, int int_4, int int_5, int int_6, float[] float_6, float[] float_7, float[] float_8, float[] float_9, float[] float_10, float[] float_11, int int_7)
	{
		float num = Class97.float_1 / (float)int_4;
		float num2 = (float)Math.Cos((double)num);
		float num3 = (float)Math.Sin((double)num);
		int num4 = int_4 + 1 >> 1;
		int num5 = int_3 - 1 >> 1;
		int num6 = int_5 * int_3;
		int num7 = int_4 * int_3;
		int num8;
		int num9;
		int num12;
		int num13;
		int num14;
		if (int_3 != 1)
		{
			for (int i = 0; i < int_6; i++)
			{
				float_10[i] = float_8[i];
			}
			num8 = 0;
			for (int j = 1; j < int_4; j++)
			{
				num8 += num6;
				num9 = num8;
				for (int k = 0; k < int_5; k++)
				{
					float_9[num9] = float_7[num9];
					num9 += int_3;
				}
			}
			int num10 = -int_3;
			num8 = 0;
			if (num5 > int_5)
			{
				for (int j = 1; j < int_4; j++)
				{
					num8 += num6;
					num10 += int_3;
					num9 = -int_3 + num8;
					for (int k = 0; k < int_5; k++)
					{
						int num11 = num10 - 1;
						num9 += int_3;
						num12 = num9;
						for (int l = 2; l < int_3; l += 2)
						{
							num11 += 2;
							num12 += 2;
							float_9[num12 - 1] = float_11[int_7 + num11 - 1] * float_7[num12 - 1] + float_11[int_7 + num11] * float_7[num12];
							float_9[num12] = float_11[int_7 + num11 - 1] * float_7[num12] - float_11[int_7 + num11] * float_7[num12 - 1];
						}
					}
				}
			}
			else
			{
				for (int j = 1; j < int_4; j++)
				{
					num10 += int_3;
					int num11 = num10 - 1;
					num8 += num6;
					num9 = num8;
					for (int l = 2; l < int_3; l += 2)
					{
						num11 += 2;
						num9 += 2;
						num12 = num9;
						for (int k = 0; k < int_5; k++)
						{
							float_9[num12 - 1] = float_11[int_7 + num11 - 1] * float_7[num12 - 1] + float_11[int_7 + num11] * float_7[num12];
							float_9[num12] = float_11[int_7 + num11 - 1] * float_7[num12] - float_11[int_7 + num11] * float_7[num12 - 1];
							num12 += int_3;
						}
					}
				}
			}
			num8 = 0;
			num9 = int_4 * num6;
			if (num5 < int_5)
			{
				for (int j = 1; j < num4; j++)
				{
					num8 += num6;
					num9 -= num6;
					num12 = num8;
					num13 = num9;
					for (int l = 2; l < int_3; l += 2)
					{
						num12 += 2;
						num13 += 2;
						num14 = num12 - int_3;
						int num15 = num13 - int_3;
						for (int k = 0; k < int_5; k++)
						{
							num14 += int_3;
							num15 += int_3;
							float_7[num14 - 1] = float_9[num14 - 1] + float_9[num15 - 1];
							float_7[num15 - 1] = float_9[num14] - float_9[num15];
							float_7[num14] = float_9[num14] + float_9[num15];
							float_7[num15] = float_9[num15 - 1] - float_9[num14 - 1];
						}
					}
				}
			}
			else
			{
				for (int j = 1; j < num4; j++)
				{
					num8 += num6;
					num9 -= num6;
					num12 = num8;
					num13 = num9;
					for (int k = 0; k < int_5; k++)
					{
						num14 = num12;
						int num15 = num13;
						for (int l = 2; l < int_3; l += 2)
						{
							num14 += 2;
							num15 += 2;
							float_7[num14 - 1] = float_9[num14 - 1] + float_9[num15 - 1];
							float_7[num15 - 1] = float_9[num14] - float_9[num15];
							float_7[num14] = float_9[num14] + float_9[num15];
							float_7[num15] = float_9[num15 - 1] - float_9[num14 - 1];
						}
						num12 += int_3;
						num13 += int_3;
					}
				}
			}
		}
		for (int i = 0; i < int_6; i++)
		{
			float_8[i] = float_10[i];
		}
		num8 = 0;
		num9 = int_4 * int_6;
		for (int j = 1; j < num4; j++)
		{
			num8 += num6;
			num9 -= num6;
			num12 = num8 - int_3;
			num13 = num9 - int_3;
			for (int k = 0; k < int_5; k++)
			{
				num12 += int_3;
				num13 += int_3;
				float_7[num12] = float_9[num12] + float_9[num13];
				float_7[num13] = float_9[num13] - float_9[num12];
			}
		}
		float num16 = 1f;
		float num17 = 0f;
		num8 = 0;
		num9 = int_4 * int_6;
		num12 = (int_4 - 1) * int_6;
		for (int m = 1; m < num4; m++)
		{
			num8 += int_6;
			num9 -= int_6;
			float num18 = num2 * num16 - num3 * num17;
			num17 = num2 * num17 + num3 * num16;
			num16 = num18;
			num13 = num8;
			num14 = num9;
			int num15 = num12;
			int num19 = int_6;
			for (int i = 0; i < int_6; i++)
			{
				float_10[num13++] = float_8[i] + num16 * float_8[num19++];
				float_10[num14++] = num17 * float_8[num15++];
			}
			float num20 = num16;
			float num21 = num17;
			float num22 = num16;
			float num23 = num17;
			num13 = int_6;
			num14 = (int_4 - 1) * int_6;
			for (int j = 2; j < num4; j++)
			{
				num13 += int_6;
				num14 -= int_6;
				float num24 = num20 * num22 - num21 * num23;
				num23 = num20 * num23 + num21 * num22;
				num22 = num24;
				num15 = num8;
				num19 = num9;
				int num25 = num13;
				int num26 = num14;
				for (int i = 0; i < int_6; i++)
				{
					float_10[num15] += num22 * float_8[num25++];
					num15++;
					float_10[num19] += num23 * float_8[num26++];
					num19++;
				}
			}
		}
		num8 = 0;
		for (int j = 1; j < num4; j++)
		{
			num8 += int_6;
			num9 = num8;
			for (int i = 0; i < int_6; i++)
			{
				float_10[i] += float_8[num9++];
			}
		}
		if (int_3 >= int_5)
		{
			num8 = 0;
			num9 = 0;
			for (int k = 0; k < int_5; k++)
			{
				num12 = num8;
				num13 = num9;
				for (int l = 0; l < int_3; l++)
				{
					float_6[num13++] = float_9[num12++];
				}
				num8 += int_3;
				num9 += num7;
			}
		}
		else
		{
			for (int l = 0; l < int_3; l++)
			{
				num8 = l;
				num9 = l;
				for (int k = 0; k < int_5; k++)
				{
					float_6[num9] = float_9[num8];
					num8 += int_3;
					num9 += num7;
				}
			}
		}
		num8 = 0;
		num9 = int_3 << 1;
		num12 = 0;
		num13 = int_4 * num6;
		for (int j = 1; j < num4; j++)
		{
			num8 += num9;
			num12 += num6;
			num13 -= num6;
			num14 = num8;
			int num15 = num12;
			int num19 = num13;
			for (int k = 0; k < int_5; k++)
			{
				float_6[num14 - 1] = float_9[num15];
				float_6[num14] = float_9[num19];
				num14 += num7;
				num15 += int_3;
				num19 += int_3;
			}
		}
		if (int_3 == 1)
		{
			return;
		}
		if (num5 >= int_5)
		{
			num8 = -int_3;
			num12 = 0;
			num13 = 0;
			num14 = int_4 * num6;
			for (int j = 1; j < num4; j++)
			{
				num8 += num9;
				num12 += num9;
				num13 += num6;
				num14 -= num6;
				int num15 = num8;
				int num19 = num12;
				int num25 = num13;
				int num26 = num14;
				for (int k = 0; k < int_5; k++)
				{
					for (int l = 2; l < int_3; l += 2)
					{
						int num27 = int_3 - l;
						float_6[l + num19 - 1] = float_9[l + num25 - 1] + float_9[l + num26 - 1];
						float_6[num27 + num15 - 1] = float_9[l + num25 - 1] - float_9[l + num26 - 1];
						float_6[l + num19] = float_9[l + num25] + float_9[l + num26];
						float_6[num27 + num15] = float_9[l + num26] - float_9[l + num25];
					}
					num15 += num7;
					num19 += num7;
					num25 += int_3;
					num26 += int_3;
				}
			}
			return;
		}
		num8 = -int_3;
		num12 = 0;
		num13 = 0;
		num14 = int_4 * num6;
		for (int j = 1; j < num4; j++)
		{
			num8 += num9;
			num12 += num9;
			num13 += num6;
			num14 -= num6;
			for (int l = 2; l < int_3; l += 2)
			{
				int num15 = int_3 + num8 - l;
				int num19 = l + num12;
				int num25 = l + num13;
				int num26 = l + num14;
				for (int k = 0; k < int_5; k++)
				{
					float_6[num19 - 1] = float_9[num25 - 1] + float_9[num26 - 1];
					float_6[num15 - 1] = float_9[num25 - 1] - float_9[num26 - 1];
					float_6[num19] = float_9[num25] + float_9[num26];
					float_6[num15] = float_9[num26] - float_9[num25];
					num15 += num7;
					num19 += num7;
					num25 += int_3;
					num26 += int_3;
				}
			}
		}
	}

	static void smethod_5(int int_3, float[] float_6, float[] float_7, float[] float_8, int[] int_4)
	{
		int num = int_4[1];
		int num2 = 1;
		int num3 = int_3;
		int num4 = int_3;
		for (int i = 0; i < num; i++)
		{
			int num5 = num - i;
			int num6 = int_4[num5 + 1];
			int num7 = num3 / num6;
			int num8 = int_3 / num3;
			int int_5 = num8 * num7;
			num4 -= (num6 - 1) * num8;
			num2 = 1 - num2;
			if (num6 == 4)
			{
				int num9 = num4 + num8;
				int num10 = num9 + num8;
				if (num2 != 0)
				{
					Class97.smethod_3(num8, num7, float_7, float_6, float_8, num4 - 1, float_8, num9 - 1, float_8, num10 - 1);
				}
				else
				{
					Class97.smethod_3(num8, num7, float_6, float_7, float_8, num4 - 1, float_8, num9 - 1, float_8, num10 - 1);
				}
			}
			else if (num6 == 2)
			{
				if (num2 == 0)
				{
					Class97.smethod_2(num8, num7, float_6, float_7, float_8, num4 - 1);
				}
				else
				{
					Class97.smethod_2(num8, num7, float_7, float_6, float_8, num4 - 1);
				}
			}
			else
			{
				if (num8 == 1)
				{
					num2 = 1 - num2;
				}
				if (num2 == 0)
				{
					Class97.smethod_4(num8, num6, num7, int_5, float_6, float_6, float_6, float_7, float_7, float_8, num4 - 1);
					num2 = 1;
				}
				else
				{
					Class97.smethod_4(num8, num6, num7, int_5, float_7, float_7, float_7, float_6, float_6, float_8, num4 - 1);
					num2 = 0;

					if (num2 == 1)
					{
						return;
					}
					for (int j = 0; j < int_3; j++)
					{
						float_6[j] = float_7[j];
					}
					return;
				}
			}
			num3 = num7;
		}

        if (num2 == 1)
        {
            return;
        }
        for (int j = 0; j < int_3; j++)
        {
            float_6[j] = float_7[j];
        }
        return;
    }

	static void smethod_6(int int_3, int int_4, float[] float_6, float[] float_7, float[] float_8, int int_5)
	{
		int num = int_4 * int_3;
		int num2 = 0;
		int num3 = 0;
		int num4 = (int_3 << 1) - 1;
		for (int i = 0; i < int_4; i++)
		{
			float_7[num2] = float_6[num3] + float_6[num4 + num3];
			float_7[num2 + num] = float_6[num3] - float_6[num4 + num3];
			num3 = (num2 += int_3) << 1;
		}
		if (int_3 < 2)
		{
			return;
		}
		if (int_3 != 2)
		{
			num2 = 0;
			num3 = 0;
			for (int i = 0; i < int_4; i++)
			{
				num4 = num2;
				int num6;
				int num5 = (num6 = num3) + (int_3 << 1);
				int num7 = num + num2;
				for (int j = 2; j < int_3; j += 2)
				{
					num4 += 2;
					num6 += 2;
					num5 -= 2;
					num7 += 2;
					float_7[num4 - 1] = float_6[num6 - 1] + float_6[num5 - 1];
					float num8 = float_6[num6 - 1] - float_6[num5 - 1];
					float_7[num4] = float_6[num6] - float_6[num5];
					float num9 = float_6[num6] + float_6[num5];
					float_7[num7 - 1] = float_8[int_5 + j - 2] * num8 - float_8[int_5 + j - 1] * num9;
					float_7[num7] = float_8[int_5 + j - 2] * num9 + float_8[int_5 + j - 1] * num8;
				}
				num3 = (num2 += int_3) << 1;
			}
			if (int_3 % 2 == 1)
			{
				return;
			}
		}
		num2 = int_3 - 1;
		num3 = int_3 - 1;
		for (int i = 0; i < int_4; i++)
		{
			float_7[num2] = float_6[num3] + float_6[num3];
			float_7[num2 + num] = -(float_6[num3 + 1] + float_6[num3 + 1]);
			num2 += int_3;
			num3 += int_3 << 1;
		}
	}

	static void smethod_7(int int_3, int int_4, float[] float_6, float[] float_7, float[] float_8, int int_5, float[] float_9, int int_6)
	{
		int num = int_4 * int_3;
		int num2 = 0;
		int num3 = num << 1;
		int num4 = int_3 << 1;
		int num5 = int_3 + (int_3 << 1);
		int num6 = 0;
		for (int i = 0; i < int_4; i++)
		{
			float num7 = float_6[num4 - 1] + float_6[num4 - 1];
			float num8 = float_6[num6] + Class97.float_4 * num7;
			float_7[num2] = float_6[num6] + num7;
			float num9 = Class97.float_3 * (float_6[num4] + float_6[num4]);
			float_7[num2 + num] = num8 - num9;
			float_7[num2 + num3] = num8 + num9;
			num2 += int_3;
			num4 += num5;
			num6 += num5;
		}
		if (int_3 == 1)
		{
			return;
		}
		num2 = 0;
		num4 = int_3 << 1;
		for (int i = 0; i < int_4; i++)
		{
			int num10 = num2 + (num2 << 1);
			int num11;
			num6 = (num11 = num10 + num4);
			int num12 = num2;
			int num14;
			int num13 = (num14 = num2 + num) + num;
			for (int j = 2; j < int_3; j += 2)
			{
				num6 += 2;
				num11 -= 2;
				num10 += 2;
				num12 += 2;
				num14 += 2;
				num13 += 2;
				float num7 = float_6[num6 - 1] + float_6[num11 - 1];
				float num8 = float_6[num10 - 1] + Class97.float_4 * num7;
				float_7[num12 - 1] = float_6[num10 - 1] + num7;
				float num15 = float_6[num6] - float_6[num11];
				float num16 = float_6[num10] + Class97.float_4 * num15;
				float_7[num12] = float_6[num10] + num15;
				float num17 = Class97.float_3 * (float_6[num6 - 1] - float_6[num11 - 1]);
				float num9 = Class97.float_3 * (float_6[num6] + float_6[num11]);
				float num18 = num8 - num9;
				float num19 = num8 + num9;
				float num20 = num16 + num17;
				float num21 = num16 - num17;
				float_7[num14 - 1] = float_8[int_5 + j - 2] * num18 - float_8[int_5 + j - 1] * num20;
				float_7[num14] = float_8[int_5 + j - 2] * num20 + float_8[int_5 + j - 1] * num18;
				float_7[num13 - 1] = float_9[int_6 + j - 2] * num19 - float_9[int_6 + j - 1] * num21;
				float_7[num13] = float_9[int_6 + j - 2] * num21 + float_9[int_6 + j - 1] * num19;
			}
			num2 += int_3;
		}
	}

	static void smethod_8(int int_3, int int_4, float[] float_6, float[] float_7, float[] float_8, int int_5, float[] float_9, int int_6, float[] float_10, int int_7)
	{
		int num = int_4 * int_3;
		int num2 = 0;
		int num3 = int_3 << 2;
		int num4 = 0;
		int num5 = int_3 << 1;
		int num6;
		for (int i = 0; i < int_4; i++)
		{
			num6 = num4 + num5;
			int num7 = num2;
			float num8 = float_6[num6 - 1] + float_6[num6 - 1];
			float num9 = float_6[num6] + float_6[num6];
			float num10 = float_6[num4] - float_6[(num6 += num5) - 1];
			float num11 = float_6[num4] + float_6[num6 - 1];
			float_7[num7] = num11 + num8;
			float_7[num7 += num] = num10 - num9;
			float_7[num7 += num] = num11 - num8;
			float_7[num7 + num] = num10 + num9;
			num2 += int_3;
			num4 += num3;
		}
		if (int_3 < 2)
		{
			return;
		}
		if (int_3 != 2)
		{
			num2 = 0;
			for (int i = 0; i < int_4; i++)
			{
				int num7 = (num6 = (num4 = (num3 = num2 << 2) + num5)) + num5;
				int num12 = num2;
				for (int j = 2; j < int_3; j += 2)
				{
					num3 += 2;
					num4 += 2;
					num6 -= 2;
					num7 -= 2;
					num12 += 2;
					float num13 = float_6[num3] + float_6[num7];
					float num14 = float_6[num3] - float_6[num7];
					float num15 = float_6[num4] - float_6[num6];
					float num9 = float_6[num4] + float_6[num6];
					float num10 = float_6[num3 - 1] - float_6[num7 - 1];
					float num11 = float_6[num3 - 1] + float_6[num7 - 1];
					float num16 = float_6[num4 - 1] - float_6[num6 - 1];
					float num8 = float_6[num4 - 1] + float_6[num6 - 1];
					float_7[num12 - 1] = num11 + num8;
					float num17 = num11 - num8;
					float_7[num12] = num14 + num15;
					float num18 = num14 - num15;
					float num19 = num10 - num9;
					float num20 = num10 + num9;
					float num21 = num13 + num16;
					float num22 = num13 - num16;
					int num23;
					float_7[(num23 = num12 + num) - 1] = float_8[int_5 + j - 2] * num19 - float_8[int_5 + j - 1] * num21;
					float_7[num23] = float_8[int_5 + j - 2] * num21 + float_8[int_5 + j - 1] * num19;
					float_7[(num23 += num) - 1] = float_9[int_6 + j - 2] * num17 - float_9[int_6 + j - 1] * num18;
					float_7[num23] = float_9[int_6 + j - 2] * num18 + float_9[int_6 + j - 1] * num17;
					float_7[(num23 += num) - 1] = float_10[int_7 + j - 2] * num20 - float_10[int_7 + j - 1] * num22;
					float_7[num23] = float_10[int_7 + j - 2] * num22 + float_10[int_7 + j - 1] * num20;
				}
				num2 += int_3;
			}
			if (int_3 % 2 == 1)
			{
				return;
			}
		}
		num2 = int_3;
		num3 = int_3 << 2;
		num4 = int_3 - 1;
		num6 = int_3 + (int_3 << 1);
		for (int i = 0; i < int_4; i++)
		{
			int num7 = num4;
			float num13 = float_6[num2] + float_6[num6];
			float num14 = float_6[num6] - float_6[num2];
			float num10 = float_6[num2 - 1] - float_6[num6 - 1];
			float num11 = float_6[num2 - 1] + float_6[num6 - 1];
			float_7[num7] = num11 + num11;
			float_7[num7 += num] = Class97.float_5 * (num10 - num13);
			float_7[num7 += num] = num14 + num14;
			float_7[num7 + num] = -Class97.float_5 * (num10 + num13);
			num4 += int_3;
			num2 += num3;
			num6 += num3;
		}
	}

	static void smethod_9(int int_3, int int_4, int int_5, int int_6, float[] float_6, float[] float_7, float[] float_8, float[] float_9, float[] float_10, float[] float_11, int int_7)
	{
		int num = int_4 * int_3;
		int num2 = int_5 * int_3;
		float num3 = Class97.float_1 / (float)int_4;
		float num4 = (float)Math.Cos((double)num3);
		float num5 = (float)Math.Sin((double)num3);
		int num6 = (int)((uint)(int_3 - 1) >> 1);
		int num7 = (int)((uint)(int_4 + 1) >> 1);
		int num8;
		int num9;
		int num10;
		if (int_3 >= int_5)
		{
			num8 = 0;
			num9 = 0;
			for (int i = 0; i < int_5; i++)
			{
				num10 = num8;
				int num11 = num9;
				for (int j = 0; j < int_3; j++)
				{
					float_9[num10] = float_6[num11];
					num10++;
					num11++;
				}
				num8 += int_3;
				num9 += num;
			}
		}
		else
		{
			num8 = 0;
			for (int j = 0; j < int_3; j++)
			{
				num9 = num8;
				num10 = num8;
				for (int i = 0; i < int_5; i++)
				{
					float_9[num9] = float_6[num10];
					num9 += int_3;
					num10 += num;
				}
				num8++;
			}
		}
		num8 = 0;
		num9 = int_4 * num2;
		int num13;
		int num12 = num13 = int_3 << 1;
		for (int k = 1; k < num7; k++)
		{
			num8 += num2;
			num9 -= num2;
			num10 = num8;
			int num11 = num9;
			int num14 = num12;
			for (int i = 0; i < int_5; i++)
			{
				float_9[num10] = float_6[num14 - 1] + float_6[num14 - 1];
				float_9[num11] = float_6[num14] + float_6[num14];
				num10 += int_3;
				num11 += int_3;
				num14 += num;
			}
			num12 += num13;
		}
		int num16;
		if (int_3 != 1)
		{
			if (num6 >= int_5)
			{
				num8 = 0;
				num9 = int_4 * num2;
				num13 = 0;
				for (int k = 1; k < num7; k++)
				{
					num8 += num2;
					num9 -= num2;
					num10 = num8;
					int num11 = num9;
					num13 += int_3 << 1;
					int num15 = num13;
					for (int i = 0; i < int_5; i++)
					{
						num12 = num10;
						int num14 = num11;
						num16 = num15;
						int num17 = num15;
						for (int j = 2; j < int_3; j += 2)
						{
							num12 += 2;
							num14 += 2;
							num16 += 2;
							num17 -= 2;
							float_9[num12 - 1] = float_6[num16 - 1] + float_6[num17 - 1];
							float_9[num14 - 1] = float_6[num16 - 1] - float_6[num17 - 1];
							float_9[num12] = float_6[num16] - float_6[num17];
							float_9[num14] = float_6[num16] + float_6[num17];
						}
						num10 += int_3;
						num11 += int_3;
						num15 += num;
					}
				}
			}
			else
			{
				num8 = 0;
				num9 = int_4 * num2;
				num13 = 0;
				for (int k = 1; k < num7; k++)
				{
					num8 += num2;
					num9 -= num2;
					num10 = num8;
					int num11 = num9;
					num13 += int_3 << 1;
					int num15 = num13;
					num16 = num13;
					for (int j = 2; j < int_3; j += 2)
					{
						num10 += 2;
						num11 += 2;
						num15 += 2;
						num16 -= 2;
						num12 = num10;
						int num14 = num11;
						int num17 = num15;
						int num18 = num16;
						for (int i = 0; i < int_5; i++)
						{
							float_9[num12 - 1] = float_6[num17 - 1] + float_6[num18 - 1];
							float_9[num14 - 1] = float_6[num17 - 1] - float_6[num18 - 1];
							float_9[num12] = float_6[num17] - float_6[num18];
							float_9[num14] = float_6[num17] + float_6[num18];
							num12 += int_3;
							num14 += int_3;
							num17 += num;
							num18 += num;
						}
					}
				}
			}
		}
		float num19 = 1f;
		float num20 = 0f;
		num8 = 0;
		num9 = (num16 = int_4 * int_6);
		num10 = (int_4 - 1) * int_6;
		for (int l = 1; l < num7; l++)
		{
			num8 += int_6;
			num9 -= int_6;
			float num21 = num4 * num19 - num5 * num20;
			num20 = num4 * num20 + num5 * num19;
			num19 = num21;
			int num11 = num8;
			num12 = num9;
			int num14 = 0;
			num13 = int_6;
			int num15 = num10;
			for (int m = 0; m < int_6; m++)
			{
				float_8[num11++] = float_10[num14++] + num19 * float_10[num13++];
				float_8[num12++] = num20 * float_10[num15++];
			}
			float num22 = num19;
			float num23 = num20;
			float num24 = num19;
			float num25 = num20;
			num14 = int_6;
			num13 = num16 - int_6;
			for (int k = 2; k < num7; k++)
			{
				num14 += int_6;
				num13 -= int_6;
				float num26 = num22 * num24 - num23 * num25;
				num25 = num22 * num25 + num23 * num24;
				num24 = num26;
				num11 = num8;
				num12 = num9;
				int num17 = num14;
				int num18 = num13;
				for (int m = 0; m < int_6; m++)
				{
					float_8[num11] += num24 * float_10[num17++];
					num11++;
					float_8[num12] += num25 * float_10[num18++];
					num12++;
				}
			}
		}
		num8 = 0;
		for (int k = 1; k < num7; k++)
		{
			num8 += int_6;
			num9 = num8;
			for (int m = 0; m < int_6; m++)
			{
				float_10[m] += float_10[num9++];
			}
		}
		num8 = 0;
		num9 = int_4 * num2;
		for (int k = 1; k < num7; k++)
		{
			num8 += num2;
			num9 -= num2;
			num10 = num8;
			int num11 = num9;
			for (int i = 0; i < int_5; i++)
			{
				float_9[num10] = float_7[num10] - float_7[num11];
				float_9[num11] = float_7[num10] + float_7[num11];
				num10 += int_3;
				num11 += int_3;
			}
		}
		if (int_3 != 1)
		{
			if (num6 >= int_5)
			{
				num8 = 0;
				num9 = int_4 * num2;
				for (int k = 1; k < num7; k++)
				{
					num8 += num2;
					num9 -= num2;
					num10 = num8;
					int num11 = num9;
					for (int i = 0; i < int_5; i++)
					{
						num12 = num10;
						int num14 = num11;
						for (int j = 2; j < int_3; j += 2)
						{
							num12 += 2;
							num14 += 2;
							float_9[num12 - 1] = float_7[num12 - 1] - float_7[num14];
							float_9[num14 - 1] = float_7[num12 - 1] + float_7[num14];
							float_9[num12] = float_7[num12] + float_7[num14 - 1];
							float_9[num14] = float_7[num12] - float_7[num14 - 1];
						}
						num10 += int_3;
						num11 += int_3;
					}
				}
			}
			else
			{
				num8 = 0;
				num9 = int_4 * num2;
				for (int k = 1; k < num7; k++)
				{
					num8 += num2;
					num9 -= num2;
					num10 = num8;
					int num11 = num9;
					for (int j = 2; j < int_3; j += 2)
					{
						num10 += 2;
						num11 += 2;
						num12 = num10;
						int num14 = num11;
						for (int i = 0; i < int_5; i++)
						{
							float_9[num12 - 1] = float_7[num12 - 1] - float_7[num14];
							float_9[num14 - 1] = float_7[num12 - 1] + float_7[num14];
							float_9[num12] = float_7[num12] + float_7[num14 - 1];
							float_9[num14] = float_7[num12] - float_7[num14 - 1];
							num12 += int_3;
							num14 += int_3;
						}
					}
				}
			}
		}
		if (int_3 == 1)
		{
			return;
		}
		for (int m = 0; m < int_6; m++)
		{
			float_8[m] = float_10[m];
		}
		num8 = 0;
		for (int k = 1; k < int_4; k++)
		{
			num8 = (num9 = num8 + num2);
			for (int i = 0; i < int_5; i++)
			{
				float_7[num9] = float_9[num9];
				num9 += int_3;
			}
		}
		int num27;
		if (num6 <= int_5)
		{
			num27 = -int_3 - 1;
			num8 = 0;
			for (int k = 1; k < int_4; k++)
			{
				num27 += int_3;
				num8 += num2;
				int num28 = num27;
				num9 = num8;
				for (int j = 2; j < int_3; j += 2)
				{
					num9 += 2;
					num28 += 2;
					num10 = num9;
					for (int i = 0; i < int_5; i++)
					{
						float_7[num10 - 1] = float_11[int_7 + num28 - 1] * float_9[num10 - 1] - float_11[int_7 + num28] * float_9[num10];
						float_7[num10] = float_11[int_7 + num28 - 1] * float_9[num10] + float_11[int_7 + num28] * float_9[num10 - 1];
						num10 += int_3;
					}
				}
			}
			return;
		}
		num27 = -int_3 - 1;
		num8 = 0;
		for (int k = 1; k < int_4; k++)
		{
			num27 += int_3;
			num8 += num2;
			num9 = num8;
			for (int i = 0; i < int_5; i++)
			{
				int num28 = num27;
				num10 = num9;
				for (int j = 2; j < int_3; j += 2)
				{
					num28 += 2;
					num10 += 2;
					float_7[num10 - 1] = float_11[int_7 + num28 - 1] * float_9[num10 - 1] - float_11[int_7 + num28] * float_9[num10];
					float_7[num10] = float_11[int_7 + num28 - 1] * float_9[num10] + float_11[int_7 + num28] * float_9[num10 - 1];
				}
				num9 += int_3;
			}
		}
	}

	static void smethod_10(int int_3, float[] float_6, float[] float_7, float[] float_8, int int_4, int[] int_5)
	{
		int num = int_5[1];
		int num2 = 0;
		int num3 = 1;
		int num4 = 1;
		for (int i = 0; i < num; i++)
		{
			int num5 = int_5[i + 2];
			int num6 = num5 * num3;
			int num7 = int_3 / num6;
			int int_6 = num7 * num3;
			if (num5 == 4)
			{
				int num8 = num4 + num7;
				int num9 = num8 + num7;
				if (num2 != 0)
				{
					Class97.smethod_8(num7, num3, float_7, float_6, float_8, int_4 + num4 - 1, float_8, int_4 + num8 - 1, float_8, int_4 + num9 - 1);
				}
				else
				{
					Class97.smethod_8(num7, num3, float_6, float_7, float_8, int_4 + num4 - 1, float_8, int_4 + num8 - 1, float_8, int_4 + num9 - 1);
				}
				num2 = 1 - num2;
			}
			else if (num5 == 2)
			{
				if (num2 != 0)
				{
					Class97.smethod_6(num7, num3, float_7, float_6, float_8, int_4 + num4 - 1);
				}
				else
				{
					Class97.smethod_6(num7, num3, float_6, float_7, float_8, int_4 + num4 - 1);
				}
				num2 = 1 - num2;
			}
			else if (num5 == 3)
			{
				int num8 = num4 + num7;
				if (num2 != 0)
				{
					Class97.smethod_7(num7, num3, float_7, float_6, float_8, int_4 + num4 - 1, float_8, int_4 + num8 - 1);
				}
				else
				{
					Class97.smethod_7(num7, num3, float_6, float_7, float_8, int_4 + num4 - 1, float_8, int_4 + num8 - 1);
				}
				num2 = 1 - num2;
			}
			else
			{
				if (num2 != 0)
				{
					Class97.smethod_9(num7, num5, num3, int_6, float_7, float_7, float_7, float_6, float_6, float_8, int_4 + num4 - 1);
				}
				else
				{
					Class97.smethod_9(num7, num5, num3, int_6, float_6, float_6, float_6, float_7, float_7, float_8, int_4 + num4 - 1);
				}
				if (num7 == 1)
				{
					num2 = 1 - num2;
				}
				num4 += (num5 - 1) * num7;
			}
			num3 = num6;
			num4 += (num5 - 1) * num7;
		}
		if (num2 == 0)
		{
			return;
		}
		for (int j = 0; j < int_3; j++)
		{
			float_6[j] = float_7[j];
		}
	}

	int int_0;

	float[] float_0;

	int[] int_1;

	static int[] int_2 = new int[]
	{
		4,
		2,
		3,
		5
	};

	static float float_1 = 6.28318548f;

	static float float_2 = 0.707106769f;

	static float float_3 = 0.8660254f;

	static float float_4 = -0.5f;

	static float float_5 = 1.41421354f;
}
