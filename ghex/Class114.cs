using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

class Class114 : TypeConverter
{
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
        return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
    }

    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
        return destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
    }

    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
        if (!(value is string))
        {
            return base.ConvertFrom(context, culture, value);
        }
        string text = ((string)value).Trim();
        if (text.Length == 0)
        {
            return null;
        }
        if (culture == null)
        {
            culture = CultureInfo.CurrentCulture;
        }
        char[] separator = culture.TextInfo.ListSeparator.ToCharArray();
        string[] array = text.Split(separator);
        if (array.Length < 4)
        {
            return null;
        }
        return new GStruct13(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2]), int.Parse(array[3]));
    }

    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
        if (destinationType == null)
        {
            throw new ArgumentNullException("destinationType");
        }
        if (destinationType == typeof(string) && value is GStruct13)
        {
            GStruct13 gstruct = (GStruct13)value;
            if (culture == null)
            {
                culture = CultureInfo.CurrentCulture;
            }
            string separator = culture.TextInfo.ListSeparator + " ";
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(int));
            return string.Join(separator, new string[]
            {
                converter.ConvertToString(context, culture, gstruct.method_0()),
                converter.ConvertToString(context, culture, gstruct.method_4()),
                converter.ConvertToString(context, culture, gstruct.method_2()),
                converter.ConvertToString(context, culture, gstruct.method_6())
            });
        }
        if (destinationType == typeof(InstanceDescriptor) && value is GStruct13)
        {
            GStruct13 gstruct2 = (GStruct13)value;
            Type[] array = new Type[4];
            array[0] = (array[1] = (array[2] = (array[3] = typeof(int))));
            ConstructorInfo constructor = typeof(GStruct13).GetConstructor(array);
            if (constructor != null)
            {
                return new InstanceDescriptor(constructor, new object[]
                {
                    gstruct2.method_0(),
                    gstruct2.method_4(),
                    gstruct2.method_2(),
                    gstruct2.method_6()
                });
            }
        }
        return base.ConvertTo(context, culture, value, destinationType);
    }

    public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
    {
        return new GStruct13((int)propertyValues["Left"], (int)propertyValues["Top"], (int)propertyValues["Right"], (int)propertyValues["Bottom"]);
    }

    public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
    {
        return true;
    }

    public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
    {
        PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(GStruct13), attributes);
        return properties.Sort(new string[]
        {
            "Left",
            "Top",
            "Right",
            "Bottom"
        });
    }

    public override bool GetPropertiesSupported(ITypeDescriptorContext context)
    {
        return true;
    }
}
