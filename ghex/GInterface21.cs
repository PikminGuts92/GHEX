using System;
using System.Runtime.InteropServices;
using System.Text;

[Guid("15CC68E3-27CC-4ecd-B222-3F5D02D80BD5")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface GInterface21 : GInterface20
{
	void imethod_26([In] ushort ushort_0, out ushort ushort_1);

	void imethod_27([In] ushort ushort_0, [In] [Out] ref ushort ushort_1, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_2, out GEnum15 genum15_0, IntPtr intptr_0, [In] [Out] ref ushort ushort_3);

	void imethod_28([In] [Out] ref ushort ushort_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, out GEnum15 genum15_0, IntPtr intptr_0, [In] [Out] ref ushort ushort_1);

	void imethod_29([In] ushort ushort_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [In] GEnum15 genum15_0, IntPtr intptr_0, [In] ushort ushort_1);

	void imethod_30(out ushort ushort_0);

	void imethod_31([In] ushort ushort_0, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_1, out ulong ulong_0);

	void imethod_32([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [In] ulong ulong_0);

	void imethod_33([In] ushort ushort_0);

	void imethod_34(out ushort ushort_0);

	void imethod_35([In] ushort ushort_0, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_1, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_1, [In] [Out] ref ushort ushort_2, out ulong ulong_0);

	void imethod_36([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_1, [In] ulong ulong_0);

	void imethod_37([In] ushort ushort_0);

	void imethod_38(out uint uint_0);

	void imethod_39([In] uint uint_0, [In] [Out] ref ushort ushort_0, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_1, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_1, out GEnum22 genum22_0, [In] [Out] ref ushort ushort_2, [MarshalAs(UnmanagedType.LPArray)] [Out] byte[] byte_0);

	void imethod_40([In] ushort ushort_0, out ushort ushort_1);

	void imethod_41([In] ushort ushort_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, IntPtr intptr_0, [MarshalAs(UnmanagedType.LPArray)] [Out] ushort[] ushort_1, [In] [Out] ref ushort ushort_2);

	void imethod_42([In] ushort ushort_0, [In] ushort ushort_1, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_2, out GEnum15 genum15_0, out ushort ushort_3, IntPtr intptr_0, [In] [Out] ref uint uint_0);

	void imethod_43([In] ushort ushort_0, [In] ushort ushort_1, [In] GEnum15 genum15_0, [In] ushort ushort_2, IntPtr intptr_0, [In] uint uint_0);

	void imethod_44([In] ushort ushort_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, out ushort ushort_1, [In] GEnum15 genum15_0, [In] ushort ushort_2, IntPtr intptr_0, [In] uint uint_0);

	void imethod_45([In] ushort ushort_0, [In] ushort ushort_1);

	void imethod_46([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_1, [In] GEnum22 genum22_0, [In] ushort ushort_0, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] [In] byte[] byte_0);
}
