using System;
using System.Collections;
using System.Reflection;

[DefaultMember("Item")]
public class GClass85 : CollectionBase
{
    public GClass85(GClass32 gclass32_1)
    {
        if (gclass32_1 == null)
        {
            throw new ArgumentNullException("owner");
        }
        this.gclass32_0 = gclass32_1;
        this.int_0 = 0;
        this.int_1 = 0;
        this.int_2 = 0;
        this.int_3 = -1;
    }

    public int method_0(GClass17 gclass17_0)
    {
        if (gclass17_0 == null)
        {
            throw new ArgumentNullException("Column is null");
        }
        int result = base.List.Add(gclass17_0);
        this.method_7();
        this.vmethod_0(new GClass90(this.gclass32_0, gclass17_0, result, result));
        return result;
    }

    public void method_1(GClass17[] gclass17_0)
    {
        if (gclass17_0 == null)
        {
            throw new ArgumentNullException("Column[] is null");
        }
        for (int i = 0; i < gclass17_0.Length; i++)
        {
            this.method_0(gclass17_0[i]);
        }
    }

    public void method_2(GClass17 gclass17_0)
    {
        int num = this.method_6(gclass17_0);
        if (num != -1)
        {
            this.method_4(num);
        }
    }

    public void method_3(GClass17[] gclass17_0)
    {
        if (gclass17_0 == null)
        {
            throw new ArgumentNullException("Column[] is null");
        }
        for (int i = 0; i < gclass17_0.Length; i++)
        {
            this.method_2(gclass17_0[i]);
        }
    }

    public void method_4(int int_4)
    {
        if (int_4 >= 0 && int_4 < base.Count)
        {
            GClass17 gclass17_ = this.method_8(int_4);
            base.List.RemoveAt(int_4);
            this.method_7();
            this.vmethod_1(new GClass90(this.gclass32_0, gclass17_, int_4, int_4));
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
            this.method_8(i).method_41(null);
        }
        base.Clear();
        base.InnerList.Capacity = 0;
        this.method_7();
        this.vmethod_1(new GClass90(this.gclass32_0, null, -1, -1));
    }

    public int method_6(GClass17 gclass17_0)
    {
        for (int i = 0; i < base.Count; i++)
        {
            if (this.method_8(i) == gclass17_0)
            {
                return i;
            }
        }
        return -1;
    }

    protected internal void method_7()
    {
        int num = 0;
        int num2 = 0;
        int num3 = 0;
        for (int i = 0; i < base.Count; i++)
        {
            num += this.method_8(i).method_9();
            if (this.method_8(i).method_19())
            {
                this.method_8(i).method_37(num2);
                num2 += this.method_8(i).method_9();
                num3++;
            }
        }
        this.int_0 = num;
        this.int_1 = num2;
        this.int_2 = num3;
    }

    public GClass17 method_8(int int_4)
    {
        if (int_4 >= 0 && int_4 < base.Count)
        {
            return base.List[int_4] as GClass17;
        }
        return null;
    }

    public GClass32 method_9()
    {
        return this.gclass32_0;
    }

    internal int method_10()
    {
        return this.int_0;
    }

    internal int method_11()
    {
        return this.int_1;
    }

    internal int method_12()
    {
        return this.int_2;
    }

    internal int method_13()
    {
        return this.int_3;
    }

    protected virtual void vmethod_0(GClass90 gclass90_0)
    {
        this.gclass32_0.vmethod_0(gclass90_0);
    }

    protected virtual void vmethod_1(GClass90 gclass90_0)
    {
        this.gclass32_0.vmethod_1(gclass90_0);
    }

    GClass32 gclass32_0;

    int int_0;

    int int_1;

    int int_2;

    int int_3;
}
