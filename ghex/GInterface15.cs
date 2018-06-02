using System;
using System.Runtime.InteropServices;
using System.Text;

[Guid("0302B57D-89D1-4ba2-85C9-166F2C53EB91")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface GInterface15 : GInterface14
{
    void imethod_8([MarshalAs(UnmanagedType.LPArray)] [Out] ushort[] ushort_0, [In] [Out] ref ushort ushort_1);

    void imethod_9([In] ushort ushort_0);

    void imethod_10([In] ushort ushort_0);

    void imethod_11(out Guid guid_0);

    void imethod_12([In] ref Guid guid_0);

    void imethod_13([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_0);

    void imethod_14([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

    void imethod_15(out ushort ushort_0);

    void imethod_16();

    void imethod_17([In] ushort ushort_0);

    void imethod_18([In] ushort ushort_0, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_1);

    void imethod_19([In] ushort ushort_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

    void imethod_20([In] ushort ushort_0, [MarshalAs(UnmanagedType.LPArray)] [Out] ushort[] ushort_1, [In] [Out] ref ushort ushort_2);

    void imethod_21([In] ushort ushort_0, [In] ushort ushort_1);

    void imethod_22([In] ushort ushort_0, [In] ushort ushort_1);
}
