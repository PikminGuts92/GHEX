using System;

class Class35
{
    internal Class35()
    {
        for (int i = 0; i < this.int_8.Length; i++)
        {
            this.int_8[i] = new int[8];
        }
    }

    internal void method_0()
    {
        this.int_4 = null;
        this.int_5 = null;
        this.int_6 = null;
        this.int_7 = null;
        this.int_8 = null;
        this.int_10 = null;
    }

    internal object method_1()
    {
        Class35 @class = new Class35();
        @class.int_3 = this.int_3;
        Array.Copy(this.int_4, 0, @class.int_4, 0, 31);
        Array.Copy(this.int_5, 0, @class.int_5, 0, 16);
        Array.Copy(this.int_6, 0, @class.int_6, 0, 16);
        Array.Copy(this.int_7, 0, @class.int_7, 0, 16);
        for (int i = 0; i < 16; i++)
        {
            Array.Copy(this.int_8[i], 0, @class.int_8[i], 0, 8);
        }
        @class.int_9 = this.int_9;
        Array.Copy(this.int_10, 0, @class.int_10, 0, 65);
        @class.float_0 = this.float_0;
        @class.float_1 = this.float_1;
        @class.float_2 = this.float_2;
        @class.int_11 = this.int_11;
        @class.int_12 = this.int_12;
        @class.int_13 = this.int_13;
        @class.float_3 = this.float_3;
        @class.int_14 = this.int_14;
        @class.int_15 = this.int_15;
        @class.int_16 = this.int_16;
        return @class;
    }

    const int int_0 = 63;

    const int int_1 = 16;

    const int int_2 = 31;

    internal int int_3;

    internal int[] int_4 = new int[31];

    internal int[] int_5 = new int[16];

    internal int[] int_6 = new int[16];

    internal int[] int_7 = new int[16];

    internal int[][] int_8 = new int[16][];

    internal int int_9;

    internal int[] int_10 = new int[65];

    internal float float_0;

    internal float float_1;

    internal float float_2;

    internal int int_11;

    internal int int_12;

    internal int int_13;

    internal float float_3;

    internal int int_14;

    internal int int_15;

    internal int int_16;
}
