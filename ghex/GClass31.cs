using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;

public class GClass31 : GClass28
{
	public GClass31(Type type_0) : base(type_0)
	{
		this.gclass85_0 = null;
		this.gclass32_0 = new GClass32();
		this.gclass32_0.method_23().method_0(new GClass25("Column", 116));
		this.gclass104_0 = new GClass104();
		this.gclass104_0.method_12().method_0(new GClass83());
		GClass97 gclass = new GClass97();
		gclass.method_38(false);
		gclass.method_44("This is a Cell ToolTip");
		this.gclass104_0.method_12().method_9(0).method_9().method_0(gclass);
		this.gclass104_0.method_15(20);
		this.gcontrol2_0 = new GControl2();
		this.gcontrol2_0.method_248(true);
		this.gcontrol2_0.Size = new Size(120, 274);
		this.gcontrol2_0.Location = new Point(246, 24);
		this.gcontrol2_0.method_183(GEnum3.const_3);
		this.gcontrol2_0.TabStop = false;
		this.gcontrol2_0.method_251(true);
		this.gcontrol2_0.method_167(this.gclass32_0);
		this.gcontrol2_0.method_240(this.gclass104_0);
		this.label_0 = new Label();
		this.label_0.Text = "Preview:";
		this.label_0.Size = new Size(140, 16);
		this.label_0.Location = new Point(247, 8);
	}

	public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
	{
		this.gclass85_0 = (GClass85)value;
		for (int i = 0; i < this.gclass85_0.Count; i++)
		{
			this.gclass85_0.method_8(i).method_0(new GDelegate11(this.method_1));
		}
		object result = base.EditValue(context, provider, value);
		GClass32 gclass = (GClass32)context.Instance;
		if (gclass.method_32() != null)
		{
			gclass.method_32().PerformLayout();
			gclass.method_32().Refresh();
		}
		return result;
	}

	protected override Type[] CreateNewItemTypes()
	{
		return new Type[]
		{
			typeof(GClass25),
			typeof(GClass23),
			typeof(GClass24),
			typeof(GClass21),
			typeof(GClass20),
			typeof(GClass22),
			typeof(GClass27),
			typeof(GClass18),
			typeof(GClass26)
		};
	}

	protected override object CreateInstance(Type itemType)
	{
		GClass17 gclass = (GClass17)base.CreateInstance(itemType);
		this.gclass85_0.method_0(gclass);
		gclass.method_0(new GDelegate11(this.method_1));
		return gclass;
	}

	protected override void DestroyInstance(object instance)
	{
		if (instance != null && instance is GClass17)
		{
			GClass17 gclass = (GClass17)instance;
			this.gclass85_0.method_2(gclass);
			gclass.method_1(new GDelegate11(this.method_1));
		}
		base.DestroyInstance(instance);
	}

	protected override CollectionEditor.CollectionForm CreateCollectionForm()
	{
		CollectionEditor.CollectionForm collectionForm = base.CreateCollectionForm();
		collectionForm.Width += 140;
		foreach (object obj in collectionForm.Controls)
		{
			Control control = (Control)obj;
			if (control.Name.Equals("propertiesLabel"))
			{
				control.Location = new Point(control.Left + 140, control.Top);
			}
			if (control is PropertyGrid)
			{
				PropertyGrid propertyGrid = (PropertyGrid)control;
				propertyGrid.SelectedObjectsChanged += this.method_0;
				propertyGrid.Location = new Point(propertyGrid.Left + 140, propertyGrid.Top);
				propertyGrid.Width -= 140;
			}
		}
		collectionForm.Controls.Add(this.label_0);
		collectionForm.Controls.Add(this.gcontrol2_0);
		return collectionForm;
	}

	protected void method_0(object sender, EventArgs e)
	{
		object[] selectedObjects = ((PropertyGrid)sender).SelectedObjects;
		this.gclass32_0.method_23().method_5();
		if (selectedObjects.Length == 1)
		{
			GClass17 gclass = (GClass17)selectedObjects[0];
			GClass97 gclass2 = this.gclass104_0.method_10(0, 0);
			if (gclass is GClass23)
			{
				gclass2.method_6("Button");
				gclass2.method_8(null);
			}
			else if (gclass is GClass24)
			{
				gclass2.method_6("Checkbox");
				gclass2.method_8(null);
				gclass2.method_28(true);
			}
			else if (gclass is GClass21)
			{
				gclass2.method_6(null);
				gclass2.method_8(Color.Red);
			}
			else if (gclass is GClass20)
			{
				gclass2.method_6("ComboBox");
				gclass2.method_8(null);
			}
			else if (gclass is GClass22)
			{
				gclass2.method_6(null);
				gclass2.method_8(DateTime.Now);
			}
			else if (gclass is GClass27)
			{
				gclass2.method_6("Image");
				gclass2.method_8(null);
			}
			else if (!(gclass is GClass18) && !(gclass is GClass26))
			{
				gclass2.method_6("Text");
				gclass2.method_8(null);
			}
			else
			{
				gclass2.method_6(null);
				gclass2.method_8(50);
			}
			this.gclass32_0.method_23().method_0(gclass);
		}
		this.gcontrol2_0.Invalidate();
	}

	void method_1(object object_0, GClass93 gclass93_0)
	{
		this.gclass85_0.method_9().method_37(gclass93_0);
	}

	GClass85 gclass85_0;

	GControl2 gcontrol2_0;

	GClass32 gclass32_0;

	GClass104 gclass104_0;

	Label label_0;
}
