using System;
using System.Runtime.InteropServices;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("faed3d21-1b6b-4af7-8cb6-3e189bbc187b")]
[ComImport]
public interface GInterface28 : GInterface27
{
    void imethod_21([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

    void imethod_22();

    void imethod_23([In] ulong ulong_0, [In] long long_0);

    void imethod_24([In] ushort ushort_0, [In] ulong ulong_0, [In] long long_0);

    void imethod_25([In] ushort ushort_0, out GInterface0 ginterface0_0, out ulong ulong_0, out ulong ulong_1, out uint uint_0, out uint uint_1, out ushort ushort_1);

    void imethod_26([In] ushort ushort_0, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [In] ushort[] ushort_1, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [In] GEnum14[] genum14_0);

    void imethod_27([In] ushort ushort_0, out GEnum14 genum14_0);

    void imethod_28([In] ushort ushort_0, [MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_29([In] ushort ushort_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_30([In] uint uint_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, out GEnum15 genum15_0, IntPtr intptr_0, [In] [Out] ref uint uint_1);

    void imethod_31([In] uint uint_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [In] GEnum15 genum15_0, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] [In] byte[] byte_0, [In] uint uint_1);

    void imethod_32(out uint uint_0);

    void imethod_33([In] uint uint_0, [MarshalAs(UnmanagedType.Interface)] out GInterface12 ginterface12_0);

    void imethod_34([In] uint uint_0, [MarshalAs(UnmanagedType.Interface)] [In] GInterface12 ginterface12_0);

    void imethod_35([In] uint uint_0, out uint uint_1);

    void imethod_36([In] uint uint_0, [In] uint uint_1, [MarshalAs(UnmanagedType.Interface)] out GInterface12 ginterface12_0);

    void imethod_37([In] ushort ushort_0, out uint uint_0);

    void imethod_38([In] uint uint_0, out ushort ushort_0);

    void imethod_39([In] uint uint_0, out uint uint_1);

    void imethod_40([In] ushort ushort_0, out uint uint_0);

    void imethod_41([MarshalAs(UnmanagedType.Interface)] [In] UCOMIStream ucomistream_0);

    void imethod_42([In] ushort ushort_0, [In] ref GStruct0 gstruct0_0, [In] ref GStruct0 gstruct0_1);

    void imethod_43([In] ushort ushort_0, [In] ulong ulong_0, [In] long long_0, out ulong ulong_1);

    void imethod_44([In] uint uint_0, [MarshalAs(UnmanagedType.Interface)] [In] GInterface26 ginterface26_0);

    void imethod_45([In] uint uint_0, [MarshalAs(UnmanagedType.Interface)] out GInterface26 ginterface26_0);

    void imethod_46([In] ushort ushort_0, [MarshalAs(UnmanagedType.Interface)] [In] GInterface26 ginterface26_0);

    void imethod_47([In] ushort ushort_0, [MarshalAs(UnmanagedType.Interface)] out GInterface26 ginterface26_0);
}
