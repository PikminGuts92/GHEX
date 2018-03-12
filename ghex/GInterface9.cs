using System;
using System.Runtime.InteropServices;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("96406BCE-2B2B-11d3-B36B-00C04F6108FF")]
[ComImport]
public interface GInterface9
{
	void imethod_0(out Guid guid_0);

	void imethod_1(IntPtr intptr_0, [In] [Out] ref uint uint_0);

	void imethod_2([In] ref GStruct2 gstruct2_0);
}
