using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

[DefaultMember("Item")]
public class GClass112 : GClass111
{
    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_16(CollectionChangeEventHandler collectionChangeEventHandler_1)
    {
        this.collectionChangeEventHandler_0 = (CollectionChangeEventHandler)Delegate.Combine(this.collectionChangeEventHandler_0, collectionChangeEventHandler_1);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_17(CollectionChangeEventHandler collectionChangeEventHandler_1)
    {
        this.collectionChangeEventHandler_0 = (CollectionChangeEventHandler)Delegate.Remove(this.collectionChangeEventHandler_0, collectionChangeEventHandler_1);
    }

    public GClass112()
    {
        this.int_1 = 0;
    }

    public GClass98 method_18(int int_2)
    {
        if (int_2 >= 0 && base.List.Count - 1 >= int_2)
        {
            return (GClass98)base.List[int_2];
        }
        return null;
    }

    public void method_19(int int_2, GClass98 gclass98_0)
    {
        base.List[int_2] = gclass98_0;
    }

    public virtual int vmethod_0()
    {
        int count = base.Count;
        int num = 0;
        if (count == 0)
        {
            return 0;
        }
        for (int i = 0; i < count; i++)
        {
            if (this.method_18(i).method_8())
            {
                num++;
            }
        }
        return num;
    }

    public virtual GClass98 vmethod_1()
    {
        for (int i = base.Count - 1; i > 0; i--)
        {
            if (this.method_18(i).method_4())
            {
                return this.method_18(i);
            }
        }
        return null;
    }

    public virtual GClass98 vmethod_2()
    {
        for (int i = 0; i < base.Count; i++)
        {
            if (this.method_18(i).method_4())
            {
                return this.method_18(i);
            }
        }
        return null;
    }

    public virtual int vmethod_3()
    {
        int count = base.Count;
        int num = 0;
        if (count == 0)
        {
            return 0;
        }
        for (int i = 0; i < count; i++)
        {
            if (this.method_18(i).method_4())
            {
                num++;
            }
        }
        return num;
    }

    protected virtual void vmethod_4(CollectionChangeEventArgs collectionChangeEventArgs_0)
    {
        if (this.collectionChangeEventHandler_0 != null)
        {
            this.collectionChangeEventHandler_0(this, collectionChangeEventArgs_0);
        }
    }

    protected virtual void vmethod_5()
    {
        this.int_1++;
    }

    protected virtual void vmethod_6()
    {
        if (--this.int_1 == 0)
        {
            this.vmethod_4(new CollectionChangeEventArgs(CollectionChangeAction.Refresh, null));
        }
    }

    public virtual void vmethod_7(GClass98[] gclass98_0)
    {
        this.vmethod_5();
        try
        {
            foreach (GClass98 value in gclass98_0)
            {
                base.List.Add(value);
            }
        }
        finally
        {
            this.vmethod_6();
        }
    }

    public virtual void vmethod_8(GClass112 gclass112_0)
    {
        this.vmethod_5();
        try
        {
            base.Clear();
            for (int i = 0; i < gclass112_0.Count; i++)
            {
                GClass98 gclass98_ = gclass112_0.method_18(i);
                GClass98 gclass = new GClass98();
                gclass.method_24(gclass98_);
                this.vmethod_9(gclass);
            }
        }
        finally
        {
            this.vmethod_6();
        }
    }

    public virtual int vmethod_9(GClass98 gclass98_0)
    {
        int num = this.vmethod_12(gclass98_0);
        if (num == -1)
        {
            num = base.List.Add(gclass98_0);
        }
        return num;
    }

    public virtual void vmethod_10(GClass98 gclass98_0)
    {
        if (base.List.Contains(gclass98_0))
        {
            base.List.Remove(gclass98_0);
        }
    }

    public virtual GClass98 vmethod_11(int int_2, GClass98 gclass98_0)
    {
        int num = base.List.IndexOf(gclass98_0);
        if (num >= 0)
        {
            base.RemoveAt(num);
            this.vmethod_14(0, gclass98_0);
            return gclass98_0;
        }
        return null;
    }

    public virtual int vmethod_12(GClass98 gclass98_0)
    {
        return base.List.IndexOf(gclass98_0);
    }

    public virtual bool vmethod_13(GClass98 gclass98_0)
    {
        return base.List.Contains(gclass98_0);
    }

    public virtual void vmethod_14(int int_2, GClass98 gclass98_0)
    {
        if (this.vmethod_13(gclass98_0))
        {
            return;
        }
        base.List.Insert(int_2, gclass98_0);
    }

    protected override void OnInsertComplete(int index, object value)
    {
        GClass98 gclass = value as GClass98;
        gclass.method_0(new EventHandler(this.vmethod_15));
        this.vmethod_4(new CollectionChangeEventArgs(CollectionChangeAction.Add, value));
    }

    protected override void OnRemove(int index, object value)
    {
        base.OnRemove(index, value);
        GClass98 gclass = value as GClass98;
        gclass.method_1(new EventHandler(this.vmethod_15));
        this.vmethod_4(new CollectionChangeEventArgs(CollectionChangeAction.Remove, value));
    }

    protected override void OnClear()
    {
        if (base.Count == 0)
        {
            return;
        }
        this.vmethod_5();
        try
        {
            for (int i = base.Count - 1; i >= 0; i--)
            {
                base.RemoveAt(i);
            }
        }
        finally
        {
            this.vmethod_6();
        }
    }

    protected virtual void vmethod_15(object sender, EventArgs e)
    {
        this.vmethod_4(new CollectionChangeEventArgs(CollectionChangeAction.Refresh, sender));
    }

    CollectionChangeEventHandler collectionChangeEventHandler_0;

    int int_1;
}
