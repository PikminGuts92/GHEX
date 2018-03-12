using System;

class Class27 : Class25
{
	public override void vmethod_0(object object_0, GClass37 gclass37_0)
	{
		Class44 @class = (Class44)object_0;
		gclass37_0.method_6(@class.int_0, 8);
		gclass37_0.method_6(@class.int_1, 16);
		gclass37_0.method_6(@class.int_2, 16);
		gclass37_0.method_6(@class.int_3, 6);
		gclass37_0.method_6(@class.int_4, 8);
		gclass37_0.method_6(@class.int_5 - 1, 4);
		for (int i = 0; i < @class.int_5; i++)
		{
			gclass37_0.method_6(@class.int_6[i], 8);
		}
	}

	public override object vmethod_1(GClass100 gclass100_0, GClass37 gclass37_0)
	{
		Class44 @class = new Class44();
		@class.int_0 = gclass37_0.method_12(8);
		@class.int_1 = gclass37_0.method_12(16);
		@class.int_2 = gclass37_0.method_12(16);
		@class.int_3 = gclass37_0.method_12(6);
		@class.int_4 = gclass37_0.method_12(8);
		@class.int_5 = gclass37_0.method_12(4) + 1;
		if (@class.int_0 >= 1 && @class.int_1 >= 1 && @class.int_2 >= 1 && @class.int_5 >= 1)
		{
			for (int i = 0; i < @class.int_5; i++)
			{
				@class.int_6[i] = gclass37_0.method_12(8);
				if (@class.int_6[i] < 0 || @class.int_6[i] >= gclass100_0.int_19)
				{
					return null;
				}
			}
			return @class;
		}
		return null;
	}

	public override object vmethod_2(GClass101 gclass101_0, Class6 class6_0, object object_0)
	{
		GClass100 gclass100_ = gclass101_0.gclass100_0;
		Class44 @class = (Class44)object_0;
		Class45 class2 = new Class45();
		class2.int_2 = @class.int_0;
		class2.int_0 = gclass100_.int_13[class6_0.int_0] / 2;
		class2.int_1 = @class.int_2;
		class2.class44_0 = @class;
		class2.class111_0.method_1(class2.int_1, class2.int_2);
		float num = (float)class2.int_1 / (float)Class27.smethod_0((float)((double)@class.int_1 / 2.0));
		class2.int_3 = new int[class2.int_0];
		for (int i = 0; i < class2.int_0; i++)
		{
			int num2 = (int)Math.Floor(Class27.smethod_0((float)((double)@class.int_1 / 2.0 / (double)class2.int_0 * (double)i)) * (double)num);
			if (num2 >= class2.int_1)
			{
				num2 = class2.int_1;
			}
			class2.int_3[i] = num2;
		}
		return class2;
	}

	static double smethod_0(float float_1)
	{
		double num = 13.1 * Math.Atan(0.00074 * (double)float_1);
		double num2 = 2.24 * Math.Atan((double)(float_1 * float_1) * 1.85E-08);
		double num3 = 0.0001 * (double)float_1;
		return num + num2 + num3;
	}

	object method_0(object object_0)
	{
		Class46 @class = new Class46();
		Class44 class2 = (Class44)object_0;
		@class.int_0 = new int[class2.int_0];
		@class.float_0 = new float[class2.int_2];
		@class.long_0 = -1L;
		return @class;
	}

	public override void vmethod_3(object object_0)
	{
	}

	public override void vmethod_4(object object_0)
	{
	}

	public override void vmethod_5(object object_0)
	{
	}

	public override int vmethod_6(GClass108 gclass108_0, object object_0, float[] float_1, float[] float_2, object object_1)
	{
		return 0;
	}

	int method_1(GClass108 gclass108_0, object object_0, float[] float_1)
	{
		Class45 @class = (Class45)object_0;
		Class44 class44_ = @class.class44_0;
		int num = gclass108_0.gclass37_0.method_12(class44_.int_3);
		if (num > 0)
		{
			int num2 = (1 << class44_.int_3) - 1;
			float float_2 = (float)num / (float)num2 * (float)class44_.int_4;
			int num3 = gclass108_0.gclass37_0.method_12(Class27.smethod_2(class44_.int_5));
			if (num3 != -1 && num3 < class44_.int_5)
			{
				int result;
				lock (this)
				{
					if (this.float_0 != null && this.float_0.Length >= @class.int_2)
					{
						for (int i = 0; i < @class.int_2; i++)
						{
							this.float_0[i] = 0f;
						}
					}
					else
					{
						this.float_0 = new float[@class.int_2];
					}
					Class112 class2 = gclass108_0.gclass101_0.class112_0[class44_.int_6[num3]];
					float num4 = 0f;
					for (int j = 0; j < @class.int_2; j++)
					{
						float_1[j] = 0f;
					}
					for (int k = 0; k < @class.int_2; k += class2.int_0)
					{
						if (class2.method_9(this.float_0, k, gclass108_0.gclass37_0, 1, -1) == -1)
						{
							for (int l = 0; l < @class.int_0; l++)
							{
								float_1[l] = 0f;
							}
							return 0;
						}
					}
					int m = 0;
					while (m < @class.int_2)
					{
						int n = 0;
						while (n < class2.int_0)
						{
							this.float_0[m] += num4;
							n++;
							m++;
						}
						num4 = this.float_0[m - 1];
					}
					Class32.smethod_0(float_1, @class.int_3, @class.int_0, @class.int_1, this.float_0, @class.int_2, float_2, (float)class44_.int_4);
					result = 1;
				}
				return result;
			}
		}
		return 0;
	}

