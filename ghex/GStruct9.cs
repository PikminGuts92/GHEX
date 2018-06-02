using System;

[Serializable]
public struct GStruct9
{
    public GStruct9(int int_2, int int_3)
    {
        this.int_0 = int_2;
        this.int_1 = int_3;
    }

    public void method_0(int int_2, int int_3)
    {
        this.int_0 += int_2;
        this.int_1 += int_3;
    }

    public override bool Equals(object object_0)
    {
        if (!(object_0 is GStruct9))
        {
            return false;
        }
        GStruct9 gstruct = (GStruct9)object_0;
        return gstruct.method_1() == this.method_1() && gstruct.method_3() == this.method_3();
    }

    public override int GetHashCode()
    {
        return this.method_1() ^ (this.method_3() << 13 | this.method_3() >> 19);
    }

    public override string ToString()
    {
        return string.Concat(new object[]
        {
            "CellPos: (",
            this.method_1(),
            ",",
            this.method_3(),
            ")"
        });
    }

    public int method_1()
    {
        return this.int_0;
    }

    public void method_2(int int_2)
    {
        this.int_0 = int_2;
    }

    public int method_3()
    {
        return this.int_1;
    }

    public void method_4(int int_2)
    {
        this.int_1 = int_2;
    }

    public bool method_5()
    {
        return this.method_1() == -1 || this.method_3() == -1;
    }

    public static bool smethod_0(GStruct9 gstruct9_1, GStruct9 gstruct9_2)
    {
        return gstruct9_1.method_1() == gstruct9_2.method_1() && gstruct9_1.method_3() == gstruct9_2.method_3();
    }

    public static bool smethod_1(GStruct9 gstruct9_1, GStruct9 gstruct9_2)
    {
        return !GStruct9.smethod_0(gstruct9_1, gstruct9_2);
    }

    public static readonly GStruct9 gstruct9_0 = new GStruct9(-1, -1);

    int int_0;

    int int_1;
}
