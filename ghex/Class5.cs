using System;

class Class5 : Class3
{
    int method_0(GClass108 gclass108_0, object object_0, float[][] float_0, int int_1)
    {
        return 0;
    }

    public override int vmethod_6(GClass108 gclass108_0, object object_0, float[][] float_0, int[] int_1, int int_2)
    {
        int num = 0;
        for (int i = 0; i < int_2; i++)
        {
            if (int_1[i] != 0)
            {
                float_0[num++] = float_0[i];
            }
        }
        if (num != 0)
        {
            return Class3.smethod_0(gclass108_0, object_0, float_0, num, 1);
        }
        return 0;
    }
}
