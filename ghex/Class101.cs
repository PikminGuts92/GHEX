using System;
using System.ComponentModel;
using System.Windows.Forms;

class Class101
{
    public Class101()
    {
        this.checkState_0 = CheckState.Unchecked;
        this.bool_0 = false;
    }

    public bool method_0()
    {
        return this.checkState_0 != CheckState.Unchecked;
    }

    public void method_1(bool bool_1)
    {
        if (bool_1 != this.method_0())
        {
            this.method_3(bool_1 ? CheckState.Checked : CheckState.Unchecked);
        }
    }

    public CheckState method_2()
    {
        return this.checkState_0;
    }

    public void method_3(CheckState checkState_1)
    {
        if (!Enum.IsDefined(typeof(CheckState), checkState_1))
        {
            throw new InvalidEnumArgumentException("value", (int)checkState_1, typeof(CheckState));
        }
        if (this.checkState_0 != checkState_1)
        {
            this.checkState_0 = checkState_1;
        }
    }

    public bool method_4()
    {
        return this.bool_0;
    }

    public void method_5(bool bool_1)
    {
        this.bool_0 = bool_1;
    }

    CheckState checkState_0;

    bool bool_0;
}
