using System;
using System.Runtime.InteropServices;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9F762FA7-A22E-428d-93C9-AC82F3AAFE5A")]
[ComImport]
public interface GInterface26
{
	void imethod_0([In] ushort ushort_0, [In] uint uint_0, out GInterface0 ginterface0_0, [In] uint uint_1, [In] ulong ulong_0, [In] ulong ulong_1, [In] IntPtr intptr_0);

	void imethod_1([In] uint uint_0, [In] uint uint_1, out GInterface0 ginterface0_0, [In] uint uint_2, [In] ulong ulong_0, [In] ulong ulong_1, [In] IntPtr intptr_0);
}
