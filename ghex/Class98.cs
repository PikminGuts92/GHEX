using System;
using System.IO;

class Class98
{
	internal Class98(Class99 class99_1, string string_2, string string_3, byte[] byte_1)
	{
		this.class99_0 = class99_1;
		this.string_0 = string_3;
		this.string_1 = string_2;
		this.byte_0 = byte_1;
		if (string_2 != null)
		{
			if (string_2 == "Tex")
			{
				this.enum8_0 = ((class99_1.method_0() == 10) ? Enum8.const_1 : Enum8.const_0);
				return;
			}
			if (string_2 == "Mesh")
			{
				this.enum8_0 = Enum8.const_2;
				return;
			}
		}
		this.enum8_0 = Enum8.const_3;
	}

	public string method_0()
	{
		return this.string_0;
	}

	public string method_1()
	{
		int num = this.method_0().LastIndexOf('.');
		if (num == -1)
		{
			return "";
		}
		return this.method_0().Substring(num + 1);
	}

	public byte[] method_2()
	{
		return this.byte_0;
	}

	public Stream method_3()
	{
		return new MemoryStream(this.byte_0);
	}

	internal Class99 method_4()
	{
		return this.class99_0;
	}

	public Enum8 method_5()
	{
		return this.enum8_0;
	}

	internal string method_6()
	{
		return this.string_1;
	}

	string string_0;

	string string_1;

	byte[] byte_0;

	Class99 class99_0;

	Enum8 enum8_0;
}
