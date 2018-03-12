using System;
using System.Runtime.InteropServices;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("203CFFE3-2E18-4fdf-B59D-6E71530534CF")]
public interface GInterface23 : GInterface22
{
	void imethod_3([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

	void imethod_4();

	void imethod_5();

	void imethod_6([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [In] uint uint_0, [In] uint uint_1);
}
