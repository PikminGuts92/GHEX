using System;
using System.Runtime.InteropServices;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("96406BDE-2B2B-11d3-B36B-00C04F6108FF")]
[ComImport]
public interface GInterface14 : GInterface13
{
    void imethod_3([MarshalAs(UnmanagedType.LPArray)] [Out] ushort[] ushort_0, [In] [Out] ref ushort ushort_1);

    void imethod_4([In] ushort ushort_0);

    void imethod_5([In] ushort ushort_0);

    void imethod_6(out Guid guid_0);

    void imethod_7([In] ref Guid guid_0);
}
