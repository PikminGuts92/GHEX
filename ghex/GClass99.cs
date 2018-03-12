using System;
using System.Text;

public class GClass99
{
	GClass99(int int_13) : this()
	{
		this.method_1(int_13);
	}

	public GClass99()
	{
		this.method_0();
	}

	void method_0()
	{
		this.int_0 = 16384;
		this.byte_0 = new byte[this.int_0];
		this.int_4 = 1024;
		this.int_3 = new int[this.int_4];
		this.long_0 = new long[this.int_4];
	}

	public void method_1(int int_13)
	{
		if (this.byte_0 == null)
		{
			this.method_0();
		}
		else
		{
			for (int i = 0; i < this.byte_0.Length; i++)
			{
				this.byte_0[i] = 0;
			}
			for (int j = 0; j < this.int_3.Length; j++)
			{
				this.int_3[j] = 0;
			}
			for (int k = 0; k < this.long_0.Length; k++)
			{
				this.long_0[k] = 0L;
			}
		}
		this.int_11 = int_13;
	}

	public void method_2()
	{
		this.byte_0 = null;
		this.int_3 = null;
		this.long_0 = null;
	}

	void method_3()
	{
		this.method_2();
	}

	void method_4(int int_13)
	{
		if (this.int_0 <= this.int_1 + int_13)
		{
			this.int_0 += int_13 + 1024;
			byte[] destinationArray = new byte[this.int_0];
			Array.Copy(this.byte_0, 0, destinationArray, 0, this.byte_0.Length);
			this.byte_0 = destinationArray;
		}
	}

	void method_5(int int_13)
	{
		if (this.int_4 <= this.int_5 + int_13)
		{
			this.int_4 += int_13 + 32;
			int[] destinationArray = new int[this.int_4];
			Array.Copy(this.int_3, 0, destinationArray, 0, this.int_3.Length);
			this.int_3 = destinationArray;
			long[] destinationArray2 = new long[this.int_4];
			Array.Copy(this.long_0, 0, destinationArray2, 0, this.long_0.Length);
			this.long_0 = destinationArray2;
		}
	}

	public int method_6(GClass91 gclass91_0)
	{
		int num = gclass91_0.int_1 / 255 + 1;
		if (this.int_2 != 0)
		{
			this.int_1 -= this.int_2;
			if (this.int_1 != 0)
			{
				Array.Copy(this.byte_0, this.int_2, this.byte_0, 0, this.int_1);
			}
			this.int_2 = 0;
		}
		this.method_4(gclass91_0.int_1);
		this.method_5(num);
		Array.Copy(gclass91_0.byte_0, gclass91_0.int_0, this.byte_0, this.int_1, gclass91_0.int_1);
		this.int_1 += gclass91_0.int_1;
		int i;
		for (i = 0; i < num - 1; i++)
		{
			this.int_3[this.int_5 + i] = 255;
			this.long_0[this.int_5 + i] = this.long_2;
		}
		this.int_3[this.int_5 + i] = gclass91_0.int_1 % 255;
		this.long_2 = (this.long_0[this.int_5 + i] = gclass91_0.long_0);
		this.int_3[this.int_5] |= 256;
		this.int_5 += num;
		this.long_1 += 1L;
		if (gclass91_0.int_3 != 0)
		{
			this.int_9 = 1;
		}
		return 0;
	}

	public int method_7(GClass91 gclass91_0)
	{
		int num = this.int_7;
		if (this.int_6 <= num)
		{
			return 0;
		}
		if ((this.int_3[num] & 1024) != 0)
		{
			this.int_7++;
			this.long_1 += 1L;
			return -1;
		}
		int num2 = this.int_3[num] & 255;
		gclass91_0.byte_0 = this.byte_0;
		gclass91_0.int_0 = this.int_2;
		gclass91_0.int_3 = (this.int_3[num] & 512);
		gclass91_0.int_2 = (this.int_3[num] & 256);
		int num3 = 0 + num2;
		while (num2 == 255)
		{
			int num4 = this.int_3[++num];
			num2 = (num4 & 255);
			if ((num4 & 512) != 0)
			{
				gclass91_0.int_3 = 512;
			}
			num3 += num2;
		}
		gclass91_0.long_1 = this.long_1;
		gclass91_0.long_0 = this.long_0[num];
		gclass91_0.int_1 = num3;
		this.int_2 += num3;
		this.int_7 = num + 1;
		this.long_1 += 1L;
		return 1;
	}

