using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

public class GClass133 : UITypeEditor
{
	public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
	{
		return UITypeEditorEditStyle.Modal;
	}

	public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
	{
		if (value.GetType() != typeof(string))
		{
			return value;
		}
		this.iwindowsFormsEditorService_0 = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
		GClass125 gclass = context.PropertyDescriptor as GClass125;
		this.string_0 = (value as string);
		if (this.iwindowsFormsEditorService_0 == null || gclass == null || this.string_0 == null)
		{
			return value;
		}
		FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
		folderBrowserDialog.Description = "Select a directory";
		folderBrowserDialog.SelectedPath = this.string_0;
		if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
		{
			return folderBrowserDialog.SelectedPath;
		}
		return value;
	}

	protected IWindowsFormsEditorService iwindowsFormsEditorService_0;

	protected string string_0;
}
