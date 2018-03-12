using System;
using System.Runtime.InteropServices;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("96406BD9-2B2B-11d3-B36B-00C04F6108FF")]
[ComImport]
public interface GInterface22
{
	void imethod_0([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

	void imethod_1();

	void imethod_2();
}
