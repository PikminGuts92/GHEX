using System;
using System.ComponentModel;

public class GClass30 : GClass28
{
	public GClass30(Type type_0) : base(type_0)
	{
		this.gclass82_0 = null;
	}

	public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
	{
		this.gclass82_0 = (GClass82)value;
		object result = base.EditValue(context, provider, value);
		GClass104 gclass = (GClass104)context.Instance;
		if (gclass.method_18() != null)
		{
			gclass.method_18().PerformLayout();
			gclass.method_18().Refresh();
		}
		return result;
	}

	protected override object CreateInstance(Type itemType)
	{
		GClass83 gclass = (GClass83)base.CreateInstance(itemType);
		this.gclass82_0.method_0(gclass);
		return gclass;
	}

	protected override void DestroyInstance(object instance)
	{
		if (instance != null && instance is GClass83)
		{
			GClass83 gclass83_ = (GClass83)instance;
			this.gclass82_0.method_2(gclass83_);
		}
		base.DestroyInstance(instance);
	}

	GClass82 gclass82_0;
}
