using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
class Class48
{
	internal Class48()
	{
	}

	internal static ResourceManager smethod_0()
	{
		if (object.ReferenceEquals(Class48.resourceManager_0, null))
		{
			ResourceManager resourceManager = new ResourceManager("gh.Properties.Resources", typeof(Class48).Assembly);
			Class48.resourceManager_0 = resourceManager;
		}
		return Class48.resourceManager_0;
	}

	internal static CultureInfo smethod_1()
	{
		return Class48.cultureInfo_0;
	}

	internal static void smethod_2(CultureInfo cultureInfo_1)
	{
		Class48.cultureInfo_0 = cultureInfo_1;
	}

	static ResourceManager resourceManager_0;

	static CultureInfo cultureInfo_0;
}
