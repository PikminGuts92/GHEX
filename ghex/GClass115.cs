using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

[DefaultMember("Item")]
public class GClass115 : GClass114, IEnumerable<GEnum51>
{
    public GClass115(GClass35 gclass35_0, GEnum50 genum50_1) : base(gclass35_0, genum50_1)
    {
    }

    public GClass115(GClass35 gclass35_0, GEnum50 genum50_1, List<GEnum51> list_1, int int_2, int int_3) : base(gclass35_0, genum50_1, int_2, int_3)
    {
        this.list_0.AddRange(list_1);
    }

    public bool method_10(GEnum51 genum51_0)
    {
        return this.list_0.Contains(genum51_0);
    }

    public void method_11(GEnum51 genum51_0, bool bool_1)
    {
        if (this.list_0.Contains(genum51_0))
        {
            if (!bool_1)
            {
                this.list_0.Remove(genum51_0);
                base.method_0().method_12(this, (GEnum5)0);
                return;
            }
        }
        else if (bool_1)
        {
            this.list_0.Add(genum51_0);
            base.method_0().method_12(this, (GEnum5)0);
        }
    }

    public bool method_12()
    {
        return this.list_0.Count > 1;
    }

    public bool method_13()
    {
        return base.method_7() > base.method_0().method_0().method_9() / 3;
    }

    public IEnumerator<GEnum51> GetEnumerator()
    {
        return this.list_0.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    List<GEnum51> list_0 = new List<GEnum51>();
}
