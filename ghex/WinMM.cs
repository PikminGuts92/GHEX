using System;
using System.Runtime.InteropServices;

// Wrapper for WinMM audio library
// Helpful: https://github.com/naudio/NAudio/blob/master/NAudio/Wave/MmeInterop/WaveInterop.cs

class WinMM
{
    [DllImport("winmm.dll")]
    public static extern int waveOutGetNumDevs();

    [DllImport("winmm.dll")]
    public static extern int waveOutPrepareHeader(IntPtr hWaveOut, ref WaveHeader lpWaveOutHdr, int uSize);

    [DllImport("winmm.dll")]
    public static extern int waveOutUnprepareHeader(IntPtr hWaveOut, ref WaveHeader lpWaveOutHdr, int uSize);

    [DllImport("winmm.dll")]
    public static extern int waveOutWrite(IntPtr hWaveOut, ref WaveHeader lpWaveOutHdr, int uSize);

    [DllImport("winmm.dll")]
    public static extern int waveOutOpen(out IntPtr hWaveOut, int uDeviceID, WaveFormat lpFormat, WaveCallback dwCallback, int dwInstance, int dwFlags);

    [DllImport("winmm.dll")]
    public static extern int waveOutReset(IntPtr hWaveOut);

    [DllImport("winmm.dll")]
    public static extern int waveOutClose(IntPtr hWaveOut);

    [DllImport("winmm.dll")]
    public static extern int waveOutPause(IntPtr hWaveOut);

    [DllImport("winmm.dll")]
    public static extern int waveOutRestart(IntPtr hWaveOut);

    [DllImport("winmm.dll")]
    public static extern int waveOutGetPosition(IntPtr hWaveOut, out int mmTime, int uSize);

    [DllImport("winmm.dll")]
    public static extern int waveOutSetVolume(IntPtr hWaveOut, int dwVolume);

    [DllImport("winmm.dll")]
    public static extern int waveOutGetVolume(IntPtr hWaveOut, out int dwVolume);

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

    const string DLL_FILE_NAME = "winmm.dll"; // Not even used?

    public delegate void WaveCallback(IntPtr intptr_0, int int_0, int int_1, ref WaveHeader struct4_0, int int_2);

    [StructLayout(LayoutKind.Sequential)]
    public struct WaveHeader
    {
        public IntPtr dataBuffer;
        public int bufferLength;
        public int bytesRecorded;
        public IntPtr userData;
        public int flags;
        public int loops;
        public IntPtr next;
        public int reserved;
    }
}
