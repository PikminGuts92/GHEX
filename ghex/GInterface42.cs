using System;
using System.Runtime.InteropServices;
using System.Text;

[Guid("d16679f2-6ca0-472d-8d31-2f5d55aee155")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface GInterface42
{
	void imethod_0([In] GEnum16 genum16_0, [MarshalAs(UnmanagedType.Interface)] out GInterface41 ginterface41_0);

	void imethod_1([In] ref Guid guid_0, [MarshalAs(UnmanagedType.Interface)] out GInterface41 ginterface41_0);

	void imethod_2([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0, [MarshalAs(UnmanagedType.Interface)] out GInterface41 ginterface41_0);

	void imethod_3([MarshalAs(UnmanagedType.Interface)] [In] GInterface41 ginterface41_0, [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref uint uint_0);

	void imethod_4(out uint uint_0);

	void imethod_5([In] uint uint_0, [MarshalAs(UnmanagedType.Interface)] out GInterface41 ginterface41_0);
}
