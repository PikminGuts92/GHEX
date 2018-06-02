using System;
using System.Collections.Generic;

public class GClass89 : MidiTrack
{
    public GClass89(MidiFile gclass120_1) : base(gclass120_1)
    {
    }

    public override void vmethod_0(List<MidiEvent> list_1)
    {
        base.Events().AddRange(list_1);
        list_1.Clear();
    }

    public override void vmethod_1(List<MidiEvent> list_1)
    {
        list_1.AddRange(base.Events());
    }
}
