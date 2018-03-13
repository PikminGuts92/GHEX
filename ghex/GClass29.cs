using System;
using System.ComponentModel;

public class GClass29 : GClass28
{
	public GClass29(Type type_0) : base(type_0)
	{
		this.gclass70_0 = null;
	}

	public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
	{
		this.gclass70_0 = (GClass70)value;
		object result = base.EditValue(context, provider, value);
		GClass83 gclass = (GClass83)context.Instance;
		if (gclass.method_31() != null && gclass.method_31().method_18() != null)
		{
			gclass.method_31().method_18().PerformLayout();
			gclass.method_31().method_18().Refresh();
		}
		return result;
	}

	protected override object CreateInstance(Type itemType)
	{
		GClass97 gclass = (GClass97)base.CreateInstance(itemType);
		this.gclass70_0.method_0(gclass);
		return gclass;
	}

	protected override void DestroyInstance(object instance)
	{
		if (instance != null && instance is GClass97)
		{
			GClass97 gclass97_ = (GClass97)instance;
			this.gclass70_0.method_2(gclass97_);
		}
		base.DestroyInstance(instance);
	}

	GClass70 gclass70_0;
}
