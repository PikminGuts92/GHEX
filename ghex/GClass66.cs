using System;
using System.Text;

public class GClass66
{
    public GClass66(GInterface41 ginterface41_1)
    {
        this.ginterface41_0 = ginterface41_1;
    }

    public GInterface38 method_0(int int_0)
    {
        GInterface38 result;
        this.ginterface41_0.imethod_6((uint)int_0, out result);
        return result;
    }

    public GInterface38 method_1(int int_0)
    {
        GInterface38 result;
        this.ginterface41_0.imethod_7((ushort)int_0, out result);
        return result;
    }

    public void method_2(GInterface38 ginterface38_0)
    {
        this.ginterface41_0.imethod_8(ginterface38_0);
    }

    public void method_3(int int_0)
    {
        this.ginterface41_0.imethod_9((ushort)int_0);
    }

    public void method_4(GInterface38 ginterface38_0)
    {
        this.ginterface41_0.imethod_11(ginterface38_0);
    }

    public GInterface41 method_5()
    {
        return this.ginterface41_0;
    }

    public string method_6()
    {
        uint capacity = 0u;
        this.ginterface41_0.imethod_1(null, ref capacity);
        StringBuilder stringBuilder = new StringBuilder((int)capacity);
        this.ginterface41_0.imethod_1(stringBuilder, ref capacity);
        return stringBuilder.ToString();
    }

    public void method_7(string string_0)
    {
        this.ginterface41_0.imethod_2(string_0);
    }

    public string method_8()
    {
        uint capacity = 0u;
        this.ginterface41_0.imethod_3(null, ref capacity);
        StringBuilder stringBuilder = new StringBuilder((int)capacity);
        this.ginterface41_0.imethod_1(stringBuilder, ref capacity);
        return stringBuilder.ToString();
    }

    public void method_9(string string_0)
    {
        this.ginterface41_0.imethod_4(string_0);
    }

    public string method_10()
    {
        uint capacity = 0u;
        GClass54.smethod_11().imethod_3(this.ginterface41_0, null, ref capacity);
        StringBuilder stringBuilder = new StringBuilder((int)capacity);
        GClass54.smethod_11().imethod_3(this.ginterface41_0, stringBuilder, ref capacity);
        return stringBuilder.ToString();
    }

    public uint method_11()
    {
        uint result;
        this.ginterface41_0.imethod_5(out result);
        return result;
    }

    GInterface41 ginterface41_0;
}