	public int method_8(GClass74 gclass74_0)
	{
		byte[] array = gclass74_0.byte_0;
		int num = gclass74_0.int_0;
		byte[] sourceArray = gclass74_0.byte_1;
		int num2 = gclass74_0.int_2;
		int num3 = gclass74_0.int_3;
		int i = 0;
		int num4 = gclass74_0.method_0();
		int num5 = gclass74_0.method_1();
		int num6 = gclass74_0.method_2();
		int num7 = gclass74_0.method_3();
		long num8 = gclass74_0.method_4();
		int num9 = gclass74_0.method_5();
		int num10 = gclass74_0.method_6();
		int num11 = (int)(array[num + 26] & byte.MaxValue);
		int num12 = this.int_7;
		int num13 = this.int_2;
		if (num13 != 0)
		{
			this.int_1 -= num13;
			if (this.int_1 != 0)
			{
				Array.Copy(this.byte_0, num13, this.byte_0, 0, this.int_1);
			}
			this.int_2 = 0;
		}
		if (num12 != 0)
		{
			if (this.int_5 - num12 != 0)
			{
				Array.Copy(this.int_3, num12, this.int_3, 0, this.int_5 - num12);
				Array.Copy(this.long_0, num12, this.long_0, 0, this.int_5 - num12);
			}
			this.int_5 -= num12;
			this.int_6 -= num12;
			this.int_7 = 0;
		}
		if (num9 != this.int_11)
		{
			return -1;
		}
		if (num4 > 0)
		{
			return -1;
		}
		this.method_5(num11 + 1);
		if (num10 != this.int_12)
		{
			for (int j = this.int_6; j < this.int_5; j++)
			{
				this.int_1 -= (this.int_3[j] & 255);
			}
			this.int_5 = this.int_6;
			if (this.int_12 != -1)
			{
				this.int_3[this.int_5++] = 1024;
				this.int_6++;
			}
			if (num5 != 0)
			{
				num6 = 0;
				while (i < num11)
				{
					int num14 = (int)(array[num + 27 + i] & byte.MaxValue);
					num2 += num14;
					num3 -= num14;
					if (num14 < 255)
					{
						i++;
						break;
					}
					i++;
				}
			}
		}
		if (num3 != 0)
		{
			this.method_4(num3);
			Array.Copy(sourceArray, num2, this.byte_0, this.int_1, num3);
			this.int_1 += num3;
		}
		int num15 = -1;
		while (i < num11)
		{
			int num16 = (int)(array[num + 27 + i] & byte.MaxValue);
			this.int_3[this.int_5] = num16;
			this.long_0[this.int_5] = -1L;
			if (num6 != 0)
			{
				this.int_3[this.int_5] |= 256;
				num6 = 0;
			}
			if (num16 < 255)
			{
				num15 = this.int_5;
			}
			this.int_5++;
			i++;
			if (num16 < 255)
			{
				this.int_6 = this.int_5;
			}
		}
		if (num15 != -1)
		{
			this.long_0[num15] = num8;
		}
		if (num7 != 0)
		{
			this.int_9 = 1;
			if (this.int_5 > 0)
			{
				this.int_3[this.int_5 - 1] |= 512;
			}
		}
		this.int_12 = num10 + 1;
		return 0;
	}

