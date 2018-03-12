using System;

class Class41 : Class40
{
	public override void vmethod_3(object object_1)
	{
	}

	public override void vmethod_4(object object_1)
	{
	}

	public override object vmethod_2(GClass101 gclass101_0, Class6 class6_0, object object_1)
	{
		GClass100 gclass100_ = gclass101_0.gclass100_0;
		Class43 @class = new Class43();
		Class42 class2 = @class.class42_0 = (Class42)object_1;
		@class.class6_0 = class6_0;
		@class.object_0 = new object[class2.int_0];
		@class.object_1 = new object[class2.int_0];
		@class.object_2 = new object[class2.int_0];
		@class.class33_0 = new Class33[class2.int_0];
		@class.class25_0 = new Class25[class2.int_0];
		@class.class2_0 = new Class2[class2.int_0];
		for (int i = 0; i < class2.int_0; i++)
		{
			int num = class2.int_2[i];
			int num2 = class2.int_3[i];
			int num3 = class2.int_4[i];
			@class.class33_0[i] = Class33.class33_0[gclass100_.int_22[num]];
			@class.object_0[i] = @class.class33_0[i].vmethod_2(gclass101_0, class6_0, gclass100_.object_1[num]);
			@class.class25_0[i] = Class25.class25_0[gclass100_.int_23[num2]];
			@class.object_1[i] = @class.class25_0[i].vmethod_2(gclass101_0, class6_0, gclass100_.object_2[num2]);
			@class.class2_0[i] = Class2.class2_0[gclass100_.int_24[num3]];
			@class.object_2[i] = @class.class2_0[i].vmethod_2(gclass101_0, class6_0, gclass100_.object_3[num3]);
		}
		if (gclass100_.int_20 == 0)
		{
		}
		@class.int_0 = gclass100_.int_8;
		return @class;
	}

	public override void vmethod_0(GClass100 gclass100_0, object object_1, GClass37 gclass37_0)
	{
		Class42 @class = (Class42)object_1;
		if (@class.int_0 > 1)
		{
			gclass37_0.method_6(1, 1);
			gclass37_0.method_6(@class.int_0 - 1, 4);
		}
		else
		{
			gclass37_0.method_6(0, 1);
		}
		if (@class.int_6 > 0)
		{
			gclass37_0.method_6(1, 1);
			gclass37_0.method_6(@class.int_6 - 1, 8);
			for (int i = 0; i < @class.int_6; i++)
			{
				gclass37_0.method_6(@class.int_7[i], Class41.smethod_0(gclass100_0.int_8));
				gclass37_0.method_6(@class.int_8[i], Class41.smethod_0(gclass100_0.int_8));
			}
		}
		else
		{
			gclass37_0.method_6(0, 1);
		}
		gclass37_0.method_6(0, 2);
		if (@class.int_0 > 1)
		{
			for (int j = 0; j < gclass100_0.int_8; j++)
			{
				gclass37_0.method_6(@class.int_1[j], 4);
			}
		}
		for (int k = 0; k < @class.int_0; k++)
		{
			gclass37_0.method_6(@class.int_2[k], 8);
			gclass37_0.method_6(@class.int_3[k], 8);
			gclass37_0.method_6(@class.int_4[k], 8);
		}
	}

	public override object vmethod_1(GClass100 gclass100_0, GClass37 gclass37_0)
	{
		Class42 @class = new Class42();
		if (gclass37_0.method_12(1) != 0)
		{
			@class.int_0 = gclass37_0.method_12(4) + 1;
		}
		else
		{
			@class.int_0 = 1;
		}
		if (gclass37_0.method_12(1) != 0)
		{
			@class.int_6 = gclass37_0.method_12(8) + 1;
			for (int i = 0; i < @class.int_6; i++)
			{
				int num = @class.int_7[i] = gclass37_0.method_12(Class41.smethod_0(gclass100_0.int_8));
				int num2 = @class.int_8[i] = gclass37_0.method_12(Class41.smethod_0(gclass100_0.int_8));
				if (num < 0 || num2 < 0 || num == num2 || num >= gclass100_0.int_8 || num2 >= gclass100_0.int_8)
				{
					@class.method_0();
					return null;
				}
			}
		}
		if (gclass37_0.method_12(2) > 0)
		{
			@class.method_0();
			return null;
		}
		if (@class.int_0 > 1)
		{
			for (int j = 0; j < gclass100_0.int_8; j++)
			{
				@class.int_1[j] = gclass37_0.method_12(4);
				if (@class.int_1[j] >= @class.int_0)
				{
					@class.method_0();
					return null;
				}
			}
		}
		for (int k = 0; k < @class.int_0; k++)
		{
			@class.int_2[k] = gclass37_0.method_12(8);
			if (@class.int_2[k] >= gclass100_0.int_16)
			{
				@class.method_0();
				return null;
			}
			@class.int_3[k] = gclass37_0.method_12(8);
			if (@class.int_3[k] >= gclass100_0.int_17)
			{
				@class.method_0();
				return null;
			}
			@class.int_4[k] = gclass37_0.method_12(8);
			if (@class.int_4[k] >= gclass100_0.int_18)
			{
				@class.method_0();
				return null;
			}
		}
		return @class;
	}

