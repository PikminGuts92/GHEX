using System;
using System.Runtime.InteropServices;
using System.Text;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7688D8CB-FC0D-43BD-9459-5A8DEC200CFA")]
[ComImport]
public interface GInterface39 : GInterface38
{
	void imethod_11(out Guid guid_0);

	void imethod_12(out ushort ushort_0);

	void imethod_13([In] ushort ushort_0);

	void imethod_14([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_0);

	void imethod_15([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

	void imethod_16([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_0);

	void imethod_17([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

	void imethod_18(out uint uint_0);

	void imethod_19([In] uint uint_0);

	void imethod_20(out uint uint_0);

	void imethod_21([In] uint uint_0);

	void imethod_22(out GEnum18 genum18_0);

	void imethod_23([In] GEnum18 genum18_0);

	void imethod_24([In] Guid guid_0, [In] ushort ushort_0, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] [In] byte[] byte_0, [In] uint uint_0);

	void imethod_25(out ushort ushort_0);

	void imethod_26([In] uint uint_0, out Guid guid_0, out ushort ushort_0, IntPtr intptr_0, [In] [Out] ref uint uint_1);

	void imethod_27();
}
