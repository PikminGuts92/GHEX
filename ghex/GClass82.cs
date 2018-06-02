using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
public class GClass82 : CollectionBase
{
    public GClass82(GClass104 gclass104_1)
    {
        if (gclass104_1 == null)
        {
            throw new ArgumentNullException("owner");
        }
        this.gclass104_0 = gclass104_1;
    }

    public int method_0(GClass83 gclass83_0)
    {
        if (gclass83_0 == null)
        {
            throw new ArgumentNullException("Row is null");
        }
        int num = base.List.Add(gclass83_0);
        this.vmethod_0(new GEventArgs9(this.gclass104_0, gclass83_0, num, num));
        return num;
    }

    public void method_1(GClass83[] gclass83_0)
    {
        if (gclass83_0 == null)
        {
            throw new ArgumentNullException("Row[] is null");
        }
        for (int i = 0; i < gclass83_0.Length; i++)
        {
            this.method_0(gclass83_0[i]);
        }
    }

    public void method_2(GClass83 gclass83_0)
    {
        int num = this.method_8(gclass83_0);
        if (num != -1)
        {
            this.method_4(num);
        }
    }

    public void method_3(GClass83[] gclass83_0)
    {
        if (gclass83_0 == null)
        {
            throw new ArgumentNullException("Row[] is null");
        }
        for (int i = 0; i < gclass83_0.Length; i++)
        {
            this.method_2(gclass83_0[i]);
        }
    }

    public void method_4(int int_0)
    {
        if (int_0 >= 0 && int_0 < base.Count)
        {
            GClass83 gclass83_ = this.method_9(int_0);
            base.List.RemoveAt(int_0);
            this.vmethod_1(new GEventArgs9(this.gclass104_0, gclass83_, int_0, int_0));
        }
    }

    public void method_5()
    {
        if (base.Count == 0)
        {
            return;
        }
        for (int i = 0; i < base.Count; i++)
        {
            this.method_9(i).method_33(null);
        }
        base.Clear();
        base.InnerList.Capacity = 0;
        this.gclass104_0.vmethod_1(new GEventArgs9(this.gclass104_0, null, -1, -1));
    }

    public void method_6(int int_0, GClass83 gclass83_0)
    {
        if (gclass83_0 == null)
        {
            return;
        }
        if (int_0 < 0)
        {
            throw new IndexOutOfRangeException();
        }
        if (int_0 >= base.Count)
        {
            this.method_0(gclass83_0);
            return;
        }
        base.List.Insert(int_0, gclass83_0);
        this.gclass104_0.vmethod_0(new GEventArgs9(this.gclass104_0, gclass83_0, int_0, int_0));
    }

    public void method_7(int int_0, GClass83[] gclass83_0)
    {
        if (gclass83_0 == null)
        {
            throw new ArgumentNullException("Row[] is null");
        }
        if (int_0 < 0)
        {
            throw new IndexOutOfRangeException();
        }
        if (int_0 >= base.Count)
        {
            this.method_1(gclass83_0);
            return;
        }
        for (int i = gclass83_0.Length - 1; i >= 0; i--)
        {
            this.method_6(int_0, gclass83_0[i]);
        }
    }

    public int method_8(GClass83 gclass83_0)
    {
        for (int i = 0; i < base.Count; i++)
        {
            if (this.method_9(i) == gclass83_0)
            {
                return i;
            }
        }
        return -1;
    }

    public GClass83 method_9(int int_0)
    {
        if (int_0 >= 0 && int_0 < base.Count)
        {
            return base.List[int_0] as GClass83;
        }
        return null;
    }

    internal void method_10(int int_0, GClass83 gclass83_0)
    {
        if (int_0 < 0 || int_0 >= base.Count)
        {
            throw new ArgumentOutOfRangeException("value");
        }
        if (gclass83_0 == null)
        {
            throw new ArgumentNullException("row cannot be null");
        }
        base.List[int_0] = gclass83_0;
        gclass83_0.method_36(int_0);
    }

    protected virtual void vmethod_0(GEventArgs9 geventArgs9_0)
    {
        this.gclass104_0.vmethod_0(geventArgs9_0);
    }

    protected virtual void vmethod_1(GEventArgs9 geventArgs9_0)
    {
        this.gclass104_0.vmethod_1(geventArgs9_0);
    }

    GClass104 gclass104_0;
}
