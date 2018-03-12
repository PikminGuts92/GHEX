using System;

public class GClass101
{
	public GClass101()
	{
		this.object_0 = new object[2][];
		this.float_3 = new float[2][][][][];
		this.float_3[0] = new float[2][][][];
		this.float_3[0][0] = new float[2][][];
		this.float_3[0][1] = new float[2][][];
		this.float_3[0][0][0] = new float[2][];
		this.float_3[0][0][1] = new float[2][];
		this.float_3[0][1][0] = new float[2][];
		this.float_3[0][1][1] = new float[2][];
		this.float_3[1] = new float[2][][][];
		this.float_3[1][0] = new float[2][][];
		this.float_3[1][1] = new float[2][][];
		this.float_3[1][0][0] = new float[2][];
		this.float_3[1][0][1] = new float[2][];
		this.float_3[1][1][0] = new float[2][];
		this.float_3[1][1][1] = new float[2][];
	}

	static int smethod_0(int int_14)
	{
		int num = 0;
		while (int_14 > 1)
		{
			num++;
			int_14 = (int)((uint)int_14 >> 1);
		}
		return num;
	}

	internal static float[] smethod_1(int int_14, int int_15, int int_16, int int_17)
	{
		float[] array = new float[int_15];
		if (int_14 == 0)
		{
			int num = int_15 / 4 - int_16 / 2;
			int num2 = int_15 - int_15 / 4 - int_17 / 2;
			for (int i = 0; i < int_16; i++)
			{
				float num3 = (float)(((double)i + 0.5) / (double)int_16 * (double)GClass101.float_0 / 2.0);
				num3 = (float)Math.Sin((double)num3);
				num3 *= num3;
				num3 *= (float)((double)GClass101.float_0 / 2.0);
				num3 = (float)Math.Sin((double)num3);
				array[i + num] = num3;
			}
			for (int j = num + int_16; j < num2; j++)
			{
				array[j] = 1f;
			}
			for (int k = 0; k < int_17; k++)
			{
				float num4 = (float)(((double)(int_17 - k) - 0.5) / (double)int_17 * (double)GClass101.float_0 / 2.0);
				num4 = (float)Math.Sin((double)num4);
				num4 *= num4;
				num4 *= (float)((double)GClass101.float_0 / 2.0);
				num4 = (float)Math.Sin((double)num4);
				array[k + num2] = num4;
			}
			return array;
		}
		return null;
	}

	int method_0(GClass100 gclass100_1, bool bool_0)
	{
		this.gclass100_0 = gclass100_1;
		this.int_3 = GClass101.smethod_0(gclass100_1.int_14);
		this.object_0[0] = new object[GClass101.int_0];
		this.object_0[1] = new object[GClass101.int_0];
		this.object_0[0][0] = new Class106();
		this.object_0[1][0] = new Class106();
		((Class106)this.object_0[0][0]).method_0(gclass100_1.int_13[0]);
		((Class106)this.object_0[1][0]).method_0(gclass100_1.int_13[1]);
		this.float_3[0][0][0] = new float[GClass101.int_1][];
		this.float_3[0][0][1] = this.float_3[0][0][0];
		this.float_3[0][1][0] = this.float_3[0][0][0];
		this.float_3[0][1][1] = this.float_3[0][0][0];
		this.float_3[1][0][0] = new float[GClass101.int_1][];
		this.float_3[1][0][1] = new float[GClass101.int_1][];
		this.float_3[1][1][0] = new float[GClass101.int_1][];
		this.float_3[1][1][1] = new float[GClass101.int_1][];
		for (int i = 0; i < GClass101.int_1; i++)
		{
			this.float_3[0][0][0][i] = GClass101.smethod_1(i, gclass100_1.int_13[0], gclass100_1.int_13[0] / 2, gclass100_1.int_13[0] / 2);
			this.float_3[1][0][0][i] = GClass101.smethod_1(i, gclass100_1.int_13[1], gclass100_1.int_13[0] / 2, gclass100_1.int_13[0] / 2);
			this.float_3[1][0][1][i] = GClass101.smethod_1(i, gclass100_1.int_13[1], gclass100_1.int_13[0] / 2, gclass100_1.int_13[1] / 2);
			this.float_3[1][1][0][i] = GClass101.smethod_1(i, gclass100_1.int_13[1], gclass100_1.int_13[1] / 2, gclass100_1.int_13[0] / 2);
			this.float_3[1][1][1][i] = GClass101.smethod_1(i, gclass100_1.int_13[1], gclass100_1.int_13[1] / 2, gclass100_1.int_13[1] / 2);
		}
		this.class112_0 = new Class112[gclass100_1.int_19];
		for (int j = 0; j < gclass100_1.int_19; j++)
		{
			this.class112_0[j] = new Class112();
			this.class112_0[j].method_13(gclass100_1.class90_0[j]);
		}
		this.int_4 = 8192;
		this.float_1 = new float[gclass100_1.int_8][];
		for (int k = 0; k < gclass100_1.int_8; k++)
		{
			this.float_1[k] = new float[this.int_4];
		}
		this.int_10 = 0;
		this.int_11 = 0;
		this.int_13 = gclass100_1.int_13[1] / 2;
		this.int_5 = this.int_13;
		this.object_1 = new object[gclass100_1.int_14];
		for (int l = 0; l < gclass100_1.int_14; l++)
		{
			int num = gclass100_1.class6_0[l].int_3;
			int num2 = gclass100_1.int_21[num];
			this.object_1[l] = Class40.class40_0[num2].vmethod_2(this, gclass100_1.class6_0[l], gclass100_1.object_0[num]);
		}
		return 0;
	}