	public int method_9(GClass74 gclass74_0)
	{
		int num = (this.int_5 > 255) ? 255 : this.int_5;
		int num2 = 0;
		int num3 = 0;
		long num4 = this.long_0[0];
		if (num == 0)
		{
			return 0;
		}
		int i;
		if (this.int_10 == 0)
		{
			num4 = 0L;
			for (i = 0; i < num; i++)
			{
				if ((this.int_3[i] & 255) < 255)
				{
					i++;
					break;
				}
			}
		}
		else
		{
			i = 0;
			while (i < num && num3 <= 4096)
			{
				num3 += (this.int_3[i] & 255);
				num4 = this.long_0[i];
				i++;
			}
		}
		string s = "OggS";
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		byte[] bytes = asciiencoding.GetBytes(s);
		Array.Copy(bytes, 0, this.byte_1, 0, bytes.Length);
		this.byte_1[4] = 0;
		this.byte_1[5] = 0;
		if ((this.int_3[0] & 256) == 0)
		{
			byte[] array = this.byte_1;
			int num5 = 5;
			array[num5] |= 1;
		}
		if (this.int_10 == 0)
		{
			byte[] array2 = this.byte_1;
			int num6 = 5;
			array2[num6] |= 2;
		}
		if (this.int_9 != 0 && this.int_5 == i)
		{
			byte[] array3 = this.byte_1;
			int num7 = 5;
			array3[num7] |= 4;
		}
		this.int_10 = 1;
		for (int j = 6; j < 14; j++)
		{
			this.byte_1[j] = (byte)num4;
			num4 >>= 8;
		}
		int num8 = this.int_11;
		for (int j = 14; j < 18; j++)
		{
			this.byte_1[j] = (byte)num8;
			num8 >>= 8;
		}
		if (this.int_12 == -1)
		{
			this.int_12 = 0;
		}
		int num9 = this.int_12++;
		for (int j = 18; j < 22; j++)
		{
			this.byte_1[j] = (byte)num9;
			num9 >>= 8;
		}
		this.byte_1[22] = 0;
		this.byte_1[23] = 0;
		this.byte_1[24] = 0;
		this.byte_1[25] = 0;
		this.byte_1[26] = (byte)i;
		for (int j = 0; j < i; j++)
		{
			this.byte_1[j + 27] = (byte)this.int_3[j];
			num2 += (int)(this.byte_1[j + 27] & byte.MaxValue);
		}
		gclass74_0.byte_0 = this.byte_1;
		gclass74_0.int_0 = 0;
		gclass74_0.int_1 = (this.int_8 = i + 27);
		gclass74_0.byte_1 = this.byte_0;
		gclass74_0.int_2 = this.int_2;
		gclass74_0.int_3 = num2;
		this.int_5 -= i;
		Array.Copy(this.int_3, i, this.int_3, 0, this.int_5 * 4);
		Array.Copy(this.long_0, i, this.long_0, 0, this.int_5 * 8);
		this.int_2 += num2;
		gclass74_0.method_7();
		return 1;
	}

	public int method_10(GClass74 gclass74_0)
	{
		if ((this.int_9 == 0 || this.int_5 == 0) && this.int_1 - this.int_2 <= 4096 && this.int_5 < 255 && (this.int_5 == 0 || this.int_10 != 0))
		{
			return 0;
		}
		return this.method_9(gclass74_0);
	}

	public int method_11()
	{
		return this.int_9;
	}

	public int method_12()
	{
		this.int_1 = 0;
		this.int_2 = 0;
		this.int_5 = 0;
		this.int_6 = 0;
		this.int_7 = 0;
		this.int_8 = 0;
		this.int_9 = 0;
		this.int_10 = 0;
		this.int_12 = -1;
		this.long_1 = 0L;
		this.long_2 = 0L;
		return 0;
	}

	byte[] byte_0;

	int int_0;

	public int int_1;

	int int_2;

	int[] int_3;

	long[] long_0;

	int int_4;

	int int_5;

	int int_6;

	int int_7;

	byte[] byte_1 = new byte[282];

	int int_8;

	public int int_9;

	int int_10;

	int int_11;

	int int_12;

	long long_1;

	public long long_2;
}
