using System;

class Class111
{
    static float smethod_0(float[] float_0, float[] float_1, int int_2, int int_3)
    {
        float[] array = new float[int_3 + 1];
        int i = int_3 + 1;
        while (i-- != 0)
        {
            float num = 0f;
            for (int j = i; j < int_2; j++)
            {
                num += float_0[j] * float_0[j - i];
            }
            array[i] = num;
        }
        float num2 = array[0];
        for (int j = 0; j < int_3; j++)
        {
            float num3 = -array[j + 1];
            if (num2 == 0f)
            {
                for (int k = 0; k < int_3; k++)
                {
                    float_1[k] = 0f;
                }
                return 0f;
            }
            for (i = 0; i < j; i++)
            {
                num3 -= float_1[i] * array[j - i];
            }
            num3 /= num2;
            float_1[j] = num3;
            for (i = 0; i < j / 2; i++)
            {
                float num4 = float_1[i];
                float_1[i] += num3 * float_1[j - 1 - i];
                float_1[j - 1 - i] += num3 * num4;
            }
            if (j % 2 != 0)
            {
                float_1[i] += float_1[i] * num3;
            }
            num2 *= (float)(1.0 - (double)(num3 * num3));
        }
        return num2;
    }

    float method_0(float[] float_0, float[] float_1)
    {
        int num = this.int_0;
        float[] array = new float[num + num];
        float num2 = (float)(0.5 / (double)num);
        int i;
        for (i = 0; i < num; i++)
        {
            array[i * 2] = float_0[i] * num2;
            array[i * 2 + 1] = 0f;
        }
        array[num * 2 - 1] = float_0[num - 1] * num2;
        num *= 2;
        this.class97_0.method_0(array);
        i = 0;
        int num3 = num / 2;
        while (i < num / 2)
        {
            float num4 = array[i];
            array[i++] = array[num3];
            array[num3++] = num4;
        }
        return Class111.smethod_0(array, float_1, num, this.int_1);
    }

    internal void method_1(int int_2, int int_3)
    {
        this.int_0 = int_2;
        this.int_1 = int_3;
        this.class97_0.method_1(int_2 * 2);
    }

    void method_2()
    {
        this.class97_0.method_2();
    }

    static float smethod_1(float float_0, float float_1)
    {
        return (float)Math.Sqrt((double)(float_0 * float_0 + float_1 * float_1));
    }

    internal void method_3(float[] float_0, float[] float_1, float float_2)
    {
        for (int i = 0; i < this.int_0 * 2; i++)
        {
            float_0[i] = 0f;
        }
        if (float_2 == 0f)
        {
            return;
        }
        for (int j = 0; j < this.int_1; j++)
        {
            float_0[j * 2 + 1] = float_1[j] / (4f * float_2);
            float_0[j * 2 + 2] = -float_1[j] / (4f * float_2);
        }
        this.class97_0.method_0(float_0);
        int num = this.int_0 * 2;
        float num2 = (float)(1.0 / (double)float_2);
        float_0[0] = (float)(1.0 / (double)(float_0[0] * 2f + num2));
        for (int k = 1; k < this.int_0; k++)
        {
            float num3 = float_0[k] + float_0[num - k];
            float float_3 = float_0[k] - float_0[num - k];
            float float_4 = num3 + num2;
            float_0[k] = (float)(1.0 / (double)Class111.smethod_1(float_4, float_3));
        }
    }

    Class97 class97_0 = new Class97();

    int int_0;

    int int_1;
}
