using System;

public class GClass52 : GInterface7
{
    public bool imethod_0()
    {
        return true;
    }

    public bool imethod_1()
    {
        return true;
    }

    public void Dispose()
    {
    }

    public GClass52(GClass114 gclass114_1)
    {
        this.gclass114_0 = gclass114_1;
    }

    public void imethod_2(GClass122 gclass122_0)
    {
        this.imethod_4();
    }

    public void imethod_3()
    {
        this.gclass114_0.method_0().method_7(this.gclass114_0);
    }

    public void imethod_4()
    {
        this.gclass114_0.method_0().method_10(this.gclass114_0);
    }

    public string imethod_5()
    {
        return "Remove Event " + this.gclass114_0.ToString();
    }

    GClass114 gclass114_0;
}
