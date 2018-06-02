using System;

public class GClass142 : MidiEvent
{
    internal GClass142(float float_0)
    {
        this.int_1 = Class109.smethod_13(float_0);
    }

    public override int vmethod_0()
    {
        return 0;
    }

    public override void vmethod_1(int int_2)
    {
    }

    public override GEnum63 vmethod_2()
    {
        return GEnum63.const_2;
    }

    public override string ToString()
    {
        return this.int_0.ToString() + ": bpm=" + Class109.smethod_12(this.int_1);
    }

    public int int_1;
}
