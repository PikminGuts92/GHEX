using System;
using System.Runtime.InteropServices;
using System.Text;

[Guid("96406BDB-2B2B-11d3-B36B-00C04F6108FF")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface GInterface41
{
	void imethod_0(out GEnum16 genum16_0);

	void imethod_1([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref uint uint_0);

	void imethod_2([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

	void imethod_3([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref uint uint_0);

	void imethod_4([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

	void imethod_5(out uint uint_0);

	void imethod_6([In] uint uint_0, [MarshalAs(UnmanagedType.Interface)] out GInterface38 ginterface38_0);

	void imethod_7([In] ushort ushort_0, [MarshalAs(UnmanagedType.Interface)] out GInterface38 ginterface38_0);

	void imethod_8([MarshalAs(UnmanagedType.Interface)] [In] GInterface38 ginterface38_0);

	void imethod_9([In] ushort ushort_0);

	void imethod_10([MarshalAs(UnmanagedType.Interface)] [In] GInterface38 ginterface38_0);

	void imethod_11([MarshalAs(UnmanagedType.Interface)] [In] GInterface38 ginterface38_0);

	void imethod_12([In] ref Guid guid_0, [MarshalAs(UnmanagedType.Interface)] out GInterface38 ginterface38_0);

	void imethod_13(out uint uint_0);

	void imethod_14([In] uint uint_0, [MarshalAs(UnmanagedType.Interface)] out GInterface14 ginterface14_0);

	void imethod_15([MarshalAs(UnmanagedType.Interface)] [In] GInterface14 ginterface14_0);

	void imethod_16([MarshalAs(UnmanagedType.Interface)] [In] GInterface14 ginterface14_0);

	void imethod_17([MarshalAs(UnmanagedType.Interface)] out GInterface14 ginterface14_0);
}
