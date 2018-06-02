using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

[DefaultMember("Attributes")]
public class GClass131
{
    public GClass131(GInterface19 ginterface19_1)
    {
        this.ginterface19_0 = ginterface19_1;
    }

    public GInterface19 method_0()
    {
        return this.ginterface19_0;
    }

    public void method_1(GStruct10 gstruct10_0)
    {
        this.ginterface19_0.imethod_6(gstruct10_0.string_0, gstruct10_0.ulong_0);
    }

    public GStruct10 method_2(int int_0)
    {
        ushort capacity = 0;
        ulong ulong_;
        this.ginterface19_0.imethod_5((ushort)int_0, null, ref capacity, out ulong_);
        StringBuilder stringBuilder = new StringBuilder((int)capacity);
        this.ginterface19_0.imethod_5((ushort)int_0, stringBuilder, ref capacity, out ulong_);
        return new GStruct10(stringBuilder.ToString(), ulong_);
    }

    public void method_3(int int_0)
    {
        this.ginterface19_0.imethod_7((ushort)int_0);
    }

    public void method_4(GStruct11 gstruct11_0)
    {
        this.ginterface19_0.imethod_10(gstruct11_0.string_0, gstruct11_0.string_1, gstruct11_0.ulong_0);
    }

    public GStruct11 method_5(int int_0)
    {
        ushort capacity = 0;
        ushort capacity2 = 0;
        ulong ulong_;
        this.ginterface19_0.imethod_9((ushort)int_0, null, ref capacity2, null, ref capacity, out ulong_);
        StringBuilder stringBuilder = new StringBuilder((int)capacity);
        StringBuilder stringBuilder2 = new StringBuilder((int)capacity2);
        this.ginterface19_0.imethod_9((ushort)int_0, stringBuilder2, ref capacity2, stringBuilder, ref capacity, out ulong_);
        return new GStruct11(stringBuilder2.ToString(), stringBuilder.ToString(), ulong_);
    }

    public void method_6(int int_0)
    {
        this.ginterface19_0.imethod_11((ushort)int_0);
    }

    public int method_7()
    {
        ushort result;
        this.ginterface19_0.imethod_8(out result);
        return (int)result;
    }

    public int method_8()
    {
        ushort result;
        this.ginterface19_0.imethod_4(out result);
        return (int)result;
    }

    public int method_9(int int_0)
    {
        ushort result;
        this.ginterface19_0.imethod_0((ushort)int_0, out result);
        return (int)result;
    }

    public int method_10()
    {
        return this.method_9(0);
    }

    public GStruct12 method_11(int int_0, int int_1)
    {
        ushort num = (ushort)int_0;
        ushort capacity = 0;
        ushort num2 = 0;
        GEnum15 genum;
        this.ginterface19_0.imethod_1((ushort)int_1, ref num, null, ref capacity, out genum, IntPtr.Zero, ref num2);
        StringBuilder stringBuilder = new StringBuilder((int)capacity);
        object obj;
        switch (genum)
        {
        case GEnum15.const_0:
        case GEnum15.const_3:
            obj = 0u;
            break;
        case GEnum15.const_1:
        case GEnum15.const_2:
            obj = new byte[(int)num2];
            break;
        case GEnum15.const_4:
            obj = 0UL;
            break;
        case GEnum15.const_5:
            obj = 0;
            break;
        case GEnum15.const_6:
            obj = Guid.NewGuid();
            break;
        default:
            throw new InvalidOperationException(string.Format("Not supported data type: {0}", genum.ToString()));
        }
        GCHandle gchandle = GCHandle.Alloc(obj, GCHandleType.Pinned);
        try
        {
            IntPtr intPtr = gchandle.AddrOfPinnedObject();
            this.ginterface19_0.imethod_1((ushort)int_1, ref num, stringBuilder, ref capacity, out genum, intPtr, ref num2);
            switch (genum)
            {
            case GEnum15.const_1:
                obj = Marshal.PtrToStringUni(intPtr);
                break;
            case GEnum15.const_3:
                obj = ((uint)obj != 0u);
                break;
            }
        }
        finally
        {
            gchandle.Free();
        }
        return new GStruct12(stringBuilder.ToString(), genum, obj);
    }

