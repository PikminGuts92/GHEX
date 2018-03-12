using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

static class Class29
{
	[STAThread]
	static void Main()
	{
		Class61.smethod_0().method_1();
		Class109.smethod_16();
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		if (Class29.gdelegate22_0 == null)
		{
			Class29.gdelegate22_0 = new ExceptionDialog.GDelegate22(Class29.smethod_0);
		}
		ExceptionDialog.smethod_3(Class29.gdelegate22_0);
		Class61.smethod_0().method_2();
	}

	[CompilerGenerated]
	static void smethod_0()
	{
		Application.Run(new MainWindow());
	}

	[CompilerGenerated]
	static ExceptionDialog.GDelegate22 gdelegate22_0;
}
