using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class GClass136
{
    GClass136()
    {
    }

    public static GClass136 smethod_0(MidiFile gclass120_0)
    {
        GClass136 gclass = new GClass136();
        foreach (MidiTrack gclass2 in gclass120_0.GetTracks())
        {
            if (gclass2 is GClass88)
            {
                GClass35 gclass3 = new GClass35(gclass);
                GClass88 gclass4 = gclass2 as GClass88;
                gclass3.method_18(gclass4.method_1());
                for (int i = 0; i < 4; i++)
                {
                    GEnum53 genum = (GEnum53)i;
                    gclass.method_0(gclass120_0, gclass4.method_13(genum), (GEnum50)genum, gclass3);
                }
                gclass.list_0.Add(gclass3);
            }
            else if (gclass2 is GClass89)
            {
                GClass36 gclass5 = new GClass36(gclass);
                GClass89 gclass6 = gclass2 as GClass89;
                gclass5.method_18("Tempo");
                gclass.method_0(gclass120_0, gclass6.Events(), GEnum50.const_4, gclass5);
                gclass.list_0.Insert(0, gclass5);
                gclass.gclass36_0 = gclass5;
            }
        }
        GClass114 gclass7 = null;
        foreach (GClass34 gclass8 in gclass.method_12())
        {
            GClass114 gclass9 = gclass8.method_4(GEnum50.const_5);
            if (gclass7 == null || (gclass9 != null && gclass9.method_2() + gclass9.method_7() > gclass7.method_2() + gclass7.method_7()))
            {
                gclass7 = gclass9;
            }
        }
        if (gclass7 != null)
        {
            gclass.method_6(gclass7.method_2() + gclass7.method_7());
        }
        else
        {
            gclass.method_6(gclass.method_9());
        }
        return gclass;
    }

    void method_0(MidiFile gclass120_0, List<MidiEvent> list_1, GEnum50 genum50_0, GClass34 gclass34_0)
    {
        foreach (MidiEvent gclass in list_1)
        {
            int num = gclass.int_0;
            int int_ = gclass.vmethod_0();
            GClass114 gclass2 = null;
            switch (gclass.vmethod_2())
            {
            case GEnum63.const_1:
            {
                GClass117 gclass3 = new GClass117(gclass34_0 as GClass36, genum50_0, (gclass as GClass141).int_1, (gclass as GClass141).genum52_0, (gclass as GClass141).int_3, (gclass as GClass141).int_2, num);
                gclass2 = gclass3;
                break;
            }
            case GEnum63.const_2:
            {
                GClass116 gclass4 = new GClass116(gclass34_0 as GClass36, genum50_0, (gclass as GClass142).int_1, num);
                gclass2 = gclass4;
                break;
            }
            case GEnum63.const_4:
            {
                GClass115 gclass5 = new GClass115(gclass34_0 as GClass35, genum50_0, (gclass as GClass145).list_0, num, int_);
                gclass2 = gclass5;
                break;
            }
            }
            if (gclass2 != null)
            {
                gclass34_0.method_7(gclass2);
            }
        }
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_1(EventHandler eventHandler_2)
    {
        this.eventHandler_0 = (EventHandler)Delegate.Combine(this.eventHandler_0, eventHandler_2);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_2(EventHandler eventHandler_2)
    {
        this.eventHandler_0 = (EventHandler)Delegate.Remove(this.eventHandler_0, eventHandler_2);
    }

    public double method_3()
    {
        return this.double_0;
    }

    public void method_4(double double_1)
    {
        if (double_1 == this.double_0)
        {
            return;
        }
        this.double_0 = double_1;
        this.int_0 = this.method_11().method_22(this.double_0);
        if (this.eventHandler_0 != null)
        {
            this.eventHandler_0(this, EventArgs.Empty);
        }
    }

    public int method_5()
    {
        return this.int_0;
    }

    public void method_6(int int_2)
    {
        if (int_2 == this.int_0)
        {
            return;
        }
        this.int_0 = int_2;
        if (this.method_11().method_23().Count == 0)
        {
            this.method_11().method_24(0);
        }
        this.double_0 = this.method_11().method_20(this.int_0);
        if (this.eventHandler_0 != null)
        {
            this.eventHandler_0(this, EventArgs.Empty);
        }
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_7(EventHandler eventHandler_2)
    {
        this.eventHandler_1 = (EventHandler)Delegate.Combine(this.eventHandler_1, eventHandler_2);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_8(EventHandler eventHandler_2)
    {
        this.eventHandler_1 = (EventHandler)Delegate.Remove(this.eventHandler_1, eventHandler_2);
    }

    public int method_9()
    {
        return this.int_1;
    }

    public void method_10(int int_2)
    {
        if (int_2 != this.int_1)
        {
            this.int_1 = int_2;
            if (this.eventHandler_1 != null)
            {
                this.eventHandler_1(this, EventArgs.Empty);
            }
        }
    }

    public GClass36 method_11()
    {
        return this.gclass36_0;
    }

    public GClass34[] method_12()
    {
        return this.list_0.ToArray();
    }

    public GClass34 method_13(string string_0)
    {
        foreach (GClass34 gclass in this.list_0)
        {
            if (string.Compare(gclass.method_17(), string_0, true) == 0)
            {
                return gclass;
            }
        }
        return null;
    }

    public GClass72 method_14()
    {
        return this.gclass72_0;
    }

    double double_0;

    EventHandler eventHandler_0;

    int int_0;

    int int_1 = 480;

    EventHandler eventHandler_1;

    GClass36 gclass36_0;

    List<GClass34> list_0 = new List<GClass34>();

    GClass72 gclass72_0 = new GClass72();
}
