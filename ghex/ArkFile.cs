using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class ArkFile
{
	public ArkFile(string hdrPath)
	{
		this.hdrPath = hdrPath.ToLower().Replace('\\', '/');
		this.arkPath = this.hdrPath.Substring(0, this.hdrPath.LastIndexOf('.')) + "_0.ark";
		this.gclass127_0 = new GClass127(this);
		this.bool_0 = false;
	}

	internal bool method_0()
	{
		return this.bool_0;
	}

	internal void method_1(bool bool_3)
	{
		this.bool_0 = bool_3;
	}

	internal bool method_2()
	{
		return this.fileStream_0 != null;
	}

	internal bool ArkExists()
	{
		return File.Exists(this.arkPath);
	}

	public bool method_4()
	{
		return this.bool_1;
	}

	public void method_5(bool bool_3)
	{
		this.bool_1 = bool_3;
	}

	public bool method_6()
	{
		return this.bool_2;
	}

	public bool method_7()
	{
		return !this.ArkExists() || this.bool_2 || (File.GetAttributes(this.arkPath) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly || (File.GetAttributes(this.hdrPath) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly || (this.fileStream_0 != null && !this.fileStream_0.CanWrite);
	}

	public void method_8()
	{
		if (this.ArkExists() && !this.method_2())
		{
			File.SetAttributes(this.hdrPath, File.GetAttributes(this.hdrPath) & ~FileAttributes.ReadOnly);
			File.SetAttributes(this.arkPath, File.GetAttributes(this.arkPath) & ~FileAttributes.ReadOnly);
			return;
		}
	}

	void method_9()
	{
		if (this.fileStream_0 != null)
		{
			return;
		}
		this.fileStream_0 = new FileStream(this.arkPath, FileMode.Open, this.method_7() ? FileAccess.Read : FileAccess.ReadWrite, FileShare.Read);
		this.binaryReader_0 = new BinaryReader(this.fileStream_0);
	}

	public void method_10()
	{
		if (this.fileStream_0 != null)
		{
			this.fileStream_0.Close();
			this.fileStream_0 = null;
			this.binaryReader_0 = null;
		}
	}

	void method_11(string string_2)
	{
		ArkFile.Class94 @class = new ArkFile.Class94();
		@class.gclass128_0 = this;
		MessageBox.Show("About to search for files.\nIt will take a few minutes.", "Archive", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		@class.list_0 = new List<ArkFile.Class91>();
		ProgressDialog progressDialog = new ProgressDialog(new ProgressDialog.GDelegate6(@class.method_0));
		BufferedStream input = new BufferedStream(new FileStream(this.arkPath, FileMode.Open, FileAccess.Read, FileShare.Read), 131072);
		this.binaryReader_0 = new BinaryReader(input);
		progressDialog.ShowDialog();
		this.binaryReader_0.Close();
		this.binaryReader_0 = null;
		this.fileStream_0 = null;
		MemoryStream memoryStream = new MemoryStream(40960);
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write((uint)@class.list_0.Count);
		foreach (ArkFile.Class91 class2 in @class.list_0)
		{
			binaryWriter.Write(class2.uint_0);
			binaryWriter.Write(class2.uint_1);
			binaryWriter.Write(class2.string_0);
			binaryWriter.Write(class2.string_1);
		}
		FileStream output = new FileStream(string_2, FileMode.Create, FileAccess.Write, FileShare.None);
		BinaryWriter binaryWriter2 = new BinaryWriter(output);
		binaryWriter2.Write(1480935495u);
		binaryWriter2.Write(1);
		binaryWriter2.Write((uint)(Class109.smethod_8((uint)memoryStream.Length) ^ 1649809477));
		MemoryStream memoryStream2 = new MemoryStream();
		DeflateStream deflateStream = new DeflateStream(memoryStream2, CompressionMode.Compress, true);
		deflateStream.Write(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
		deflateStream.Close();
		binaryWriter2.Write(memoryStream2.GetBuffer(), 0, (int)memoryStream2.Length);
		memoryStream2.Close();
		binaryWriter2.Close();
		binaryWriter.Close();
	}

	void method_12()
	{
		this.bool_2 = true;
		string text = this.hdrPath.Substring(0, this.hdrPath.LastIndexOf('.')) + ".ghex";
		if (!File.Exists(text))
		{
			this.method_11(text);
		}
		FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
		BinaryReader binaryReader = new BinaryReader(fileStream);
		uint num = binaryReader.ReadUInt32();
		byte b = binaryReader.ReadByte();
		if (num != 1480935495u)
		{
			throw new FileLoadException("Not a valid list file!");
		}
		if (b != 1)
		{
			binaryReader.Close();
			this.method_11(text);
			fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
			binaryReader = new BinaryReader(fileStream);
			num = binaryReader.ReadUInt32();
			b = binaryReader.ReadByte();
		}
		uint num2 = (uint)Class109.smethod_8(binaryReader.ReadUInt32() ^ 1649809477u);
		byte[] buffer = new byte[num2];
		byte[] buffer2 = binaryReader.ReadBytes((int)(fileStream.Length - fileStream.Position));
		DeflateStream deflateStream = new DeflateStream(new MemoryStream(buffer2), CompressionMode.Decompress);
		int num3 = 0;
		for (;;)
		{
			int num4 = deflateStream.Read(buffer, num3, (int)((ulong)num2 - (ulong)((long)num3)));
			if (num4 == 0)
			{
				break;
			}
			num3 += num4;
		}
		deflateStream.Close();
		if ((long)num3 != (long)((ulong)num2))
		{
			throw new FileLoadException("Data size mismatch");
		}
		MemoryStream input = new MemoryStream(buffer);
		BinaryReader binaryReader2 = new BinaryReader(input);
		uint num5 = binaryReader2.ReadUInt32();
		for (uint num6 = 0u; num6 < num5; num6 += 1u)
		{
			uint num7 = binaryReader2.ReadUInt32();
			uint num8 = binaryReader2.ReadUInt32();
			string string_ = binaryReader2.ReadString();
			string string_2 = binaryReader2.ReadString();
			GClass126 item = new GClass126(this, -1L, (long)((ulong)num7), (long)((ulong)num8), string_, string_2);
			this.gclass127_0.Add(item);
		}
		binaryReader2.Close();
		this.gclass127_0.Sort(new ArkFile.Class93());
		fileStream.Close();
	}

	public void method_13()
	{
		if (this.gclass127_0.Count != 0)
		{
			return;
		}
		if (this.method_14() == 4022548923UL)
		{
			this.method_12();
			return;
		}
		FileStream fileStream = new FileStream(this.hdrPath, FileMode.Open, FileAccess.Read, FileShare.Read);
		BinaryReader binaryReader = new BinaryReader(fileStream);
		binaryReader.ReadUInt32();
		binaryReader.ReadUInt32();
		binaryReader.ReadUInt32();
		uint num = binaryReader.ReadUInt32();
		uint num2 = binaryReader.ReadUInt32();
		binaryReader.BaseStream.Seek((long)((ulong)num2), SeekOrigin.Current);
		int num3 = binaryReader.ReadInt32();
		long[] array = new long[num3];
		uint num4 = 0u;
		while ((ulong)num4 < (ulong)((long)num3))
		{
			long num5 = (long)(binaryReader.ReadInt32() + 16 + 4);
			if (num5 > (long)((ulong)num))
			{
				throw new FileLoadException("File offset is beyond end of archive");
			}
			array[(int)((UIntPtr)num4)] = num5;
			num4 += 1u;
		}
		long position = binaryReader.BaseStream.Position;
		string[] array2 = new string[num3];
		uint num6 = 0u;
		while ((ulong)num6 < (ulong)((long)num3))
		{
			long offset = array[(int)((UIntPtr)num6)];
			array2[(int)((UIntPtr)num6)] = "";
			binaryReader.BaseStream.Seek(offset, SeekOrigin.Begin);
			array2[(int)((UIntPtr)num6)] = "";
			while (binaryReader.PeekChar() != 0)
			{
				string[] array3;
				IntPtr intPtr;
				(array3 = array2)[(int)(intPtr = ((IntPtr)num6))] = array3[(int)intPtr] + binaryReader.ReadChar();
			}
			num6 += 1u;
		}
		binaryReader.BaseStream.Seek(position, SeekOrigin.Begin);
		int num7 = binaryReader.ReadInt32();
		this.gclass127_0.Capacity = num7;
		uint num8 = 0u;
		while ((ulong)num8 < (ulong)((long)num7))
		{
			long position2 = binaryReader.BaseStream.Position;
			long num9 = (long)binaryReader.ReadInt32();
			if (num9 < 0L)
			{
				num9 = 4294967296L + num9;
			}
			int num10 = binaryReader.ReadInt32();
			int num11 = binaryReader.ReadInt32();
			long long_ = (long)binaryReader.ReadInt32();
			binaryReader.ReadInt32();
			this.gclass127_0.Add(new GClass126(this, position2, num9, long_, array2[num11], array2[num10]));
			num8 += 1u;
		}
		this.gclass127_0.Sort(new ArkFile.Class93());
		fileStream.Close();
	}

	public ulong method_14()
	{
		if (this.ulong_0 == 0UL)
		{
			GClass129 gclass = new GClass129();
			gclass.method_0(GClass129.GEnum57.const_2);
			this.ulong_0 = gclass.method_1(File.ReadAllBytes(this.hdrPath));
		}
		return this.ulong_0;
	}

	public void method_15()
	{
		FileStream fileStream = new FileStream(this.hdrPath.ToUpper(), FileMode.Open, FileAccess.Write, FileShare.Read);
		BinaryWriter binaryWriter = new BinaryWriter(fileStream);
		this.method_9();
		binaryWriter.Seek(12, SeekOrigin.Begin);
		binaryWriter.Write((uint)this.fileStream_0.Length);
		foreach (GClass126 gclass in this.gclass127_0)
		{
			binaryWriter.BaseStream.Seek(gclass.method_3(), SeekOrigin.Begin);
			binaryWriter.Write((uint)gclass.method_11());
			binaryWriter.Seek(8, SeekOrigin.Current);
			binaryWriter.Write((uint)gclass.method_4());
		}
		fileStream.Close();
		this.ulong_0 = 0UL;
		this.bool_0 = false;
	}

	public string GetHdrPath()
	{
		return this.hdrPath;
	}

	public string method_17()
	{
		string text = this.hdrPath.Substring(this.hdrPath.LastIndexOf('/') + 1);
		return text.Substring(0, text.LastIndexOf('.'));
	}

	public GClass127 method_18()
	{
		return this.gclass127_0;
	}

	public void method_19(GClass126 gclass126_0, GClass126 gclass126_1, bool bool_3, bool bool_4)
	{
		gclass126_0.method_10(gclass126_1, bool_3, bool_4);
	}

	bool method_20(GClass126 gclass126_0)
	{
		return gclass126_0.method_11() > this.long_0;
	}

	public void method_21(GClass126 gclass126_0, Stream stream_0, ref ProgressDialog.GClass73 gclass73_0)
	{
		this.method_9();
		BinaryWriter binaryWriter = new BinaryWriter(this.fileStream_0);
		lock (gclass73_0)
		{
			gclass73_0.string_0 = "Appending data for \"" + gclass126_0.method_6() + "\"";
		}
		int num = (int)Math.Min(stream_0.Length, 131072L);
		byte[] array = new byte[num];
		DateTime now = DateTime.Now;
		binaryWriter.BaseStream.Seek(0L, SeekOrigin.End);
		gclass126_0.method_10(new GClass126(this, gclass126_0.method_3(), binaryWriter.BaseStream.Position, stream_0.Length, null, null), false, false);
		binaryWriter.BaseStream.SetLength(gclass126_0.method_11() + gclass126_0.method_4());
		stream_0.Seek(0L, SeekOrigin.Begin);
		while (stream_0.Position < stream_0.Length)
		{
			int count = Math.Min((int)(stream_0.Length - stream_0.Position), array.Length);
			stream_0.Read(array, 0, count);
			binaryWriter.Write(array, 0, count);
			string str = Class109.smethod_0(now, stream_0.Position, stream_0.Length);
			lock (gclass73_0)
			{
				gclass73_0.int_0 = (int)(stream_0.Position * 100L / stream_0.Length);
				gclass73_0.string_1 = "Writing \"" + gclass126_0.method_6() + "\"" + str;
			}
		}
		this.method_15();
	}

	public void method_22(GClass126 gclass126_0, Stream stream_0, ref ProgressDialog.GClass73 gclass73_0)
	{
		this.method_23(gclass126_0, stream_0, ref gclass73_0, true);
	}

	public void method_23(GClass126 gclass126_0, Stream stream_0, ref ProgressDialog.GClass73 gclass73_0, bool bool_3)
	{
		this.method_9();
		BinaryWriter binaryWriter = new BinaryWriter(this.fileStream_0);
		this.long_0 = gclass126_0.method_11();
		if (bool_3)
		{
			lock (gclass73_0)
			{
				gclass73_0.string_0 = "Replacing data for \"" + gclass126_0.method_6() + "\"";
			}
		}
		List<GClass126> list = this.method_18().FindAll(new Predicate<GClass126>(this.method_20));
		List<GClass126> list2 = list;
		if (ArkFile.comparison_0 == null)
		{
			ArkFile.comparison_0 = new Comparison<GClass126>(ArkFile.smethod_0);
		}
		list2.Sort(ArkFile.comparison_0);
		long num = 0L;
		long num2 = stream_0.Length;
		foreach (GClass126 gclass in list)
		{
			num2 += gclass.method_4();
		}
		int num3 = (int)Math.Min(gclass126_0.method_4(), 262144L);
		byte[] array = new byte[num3];
		DateTime now = DateTime.Now;
		long num4 = gclass126_0.method_11();
		foreach (GClass126 gclass2 in list)
		{
			int num5 = list.IndexOf(gclass2);
			if (bool_3)
			{
				lock (gclass73_0)
				{
					gclass73_0.string_1 = "Moving \"" + gclass2.method_6() + "\"";
				}
			}
			long num6 = gclass2.method_11();
			gclass2.method_10(new GClass126(this, gclass2.method_3(), num4, gclass2.method_4(), null, null), false, false);
			long num7 = 0L;
			while (num7 < gclass2.method_4())
			{
				int count = Math.Min((int)(gclass2.method_4() - num7), array.Length);
				this.binaryReader_0.BaseStream.Seek(num6, SeekOrigin.Begin);
				int num8 = this.binaryReader_0.Read(array, 0, count);
				binaryWriter.BaseStream.Seek(num4, SeekOrigin.Begin);
				binaryWriter.Write(array, 0, num8);
				num7 += (long)num8;
				num6 += (long)num8;
				num4 += (long)num8;
				num += (long)num8;
				string text = Class109.smethod_0(now, num, num2);
				lock (gclass73_0)
				{
					if (bool_3)
					{
						gclass73_0.int_0 = (int)(num7 * 100L / gclass2.method_4());
						gclass73_0.int_1 = (int)(num * 100L / num2);
						gclass73_0.string_2 = string.Concat(new object[]
						{
							"File ",
							1 + num5,
							" of ",
							list.Count + ((stream_0.Length > 0L) ? 1 : 0),
							text
						});
					}
					else
					{
						gclass73_0.int_0 = (int)(num * 100L / num2);
					}
				}
			}
		}
		binaryWriter.BaseStream.Seek(this.long_0 + num, SeekOrigin.Begin);
		gclass126_0.method_10(new GClass126(this, gclass126_0.method_3(), binaryWriter.BaseStream.Position, stream_0.Length, null, null), false, false);
		if (stream_0.Length > 0L)
		{
			stream_0.Seek(0L, SeekOrigin.Begin);
			if (!bool_3)
			{
				goto IL_493;
			}
			lock (gclass73_0)
			{
				gclass73_0.string_1 = "Writing \"" + gclass126_0.method_6() + "\"";
				goto IL_493;
			}
			IL_39B:
			int count2 = Math.Min((int)(stream_0.Length - stream_0.Position), array.Length);
			int num9 = stream_0.Read(array, 0, count2);
			binaryWriter.Write(array, 0, num9);
			num += (long)num9;
			string text2 = Class109.smethod_0(now, num, num2);
			lock (gclass73_0)
			{
				if (bool_3)
				{
					gclass73_0.int_0 = (int)(stream_0.Position * 100L / stream_0.Length);
					gclass73_0.int_1 = (int)(num * 100L / num2);
					gclass73_0.string_2 = string.Concat(new object[]
					{
						"File ",
						list.Count + 1,
						" of ",
						list.Count + 1,
						text2
					});
				}
				else
				{
					gclass73_0.int_0 = (int)(num * 100L / num2);
				}
			}
			IL_493:
			if (stream_0.Position < stream_0.Length)
			{
				goto IL_39B;
			}
		}
		binaryWriter.BaseStream.SetLength(this.long_0 + num);
		this.method_15();
	}

	public void method_24(GClass126 gclass126_0, Stream stream_0, ref ProgressDialog.GClass73 gclass73_0)
	{
		GStream2 gstream = gclass126_0.method_9();
		BinaryWriter binaryWriter = new BinaryWriter(stream_0);
		int num = (int)Math.Min(gclass126_0.method_4(), 262144L);
		byte[] array = new byte[num];
		DateTime now = DateTime.Now;
		while (gstream.Position < gstream.Length)
		{
			int count = Math.Min((int)(gstream.Length - gstream.Position), array.Length);
			gstream.Read(array, 0, count);
			binaryWriter.Write(array, 0, count);
			string str = Class109.smethod_0(now, gstream.Position, gstream.Length);
			if (gclass73_0 != null)
			{
				lock (gclass73_0)
				{
					gclass73_0.string_1 = "Writing \"" + gclass126_0.method_6() + "\"" + str;
					gclass73_0.int_0 = (int)(gstream.Position * 100L / gstream.Length);
				}
			}
		}
	}

	public byte[] method_25(GClass126 gclass126_0)
	{
		this.method_9();
		this.binaryReader_0.BaseStream.Seek(gclass126_0.method_11(), SeekOrigin.Begin);
		return this.binaryReader_0.ReadBytes((int)gclass126_0.method_4());
	}

	internal FileStream GetArkStream()
	{
		return new FileStream(this.arkPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
	}

	public GClass127 method_27(string string_2)
	{
		GClass127 gclass = new GClass127(this);
		foreach (GClass126 gclass2 in this.method_18())
		{
			if (string.Compare(gclass2.method_7() + "/" + gclass2.method_6(), string_2, true) == 0)
			{
				gclass.Add(gclass2);
			}
		}
		return gclass;
	}

	public GClass127 method_28(string string_2, string string_3)
	{
		GClass127 gclass = new GClass127(this);
		string[] array = string_3.Split(new char[]
		{
			'.'
		});
		string text = (array.Length > 0) ? array[0] : "*";
		string strB = (array.Length > 1) ? array[1] : "*";
		if (string_2 == "/")
		{
			using (List<GClass126>.Enumerator enumerator = this.method_18().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					GClass126 gclass2 = enumerator.Current;
					string[] array2 = gclass2.method_7().Split(new char[]
					{
						'/'
					});
					if (array2.Length == 0)
					{
						gclass.Add(gclass2);
					}
				}
				return gclass;
			}
		}
		foreach (GClass126 gclass3 in this.method_18())
		{
			if (gclass3.method_7().StartsWith(string_2, true, CultureInfo.CurrentUICulture))
			{
				string[] array3 = gclass3.method_6().Split(new char[]
				{
					'.'
				});
				if (string.Compare((array3.Length > 1) ? array3[1] : "*", strB) == 0 && (!(text != "*") || string.Compare(array3[0], text) == 0))
				{
					gclass.Add(gclass3);
				}
			}
		}
		return gclass;
	}

	[CompilerGenerated]
	static int smethod_0(GClass126 gclass126_0, GClass126 gclass126_1)
	{
		if (gclass126_0.method_11() >= gclass126_1.method_11())
		{
			return 1;
		}
		return -1;
	}

	GClass127 gclass127_0;

	string hdrPath;

	string arkPath;

	FileStream fileStream_0;

	BinaryReader binaryReader_0;

	bool bool_0;

	bool bool_1;

	bool bool_2;

	ulong ulong_0;

	long long_0;

	[CompilerGenerated]
	static Comparison<GClass126> comparison_0;

	enum Enum6
	{
		const_0 = 1
	}

	class Class91
	{
		public uint uint_0;

		public uint uint_1;

		public string string_0;

		public string string_1;
	}

	class Class92
	{
		public Class92(uint uint_1)
		{
			this.uint_0 = uint_1;
		}

		public uint uint_0;

		public int int_0;

		public bool bool_0;
	}

	class Class93 : IComparer<GClass126>
	{
		public int Compare(GClass126 gclass126_0, GClass126 gclass126_1)
		{
			return string.Compare(gclass126_0.method_7() + "/" + gclass126_0.method_6(), gclass126_1.method_7() + "/" + gclass126_1.method_6(), true);
		}
	}

	[CompilerGenerated]
	sealed class Class94
	{
		public void method_0(ref ProgressDialog.GClass73 gclass73_0)
		{
            // TODO: Actually fix goto IL_127
            return;

            string text = null;
			int num = 0;
			int num2 = 0;
			ArkFile.Class91 @class = null;
			long num3 = 0L;
			lock (gclass73_0)
			{
				gclass73_0.string_0 = "Searching archive..";
			}
			DateTime now = DateTime.Now;
			IL_5CB:
			while (this.gclass128_0.binaryReader_0.BaseStream.Position < this.gclass128_0.binaryReader_0.BaseStream.Length - 1024L)
			{
				int count = this.list_0.Count;
				long num4 = this.gclass128_0.binaryReader_0.BaseStream.Position;
				uint num5 = 0u;
				byte[] array = this.gclass128_0.binaryReader_0.ReadBytes(4096);
				for (int i = 0; i < array.Length - 4; i++)
				{
					byte b = array[i];
					if (b == 77 || b == 79)
					{
						byte b2 = array[i + 1];
						if (b2 == 84 || b2 == 103)
						{
							byte b3 = array[i + 2];
							if (b3 == 104 || b3 == 103)
							{
								byte b4 = array[i + 3];
								if (b4 != 100)
								{
									if (b4 != 83)
									{
										goto IL_D5;
									}
								}
								num5 = (uint)((int)b4 << 24 | (int)b3 << 16 | (int)b2 << 8 | (int)b);
								num4 += (long)i;
								this.gclass128_0.binaryReader_0.BaseStream.Seek(num4 + 4L, SeekOrigin.Begin);
								IL_127:
								if (num5 == 1684558925u)
								{
									int num6 = Class109.smethod_8(this.gclass128_0.binaryReader_0.ReadUInt32());
									Class109.smethod_9(this.gclass128_0.binaryReader_0.ReadUInt16());
									int num7 = Class109.smethod_9(this.gclass128_0.binaryReader_0.ReadUInt16());
									Class109.smethod_9(this.gclass128_0.binaryReader_0.ReadUInt16());
									int num8 = 8 + num6;
									for (int j = 0; j < num7; j++)
									{
										this.gclass128_0.binaryReader_0.ReadUInt32();
										int num9 = Class109.smethod_8(this.gclass128_0.binaryReader_0.ReadUInt32());
										num8 += 8 + num9;
										this.gclass128_0.binaryReader_0.BaseStream.Seek((long)num9, SeekOrigin.Current);
									}
									this.gclass128_0.binaryReader_0.BaseStream.Seek(num4 + 25L, SeekOrigin.Begin);
									byte count2 = this.gclass128_0.binaryReader_0.ReadByte();
									text = new string(this.gclass128_0.binaryReader_0.ReadChars((int)count2));
									this.gclass128_0.binaryReader_0.BaseStream.Seek(num4 + (long)num8, SeekOrigin.Begin);
									num = 0;
									ArkFile.Class91 class2 = new ArkFile.Class91();
									class2.uint_0 = (uint)num4;
									class2.uint_1 = (uint)num8;
									if (text.ToLower().Contains("tutorial"))
									{
										class2.string_0 = "tutorial";
									}
									else
									{
										class2.string_0 = "songs/" + text;
									}
									class2.string_1 = text + ".mid";
									this.list_0.Add(class2);
									num3 += (long)((ulong)class2.uint_1);
									lock (gclass73_0)
									{
										gclass73_0.string_1 = class2.string_1;
										goto IL_49F;
									}
									goto IL_2F8;
								}
								goto IL_2F8;
								IL_49F:
								string text2 = Class109.smethod_0(now, this.gclass128_0.binaryReader_0.BaseStream.Position, this.gclass128_0.binaryReader_0.BaseStream.Length);
								lock (gclass73_0)
								{
									gclass73_0.int_1 = (int)(num4 * 100L / this.gclass128_0.binaryReader_0.BaseStream.Length);
									if (this.list_0.Count == 0)
									{
										gclass73_0.string_2 = "No files found";
									}
									else
									{
										gclass73_0.string_2 = string.Concat(new object[]
										{
											"Found ",
											this.list_0.Count,
											" file",
											(this.list_0.Count > 1) ? "s" : "",
											" (",
											num3 * 100L / this.gclass128_0.binaryReader_0.BaseStream.Length,
											"%)",
											text2
										});
									}
								}
								goto IL_5CB;
								IL_2F8:
								if (num5 != 1399285583u)
								{
									goto IL_49F;
								}
								if (@class == null)
								{
									@class = new ArkFile.Class91();
									if (num2 >= 9 && num2 < 100 && text != null)
									{
										@class.string_0 = "songs/" + text;
										if (num == 0)
										{
											@class.string_1 = text + ".mogg";
										}
										else
										{
											@class.string_1 = string.Concat(new object[]
											{
												text,
												"_",
												num,
												".mogg"
											});
										}
									}
									else
									{
										@class.string_0 = "_uncategorized";
										@class.string_1 = num2.ToString() + ".mogg";
									}
									lock (gclass73_0)
									{
										gclass73_0.string_1 = @class.string_1;
									}
									num2++;
									num++;
									@class.uint_1 = 0u;
									@class.uint_0 = (uint)num4;
								}
								this.gclass128_0.binaryReader_0.ReadByte();
								byte b5 = this.gclass128_0.binaryReader_0.ReadByte();
								this.gclass128_0.binaryReader_0.BaseStream.Seek(20L, SeekOrigin.Current);
								byte b6 = this.gclass128_0.binaryReader_0.ReadByte();
								uint num10 = 0u;
								for (int k = 0; k < (int)b6; k++)
								{
									num10 += (uint)this.gclass128_0.binaryReader_0.ReadByte();
								}
								this.gclass128_0.binaryReader_0.BaseStream.Seek((long)((ulong)num10), SeekOrigin.Current);
								@class.uint_1 += num10;
								if ((b5 & 4) == 4)
								{
									num3 += (long)((ulong)@class.uint_1);
									this.list_0.Add(@class);
									@class = null;
									goto IL_49F;
								}
								goto IL_49F;
							}
						}
					}
					IL_D5:;
				}
				//goto IL_127;
			}
		}

		public List<ArkFile.Class91> list_0;

		public ArkFile gclass128_0;
	}
}
