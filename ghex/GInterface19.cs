using System;
using System.Runtime.InteropServices;
using System.Text;

[Guid("96406BDA-2B2B-11d3-B36B-00C04F6108FF")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface GInterface19
{
    void imethod_0([In] ushort ushort_0, out ushort ushort_1);

    void imethod_1([In] ushort ushort_0, [In] [Out] ref ushort ushort_1, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_2, out GEnum15 genum15_0, IntPtr intptr_0, [In] [Out] ref ushort ushort_3);

    void imethod_2([In] [Out] ref ushort ushort_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, out GEnum15 genum15_0, IntPtr intptr_0, [In] [Out] ref ushort ushort_1);

    void imethod_3([In] ushort ushort_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [In] GEnum15 genum15_0, IntPtr intptr_0, [In] ushort ushort_1);

    void imethod_4(out ushort ushort_0);

    void imethod_5([In] ushort ushort_0, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_1, out ulong ulong_0);

    void imethod_6([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [In] ulong ulong_0);

    void imethod_7([In] ushort ushort_0);

    void imethod_8(out ushort ushort_0);

    void imethod_9([In] ushort ushort_0, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_1, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_1, [In] [Out] ref ushort ushort_2, out ulong ulong_0);

    void imethod_10([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_1, [In] ulong ulong_0);

    void imethod_11([In] ushort ushort_0);
}