	public override int vmethod_5(GClass108 gclass108_0, object object_1)
	{
		int result;
		lock (this)
		{
			GClass101 gclass101_ = gclass108_0.gclass101_0;
			GClass100 gclass100_ = gclass101_.gclass100_0;
			Class43 @class = (Class43)object_1;
			Class42 class42_ = @class.class42_0;
			Class6 class6_ = @class.class6_0;
			int num = gclass108_0.int_3 = gclass100_.int_13[gclass108_0.int_1];
			float[] array = gclass101_.float_3[gclass108_0.int_1][gclass108_0.int_0][gclass108_0.int_2][class6_.int_1];
			if (this.float_0 == null || this.float_0.Length < gclass100_.int_8)
			{
				this.float_0 = new float[gclass100_.int_8][];
				this.int_1 = new int[gclass100_.int_8];
				this.int_0 = new int[gclass100_.int_8];
				this.object_0 = new object[gclass100_.int_8];
			}
			for (int i = 0; i < gclass100_.int_8; i++)
			{
				float[] array2 = gclass108_0.float_0[i];
				int num2 = class42_.int_1[i];
				this.object_0[i] = @class.class25_0[num2].vmethod_7(gclass108_0, @class.object_1[num2], this.object_0[i]);
				if (this.object_0[i] != null)
				{
					this.int_1[i] = 1;
				}
				else
				{
					this.int_1[i] = 0;
				}
				for (int j = 0; j < num / 2; j++)
				{
					array2[j] = 0f;
				}
			}
			for (int k = 0; k < class42_.int_6; k++)
			{
				if (this.int_1[class42_.int_7[k]] != 0 || this.int_1[class42_.int_8[k]] != 0)
				{
					this.int_1[class42_.int_7[k]] = 1;
					this.int_1[class42_.int_8[k]] = 1;
				}
			}
			for (int l = 0; l < class42_.int_0; l++)
			{
				int num3 = 0;
				for (int m = 0; m < gclass100_.int_8; m++)
				{
					if (class42_.int_1[m] == l)
					{
						if (this.int_1[m] != 0)
						{
							this.int_0[num3] = 1;
						}
						else
						{
							this.int_0[num3] = 0;
						}
						this.float_0[num3++] = gclass108_0.float_0[m];
					}
				}
				@class.class2_0[l].vmethod_6(gclass108_0, @class.object_2[l], this.float_0, this.int_0, num3);
			}
			for (int n = class42_.int_6 - 1; n >= 0; n--)
			{
				float[] array3 = gclass108_0.float_0[class42_.int_7[n]];
				float[] array4 = gclass108_0.float_0[class42_.int_8[n]];
				for (int num4 = 0; num4 < num / 2; num4++)
				{
					float num5 = array3[num4];
					float num6 = array4[num4];
					if (num5 > 0f)
					{
						if (num6 > 0f)
						{
							array3[num4] = num5;
							array4[num4] = num5 - num6;
						}
						else
						{
							array4[num4] = num5;
							array3[num4] = num5 + num6;
						}
					}
					else if (num6 > 0f)
					{
						array3[num4] = num5;
						array4[num4] = num5 + num6;
					}
					else
					{
						array4[num4] = num5;
						array3[num4] = num5 - num6;
					}
				}
			}
			for (int num7 = 0; num7 < gclass100_.int_8; num7++)
			{
				float[] array5 = gclass108_0.float_0[num7];
				int num8 = class42_.int_1[num7];
				@class.class25_0[num8].vmethod_8(gclass108_0, @class.object_1[num8], this.object_0[num7], array5);
			}
			for (int num9 = 0; num9 < gclass100_.int_8; num9++)
			{
				float[] array6 = gclass108_0.float_0[num9];
				((Class106)gclass101_.object_0[gclass108_0.int_1][0]).method_3(array6, array6);
			}
			for (int num10 = 0; num10 < gclass100_.int_8; num10++)
			{
				float[] array7 = gclass108_0.float_0[num10];
				if (this.int_1[num10] != 0)
				{
					for (int num11 = 0; num11 < num; num11++)
					{
						array7[num11] *= array[num11];
					}
				}
				else
				{
					for (int num12 = 0; num12 < num; num12++)
					{
						array7[num12] = 0f;
					}
				}
			}
			result = 0;
		}
		return result;
	}

	static int smethod_0(int int_2)
	{
		int num = 0;
		while (int_2 > 1)
		{
			num++;
			int_2 = (int)((uint)int_2 >> 1);
		}
		return num;
	}

	float[][] float_0;

	int[] int_0;

	int[] int_1;

	object[] object_0;
}
