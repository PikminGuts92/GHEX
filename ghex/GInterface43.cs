using System;
using System.Runtime.InteropServices;
using System.Text;

[Guid("7A924E51-73C1-494d-8019-23D37ED9B89A")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface GInterface43 : GInterface42
{
    void imethod_6([In] GEnum16 genum16_0, [MarshalAs(UnmanagedType.Interface)] out GInterface41 ginterface41_0);

    void imethod_7([In] ref Guid guid_0, [MarshalAs(UnmanagedType.Interface)] out GInterface41 ginterface41_0);

    void imethod_8([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [MarshalAs(UnmanagedType.Interface)] out GInterface41 ginterface41_0);

    void imethod_9([MarshalAs(UnmanagedType.Interface)] [In] GInterface41 ginterface41_0, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref uint uint_0);

    void imethod_10(out uint uint_0);

    void imethod_11([In] uint uint_0, [MarshalAs(UnmanagedType.Interface)] out GInterface41 ginterface41_0);

    void imethod_12(out GEnum16 genum16_0);

    void imethod_13([In] GEnum16 genum16_0);
}
