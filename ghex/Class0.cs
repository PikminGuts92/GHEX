using System;
using System.Runtime.InteropServices;

class Class0 : GInterface0
{
    public Class0(uint uint_2)
    {
        this.byte_0 = new byte[uint_2];
        this.uint_0 = uint_2;
        this.uint_1 = uint_2;
        this.gchandle_0 = GCHandle.Alloc(this.byte_0, GCHandleType.Pinned);
    }

    ~Class0()
    {
        this.gchandle_0.Free();
    }

    public uint method_0()
    {
        return this.uint_0;
    }

    public void method_1(uint uint_2)
    {
        if (uint_2 > this.uint_1)
        {
            throw new ArgumentException();
        }
        this.uint_0 = uint_2;
    }

    public uint method_2()
    {
        return this.uint_1;
    }

    public byte[] method_3()
    {
        return this.byte_0;
    }

    public void imethod_0(out uint uint_2)
    {
        uint_2 = this.uint_0;
    }

    public void imethod_1(uint uint_2)
    {
        this.method_1(uint_2);
    }

    public void imethod_2(out uint uint_2)
    {
        uint_2 = this.uint_1;
    }

    public void imethod_3(out IntPtr intptr_0)
    {
        intptr_0 = this.gchandle_0.AddrOfPinnedObject();
    }

    public void imethod_4(out IntPtr intptr_0, out uint uint_2)
    {
        intptr_0 = this.gchandle_0.AddrOfPinnedObject();
        uint_2 = this.uint_0;
    }

    uint uint_0;

    uint uint_1;

    byte[] byte_0;

    GCHandle gchandle_0;
}
