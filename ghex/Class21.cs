using System;
using System.Security.Permissions;
using System.Windows.Forms;

class Class21 : IMessageFilter
{
    public Class21(GInterface5 ginterface5_1)
    {
        this.ginterface5_0 = ginterface5_1;
    }

    public GInterface5 method_0()
    {
        return this.ginterface5_0;
    }

    public void method_1(GInterface5 ginterface5_1)
    {
        this.ginterface5_0 = ginterface5_1;
    }

    public bool PreFilterMessage(ref Message message_0)
    {
        if (this.method_0() == null)
        {
            return false;
        }
        if (message_0.Msg != 256 && message_0.Msg != 260 && message_0.Msg != 257 && message_0.Msg != 261)
        {
            return false;
        }
        UIPermission uipermission = new UIPermission(UIPermissionWindow.AllWindows);
        uipermission.Demand();
        Control control_ = Control.FromChildHandle(message_0.HWnd);
        return this.method_0().imethod_0(control_, (GEnum8)message_0.Msg, message_0.WParam.ToInt32(), message_0.LParam.ToInt32());
    }

    GInterface5 ginterface5_0;
}
