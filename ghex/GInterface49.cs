using System;
using System.Runtime.InteropServices;

[Guid("B6B8FD5A-32E2-49d4-A910-C26CC85465ED")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface GInterface49 : GInterface48
{
	void imethod_21(out uint uint_0);

	void imethod_22([In] uint uint_0);

	void imethod_23(out uint uint_0);

	void imethod_24(out IntPtr intptr_0);

	void imethod_25(out IntPtr intptr_0, out uint uint_0);

	void imethod_26([In] uint uint_0, out byte byte_0);

	void imethod_27([In] uint uint_0, [In] ref byte byte_0);

	void imethod_28([In] Guid guid_0, [In] IntPtr intptr_0, [In] uint uint_0);

	void imethod_29([In] Guid guid_0, IntPtr intptr_0, [In] [Out] ref uint uint_0);

	void imethod_30(out uint uint_0);

	void imethod_31([In] uint uint_0, out Guid guid_0, IntPtr intptr_0, [In] [Out] ref uint uint_1);
}