	public override object vmethod_7(GClass108 gclass108_0, object object_0, object object_1)
	{
		Class45 @class = (Class45)object_0;
		Class44 class44_ = @class.class44_0;
		float[] array = null;
		if (object_1 is float[])
		{
			array = (float[])object_1;
		}
		int num = gclass108_0.gclass37_0.method_12(class44_.int_3);
		if (num > 0)
		{
			int num2 = (1 << class44_.int_3) - 1;
			float num3 = (float)num / (float)num2 * (float)class44_.int_4;
			int num4 = gclass108_0.gclass37_0.method_12(Class27.smethod_2(class44_.int_5));
			if (num4 != -1 && num4 < class44_.int_5)
			{
				Class112 class2 = gclass108_0.gclass101_0.class112_0[class44_.int_6[num4]];
				float num5 = 0f;
				if (array != null && array.Length >= @class.int_2 + 1)
				{
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = 0f;
					}
				}
				else
				{
					array = new float[@class.int_2 + 1];
				}
				for (int j = 0; j < @class.int_2; j += class2.int_0)
				{
					if (class2.method_6(array, j, gclass108_0.gclass37_0, class2.int_0) == -1)
					{
						return null;
					}
				}
				int k = 0;
				while (k < @class.int_2)
				{
					int l = 0;
					while (l < class2.int_0)
					{
						array[k] += num5;
						l++;
						k++;
					}
					num5 = array[k - 1];
				}
				array[@class.int_2] = num3;
				return array;
			}
		}
		return null;
	}

	public override int vmethod_8(GClass108 gclass108_0, object object_0, object object_1, float[] float_1)
	{
		Class45 @class = (Class45)object_0;
		Class44 class44_ = @class.class44_0;
		if (object_1 != null)
		{
			float[] array = (float[])object_1;
			float float_2 = array[@class.int_2];
			Class32.smethod_0(float_1, @class.int_3, @class.int_0, @class.int_1, array, @class.int_2, float_2, (float)class44_.int_4);
			return 1;
		}
		for (int i = 0; i < @class.int_0; i++)
		{
			float_1[i] = 0f;
		}
		return 0;
	}

	static float smethod_1(float float_1)
	{
		return (float)Math.Exp((double)float_1 * 0.11512925);
	}

	static int smethod_2(int int_0)
	{
		int num = 0;
		while (int_0 != 0)
		{
			num++;
			int_0 = (int)((uint)int_0 >> 1);
		}
		return num;
	}

	static void smethod_3(float[] float_1, float[] float_2, int int_0)
	{
		int num = int_0 / 2;
		float[] array = new float[num];
		float[] array2 = new float[num];
		float[] array3 = new float[num + 1];
		float[] array4 = new float[num + 1];
		float[] array5 = new float[num];
		float[] array6 = new float[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = (float)(-2.0 * Math.Cos((double)float_1[i * 2]));
			array2[i] = (float)(-2.0 * Math.Cos((double)float_1[i * 2 + 1]));
		}
		int j;
		for (j = 0; j < num; j++)
		{
			array3[j] = 0f;
			array4[j] = 1f;
			array5[j] = 0f;
			array6[j] = 1f;
		}
		array4[j] = 1f;
		array3[j] = 1f;
		for (int i = 1; i < int_0 + 1; i++)
		{
			float num2 = 0f;
			float num3 = 0f;
			float num4 = num2;
			for (j = 0; j < num; j++)
			{
				float num5 = array[j] * array4[j] + array3[j];
				array3[j] = array4[j];
				array4[j] = num4;
				num4 += num5;
				num5 = array2[j] * array6[j] + array5[j];
				array5[j] = array6[j];
				array6[j] = num3;
				num3 += num5;
			}
			float_2[i - 1] = (num4 + array4[j] + num3 - array3[j]) / 2f;
			array4[j] = num4;
			array3[j] = num3;
		}
	}

	static void smethod_4(float[] float_1, float[] float_2, float float_3, Class45 class45_0, string string_0, int int_0)
	{
		float[] array = new float[Math.Max(class45_0.int_1 * 2, class45_0.int_2 * 2 + 2)];
		if (float_3 == 0f)
		{
			for (int i = 0; i < class45_0.int_0; i++)
			{
				float_1[i] = 0f;
			}
			return;
		}
		class45_0.class111_0.method_3(array, float_2, float_3);
		for (int j = 0; j < class45_0.int_0; j++)
		{
			float_1[j] = array[class45_0.int_3[j]];
		}
	}

	float[] float_0;
}
