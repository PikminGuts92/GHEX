using System;
using System.Collections;
using System.Runtime.CompilerServices;

public abstract class GClass111 : CollectionBase
{
    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_0(GDelegate20 gdelegate20_2)
    {
        this.gdelegate20_0 = (GDelegate20)Delegate.Combine(this.gdelegate20_0, gdelegate20_2);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_1(GDelegate20 gdelegate20_2)
    {
        this.gdelegate20_0 = (GDelegate20)Delegate.Remove(this.gdelegate20_0, gdelegate20_2);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_2(GDelegate20 gdelegate20_2)
    {
        this.gdelegate20_1 = (GDelegate20)Delegate.Combine(this.gdelegate20_1, gdelegate20_2);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_3(GDelegate20 gdelegate20_2)
    {
        this.gdelegate20_1 = (GDelegate20)Delegate.Remove(this.gdelegate20_1, gdelegate20_2);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_4(GDelegate21 gdelegate21_4)
    {
        this.gdelegate21_0 = (GDelegate21)Delegate.Combine(this.gdelegate21_0, gdelegate21_4);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_5(GDelegate21 gdelegate21_4)
    {
        this.gdelegate21_0 = (GDelegate21)Delegate.Remove(this.gdelegate21_0, gdelegate21_4);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_6(GDelegate21 gdelegate21_4)
    {
        this.gdelegate21_1 = (GDelegate21)Delegate.Combine(this.gdelegate21_1, gdelegate21_4);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_7(GDelegate21 gdelegate21_4)
    {
        this.gdelegate21_1 = (GDelegate21)Delegate.Remove(this.gdelegate21_1, gdelegate21_4);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_8(GDelegate21 gdelegate21_4)
    {
        this.gdelegate21_2 = (GDelegate21)Delegate.Combine(this.gdelegate21_2, gdelegate21_4);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_9(GDelegate21 gdelegate21_4)
    {
        this.gdelegate21_2 = (GDelegate21)Delegate.Remove(this.gdelegate21_2, gdelegate21_4);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_10(GDelegate21 gdelegate21_4)
    {
        this.gdelegate21_3 = (GDelegate21)Delegate.Combine(this.gdelegate21_3, gdelegate21_4);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_11(GDelegate21 gdelegate21_4)
    {
        this.gdelegate21_3 = (GDelegate21)Delegate.Remove(this.gdelegate21_3, gdelegate21_4);
    }

    public GClass111()
    {
        this.int_0 = 0;
    }

    public void method_12()
    {
        this.int_0++;
    }

    public void method_13()
    {
        this.int_0--;
    }

    public bool method_14()
    {
        return this.int_0 > 0;
    }

    protected override void OnClear()
    {
        if (!this.method_14() && this.gdelegate20_0 != null)
        {
            this.gdelegate20_0();
        }
    }

    protected override void OnClearComplete()
    {
        if (!this.method_14() && this.gdelegate20_1 != null)
        {
            this.gdelegate20_1();
        }
    }

    protected override void OnInsert(int index, object value)
    {
        if (!this.method_14() && this.gdelegate21_0 != null)
        {
            this.gdelegate21_0(index, value);
        }
    }

    protected override void OnInsertComplete(int index, object value)
    {
        if (!this.method_14() && this.gdelegate21_1 != null)
        {
            this.gdelegate21_1(index, value);
        }
    }

    protected override void OnRemove(int index, object value)
    {
        if (!this.method_14() && this.gdelegate21_2 != null)
        {
            this.gdelegate21_2(index, value);
        }
    }

    protected override void OnRemoveComplete(int index, object value)
    {
        if (!this.method_14() && this.gdelegate21_3 != null)
        {
            this.gdelegate21_3(index, value);
        }
    }

    protected int method_15(object object_0)
    {
        return base.List.IndexOf(object_0);
    }

    int int_0;

    GDelegate20 gdelegate20_0;

    GDelegate20 gdelegate20_1;

    GDelegate21 gdelegate21_0;

    GDelegate21 gdelegate21_1;

    GDelegate21 gdelegate21_2;

    GDelegate21 gdelegate21_3;
}
