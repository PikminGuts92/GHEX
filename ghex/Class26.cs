﻿using System;

class Class26 : Class25
{
    public override void vmethod_0(object object_0, GClass37 gclass37_0)
    {
        Class35 @class = (Class35)object_0;
        int num = 0;
        int int_ = @class.int_10[1];
        int num2 = -1;
        gclass37_0.method_6(@class.int_3, 5);
        for (int i = 0; i < @class.int_3; i++)
        {
            gclass37_0.method_6(@class.int_4[i], 4);
            if (num2 < @class.int_4[i])
            {
                num2 = @class.int_4[i];
            }
        }
        for (int j = 0; j < num2 + 1; j++)
        {
            gclass37_0.method_6(@class.int_5[j] - 1, 3);
            gclass37_0.method_6(@class.int_6[j], 2);
            if (@class.int_6[j] != 0)
            {
                gclass37_0.method_6(@class.int_7[j], 8);
            }
            for (int k = 0; k < 1 << @class.int_6[j]; k++)
            {
                gclass37_0.method_6(@class.int_8[j][k] + 1, 8);
            }
        }
        gclass37_0.method_6(@class.int_9 - 1, 2);
        gclass37_0.method_6(Class26.smethod_3(int_), 4);
        int int_2 = Class26.smethod_3(int_);
        int l = 0;
        int m = 0;
        while (l < @class.int_3)
        {
            num += @class.int_5[@class.int_4[l]];
            while (m < num)
            {
                gclass37_0.method_6(@class.int_10[m + 2], int_2);
                m++;
            }
            l++;
        }
    }

    public override object vmethod_1(GClass100 gclass100_0, GClass37 gclass37_0)
    {
        int num = 0;
        int num2 = -1;
        Class35 @class = new Class35();
        @class.int_3 = gclass37_0.method_12(5);
        for (int i = 0; i < @class.int_3; i++)
        {
            @class.int_4[i] = gclass37_0.method_12(4);
            if (num2 < @class.int_4[i])
            {
                num2 = @class.int_4[i];
            }
        }
        for (int j = 0; j < num2 + 1; j++)
        {
            @class.int_5[j] = gclass37_0.method_12(3) + 1;
            @class.int_6[j] = gclass37_0.method_12(2);
            if (@class.int_6[j] < 0)
            {
                @class.method_0();
                return null;
            }
            if (@class.int_6[j] != 0)
            {
                @class.int_7[j] = gclass37_0.method_12(8);
            }
            if (@class.int_7[j] < 0 || @class.int_7[j] >= gclass100_0.int_19)
            {
                @class.method_0();
                return null;
            }
            for (int k = 0; k < 1 << @class.int_6[j]; k++)
            {
                @class.int_8[j][k] = gclass37_0.method_12(8) - 1;
                if (@class.int_8[j][k] < -1 || @class.int_8[j][k] >= gclass100_0.int_19)
                {
                    @class.method_0();
                    return null;
                }
            }
        }
        @class.int_9 = gclass37_0.method_12(2) + 1;
        int num3 = gclass37_0.method_12(4);
        int l = 0;
        int m = 0;
        while (l < @class.int_3)
        {
            num += @class.int_5[@class.int_4[l]];
            while (m < num)
            {
                int num4 = @class.int_10[m + 2] = gclass37_0.method_12(num3);
                if (num4 < 0 || num4 >= 1 << num3)
                {
                    @class.method_0();
                    return null;
                }
                m++;
            }
            l++;
        }
        @class.int_10[0] = 0;
        @class.int_10[1] = 1 << num3;
        return @class;
    }

