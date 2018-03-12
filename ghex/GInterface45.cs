using System;
using System.Runtime.InteropServices;
using System.Text;

[Guid("07E72D33-D94E-4be7-8843-60AE5FF7E5F5")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface GInterface45 : GInterface41
{
	void imethod_18(out GEnum16 genum16_0);

	void imethod_19([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref uint uint_0);

	void imethod_20([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

	void imethod_21([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref uint uint_0);

	void imethod_22([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

	void imethod_23(out uint uint_0);

	void imethod_24([In] uint uint_0, [MarshalAs(UnmanagedType.Interface)] out GInterface38 ginterface38_0);

	void imethod_25([In] ushort ushort_0, [MarshalAs(UnmanagedType.Interface)] out GInterface38 ginterface38_0);

	void imethod_26([MarshalAs(UnmanagedType.Interface)] [In] GInterface38 ginterface38_0);

	void imethod_27([In] ushort ushort_0);

	void imethod_28([MarshalAs(UnmanagedType.Interface)] [In] GInterface38 ginterface38_0);

	void imethod_29([MarshalAs(UnmanagedType.Interface)] [In] GInterface38 ginterface38_0);

	void imethod_30([In] ref Guid guid_0, [MarshalAs(UnmanagedType.Interface)] out GInterface38 ginterface38_0);

	void imethod_31(out uint uint_0);

	void imethod_32([In] uint uint_0, [MarshalAs(UnmanagedType.Interface)] out GInterface14 ginterface14_0);

	void imethod_33([MarshalAs(UnmanagedType.Interface)] [In] GInterface14 ginterface14_0);

	void imethod_34([MarshalAs(UnmanagedType.Interface)] [In] GInterface14 ginterface14_0);

	void imethod_35([MarshalAs(UnmanagedType.Interface)] out GInterface14 ginterface14_0);

	void imethod_36(out Guid guid_0);
}
