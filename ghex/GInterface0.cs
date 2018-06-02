using System;
using System.Runtime.InteropServices;

[Guid("E1CD3524-03D7-11d2-9EED-006097D2D7CF")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface GInterface0
{
    void imethod_0(out uint uint_0);

    void imethod_1([In] uint uint_0);

    void imethod_2(out uint uint_0);

    void imethod_3(out IntPtr intptr_0);

    void imethod_4(out IntPtr intptr_0, out uint uint_0);
}
