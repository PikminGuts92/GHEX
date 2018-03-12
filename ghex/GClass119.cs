using System;
using System.Text;

public class GClass119
{
	public void method_0()
	{
		this.byte_0 = null;
		this.int_2 = 0;
		this.byte_1 = null;
	}

	public void method_1(string string_1)
	{
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		byte[] bytes = asciiencoding.GetBytes(string_1);
		this.method_2(bytes);
	}

	void method_2(byte[] byte_2)
	{
		byte[][] destinationArray = new byte[this.int_2 + 2][];
		if (this.byte_0 != null)
		{
			Array.Copy(this.byte_0, 0, destinationArray, 0, this.int_2);
		}
		this.byte_0 = destinationArray;
		int[] destinationArray2 = new int[this.int_2 + 2];
		if (this.int_1 != null)
		{
			Array.Copy(this.int_1, 0, destinationArray2, 0, this.int_2);
		}
		this.int_1 = destinationArray2;
		byte[] array = new byte[byte_2.Length + 1];
		Array.Copy(byte_2, 0, array, 0, byte_2.Length);
		this.byte_0[this.int_2] = array;
		this.int_1[this.int_2] = byte_2.Length;
		this.int_2++;
		this.byte_0[this.int_2] = null;
	}

	public void method_3(string string_1, string string_2)
	{
		if (string_2 == null)
		{
			string_2 = "";
		}
		this.method_1(string_1 + "=" + string_2);
	}

	static bool smethod_0(byte[] byte_2, byte[] byte_3, int int_3)
	{
		for (int i = 0; i < int_3; i++)
		{
			byte b = byte_2[i];
			byte b2 = byte_3[i];
			if (b >= 65)
			{
				b = b - 65 + 97;
			}
			if (b2 >= 65)
			{
				b2 = b2 - 65 + 97;
			}
			if (b != b2)
			{
				return false;
			}
		}
		return true;
	}

	public string method_4(string string_1)
	{
		return this.method_5(string_1, 0);
	}

	public string method_5(string string_1, int int_3)
	{
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		byte[] bytes = asciiencoding.GetBytes(string_1);
		int num = this.method_6(bytes, int_3);
		if (num == -1)
		{
			return null;
		}
		byte[] array = this.byte_0[num];
		for (int i = 0; i < this.int_1[num]; i++)
		{
			if (array[i] == 61)
			{
				char[] chars = asciiencoding.GetChars(array);
				return new string(chars, i + 1, this.int_1[num] - (i + 1));
			}
		}
		return null;
	}

	int method_6(byte[] byte_2, int int_3)
	{
		int num = 0;
		int num2 = byte_2.Length;
		byte[] array = new byte[num2 + 2];
		Array.Copy(byte_2, 0, array, 0, byte_2.Length);
		array[byte_2.Length] = 61;
		for (int i = 0; i < this.int_2; i++)
		{
			if (GClass119.smethod_0(this.byte_0[i], array, num2))
			{
				if (int_3 == num)
				{
					return i;
				}
				num++;
			}
		}
		return -1;
	}

	internal int method_7(GClass37 gclass37_0)
	{
		int num = gclass37_0.method_12(32);
		if (num < 0)
		{
			this.method_10();
			return -1;
		}
		this.byte_1 = new byte[num + 1];
		gclass37_0.method_2(this.byte_1, num);
		this.int_2 = gclass37_0.method_12(32);
		if (this.int_2 < 0)
		{
			this.method_10();
			return -1;
		}
		this.byte_0 = new byte[this.int_2 + 1][];
		this.int_1 = new int[this.int_2 + 1];
		for (int i = 0; i < this.int_2; i++)
		{
			int num2 = gclass37_0.method_12(32);
			if (num2 < 0)
			{
				this.method_10();
				return -1;
			}
			this.int_1[i] = num2;
			this.byte_0[i] = new byte[num2 + 1];
			gclass37_0.method_2(this.byte_0[i], num2);
		}
		if (gclass37_0.method_12(1) != 1)
		{
			this.method_10();
			return -1;
		}
		return 0;
	}

	int method_8(GClass37 gclass37_0)
	{
		string text = "Xiphophorus libVorbis I 20000508";
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		byte[] bytes = asciiencoding.GetBytes(text);
		byte[] bytes2 = asciiencoding.GetBytes(GClass119.string_0);
		gclass37_0.method_6(3, 8);
		gclass37_0.method_1(bytes2);
		gclass37_0.method_6(text.Length, 32);
		gclass37_0.method_1(bytes);
		gclass37_0.method_6(this.int_2, 32);
		if (this.int_2 != 0)
		{
			for (int i = 0; i < this.int_2; i++)
			{
				if (this.byte_0[i] != null)
				{
					gclass37_0.method_6(this.int_1[i], 32);
					gclass37_0.method_1(this.byte_0[i]);
				}
				else
				{
					gclass37_0.method_6(0, 32);
				}
			}
		}
		gclass37_0.method_6(1, 1);
		return 0;
	}

	public int method_9(GClass91 gclass91_0)
	{
		GClass37 gclass = new GClass37();
		gclass.method_0();
		if (this.method_8(gclass) != 0)
		{
			return GClass119.int_0;
		}
		gclass91_0.byte_0 = new byte[gclass.method_14()];
		gclass91_0.int_0 = 0;
		gclass91_0.int_1 = gclass.method_14();
		Array.Copy(gclass.method_16(), 0, gclass91_0.byte_0, 0, gclass91_0.int_1);
		gclass91_0.int_2 = 0;
		gclass91_0.int_3 = 0;
		gclass91_0.long_0 = 0L;
		return 0;
	}

	public void method_10()
	{
		for (int i = 0; i < this.int_2; i++)
		{
			this.byte_0[i] = null;
		}
		this.byte_0 = null;
		this.byte_1 = null;
	}

	public string method_11()
	{
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		char[] chars = asciiencoding.GetChars(this.byte_1);
		return new string(chars);
	}

	public string method_12(int int_3)
	{
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		if (this.int_2 <= int_3)
		{
			return null;
		}
		char[] chars = asciiencoding.GetChars(this.byte_0[int_3]);
		return new string(chars);
	}

	public string method_13()
	{
		ASCIIEncoding asciiencoding = new ASCIIEncoding();
		string str = "Vendor: " + new string(asciiencoding.GetChars(this.byte_1));
		for (int i = 0; i < this.int_2; i++)
		{
			str = str + "\nComment: " + new string(asciiencoding.GetChars(this.byte_0[i]));
		}
		return str + "\n";
	}

	static string string_0 = "vorbis";

	static int int_0 = -130;

	public byte[][] byte_0;

	public int[] int_1;

	public int int_2;

	public byte[] byte_1;
}
