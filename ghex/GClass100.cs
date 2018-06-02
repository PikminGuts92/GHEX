using System;
using System.Text;

public class GClass100
{
    public void method_0()
    {
        this.int_9 = 0;
    }

    public void method_1()
    {
        for (int i = 0; i < this.int_14; i++)
        {
            this.class6_0[i] = null;
        }
        this.class6_0 = null;
        for (int j = 0; j < this.int_15; j++)
        {
            Class40.class40_0[this.int_21[j]].vmethod_3(this.object_0[j]);
        }
        this.object_0 = null;
        for (int k = 0; k < this.int_16; k++)
        {
            Class33.class33_0[this.int_22[k]].vmethod_3(this.object_1[k]);
        }
        this.object_1 = null;
        for (int l = 0; l < this.int_17; l++)
        {
            Class25.class25_0[this.int_23[l]].vmethod_3(this.object_2[l]);
        }
        this.object_2 = null;
        for (int m = 0; m < this.int_18; m++)
        {
            Class2.class2_0[this.int_24[m]].vmethod_3(this.object_3[m]);
        }
        this.object_3 = null;
        for (int n = 0; n < this.int_19; n++)
        {
            if (this.class90_0[n] != null)
            {
                this.class90_0[n].method_3();
                this.class90_0[n] = null;
            }
        }
        this.class90_0 = null;
        for (int num = 0; num < this.int_20; num++)
        {
            this.class9_0[num].method_0();
        }
    }

    int method_2(GClass37 gclass37_0)
    {
        this.int_7 = gclass37_0.method_12(32);
        if (this.int_7 != 0)
        {
            return -1;
        }
        this.int_8 = gclass37_0.method_12(8);
        this.int_9 = gclass37_0.method_12(32);
        this.int_10 = gclass37_0.method_12(32);
        this.int_11 = gclass37_0.method_12(32);
        this.int_12 = gclass37_0.method_12(32);
        this.int_13[0] = 1 << gclass37_0.method_12(4);
        this.int_13[1] = 1 << gclass37_0.method_12(4);
        if (this.int_9 >= 1 && this.int_8 >= 1 && this.int_13[0] >= 8 && this.int_13[1] >= this.int_13[0])
        {
            if (gclass37_0.method_12(1) == 1)
            {
                return 0;
            }
        }
        this.method_1();
        return -1;
    }

