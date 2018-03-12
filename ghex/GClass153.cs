using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;

public class GClass153
{
	public GClass153(string string_3, GEnum67 genum67_1, object object_1, string string_4, string string_5, bool bool_1)
	{
		this.genum67_0 = genum67_1;
		this.string_0 = string_3;
		this.string_1 = string_5;
		this.string_2 = string_4;
		this.object_0 = object_1;
		this.bool_0 = bool_1;
	}

	public GClass153(string string_3, GEnum67 genum67_1, object object_1, string string_4, string string_5) : this(string_3, genum67_1, object_1, string_4, string_5, false)
	{
	}

	public GClass153(string string_3, GEnum67 genum67_1, object object_1, string string_4) : this(string_3, genum67_1, object_1, string_4, null)
	{
	}

	public GEnum67 method_0()
	{
		return this.genum67_0;
	}

	public string method_1()
	{
		return this.string_0;
	}

	public string method_2()
	{
		return this.string_1;
	}

	public void method_3(string string_3)
	{
		this.string_1 = string_3;
	}

	public string method_4()
	{
		return this.string_2;
	}

	public void method_5(string string_3)
	{
		this.string_2 = string_3;
	}

	public bool method_6()
	{
		return this.bool_0;
	}

	public void method_7(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	public object method_8()
	{
		return this.object_0;
	}

	public void method_9(object object_1)
	{
		this.object_0 = object_1;
	}

	public Attribute[] method_10()
	{
		ArrayList arrayList = new ArrayList();
		if (this.string_1 != null)
		{
			arrayList.Add(new CategoryAttribute(this.string_1));
		}
		if (this.string_2 != null)
		{
			arrayList.Add(new DescriptionAttribute(this.string_2));
		}
		arrayList.Add(new ReadOnlyAttribute(this.bool_0));
		switch (this.genum67_0)
		{
		case GEnum67.const_5:
		case GEnum67.const_6:
			arrayList.Add(new EditorAttribute(typeof(GClass154), typeof(UITypeEditor)));
			break;
		case GEnum67.const_7:
			arrayList.Add(new EditorAttribute(typeof(GClass133), typeof(UITypeEditor)));
			break;
		}
		return (Attribute[])arrayList.ToArray(typeof(Attribute));
	}

	protected GEnum67 genum67_0;

	protected string string_0;

	protected object object_0;

	protected string string_1;

	protected string string_2;

	protected bool bool_0;
}
