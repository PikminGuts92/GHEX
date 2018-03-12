using System;
using System.IO;

class Class39
{
	public static Class39.Struct2 smethod_0(BinaryReader binaryReader_0)
	{
		Class39.Struct2 result = default(Class39.Struct2);
		result.uint_0 = binaryReader_0.ReadUInt32();
		result.uint_1 = binaryReader_0.ReadUInt32();
		if (result.uint_0 == 559114070u)
		{
			if (result.uint_1 == 2u)
			{
				int num = 0;
				int[] array = new int[30];
				for (int i = 0; i < 15; i++)
				{
					array[i * 2] = binaryReader_0.ReadInt32();
					array[i * 2 + 1] = binaryReader_0.ReadInt32();
					if (array[i * 2] == 0)
					{
						binaryReader_0.BaseStream.Seek((long)((15 - (i + 1)) * 8), SeekOrigin.Current);

						result.struct3_0 = new Class39.Struct2.Struct3[num];
						for (int j = 0; j < num; j++)
						{
							result.struct3_0[j].int_0 = array[j * 2];
							result.struct3_0[j].int_1 = array[j * 2 + 1];
						}
						return result;
					}
					num++;
				}

                result.struct3_0 = new Class39.Struct2.Struct3[num];
                for (int j = 0; j < num; j++)
                {
                    result.struct3_0[j].int_0 = array[j * 2];
                    result.struct3_0[j].int_1 = array[j * 2 + 1];
                }
                return result;
            }
		}
		throw new FileLoadException("Not a valid VGS file");
	}

	public static void smethod_1(BinaryWriter binaryWriter_0, Class39.Struct2.Struct3[] struct3_0)
	{
		binaryWriter_0.Write(559114070u);
		binaryWriter_0.Write(2u);
		for (int i = 0; i < 15; i++)
		{
			if (i < struct3_0.Length)
			{
				binaryWriter_0.Write((uint)struct3_0[i].int_0);
				binaryWriter_0.Write((uint)struct3_0[i].int_1);
			}
			else
			{
				binaryWriter_0.Write(0UL);
			}
		}
	}

	public const uint uint_0 = 559114070u;

	public struct Struct2
	{
		public uint uint_0;

		public uint uint_1;

		public Class39.Struct2.Struct3[] struct3_0;

		public struct Struct3
		{
			public int int_0;

			public int int_1;
		}
	}
}
