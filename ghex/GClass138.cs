using System;
using System.Collections.Generic;

public class GClass138 : IComparer<MidiEvent>
{
    public int Compare(MidiEvent gclass139_0, MidiEvent gclass139_1)
    {
        if (gclass139_0.vmethod_2() == GEnum63.const_3 && gclass139_1.vmethod_2() == GEnum63.const_3)
        {
            bool flag = !((GClass143)gclass139_0).bool_0 || ((GClass143)gclass139_0).byte_1 == 0;
            bool flag2 = !((GClass143)gclass139_1).bool_0 || ((GClass143)gclass139_1).byte_1 == 0;
            return gclass139_0.int_0 - (flag ? 1 : 0) - (gclass139_1.int_0 - (flag2 ? 1 : 0));
        }
        return gclass139_0.int_0 - gclass139_1.int_0;
    }
}
