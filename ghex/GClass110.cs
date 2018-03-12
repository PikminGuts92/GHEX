using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

public class GClass110 : TypeConverter
{
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		return destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
	}

	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if (destinationType == typeof(InstanceDescriptor) && value is GClass83)
		{
			ConstructorInfo constructor = typeof(GClass83).GetConstructor(new Type[0]);
			if (constructor != null)
			{
				return new InstanceDescriptor(constructor, null, false);
			}
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}
}
