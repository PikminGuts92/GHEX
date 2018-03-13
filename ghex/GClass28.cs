using System;
using System.ComponentModel.Design;
using System.Windows.Forms;

public class GClass28 : CollectionEditor
{
	public GClass28(Type type_0) : base(type_0)
	{
	}

	protected override CollectionEditor.CollectionForm CreateCollectionForm()
	{
		CollectionEditor.CollectionForm collectionForm = base.CreateCollectionForm();
		foreach (object obj in collectionForm.Controls)
		{
			Control control = (Control)obj;
			if (control is PropertyGrid)
			{
				PropertyGrid propertyGrid = (PropertyGrid)control;
				propertyGrid.HelpVisible = true;
				propertyGrid.CommandsVisibleIfAvailable = true;
			}
		}
		return collectionForm;
	}
}
