using System;

class Class90
{
	internal Class90()
	{
	}

	internal Class90(int int_11, int int_12, int[] int_13, int int_14, int int_15, int int_16, int int_17, int int_18, int[] int_19, object object_0, object object_1) : this()
	{
		this.int_0 = int_11;
		this.int_1 = int_12;
		this.int_2 = int_13;
		this.int_3 = int_14;
		this.int_4 = int_15;
		this.int_5 = int_16;
		this.int_6 = int_17;
		this.int_7 = int_18;
		this.int_8 = int_19;
	}

	internal int method_0(GClass37 gclass37_0)
	{
		bool flag = false;
		gclass37_0.method_6(5653314, 24);
		gclass37_0.method_6(this.int_0, 16);
		gclass37_0.method_6(this.int_1, 24);
		int i = 1;
		while (i < this.int_1 && this.int_2[i] >= this.int_2[i - 1])
		{
			i++;
		}
		if (i == this.int_1)
		{
			flag = true;
		}
		if (flag)
		{
			int num = 0;
			gclass37_0.method_6(1, 1);
			gclass37_0.method_6(this.int_2[0] - 1, 5);
			for (i = 1; i < this.int_1; i++)
			{
				int num2 = this.int_2[i];
				int num3 = this.int_2[i - 1];
				if (num2 > num3)
				{
					for (int j = num3; j < num2; j++)
					{
						gclass37_0.method_6(i - num, Class90.smethod_0(this.int_1 - num));
						num = i;
					}
				}
			}
			gclass37_0.method_6(i - num, Class90.smethod_0(this.int_1 - num));
		}
		else
		{
			gclass37_0.method_6(0, 1);
			i = 0;
			while (i < this.int_1 && this.int_2[i] != 0)
			{
				i++;
			}
			if (i == this.int_1)
			{
				gclass37_0.method_6(0, 1);
				for (i = 0; i < this.int_1; i++)
				{
					gclass37_0.method_6(this.int_2[i] - 1, 5);
				}
			}
			else
			{
				gclass37_0.method_6(1, 1);
				for (i = 0; i < this.int_1; i++)
				{
					if (this.int_2[i] == 0)
					{
						gclass37_0.method_6(0, 1);
					}
					else
					{
						gclass37_0.method_6(1, 1);
						gclass37_0.method_6(this.int_2[i] - 1, 5);
					}
				}
			}
		}
		gclass37_0.method_6(this.int_3, 4);
		switch (this.int_3)
		{
		case 0:
			break;
		case 1:
		case 2:
		{
			if (this.int_8 == null)
			{
				return -1;
			}
			gclass37_0.method_6(this.int_4, 32);
			gclass37_0.method_6(this.int_5, 32);
			gclass37_0.method_6(this.int_6 - 1, 4);
			gclass37_0.method_6(this.int_7, 1);
			int num4 = 0;
			switch (this.int_3)
			{
			case 1:
				num4 = this.method_2();
				break;
			case 2:
				num4 = this.int_1 * this.int_0;
				break;
			}
			for (i = 0; i < num4; i++)
			{
				gclass37_0.method_6(Math.Abs(this.int_8[i]), this.int_6);
			}
			break;
		}
		default:
			return -1;
		}
		return 0;
	}

	internal int method_1(GClass37 gclass37_0)
	{
		if (gclass37_0.method_12(24) != 5653314)
		{
			this.method_3();
			return -1;
		}
		this.int_0 = gclass37_0.method_12(16);
		this.int_1 = gclass37_0.method_12(24);
		if (this.int_1 == -1)
		{
			this.method_3();
			return -1;
		}
		switch (gclass37_0.method_12(1))
		{
		case 0:
			this.int_2 = new int[this.int_1];
			if (gclass37_0.method_12(1) != 0)
			{
				for (int i = 0; i < this.int_1; i++)
				{
					if (gclass37_0.method_12(1) != 0)
					{
						int num = gclass37_0.method_12(5);
						if (num == -1)
						{
							this.method_3();
							return -1;
						}
						this.int_2[i] = num + 1;
					}
					else
					{
						this.int_2[i] = 0;
					}
				}
			}
			else
			{
				for (int i = 0; i < this.int_1; i++)
				{
					int num2 = gclass37_0.method_12(5);
					if (num2 == -1)
					{
						this.method_3();
						return -1;
					}
					this.int_2[i] = num2 + 1;
				}
			}
			break;
		case 1:
		{
			int num3 = gclass37_0.method_12(5) + 1;
			this.int_2 = new int[this.int_1];
			int i = 0;
			while (i < this.int_1)
			{
				int num4 = gclass37_0.method_12(Class90.smethod_0(this.int_1 - i));
				if (num4 == -1)
				{
					this.method_3();
					return -1;
				}
				int j = 0;
				while (j < num4)
				{
					this.int_2[i] = num3;
					j++;
					i++;
				}
				num3++;
			}
			break;
		}
		default:
			return -1;
		}
		switch (this.int_3 = gclass37_0.method_12(4))
		{
		case 0:
			break;
		case 1:
		case 2:
		{
			this.int_4 = gclass37_0.method_12(32);
			this.int_5 = gclass37_0.method_12(32);
			this.int_6 = gclass37_0.method_12(4) + 1;
			this.int_7 = gclass37_0.method_12(1);
			int num5 = 0;
			switch (this.int_3)
			{
			case 1:
				num5 = this.method_2();
				break;
			case 2:
				num5 = this.int_1 * this.int_0;
				break;
			}
			this.int_8 = new int[num5];
			for (int i = 0; i < num5; i++)
			{
				this.int_8[i] = gclass37_0.method_12(this.int_6);
			}
			if (this.int_8[num5 - 1] == -1)
			{
				this.method_3();
				return -1;
			}
			break;
		}
		default:
			this.method_3();
			return -1;
		}
		return 0;
	}

