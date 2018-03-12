using System;
using System.ComponentModel;
using System.Drawing;

[ToolboxItem(false)]
[DesignTimeVisible(false)]
public abstract class GClass19 : GClass17
{
	public GClass19()
	{
		this.method_44();
	}

	public GClass19(string string_3) : base(string_3)
	{
		this.method_44();
	}

	public GClass19(string string_3, int int_11) : base(string_3, int_11)
	{
		this.method_44();
	}

	public GClass19(string string_3, int int_11, bool bool_2) : base(string_3, int_11, bool_2)
	{
		this.method_44();
	}

	public GClass19(string string_3, Image image_1) : base(string_3, image_1)
	{
		this.method_44();
	}

	public GClass19(string string_3, Image image_1, int int_11) : base(string_3, image_1, int_11)
	{
		this.method_44();
	}

	public GClass19(string string_3, Image image_1, int int_11, bool bool_2) : base(string_3, image_1, int_11, bool_2)
	{
		this.method_44();
	}

	void method_44()
	{
		this.bool_1 = true;
	}

	public bool method_45()
	{
		return this.bool_1;
	}

	public void method_46(bool bool_2)
	{
		if (this.bool_1 != bool_2)
		{
			this.bool_1 = bool_2;
			this.vmethod_13(new GClass93(this, GEnum13.const_9, null));
		}
	}

	bool bool_1;
}
