using System;
using System.Reflection;

[DefaultMember("Item")]
public class GClass95
{
	public GClass95(string string_1, GClass137[] gclass137_1)
	{
		this.string_0 = string_1;
		this.gclass137_0 = gclass137_1;
		this.uint_0 = 0u;
	}

	public uint method_0(string string_1)
	{
		foreach (GClass137 gclass in this.gclass137_0)
		{
			if (string.Compare(gclass.method_0(), string_1, true) == 0)
			{
				return gclass.method_1();
			}
		}
		return 0u;
	}

	public bool method_1()
	{
		return this.bool_0;
	}

	public void method_2(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	public string method_3()
	{
		return this.string_0;
	}

	public GClass137[] method_4()
	{
		return this.gclass137_0;
	}

	public uint method_5()
	{
		return this.uint_0;
	}

	public void method_6(uint uint_1)
	{
		this.uint_0 = uint_1;
	}

	public virtual string ToString()
	{
		if (!this.bool_0)
		{
			foreach (GClass137 gclass in this.gclass137_0)
			{
				if (gclass.method_1() == this.uint_0)
				{
					return gclass.method_0();
				}
			}
			return "";
		}
		string text = "";
		foreach (GClass137 gclass2 in this.gclass137_0)
		{
			if ((gclass2.method_1() & this.uint_0) == gclass2.method_1())
			{
				text = text + gclass2.method_0() + "|";
			}
		}
		if (text.EndsWith("|"))
		{
			return text.TrimEnd(new char[]
			{
				'|'
			});
		}
		return text;
	}

	protected string string_0;

	protected GClass137[] gclass137_0;

	protected uint uint_0;

	protected bool bool_0;
}
