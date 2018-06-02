using System;
using System.IO;
using System.Runtime.CompilerServices;

public class ArkEntry
{
	internal ArkEntry(ArkFile ark, long long_3, long long_4, long long_5, string dir, string file)
	{
        // Typical ark entry here
		this.long_0 = long_3;
		this.ark = ark;
		this.long_1 = long_4;
		this.long_2 = long_5;
		this.fileName = file;
		this.directory = dir;
	}

	public object method_0()
	{
		return this.object_0;
	}

	public void method_1(object object_1)
	{
		this.object_0 = object_1;
	}

	internal ArkFile GetArk()
	{
		return this.ark;
	}

	internal long method_3()
	{
		return this.long_0;
	}

	public long method_4()
	{
		return this.long_2;
	}

	public string GetFileExtension()
	{
		int num = this.fileName.LastIndexOf('.');
		if (num == -1)
		{
			return "";
		}
		return this.fileName.Substring(num + 1);
	}

	public string GetFileName()
	{
		return this.fileName;
	}

	public string GetDirectory()
	{
		return this.directory;
	}

	public byte[] method_8()
	{
		return this.ark.method_25(this);
	}

	public GStream2 method_9()
	{
		return new GStream2(this, this.ark.GetArkStream());
	}

	public void method_10(ArkEntry gclass126_0, bool bool_0, bool bool_1)
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
		this.ark.method_1(true);
		if (bool_1)
		{
			this.ark.method_15();
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
		this.ark.method_22(this, stream_, ref gclass73_0);
	}

	long long_0;

	long long_1;

	long long_2;

	string fileName;

	string directory;

	ArkFile ark;

	object object_0;
}
