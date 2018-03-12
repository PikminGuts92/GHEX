using System;
using System.Runtime.InteropServices;

[Guid("96406BD6-2B2B-11d3-B36B-00C04F6108FF")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface GInterface30
{
	void imethod_0([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [MarshalAs(UnmanagedType.Interface)] [In] GInterface29 ginterface29_0, [In] IntPtr intptr_0);

	void imethod_1();

	void imethod_2(out uint uint_0);

	void imethod_3([In] uint uint_0, [MarshalAs(UnmanagedType.Interface)] out GInterface12 ginterface12_0);

	void imethod_4([In] uint uint_0, [MarshalAs(UnmanagedType.Interface)] [In] GInterface12 ginterface12_0);

	void imethod_5([In] uint uint_0, out uint uint_1);

	void imethod_6([In] uint uint_0, [In] uint uint_1, [MarshalAs(UnmanagedType.Interface)] out GInterface12 ginterface12_0);

	void imethod_7([In] ulong ulong_0, [In] ulong ulong_1, [In] float float_0, [In] IntPtr intptr_0);

	void imethod_8();

	void imethod_9();

	void imethod_10();
}
