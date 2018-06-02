using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

[DefaultMember("Attributes")]
public class GStream0 : Stream, IDisposable
{
    public GStream0(string string_0, WaveFormat gclass94_1)
    {
        this.ginterface27_0 = GClass54.smethod_1(GEnum23.flag_0);
        try
        {
            this.ginterface27_0.imethod_0(string_0);
            this.method_8(gclass94_1);
        }
        catch
        {
            try
            {
                this.ginterface27_0.imethod_1();
            }
            catch
            {
            }
            this.ginterface27_0 = null;
            throw;
        }
    }

    public GStream0(string string_0) : this(string_0, null)
    {
    }

    ~GStream0()
    {
        this.method_9(false);
    }

    public WaveFormat method_0()
    {
        return new WaveFormat(this.gclass94_0.int_0, (int)this.gclass94_0.short_3, (int)this.gclass94_0.short_1);
    }

    public GInterface41 method_1()
    {
        return (GInterface41)this.ginterface27_0;
    }

    public GInterface19 method_2()
    {
        return (GInterface19)this.ginterface27_0;
    }

    public int method_3()
    {
        return (int)this.uint_3;
    }

    public long method_4()
    {
        return Math.Max(this.method_5(1UL), (long)this.gclass94_0.short_2);
    }

    protected long method_5(ulong ulong_0)
    {
        ulong num = ulong_0 * (ulong)((long)this.gclass94_0.int_1) / 10000000UL;
        return (long)(num - num % (ulong)((long)this.gclass94_0.short_2));
    }

    protected ulong method_6(long long_2)
    {
        long_2 -= long_2 % (long)this.gclass94_0.short_2;
        return (ulong)(long_2 * 10000000L / (long)this.gclass94_0.int_1);
    }

    public string method_7(string string_0)
    {
        GClass131 gclass = new GClass131(this.method_2());
        string result;
        try
        {
            result = gclass.method_18(string_0).method_2().ToString();
        }
        catch (COMException ex)
        {
            if (ex.ErrorCode != -1072887824)
            {
                throw ex;
            }
            result = null;
        }
        return result;
    }

    void method_8(WaveFormat gclass94_1)
    {
        this.uint_2 = GStream0.smethod_0(this.ginterface27_0);
        if (this.uint_2 == 4294967295u)
        {
            throw new ArgumentException("An audio stream was not found");
        }
        int[] array = GStream0.smethod_1(this.ginterface27_0, this.uint_2);
        if (array.Length == 0)
        {
            throw new ArgumentException("An audio stream was not found");
        }
        if (gclass94_1 != null)
        {
            this.int_0 = -1;
            int i = 0;
            while (i < array.Length)
            {
                WaveFormat gclass = GStream0.smethod_2(this.ginterface27_0, this.uint_2, (uint)array[i]);
                if (gclass.short_0 == gclass94_1.short_0 && gclass.int_1 == gclass94_1.int_1 && gclass.short_2 == gclass94_1.short_2 && gclass.short_1 == gclass94_1.short_1 && gclass.int_0 == gclass94_1.int_0 && gclass.short_3 == gclass94_1.short_3)
                {
                    this.int_0 = array[i];
                    this.gclass94_0 = gclass;

                    if (this.int_0 < 0)
                    {
                        throw new ArgumentException("No PCM output found");
                    }
                    goto IL_116;
                }
                else
                {
                    i++;
                }
            }

            if (this.int_0 < 0)
            {
                throw new ArgumentException("No PCM output found");
            }
            goto IL_116;
        }
        this.int_0 = array[0];
        this.gclass94_0 = GStream0.smethod_2(this.ginterface27_0, this.uint_2, (uint)array[0]);
        IL_116:
        uint num = 0u;
        this.ginterface27_0.imethod_11(out num);
        ushort[] array2 = new ushort[num];
        GEnum14[] array3 = new GEnum14[num];
        for (uint num2 = 0u; num2 < num; num2 += 1u)
        {
            this.ginterface27_0.imethod_17(num2, out array2[(int)((UIntPtr)num2)]);
            if (num2 == this.uint_2)
            {
                array3[(int)((UIntPtr)num2)] = GEnum14.const_2;
                this.ushort_0 = array2[(int)((UIntPtr)num2)];
                this.ginterface27_0.imethod_7(this.ushort_0, false);
            }
            else
            {
                array3[(int)((UIntPtr)num2)] = GEnum14.const_0;
            }
        }
        this.ginterface27_0.imethod_5((ushort)num, array2, array3);
        GInterface12 ginterface = null;
        this.ginterface27_0.imethod_15(this.uint_2, (uint)this.int_0, out ginterface);
        this.ginterface27_0.imethod_13(this.uint_2, ginterface);
        uint cb = 0u;
        ginterface.imethod_4(IntPtr.Zero, ref cb);
        IntPtr intPtr = Marshal.AllocCoTaskMem((int)cb);
        try
        {
            ginterface.imethod_4(intPtr, ref cb);
            this.uint_3 = ((GStruct2)Marshal.PtrToStructure(intPtr, typeof(GStruct2))).uint_0;
        }
        finally
        {
            Marshal.FreeCoTaskMem(intPtr);
            ginterface = null;
        }
        this.bool_0 = false;
        this.long_1 = -1L;
        GClass131 gclass2 = new GClass131(this.method_2());
        try
        {
            this.bool_0 = GStruct12.smethod_1(gclass2.method_18("Seekable"));
            this.long_1 = this.method_5(GStruct12.smethod_4(gclass2.method_18("Duration")));
        }
        catch (COMException ex)
        {
            if (ex.ErrorCode != -1072887824)
            {
                throw ex;
            }
        }
    }

