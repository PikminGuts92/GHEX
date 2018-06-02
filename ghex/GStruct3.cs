using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct GStruct3
{
    public ushort ushort_0;

    public ushort ushort_1;

    uint uint_0;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string string_0;

    public uint uint_1;

    public ushort ushort_2;

    public ushort ushort_3;

    public uint uint_2;
}
