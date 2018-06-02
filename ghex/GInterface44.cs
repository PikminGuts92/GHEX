using System;
using System.Runtime.InteropServices;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("BA4DCC78-7EE0-4ab8-B27A-DBCE8BC51454")]
[ComImport]
public interface GInterface44
{
    void imethod_0(out ushort ushort_0);

    void imethod_1([In] ushort ushort_0);
}