    static uint smethod_0(GInterface27 ginterface27_1)
    {
        uint result = uint.MaxValue;
        uint num = 0u;
        ginterface27_1.imethod_11(out num);
        for (uint num2 = 0u; num2 < num; num2 += 1u)
        {
            GInterface12 ginterface = null;
            ginterface27_1.imethod_12(num2, out ginterface);
            Guid a;
            ginterface.imethod_3(out a);
            if (a == GClass67.smethod_41())
            {
                result = num2;
                return result;
            }
        }
        return result;
    }

    static int[] smethod_1(GInterface27 ginterface27_1, uint uint_4)
    {
        ArrayList arrayList = new ArrayList();
        uint num = 0u;
        ginterface27_1.imethod_14(uint_4, out num);
        int num2 = Marshal.SizeOf(typeof(GStruct2)) + Marshal.SizeOf(typeof(WaveFormat));
        IntPtr intPtr = Marshal.AllocCoTaskMem(num2);
        try
        {
            int num3 = 0;
            while ((long)num3 < (long)((ulong)num))
            {
                GInterface12 ginterface = null;
                uint num4 = 0u;
                ginterface27_1.imethod_15(uint_4, (uint)num3, out ginterface);
                ginterface.imethod_4(IntPtr.Zero, ref num4);
                if (num4 > (uint)num2)
                {
                    num2 = (int)num4;
                    Marshal.FreeCoTaskMem(intPtr);
                    intPtr = Marshal.AllocCoTaskMem(num2);
                }
                ginterface.imethod_4(intPtr, ref num4);
                GStruct2 gstruct = (GStruct2)Marshal.PtrToStructure(intPtr, typeof(GStruct2));
                if (gstruct.guid_0 == GClass67.smethod_41() && gstruct.guid_1 == GClass67.smethod_29() && gstruct.guid_2 == GClass67.smethod_18() && gstruct.uint_1 >= 18u)
                {
                    arrayList.Add(num3);
                }
                num3++;
            }
        }
        finally
        {
            Marshal.FreeCoTaskMem(intPtr);
        }
        return (int[])arrayList.ToArray(typeof(int));
    }

    static WaveFormat smethod_2(GInterface27 ginterface27_1, uint uint_4, uint uint_5)
    {
        GInterface12 ginterface = null;
        uint val = 0u;
        WaveFormat gclass = null;
        ginterface27_1.imethod_15(uint_4, uint_5, out ginterface);
        ginterface.imethod_4(IntPtr.Zero, ref val);
        IntPtr intPtr = Marshal.AllocCoTaskMem(Math.Max((int)val, Marshal.SizeOf(typeof(GStruct2)) + Marshal.SizeOf(typeof(WaveFormat))));
        try
        {
            ginterface.imethod_4(intPtr, ref val);
            GStruct2 gstruct = (GStruct2)Marshal.PtrToStructure(intPtr, typeof(GStruct2));
            if (!(gstruct.guid_0 == GClass67.smethod_41()) || !(gstruct.guid_1 == GClass67.smethod_29()) || !(gstruct.guid_2 == GClass67.smethod_18()) || gstruct.uint_1 < 18u)
            {
                throw new ArgumentException(string.Format("The format {0} of the output {1} is not a valid PCM format", uint_5, uint_4));
            }
            gclass = new WaveFormat(44100, 16, 2);
            Marshal.PtrToStructure(gstruct.intptr_1, gclass);
        }
        finally
        {
            Marshal.FreeCoTaskMem(intPtr);
        }
        return gclass;
    }

