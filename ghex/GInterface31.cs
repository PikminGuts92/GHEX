using System;
using System.Runtime.InteropServices;

[Guid("96406BEA-2B2B-11d3-B36B-00C04F6108FF")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface GInterface31
{
    void imethod_0([MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_1([MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_2([In] ulong ulong_0);

    void imethod_3([MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_4([MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_5([In] ushort ushort_0, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [In] ushort[] ushort_1, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [In] GEnum14[] genum14_0);

    void imethod_6([In] ushort ushort_0, out GEnum14 genum14_0);

    void imethod_7([MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_8([MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_9([In] ushort ushort_0, [MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_10([In] ushort ushort_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_11([In] uint uint_0, [MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_12([In] uint uint_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_13([In] ushort ushort_0, [MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_14([In] ushort ushort_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_15([In] [Out] ref GStruct8 gstruct8_0);

    void imethod_16([In] ref GStruct7 gstruct7_0);

    void imethod_17([In] uint uint_0, out uint uint_1);

    void imethod_18([In] ushort ushort_0, out uint uint_0);

    void imethod_19(ulong ulong_0);
}
