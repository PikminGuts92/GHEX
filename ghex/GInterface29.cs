using System;
using System.Runtime.InteropServices;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("96406BD8-2B2B-11d3-B36B-00C04F6108FF")]
[ComImport]
public interface GInterface29 : GInterface18
{
    void imethod_1([In] GEnum19 genum19_0, [In] IntPtr intptr_0, [In] GEnum15 genum15_0, [In] IntPtr intptr_1, [In] IntPtr intptr_2);

    void imethod_2([In] uint uint_0, [In] ulong ulong_0, [In] ulong ulong_1, [In] uint uint_1, [MarshalAs(UnmanagedType.Interface)] [In] GInterface0 ginterface0_0, [In] IntPtr intptr_0);
}
