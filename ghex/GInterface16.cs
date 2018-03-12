using System;
using System.Runtime.InteropServices;

[Guid("AD694AF1-F8D9-42F8-BC47-70311B0C4F9E")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface GInterface16 : GInterface13
{
	void imethod_3([MarshalAs(UnmanagedType.LPArray)] [Out] ushort[] ushort_0, [In] [Out] ref ushort ushort_1);

	void imethod_4([In] ushort ushort_0);

	void imethod_5([In] ushort ushort_0);

	void imethod_6(out Guid guid_0);

	void imethod_7([In] ref Guid guid_0);

	void imethod_8(out uint uint_0, out uint uint_1);

	void imethod_9([In] uint uint_0, [In] uint uint_1);
}
