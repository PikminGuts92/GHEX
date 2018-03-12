using System;
using System.Drawing;
using System.Windows.Forms;

public class GClass44 : GClass38
{
	public GClass44(GClass104 gclass104_1, int int_1, SortOrder sortOrder_1) : base(gclass104_1, int_1, sortOrder_1)
	{
	}

	public virtual int Compare(object object_0, object object_1)
	{
		GClass97 gclass = (GClass97)object_0;
		GClass97 gclass2 = (GClass97)object_1;
		if (gclass == null && gclass2 == null)
		{
			return 0;
		}
		if (gclass == null)
		{
			return -1;
		}
		if (gclass2 == null)
		{
			return 1;
		}
		if (gclass.method_7() == null && gclass2.method_7() == null)
		{
			return 0;
		}
		if (gclass.method_7() == null)
		{
			return -1;
		}
		if (gclass2.method_7() == null)
		{
			return 1;
		}
		Color color = (Color)gclass.method_7();
		Color color2 = (Color)gclass2.method_7();
		if (color.GetHue() < color2.GetHue())
		{
			return -1;
		}
		if (color.GetHue() > color2.GetHue())
		{
			return 1;
		}
		if (color.GetSaturation() < color2.GetSaturation())
		{
			return -1;
		}
		if (color.GetSaturation() > color2.GetSaturation())
		{
			return 1;
		}
		if (color.GetBrightness() < color2.GetBrightness())
		{
			return -1;
		}
		if (color.GetBrightness() > color2.GetBrightness())
		{
			return 1;
		}
		return 0;
	}
}
