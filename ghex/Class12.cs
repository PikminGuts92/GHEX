using System;
using System.Runtime.InteropServices;
using System.Threading;

class Class12 : IDisposable
{
	internal static void smethod_0(IntPtr intptr_1, int int_0, int int_1, ref WinMM.Struct4 struct4_1, int int_2)
	{
		if (int_0 == 957)
		{
			try
			{
				Class12 @class = (Class12)((GCHandle)struct4_1.intptr_1).Target;
				@class.method_4();
			}
			catch
			{
			}
		}
	}

	public Class12(IntPtr intptr_1, int int_0)
	{
		this.intptr_0 = intptr_1;
		this.gchandle_0 = GCHandle.Alloc(this.struct4_0, GCHandleType.Pinned);
		this.struct4_0.intptr_1 = (IntPtr)GCHandle.Alloc(this);
		this.byte_0 = new byte[int_0];
		this.gchandle_1 = GCHandle.Alloc(this.byte_0, GCHandleType.Pinned);
		this.struct4_0.intptr_0 = this.gchandle_1.AddrOfPinnedObject();
		this.struct4_0.int_0 = int_0;
		Class11.smethod_0(WinMM.waveOutPrepareHeader(this.intptr_0, ref this.struct4_0, Marshal.SizeOf(this.struct4_0)));
	}

	~Class12()
	{
		this.Dispose();
	}

	public void Dispose()
	{
		if (this.struct4_0.intptr_0 != IntPtr.Zero)
		{
			WinMM.waveOutUnprepareHeader(this.intptr_0, ref this.struct4_0, Marshal.SizeOf(this.struct4_0));
			this.gchandle_0.Free();
			this.struct4_0.intptr_0 = IntPtr.Zero;
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
		return this.struct4_0.int_0;
	}

	public IntPtr method_1()
	{
		return this.struct4_0.intptr_0;
	}

	public bool method_2()
	{
		bool result;
		lock (this)
		{
			this.autoResetEvent_0.Reset();
			this.bool_0 = (WinMM.waveOutWrite(this.intptr_0, ref this.struct4_0, Marshal.SizeOf(this.struct4_0)) == 0);
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

	public Class12 class12_0;

	AutoResetEvent autoResetEvent_0 = new AutoResetEvent(false);

	IntPtr intptr_0;

	WinMM.Struct4 struct4_0;

	byte[] byte_0;

	GCHandle gchandle_0;

	GCHandle gchandle_1;

	bool bool_0;
}
