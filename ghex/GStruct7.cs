using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public struct GStruct7
{
	public uint uint_0;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string string_0;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string string_1;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string string_2;

	ulong ulong_0;

	public IntPtr intptr_0;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string string_3;

	public ulong ulong_1;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string string_4;
}
