using System;
using System.IO;

public class GClass107
{
	GClass107()
	{
		this.gclass99_0 = new GClass99();
		this.gclass101_0 = new GClass101();
		this.gclass108_0 = new GClass108(this.gclass101_0);
	}

	public GClass107(string string_0) : this()
	{
		FileStream fileStream_ = null;
		try
		{
			fileStream_ = new FileStream(string_0, FileMode.Open, FileAccess.Read);
		}
		catch (Exception ex)
		{
			throw new GException1("VorbisFile: " + ex.Message);
		}
		int num = this.method_13(fileStream_, null, 0);
		if (num == -1)
		{
			throw new GException1("VorbisFile: open return -1");
		}
	}

	public GClass107(FileStream fileStream_1, byte[] byte_0, int int_22) : this()
	{
		this.method_13(fileStream_1, byte_0, int_22);
	}

	int method_0()
	{
		int offset = this.gclass96_0.method_1(GClass107.int_0);
		byte[] byte_ = this.gclass96_0.byte_0;
		int num = 0;
		int result;
		try
		{
			num = this.fileStream_0.Read(byte_, offset, GClass107.int_0);
			goto IL_51;
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine(ex.Message);
			result = GClass107.int_7;
		}
		return result;
		IL_51:
		this.gclass96_0.method_2(num);
		if (num == -1)
		{
			num = 0;
		}
		return num;
	}

	void method_1(long long_6)
	{
		GClass107.smethod_0(this.fileStream_0, long_6, GClass107.int_1);
		this.long_0 = long_6;
		this.gclass96_0.method_5();
	}

	int method_2(GClass74 gclass74_0, long long_6)
	{
		if (long_6 > 0L)
		{
			long_6 += this.long_0;
		}
		while (long_6 <= 0L || this.long_0 < long_6)
		{
			int num = this.gclass96_0.method_3(gclass74_0);
			if (num < 0)
			{
				this.long_0 -= (long)num;
			}
			else
			{
				if (num != 0)
				{
					int result = (int)this.long_0;
					this.long_0 += (long)num;
					return result;
				}
				if (long_6 == 0L)
				{
					return GClass107.int_4;
				}
				int num2 = this.method_0();
				if (num2 == 0)
				{
					return GClass107.int_5;
				}
				if (num2 < 0)
				{
					return GClass107.int_7;
				}
			}
		}
		return GClass107.int_4;
	}

	int method_3(GClass74 gclass74_0)
	{
		long num = this.long_0;
		int num2 = -1;
		int num3;
		while (num2 == -1)
		{
			num -= (long)GClass107.int_0;
			if (num < 0L)
			{
				num = 0L;
			}
			this.method_1(num);
			while (this.long_0 < num + (long)GClass107.int_0)
			{
				num3 = this.method_2(gclass74_0, num + (long)GClass107.int_0 - this.long_0);
				if (num3 == GClass107.int_7)
				{
					return GClass107.int_7;
				}
				if (num3 < 0)
				{
					break;
				}
				num2 = num3;
			}
		}
		this.method_1((long)num2);
		num3 = this.method_2(gclass74_0, (long)GClass107.int_0);
		if (num3 < 0)
		{
			return GClass107.int_8;
		}
		return num2;
	}

	int method_4(long long_6, long long_7, long long_8, int int_22, int int_23)
	{
		long num = long_8;
		long long_9 = long_8;
		GClass74 gclass = new GClass74();
		int num3;
		while (long_7 < num)
		{
			long num2;
			if (num - long_7 < (long)GClass107.int_0)
			{
				num2 = long_7;
			}
			else
			{
				num2 = (long_7 + num) / 2L;
			}
			this.method_1(num2);
			num3 = this.method_2(gclass, -1L);
			if (num3 == GClass107.int_7)
			{
				return GClass107.int_7;
			}
			if (num3 >= 0)
			{
				if (gclass.method_5() == int_22)
				{
					long_7 = (long)(num3 + gclass.int_1 + gclass.int_3);
					continue;
				}
			}
			num = num2;
			if (num3 >= 0)
			{
				long_9 = (long)num3;
			}
		}
		this.method_1(long_9);
		num3 = this.method_2(gclass, -1L);
		if (num3 == GClass107.int_7)
		{
			return GClass107.int_7;
		}
		if (long_7 < long_8)
		{
			if (num3 != -1)
			{
				num3 = this.method_4(long_9, this.long_0, long_8, gclass.method_5(), int_23 + 1);
				if (num3 == GClass107.int_7)
				{
					return GClass107.int_7;
				}
				goto IL_FF;
			}
		}
		this.int_18 = int_23 + 1;
		this.long_2 = new long[int_23 + 2];
		this.long_2[int_23 + 1] = long_7;
		IL_FF:
		this.long_2[int_23] = long_6;
		return 0;
	}