	public int method_1(GClass100 gclass100_1)
	{
		this.method_0(gclass100_1, false);
		this.int_6 = this.int_13;
		this.int_13 -= gclass100_1.int_13[this.int_11] / 4 + gclass100_1.int_13[this.int_10] / 4;
		this.long_0 = -1L;
		this.long_1 = -1L;
		return 0;
	}

	GClass101(GClass100 gclass100_1) : this()
	{
		this.method_0(gclass100_1, false);
		this.int_6 = this.int_13;
		this.int_13 -= gclass100_1.int_13[this.int_11] / 4 + gclass100_1.int_13[this.int_10] / 4;
		this.long_0 = -1L;
		this.long_1 = -1L;
	}

	public int method_2(GClass108 gclass108_0)
	{
		if (this.int_13 > this.gclass100_0.int_13[1] / 2 && this.int_6 > 8192)
		{
			int num = this.int_13 - this.gclass100_0.int_13[1] / 2;
			num = ((this.int_6 < num) ? this.int_6 : num);
			this.int_5 -= num;
			this.int_13 -= num;
			this.int_6 -= num;
			if (num != 0)
			{
				for (int i = 0; i < this.gclass100_0.int_8; i++)
				{
					Array.Copy(this.float_1[i], num, this.float_1[i], 0, this.int_5);
				}
			}
		}
		this.int_10 = this.int_11;
		this.int_11 = gclass108_0.int_1;
		this.int_12 = -1;
		this.long_2 += (long)gclass108_0.int_6;
		this.long_3 += (long)gclass108_0.int_7;
		this.long_4 += (long)gclass108_0.int_8;
		this.long_5 += (long)gclass108_0.int_9;
		if (this.long_1 + 1L != gclass108_0.long_1)
		{
			this.long_0 = -1L;
		}
		this.long_1 = gclass108_0.long_1;
		int num2 = this.gclass100_0.int_13[this.int_11];
		int num3 = this.int_13 + this.gclass100_0.int_13[this.int_10] / 4 + num2 / 4;
		int num4 = num3 - num2 / 2;
		int num5 = num4 + num2;
		int num6 = 0;
		int num7 = 0;
		if (num5 > this.int_4)
		{
			this.int_4 = num5 + this.gclass100_0.int_13[1];
			for (int j = 0; j < this.gclass100_0.int_8; j++)
			{
				float[] array = new float[this.int_4];
				Array.Copy(this.float_1[j], 0, array, 0, this.float_1[j].Length);
				this.float_1[j] = array;
			}
		}
		switch (this.int_11)
		{
		case 0:
			num6 = 0;
			num7 = this.gclass100_0.int_13[0] / 2;
			break;
		case 1:
			num6 = this.gclass100_0.int_13[1] / 4 - this.gclass100_0.int_13[this.int_10] / 4;
			num7 = num6 + this.gclass100_0.int_13[this.int_10] / 2;
			break;
		}
		for (int k = 0; k < this.gclass100_0.int_8; k++)
		{
			int num8 = num4;
			int l;
			for (l = num6; l < num7; l++)
			{
				this.float_1[k][num8 + l] += gclass108_0.float_0[k][l];
			}
			while (l < num2)
			{
				this.float_1[k][num8 + l] = gclass108_0.float_0[k][l];
				l++;
			}
		}
		if (this.long_0 == -1L)
		{
			this.long_0 = gclass108_0.long_0;
		}
		else
		{
			this.long_0 += (long)(num3 - this.int_13);
			if (gclass108_0.long_0 != -1L && this.long_0 != gclass108_0.long_0)
			{
				if (this.long_0 > gclass108_0.long_0 && gclass108_0.int_5 != 0)
				{
					num3 -= (int)(this.long_0 - gclass108_0.long_0);
				}
				this.long_0 = gclass108_0.long_0;
			}
		}
		this.int_13 = num3;
		this.int_5 = num5;
		if (gclass108_0.int_5 != 0)
		{
			this.int_9 = 1;
		}
		return 0;
	}

	public int method_3(float[][][] float_4, int[] int_14)
	{
		if (this.int_6 < this.int_13)
		{
			if (float_4 != null)
			{
				for (int i = 0; i < this.gclass100_0.int_8; i++)
				{
					int_14[i] = this.int_6;
				}
				float_4[0] = this.float_1;
			}
			return this.int_13 - this.int_6;
		}
		return 0;
	}

	public int method_4(int int_14)
	{
		if (int_14 != 0 && this.int_6 + int_14 > this.int_13)
		{
			return -1;
		}
		this.int_6 += int_14;
		return 0;
	}

	public void method_5()
	{
	}

	static float float_0 = 3.14159274f;

	static int int_0 = 1;

	static int int_1 = 1;

	internal int int_2;

	internal GClass100 gclass100_0;

	internal int int_3;

	float[][] float_1;

	int int_4;

	int int_5;

	int int_6;

	float[] float_2;

	int int_7;

	int int_8;

	int int_9;

	int int_10;

	int int_11;

	int int_12;

	int int_13;

	long long_0;

	public long long_1;

	long long_2;

	long long_3;

	long long_4;

	long long_5;

	internal float[][][][][] float_3;

	internal object[][] object_0;

	internal Class112[] class112_0;

	internal object[] object_1;
}
