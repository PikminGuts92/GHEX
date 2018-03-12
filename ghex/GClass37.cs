using System;

public class GClass37
{
	public void method_0()
	{
		this.byte_0 = new byte[GClass37.int_0];
		this.int_1 = 0;
		this.byte_0[0] = 0;
		this.int_4 = GClass37.int_0;
	}

	public void method_1(byte[] byte_1)
	{
		for (int i = 0; i < byte_1.Length; i++)
		{
			if (byte_1[i] == 0)
			{
				return;
			}
			this.method_6((int)byte_1[i], 8);
		}
	}

	public void method_2(byte[] byte_1, int int_5)
	{
		int num = 0;
		while (int_5-- != 0)
		{
			byte_1[num++] = (byte)this.method_12(8);
		}
	}

	public void method_3()
	{
		this.int_1 = 0;
		this.byte_0[0] = 0;
		this.int_3 = 0;
		this.int_2 = 0;
	}

	public void method_4()
	{
		this.byte_0 = null;
	}

	public void method_5(byte[] byte_1, int int_5, int int_6)
	{
		this.int_1 = int_5;
		this.byte_0 = byte_1;
		this.int_3 = 0;
		this.int_2 = 0;
		this.int_4 = int_6;
	}

	public void method_6(int int_5, int int_6)
	{
		if (this.int_3 + 4 >= this.int_4)
		{
			byte[] destinationArray = new byte[this.int_4 + GClass37.int_0];
			Array.Copy(this.byte_0, 0, destinationArray, 0, this.int_4);
			this.byte_0 = destinationArray;
			this.int_4 += GClass37.int_0;
		}
		int_5 &= (int)GClass37.uint_0[int_6];
		int_6 += this.int_2;
		byte[] array = this.byte_0;
		int num = this.int_1;
		array[num] |= (byte)(int_5 << this.int_2);
		if (int_6 >= 8)
		{
			this.byte_0[this.int_1 + 1] = (byte)((uint)int_5 >> 8 - this.int_2);
			if (int_6 >= 16)
			{
				this.byte_0[this.int_1 + 2] = (byte)((uint)int_5 >> 16 - this.int_2);
				if (int_6 >= 24)
				{
					this.byte_0[this.int_1 + 3] = (byte)((uint)int_5 >> 24 - this.int_2);
					if (int_6 >= 32)
					{
						if (this.int_2 > 0)
						{
							this.byte_0[this.int_1 + 4] = (byte)((uint)int_5 >> 32 - this.int_2);
						}
						else
						{
							this.byte_0[this.int_1 + 4] = 0;
						}
					}
				}
			}
		}
		this.int_3 += int_6 / 8;
		this.int_1 += int_6 / 8;
		this.int_2 = (int_6 & 7);
	}

	public int method_7(int int_5)
	{
		uint num = GClass37.uint_0[int_5];
		int_5 += this.int_2;
		if (this.int_3 + 4 >= this.int_4 && this.int_3 + (int_5 - 1) / 8 >= this.int_4)
		{
			return -1;
		}
		int num2 = (this.byte_0[this.int_1] & byte.MaxValue) >> this.int_2;
		if (int_5 > 8)
		{
			num2 |= (int)(this.byte_0[this.int_1 + 1] & byte.MaxValue) << 8 - this.int_2;
			if (int_5 > 16)
			{
				num2 |= (int)(this.byte_0[this.int_1 + 2] & byte.MaxValue) << 16 - this.int_2;
				if (int_5 > 24)
				{
					num2 |= (int)(this.byte_0[this.int_1 + 3] & byte.MaxValue) << 24 - this.int_2;
					if (int_5 > 32 && this.int_2 != 0)
					{
						num2 |= (int)(this.byte_0[this.int_1 + 4] & byte.MaxValue) << 32 - this.int_2;
					}
				}
			}
		}
		return (int)((ulong)num & (ulong)((long)num2));
	}

	public int method_8()
	{
		if (this.int_3 >= this.int_4)
		{
			return -1;
		}
		return this.byte_0[this.int_1] >> this.int_2 & 1;
	}

	public void method_9(int int_5)
	{
		int_5 += this.int_2;
		this.int_1 += int_5 / 8;
		this.int_3 += int_5 / 8;
		this.int_2 = (int_5 & 7);
	}

	public void method_10()
	{
		this.int_2++;
		if (this.int_2 > 7)
		{
			this.int_2 = 0;
			this.int_1++;
			this.int_3++;
		}
	}

