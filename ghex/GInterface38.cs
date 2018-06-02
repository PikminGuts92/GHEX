using System;
using System.Runtime.InteropServices;
using System.Text;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("96406BDC-2B2B-11d3-B36B-00C04F6108FF")]
[ComImport]
public interface GInterface38
{
    void imethod_0(out Guid guid_0);

    void imethod_1(out ushort ushort_0);

    void imethod_2([In] ushort ushort_0);

    void imethod_3([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_0);

    void imethod_4([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

    void imethod_5([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_0);

    void imethod_6([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

    void imethod_7(out uint uint_0);

    void imethod_8([In] uint uint_0);

    void imethod_9(out uint uint_0);

    void imethod_10([In] uint uint_0);
}
