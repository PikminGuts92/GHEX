using System;
using System.Runtime.InteropServices;

[Guid("6d7cdc71-9888-11d3-8edc-00c04f6109cf")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface GInterface24
{
	void imethod_0([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [MarshalAs(UnmanagedType.Interface)] [In] GInterface18 ginterface18_0, [In] IntPtr intptr_0);

	void imethod_1();
}
