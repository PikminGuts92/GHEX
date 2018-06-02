using System;
using System.Runtime.InteropServices;

// Wrapper for WinMM audio library
// Helpful: https://github.com/naudio/NAudio/blob/master/NAudio/Wave/MmeInterop/WaveInterop.cs

class WinMM
{
	[DllImport("winmm.dll")]
	public static extern int waveOutGetNumDevs();

	[DllImport("winmm.dll")]
	public static extern int waveOutPrepareHeader(IntPtr intptr_0, ref WinMM.Struct4 struct4_0, int int_8);

	[DllImport("winmm.dll")]
	public static extern int waveOutUnprepareHeader(IntPtr intptr_0, ref WinMM.Struct4 struct4_0, int int_8);

	[DllImport("winmm.dll")]
	public static extern int waveOutWrite(IntPtr intptr_0, ref WinMM.Struct4 struct4_0, int int_8);

	[DllImport("winmm.dll")]
	public static extern int waveOutOpen(out IntPtr intptr_0, int int_8, GClass94 gclass94_0, WinMM.Delegate1 delegate1_0, int int_9, int int_10);

	[DllImport("winmm.dll")]
	public static extern int waveOutReset(IntPtr intptr_0);

	[DllImport("winmm.dll")]
	public static extern int waveOutClose(IntPtr intptr_0);

	[DllImport("winmm.dll")]
	public static extern int waveOutPause(IntPtr intptr_0);

	[DllImport("winmm.dll")]
	public static extern int waveOutRestart(IntPtr intptr_0);

	[DllImport("winmm.dll")]
	public static extern int waveOutGetPosition(IntPtr intptr_0, out int int_8, int int_9);

	[DllImport("winmm.dll")]
	public static extern int waveOutSetVolume(IntPtr intptr_0, int int_8);

	[DllImport("winmm.dll")]
	public static extern int waveOutGetVolume(IntPtr intptr_0, out int int_8);

	public const int int_0 = 0x00;

    // WaveMessage
	public const int WAVE_OUT_OPEN  = 0x3BB;
	public const int WAVE_OUT_CLOSE = 0x3BC;
	public const int WAVE_OUT_DONE  = 0x3BD;

    // WaveInOutOpenFlags
    public const int CALL_BACK_FUNCTION = 0x30000;

    public const int int_5 = 0x01;
	public const int int_6 = 0x02;
	public const int int_7 = 0x04;

	const string DLL_FILE_NAME = "winmm.dll";

	public delegate void Delegate1(IntPtr intptr_0, int int_0, int int_1, ref WinMM.Struct4 struct4_0, int int_2);

	public struct Struct4
	{
		public IntPtr intptr_0;

		public int int_0;

		public int int_1;

		public IntPtr intptr_1;

		public int int_2;

		public int int_3;

		public IntPtr intptr_2;

		public int int_4;
	}
}