	int method_5(GClass100 gclass100_1, GClass119 gclass119_1, int[] int_22, GClass74 gclass74_0)
	{
		GClass74 gclass = new GClass74();
		GClass91 gclass91_ = new GClass91();
		if (gclass74_0 == null)
		{
			int num = this.method_2(gclass, (long)GClass107.int_0);
			if (num == GClass107.int_7)
			{
				return GClass107.int_7;
			}
			if (num < 0)
			{
				return GClass107.int_11;
			}
			gclass74_0 = gclass;
		}
		if (int_22 != null)
		{
			int_22[0] = gclass74_0.method_5();
		}
		this.gclass99_0.method_1(gclass74_0.method_5());
		gclass100_1.method_0();
		gclass119_1.method_0();
		int i = 0;
		while (i < 3)
		{
			this.gclass99_0.method_8(gclass74_0);
			while (i < 3)
			{
				int num2 = this.gclass99_0.method_7(gclass91_);
				if (num2 == 0)
				{
					break;
				}
				if (num2 == -1)
				{
					Console.Error.WriteLine("Corrupt header in logical bitstream.");
					gclass100_1.method_1();
					gclass119_1.method_10();
					this.gclass99_0.method_2();
					return -1;
				}
				if (gclass100_1.method_4(gclass119_1, gclass91_) != 0)
				{
					Console.Error.WriteLine("Illegal header in logical bitstream.");
					gclass100_1.method_1();
					gclass119_1.method_10();
					this.gclass99_0.method_2();
					return -1;
				}
				i++;
			}
			if (i < 3 && this.method_2(gclass74_0, 1L) < 0)
			{
				Console.Error.WriteLine("Missing header in logical bitstream.");
				gclass100_1.method_1();
				gclass119_1.method_10();
				this.gclass99_0.method_2();
				return -1;
			}
		}
		return 0;
	}

	void method_6(GClass100 gclass100_1, GClass119 gclass119_1, int int_22)
	{
		GClass74 gclass = new GClass74();
		this.gclass100_0 = new GClass100[this.int_18];
		this.gclass119_0 = new GClass119[this.int_18];
		this.long_3 = new long[this.int_18];
		this.long_4 = new long[this.int_18];
		this.int_19 = new int[this.int_18];
		int i = 0;
		while (i < this.int_18)
		{
			if (gclass100_1 != null && gclass119_1 != null && i == 0)
			{
				this.gclass100_0[i] = gclass100_1;
				this.gclass119_0[i] = gclass119_1;
				this.long_3[i] = (long)int_22;
			}
			else
			{
				this.method_1(this.long_2[i]);
				if (this.method_5(this.gclass100_0[i], this.gclass119_0[i], null, null) == -1)
				{
					Console.Error.WriteLine("Error opening logical bitstream #" + (i + 1) + "\n");
					this.long_3[i] = -1L;
				}
				else
				{
					this.long_3[i] = this.long_0;
					this.gclass99_0.method_2();
				}
			}
			long long_ = this.long_2[i + 1];
			this.method_1(long_);
			for (;;)
			{
				int num = this.method_3(gclass);
				if (num == -1)
				{
					goto Block_6;
				}
				if (gclass.method_4() != -1L)
				{
					goto Block_5;
				}
			}
			IL_189:
			i++;
			continue;
			Block_5:
			this.int_19[i] = gclass.method_5();
			this.long_4[i] = gclass.method_4();
			goto IL_189;
			Block_6:
			Console.Error.WriteLine("Could not find last page of logical bitstream #" + i + "\n");
			this.gclass100_0[i].method_1();
			this.gclass119_0[i].method_10();
			goto IL_189;
		}
	}