    public GStruct12 method_12(int int_0)
    {
        return this.method_11(0, int_0);
    }

    public GStruct12 method_13(int int_0, string string_0)
    {
        ushort num = (ushort)int_0;
        ushort num2 = 0;
        GEnum15 genum;
        this.ginterface19_0.imethod_2(ref num, string_0, out genum, IntPtr.Zero, ref num2);
        object obj;
        switch (genum)
        {
        case GEnum15.const_0:
        case GEnum15.const_3:
            obj = 0u;
            break;
        case GEnum15.const_1:
        case GEnum15.const_2:
            obj = new byte[(int)num2];
            break;
        case GEnum15.const_4:
            obj = 0UL;
            break;
        case GEnum15.const_5:
            obj = 0;
            break;
        case GEnum15.const_6:
            obj = Guid.NewGuid();
            break;
        default:
            throw new InvalidOperationException(string.Format("Not supported data type: {0}", genum.ToString()));
        }
        GCHandle gchandle = GCHandle.Alloc(obj, GCHandleType.Pinned);
        try
        {
            IntPtr intPtr = gchandle.AddrOfPinnedObject();
            this.ginterface19_0.imethod_2(ref num, string_0, out genum, intPtr, ref num2);
            switch (genum)
            {
            case GEnum15.const_1:
                obj = Marshal.PtrToStringUni(intPtr);
                break;
            case GEnum15.const_3:
                obj = ((uint)obj != 0u);
                break;
            }
        }
        finally
        {
            gchandle.Free();
        }
        return new GStruct12(string_0, genum, obj);
    }

    public GStruct12 method_14(string string_0)
    {
        return this.method_13(0, string_0);
    }

    public void method_15(int int_0, GStruct12 gstruct12_0)
    {
        object obj;
        ushort ushort_;
        switch (gstruct12_0.method_1())
        {
        case GEnum15.const_0:
            obj = GStruct12.smethod_7(gstruct12_0);
            ushort_ = 4;
            break;
        case GEnum15.const_1:
        {
            byte[] bytes = Encoding.Unicode.GetBytes((string)gstruct12_0.method_2() + '\0');
            obj = bytes;
            ushort_ = (ushort)bytes.Length;
            break;
        }
        case GEnum15.const_2:
            obj = (byte[])gstruct12_0.method_2();
            ushort_ = (ushort)((byte[])obj).Length;
            break;
        case GEnum15.const_3:
            obj = (GStruct12.smethod_1(gstruct12_0) ? 1u : 0u);
            ushort_ = 4;
            break;
        case GEnum15.const_4:
            obj = GStruct12.smethod_4(gstruct12_0);
            ushort_ = 8;
            break;
        case GEnum15.const_5:
            obj = GStruct12.smethod_8(gstruct12_0);
            ushort_ = 2;
            break;
        case GEnum15.const_6:
            obj = GStruct12.smethod_2(gstruct12_0);
            ushort_ = (ushort)Marshal.SizeOf(typeof(Guid));
            break;
        default:
            throw new ArgumentException("Invalid data type", "attr");
        }
        GCHandle gchandle = GCHandle.Alloc(obj, GCHandleType.Pinned);
        try
        {
            this.ginterface19_0.imethod_3((ushort)int_0, gstruct12_0.method_0(), gstruct12_0.method_1(), gchandle.AddrOfPinnedObject(), ushort_);
        }
        finally
        {
            gchandle.Free();
        }
    }

    public void method_16(GStruct12 gstruct12_0)
    {
        this.method_15(0, gstruct12_0);
    }

    public GStruct12 method_17(int int_0)
    {
        return this.method_12(int_0);
    }

    public GStruct12 method_18(string string_0)
    {
        return this.method_14(string_0);
    }

    public void method_19(string string_0, GStruct12 gstruct12_0)
    {
        this.method_16(gstruct12_0);
    }

    GInterface19 ginterface19_0;
}
