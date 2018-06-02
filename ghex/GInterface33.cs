using System;
using System.Runtime.InteropServices;
using System.Text;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("5DC0674B-F04B-4a4e-9F2A-B1AFDE2C8100")]
[ComImport]
public interface GInterface33 : GInterface32
{
    void imethod_55([MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_56([MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_57([In] ulong ulong_0);

    void imethod_58([MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_59([MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_60([In] ushort ushort_0, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [In] ushort[] ushort_1, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [In] GEnum14[] genum14_0);

    void imethod_61([In] ushort ushort_0, out GEnum14 genum14_0);

    void imethod_62([MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_63([MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_64([In] ushort ushort_0, [MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_65([In] ushort ushort_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_66([In] uint uint_0, [MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_67([In] uint uint_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_68([In] ushort ushort_0, [MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_69([In] ushort ushort_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_70([In] [Out] ref GStruct8 gstruct8_0);

    void imethod_71([In] ref GStruct7 gstruct7_0);

    void imethod_72([In] uint uint_0, out uint uint_1);

    void imethod_73([In] ushort ushort_0, out uint uint_0);

    void imethod_74(ulong ulong_0);

    void imethod_75([In] GEnum20 genum20_0);

    void imethod_76(out GEnum20 genum20_0);

    void imethod_77(out uint uint_0, out ulong ulong_0);

    void imethod_78(out uint uint_0, out ulong ulong_0, out ulong ulong_1);

    void imethod_79(out uint uint_0);

    void imethod_80([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

    void imethod_81([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref uint uint_0);

    void imethod_82([In] ushort ushort_0, [In] ulong ulong_0, [In] float float_0, [In] IntPtr intptr_0);

    void imethod_83([In] uint uint_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, out GEnum15 genum15_0, [MarshalAs(UnmanagedType.LPArray)] [Out] byte[] byte_0, [In] [Out] ref ushort ushort_0);

    void imethod_84([In] uint uint_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [In] GEnum15 genum15_0, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] [In] byte[] byte_0, [In] ushort ushort_0);

    void imethod_85([In] ulong ulong_0, [In] ulong ulong_1, [In] float float_0);

    void imethod_86([MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_87([MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_88();

    void imethod_89([MarshalAs(UnmanagedType.Interface)] [In] UCOMIStream ucomistream_0, [MarshalAs(UnmanagedType.Interface)] [In] GInterface29 ginterface29_0, [In] IntPtr intptr_0);

    void imethod_90();

    void imethod_91([In] ushort ushort_0, [In] IntPtr intptr_0, [In] IntPtr intptr_1, [In] GEnum21 genum21_0, [In] float float_0, [In] IntPtr intptr_2);
}
