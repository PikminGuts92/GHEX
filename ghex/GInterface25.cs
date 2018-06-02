using System;
using System.Runtime.InteropServices;

[Guid("B70F1E42-6255-4df0-A6B9-02B212D9E2BB")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface GInterface25 : GInterface24
{
    void imethod_2([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [MarshalAs(UnmanagedType.Interface)] [In] GInterface18 ginterface18_0, [In] IntPtr intptr_0);

    void imethod_3();

    void imethod_4([In] ushort ushort_0, [In] GEnum24 genum24_0, [In] IntPtr intptr_0, [In] IntPtr intptr_1);
}
