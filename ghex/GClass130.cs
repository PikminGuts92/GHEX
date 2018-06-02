using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

public class GClass130 : GInterface36
{
    public GClass130()
    {
        this.list_0 = new List<GInterface35>();
        this.imethod_9();
    }

    public string imethod_0()
    {
        return "WaveOut";
    }

    public bool imethod_1()
    {
        return this.bool_1;
    }

    public AudioInfo imethod_2()
    {
        return this.gclass102_0;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void imethod_3(GDelegate12 gdelegate12_1)
    {
        this.gdelegate12_0 = (GDelegate12)Delegate.Combine(this.gdelegate12_0, gdelegate12_1);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void imethod_4(GDelegate12 gdelegate12_1)
    {
        this.gdelegate12_0 = (GDelegate12)Delegate.Remove(this.gdelegate12_0, gdelegate12_1);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void imethod_5(GDelegate13 gdelegate13_1)
    {
        this.gdelegate13_0 = (GDelegate13)Delegate.Combine(this.gdelegate13_0, gdelegate13_1);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void imethod_6(GDelegate13 gdelegate13_1)
    {
        this.gdelegate13_0 = (GDelegate13)Delegate.Remove(this.gdelegate13_0, gdelegate13_1);
    }

    public void imethod_7(GInterface35 ginterface35_0)
    {
        this.list_0.Add(ginterface35_0);
    }

    public void imethod_8(GInterface35 ginterface35_0)
    {
        this.list_0.Remove(ginterface35_0);
    }

    public void imethod_9()
    {
        this.gclass102_0 = new AudioInfo(44100, 16, 2);
        this.uint_0 = (uint)(30 * this.gclass102_0.bitrate / 1000);
        this.int_0 = 5;
        this.bool_2 = true;
    }

    public void imethod_10()
    {
        if (this.bool_1)
        {
            return;
        }
        if (this.thread_0 != null)
        {
            this.thread_0.Join(-1);
        }
        this.thread_0 = new Thread(new ThreadStart(this.method_0));
        this.thread_0.Name = "WaveOutThread";
        this.thread_0.IsBackground = true;
        this.bool_1 = true;
        this.bool_0 = false;
        this.thread_0.Start();
    }

    public bool imethod_11(int int_1)
    {
        if (!this.bool_1)
        {
            return true;
        }
        this.bool_0 = true;
        return this.thread_0.Join(int_1);
    }

    void method_0()
    {
        IntPtr intptr_ = (IntPtr)0;
        uint num = 0u;
        int millisecondsTimeout = 20;
        Class95[] array = null;
        try
        {
            GStruct5 gstruct = default(GStruct5);
            gstruct.ushort_0 = 1;
            gstruct.ushort_1 = (ushort)this.gclass102_0.channels;
            gstruct.ushort_3 = (ushort)this.gclass102_0.bits;
            gstruct.uint_0 = (uint)this.gclass102_0.bitrate;
            gstruct.ushort_2 = (ushort)(gstruct.ushort_1 * gstruct.ushort_3 >> 3);
            gstruct.uint_1 = gstruct.uint_0 * (uint)gstruct.ushort_2;
            gstruct.ushort_4 = 0;
            millisecondsTimeout = 20;
            Console.WriteLine("starting up, pollQuantum=" + millisecondsTimeout.ToString());
            array = new Class95[this.int_0];
            uint num2 = 0u;
            while ((ulong)num2 < (ulong)((long)this.int_0))
            {
                array[(int)((UIntPtr)num2)] = new Class95();
                num2 += 1u;
            }
            foreach (Class95 @class in array)
            {
                @class.gstruct4_0.uint_0 = this.uint_0 * (uint)gstruct.ushort_2;
                @class.gstruct4_0.genum37_0 = GEnum37.flag_0;
                @class.gstruct4_0.uint_2 = 0u;
                @class.int_0 = new int[@class.gstruct4_0.uint_0 / 2u];
                @class.intptr_0 = Marshal.AllocHGlobal((int)(@class.gstruct4_0.uint_0 / 2u));
            }
            GClass103 gclass = new GClass103(this.gclass102_0, this.uint_0);
            if (this.gdelegate12_0 != null)
            {
                this.gdelegate12_0();
            }
            if (GClass78.waveOutOpen(ref intptr_, num, ref gstruct, (IntPtr)0, (IntPtr)0, 0u) != GEnum35.const_0)
            {
                throw new GException0("Failed to open device!");
            }
            if (GClass78.waveOutPause(intptr_) != GEnum35.const_0)
            {
                throw new GException0("Failed to pause device!");
            }
            int num3 = 0;
            uint num4 = 0u;
            bool flag = true;
            bool flag2 = false;
            while (!flag2)
            {
                if (this.list_0.Count == 0)
                {
                    this.bool_0 = true;
                }
                if (this.bool_0)
                {
                    if (GClass78.waveOutPause(intptr_) != GEnum35.const_0)
                    {
                        throw new GException0("Failed to pause device!");
                    }
                    if (GClass78.waveOutReset(intptr_) != GEnum35.const_0)
                    {
                        throw new GException0("Failed to reset device!");
                    }
                    flag2 = true;
                    Console.WriteLine("  done due to m_stop==true");
                }
                uint num5 = 0u;
                foreach (Class95 class2 in array)
                {
                    if ((class2.gstruct4_0.genum37_0 & GEnum37.flag_0) == (GEnum37)0u)
                    {
                        num5 += 1u;
                    }
                }
                uint num6 = 0u;
                foreach (Class95 class3 in array)
                {
                    if ((class3.gstruct4_0.genum37_0 & GEnum37.flag_0) == (GEnum37)0u)
                    {
                        flag2 = false;
                    }
                    else
                    {
                        if ((class3.gstruct4_0.genum37_0 & GEnum37.flag_1) != (GEnum37)0u)
                        {
                            GEnum35 genum = GClass78.waveOutUnprepareHeader(intptr_, ref class3.gstruct4_0, Marshal.SizeOf(class3.gstruct4_0));
                            if (genum != GEnum35.const_0)
                            {
                                throw new GException0("waveOutUnprepareHeader() failed: " + genum.ToString());
                            }
                        }
                        if (!flag2 && num3 <= 0)
                        {
                            foreach (GInterface35 ginterface in this.list_0)
                            {
                                GEnum48 genum2 = ginterface.imethod_0(gclass);
                                if (genum2 == GEnum48.const_1)
                                {
                                    break;
                                }
                            }
                            GClass80.smethod_2(gclass.method_3(GEnum47.const_0), gclass.method_3(GEnum47.const_1), ref class3.int_0, gclass.method_0());
                            Marshal.Copy(class3.int_0, 0, class3.intptr_0, gclass.method_0());
                            class3.gstruct4_0.intptr_0 = class3.intptr_0;
                            class3.gstruct4_0.uint_0 = this.uint_0 * (uint)gstruct.ushort_2;
                            class3.gstruct4_0.uint_2 = 0u;
                            class3.gstruct4_0.genum37_0 = (GEnum37)0u;
                            if (GClass78.waveOutPrepareHeader(intptr_, ref class3.gstruct4_0, Marshal.SizeOf(class3.gstruct4_0)) != GEnum35.const_0)
                            {
                                throw new GException0("waveOutPrepareHeader() failed");
                            }
                            if (flag)
                            {
                                flag = false;
                                if (GClass78.waveOutRestart(intptr_) != GEnum35.const_0)
                                {
                                    throw new GException0("Failed to resume device!");
                                }
                                Console.WriteLine("  {0}: first block", num6);
                            }
                            try
                            {
                                if (GClass78.waveOutWrite(intptr_, ref class3.gstruct4_0, Marshal.SizeOf(class3.gstruct4_0)) != GEnum35.const_0)
                                {
                                    throw new GException0("waveOutWrite() failed");
                                }
                                goto IL_462;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("WaveOut Driver Exception (Write): " + ex.Message);
                                goto IL_462;
                            }
                            IL_40E:
                            if ((ulong)(num6 + num5 + 1u) != (ulong)((long)array.Length))
                            {
                                goto IL_424;
                            }
                            break;
                            IL_462:
                            num6 += 1u;
                            if (num6 > 1u)
                            {
                                goto IL_40E;
                            }
                        }
                        else
                        {
                            num3--;
                        }
                    }
                    IL_424:;
                }
                if ((ulong)num5 == (ulong)((long)array.Length))
                {
                    num4 += 1u;
                    if (num4 > 2u)
                    {
                        num4 = 0u;
                        Console.WriteLine("  no blocks done, yielding");
                    }
                }
                if (!flag2)
                {
                    Thread.Sleep(millisecondsTimeout);
                }
            }
        }
        catch (Exception ex2)
        {
            Console.WriteLine("WaveOut Driver Exception: " + ex2.Message);
        }
        finally
        {
            if (GClass78.waveOutClose(intptr_) != GEnum35.const_0)
            {
                throw new GException0("Failed to close device!");
            }
            Console.WriteLine("stopping");
            if (this.gdelegate13_0 != null)
            {
                this.gdelegate13_0();
            }
            this.bool_1 = false;
        }
    }

    Thread thread_0;

    bool bool_0;

    bool bool_1;

    AudioInfo gclass102_0;

    uint uint_0;

    int int_0;

    bool bool_2;

    GDelegate12 gdelegate12_0;

    GDelegate13 gdelegate13_0;

    List<GInterface35> list_0;
}
