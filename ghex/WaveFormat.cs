using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public class WaveFormat
{
    public WaveFormat()
    {
    }

    public WaveFormat(int int_2, int int_3, int int_4)
    {
        this.short_0 = 1;
        this.short_1 = (short)int_4;
        this.int_0 = int_2;
        this.short_3 = (short)int_3;
        this.short_4 = 0;
        this.short_2 = (short)(int_4 * (int_3 / 8));
        this.int_1 = this.int_0 * (int)this.short_2;
    }

    public short short_0;

    public short short_1;

    public int int_0;

    public int int_1;

    public short short_2;

    public short short_3;

    public short short_4;
}
