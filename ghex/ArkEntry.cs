using System;
using System.IO;
using System.Runtime.CompilerServices;

public class ArkEntry
{
	internal ArkEntry(ArkFile ark, long hdrOffset, long fileOffset, long size, string dir, string file)
	{
        // Typical ark entry here
		this.hdrEntryOffset = hdrOffset;
		this.ark = ark;
		this.fileOffset = fileOffset;
		this.fileSize = size;
		this.fileName = file;
		this.directory = dir;
	}

	public object GetFileObject()
	{
		return this.fileObject;
	}

	public void SetFileObject(object obj)
	{
		this.fileObject = obj;
	}

	internal ArkFile GetArk()
	{
		return this.ark;
	}

	internal long GetHdrEntryOffset()
	{
		return this.hdrEntryOffset;
	}

	public long GetFileSize()
	{
		return this.fileSize;
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

	public GStream2 GetArkEntryStream()
	{
		return new GStream2(this, this.ark.GetArkStream());
	}

	public void method_10(ArkEntry gclass126_0, bool bool_0, bool bool_1)
	{
		ProgressDialog.GDelegate6 gdelegate = null;
		long num = gclass126_0.fileOffset;
		long num2 = gclass126_0.fileSize;
		if (bool_0)
		{
			gclass126_0.fileOffset = this.fileOffset;
			gclass126_0.fileSize = this.fileSize;
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
		this.fileOffset = num;
		this.fileSize = num2;
		this.ark.method_1(true);
		if (bool_1)
		{
			this.ark.method_15();
		}
	}

	internal long GetFileOffset()
	{
		return this.fileOffset;
	}

	[CompilerGenerated]
	void method_12(ref ProgressDialog.GClass73 gclass73_0)
	{
		MemoryStream stream_ = new MemoryStream();
		this.ark.method_22(this, stream_, ref gclass73_0);
	}

	long hdrEntryOffset;

	long fileOffset;

	long fileSize;

	string fileName;

	string directory;

	ArkFile ark;

	object fileObject; // Basically the unserialized file (e.g. milo, vgs, etc)

    public string GetFullPath() => string.IsNullOrEmpty(directory) ? fileName : $"{directory}/{fileName}";

    public override string ToString() => GetFullPath();
}
