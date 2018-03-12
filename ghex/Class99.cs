using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;

class Class99
{
	Class99()
	{
	}

	public int method_0()
	{
		return this.int_0;
	}

	public List<Class98> method_1()
	{
		return this.list_0;
	}

	public static Class99 smethod_0(byte[] byte_0, ref ProgressDialog.GClass73 gclass73_0)
	{
		MemoryStream memoryStream = new MemoryStream(byte_0);
		BinaryReader binaryReader = new BinaryReader(memoryStream);
		binaryReader.ReadUInt32();
		int num = binaryReader.ReadInt32();
		uint num2 = binaryReader.ReadUInt32();
		int num3 = binaryReader.ReadInt32();
		int[] array = new int[num2];
		int num4 = 0;
		while ((long)num4 < (long)((ulong)num2))
		{
			array[num4] = binaryReader.ReadInt32();
			num4++;
		}
		byte[] buffer = new byte[(long)num3 * (long)((ulong)num2)];
		memoryStream.Seek((long)num, SeekOrigin.Begin);
		lock (gclass73_0)
		{
			gclass73_0.string_1 = "Decompressing..";
		}
		int num5 = num;
		int num6 = 0;
		int num7 = 0;
		while ((long)num7 < (long)((ulong)num2))
		{
			DeflateStream deflateStream = new DeflateStream(new MemoryStream(byte_0, num5, array[num7]), CompressionMode.Decompress, true);
			int num8 = deflateStream.Read(buffer, num6, num3);
			if (num8 == 0)
			{
				return null;
			}
			num6 += num8;
			num5 += array[num7];
			lock (gclass73_0)
			{
				gclass73_0.int_0 = num5 * 100 / (byte_0.Length - num);
			}
			num7++;
		}
		Array.Resize<byte>(ref buffer, num6);
		return Class99.smethod_1(new MemoryStream(buffer), ref gclass73_0);
	}

	public static Class99 smethod_1(Stream stream_0, ref ProgressDialog.GClass73 gclass73_0)
	{
		BinaryReader binaryReader = new BinaryReader(stream_0);
		Class99 @class = new Class99();
		@class.int_0 = binaryReader.ReadInt32();
		if (@class.int_0 == 24)
		{
			binaryReader.BaseStream.Seek((long)binaryReader.ReadInt32(), SeekOrigin.Current);
			binaryReader.BaseStream.Seek((long)binaryReader.ReadInt32(), SeekOrigin.Current);
			binaryReader.BaseStream.Seek(8L, SeekOrigin.Current);
		}
		int num = binaryReader.ReadInt32();
		string[] array = new string[num];
		string[] array2 = new string[num];
		for (int i = 0; i < num; i++)
		{
			int num2 = binaryReader.ReadInt32();
			string text = "";
			for (int j = 0; j < num2; j++)
			{
				text += binaryReader.ReadChar();
			}
			num2 = binaryReader.ReadInt32();
			string text2 = "";
			for (int k = 0; k < num2; k++)
			{
				text2 += binaryReader.ReadChar();
			}
			array[i] = text;
			array2[i] = text2;
		}
		if (@class.int_0 == 24)
		{
			while (binaryReader.ReadUInt32() != 3735936685u)
			{
				binaryReader.BaseStream.Seek(-3L, SeekOrigin.Current);
			}
		}
		@class.list_0 = new List<Class98>();
		int num3 = 0;
		long position = binaryReader.BaseStream.Position;
		long position2 = binaryReader.BaseStream.Position;
		for (;;)
		{
			uint num4 = binaryReader.ReadUInt32();
			if (binaryReader.BaseStream.Position == binaryReader.BaseStream.Length)
			{
				goto IL_15A;
			}
			if (num4 == 3735936685u)
			{
				goto IL_15A;
			}
			binaryReader.BaseStream.Seek(-3L, SeekOrigin.Current);
			IL_238:
			lock (gclass73_0)
			{
				gclass73_0.int_0 = (int)((binaryReader.BaseStream.Position - position) * 100L / (binaryReader.BaseStream.Length - position));
			}
			if (binaryReader.BaseStream.Position >= binaryReader.BaseStream.Length)
			{
				break;
			}
			continue;
			IL_15A:
			lock (gclass73_0)
			{
				gclass73_0.string_1 = string.Concat(new object[]
				{
					array2[num3],
					" (",
					1 + num3,
					"/",
					num,
					")"
				});
			}
			int count = (int)(binaryReader.BaseStream.Position - position2 - 4L);
			binaryReader.BaseStream.Seek(position2, SeekOrigin.Begin);
			Class98 item = new Class98(@class, array[num3], array2[num3], binaryReader.ReadBytes(count));
			@class.list_0.Add(item);
			num3++;
			binaryReader.BaseStream.Seek(4L, SeekOrigin.Current);
			position2 = binaryReader.BaseStream.Position;
			goto IL_238;
		}
		lock (gclass73_0)
		{
			gclass73_0.string_1 = "Sorting";
			gclass73_0.int_0 = -1;
		}
		List<Class98> list = @class.list_0;
		if (Class99.comparison_0 == null)
		{
			Class99.comparison_0 = new Comparison<Class98>(Class99.smethod_2);
		}
		list.Sort(Class99.comparison_0);
		return @class;
	}

	[CompilerGenerated]
	static int smethod_2(Class98 class98_0, Class98 class98_1)
	{
		return string.Compare(class98_0.method_0(), class98_1.method_0(), true);
	}

	int int_0;

	List<Class98> list_0;

	[CompilerGenerated]
	static Comparison<Class98> comparison_0;
}
