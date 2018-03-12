using System;
using System.Runtime.InteropServices;
using System.Text;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("96406BD7-2B2B-11d3-B36B-00C04F6108FF")]
[ComImport]
public interface GInterface12 : GInterface9
{
	void imethod_3(out Guid guid_0);

	void imethod_4(IntPtr intptr_0, [In] [Out] ref uint uint_0);

	void imethod_5([In] ref GStruct2 gstruct2_0);

	void imethod_6([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_0);

	void imethod_7([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref ushort ushort_0);
}
