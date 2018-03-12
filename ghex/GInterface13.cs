using System;
using System.Runtime.InteropServices;

[Guid("96406BDD-2B2B-11d3-B36B-00C04F6108FF")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface GInterface13
{
	void imethod_0([MarshalAs(UnmanagedType.LPArray)] [Out] ushort[] ushort_0, [In] [Out] ref ushort ushort_1);

	void imethod_1([In] ushort ushort_0);

	void imethod_2([In] ushort ushort_0);
}