	int method_7()
	{
		if (this.bool_1)
		{
			Environment.Exit(1);
		}
		this.gclass101_0.method_1(this.gclass100_0[0]);
		this.gclass108_0.method_0(this.gclass101_0);
		this.bool_1 = true;
		return 0;
	}

	int method_8()
	{
		GClass100 gclass100_ = new GClass100();
		GClass119 gclass119_ = new GClass119();
		GClass74 gclass = new GClass74();
		int[] array = new int[1];
		int num = this.method_5(gclass100_, gclass119_, array, null);
		int num2 = array[0];
		int int_ = (int)this.long_0;
		this.gclass99_0.method_2();
		if (num == -1)
		{
			return -1;
		}
		this.bool_0 = true;
		GClass107.smethod_0(this.fileStream_0, 0L, GClass107.int_3);
		this.long_0 = GClass107.smethod_1(this.fileStream_0);
		long num3 = this.long_0;
		num3 = (long)this.method_3(gclass);
		if (gclass.method_5() != num2)
		{
			if (this.method_4(0L, 0L, num3 + 1L, num2, 0) < 0)
			{
				this.method_12();
				return GClass107.int_7;
			}
		}
		else if (this.method_4(0L, num3, num3 + 1L, num2, 0) < 0)
		{
			this.method_12();
			return GClass107.int_7;
		}
		this.method_6(gclass100_, gclass119_, int_);
		return this.method_23(0);
	}

	int method_9()
	{
		this.int_18 = 1;
		this.gclass100_0 = new GClass100[this.int_18];
		this.gclass100_0[0] = new GClass100();
		this.gclass119_0 = new GClass119[this.int_18];
		this.gclass119_0[0] = new GClass119();
		int[] array = new int[1];
		if (this.method_5(this.gclass100_0[0], this.gclass119_0[0], array, null) == -1)
		{
			return -1;
		}
		this.int_20 = array[0];
		this.method_7();
		return 0;
	}

	void method_10()
	{
		this.gclass99_0.method_2();
		this.gclass101_0.method_5();
		this.gclass108_0.method_1();
		this.bool_1 = false;
		this.float_0 = 0f;
		this.float_1 = 0f;
	}

	int method_11(int int_22)
	{
		GClass74 gclass = new GClass74();
		GClass91 gclass2;
		long num2;
		for (;;)
		{
			if (this.bool_1)
			{
				gclass2 = new GClass91();
				int num = this.gclass99_0.method_7(gclass2);
				if (num > 0)
				{
					num2 = gclass2.long_0;
					if (this.gclass108_0.method_2(gclass2) == 0)
					{
						goto Block_11;
					}
				}
			}
			if (int_22 == 0)
			{
				return 0;
			}
			if (this.method_2(gclass, -1L) < 0)
			{
				return 0;
			}
			this.float_0 += (float)(gclass.int_1 * 8);
			if (this.bool_1 && this.int_20 != gclass.method_5())
			{
				this.method_10();
			}
			if (!this.bool_1)
			{
				if (this.bool_0)
				{
					this.int_20 = gclass.method_5();
					int num3 = 0;
					while (num3 < this.int_18 && this.int_19[num3] != this.int_20)
					{
						num3++;
					}
					if (num3 == this.int_18)
					{
						break;
					}
					this.int_21 = num3;
					this.gclass99_0.method_1(this.int_20);
					this.gclass99_0.method_12();
				}
				else
				{
					int[] array = new int[1];
					int num4 = this.method_5(this.gclass100_0[0], this.gclass119_0[0], array, gclass);
					this.int_20 = array[0];
					if (num4 != 0)
					{
						return num4;
					}
					this.int_21++;
				}
				this.method_7();
			}
			this.gclass99_0.method_8(gclass);
		}
		return -1;
		Block_11:
		int num5 = this.gclass101_0.method_3(null, null);
		this.gclass101_0.method_2(this.gclass108_0);
		this.float_1 += (float)(this.gclass101_0.method_3(null, null) - num5);
		this.float_0 += (float)(gclass2.int_1 * 8);
		if (num2 != -1L && gclass2.int_3 == 0)
		{
			int num6 = this.bool_0 ? this.int_21 : 0;
			int num7 = this.gclass101_0.method_3(null, null);
			num2 -= (long)num7;
			for (int i = 0; i < num6; i++)
			{
				num2 += this.long_4[i];
			}
			this.long_5 = num2;
		}
		return 1;
	}

