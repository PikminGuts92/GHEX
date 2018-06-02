using System;
using System.Runtime.CompilerServices;

class Class3 : Class2
{
    public override void vmethod_0(object object_0, GClass37 gclass37_0)
    {
        Class17 @class = (Class17)object_0;
        int num = 0;
        gclass37_0.method_6(@class.int_0, 24);
        gclass37_0.method_6(@class.int_1, 24);
        gclass37_0.method_6(@class.int_2 - 1, 24);
        gclass37_0.method_6(@class.int_3 - 1, 6);
        gclass37_0.method_6(@class.int_4, 8);
        for (int i = 0; i < @class.int_3; i++)
        {
            if (Class3.smethod_2(@class.int_5[i]) > 3)
            {
                gclass37_0.method_6(@class.int_5[i], 3);
                gclass37_0.method_6(1, 1);
                gclass37_0.method_6(@class.int_5[i] >> 3, 5);
            }
            else
            {
                gclass37_0.method_6(@class.int_5[i], 4);
            }
            num += Class3.smethod_3(@class.int_5[i]);
        }
        for (int j = 0; j < num; j++)
        {
            gclass37_0.method_6(@class.int_6[j], 8);
        }
    }

    public override object vmethod_1(GClass100 gclass100_0, GClass37 gclass37_0)
    {
        int num = 0;
        Class17 @class = new Class17();
        @class.int_0 = gclass37_0.method_12(24);
        @class.int_1 = gclass37_0.method_12(24);
        @class.int_2 = gclass37_0.method_12(24) + 1;
        @class.int_3 = gclass37_0.method_12(6) + 1;
        @class.int_4 = gclass37_0.method_12(8);
        for (int i = 0; i < @class.int_3; i++)
        {
            int num2 = gclass37_0.method_12(3);
            if (gclass37_0.method_12(1) != 0)
            {
                num2 |= gclass37_0.method_12(5) << 3;
            }
            @class.int_5[i] = num2;
            num += Class3.smethod_3(num2);
        }
        for (int j = 0; j < num; j++)
        {
            @class.int_6[j] = gclass37_0.method_12(8);
        }
        if (@class.int_4 >= gclass100_0.int_19)
        {
            this.vmethod_3(@class);
            return null;
        }
        for (int k = 0; k < num; k++)
        {
            if (@class.int_6[k] >= gclass100_0.int_19)
            {
                this.vmethod_3(@class);
                return null;
            }
        }
        return @class;
    }

    public override object vmethod_2(GClass101 gclass101_0, Class6 class6_0, object object_0)
    {
        Class17 @class = (Class17)object_0;
        Class16 class2 = new Class16();
        int num = 0;
        int num2 = 0;
        class2.class17_0 = @class;
        class2.int_0 = class6_0.int_3;
        class2.int_1 = @class.int_3;
        class2.class112_0 = gclass101_0.class112_0;
        class2.class112_1 = gclass101_0.class112_0[@class.int_4];
        int num3 = class2.class112_1.int_0;
        class2.int_3 = new int[class2.int_1][];
        for (int i = 0; i < class2.int_1; i++)
        {
            int num4 = Class3.smethod_2(@class.int_5[i]);
            if (num4 != 0)
            {
                if (num4 > num2)
                {
                    num2 = num4;
                }
                class2.int_3[i] = new int[num4];
                for (int j = 0; j < num4; j++)
                {
                    if ((@class.int_5[i] & 1 << j) != 0)
                    {
                        class2.int_3[i][j] = @class.int_6[num++];
                    }
                }
            }
        }
        class2.int_4 = (int)Math.Round(Math.Pow((double)class2.int_1, (double)num3));
        class2.int_2 = num2;
        class2.int_5 = new int[class2.int_4][];
        for (int k = 0; k < class2.int_4; k++)
        {
            int num5 = k;
            int num6 = class2.int_4 / class2.int_1;
            class2.int_5[k] = new int[num3];
            for (int l = 0; l < num3; l++)
            {
                int num7 = num5 / num6;
                num5 -= num7 * num6;
                num6 /= class2.int_1;
                class2.int_5[k][l] = num7;
            }
        }
        return class2;
    }

    public override void vmethod_3(object object_0)
    {
    }

    public override void vmethod_4(object object_0)
    {
    }

