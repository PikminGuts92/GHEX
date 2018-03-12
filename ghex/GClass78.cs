using System;
using System.Runtime.InteropServices;

public class GClass78
{
	[DllImport("WinMM.dll", CharSet = CharSet.Ansi)]
	public static extern uint waveOutGetNumDevs();

	[DllImport("WinMM.dll", CharSet = CharSet.Ansi)]
	public static extern GEnum35 waveOutGetDevCaps(uint uint_0, ref GStruct3 gstruct3_0, int int_0);

	[DllImport("WinMM.dll", CharSet = CharSet.Ansi)]
	public static extern GEnum35 waveOutOpen(ref IntPtr intptr_0, uint uint_0, ref GStruct5 gstruct5_0, IntPtr intptr_1, IntPtr intptr_2, uint uint_1);

	[DllImport("WinMM.dll", CharSet = CharSet.Ansi)]
	public static extern GEnum35 waveOutClose(IntPtr intptr_0);

	[DllImport("WinMM.dll", CharSet = CharSet.Ansi)]
	public static extern GEnum35 waveOutPrepareHeader(IntPtr intptr_0, ref GStruct4 gstruct4_0, int int_0);

	[DllImport("WinMM.dll", CharSet = CharSet.Ansi)]
	public static extern GEnum35 waveOutUnprepareHeader(IntPtr intptr_0, ref GStruct4 gstruct4_0, int int_0);

	[DllImport("WinMM.dll", CharSet = CharSet.Ansi)]
	public static extern GEnum35 waveOutWrite(IntPtr intptr_0, ref GStruct4 gstruct4_0, int int_0);

	[DllImport("WinMM.dll", CharSet = CharSet.Ansi)]
	public static extern GEnum35 waveOutPause(IntPtr intptr_0);

	[DllImport("WinMM.dll", CharSet = CharSet.Ansi)]
	public static extern GEnum35 waveOutRestart(IntPtr intptr_0);

	[DllImport("WinMM.dll", CharSet = CharSet.Ansi)]
	public static extern GEnum35 waveOutReset(IntPtr intptr_0);

	[DllImport("WinMM.dll", CharSet = CharSet.Ansi)]
	public static extern GEnum35 waveOutBreakLoop(IntPtr intptr_0);

	[DllImport("WinMM.dll", CharSet = CharSet.Ansi)]
	public static extern GEnum35 waveOutGetPosition(IntPtr intptr_0, ref GStruct6 gstruct6_0, int int_0);

	[DllImport("WinMM.dll", CharSet = CharSet.Ansi)]
	public static extern GEnum35 waveOutGetPitch(IntPtr intptr_0, ref uint uint_0);

	[DllImport("WinMM.dll", CharSet = CharSet.Ansi)]
	public static extern GEnum35 waveOutSetPitch(IntPtr intptr_0, uint uint_0);

	[DllImport("WinMM.dll", CharSet = CharSet.Ansi)]
	public static extern GEnum35 waveOutGetPlaybackRate(IntPtr intptr_0, ref uint uint_0);

	[DllImport("WinMM.dll", CharSet = CharSet.Ansi)]
	public static extern GEnum35 waveOutSetPlaybackRate(IntPtr intptr_0, uint uint_0);

	[DllImport("WinMM.dll", CharSet = CharSet.Ansi)]
	public static extern GEnum35 waveOutGetID(IntPtr intptr_0, ref uint uint_0);
}
