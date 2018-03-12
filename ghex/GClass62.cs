using System;
using System.Runtime.InteropServices;
using System.Threading;

public class GClass62 : IDisposable
{
	public static int smethod_0()
	{
		return Class47.waveOutGetNumDevs();
	}

	public GClass62(int int_0, GClass94 gclass94_0, int int_1, int int_2, GDelegate1 gdelegate1_1)
	{
		this.byte_0 = (byte)((gclass94_0.short_3 == 8) ? 128 : 0);
		this.gdelegate1_0 = gdelegate1_1;
		Class11.smethod_0(Class47.waveOutOpen(out this.intptr_0, int_0, gclass94_0, this.delegate1_0, 0, 196608));
		this.method_1(int_1, int_2);
		this.thread_0 = new Thread(new ThreadStart(this.method_0));
		this.thread_0.Start();
	}

	~GClass62()
	{
		this.Dispose();
	}

	public void Dispose()
	{
		if (this.thread_0 != null)
		{
			try
			{
				this.bool_0 = true;
				if (this.intptr_0 != IntPtr.Zero)
				{
					Class47.waveOutReset(this.intptr_0);
				}
				this.thread_0.Join();
				this.gdelegate1_0 = null;
				this.method_2();
				if (this.intptr_0 != IntPtr.Zero)
				{
					Class47.waveOutClose(this.intptr_0);
				}
			}
			finally
			{
				this.thread_0 = null;
				this.intptr_0 = IntPtr.Zero;
			}
		}
		GC.SuppressFinalize(this);
	}

	void method_0()
	{
		while (!this.bool_0)
		{
			this.method_3();
			if (this.gdelegate1_0 != null && !this.bool_0)
			{
				this.gdelegate1_0(this.class12_1.method_1(), this.class12_1.method_0());
			}
			else
			{
				byte b = this.byte_0;
				byte[] array = new byte[this.class12_1.method_0()];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = b;
				}
				Marshal.Copy(array, 0, this.class12_1.method_1(), array.Length);
			}
			this.class12_1.method_2();
		}
		this.method_4();
	}

	void method_1(int int_0, int int_1)
	{
		this.method_2();
		if (int_1 > 0)
		{
			this.class12_0 = new Class12(this.intptr_0, int_0);
			Class12 @class = this.class12_0;
			try
			{
				for (int i = 1; i < int_1; i++)
				{
					Class12 class2 = new Class12(this.intptr_0, int_0);
					@class.class12_0 = class2;
					@class = class2;
				}
			}
			finally
			{
				@class.class12_0 = this.class12_0;
			}
		}
	}

	void method_2()
	{
		this.class12_1 = null;
		if (this.class12_0 != null)
		{
			Class12 @class = this.class12_0;
			this.class12_0 = null;
			Class12 class2 = @class;
			do
			{
				Class12 class3 = class2.class12_0;
				class2.Dispose();
				class2 = class3;
			}
			while (class2 != @class);
		}
	}

	void method_3()
	{
		this.class12_1 = ((this.class12_1 == null) ? this.class12_0 : this.class12_1.class12_0);
		this.class12_1.method_3();
	}

	void method_4()
	{
		Class12 @class = this.class12_0;
		while (@class.class12_0 != this.class12_0)
		{
			@class.method_3();
			@class = @class.class12_0;
		}
	}

	IntPtr intptr_0;

	Class12 class12_0;

	Class12 class12_1;

	Thread thread_0;

	GDelegate1 gdelegate1_0;

	bool bool_0;

	byte byte_0;

	Class47.Delegate1 delegate1_0 = new Class47.Delegate1(Class12.smethod_0);
}