	int method_12()
	{
		this.gclass108_0.method_1();
		this.gclass101_0.method_5();
		this.gclass99_0.method_2();
		if (this.gclass100_0 != null && this.int_18 != 0)
		{
			for (int i = 0; i < this.int_18; i++)
			{
				this.gclass100_0[i].method_1();
				this.gclass119_0[i].method_10();
			}
			this.gclass100_0 = null;
			this.gclass119_0 = null;
		}
		if (this.long_3 != null)
		{
			this.long_3 = null;
		}
		if (this.long_4 != null)
		{
			this.long_4 = null;
		}
		if (this.int_19 != null)
		{
			this.int_19 = null;
		}
		if (this.long_2 != null)
		{
			this.long_2 = null;
		}
		this.gclass96_0.method_0();
		return 0;
	}

	static int smethod_0(FileStream fileStream_1, long long_6, int int_22)
	{
		if (fileStream_1.CanSeek)
		{
			try
			{
				if (int_22 == GClass107.int_1)
				{
					fileStream_1.Seek(long_6, SeekOrigin.Begin);
				}
				else if (int_22 == GClass107.int_3)
				{
					fileStream_1.Seek(fileStream_1.Length - long_6, SeekOrigin.Begin);
				}
				else
				{
					Console.Error.WriteLine("seek: " + int_22 + " is not supported");
				}
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.Message);
			}
			return 0;
		}
		int result;
		try
		{
			if (int_22 == 0)
			{
				fileStream_1.Seek(0L, SeekOrigin.Begin);
			}
			fileStream_1.Seek(long_6, SeekOrigin.Begin);
			return 0;
		}
		catch (Exception ex2)
		{
			Console.Error.WriteLine(ex2.Message);
			result = -1;
		}
		return result;
	}

	static long smethod_1(FileStream fileStream_1)
	{
		try
		{
			if (fileStream_1.CanSeek)
			{
				return fileStream_1.Position;
			}
		}
		catch (Exception ex)
		{
			Console.Error.WriteLine(ex.Message);
		}
		return 0L;
	}

	int method_13(FileStream fileStream_1, byte[] byte_0, int int_22)
	{
		return this.method_14(fileStream_1, byte_0, int_22);
	}

	int method_14(FileStream fileStream_1, byte[] byte_0, int int_22)
	{
		this.fileStream_0 = fileStream_1;
		this.gclass96_0.method_6();
		if (byte_0 != null)
		{
			int destinationIndex = this.gclass96_0.method_1(int_22);
			Array.Copy(byte_0, 0, this.gclass96_0.byte_0, destinationIndex, int_22);
			this.gclass96_0.method_2(int_22);
		}
		int num;
		if (fileStream_1.CanSeek)
		{
			num = this.method_8();
		}
		else
		{
			num = this.method_9();
		}
		if (num != 0)
		{
			this.fileStream_0 = null;
			this.method_12();
		}
		return num;
	}

	public int method_15()
	{
		return this.int_18;
	}

	public bool method_16()
	{
		return this.bool_0;
	}

	public int method_17(int int_22)
	{
		if (int_22 >= this.int_18)
		{
			return -1;
		}
		if (!this.bool_0 && int_22 != 0)
		{
			return this.method_17(0);
		}
		if (int_22 < 0)
		{
			long num = 0L;
			for (int i = 0; i < this.int_18; i++)
			{
				num += (this.long_2[i + 1] - this.long_3[i]) * 8L;
			}
			return (int)Math.Round((double)((float)num / this.method_22(-1)));
		}
		if (this.bool_0)
		{
			return (int)Math.Round((double)((float)((this.long_2[int_22 + 1] - this.long_3[int_22]) * 8L) / this.method_22(int_22)));
		}
		if (this.gclass100_0[int_22].int_11 > 0)
		{
			return this.gclass100_0[int_22].int_11;
		}
		if (this.gclass100_0[int_22].int_10 <= 0)
		{
			return -1;
		}
		if (this.gclass100_0[int_22].int_12 > 0)
		{
			return (this.gclass100_0[int_22].int_10 + this.gclass100_0[int_22].int_12) / 2;
		}
		return this.gclass100_0[int_22].int_10;
	}

	public int method_18()
	{
		int num = this.bool_0 ? this.int_21 : 0;
		if (this.float_1 == 0f)
		{
			return -1;
		}
		int result = (int)((double)(this.float_0 / this.float_1 * (float)this.gclass100_0[num].int_9) + 0.5);
		this.float_0 = 0f;
		this.float_1 = 0f;
		return result;
	}

	public int method_19(int int_22)
	{
		if (int_22 >= this.int_18)
		{
			return -1;
		}
		if (!this.bool_0 && int_22 >= 0)
		{
			return this.method_19(-1);
		}
		if (int_22 < 0)
		{
			return this.int_20;
		}
		return this.int_19[int_22];
	}

	public long method_20(int int_22)
	{
		if (!this.bool_0 || int_22 >= this.int_18)
		{
			return -1L;
		}
		if (int_22 < 0)
		{
			long num = 0L;
			for (int i = 0; i < this.int_18; i++)
			{
				num += this.method_20(i);
			}
			return num;
		}
		return this.long_2[int_22 + 1] - this.long_2[int_22];
	}

	public long method_21(int int_22)
	{
		if (!this.bool_0 || int_22 >= this.int_18)
		{
			return -1L;
		}
		if (int_22 < 0)
		{
			long num = 0L;
			for (int i = 0; i < this.int_18; i++)
			{
				num += this.method_21(i);
			}
			return num;
		}
		return this.long_4[int_22];
	}

	public float method_22(int int_22)
	{
		if (!this.bool_0 || int_22 >= this.int_18)
		{
			return -1f;
		}
		if (int_22 < 0)
		{
			float num = 0f;
			for (int i = 0; i < this.int_18; i++)
			{
				num += this.method_22(i);
			}
			return num;
		}
		return (float)this.long_4[int_22] / (float)this.gclass100_0[int_22].int_9;
	}

	public int method_23(int int_22)
	{
		if (!this.bool_0)
		{
			return -1;
		}
		if (int_22 < 0 || (long)int_22 > this.long_2[this.int_18])
		{
			this.long_5 = -1L;
			this.method_10();
			return -1;
		}
		this.long_5 = -1L;
		this.method_10();
		this.method_1((long)int_22);
		switch (this.method_11(1))
		{
		case -1:
			this.long_5 = -1L;
			this.method_10();
			return -1;
		case 0:
			this.long_5 = this.method_21(-1);
			return 0;
		default:
			for (;;)
			{
				switch (this.method_11(0))
				{
				case -1:
					goto IL_77;
				case 0:
					return 0;
				}
			}
			IL_77:
			this.long_5 = -1L;
			this.method_10();
			return -1;
		}
	}

	public int method_24(long long_6)
	{
		long num = this.method_21(-1);
		if (!this.bool_0)
		{
			return -1;
		}
		if (long_6 < 0L || long_6 > num)
		{
			this.long_5 = -1L;
			this.method_10();
			return -1;
		}
		int i;
		for (i = this.int_18 - 1; i >= 0; i--)
		{
			num -= this.long_4[i];
			if (long_6 >= num)
			{
				break;
			}
		}
		long num2 = long_6 - num;
		long num3 = this.long_2[i + 1];
		long num4 = this.long_2[i];
		int int_ = (int)num4;
		GClass74 gclass = new GClass74();
		while (num4 < num3)
		{
			long num5;
			if (num3 - num4 < (long)GClass107.int_0)
			{
				num5 = num4;
			}
			else
			{
				num5 = (num3 + num4) / 2L;
			}
			this.method_1(num5);
			int num6 = this.method_2(gclass, num3 - num5);
			if (num6 == -1)
			{
				num3 = num5;
			}
			else
			{
				long num7 = gclass.method_4();
				if (num7 < num2)
				{
					int_ = num6;
					num4 = this.long_0;
				}
				else
				{
					num3 = num5;
				}
			}
		}
		if (this.method_23(int_) != 0)
		{
			this.long_5 = -1L;
			this.method_10();
			return -1;
		}
		if (this.long_5 >= long_6)
		{
			this.long_5 = -1L;
			this.method_10();
			return -1;
		}
		if (long_6 > this.method_21(-1))
		{
			this.long_5 = -1L;
			this.method_10();
			return -1;
		}
		while (this.long_5 < long_6)
		{
			int num8 = (int)(long_6 - this.long_5);
			float[][][] float_ = new float[1][][];
			int[] array = new int[this.method_29(-1).int_8];
			int num9 = this.gclass101_0.method_3(float_, array);
			if (num9 > num8)
			{
				num9 = num8;
			}
			this.gclass101_0.method_4(num9);
			this.long_5 += (long)num9;
			if (num9 < num8 && this.method_11(1) == 0)
			{
				this.long_5 = this.method_21(-1);
			}
		}
		return 0;
	}

	public int method_25(float float_2)
	{
		long num = this.method_21(-1);
		float num2 = this.method_22(-1);
		if (!this.bool_0)
		{
			return -1;
		}
		if (float_2 >= 0f && float_2 <= num2)
		{
			int i;
			for (i = this.int_18 - 1; i >= 0; i--)
			{
				num -= this.long_4[i];
				num2 -= this.method_22(i);
				if (float_2 >= num2)
				{
					break;
				}
			}
			long long_ = (long)((float)num + (float_2 - num2) * (float)this.gclass100_0[i].int_9);
			return this.method_24(long_);
		}
		this.long_5 = -1L;
		this.method_10();
		return -1;
	}

	public long method_26()
	{
		return this.long_0;
	}

	public long method_27()
	{
		return this.long_5;
	}

	public float method_28()
	{
		int i = -1;
		long num = 0L;
		float num2 = 0f;
		if (this.bool_0)
		{
			num = this.method_21(-1);
			num2 = this.method_22(-1);
			for (i = this.int_18 - 1; i >= 0; i--)
			{
				num -= this.long_4[i];
				num2 -= this.method_22(i);
				if (this.long_5 >= num)
				{
					break;
				}
			}
		}
		return num2 + (float)(this.long_5 - num) / (float)this.gclass100_0[i].int_9;
	}

	public GClass100 method_29(int int_22)
	{
		if (this.bool_0)
		{
			if (int_22 < 0)
			{
				if (this.bool_1)
				{
					return this.gclass100_0[this.int_21];
				}
				return null;
			}
			else
			{
				if (int_22 >= this.int_18)
				{
					return null;
				}
				return this.gclass100_0[int_22];
			}
		}
		else
		{
			if (this.bool_1)
			{
				return this.gclass100_0[0];
			}
			return null;
		}
	}

	public GClass119 method_30(int int_22)
	{
		if (this.bool_0)
		{
			if (int_22 < 0)
			{
				if (this.bool_1)
				{
					return this.gclass119_0[this.int_21];
				}
				return null;
			}
			else
			{
				if (int_22 >= this.int_18)
				{
					return null;
				}
				return this.gclass119_0[int_22];
			}
		}
		else
		{
			if (this.bool_1)
			{
				return this.gclass119_0[0];
			}
			return null;
		}
	}

	int method_31()
	{
		return 0;
	}

	public int method_32(byte[] byte_0, int int_22, int int_23, int int_24, int int_25, int[] int_26)
	{
		int num = this.method_31();
		int num2 = 0;
		int[] array2;
		int num3;
		float[][] array3;
		for (;;)
		{
			if (this.bool_1)
			{
				float[][][] array = new float[1][][];
				array2 = new int[this.method_29(-1).int_8];
				num3 = this.gclass101_0.method_3(array, array2);
				array3 = array[0];
				if (num3 != 0)
				{
					break;
				}
			}
			switch (this.method_11(1))
			{
			case -1:
				return -1;
			case 0:
				return 0;
			}
		}
		int num4 = this.method_29(-1).int_8;
		int num5 = int_24 * num4;
		if (num3 > int_22 / num5)
		{
			num3 = int_22 / num5;
		}
		if (int_24 == 1)
		{
			int num6 = (int_25 != 0) ? 0 : 128;
			for (int i = 0; i < num3; i++)
			{
				for (int j = 0; j < num4; j++)
				{
					int num7 = (int)((double)array3[j][array2[j] + i] * 128.0 + 0.5);
					if (num7 > 127)
					{
						num7 = 127;
					}
					else if (num7 < -128)
					{
						num7 = -128;
					}
					byte_0[num2++] = (byte)(num7 + num6);
				}
			}
		}
		else
		{
			int num8 = (int_25 != 0) ? 0 : 32768;
			if (num == int_23)
			{
				if (int_25 != 0)
				{
					for (int k = 0; k < num4; k++)
					{
						int num9 = array2[k];
						int num10 = k * 2;
						for (int l = 0; l < num3; l++)
						{
							int num7 = (int)((double)array3[k][num9 + l] * 32767.0);
							if (num7 > 32767)
							{
								num7 = 32767;
							}
							else if (num7 < -32768)
							{
								num7 = -32768;
							}
							byte_0[num10] = (byte)num7;
							byte_0[num10 + 1] = (byte)((uint)num7 >> 8);
							num10 += num5;
						}
					}
				}
				else
				{
					for (int m = 0; m < num4; m++)
					{
						float[] array4 = array3[m];
						int num11 = m;
						for (int n = 0; n < num3; n++)
						{
							int num7 = (int)((double)array4[n] * 32768.0 + 0.5);
							if (num7 > 32767)
							{
								num7 = 32767;
							}
							else if (num7 < -32768)
							{
								num7 = -32768;
							}
							byte_0[num11] = (byte)((uint)(num7 + num8) >> 8);
							byte_0[num11 + 1] = (byte)(num7 + num8);
							num11 += num4 * 2;
						}
					}
				}
			}
			else if (int_23 != 0)
			{
				for (int num12 = 0; num12 < num3; num12++)
				{
					for (int num13 = 0; num13 < num4; num13++)
					{
						int num7 = (int)((double)array3[num13][num12] * 32768.0 + 0.5);
						if (num7 > 32767)
						{
							num7 = 32767;
						}
						else if (num7 < -32768)
						{
							num7 = -32768;
						}
						num7 += num8;
						byte_0[num2++] = (byte)((uint)num7 >> 8);
						byte_0[num2++] = (byte)num7;
					}
				}
			}
			else
			{
				for (int num14 = 0; num14 < num3; num14++)
				{
					for (int num15 = 0; num15 < num4; num15++)
					{
						int num7 = (int)((double)array3[num15][num14] * 32768.0 + 0.5);
						if (num7 > 32767)
						{
							num7 = 32767;
						}
						else if (num7 < -32768)
						{
							num7 = -32768;
						}
						num7 += num8;
						byte_0[num2++] = (byte)num7;
						byte_0[num2++] = (byte)((uint)num7 >> 8);
					}
				}
			}
		}
		this.gclass101_0.method_4(num3);
		this.long_5 += (long)num3;
		if (int_26 != null)
		{
			int_26[0] = this.int_21;
		}
		return num3 * num5;
	}

	public GClass100[] method_33()
	{
		return this.gclass100_0;
	}

	public GClass119[] method_34()
	{
		return this.gclass119_0;
	}

	static int int_0 = 8500;

	static int int_1 = 0;

	static int int_2 = 1;

	static int int_3 = 2;

	static int int_4 = -1;

	static int int_5 = -2;

	static int int_6 = -3;

	static int int_7 = -128;

	static int int_8 = -129;

	static int int_9 = -130;

	static int int_10 = -131;

	static int int_11 = -132;

	static int int_12 = -133;

	static int int_13 = -134;

	static int int_14 = -135;

	static int int_15 = -136;

	static int int_16 = -137;

	static int int_17 = -138;

	FileStream fileStream_0;

	bool bool_0;

	long long_0;

	long long_1;

	GClass96 gclass96_0 = new GClass96();

	int int_18;

	long[] long_2;

	long[] long_3;

	int[] int_19;

	long[] long_4;

	GClass100[] gclass100_0;

	GClass119[] gclass119_0;

	long long_5;

	bool bool_1;

	int int_20;

	int int_21;

	float float_0;

	float float_1;

	GClass99 gclass99_0;

	GClass101 gclass101_0;

	GClass108 gclass108_0;
}
