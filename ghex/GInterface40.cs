using System;
using System.Runtime.InteropServices;
using System.Text;

[Guid("CB164104-3AA9-45a7-9AC9-4DAEE131D6E1")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface GInterface40 : GInterface39
{
    void imethod_28(out Guid guid_0);

    void imethod_29(out ushort ushort_0);

    void imethod_30([In] ushort ushort_0);

    void imethod_31([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_0);

    void imethod_32([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

    void imethod_33([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_0);

    void imethod_34([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

    void imethod_35(out uint uint_0);

    void imethod_36([In] uint uint_0);

    void imethod_37(out uint uint_0);

    void imethod_38([In] uint uint_0);

    void imethod_39(out GEnum18 genum18_0);

    void imethod_40([In] GEnum18 genum18_0);

    void imethod_41([In] Guid guid_0, [In] ushort ushort_0, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] [In] byte[] byte_0, [In] uint uint_0);

    void imethod_42(out ushort ushort_0);

    void imethod_43([In] uint uint_0, out Guid guid_0, out ushort ushort_0, IntPtr intptr_0, [In] [Out] ref uint uint_1);

    void imethod_44();

    void imethod_45([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_0);

    void imethod_46([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);
}
