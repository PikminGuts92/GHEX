using System;

public class GClass74
{
	static uint smethod_0(uint uint_1)
	{
		uint num = uint_1 << 24;
		for (int i = 0; i < 8; i++)
		{
			if ((num & 2147483648u) != 0u)
			{
				num = (num << 1 ^ 79764919u);
			}
			else
			{
				num <<= 1;
			}
		}
		return num & uint.MaxValue;
	}

	internal int method_0()
	{
		return (int)(this.byte_0[this.int_0 + 4] & byte.MaxValue);
	}

	internal int method_1()
	{
		return (int)(this.byte_0[this.int_0 + 5] & 1);
	}

	public int method_2()
	{
		return (int)(this.byte_0[this.int_0 + 5] & 2);
	}

	public int method_3()
	{
		return (int)(this.byte_0[this.int_0 + 5] & 4);
	}

	public long method_4()
	{
		long num = (long)(this.byte_0[this.int_0 + 13] & byte.MaxValue);
		num = (num << 8 | (long)((ulong)(this.byte_0[this.int_0 + 12] & byte.MaxValue)));
		num = (num << 8 | (long)((ulong)(this.byte_0[this.int_0 + 11] & byte.MaxValue)));
		num = (num << 8 | (long)((ulong)(this.byte_0[this.int_0 + 10] & byte.MaxValue)));
		num = (num << 8 | (long)((ulong)(this.byte_0[this.int_0 + 9] & byte.MaxValue)));
		num = (num << 8 | (long)((ulong)(this.byte_0[this.int_0 + 8] & byte.MaxValue)));
		num = (num << 8 | (long)((ulong)(this.byte_0[this.int_0 + 7] & byte.MaxValue)));
		return num << 8 | (long)((ulong)(this.byte_0[this.int_0 + 6] & byte.MaxValue));
	}

	public int method_5()
	{
		return (int)(this.byte_0[this.int_0 + 14] & byte.MaxValue) | (int)(this.byte_0[this.int_0 + 15] & byte.MaxValue) << 8 | (int)(this.byte_0[this.int_0 + 16] & byte.MaxValue) << 16 | (int)(this.byte_0[this.int_0 + 17] & byte.MaxValue) << 24;
	}

	internal int method_6()
	{
		return (int)(this.byte_0[this.int_0 + 18] & byte.MaxValue) | (int)(this.byte_0[this.int_0 + 19] & byte.MaxValue) << 8 | (int)(this.byte_0[this.int_0 + 20] & byte.MaxValue) << 16 | (int)(this.byte_0[this.int_0 + 21] & byte.MaxValue) << 24;
	}

	internal void method_7()
	{
		uint num = 0u;
		for (int i = 0; i < this.int_1; i++)
		{
			uint num2 = (uint)(this.byte_0[this.int_0 + i] & byte.MaxValue);
			uint num3 = num >> 24 & 255u;
			num = (num << 8 ^ GClass74.uint_0[(int)((UIntPtr)(num2 ^ num3))]);
		}
		for (int j = 0; j < this.int_3; j++)
		{
			uint num2 = (uint)(this.byte_1[this.int_2 + j] & byte.MaxValue);
			uint num3 = num >> 24 & 255u;
			num = (num << 8 ^ GClass74.uint_0[(int)((UIntPtr)(num2 ^ num3))]);
		}
		this.byte_0[this.int_0 + 22] = (byte)num;
		this.byte_0[this.int_0 + 23] = (byte)(num >> 8);
		this.byte_0[this.int_0 + 24] = (byte)(num >> 16);
		this.byte_0[this.int_0 + 25] = (byte)(num >> 24);
	}

	public GClass74()
	{
		uint num = 0u;
		while ((ulong)num < (ulong)((long)GClass74.uint_0.Length))
		{
			GClass74.uint_0[(int)((UIntPtr)num)] = GClass74.smethod_0(num);
			num += 1u;
		}
	}

	static uint[] uint_0 = new uint[256];

	public byte[] byte_0;

	public int int_0;

	public int int_1;

	public byte[] byte_1;

	public int int_2;

	public int int_3;
}
