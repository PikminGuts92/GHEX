using System;
using System.Runtime.InteropServices;
using System.Text;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("00EF96CC-A461-4546-8BCD-C9A28F0E06F5")]
[ComImport]
public interface GInterface46 : GInterface45
{
	void imethod_37(out GEnum16 genum16_0);

	void imethod_38([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref uint uint_0);

	void imethod_39([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

	void imethod_40([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, [In] [Out] ref uint uint_0);

	void imethod_41([MarshalAs(UnmanagedType.LPWStr)] [In] string string_0);

	void imethod_42(out uint uint_0);

	void imethod_43([In] uint uint_0, [MarshalAs(UnmanagedType.Interface)] out GInterface38 ginterface38_0);

	void imethod_44([In] ushort ushort_0, [MarshalAs(UnmanagedType.Interface)] out GInterface38 ginterface38_0);

	void imethod_45([MarshalAs(UnmanagedType.Interface)] [In] GInterface38 ginterface38_0);

	void imethod_46([In] ushort ushort_0);

	void imethod_47([MarshalAs(UnmanagedType.Interface)] [In] GInterface38 ginterface38_0);

	void imethod_48([MarshalAs(UnmanagedType.Interface)] [In] GInterface38 ginterface38_0);

	void imethod_49([In] ref Guid guid_0, [MarshalAs(UnmanagedType.Interface)] out GInterface38 ginterface38_0);

	void imethod_50(out uint uint_0);

	void imethod_51([In] uint uint_0, [MarshalAs(UnmanagedType.Interface)] out GInterface14 ginterface14_0);

	void imethod_52([MarshalAs(UnmanagedType.Interface)] [In] GInterface14 ginterface14_0);

	void imethod_53([MarshalAs(UnmanagedType.Interface)] [In] GInterface14 ginterface14_0);

	void imethod_54([MarshalAs(UnmanagedType.Interface)] out GInterface14 ginterface14_0);

	void imethod_55(out Guid guid_0);

	void imethod_56(out GEnum17 genum17_0);

	void imethod_57([In] GEnum17 genum17_0);

	void imethod_58(out uint uint_0);

	void imethod_59([In] uint uint_0, [MarshalAs(UnmanagedType.Interface)] out GInterface16 ginterface16_0);

	void imethod_60([MarshalAs(UnmanagedType.Interface)] [In] GInterface16 ginterface16_0);

	void imethod_61([MarshalAs(UnmanagedType.Interface)] [In] GInterface16 ginterface16_0);

	void imethod_62([MarshalAs(UnmanagedType.Interface)] out GInterface16 ginterface16_0);

	void imethod_63([MarshalAs(UnmanagedType.Interface)] out GInterface17 ginterface17_0);

	void imethod_64([MarshalAs(UnmanagedType.Interface)] [In] GInterface17 ginterface17_0);

	void imethod_65();

	void imethod_66([MarshalAs(UnmanagedType.Interface)] out GInterface17 ginterface17_0);

	void imethod_67([In] ulong ulong_0, out ulong ulong_1);
}
