using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public partial class BatchExportNewNameDialog : Form
{
    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    public BatchExportNewNameDialog()
    {
        this.InitializeComponent();
    }

    public string method_0()
    {
        return this.textBox1.Text;
    }

    IContainer icontainer_0;
}
