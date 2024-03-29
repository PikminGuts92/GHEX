﻿using System;
using System.Collections.Generic;

public class GClass87 : MidiTrack
{
    public GClass87(MidiFile gclass120_1) : base(gclass120_1)
    {
    }

    public GClass87(MidiFile gclass120_1, string string_1) : base(gclass120_1, string_1)
    {
    }

    protected bool method_7(MidiEvent gclass139_0, int int_0)
    {
        return gclass139_0.vmethod_2() == GEnum63.const_3 && (int)((GClass143)gclass139_0).byte_0 == int_0 && (!((GClass143)gclass139_0).bool_0 || ((GClass143)gclass139_0).byte_1 == 0);
    }

    protected GClass143 method_8(List<MidiEvent> list_1, int int_0, int int_1)
    {
        for (int i = int_0; i < list_1.Count; i++)
        {
            MidiEvent gclass = list_1[i];
            if (this.method_7(gclass, int_1))
            {
                return (GClass143)gclass;
            }
        }
        throw new Exception("No end found for trigger: " + int_1);
    }

    public override void vmethod_0(List<MidiEvent> list_1)
    {
        List<MidiEvent> list = new List<MidiEvent>();
        for (int i = 0; i < list_1.Count; i++)
        {
            MidiEvent gclass = list_1[i];
            GEnum63 genum = gclass.vmethod_2();
            if (genum != GEnum63.const_0)
            {
                if (genum == GEnum63.const_3)
                {
                    GClass143 gclass2 = (GClass143)gclass;
                    if (gclass2.bool_0 && gclass2.byte_1 > 0)
                    {
                        GClass143 gclass3 = null;
                        int j = i + 1;
                        while (j < list_1.Count)
                        {
                            MidiEvent gclass4 = list_1[j];
                            if (!this.method_7(gclass4, (int)gclass2.byte_0))
                            {
                                j++;
                            }
                            else
                            {
                                gclass3 = (GClass143)gclass4;
                                list.Add(gclass4);

                                if (gclass3 != null)
                                {
                                    base.Events().Add(new GClass144(gclass2.int_0, gclass3.int_0 - gclass2.int_0, (int)gclass2.byte_0));
                                    list.Add(gclass);
                                    goto IL_104;
                                }
                                goto IL_14A;
                            }
                        }
                        goto Block_6;
                        IL_14A:
                        throw new Exception("No end found for trigger: " + gclass2.byte_0);
                        Block_6:
                        if (gclass3 != null)
                        {
                            base.Events().Add(new GClass144(gclass2.int_0, gclass3.int_0 - gclass2.int_0, (int)gclass2.byte_0));
                            list.Add(gclass);
                            goto IL_104;
                        }
                        goto IL_14A;
                    }
                }
            }
            else
            {
                base.Events().Add(new GClass140(gclass.int_0, ((GClass140)gclass).genum64_0, ((GClass140)gclass).string_0.Trim()));
                list.Add(gclass);
            }
            IL_104:;
        }
        using (List<MidiEvent>.Enumerator enumerator = list.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                MidiEvent item = enumerator.Current;
                list_1.Remove(item);
            }
            return;
        }
        //goto IL_14A; TODO: Figure out if this was needed?
    }

    protected void method_9(MidiEvent gclass139_0, List<MidiEvent> list_1, GEnum54 genum54_0)
    {
        GEnum63 genum = gclass139_0.vmethod_2();
        if (genum == GEnum63.const_0)
        {
            string string_ = ((GClass140)gclass139_0).string_0;
            list_1.Add(new GClass140
            {
                int_0 = gclass139_0.int_0,
                genum64_0 = ((GClass140)gclass139_0).genum64_0,
                string_0 = ((genum54_0 == GEnum54.const_1) ? string_ : ("[" + string_ + "]"))
            });
            return;
        }
        if (genum == GEnum63.const_8)
        {
            base.method_4(gclass139_0, ((GClass144)gclass139_0).int_2, list_1);
            return;
        }
        throw new NotImplementedException(gclass139_0.vmethod_2().ToString());
    }

    public override void vmethod_1(List<MidiEvent> list_1)
    {
        GEnum54 genum54_ = base.Parent().method_3();
        foreach (MidiEvent gclass139_ in base.Events())
        {
            this.method_9(gclass139_, list_1, genum54_);
        }
    }
}
