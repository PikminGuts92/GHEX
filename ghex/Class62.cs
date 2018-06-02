using System;
using System.Security.Permissions;
using System.Windows.Forms;

class Class62 : IMessageFilter
{
    public Class62(GInterface4 ginterface4_1)
    {
        this.ginterface4_0 = ginterface4_1;
    }

    public GInterface4 method_0()
    {
        return this.ginterface4_0;
    }

    public void method_1(GInterface4 ginterface4_1)
    {
        this.ginterface4_0 = ginterface4_1;
    }

    public bool PreFilterMessage(ref Message message_0)
    {
        if (this.method_0() == null)
        {
            return false;
        }
        if ((message_0.Msg >= 512 && message_0.Msg <= 525) || (message_0.Msg >= 160 && message_0.Msg <= 172))
        {
            UIPermission uipermission = new UIPermission(UIPermissionWindow.AllWindows);
            uipermission.Demand();
            Control control_ = Control.FromChildHandle(message_0.HWnd);
            return this.method_0().imethod_4(control_, (GEnum8)message_0.Msg, message_0.WParam.ToInt32(), message_0.LParam.ToInt32());
        }
        return false;
    }

    GInterface4 ginterface4_0;
}