	public int method_11(int int_5)
	{
		int num = 32 - int_5;
		int_5 += this.int_2;
		if (this.int_3 + 4 >= this.int_4 && this.int_3 + (int_5 - 1) / 8 >= this.int_4)
		{
			this.int_1 += int_5 / 8;
			this.int_3 += int_5 / 8;
			this.int_2 = (int_5 & 7);
			return -1;
		}
		int num2 = (int)(this.byte_0[this.int_1] & byte.MaxValue) << 24 + this.int_2;
		if (int_5 > 8)
		{
			num2 |= (int)(this.byte_0[this.int_1 + 1] & byte.MaxValue) << 16 + this.int_2;
			if (int_5 > 16)
			{
				num2 |= (int)(this.byte_0[this.int_1 + 2] & byte.MaxValue) << 8 + this.int_2;
				if (int_5 > 24)
				{
					num2 |= (int)(this.byte_0[this.int_1 + 3] & byte.MaxValue) << this.int_2;
					if (int_5 > 32 && this.int_2 != 0)
					{
						num2 |= (this.byte_0[this.int_1 + 4] & byte.MaxValue) >> 8 - this.int_2;
					}
				}
			}
		}
		num2 = (int)((uint)num2 >> (num >> 1) >> (num + 1 >> 1));
		this.int_1 += int_5 / 8;
		this.int_3 += int_5 / 8;
		this.int_2 = (int_5 & 7);
		return num2;
	}

	public int method_12(int int_5)
	{
		uint num = GClass37.uint_0[int_5];
		int_5 += this.int_2;
		int num2;
		if (this.int_3 + 4 >= this.int_4)
		{
			num2 = -1;
			if (this.int_3 + (int_5 - 1) / 8 >= this.int_4)
			{
				this.int_1 += int_5 / 8;
				this.int_3 += int_5 / 8;
				this.int_2 = (int_5 & 7);
				return num2;
			}
		}
		num2 = (this.byte_0[this.int_1] & byte.MaxValue) >> this.int_2;
		if (int_5 > 8)
		{
			num2 |= (int)(this.byte_0[this.int_1 + 1] & byte.MaxValue) << 8 - this.int_2;
			if (int_5 > 16)
			{
				num2 |= (int)(this.byte_0[this.int_1 + 2] & byte.MaxValue) << 16 - this.int_2;
				if (int_5 > 24)
				{
					num2 |= (int)(this.byte_0[this.int_1 + 3] & byte.MaxValue) << 24 - this.int_2;
					if (int_5 > 32 && this.int_2 != 0)
					{
						num2 |= (int)(this.byte_0[this.int_1 + 4] & byte.MaxValue) << 32 - this.int_2;
					}
				}
			}
		}
		num2 &= (int)num;
		this.int_1 += int_5 / 8;
		this.int_3 += int_5 / 8;
		this.int_2 = (int_5 & 7);
		return num2;
	}

	public int method_13()
	{
		int result;
		if (this.int_3 >= this.int_4)
		{
			result = -1;
			this.int_2++;
			if (this.int_2 > 7)
			{
				this.int_2 = 0;
				this.int_1++;
				this.int_3++;
			}
			return result;
		}
		result = (this.byte_0[this.int_1] >> this.int_2 & 1);
		this.int_2++;
		if (this.int_2 > 7)
		{
			this.int_2 = 0;
			this.int_1++;
			this.int_3++;
		}
		return result;
	}

	public int method_14()
	{
		return this.int_3 + (this.int_2 + 7) / 8;
	}

	public int method_15()
	{
		return this.int_3 * 8 + this.int_2;
	}

	public static int smethod_0(int int_5)
	{
		int num = 0;
		while (int_5 > 0)
		{
			num++;
			int_5 >>= 1;
		}
		return num;
	}

	public byte[] method_16()
	{
		return this.byte_0;
	}

	static int int_0 = 256;

	static uint[] uint_0 = new uint[]
	{
		0u,
		1u,
		3u,
		7u,
		15u,
		31u,
		63u,
		127u,
		255u,
		511u,
		1023u,
		2047u,
		4095u,
		8191u,
		16383u,
		32767u,
		65535u,
		131071u,
		262143u,
		524287u,
		1048575u,
		2097151u,
		4194303u,
		8388607u,
		16777215u,
		33554431u,
		67108863u,
		134217727u,
		268435455u,
		536870911u,
		1073741823u,
		2147483647u,
		uint.MaxValue
	};

	int int_1;

	byte[] byte_0;

	int int_2;

	int int_3;

	int int_4;
}
