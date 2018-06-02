using System;
using System.Collections.Generic;
using System.IO;

public class MidiFile
{
    public MidiFile()
    {
    }

    public MidiFile(Stream stream_0)
    {
        this.method_8(stream_0);
    }

    public List<MidiTrack> GetTracks()
    {
        return this.tracks;
    }

    public int TicksPerQuarterNote()
    {
        return this.ticksPerQuarterNote;
    }

    public void SetTicksPerQuarterNote(int int_1)
    {
        this.ticksPerQuarterNote = int_1;
    }

    public GEnum54 method_3()
    {
        if (this.FindTrackByName("T1 GEMS") != null)
        {
            return GEnum54.const_1;
        }
        if (this.FindTrackByName("PART GUITAR") != null)
        {
            return GEnum54.const_2;
        }
        return GEnum54.const_0;
    }

    public MidiTrack FindTrackByName(string string_0)
    {
        if (string_0 == null)
        {
            return null;
        }
        foreach (MidiTrack gclass in this.tracks)
        {
            if (string.Compare(gclass.method_1(), string_0, true) == 0)
            {
                return gclass;
            }
        }
        return null;
    }

    public double method_5(int int_1)
    {
        GClass89 gclass = this.GetTracks()[0] as GClass89;
        GClass141 gclass2 = null;
        GClass142 gclass3 = null;
        foreach (MidiEvent gclass4 in gclass.Events())
        {
            if (gclass3 == null && gclass4.vmethod_2() == GEnum63.const_2)
            {
                gclass3 = (gclass4 as GClass142);
            }
            if (gclass2 == null && gclass4.vmethod_2() == GEnum63.const_1)
            {
                gclass2 = (gclass4 as GClass141);
            }
            if (gclass2 != null && gclass3 != null)
            {
                break;
            }
        }
        double num = 0.0;
        int num2 = 0;
        foreach (MidiEvent gclass5 in gclass.Events())
        {
            if (gclass5.vmethod_2() == GEnum63.const_2)
            {
                if (gclass5.int_0 >= int_1)
                {
                    break;
                }
                int num3 = gclass5.int_0 - num2;
                double num4 = (double)num3 * (double)gclass3.int_1 / (double)((float)this.TicksPerQuarterNote() * 1000000f);
                num += num4;
                gclass3 = (gclass5 as GClass142);
                num2 = gclass5.int_0;
            }
        }
        int num5 = int_1 - num2;
        double num6 = (double)num5 * (double)gclass3.int_1 / (double)((float)this.TicksPerQuarterNote() * 1000000f);
        num += num6;
        return num;
    }

    public int method_6(double double_0)
    {
        GClass89 gclass = this.GetTracks()[0] as GClass89;
        GClass141 gclass2 = null;
        GClass142 gclass3 = null;
        foreach (MidiEvent gclass4 in gclass.Events())
        {
            if (gclass3 == null && gclass4.vmethod_2() == GEnum63.const_2)
            {
                gclass3 = (gclass4 as GClass142);
            }
            if (gclass2 == null && gclass4.vmethod_2() == GEnum63.const_1)
            {
                gclass2 = (gclass4 as GClass141);
            }
            if (gclass2 != null && gclass3 != null)
            {
                break;
            }
        }
        double num = 0.0;
        int num2 = 0;
        foreach (MidiEvent gclass5 in gclass.Events())
        {
            int num3 = gclass5.int_0 - num2;
            if (gclass5.vmethod_2() == GEnum63.const_2)
            {
                double num4 = (double)num3 * (double)gclass3.int_1 / (double)((float)this.TicksPerQuarterNote() * 1000000f);
                if (num + num4 >= double_0)
                {
                    break;
                }
                num += num4;
                gclass3 = (gclass5 as GClass142);
                num2 = gclass5.int_0;
            }
            int num5 = gclass5.int_0;
        }
        double num6 = double_0 - num;
        double num7 = num6 * (double)this.TicksPerQuarterNote() * 1000000.0 / (double)gclass3.int_1;
        return num2 + (int)num7;
    }

