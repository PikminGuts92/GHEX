using System;
using System.Runtime.InteropServices;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("C87CEAAF-75BE-4bc4-84EB-AC2798507672")]
[ComImport]
public interface GInterface48 : GInterface47
{
    void imethod_12(out uint uint_0);

    void imethod_13([In] uint uint_0);

    void imethod_14(out uint uint_0);

    void imethod_15(out IntPtr intptr_0);

    void imethod_16(out IntPtr intptr_0, out uint uint_0);

    void imethod_17([In] uint uint_0, out byte byte_0);

    void imethod_18([In] uint uint_0, [In] ref byte byte_0);

    void imethod_19([In] Guid guid_0, [In] IntPtr intptr_0, [In] uint uint_0);

    void imethod_20([In] Guid guid_0, IntPtr intptr_0, [In] [Out] ref uint uint_0);
}
