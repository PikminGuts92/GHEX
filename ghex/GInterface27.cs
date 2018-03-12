using System;
using System.Runtime.InteropServices;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9397F121-7705-4dc9-B049-98B698188414")]
[ComImport]
public interface GInterface27
{
	void imethod_0([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

	void imethod_1();

	void imethod_2([In] ulong ulong_0, [In] long long_0);

	void imethod_3([In] ushort ushort_0, [In] ulong ulong_0, [In] long long_0);

	void imethod_4([In] ushort ushort_0, out GInterface0 ginterface0_0, out ulong ulong_0, out ulong ulong_1, out uint uint_0, out uint uint_1, out ushort ushort_1);

	void imethod_5([In] ushort ushort_0, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [In] ushort[] ushort_1, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [In] GEnum14[] genum14_0);

	void imethod_6([In] ushort ushort_0, out GEnum14 genum14_0);

	void imethod_7([In] ushort ushort_0, [MarshalAs(UnmanagedType.Bool)] [In] bool bool_0);

	void imethod_8([In] ushort ushort_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_0);

	void imethod_9([In] uint uint_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, out GEnum15 genum15_0, IntPtr intptr_0, [In] [Out] ref uint uint_1);

	void imethod_10([In] uint uint_0, [MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [In] GEnum15 genum15_0, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] [In] byte[] byte_0, [In] uint uint_1);

	void imethod_11(out uint uint_0);

	void imethod_12([In] uint uint_0, [MarshalAs(UnmanagedType.Interface)] out GInterface12 ginterface12_0);

	void imethod_13([In] uint uint_0, [MarshalAs(UnmanagedType.Interface)] [In] GInterface12 ginterface12_0);

	void imethod_14([In] uint uint_0, out uint uint_1);

	void imethod_15([In] uint uint_0, [In] uint uint_1, [MarshalAs(UnmanagedType.Interface)] out GInterface12 ginterface12_0);

	void imethod_16([In] ushort ushort_0, out uint uint_0);

	void imethod_17([In] uint uint_0, out ushort ushort_0);

	void imethod_18([In] uint uint_0, out uint uint_1);

	void imethod_19([In] ushort ushort_0, out uint uint_0);

	void imethod_20([MarshalAs(UnmanagedType.Interface)] [In] UCOMIStream ucomistream_0);
}
