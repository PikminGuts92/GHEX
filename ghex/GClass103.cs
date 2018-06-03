using System;
using System.Reflection;

[DefaultMember("Item")]
public class GClass103
{
    public GClass103(AudioInfo info, uint uint_0)
    {
        this.method_1((int)uint_0);
        this.audioInfo = info;
    }

    public int method_0()
    {
        return this.float_0.Length;
    }

    public void method_1(int int_0)
    {
        this.float_0 = new float[int_0];
        this.float_1 = new float[int_0];
    }

    public AudioInfo GetAudioInfo()
    {
        return this.audioInfo;
    }

    public float[] method_3(GEnum47 genum47_0)
    {
        if (genum47_0 != GEnum47.const_0)
        {
            return this.float_1;
        }
        return this.float_0;
    }

    public float method_4(GEnum47 genum47_0, int int_0)
    {
        if (genum47_0 != GEnum47.const_0)
        {
            return this.float_1[int_0];
        }
        return this.float_0[int_0];
    }

    public void method_5(GEnum47 genum47_0, int int_0, float float_2)
    {
        float[] array = (genum47_0 == GEnum47.const_0) ? this.float_0 : this.float_1;
        array[int_0] = float_2;
    }

    float[] float_0;

    float[] float_1;

    AudioInfo audioInfo;
}
