using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GClass118 : ICustomTypeDescriptor
{
	public GClass118()
	{
		this.propertyDescriptorCollection_0 = new PropertyDescriptorCollection(null);
	}

	public void method_0(string string_0, string string_1)
	{
		foreach (object obj in this.propertyDescriptorCollection_0)
		{
			GClass125 gclass = (GClass125)obj;
			if (string.Compare(gclass.Category, string_0) == 0 && gclass.Name.StartsWith(string_1))
			{
				this.gclass125_0 = gclass;
				break;
			}
		}
	}

	public List<GClass153> method_1()
	{
		return this.list_0;
	}

	public void method_2()
	{
		if (this.propertyDescriptorCollection_0.Count == this.list_0.Count)
		{
			return;
		}
		this.propertyDescriptorCollection_0.Clear();
		foreach (GClass153 gclass in this.list_0)
		{
			GClass125 value = new GClass125(gclass, gclass.method_10());
			this.propertyDescriptorCollection_0.Add(value);
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_3(PropertyValueChangedEventHandler propertyValueChangedEventHandler_1)
	{
		this.propertyValueChangedEventHandler_0 = (PropertyValueChangedEventHandler)Delegate.Combine(this.propertyValueChangedEventHandler_0, propertyValueChangedEventHandler_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_4(PropertyValueChangedEventHandler propertyValueChangedEventHandler_1)
	{
		this.propertyValueChangedEventHandler_0 = (PropertyValueChangedEventHandler)Delegate.Remove(this.propertyValueChangedEventHandler_0, propertyValueChangedEventHandler_1);
	}

	public void method_5(object sender, PropertyValueChangedEventArgs e)
	{
		if (this.propertyValueChangedEventHandler_0 != null)
		{
			this.propertyValueChangedEventHandler_0(sender, e);
		}
	}

	public TypeConverter GetConverter()
	{
		return TypeDescriptor.GetConverter(this, true);
	}

	public EventDescriptorCollection GetEvents(Attribute[] attributes)
	{
		return TypeDescriptor.GetEvents(this, attributes, true);
	}

	public EventDescriptorCollection GetEvents()
	{
		return TypeDescriptor.GetEvents(this, true);
	}

	public string GetComponentName()
	{
		return TypeDescriptor.GetComponentName(this, true);
	}

	public object GetPropertyOwner(PropertyDescriptor propertyDescriptor_0)
	{
		return this;
	}

	public AttributeCollection GetAttributes()
	{
		return TypeDescriptor.GetAttributes(this, true);
	}

	public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
	{
		this.method_2();
		return this.propertyDescriptorCollection_0;
	}

	public PropertyDescriptorCollection GetProperties()
	{
		return TypeDescriptor.GetProperties(this, true);
	}

	public object GetEditor(Type editorBaseType)
	{
		return TypeDescriptor.GetEditor(this, editorBaseType, true);
	}

	public PropertyDescriptor GetDefaultProperty()
	{
		if (this.gclass125_0 != null)
		{
			return this.gclass125_0;
		}
		return TypeDescriptor.GetDefaultProperty(this, true);
	}

	public EventDescriptor GetDefaultEvent()
	{
		return TypeDescriptor.GetDefaultEvent(this, true);
	}

	public string GetClassName()
	{
		return TypeDescriptor.GetClassName(this, true);
	}

	PropertyDescriptorCollection propertyDescriptorCollection_0;

	GClass125 gclass125_0;

	List<GClass153> list_0 = new List<GClass153>();

	PropertyValueChangedEventHandler propertyValueChangedEventHandler_0;
}
