using System;
using System.Runtime.InteropServices;
using System.Text;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("15CF9781-454E-482e-B393-85FAE487A810")]
[ComImport]
public interface GInterface20 : GInterface19
{
	void imethod_12([In] ushort ushort_0, out ushort ushort_1);

	void imethod_13([In] ushort ushort_0, [In] [Out] ref ushort ushort_1, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_2, out GEnum15 genum15_0, IntPtr intptr_0, [In] [Out] ref ushort ushort_3);

	void imethod_14([In] [Out] ref ushort ushort_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, out GEnum15 genum15_0, IntPtr intptr_0, [In] [Out] ref ushort ushort_1);

	void imethod_15([In] ushort ushort_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [In] GEnum15 genum15_0, IntPtr intptr_0, [In] ushort ushort_1);

	void imethod_16(out ushort ushort_0);

	void imethod_17([In] ushort ushort_0, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_1, out ulong ulong_0);

	void imethod_18([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [In] ulong ulong_0);

	void imethod_19([In] ushort ushort_0);

	void imethod_20(out ushort ushort_0);

	void imethod_21([In] ushort ushort_0, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_1, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_1, [In] [Out] ref ushort ushort_2, out ulong ulong_0);

	void imethod_22([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_1, [In] ulong ulong_0);

	void imethod_23([In] ushort ushort_0);

	void imethod_24(out uint uint_0);

	void imethod_25([In] uint uint_0, [In] [Out] ref ushort ushort_0, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_1, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_1, out GEnum22 genum22_0, [In] [Out] ref ushort ushort_2, [MarshalAs(UnmanagedType.LPArray)] [Out] byte[] byte_0);
}
