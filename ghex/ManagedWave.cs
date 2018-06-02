using System;
using System.Runtime.InteropServices;
using System.Threading;

// Managed wave instance?
class ManagedWave : IDisposable
{
	internal static void smethod_0(IntPtr intptr_1, int int_0, int int_1, ref WinMM.WaveHeader waveHeader, int int_2)
	{
		if (int_0 == WinMM.WAVE_OUT_DONE)
		{
			try
			{
				ManagedWave @class = (ManagedWave)((GCHandle)waveHeader.userData).Target;
				@class.method_4();
			}
			catch
			{
			}
		}
	}

	public ManagedWave(IntPtr intptr_1, int int_0)
	{
		this.intptr_0 = intptr_1;
		this.gchandle_0 = GCHandle.Alloc(this.waveHeader, GCHandleType.Pinned);
		this.waveHeader.userData = (IntPtr)GCHandle.Alloc(this);
		this.byte_0 = new byte[int_0];
		this.gchandle_1 = GCHandle.Alloc(this.byte_0, GCHandleType.Pinned);
		this.waveHeader.dataBuffer = this.gchandle_1.AddrOfPinnedObject();
		this.waveHeader.bufferLength = int_0;
		Class11.smethod_0(WinMM.waveOutPrepareHeader(this.intptr_0, ref this.waveHeader, Marshal.SizeOf(this.waveHeader)));
	}

	~ManagedWave()
	{
		this.Dispose();
	}

	public void Dispose()
	{
		if (this.waveHeader.dataBuffer != IntPtr.Zero)
		{
			WinMM.waveOutUnprepareHeader(this.intptr_0, ref this.waveHeader, Marshal.SizeOf(this.waveHeader));
			this.gchandle_0.Free();
			this.waveHeader.dataBuffer = IntPtr.Zero;
		}
		this.autoResetEvent_0.Close();
		if (this.gchandle_1.IsAllocated)
		{
			this.gchandle_1.Free();
		}
		GC.SuppressFinalize(this);
	}

	public int method_0()
	{
		return this.waveHeader.bufferLength;
	}

	public IntPtr method_1()
	{
		return this.waveHeader.dataBuffer;
	}

	public bool method_2()
	{
		bool result;
		lock (this)
		{
			this.autoResetEvent_0.Reset();
			this.bool_0 = (WinMM.waveOutWrite(this.intptr_0, ref this.waveHeader, Marshal.SizeOf(this.waveHeader)) == 0);
			result = this.bool_0;
		}
		return result;
	}

	public void method_3()
	{
		if (this.bool_0)
		{
			this.bool_0 = this.autoResetEvent_0.WaitOne();
			return;
		}
		Thread.Sleep(0);
	}

	public void method_4()
	{
		this.autoResetEvent_0.Set();
		this.bool_0 = false;
	}

	public ManagedWave class12_0;

	AutoResetEvent autoResetEvent_0 = new AutoResetEvent(false);

	IntPtr intptr_0;

	WinMM.WaveHeader waveHeader;

	byte[] byte_0;

	GCHandle gchandle_0;

	GCHandle gchandle_1;

	bool bool_0;
}
