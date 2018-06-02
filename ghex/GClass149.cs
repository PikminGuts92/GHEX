using System;
using System.Text;

public class GClass149
{
    public GClass149(GInterface38 ginterface38_1)
    {
        this.ginterface38_0 = ginterface38_1;
    }

    public GInterface38 method_0()
    {
        return this.ginterface38_0;
    }

    public uint method_1()
    {
        uint result;
        this.ginterface38_0.imethod_7(out result);
        return result;
    }

    public void method_2(uint uint_0)
    {
        this.ginterface38_0.imethod_8(uint_0);
    }

    public uint method_3()
    {
        uint result;
        this.ginterface38_0.imethod_9(out result);
        return result;
    }

    public void method_4(uint uint_0)
    {
        this.ginterface38_0.imethod_10(uint_0);
    }

    public string method_5()
    {
        ushort capacity = 0;
        this.ginterface38_0.imethod_5(null, ref capacity);
        StringBuilder stringBuilder = new StringBuilder((int)capacity);
        this.ginterface38_0.imethod_5(stringBuilder, ref capacity);
        return stringBuilder.ToString();
    }

    public void method_6(string string_0)
    {
        this.ginterface38_0.imethod_6(string_0);
    }

    public string method_7()
    {
        ushort capacity = 0;
        this.ginterface38_0.imethod_3(null, ref capacity);
        StringBuilder stringBuilder = new StringBuilder((int)capacity);
        this.ginterface38_0.imethod_3(stringBuilder, ref capacity);
        return stringBuilder.ToString();
    }

    public void method_8(string string_0)
    {
        this.ginterface38_0.imethod_4(string_0);
    }

    public ushort method_9()
    {
        ushort result;
        this.ginterface38_0.imethod_1(out result);
        return result;
    }

    public void method_10(ushort ushort_0)
    {
        this.ginterface38_0.imethod_2(ushort_0);
    }

    public Guid method_11()
    {
        Guid result;
        this.ginterface38_0.imethod_0(out result);
        return result;
    }

    GInterface38 ginterface38_0;
}
