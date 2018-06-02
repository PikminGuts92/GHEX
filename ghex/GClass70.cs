using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
public class GClass70 : CollectionBase
{
    public GClass70(GClass83 gclass83_1)
    {
        if (gclass83_1 == null)
        {
            throw new ArgumentNullException("owner");
        }
        this.gclass83_0 = gclass83_1;
    }

    public int method_0(GClass97 gclass97_0)
    {
        if (gclass97_0 == null)
        {
            throw new ArgumentNullException("Cell is null");
        }
        int num = base.List.Add(gclass97_0);
        this.vmethod_0(new GEventArgs6(this.gclass83_0, gclass97_0, num, num));
        return num;
    }

    public void method_1(GClass97[] gclass97_0)
    {
        if (gclass97_0 == null)
        {
            throw new ArgumentNullException("Cell[] is null");
        }
        for (int i = 0; i < gclass97_0.Length; i++)
        {
            this.method_0(gclass97_0[i]);
        }
    }

    public void method_2(GClass97 gclass97_0)
    {
        int num = this.method_8(gclass97_0);
        if (num != -1)
        {
            this.method_4(num);
        }
    }

    public void method_3(GClass97[] gclass97_0)
    {
        if (gclass97_0 == null)
        {
            throw new ArgumentNullException("Cell[] is null");
        }
        for (int i = 0; i < gclass97_0.Length; i++)
        {
            this.method_2(gclass97_0[i]);
        }
    }

    public void method_4(int int_0)
    {
        if (int_0 >= 0 && int_0 < base.Count)
        {
            GClass97 gclass97_ = this.method_9(int_0);
            base.List.RemoveAt(int_0);
            this.vmethod_1(new GEventArgs6(this.gclass83_0, gclass97_, int_0, int_0));
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
            this.method_9(i).method_49(null);
        }
        base.Clear();
        base.InnerList.Capacity = 0;
        this.vmethod_1(new GEventArgs6(this.gclass83_0, null, -1, -1));
    }

    public void method_6(int int_0, GClass97 gclass97_0)
    {
        if (gclass97_0 == null)
        {
            return;
        }
        if (int_0 < 0)
        {
            throw new IndexOutOfRangeException();
        }
        if (int_0 >= base.Count)
        {
            this.method_0(gclass97_0);
            return;
        }
        base.List.Insert(int_0, gclass97_0);
        this.vmethod_0(new GEventArgs6(this.gclass83_0, gclass97_0, int_0, int_0));
    }

    public void method_7(int int_0, GClass97[] gclass97_0)
    {
        if (gclass97_0 == null)
        {
            throw new ArgumentNullException("Cell[] is null");
        }
        if (int_0 < 0)
        {
            throw new IndexOutOfRangeException();
        }
        if (int_0 >= base.Count)
        {
            this.method_1(gclass97_0);
            return;
        }
        for (int i = gclass97_0.Length - 1; i >= 0; i--)
        {
            this.method_6(int_0, gclass97_0[i]);
        }
    }

    public int method_8(GClass97 gclass97_0)
    {
        for (int i = 0; i < base.Count; i++)
        {
            if (this.method_9(i) == gclass97_0)
            {
                return i;
            }
        }
        return -1;
    }

    public GClass97 method_9(int int_0)
    {
        if (int_0 >= 0 && int_0 < base.Count)
        {
            return base.List[int_0] as GClass97;
        }
        return null;
    }

    protected virtual void vmethod_0(GEventArgs6 geventArgs6_0)
    {
        this.gclass83_0.vmethod_1(geventArgs6_0);
    }

    protected virtual void vmethod_1(GEventArgs6 geventArgs6_0)
    {
        this.gclass83_0.vmethod_2(geventArgs6_0);
    }

    GClass83 gclass83_0;
}
