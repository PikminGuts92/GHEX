using System;
using System.ComponentModel;

[TypeConverter(typeof(Class114))]
[Serializable]
public struct GStruct13
{
    public GStruct13(int int_4, int int_5, int int_6, int int_7)
    {
        this.int_0 = int_4;
        this.int_1 = int_6;
        this.int_2 = int_5;
        this.int_3 = int_7;
    }

    public override bool Equals(object object_0)
    {
        if (!(object_0 is GStruct13))
        {
            return false;
        }
        GStruct13 gstruct = (GStruct13)object_0;
        return gstruct.method_0() == this.method_0() && gstruct.method_4() == this.method_4() && gstruct.method_2() == this.method_2() && gstruct.method_6() == this.method_6();
    }

    public override int GetHashCode()
    {
        return this.method_0() ^ (this.method_4() << 13 | this.method_4() >> 19) ^ (this.method_2() << 26 | this.method_2() >> 6) ^ (this.method_6() << 7 | this.method_6() >> 25);
    }

    public int method_0()
    {
        return this.int_0;
    }

    public void method_1(int int_4)
    {
        if (int_4 < 0)
        {
            throw new ArgumentException("Padding value cannot be negative");
        }
        this.int_0 = int_4;
    }

    public int method_2()
    {
        return this.int_1;
    }

    public void method_3(int int_4)
    {
        if (int_4 < 0)
        {
            throw new ArgumentException("Padding value cannot be negative");
        }
        this.int_1 = int_4;
    }

    public int method_4()
    {
        return this.int_2;
    }

    public void method_5(int int_4)
    {
        if (int_4 < 0)
        {
            throw new ArgumentException("Padding value cannot be negative");
        }
        this.int_2 = int_4;
    }

    public int method_6()
    {
        return this.int_3;
    }

    public void method_7(int int_4)
    {
        if (int_4 < 0)
        {
            throw new ArgumentException("Padding value cannot be negative");
        }
        this.int_3 = int_4;
    }

    public bool method_8()
    {
        return this.method_0() == 0 && this.method_4() == 0 && this.method_2() == 0 && this.method_6() == 0;
    }

    public static bool smethod_0(GStruct13 gstruct13_1, GStruct13 gstruct13_2)
    {
        return gstruct13_1.method_0() == gstruct13_2.method_0() && gstruct13_1.method_4() == gstruct13_2.method_4() && gstruct13_1.method_2() == gstruct13_2.method_2() && gstruct13_1.method_6() == gstruct13_2.method_6();
    }

    public static bool smethod_1(GStruct13 gstruct13_1, GStruct13 gstruct13_2)
    {
        return !GStruct13.smethod_0(gstruct13_1, gstruct13_2);
    }

    public static readonly GStruct13 gstruct13_0 = new GStruct13(0, 0, 0, 0);

    int int_0;

    int int_1;

    int int_2;

    int int_3;
}
