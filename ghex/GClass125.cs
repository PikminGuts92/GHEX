using System;
using System.ComponentModel;

public class GClass125 : PropertyDescriptor
{
	public GClass125(GClass153 gclass153_1, Attribute[] attribute_0) : base(gclass153_1.method_1(), attribute_0)
	{
		this.gclass153_0 = gclass153_1;
	}

	public override Type ComponentType
	{
		get
		{
			return base.GetType();
		}
	}

	public override bool IsReadOnly
	{
		get
		{
			return this.Attributes.Matches(ReadOnlyAttribute.Yes);
		}
	}

	public override Type PropertyType
	{
		get
		{
			return this.gclass153_0.method_8().GetType();
		}
	}

	public override bool CanResetValue(object component)
	{
		return true;
	}

	public override object GetValue(object component)
	{
		return this.gclass153_0.method_8();
	}

	public override void ResetValue(object component)
	{
	}

	public override void SetValue(object component, object value)
	{
		this.gclass153_0.method_9(value);
	}

	public override bool ShouldSerializeValue(object component)
	{
		return false;
	}

	public GClass153 method_0()
	{
		return this.gclass153_0;
	}

	GClass153 gclass153_0;
}
