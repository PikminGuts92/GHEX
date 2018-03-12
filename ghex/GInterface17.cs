using System;
using System.Runtime.InteropServices;

[Guid("8C1C6090-F9A8-4748-8EC3-DD1108BA1E77")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface GInterface17
{
	void imethod_0([MarshalAs(UnmanagedType.LPArray)] [Out] GStruct1[] gstruct1_0, [In] [Out] ref ushort ushort_0);

	void imethod_1([MarshalAs(UnmanagedType.LPArray)] [In] GStruct1[] gstruct1_0, [In] ushort ushort_0);
}
