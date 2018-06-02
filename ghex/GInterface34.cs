using System;
using System.Runtime.InteropServices;
using System.Text;

[Guid("945A76A2-12AE-4d48-BD3C-CD1D90399B85")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface GInterface34 : GInterface33
{
    void imethod_92([MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_93([MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_94([In] ulong ulong_0);

    void imethod_95([MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_96([MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_97([In] ushort ushort_0, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [In] ushort[] ushort_1, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [In] GEnum14[] genum14_0);

    void imethod_98([In] ushort ushort_0, out GEnum14 genum14_0);

    void imethod_99([MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_100([MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_101([In] ushort ushort_0, [MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_102([In] ushort ushort_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_103([In] uint uint_0, [MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_104([In] uint uint_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_105([In] ushort ushort_0, [MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_106([In] ushort ushort_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_107([In] [Out] ref GStruct8 gstruct8_0);

    void imethod_108([In] ref GStruct7 gstruct7_0);

    void imethod_109([In] uint uint_0, out uint uint_1);

    void imethod_110([In] ushort ushort_0, out uint uint_0);

    void imethod_111(ulong ulong_0);

    void imethod_112([In] GEnum20 genum20_0);

    void imethod_113(out GEnum20 genum20_0);

    void imethod_114(out uint uint_0, out ulong ulong_0);

    void imethod_115(out uint uint_0, out ulong ulong_0, out ulong ulong_1);

    void imethod_116(out uint uint_0);

    void imethod_117([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

    void imethod_118([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref uint uint_0);

    void imethod_119([In] ushort ushort_0, [In] ulong ulong_0, [In] float float_0, [In] IntPtr intptr_0);

    void imethod_120([In] uint uint_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, out GEnum15 genum15_0, [MarshalAs(UnmanagedType.LPArray)] [Out] byte[] byte_0, [In] [Out] ref ushort ushort_0);

    void imethod_121([In] uint uint_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [In] GEnum15 genum15_0, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] [In] byte[] byte_0, [In] ushort ushort_0);

    void imethod_122([In] ulong ulong_0, [In] ulong ulong_1, [In] float float_0);

    void imethod_123([MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

    void imethod_124([MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_125();

    void imethod_126([MarshalAs(UnmanagedType.Interface)] [In] UCOMIStream ucomistream_0, [MarshalAs(UnmanagedType.Interface)] [In] GInterface29 ginterface29_0, [In] IntPtr intptr_0);

    void imethod_127();

    void imethod_128([In] ushort ushort_0, [In] IntPtr intptr_0, [In] IntPtr intptr_1, [In] GEnum21 genum21_0, [In] float float_0, [In] IntPtr intptr_2);

    void imethod_129([In] uint uint_0, out ushort ushort_0);

    void imethod_130([In] uint uint_0, [In] ushort ushort_0, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_1);

    void imethod_131(out double double_0);

    void imethod_132([MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_133([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_1, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_2);

    void imethod_134();

    void imethod_135([MarshalAs(UnmanagedType.Bool)] out bool bool_0);

    void imethod_136();

    void imethod_137([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref uint uint_0);
}
