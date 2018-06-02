using System;
using System.Drawing;

struct Struct7
{
    public Struct7(int int_2, int int_3)
    {
        this.int_0 = int_2;
        this.int_1 = int_3;
    }

    public static Struct7 smethod_0(Size size_0)
    {
        return new Struct7(size_0.Width, size_0.Height);
    }

    public Size method_0()
    {
        return new Size(this.int_0, this.int_1);
    }

    public int int_0;

    public int int_1;
}
