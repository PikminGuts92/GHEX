using System;
using System.Runtime.InteropServices;
using System.Text;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("ae14a945-b90c-4d0d-9127-80d665f7d73e")]
[ComImport]
public interface GInterface32 : GInterface31
{
    void imethod_20([MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_21([MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_22([In] ulong ulong_0);

    void imethod_23([MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_24([MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_25([In] ushort ushort_0, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [In] ushort[] ushort_1, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [In] GEnum14[] genum14_0);

    void imethod_26([In] ushort ushort_0, out GEnum14 genum14_0);

    void imethod_27([MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_28([MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_29([In] ushort ushort_0, [MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_30([In] ushort ushort_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_31([In] uint uint_0, [MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_32([In] uint uint_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_33([In] ushort ushort_0, [MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_34([In] ushort ushort_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_35([In] [Out] ref GStruct8 gstruct8_0);

    void imethod_36([In] ref GStruct7 gstruct7_0);

    void imethod_37([In] uint uint_0, out uint uint_1);

    void imethod_38([In] ushort ushort_0, out uint uint_0);

    void imethod_39(ulong ulong_0);

    void imethod_40([In] GEnum20 genum20_0);

    void imethod_41(out GEnum20 genum20_0);

    void imethod_42(out uint uint_0, out ulong ulong_0);

    void imethod_43(out uint uint_0, out ulong ulong_0, out ulong ulong_1);

    void imethod_44(out uint uint_0);

    void imethod_45([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

    void imethod_46([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref uint uint_0);

    void imethod_47([In] ushort ushort_0, [In] ulong ulong_0, [In] float float_0, [In] IntPtr intptr_0);

    void imethod_48([In] uint uint_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, out GEnum15 genum15_0, [MarshalAs(UnmanagedType.LPArray)] [Out] byte[] byte_0, [In] [Out] ref ushort ushort_0);

    void imethod_49([In] uint uint_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [In] GEnum15 genum15_0, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] [In] byte[] byte_0, [In] ushort ushort_0);

    void imethod_50([In] ulong ulong_0, [In] ulong ulong_1, [In] float float_0);

    void imethod_51([MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_52([MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_53();

    void imethod_54([MarshalAs(UnmanagedType.Interface)] [In] UCOMIStream ucomistream_0, [MarshalAs(UnmanagedType.Interface)] [In] GInterface29 ginterface29_0, [In] IntPtr intptr_0);
}
