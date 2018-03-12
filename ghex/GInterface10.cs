using System;
using System.Runtime.InteropServices;

[Guid("96406BCF-2B2B-11d3-B36B-00C04F6108FF")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface GInterface10 : GInterface9
{
	void imethod_3(out Guid guid_0);

	void imethod_4(IntPtr intptr_0, [In] [Out] ref uint uint_0);

	void imethod_5([In] ref GStruct2 gstruct2_0);

	void imethod_6(out long long_0);

	void imethod_7([In] long long_0);

	void imethod_8(out uint uint_0);

	void imethod_9([In] uint uint_0);
}