    public override object vmethod_2(GClass101 gclass101_0, Class6 class6_0, object object_0)
    {
        int num = 0;
        int[] array = new int[Class26.int_1 + 2];
        Class35 @class = (Class35)object_0;
        Class36 class2 = new Class36();
        class2.class35_0 = @class;
        class2.int_7 = @class.int_10[1];
        for (int i = 0; i < @class.int_3; i++)
        {
            num += @class.int_5[@class.int_4[i]];
        }
        num += 2;
        class2.int_6 = num;
        for (int j = 0; j < num; j++)
        {
            array[j] = j;
        }
        for (int k = 0; k < num - 1; k++)
        {
            for (int l = k; l < num; l++)
            {
                if (@class.int_10[array[k]] > @class.int_10[array[l]])
                {
                    int num2 = array[l];
                    array[l] = array[k];
                    array[k] = num2;
                }
            }
        }
        for (int m = 0; m < num; m++)
        {
            class2.int_2[m] = array[m];
        }
        for (int n = 0; n < num; n++)
        {
            class2.int_3[class2.int_2[n]] = n;
        }
        for (int num3 = 0; num3 < num; num3++)
        {
            class2.int_1[num3] = @class.int_10[class2.int_2[num3]];
        }
        switch (@class.int_9)
        {
        case 1:
            class2.int_8 = 256;
            break;
        case 2:
            class2.int_8 = 128;
            break;
        case 3:
            class2.int_8 = 86;
            break;
        case 4:
            class2.int_8 = 64;
            break;
        default:
            class2.int_8 = -1;
            break;
        }
        for (int num4 = 0; num4 < num - 2; num4++)
        {
            int num5 = 0;
            int num6 = 1;
            int num7 = 0;
            int num8 = class2.int_7;
            int num9 = @class.int_10[num4 + 2];
            for (int num10 = 0; num10 < num4 + 2; num10++)
            {
                int num11 = @class.int_10[num10];
                if (num11 > num7 && num11 < num9)
                {
                    num5 = num10;
                    num7 = num11;
                }
                if (num11 < num8 && num11 > num9)
                {
                    num6 = num10;
                    num8 = num11;
                }
            }
            class2.int_5[num4] = num5;
            class2.int_4[num4] = num6;
        }
        return class2;
    }

    public override void vmethod_3(object object_0)
    {
    }

    public override void vmethod_4(object object_0)
    {
    }

    public override void vmethod_5(object object_0)
    {
    }

    public override int vmethod_6(GClass108 gclass108_0, object object_0, float[] float_1, float[] float_2, object object_1)
    {
        return 0;
    }