    public void method_7(Stream stream_0)
    {
        BinaryWriter binaryWriter = new BinaryWriter(stream_0);
        binaryWriter.Write(1684558925u);
        binaryWriter.Write((uint)Class109.smethod_8(6u));
        binaryWriter.Write((ushort)Class109.smethod_9(1));
        binaryWriter.Write((ushort)Class109.smethod_9((ushort)this.GetTracks().Count));
        binaryWriter.Write((ushort)Class109.smethod_9((ushort)this.TicksPerQuarterNote()));
        BinaryWriter binaryWriter2 = new BinaryWriter(new MemoryStream(1024));
        BinaryWriter binaryWriter3 = new BinaryWriter(new MemoryStream(4));
        foreach (MidiTrack gclass in this.GetTracks())
        {
            binaryWriter.Write(1802654797u);
            binaryWriter.Write(0u);
            long position = binaryWriter.BaseStream.Position;
            List<MidiEvent> list = new List<MidiEvent>();
            gclass.vmethod_1(list);
            list.Sort(new GClass138());
            list.Insert(0, new GClass140(0, GEnum64.const_2, (gclass.method_1() != string.Empty) ? gclass.method_1() : "untitled"));
            byte b = 0;
            int num = 0;
            foreach (MidiEvent gclass2 in list)
            {
                binaryWriter2.Seek(0, SeekOrigin.Begin);
                int num2 = 0;
                switch (gclass2.vmethod_2())
                {
                case GEnum63.const_0:
                {
                    GClass140 gclass3 = gclass2 as GClass140;
                    num2 = (int)((GEnum64)65280 | gclass3.genum64_0);
                    binaryWriter2.Write(gclass3.string_0.ToCharArray());
                    break;
                }
                case GEnum63.const_1:
                {
                    GClass141 gclass4 = gclass2 as GClass141;
                    num2 = 65368;
                    binaryWriter2.Write((byte)gclass4.int_1);
                    binaryWriter2.Write((byte)gclass4.genum52_0);
                    binaryWriter2.Write((byte)gclass4.int_2);
                    binaryWriter2.Write((byte)gclass4.int_3);
                    break;
                }
                case GEnum63.const_2:
                {
                    GClass142 gclass5 = gclass2 as GClass142;
                    num2 = 65361;
                    binaryWriter2.Write((byte)(gclass5.int_1 >> 16));
                    binaryWriter2.Write((byte)(gclass5.int_1 >> 8));
                    binaryWriter2.Write((byte)gclass5.int_1);
                    break;
                }
                case GEnum63.const_3:
                {
                    GClass143 gclass6 = gclass2 as GClass143;
                    num2 = (gclass6.bool_0 ? 36864 : 32768);
                    binaryWriter2.Write(gclass6.byte_0);
                    binaryWriter2.Write(gclass6.byte_1);
                    break;
                }
                }
                if (num2 != 0)
                {
                    binaryWriter3.Seek(0, SeekOrigin.Begin);
                    uint num3 = (uint)(gclass2.int_0 - num);
                    do
                    {
                        byte value = (byte)(num3 & 127u);
                        binaryWriter3.Write(value);
                        num3 >>= 7;
                    }
                    while (num3 > 0u);
                    for (int i = (int)binaryWriter3.BaseStream.Position - 1; i >= 0; i--)
                    {
                        byte b2 = (binaryWriter3.BaseStream as MemoryStream).GetBuffer()[i];
                        if (i > 0)
                        {
                            b2 |= 128;
                        }
                        binaryWriter.Write(b2);
                    }
                    if (num2 >> 8 == 255)
                    {
                        binaryWriter.Write(byte.MaxValue);
                        binaryWriter.Write((byte)num2);
                        binaryWriter.Write((byte)binaryWriter2.BaseStream.Position);
                    }
                    else
                    {
                        if ((byte)(num2 >> 8) != b)
                        {
                            binaryWriter.Write((byte)(num2 >> 8));
                        }
                        b = (byte)(num2 >> 8);
                    }
                    binaryWriter.Write((binaryWriter2.BaseStream as MemoryStream).GetBuffer(), 0, (int)binaryWriter2.BaseStream.Position);
                    num = gclass2.int_0;
                }
            }
            binaryWriter.Write(0);
            binaryWriter.Write(byte.MaxValue);
            binaryWriter.Write(47);
            binaryWriter.Write(0);
            long num4 = binaryWriter.BaseStream.Position - position;
            binaryWriter.Seek((int)position - 4, SeekOrigin.Begin);
            binaryWriter.Write((uint)Class109.smethod_8((uint)num4));
            binaryWriter.Seek(0, SeekOrigin.End);
        }
    }