    int method_3(GClass37 gclass37_0)
    {
        this.int_19 = gclass37_0.method_12(8) + 1;
        if (this.class90_0 == null || this.class90_0.Length != this.int_19)
        {
            this.class90_0 = new Class90[this.int_19];
        }
        for (int i = 0; i < this.int_19; i++)
        {
            this.class90_0[i] = new Class90();
            if (this.class90_0[i].method_1(gclass37_0) != 0)
            {
                this.method_1();
                return -1;
            }
        }
        this.int_16 = gclass37_0.method_12(6) + 1;
        if (this.int_22 == null || this.int_22.Length != this.int_16)
        {
            this.int_22 = new int[this.int_16];
        }
        if (this.object_1 == null || this.object_1.Length != this.int_16)
        {
            this.object_1 = new object[this.int_16];
        }
        for (int j = 0; j < this.int_16; j++)
        {
            this.int_22[j] = gclass37_0.method_12(16);
            if (this.int_22[j] < 0 || this.int_22[j] >= GClass100.int_2)
            {
                this.method_1();
                return -1;
            }
            this.object_1[j] = Class33.class33_0[this.int_22[j]].vmethod_1(this, gclass37_0);
            if (this.object_1[j] == null)
            {
                this.method_1();
                return -1;
            }
        }
        this.int_17 = gclass37_0.method_12(6) + 1;
        if (this.int_23 == null || this.int_23.Length != this.int_17)
        {
            this.int_23 = new int[this.int_17];
        }
        if (this.object_2 == null || this.object_2.Length != this.int_17)
        {
            this.object_2 = new object[this.int_17];
        }
        for (int k = 0; k < this.int_17; k++)
        {
            this.int_23[k] = gclass37_0.method_12(16);
            if (this.int_23[k] < 0 || this.int_23[k] >= GClass100.int_3)
            {
                this.method_1();
                return -1;
            }
            this.object_2[k] = Class25.class25_0[this.int_23[k]].vmethod_1(this, gclass37_0);
            if (this.object_2[k] == null)
            {
                this.method_1();
                return -1;
            }
        }
        this.int_18 = gclass37_0.method_12(6) + 1;
        if (this.int_24 == null || this.int_24.Length != this.int_18)
        {
            this.int_24 = new int[this.int_18];
        }
        if (this.object_3 == null || this.object_3.Length != this.int_18)
        {
            this.object_3 = new object[this.int_18];
        }
        for (int l = 0; l < this.int_18; l++)
        {
            this.int_24[l] = gclass37_0.method_12(16);
            if (this.int_24[l] < 0 || this.int_24[l] >= GClass100.int_4)
            {
                this.method_1();
                return -1;
            }
            this.object_3[l] = Class2.class2_0[this.int_24[l]].vmethod_1(this, gclass37_0);
            if (this.object_3[l] == null)
            {
                this.method_1();
                return -1;
            }
        }
        this.int_15 = gclass37_0.method_12(6) + 1;
        if (this.int_21 == null || this.int_21.Length != this.int_15)
        {
            this.int_21 = new int[this.int_15];
        }
        if (this.object_0 == null || this.object_0.Length != this.int_15)
        {
            this.object_0 = new object[this.int_15];
        }
        for (int m = 0; m < this.int_15; m++)
        {
            this.int_21[m] = gclass37_0.method_12(16);
            if (this.int_21[m] < 0 || this.int_21[m] >= GClass100.int_5)
            {
                this.method_1();
                return -1;
            }
            this.object_0[m] = Class40.class40_0[this.int_21[m]].vmethod_1(this, gclass37_0);
            if (this.object_0[m] == null)
            {
                this.method_1();
                return -1;
            }
        }
        this.int_14 = gclass37_0.method_12(6) + 1;
        if (this.class6_0 == null || this.class6_0.Length != this.int_14)
        {
            this.class6_0 = new Class6[this.int_14];
        }
        for (int n = 0; n < this.int_14; n++)
        {
            this.class6_0[n] = new Class6();
            this.class6_0[n].int_0 = gclass37_0.method_12(1);
            this.class6_0[n].int_1 = gclass37_0.method_12(16);
            this.class6_0[n].int_2 = gclass37_0.method_12(16);
            this.class6_0[n].int_3 = gclass37_0.method_12(8);
            if (this.class6_0[n].int_1 >= GClass100.int_6 || this.class6_0[n].int_2 >= GClass100.int_6 || this.class6_0[n].int_3 >= this.int_15)
            {
                this.method_1();
                return -1;
            }
        }
        if (gclass37_0.method_12(1) != 1)
        {
            this.method_1();
            return -1;
        }
        return 0;
    }

    public int method_4(GClass119 gclass119_0, GClass91 gclass91_0)
    {
        GClass37 gclass = new GClass37();
        if (gclass91_0 != null)
        {
            gclass.method_5(gclass91_0.byte_0, gclass91_0.int_0, gclass91_0.int_1);
            byte[] array = new byte[6];
            int num = gclass.method_12(8);
            gclass.method_2(array, 6);
            if (array[0] == 118 && array[1] == 111 && array[2] == 114 && array[3] == 98 && array[4] == 105)
            {
                if (array[5] == 115)
                {
                    switch (num)
                    {
                    case 1:
                        if (gclass91_0.int_2 == 0)
                        {
                            return -1;
                        }
                        if (this.int_9 != 0)
                        {
                            return -1;
                        }
                        return this.method_2(gclass);
                    case 2:
                    case 4:
                        return -1;
                    case 3:
                        if (this.int_9 == 0)
                        {
                            return -1;
                        }
                        return gclass119_0.method_7(gclass);
                    case 5:
                        if (this.int_9 != 0 && gclass119_0.byte_1 != null)
                        {
                            return this.method_3(gclass);
                        }
                        return -1;
                    default:
                        return -1;
                    }
                }
            }
            return -1;
        }
        return -1;
    }

    int method_5(GClass37 gclass37_0)
    {
        ASCIIEncoding asciiencoding = new ASCIIEncoding();
        byte[] bytes = asciiencoding.GetBytes(GClass100.string_0);
        gclass37_0.method_6(1, 8);
        gclass37_0.method_1(bytes);
        gclass37_0.method_6(0, 32);
        gclass37_0.method_6(this.int_8, 8);
        gclass37_0.method_6(this.int_9, 32);
        gclass37_0.method_6(this.int_10, 32);
        gclass37_0.method_6(this.int_11, 32);
        gclass37_0.method_6(this.int_12, 32);
        gclass37_0.method_6(GClass100.smethod_0(this.int_13[0]), 4);
        gclass37_0.method_6(GClass100.smethod_0(this.int_13[1]), 4);
        gclass37_0.method_6(1, 1);
        return 0;
    }

