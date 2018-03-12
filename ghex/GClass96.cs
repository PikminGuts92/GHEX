using System;

public class GClass96
{
	public int method_0()
	{
		this.byte_0 = null;
		return 0;
	}

	public int method_1(int int_6)
	{
		if (this.int_2 != 0)
		{
			this.int_1 -= this.int_2;
			if (this.int_1 > 0)
			{
				Array.Copy(this.byte_0, this.int_2, this.byte_0, 0, this.int_1);
			}
			this.int_2 = 0;
		}
		if (int_6 > this.int_0 - this.int_1)
		{
			int num = int_6 + this.int_1 + 4096;
			if (this.byte_0 != null)
			{
				byte[] destinationArray = new byte[num];
				Array.Copy(this.byte_0, 0, destinationArray, 0, this.byte_0.Length);
				this.byte_0 = destinationArray;
			}
			else
			{
				this.byte_0 = new byte[num];
			}
			this.int_0 = num;
		}
		return this.int_1;
	}

	public int method_2(int int_6)
	{
		if (this.int_1 + int_6 > this.int_0)
		{
			return -1;
		}
		this.int_1 += int_6;
		return 0;
	}

	public int method_3(GClass74 gclass74_1)
	{
		int num = this.int_2;
		int num2 = this.int_1 - this.int_2;
		int num4;
		if (this.int_4 == 0)
		{
			if (num2 < 27)
			{
				return 0;
			}
			if (this.byte_0[num] == 79 && this.byte_0[num + 1] == 103 && this.byte_0[num + 2] == 103)
			{
				if (this.byte_0[num + 3] == 83)
				{
					int num3 = (int)((this.byte_0[num + 26] & byte.MaxValue) + 27);
					if (num2 < num3)
					{
						return 0;
					}
					for (int i = 0; i < (int)(this.byte_0[num + 26] & 255); i++)
					{
						this.int_5 += (int)(this.byte_0[num + 27 + i] & byte.MaxValue);
					}
					this.int_4 = num3;
					goto IL_11E;
				}
			}
			this.int_4 = 0;
			this.int_5 = 0;
			num4 = 0;
			for (int j = 0; j < num2 - 1; j++)
			{
				if (this.byte_0[num + 1 + j] == 79)
				{
					num4 = num + 1 + j;
					IL_108:
					if (num4 == 0)
					{
						num4 = this.int_1;
					}
					this.int_2 = num4;
					return -(num4 - num);
				}
			}
			goto IL_108;
		}
		IL_11E:
		if (this.int_5 + this.int_4 > num2)
		{
			return 0;
		}
		byte b = this.byte_0[num + 22];
		byte b2 = this.byte_0[num + 23];
		byte b3 = this.byte_0[num + 24];
		byte b4 = this.byte_0[num + 25];
		this.byte_0[num + 22] = 0;
		this.byte_0[num + 23] = 0;
		this.byte_0[num + 24] = 0;
		this.byte_0[num + 25] = 0;
		GClass74 gclass = this.gclass74_0;
		gclass.byte_0 = this.byte_0;
		gclass.int_0 = num;
		gclass.int_1 = this.int_4;
		gclass.byte_1 = this.byte_0;
		gclass.int_2 = num + this.int_4;
		gclass.int_3 = this.int_5;
		gclass.method_7();
		if (b == this.byte_0[num + 22] && b2 == this.byte_0[num + 23] && b3 == this.byte_0[num + 24])
		{
			if (b4 == this.byte_0[num + 25])
			{
				num = this.int_2;
				if (gclass74_1 != null)
				{
					gclass74_1.byte_0 = this.byte_0;
					gclass74_1.int_0 = num;
					gclass74_1.int_1 = this.int_4;
					gclass74_1.byte_1 = this.byte_0;
					gclass74_1.int_2 = num + this.int_4;
					gclass74_1.int_3 = this.int_5;
				}
				this.int_3 = 0;
				this.int_2 += (num2 = this.int_4 + this.int_5);
				this.int_4 = 0;
				this.int_5 = 0;
				return num2;
			}
		}
		this.byte_0[num + 22] = b;
		this.byte_0[num + 23] = b2;
		this.byte_0[num + 24] = b3;
		this.byte_0[num + 25] = b4;
		this.int_4 = 0;
		this.int_5 = 0;
		num4 = 0;
		for (int k = 0; k < num2 - 1; k++)
		{
			if (this.byte_0[num + 1 + k] == 79)
			{
				num4 = num + 1 + k;
				IL_32C:
				if (num4 == 0)
				{
					num4 = this.int_1;
				}
				this.int_2 = num4;
				return -(num4 - num);
			}
		}
		goto IL_32C;
	}

	public int method_4(GClass74 gclass74_1)
	{
		do
		{
			int num = this.method_3(gclass74_1);
			if (num > 0)
			{
				return 1;
			}
			if (num == 0)
			{
				return 0;
			}
		}
		while (this.int_3 != 0);
		this.int_3 = 1;
		return -1;
	}

	public int method_5()
	{
		this.int_1 = 0;
		this.int_2 = 0;
		this.int_3 = 0;
		this.int_4 = 0;
		this.int_5 = 0;
		return 0;
	}

	public void method_6()
	{
	}

	public byte[] byte_0;

	public int int_0;

	public int int_1;

	int int_2;

	int int_3;

	int int_4;

	int int_5;

	GClass74 gclass74_0 = new GClass74();
}
