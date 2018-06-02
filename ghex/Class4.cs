using System;

class Class4 : Class3
{
    public override int vmethod_5(GClass108 gclass108_0, object object_0, float[][] float_0, int int_1)
    {
        return 0;
    }

    public override int vmethod_6(GClass108 gclass108_0, object object_0, float[][] float_0, int[] int_1, int int_2)
    {
        int num = 0;
        while (num < int_2 && int_1[num] == 0)
        {
            num++;
        }
        if (num == int_2)
        {
            return 0;
        }
        return Class3.smethod_1(gclass108_0, object_0, float_0, int_2);
    }
}
