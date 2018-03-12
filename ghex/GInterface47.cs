using System;
using System.Runtime.InteropServices;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("4F528693-1035-43fe-B428-757561AD3A68")]
[ComImport]
public interface GInterface47 : GInterface0
{
	void imethod_5(out uint uint_0);

	void imethod_6([In] uint uint_0);

	void imethod_7(out uint uint_0);

	void imethod_8(out IntPtr intptr_0);

	void imethod_9(out IntPtr intptr_0, out uint uint_0);

	void imethod_10([In] uint uint_0, out byte byte_0);

	void imethod_11([In] uint uint_0, [In] ref byte byte_0);
}
