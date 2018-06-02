using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

public class GClass154 : UITypeEditor
{
    public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
    {
        return UITypeEditorEditStyle.DropDown;
    }

    public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
    {
        if (value.GetType() != typeof(GClass95))
        {
            return value;
        }
        this.iwindowsFormsEditorService_0 = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
        GClass125 gclass = context.PropertyDescriptor as GClass125;
        GClass95 gclass2 = value as GClass95;
        if (this.iwindowsFormsEditorService_0 != null && gclass != null && gclass2 != null)
        {
            if (gclass.method_0().method_0() == GEnum67.const_5)
            {
                ListBox listBox = new ListBox();
                listBox.BorderStyle = BorderStyle.None;
                listBox.MouseUp += this.method_0;
                listBox.BeginUpdate();
                int num = 0;
                foreach (GClass137 gclass3 in gclass2.method_4())
                {
                    listBox.Items.Add(gclass3);
                    if (gclass3.method_1() == gclass2.method_5())
                    {
                        listBox.SelectedIndex = num;
                    }
                    num++;
                }
                listBox.EndUpdate();
                this.iwindowsFormsEditorService_0.DropDownControl(listBox);
                GClass137 gclass4 = listBox.SelectedItem as GClass137;
                if (gclass4 != null && gclass4.method_1() != gclass2.method_5())
                {
                    GClass95 gclass5 = new GClass95(gclass2.method_3(), gclass2.method_4());
                    gclass5.method_2(false);
                    gclass5.method_6(gclass4.method_1());
                    return gclass5;
                }
            }
            else
            {
                CheckedListBox checkedListBox = new CheckedListBox();
                checkedListBox.CheckOnClick = true;
                checkedListBox.BorderStyle = BorderStyle.None;
                checkedListBox.BeginUpdate();
                int num2 = 0;
                foreach (GClass137 gclass6 in gclass2.method_4())
                {
                    checkedListBox.Items.Add(gclass6);
                    checkedListBox.SetItemChecked(num2, (gclass6.method_1() & gclass2.method_5()) == gclass6.method_1());
                    num2++;
                }
                checkedListBox.EndUpdate();
                this.iwindowsFormsEditorService_0.DropDownControl(checkedListBox);
                uint num3 = 0u;
                foreach (object obj in checkedListBox.CheckedItems)
                {
                    GClass137 gclass7 = (GClass137)obj;
                    num3 |= gclass7.method_1();
                }
                if (num3 != gclass2.method_5())
                {
                    GClass95 gclass8 = new GClass95(gclass2.method_3(), gclass2.method_4());
                    gclass8.method_2(true);
                    gclass8.method_6(num3);
                    return gclass8;
                }
            }
            return value;
        }
        return value;
    }

    protected void method_0(object sender, MouseEventArgs e)
    {
        this.iwindowsFormsEditorService_0.CloseDropDown();
    }

    protected IWindowsFormsEditorService iwindowsFormsEditorService_0;
}