    int method_6(GClass37 gclass37_0)
    {
        ASCIIEncoding asciiencoding = new ASCIIEncoding();
        byte[] bytes = asciiencoding.GetBytes(GClass100.string_0);
        gclass37_0.method_6(5, 8);
        gclass37_0.method_1(bytes);
        gclass37_0.method_6(this.int_19 - 1, 8);
        for (int i = 0; i < this.int_19; i++)
        {
            if (this.class90_0[i].method_0(gclass37_0) != 0)
            {
                return -1;
            }
        }
        gclass37_0.method_6(this.int_16 - 1, 6);
        for (int j = 0; j < this.int_16; j++)
        {
            gclass37_0.method_6(this.int_22[j], 16);
            Class33.class33_0[this.int_22[j]].vmethod_0(this.object_1[j], gclass37_0);
        }
        gclass37_0.method_6(this.int_17 - 1, 6);
        for (int k = 0; k < this.int_17; k++)
        {
            gclass37_0.method_6(this.int_23[k], 16);
            Class25.class25_0[this.int_23[k]].vmethod_0(this.object_2[k], gclass37_0);
        }
        gclass37_0.method_6(this.int_18 - 1, 6);
        for (int l = 0; l < this.int_18; l++)
        {
            gclass37_0.method_6(this.int_24[l], 16);
            Class2.class2_0[this.int_24[l]].vmethod_0(this.object_3[l], gclass37_0);
        }
        gclass37_0.method_6(this.int_15 - 1, 6);
        for (int m = 0; m < this.int_15; m++)
        {
            gclass37_0.method_6(this.int_21[m], 16);
            Class40.class40_0[this.int_21[m]].vmethod_0(this, this.object_0[m], gclass37_0);
        }
        gclass37_0.method_6(this.int_14 - 1, 6);
        for (int n = 0; n < this.int_14; n++)
        {
            gclass37_0.method_6(this.class6_0[n].int_0, 1);
            gclass37_0.method_6(this.class6_0[n].int_1, 16);
            gclass37_0.method_6(this.class6_0[n].int_2, 16);
            gclass37_0.method_6(this.class6_0[n].int_3, 8);
        }
        gclass37_0.method_6(1, 1);
        return 0;
    }

    public int method_7(GClass91 gclass91_0)
    {
        GClass37 gclass = new GClass37();
        gclass.method_5(gclass91_0.byte_0, gclass91_0.int_0, gclass91_0.int_1);
        if (gclass.method_12(1) != 0)
        {
            return GClass100.int_1;
        }
        int num = 0;
        for (int i = this.int_14; i > 1; i = (int)((uint)i >> 1))
        {
            num++;
        }
        int num2 = gclass.method_12(num);
        if (num2 == -1)
        {
            return GClass100.int_0;
        }
        return this.int_13[this.class6_0[num2].int_0];
    }

    static int smethod_0(int int_25)
    {
        int num = 0;
        while (int_25 > 1)
        {
            num++;
            int_25 = (int)((uint)int_25 >> 1);
        }
        return num;
    }

    public string method_8()
    {
        return string.Concat(new string[]
        {
            "version:",
            this.int_7.ToString(),
            ", channels:",
            this.int_8.ToString(),
            ", rate:",
            this.int_9.ToString(),
            ", bitrate:",
            this.int_10.ToString(),
            ",",
            this.int_11.ToString(),
            ",",
            this.int_12.ToString()
        });
    }

    static int int_0 = -136;

    static int int_1 = -135;

    static string string_0 = "vorbis";

    static int int_2 = 1;

    static int int_3 = 2;

    static int int_4 = 3;

    static int int_5 = 1;

    static int int_6 = 1;

    public int int_7;

    public int int_8;

    public int int_9;

    internal int int_10;

    internal int int_11;

    internal int int_12;

    internal int[] int_13 = new int[2];

    internal int int_14;

    internal int int_15;

    internal int int_16;

    internal int int_17;

    internal int int_18;

    internal int int_19;

    internal int int_20;

    internal Class6[] class6_0;

    internal int[] int_21;

    internal object[] object_0;

    internal int[] int_22;

    internal object[] object_1;

    internal int[] int_23;

    internal object[] object_2;

    internal int[] int_24;

    internal object[] object_3;

    internal Class90[] class90_0;

    internal Class9[] class9_0 = new Class9[64];
}
