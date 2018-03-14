using System;
using System.Runtime.InteropServices;

// Wrapper for WinMM audio library

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

	public const int int_0 = 0;

	public const int int_1 = 955;

	public const int int_2 = 956;

	public const int int_3 = 957;

	public const int int_4 = 196608;

	public const int int_5 = 1;

	public const int int_6 = 2;

	public const int int_7 = 4;

	const string string_0 = "winmm.dll";

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
