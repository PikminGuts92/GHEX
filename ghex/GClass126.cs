using System;
using System.IO;
using System.Runtime.CompilerServices;

public class GClass126
{
	internal GClass126(GClass128 gclass128_1, long long_3, long long_4, long long_5, string string_2, string string_3)
	{
		this.long_0 = long_3;
		this.gclass128_0 = gclass128_1;
		this.long_1 = long_4;
		this.long_2 = long_5;
		this.string_0 = string_3;
		this.string_1 = string_2;
	}

	public object method_0()
	{
		return this.object_0;
	}

	public void method_1(object object_1)
	{
		this.object_0 = object_1;
	}

	internal GClass128 method_2()
	{
		return this.gclass128_0;
	}

	internal long method_3()
	{
		return this.long_0;
	}

	public long method_4()
	{
		return this.long_2;
	}

	public string method_5()
	{
		int num = this.string_0.LastIndexOf('.');
		if (num == -1)
		{
			return "";
		}
		return this.string_0.Substring(num + 1);
	}

	public string method_6()
	{
		return this.string_0;
	}

	public string method_7()
	{
		return this.string_1;
	}

	public byte[] method_8()
	{
		return this.gclass128_0.method_25(this);
	}

	public GStream2 method_9()
	{
		return new GStream2(this, this.gclass128_0.method_26());
	}

	public void method_10(GClass126 gclass126_0, bool bool_0, bool bool_1)
	{
		ProgressDialog.GDelegate6 gdelegate = null;
		long num = gclass126_0.long_1;
		long num2 = gclass126_0.long_2;
		if (bool_0)
		{
			gclass126_0.long_1 = this.long_1;
			gclass126_0.long_2 = this.long_2;
		}
		else if (bool_1)
		{
			if (gdelegate == null)
			{
				gdelegate = new ProgressDialog.GDelegate6(this.method_12);
			}
			ProgressDialog progressDialog = new ProgressDialog(gdelegate);
			progressDialog.ShowDialog();
		}
		this.long_1 = num;
		this.long_2 = num2;
		this.gclass128_0.method_1(true);
		if (bool_1)
		{
			this.gclass128_0.method_15();
		}
	}

	internal long method_11()
	{
		return this.long_1;
	}

	[CompilerGenerated]
	void method_12(ref ProgressDialog.GClass73 gclass73_0)
	{
		MemoryStream stream_ = new MemoryStream();
		this.gclass128_0.method_22(this, stream_, ref gclass73_0);
	}

	long long_0;

	long long_1;

	long long_2;

	string string_0;

	string string_1;

	GClass128 gclass128_0;

	object object_0;
}