    public override void Close()
    {
        if (this.ginterface27_0 != null)
        {
            this.ginterface27_0.imethod_1();
            this.ginterface27_0 = null;
        }
        base.Close();
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
        if (this.ginterface27_0 != null)
        {
            int i = 0;
            if (this.long_1 > 0L && this.long_1 - this.long_0 < (long)count)
            {
                count = (int)(this.long_1 - this.long_0);
            }
            if (this.gclass0_0 != null)
            {
                while (this.gclass0_0.method_2() < this.gclass0_0.method_0() && i < count)
                {
                    i += this.gclass0_0.method_5(buffer, offset, count);
                }
            }
            while (i < count)
            {
                GInterface0 ginterface0_ = null;
                ulong num = 0UL;
                ulong num2 = 0UL;
                uint num3 = 0u;
                try
                {
                    this.ginterface27_0.imethod_4(this.ushort_0, out ginterface0_, out num, out num2, out num3, out this.uint_2, out this.ushort_0);
                }
                catch (COMException ex)
                {
                    if (ex.ErrorCode == -1072886833)
                    {
                        if (this.gclass94_0.short_3 == 8)
                        {
                            while (i < count)
                            {
                                buffer[offset + i] = 128;
                                i++;
                            }
                        }
                        else
                        {
                            Array.Clear(buffer, offset + i, count - i);
                            i = count;
                        }
                        break;
                    }
                    throw ex;
                }
                this.gclass0_0 = new GClass0(ginterface0_);
                i += this.gclass0_0.method_5(buffer, offset + i, count - i);
            }
            if (this.gclass0_0 != null && this.gclass0_0.method_2() >= this.gclass0_0.method_0())
            {
                this.gclass0_0 = null;
            }
            this.long_0 += (long)i;
            return i;
        }
        throw new ObjectDisposedException(this.ToString());
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
        throw new NotSupportedException();
    }

    public override long Seek(long offset, SeekOrigin origin)
    {
        if (!this.CanSeek)
        {
            throw new NotSupportedException();
        }
        switch (origin)
        {
        case SeekOrigin.Current:
            offset += this.long_0;
            break;
        case SeekOrigin.End:
            offset += this.long_1;
            break;
        }
        if (offset == this.long_0)
        {
            return this.long_0;
        }
        if (offset < 0L || offset > this.long_1)
        {
            throw new ArgumentException("Offset out of range", "offset");
        }
        if (offset % this.method_4() > 0L)
        {
            throw new ArgumentException(string.Format("Offset must be aligned by a value of SeekAlign ({0})", this.method_4()), "offset");
        }
        ulong ulong_ = this.method_6(offset);
        this.ginterface27_0.imethod_2(ulong_, 0L);
        this.long_0 = offset;
        this.gclass0_0 = null;
        return offset;
    }

    public override void Flush()
    {
    }

    public override void SetLength(long value)
    {
        throw new NotSupportedException();
    }

    public override bool CanRead
    {
        get
        {
            if (this.ginterface27_0 == null)
            {
                throw new ObjectDisposedException(this.ToString());
            }
            return true;
        }
    }

    public override bool CanSeek
    {
        get
        {
            if (this.ginterface27_0 != null)
            {
                return this.bool_0 && this.long_1 > 0L;
            }
            throw new ObjectDisposedException(this.ToString());
        }
    }

    public override bool CanWrite
    {
        get
        {
            return false;
        }
    }

    public override long Length
    {
        get
        {
            if (this.ginterface27_0 == null)
            {
                throw new ObjectDisposedException(this.ToString());
            }
            if (!this.CanSeek)
            {
                throw new NotSupportedException();
            }
            return this.long_1;
        }
    }

    public override long Position
    {
        get
        {
            if (this.ginterface27_0 == null)
            {
                throw new ObjectDisposedException(this.ToString());
            }
            return this.long_0;
        }
        set
        {
            this.Seek(value, SeekOrigin.Begin);
        }
    }

    void method_9(bool bool_1)
    {
        if (bool_1)
        {
            this.Close();
        }
    }

    public new void Dispose()
    {
        this.method_9(true);
        GC.SuppressFinalize(this);
    }

    const uint uint_0 = 4294967295u;

    protected const uint uint_1 = 18u;

    GInterface27 ginterface27_0;

    uint uint_2;

    ushort ushort_0;

    int int_0;

    long long_0;

    long long_1 = -1L;

    bool bool_0;

    uint uint_3;

    WaveFormat gclass94_0;

    GClass0 gclass0_0;
}
