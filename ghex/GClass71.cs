using System;
using System.Runtime.CompilerServices;

public class GClass71 : IDisposable
{
    public GClass71(byte[] byte_1, long[] long_1, int int_1)
    {
        this.byte_0 = byte_1;
        this.long_0 = long_1;
        this.int_0 = int_1;
    }

    public void Dispose()
    {
        Array.Resize<byte>(ref this.byte_0, 16);
    }

    public GClass64 method_0()
    {
        if (this.gclass64_0 == null)
        {
            this.gclass64_0 = new GClass64(this, 100);
        }
        return this.gclass64_0;
    }

    public GClass71 method_1()
    {
        return this.gclass71_0;
    }

    public void method_2(GClass71 gclass71_1)
    {
        if (gclass71_1 == this)
        {
            return;
        }
        this.gclass71_0 = gclass71_1;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_3(EventHandler eventHandler_1)
    {
        this.eventHandler_0 = (EventHandler)Delegate.Combine(this.eventHandler_0, eventHandler_1);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_4(EventHandler eventHandler_1)
    {
        this.eventHandler_0 = (EventHandler)Delegate.Remove(this.eventHandler_0, eventHandler_1);
    }

    public double method_5()
    {
        return this.double_0;
    }

    public void method_6(double double_1)
    {
        if (double_1 == this.double_0)
        {
            return;
        }
        this.double_0 = double_1;
        if (this.eventHandler_0 != null)
        {
            this.eventHandler_0(this, EventArgs.Empty);
        }
        if (this.gclass71_0 != null && this.gclass71_0.method_5() != double_1)
        {
            this.gclass71_0.double_0 = double_1;
            if (this.gclass71_0.eventHandler_0 != null)
            {
                this.gclass71_0.eventHandler_0(this.gclass71_0, EventArgs.Empty);
            }
        }
    }

    public int method_7()
    {
        return this.int_0;
    }

    public long method_8()
    {
        return this.byte_0.LongLength / 16L;
    }

    public long method_9()
    {
        return this.byte_0.LongLength * 28L / 16L;
    }

    public double method_10()
    {
        return (double)(this.byte_0.LongLength * 28L / (long)(16 * this.int_0));
    }

    public void method_11(long long_1, float[] float_0, long long_2)
    {
        long num;
        long num2;
        checked
        {
            num = this.long_0[(int)((IntPtr)(unchecked(long_1 * 2L)))];
            num2 = this.long_0[(int)((IntPtr)(unchecked(long_1 * 2L + 1L)))];
        }
        GClass80.smethod_3(ref this.byte_0, long_1 * 16L, ref float_0, long_2, ref num, ref num2);
    }

    long[] long_0;

    GClass64 gclass64_0;

    GClass71 gclass71_0;

    double double_0;

    EventHandler eventHandler_0;

    int int_0;

    byte[] byte_0;
}