    public override object vmethod_7(GClass108 gclass108_0, object object_0, object object_1)
    {
        Class36 @class = (Class36)object_0;
        Class35 class35_ = @class.class35_0;
        Class112[] class112_ = gclass108_0.gclass101_0.class112_0;
        if (gclass108_0.gclass37_0.method_12(1) == 1)
        {
            int[] array = null;
            if (object_1 is int[])
            {
                array = (int[])object_1;
            }
            if (array != null && array.Length >= @class.int_6)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = 0;
                }
            }
            else
            {
                array = new int[@class.int_6];
            }
            array[0] = gclass108_0.gclass37_0.method_12(Class26.smethod_2(@class.int_8 - 1));
            array[1] = gclass108_0.gclass37_0.method_12(Class26.smethod_2(@class.int_8 - 1));
            int j = 0;
            int num = 2;
            while (j < class35_.int_3)
            {
                int num2 = class35_.int_4[j];
                int num3 = class35_.int_5[num2];
                int num4 = class35_.int_6[num2];
                int num5 = 1 << num4;
                int num6 = 0;
                if (num4 != 0)
                {
                    num6 = class112_[class35_.int_7[num2]].method_8(gclass108_0.gclass37_0);
                    if (num6 == -1)
                    {
                        return null;
                    }
                }
                for (int k = 0; k < num3; k++)
                {
                    int num7 = class35_.int_8[num2][num6 & num5 - 1];
                    num6 = (int)((uint)num6 >> num4);
                    if (num7 >= 0)
                    {
                        if ((array[num + k] = class112_[num7].method_8(gclass108_0.gclass37_0)) == -1)
                        {
                            return null;
                        }
                    }
                    else
                    {
                        array[num + k] = 0;
                    }
                }
                num += num3;
                j++;
            }
            for (int l = 2; l < @class.int_6; l++)
            {
                int num8 = Class26.smethod_0(class35_.int_10[@class.int_5[l - 2]], class35_.int_10[@class.int_4[l - 2]], array[@class.int_5[l - 2]], array[@class.int_4[l - 2]], class35_.int_10[l]);
                int num9 = @class.int_8 - num8;
                int num10 = num8;
                int num11 = ((num9 < num10) ? num9 : num10) << 1;
                int num12 = array[l];
                if (num12 != 0)
                {
                    if (num12 >= num11)
                    {
                        if (num9 > num10)
                        {
                            num12 -= num10;
                        }
                        else
                        {
                            num12 = -1 - (num12 - num9);
                        }
                    }
                    else if ((num12 & 1) != 0)
                    {
                        num12 = (int)(-(int)((ulong)((uint)(num12 + 1) >> 1)));
                    }
                    else
                    {
                        num12 >>= 1;
                    }
                    array[l] = num12 + num8;
                    array[@class.int_5[l - 2]] &= 32767;
                    array[@class.int_4[l - 2]] &= 32767;
                }
                else
                {
                    array[l] = (num8 | 32768);
                }
            }
            return array;
        }
        return null;
    }

    static int smethod_0(int int_2, int int_3, int int_4, int int_5, int int_6)
    {
        int_4 &= 32767;
        int_5 &= 32767;
        int num = int_5 - int_4;
        int num2 = int_3 - int_2;
        int num3 = Math.Abs(num);
        int num4 = num3 * (int_6 - int_2);
        int num5 = num4 / num2;
        if (num < 0)
        {
            return int_4 - num5;
        }
        return int_4 + num5;
    }

    public override int vmethod_8(GClass108 gclass108_0, object object_0, object object_1, float[] float_1)
    {
        Class36 @class = (Class36)object_0;
        Class35 class35_ = @class.class35_0;
        int num = gclass108_0.gclass101_0.gclass100_0.int_13[gclass108_0.int_4] / 2;
        if (object_1 != null)
        {
            int[] array = (int[])object_1;
            int num2 = 0;
            int int_ = 0;
            int int_2 = array[0] * class35_.int_9;
            for (int i = 1; i < @class.int_6; i++)
            {
                int num3 = @class.int_2[i];
                int num4 = array[num3] & 32767;
                if (num4 == array[num3])
                {
                    num4 *= class35_.int_9;
                    num2 = class35_.int_10[num3];
                    Class26.smethod_1(int_, num2, int_2, num4, float_1);
                    int_ = num2;
                    int_2 = num4;
                }
            }
            for (int j = num2; j < num; j++)
            {
                float_1[j] *= float_1[j - 1];
            }
            return 1;
        }
        for (int k = 0; k < num; k++)
        {
            float_1[k] = 0f;
        }
        return 0;
    }

    static void smethod_1(int int_2, int int_3, int int_4, int int_5, float[] float_1)
    {
        int num = int_5 - int_4;
        int num2 = int_3 - int_2;
        int num3 = Math.Abs(num);
        int num4 = num / num2;
        int num5 = (num < 0) ? (num4 - 1) : (num4 + 1);
        int num6 = int_2;
        int num7 = int_4;
        int num8 = 0;
        num3 -= Math.Abs(num4 * num2);
        float_1[num6] *= Class26.float_0[num7];
        while (++num6 < int_3)
        {
            num8 += num3;
            if (num8 >= num2)
            {
                num8 -= num2;
                num7 += num5;
            }
            else
            {
                num7 += num4;
            }
            float_1[num6] *= Class26.float_0[num7];
        }
    }

    static int smethod_2(int int_2)
    {
        int num = 0;
        while (int_2 != 0)
        {
            num++;
            int_2 = (int)((uint)int_2 >> 1);
        }
        return num;
    }

    static int smethod_3(int int_2)
    {
        int num = 0;
        while (int_2 > 1)
        {
            num++;
            int_2 = (int)((uint)int_2 >> 1);
        }
        return num;
    }

    static int int_0 = 140;

    static int int_1 = 63;

    static float[] float_0 = new float[]
    {
        1.06498632E-07f,
        1.1341951E-07f,
        1.20790148E-07f,
        1.28639783E-07f,
        1.369995E-07f,
        1.459025E-07f,
        1.55384086E-07f,
        1.65481808E-07f,
        1.76235744E-07f,
        1.87688556E-07f,
        1.998856E-07f,
        2.128753E-07f,
        2.26709133E-07f,
        2.41441967E-07f,
        2.57132228E-07f,
        2.73842119E-07f,
        2.91637917E-07f,
        3.10590224E-07f,
        3.307741E-07f,
        3.52269666E-07f,
        3.75162131E-07f,
        3.995423E-07f,
        4.255068E-07f,
        4.53158634E-07f,
        4.82607447E-07f,
        5.1397E-07f,
        5.47370632E-07f,
        5.829419E-07f,
        6.208247E-07f,
        6.611694E-07f,
        7.041359E-07f,
        7.49894639E-07f,
        7.98627E-07f,
        8.505263E-07f,
        9.057983E-07f,
        9.646621E-07f,
        1.02735135E-06f,
        1.0941144E-06f,
        1.16521608E-06f,
        1.24093845E-06f,
        1.32158164E-06f,
        1.40746545E-06f,
        1.49893049E-06f,
        1.59633942E-06f,
        1.70007854E-06f,
        1.81055918E-06f,
        1.92821949E-06f,
        2.053526E-06f,
        2.18697573E-06f,
        2.3290977E-06f,
        2.48045581E-06f,
        2.64164964E-06f,
        2.813319E-06f,
        2.9961443E-06f,
        3.19085052E-06f,
        3.39821E-06f,
        3.619045E-06f,
        3.85423073E-06f,
        4.10470057E-06f,
        4.371447E-06f,
        4.6555283E-06f,
        4.958071E-06f,
        5.280274E-06f,
        5.623416E-06f,
        5.988857E-06f,
        6.37804669E-06f,
        6.79252844E-06f,
        7.23394533E-06f,
        7.704048E-06f,
        8.2047E-06f,
        8.737888E-06f,
        9.305725E-06f,
        9.910464E-06f,
        1.05545014E-05f,
        1.12403923E-05f,
        1.19708557E-05f,
        1.27487892E-05f,
        1.3577278E-05f,
        1.44596061E-05f,
        1.53992714E-05f,
        1.64000048E-05f,
        1.74657689E-05f,
        1.86007928E-05f,
        1.98095768E-05f,
        2.10969138E-05f,
        2.24679115E-05f,
        2.39280016E-05f,
        2.54829774E-05f,
        2.71390054E-05f,
        2.890265E-05f,
        3.078091E-05f,
        3.27812268E-05f,
        3.49115326E-05f,
        3.718028E-05f,
        3.95964671E-05f,
        4.21696677E-05f,
        4.491009E-05f,
        4.7828602E-05f,
        5.09367746E-05f,
        5.424693E-05f,
        5.77722021E-05f,
        6.152657E-05f,
        6.552491E-05f,
        6.97830837E-05f,
        7.43179844E-05f,
        7.914758E-05f,
        8.429104E-05f,
        8.976875E-05f,
        9.560242E-05f,
        0.000101815211f,
        0.000108431741f,
        0.000115478237f,
        0.000122982674f,
        0.000130974775f,
        0.000139486248f,
        0.000148550855f,
        0.000158204537f,
        0.000168485552f,
        0.00017943469f,
        0.000191095358f,
        0.000203513817f,
        0.0002167393f,
        0.000230824226f,
        0.000245824485f,
        0.000261799549f,
        0.000278812746f,
        0.000296931568f,
        0.000316227874f,
        0.000336778146f,
        0.000358663878f,
        0.000381971884f,
        0.00040679457f,
        0.000433230365f,
        0.0004613841f,
        0.0004913675f,
        0.00052329927f,
        0.0005573062f,
        0.0005935231f,
        0.0006320936f,
        0.0006731706f,
        0.000716917f,
        0.0007635063f,
        0.000813123246f,
        0.000865964568f,
        0.000922239851f,
        0.0009821722f,
        0.00104599923f,
        0.00111397426f,
        0.00118636654f,
        0.00126346329f,
        0.0013455702f,
        0.00143301289f,
        0.00152613816f,
        0.00162531529f,
        0.00173093739f,
        0.00184342347f,
        0.00196321961f,
        0.00209080055f,
        0.0022266726f,
        0.00237137428f,
        0.00252547953f,
        0.00268959929f,
        0.00286438479f,
        0.0030505287f,
        0.003248769f,
        0.00345989247f,
        0.00368473586f,
        0.00392419053f,
        0.00417920668f,
        0.004450795f,
        0.004740033f,
        0.005048067f,
        0.0053761187f,
        0.005725489f,
        0.00609756354f,
        0.00649381755f,
        0.00691582263f,
        0.00736525143f,
        0.007843887f,
        0.008353627f,
        0.008896492f,
        0.009474637f,
        0.010090352f,
        0.01074608f,
        0.0114444206f,
        0.012188144f,
        0.0129801976f,
        0.0138237253f,
        0.0147220679f,
        0.0156787913f,
        0.0166976862f,
        0.0177827962f,
        0.0189384222f,
        0.0201691482f,
        0.0214798544f,
        0.0228757355f,
        0.02436233f,
        0.0259455312f,
        0.0276316181f,
        0.0294272769f,
        0.0313396268f,
        0.03337625f,
        0.0355452262f,
        0.0378551558f,
        0.0403152f,
        0.0429351069f,
        0.0457252748f,
        0.0486967564f,
        0.05186135f,
        0.05523159f,
        0.05882085f,
        0.0626433641f,
        0.06671428f,
        0.07104975f,
        0.0756669641f,
        0.08058423f,
        0.08582105f,
        0.09139818f,
        0.0973377451f,
        0.1036633f,
        0.110399932f,
        0.117574342f,
        0.125214979f,
        0.133352146f,
        0.142018124f,
        0.151247263f,
        0.161076173f,
        0.1715438f,
        0.182691678f,
        0.194564015f,
        0.207207873f,
        0.220673427f,
        0.235014021f,
        0.250286549f,
        0.266551584f,
        0.283873618f,
        0.3023213f,
        0.32196787f,
        0.342891127f,
        0.365174145f,
        0.3889052f,
        0.414178461f,
        0.44109413f,
        0.4697589f,
        0.50028646f,
        0.532797933f,
        0.5674221f,
        0.6042964f,
        0.643566966f,
        0.6853896f,
        0.729930043f,
        0.777365f,
        0.8278826f,
        0.881683052f,
        0.9389798f,
        1f
    };
}
