using System;
using System.Runtime.InteropServices;

public class GClass0
{
    public GClass0(GInterface0 ginterface0_1)
    {
        this.ginterface0_0 = ginterface0_1;
        this.ginterface0_0.imethod_4(out this.intptr_0, out this.uint_0);
        this.ginterface0_0.imethod_2(out this.uint_1);
    }

    public uint method_0()
    {
        return this.uint_0;
    }

    public void method_1(uint uint_3)
    {
        if (uint_3 > this.uint_1)
        {
            throw new ArgumentOutOfRangeException();
        }
        this.ginterface0_0.imethod_1(uint_3);
        this.uint_0 = uint_3;
        if (this.uint_2 > this.uint_0)
        {
            this.uint_2 = this.uint_0;
            return;
        }
    }

    public uint method_2()
    {
        return this.uint_2;
    }

    public void method_3(uint uint_3)
    {
        if (uint_3 > this.uint_0)
        {
            throw new ArgumentOutOfRangeException();
        }
        this.uint_2 = uint_3;
    }

    public GInterface0 method_4()
    {
        return this.ginterface0_0;
    }

    public int method_5(byte[] byte_0, int int_0, int int_1)
    {
        if (this.uint_2 < this.uint_0)
        {
            IntPtr source = (IntPtr)((long)this.intptr_0.ToInt32() + (long)((ulong)this.uint_2));
            int num = Math.Min(int_1, (int)(this.method_0() - this.method_2()));
            Marshal.Copy(source, byte_0, int_0, num);
            this.uint_2 += (uint)num;
            return num;
        }
        return 0;
    }

    public void method_6(byte[] byte_0, int int_0, int int_1)
    {
        if (byte_0 == null)
        {
            throw new ArgumentNullException("buffer");
        }
        if (int_0 < 0)
        {
            throw new ArgumentOutOfRangeException("offset");
        }
        if (int_1 <= 0 || (ulong)this.uint_2 + (ulong)((long)int_1) > (ulong)this.uint_0)
        {
            throw new ArgumentOutOfRangeException("count");
        }
        IntPtr destination = (IntPtr)((long)this.intptr_0.ToInt32() + (long)((ulong)this.uint_2));
        Marshal.Copy(byte_0, int_0, destination, int_1);
        this.uint_2 += (uint)int_1;
    }

    GInterface0 ginterface0_0;

    uint uint_0;

    uint uint_1;

    IntPtr intptr_0;

    uint uint_2;
}