	internal int method_2()
	{
		int num = (int)Math.Floor(Math.Pow((double)this.int_1, 1.0 / (double)this.int_0));
		for (;;)
		{
			int num2 = 1;
			int num3 = 1;
			for (int i = 0; i < this.int_0; i++)
			{
				num2 *= num;
				num3 *= num + 1;
			}
			if (num2 <= this.int_1 && num3 > this.int_1)
			{
				break;
			}
			if (num2 > this.int_1)
			{
				num--;
			}
			else
			{
				num++;
			}
		}
		return num;
	}

	internal void method_3()
	{
	}

	internal float[] method_4()
	{
		if (this.int_3 != 1)
		{
			if (this.int_3 != 2)
			{
				return null;
			}
		}
		float num = Class90.smethod_2(this.int_4);
		float num2 = Class90.smethod_2(this.int_5);
		float[] array = new float[this.int_1 * this.int_0];
		switch (this.int_3)
		{
		case 1:
		{
			int num3 = this.method_2();
			for (int i = 0; i < this.int_1; i++)
			{
				float num4 = 0f;
				int num5 = 1;
				for (int j = 0; j < this.int_0; j++)
				{
					int num6 = i / num5 % num3;
					float num7 = (float)this.int_8[num6];
					num7 = Math.Abs(num7) * num2 + num + num4;
					if (this.int_7 != 0)
					{
						num4 = num7;
					}
					array[i * this.int_0 + j] = num7;
					num5 *= num3;
				}
			}
			break;
		}
		case 2:
			for (int k = 0; k < this.int_1; k++)
			{
				float num8 = 0f;
				for (int l = 0; l < this.int_0; l++)
				{
					float num9 = (float)this.int_8[k * this.int_0 + l];
					num9 = Math.Abs(num9) * num2 + num + num8;
					if (this.int_7 != 0)
					{
						num8 = num9;
					}
					array[k * this.int_0 + l] = num9;
				}
			}
			break;
		}
		return array;
	}

	internal static int smethod_0(int int_11)
	{
		int num = 0;
		while (int_11 != 0)
		{
			num++;
			int_11 = (int)((uint)int_11 >> 1);
		}
		return num;
	}

	internal static long smethod_1(float float_0)
	{
		uint num = 0u;
		if (float_0 < 0f)
		{
			num = 2147483648u;
			float_0 = -float_0;
		}
		int num2 = (int)Math.Floor(Math.Log((double)float_0) / Math.Log(2.0));
		int num3 = (int)Math.Round(Math.Pow((double)float_0, (double)(Class90.int_9 - 1 - num2)));
		num2 = num2 + Class90.int_10 << Class90.int_9;
		return (long)(num | (uint)num2 | (uint)num3);
	}

	internal static float smethod_2(int int_11)
	{
		float num = (float)(int_11 & 2097151);
		float num2 = (uint)(int_11 & 2145386496) >> Class90.int_9;
		if (((long)int_11 & 2147483648L) != 0L)
		{
			num = -num;
		}
		return Class90.smethod_3(num, (int)num2 - (Class90.int_9 - 1) - Class90.int_10);
	}

	internal static float smethod_3(float float_0, int int_11)
	{
		return (float)((double)float_0 * Math.Pow(2.0, (double)int_11));
	}

	internal int int_0;

	internal int int_1;

	internal int[] int_2;

	internal int int_3;

	internal int int_4;

	internal int int_5;

	internal int int_6;

	internal int int_7;

	internal int[] int_8;

	internal Class107 class107_0;

	internal Class18 class18_0;

	static int int_9 = 21;

	static int int_10 = 768;
}
