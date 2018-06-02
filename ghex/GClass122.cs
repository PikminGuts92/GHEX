using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public abstract class GClass122 : IDisposable
{
    public bool method_0()
    {
        return this.bool_0;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_1(GDelegate23 gdelegate23_1)
    {
        this.gdelegate23_0 = (GDelegate23)Delegate.Combine(this.gdelegate23_0, gdelegate23_1);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_2(GDelegate23 gdelegate23_1)
    {
        this.gdelegate23_0 = (GDelegate23)Delegate.Remove(this.gdelegate23_0, gdelegate23_1);
    }

    public string method_3()
    {
        return this.string_0;
    }

    public void method_4(string string_1)
    {
        this.string_0 = string_1;
        if (this.gdelegate23_0 != null)
        {
            this.gdelegate23_0(new GEventArgs14(this, GEnum59.const_1));
        }
    }

    public abstract Control vmethod_0();

    public virtual void vmethod_1(ToolStrip[] toolStrip_0)
    {
    }

    public virtual void vmethod_2()
    {
    }

    public GClass118 method_5()
    {
        return this.gclass118_0;
    }

    public void method_6(GClass118 gclass118_1)
    {
        this.gclass118_0 = gclass118_1;
        this.method_9(gclass118_1);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_7(GDelegate24 gdelegate24_1)
    {
        this.gdelegate24_0 = (GDelegate24)Delegate.Combine(this.gdelegate24_0, gdelegate24_1);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_8(GDelegate24 gdelegate24_1)
    {
        this.gdelegate24_0 = (GDelegate24)Delegate.Remove(this.gdelegate24_0, gdelegate24_1);
    }

    void method_9(GClass118 gclass118_1)
    {
        if (this.gdelegate24_0 != null)
        {
            this.gdelegate24_0(this, gclass118_1);
        }
    }

    public GInterface7 method_10()
    {
        return this.ginterface7_0;
    }

    void method_11()
    {
        foreach (GInterface7 ginterface in this.list_0)
        {
            ginterface.Dispose();
        }
        this.list_0.Clear();
        this.int_0 = 0;
        this.ginterface7_0 = null;
    }

    void method_12(bool bool_1)
    {
        if (bool_1 == this.bool_0)
        {
            if (bool_1)
            {
                this.vmethod_3(new GEventArgs14(this, GEnum59.const_0));
            }
            return;
        }
        this.bool_0 = bool_1;
        this.vmethod_3(new GEventArgs14(this, GEnum59.const_0));
    }

    protected virtual void vmethod_3(GEventArgs14 geventArgs14_0)
    {
        if (this.gdelegate23_0 != null)
        {
            this.gdelegate23_0(geventArgs14_0);
        }
    }

    public bool method_13()
    {
        return this.list_0.Count > 0 && this.int_0 >= 0;
    }

    public void method_14()
    {
        if (!this.method_13())
        {
            return;
        }
        GInterface7 ginterface = this.list_0[this.int_0--];
        this.ginterface7_0 = ginterface;
        ginterface.imethod_3();
        if (this.int_0 == -1)
        {
            this.method_12(false);
            return;
        }
        if (ginterface.imethod_0())
        {
            this.method_12(true);
        }
    }

    public bool method_15()
    {
        return this.list_0.Count > 0 && this.int_0 < this.list_0.Count - 1;
    }

    public void method_16()
    {
        if (!this.method_15())
        {
            return;
        }
        GInterface7 ginterface = this.list_0[++this.int_0];
        this.ginterface7_0 = ginterface;
        ginterface.imethod_4();
        if (ginterface.imethod_0())
        {
            this.method_12(true);
        }
    }

    public void method_17(GInterface7 ginterface7_1)
    {
        try
        {
            if (!ginterface7_1.imethod_1())
            {
                if (MessageBox.Show("This action can not be undone.\nAre you sure you want to proceed?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                this.method_11();
            }
            ginterface7_1.imethod_2(this);
            this.ginterface7_0 = ginterface7_1;
            if (ginterface7_1.imethod_1())
            {
                if (this.list_0.Count > 0 && this.int_0 != this.list_0.Count - 1)
                {
                    for (int i = this.int_0 + 1; i < this.list_0.Count; i++)
                    {
                        this.list_0[i].Dispose();
                    }
                    this.list_0.RemoveRange(this.int_0 + 1, this.list_0.Count - (this.int_0 + 1));
                }
                this.list_0.Add(ginterface7_1);
                this.int_0 = this.list_0.IndexOf(ginterface7_1);
            }
            if (ginterface7_1.imethod_0())
            {
                this.method_12(true);
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    protected abstract void vmethod_4();

    public void method_18()
    {
        if (!this.method_0())
        {
            return;
        }
        try
        {
            this.vmethod_4();
            this.method_12(false);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void Dispose()
    {
        if (this.vmethod_0() != null)
        {
            this.vmethod_0().Dispose();
        }
        this.method_11();
    }

    int int_0 = -1;

    List<GInterface7> list_0 = new List<GInterface7>();

    bool bool_0;

    string string_0 = "";

    GDelegate23 gdelegate23_0;

    GClass118 gclass118_0;

    GDelegate24 gdelegate24_0;

    GInterface7 ginterface7_0;
}