    public override int vmethod_5(GClass108 gclass108_0, object object_0, float[][] float_0, int int_1)
    {
        return 0;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    internal static int smethod_0(GClass108 gclass108_0, object object_0, float[][] float_0, int int_1, int int_2)
    {
        Class16 @class = (Class16)object_0;
        Class17 class17_ = @class.class17_0;
        int int_3 = class17_.int_2;
        int num = @class.class112_1.int_0;
        int num2 = class17_.int_1 - class17_.int_0;
        int num3 = num2 / int_3;
        int num4 = (num3 + num - 1) / num;
        if (Class3.int_0.Length < int_1)
        {
            Class3.int_0 = new int[int_1][][];
            for (int i = 0; i < int_1; i++)
            {
                Class3.int_0[i] = new int[num4][];
            }
        }
        else
        {
            for (int i = 0; i < int_1; i++)
            {
                if (Class3.int_0[i] == null || Class3.int_0[i].Length < num4)
                {
                    Class3.int_0[i] = new int[num4][];
                }
            }
        }
        for (int j = 0; j < @class.int_2; j++)
        {
            int k = 0;
            int num5 = 0;
            while (k < num3)
            {
                if (j == 0)
                {
                    for (int i = 0; i < int_1; i++)
                    {
                        int num6 = @class.class112_1.method_8(gclass108_0.gclass37_0);
                        if (num6 == -1)
                        {
                            return 0;
                        }
                        Class3.int_0[i][num5] = @class.int_5[num6];
                        if (Class3.int_0[i][num5] == null)
                        {
                            return 0;
                        }
                    }
                }
                int num7 = 0;
                while (num7 < num && k < num3)
                {
                    for (int i = 0; i < int_1; i++)
                    {
                        int int_4 = class17_.int_0 + k * int_3;
                        if ((class17_.int_5[Class3.int_0[i][num5][num7]] & 1 << j) != 0)
                        {
                            Class112 class2 = @class.class112_0[@class.int_3[Class3.int_0[i][num5][num7]][j]];
                            if (class2 != null)
                            {
                                if (int_2 == 0)
                                {
                                    if (class2.method_4(float_0[i], int_4, gclass108_0.gclass37_0, int_3) == -1)
                                    {
                                        return 0;
                                    }
                                }
                                else if (int_2 == 1 && class2.method_5(float_0[i], int_4, gclass108_0.gclass37_0, int_3) == -1)
                                {
                                    return 0;
                                }
                            }
                        }
                    }
                    num7++;
                    k++;
                }
                num5++;
            }
        }
        return 0;
    }

    internal static int smethod_1(GClass108 gclass108_0, object object_0, float[][] float_0, int int_1)
    {
        Class16 @class = (Class16)object_0;
        Class17 class17_ = @class.class17_0;
        int int_2 = class17_.int_2;
        int num = @class.class112_1.int_0;
        int num2 = class17_.int_1 - class17_.int_0;
        int num3 = num2 / int_2;
        int num4 = (num3 + num - 1) / num;
        int[][] array = new int[num4][];
        for (int i = 0; i < @class.int_2; i++)
        {
            int j = 0;
            int num5 = 0;
            while (j < num3)
            {
                if (i == 0)
                {
                    int num6 = @class.class112_1.method_8(gclass108_0.gclass37_0);
                    if (num6 == -1)
                    {
                        return 0;
                    }
                    array[num5] = @class.int_5[num6];
                    if (array[num5] == null)
                    {
                        return 0;
                    }
                }
                int num7 = 0;
                while (num7 < num && j < num3)
                {
                    int int_3 = class17_.int_0 + j * int_2;
                    if ((class17_.int_5[array[num5][num7]] & 1 << i) != 0)
                    {
                        Class112 class2 = @class.class112_0[@class.int_3[array[num5][num7]][i]];
                        if (class2 != null && class2.method_7(float_0, int_3, int_1, gclass108_0.gclass37_0, int_2) == -1)
                        {
                            return 0;
                        }
                    }
                    num7++;
                    j++;
                }
                num5++;
            }
        }
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
            return Class3.smethod_0(gclass108_0, object_0, float_0, num, 0);
        }
        return 0;
    }

    internal static int smethod_2(int int_1)
    {
        int num = 0;
        while (int_1 != 0)
        {
            num++;
            int_1 = (int)((uint)int_1 >> 1);
        }
        return num;
    }

    internal static int smethod_3(int int_1)
    {
        int num = 0;
        while (int_1 != 0)
        {
            num += (int_1 & 1);
            int_1 = (int)((uint)int_1 >> 1);
        }
        return num;
    }

    static int[][][] int_0 = new int[2][][];
}
