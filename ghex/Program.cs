using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

static class Program
{
    [STAThread]
    static void Main()
    {
        Settings.GetGlobalSettings().LoadXML();
        Class109.smethod_16();
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        if (Program.gdelegate22_0 == null)
        {
            Program.gdelegate22_0 = new ExceptionDialog.GDelegate22(Program.smethod_0);
        }
        ExceptionDialog.smethod_3(Program.gdelegate22_0);
        Settings.GetGlobalSettings().SaveXML();
    }

    [CompilerGenerated]
    static void smethod_0()
    {
        Application.Run(new MainWindow());
    }

    [CompilerGenerated]
    static ExceptionDialog.GDelegate22 gdelegate22_0;
}
