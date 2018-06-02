using System;
using System.IO;

class VgsHelper
{
    public static readonly uint VGS_MAGIC = 0x21536756; // VgS!
    public static readonly uint MAX_CHANNELS = 15;

    public static VgsHelper.VgsFile ReadVgsFromStream(BinaryReader reader)
    {
        // Parses VGS file
        VgsHelper.VgsFile result = default(VgsHelper.VgsFile);
        result.magic = reader.ReadUInt32();
        result.version = reader.ReadUInt32();

        // Checks magic
        if (result.magic == VGS_MAGIC)
        {
            // Checks version
            if (result.version == 2u)
            {
                int num = 0;
                int[] array = new int[30];

                // Parses each channel info
                for (int i = 0; i < MAX_CHANNELS; i++)
                {
                    // Reads sample rate and block count
                    array[i * 2] = reader.ReadInt32();
                    array[i * 2 + 1] = reader.ReadInt32();
                    if (array[i * 2] == 0)
                    {
                        reader.BaseStream.Seek((long)((MAX_CHANNELS - (i + 1)) * 8), SeekOrigin.Current);

                        result.channels = new VgsHelper.VgsFile.VgsChannel[num];
                        for (int j = 0; j < num; j++)
                        {
                            result.channels[j].sampleRate = array[j * 2];
                            result.channels[j].blockCount = array[j * 2 + 1];
                        }
                        return result;
                    }
                    num++;
                }

                // Max channels reached
                result.channels = new VgsHelper.VgsFile.VgsChannel[num];
                for (int j = 0; j < num; j++)
                {
                    result.channels[j].sampleRate = array[j * 2];
                    result.channels[j].blockCount = array[j * 2 + 1];
                }
                return result;
            }
        }
        throw new FileLoadException("Not a valid VGS file");
    }

    public static void WriteVgsToStream(BinaryWriter binaryWriter_0, VgsHelper.VgsFile.VgsChannel[] struct3_0)
    {
        binaryWriter_0.Write(VGS_MAGIC);
        binaryWriter_0.Write(2u);
        for (int i = 0; i < 15; i++)
        {
            if (i < struct3_0.Length)
            {
                binaryWriter_0.Write((uint)struct3_0[i].sampleRate);
                binaryWriter_0.Write((uint)struct3_0[i].blockCount);
            }
            else
            {
                binaryWriter_0.Write(0UL);
            }
        }
    }
    
    public struct VgsFile
    {
        public uint magic;

        public uint version;

        public VgsHelper.VgsFile.VgsChannel[] channels;

        public struct VgsChannel
        {
            public int sampleRate;

            public int blockCount;
        }
    }
}
