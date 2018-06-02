using System;
using System.Runtime.InteropServices;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("61103CA4-2033-11d2-9EF1-006097D2D7CF")]
[ComImport]
public interface GInterface50
{
    void imethod_0([In] uint uint_0, [MarshalAs(UnmanagedType.Interface)] out GInterface0 ginterface0_0);

    void imethod_1([In] uint uint_0, [MarshalAs(UnmanagedType.Interface)] out GInterface0 ginterface0_0);
}