    void method_8(Stream stream_0)
    {
        BinaryReader binaryReader = new BinaryReader(stream_0);
        if (binaryReader.ReadUInt32() != 1684558925u)
        {
            throw new FileLoadException("Not a valid MIDI file");
        }
        Class109.smethod_8(binaryReader.ReadUInt32());
        Class109.smethod_9(binaryReader.ReadUInt16());
        int num = Class109.smethod_9(binaryReader.ReadUInt16());
        int int_ = Class109.smethod_9(binaryReader.ReadUInt16());
        this.SetTicksPerQuarterNote(int_);
        for (int i = 0; i < num; i++)
        {
            Class109.smethod_8(binaryReader.ReadUInt32());
            int num2 = Class109.smethod_8(binaryReader.ReadUInt32());
            byte b = 0;
            long position = binaryReader.BaseStream.Position;
            MidiTrack gclass = null;
            bool flag = false;
            List<MidiEvent> list = new List<MidiEvent>();
            if (i == 0)
            {
                gclass = new GClass89(this);
            }
            int num3 = 0;
            while (binaryReader.BaseStream.Position < position + (long)num2)
            {
                int num4 = 0;
                byte b2;
                do
                {
                    b2 = binaryReader.ReadByte();
                    num4 = (num4 << 7 | ((int)b2 & -129));
                }
                while ((b2 & 128) != 0);
                num3 += num4;
                byte b3 = b;
                byte b4 = binaryReader.ReadByte();
                bool flag2 = false;
                if ((b4 & 128) == 128)
                {
                    b3 = b4;
                }
                else
                {
                    flag2 = true;
                }
                int num5;
                if (b3 >> 4 != 15)
                {
                    num5 = (int)(b3 & 240) << 8;
                }
                else if (flag2)
                {
                    num5 = ((int)b3 << 8 | (int)b4);
                    flag2 = false;
                }
                else
                {
                    num5 = ((int)b3 << 8 | (int)binaryReader.ReadByte());
                }
                MidiEvent gclass2 = null;
                byte b5 = flag2 ? b4 : binaryReader.ReadByte();
                int num6 = num5;
                if (num6 <= 65286)
                {
                    if (num6 <= 45056)
                    {
                        if (num6 != 32768)
                        {
                            if (num6 != 36864)
                            {
                                if (num6 != 45056)
                                {
                                    goto IL_5B8;
                                }
                                binaryReader.ReadByte();
                            }
                            else
                            {
                                gclass2 = new GClass143();
                                (gclass2 as GClass143).byte_0 = b5;
                                (gclass2 as GClass143).byte_1 = binaryReader.ReadByte();
                                (gclass2 as GClass143).bool_0 = true;
                            }
                        }
                        else
                        {
                            gclass2 = new GClass143();
                            (gclass2 as GClass143).byte_0 = b5;
                            (gclass2 as GClass143).byte_1 = binaryReader.ReadByte();
                            (gclass2 as GClass143).bool_0 = false;
                        }
                    }
                    else if (num6 != 49152)
                    {
                        if (num6 != 57344)
                        {
                            switch (num6)
                            {
                            case 65280:
                                binaryReader.ReadByte();
                                binaryReader.ReadByte();
                                break;
                            case 65281:
                            case 65282:
                            case 65283: // Fix for parsing 'instrument name' events
                            case 65284:
                            case 65285:
                            case 65286:
                            {
                                long offset = binaryReader.BaseStream.Position + (long)((ulong)b5);
                                string text = new string(binaryReader.ReadChars((int)b5));
                                binaryReader.BaseStream.Seek(offset, SeekOrigin.Begin);
                                if ((num5 & 15) == 3)
                                {
                                    flag = true;
                                    string key;
                                    if ((key = text.ToUpper()) == null)
                                    {
                                        goto IL_3B9;
                                    }
                                    if (Class120.dictionary_3 == null)
                                    {
                                        Class120.dictionary_3 = new Dictionary<string, int>(12)
                                        {
                                            {
                                                "T1 GEMS",
                                                0
                                            },
                                            {
                                                "PART GUITAR",
                                                1
                                            },
                                            {
                                                "PART GUITAR COOP",
                                                2
                                            },
                                            {
                                                "PART BASS",
                                                3
                                            },
                                            {
                                                "PART RHYTHM",
                                                4
                                            },
                                            {
                                                "EVENTS",
                                                5
                                            },
                                            {
                                                "TRIGGERS",
                                                6
                                            },
                                            {
                                                "ANIM",
                                                7
                                            },
                                            {
                                                "BAND BASS",
                                                8
                                            },
                                            {
                                                "BAND DRUMS",
                                                9
                                            },
                                            {
                                                "BAND SINGER",
                                                10
                                            },
                                            {
                                                "BAND KEYS",
                                                11
                                            }
                                        };
                                    }
                                    int num7;
                                    if (!Class120.dictionary_3.TryGetValue(key, out num7))
                                    {
                                        goto IL_3B9;
                                    }
                                    switch (num7)
                                    {
                                    case 0:
                                    case 1:
                                    case 2:
                                    case 3:
                                    case 4:
                                        gclass = new GClass88(this, text.ToUpper());
                                        break;
                                    case 5:
                                    case 6:
                                    case 7:
                                    case 8:
                                    case 9:
                                    case 10:
                                    case 11:
                                        gclass = new GClass87(this, text.ToUpper());
                                        break;
                                    default:
                                        goto IL_3B9;
                                    }
                                    IL_3C5:
                                    if (gclass != null && gclass.method_1() == null)
                                    {
                                        gclass.method_2(text);
                                        goto IL_3DB;
                                    }
                                    goto IL_3DB;
                                    IL_3B9:
                                    if (gclass == null)
                                    {
                                        gclass = new GClass89(this);
                                        goto IL_3C5;
                                    }
                                    goto IL_3C5;
                                }
                                IL_3DB:
                                if ((num5 & 15) == 1)
                                {
                                    gclass2 = new GClass140(0, GEnum64.const_0, text);
                                }
                                break;
                            }
                            default:
                                goto IL_5B8;
                            }
                        }
                        else
                        {
                            binaryReader.ReadByte();
                        }
                    }
                }
                else if (num6 <= 65361)
                {
                    switch (num6)
                    {
                    case 65312:
                        binaryReader.ReadByte();
                        break;
                    case 65313:
                        binaryReader.ReadByte();
                        break;
                    default:
                        if (num6 != 65327)
                        {
                            if (num6 != 65361)
                            {
                                goto IL_5B8;
                            }
                            int num8 = (int)binaryReader.ReadByte() << 16;
                            num8 |= (int)binaryReader.ReadByte() << 8;
                            num8 |= (int)binaryReader.ReadByte();
                            gclass2 = new GClass142(0f);
                            (gclass2 as GClass142).int_1 = num8;
                        }
                        break;
                    }
                }
                else if (num6 != 65364)
                {
                    switch (num6)
                    {
                    case 65368:
                        gclass2 = new GClass141((int)binaryReader.ReadByte(), (GEnum52)binaryReader.ReadByte(), (int)binaryReader.ReadByte(), (int)binaryReader.ReadByte());
                        break;
                    case 65369:
                        binaryReader.ReadByte();
                        binaryReader.ReadByte();
                        break;
                    default:
                        if (num6 != 65407)
                        {
                            goto IL_5B8;
                        }
                        binaryReader.ReadBytes((int)b5);
                        break;
                    }
                }
                else
                {
                    binaryReader.ReadByte();
                    binaryReader.ReadByte();
                    binaryReader.ReadByte();
                    binaryReader.ReadByte();
                    binaryReader.ReadByte();
                }
                if (gclass2 != null)
                {
                    gclass2.int_0 = num3;
                    list.Add(gclass2);
                }
                if (b3 >> 4 != 15)
                {
                    b = b3;
                }
                if (!flag || gclass != null)
                {
                    continue;
                }
                break;
                IL_5B8:
                throw new NotImplementedException("Unhandled MIDI command: " + num5.ToString("X"));
            }
            if (gclass != null)
            {
                if (!flag)
                {
                    gclass.method_2(string.Empty);
                }
                this.GetTracks().Add(gclass);
                list.Sort(new GClass138());
                gclass.vmethod_0(list);
            }
            binaryReader.BaseStream.Seek(position + (long)num2, SeekOrigin.Begin);
        }
    }

    List<MidiTrack> tracks = new List<MidiTrack>();

    int ticksPerQuarterNote;
}
