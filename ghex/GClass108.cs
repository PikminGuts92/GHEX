using System;

public class GClass108
{
	public GClass108(GClass101 gclass101_1)
	{
		this.gclass101_0 = gclass101_1;
		if (gclass101_1.int_2 != 0)
		{
			this.gclass37_0.method_0();
		}
	}

	public void method_0(GClass101 gclass101_1)
	{
		this.gclass101_0 = gclass101_1;
	}

	public int method_1()
	{
		if (this.gclass101_0 != null && this.gclass101_0.int_2 != 0)
		{
			this.gclass37_0.method_4();
		}
		return 0;
	}

	public int method_2(GClass91 gclass91_0)
	{
		GClass100 gclass100_ = this.gclass101_0.gclass100_0;
		this.gclass37_0.method_5(gclass91_0.byte_0, gclass91_0.int_0, gclass91_0.int_1);
		if (this.gclass37_0.method_12(1) != 0)
		{
			return -1;
		}
		int num = this.gclass37_0.method_12(this.gclass101_0.int_3);
		if (num == -1)
		{
			return -1;
		}
		this.int_4 = num;
		this.int_1 = gclass100_.class6_0[this.int_4].int_0;
		if (this.int_1 != 0)
		{
			this.int_0 = this.gclass37_0.method_12(1);
			this.int_2 = this.gclass37_0.method_12(1);
			if (this.int_2 == -1)
			{
				return -1;
			}
		}
		else
		{
			this.int_0 = 0;
			this.int_2 = 0;
		}
		this.long_0 = gclass91_0.long_0;
		this.long_1 = gclass91_0.long_1 - 3L;
		this.int_5 = gclass91_0.int_3;
		this.int_3 = gclass100_.int_13[this.int_1];
		if (this.float_0.Length < gclass100_.int_8)
		{
			this.float_0 = new float[gclass100_.int_8][];
		}
		for (int i = 0; i < gclass100_.int_8; i++)
		{
			if (this.float_0[i] != null && this.float_0[i].Length >= this.int_3)
			{
				for (int j = 0; j < this.int_3; j++)
				{
					this.float_0[i][j] = 0f;
				}
			}
			else
			{
				this.float_0[i] = new float[this.int_3];
			}
		}
		int num2 = gclass100_.int_21[gclass100_.class6_0[this.int_4].int_3];
		return Class40.class40_0[num2].vmethod_5(this, this.gclass101_0.object_1[this.int_4]);
	}

	internal float[][] float_0 = new float[0][];

	internal GClass37 gclass37_0 = new GClass37();

	internal int int_0;

	internal int int_1;

	internal int int_2;

	internal int int_3;

	internal int int_4;

	internal int int_5;

	public long long_0;

	internal long long_1;

	internal GClass101 gclass101_0;

	internal int int_6;

	internal int int_7;

	internal int int_8;

	internal int int_9;
}
