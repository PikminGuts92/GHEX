using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public partial class ArkRelinkDialog : Form
{
    public ArkRelinkDialog(ArkEntry gclass126_1)
    {
        this.InitializeComponent();
        this.MinimumSize = base.Size;
        this.gclass126_0 = gclass126_1;
        this.Text = "Point \"" + gclass126_1.GetFileName() + "\" to..";
        this.tvFiles.Select();
    }

    public TreeView method_0()
    {
        return this.tvFiles;
    }

    void tvFiles_AfterSelect(object sender, TreeViewEventArgs e)
    {
        ArkEntry gclass = e.Node.Tag as ArkEntry;
        bool flag = gclass != null && gclass != this.gclass126_0;
        this.cbSwap.Enabled = flag;
        this.btnOk.Enabled = flag;
        if (flag)
        {
            this.cbSwap_CheckedChanged(gclass, EventArgs.Empty);
            return;
        }
        this.cbSwap.Text = "..and swap files";
    }

    void cbSwap_CheckedChanged(object sender, EventArgs e)
    {
        ArkEntry gclass = this.tvFiles.SelectedNode.Tag as ArkEntry;
        if (this.cbSwap.Checked)
        {
            this.cbSwap.Text = string.Concat(new string[]
            {
                "..and \"",
                gclass.GetFileName(),
                "\" to \"",
                this.gclass126_0.GetFileName(),
                "\""
            });
            return;
        }
        this.cbSwap.Text = "..and orphan it";
    }

    void btnOk_Click(object sender, EventArgs e)
    {
        ArkEntry gclass = this.tvFiles.SelectedNode.Tag as ArkEntry;
        if (gclass.GetFileExtension() != this.gclass126_0.GetFileExtension() && MessageBox.Show("Files do not share the same extension.\nAre you sure you want to do this?", this.gclass126_0.GetFileName(), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
        {
            return;
        }
        bool bool_ = false;
        if (!this.cbSwap.Checked)
        {
            bool_ = (MessageBox.Show("You have chosen to orphan a file.\nDo you really want do do this?\n(You will not be able to access it again!)", this.gclass126_0.GetFileName(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }
        this.gclass126_0.method_10(gclass, this.cbSwap.Checked, bool_);
        base.DialogResult = DialogResult.OK;
    }

    void tvFiles_DoubleClick(object sender, EventArgs e)
    {
        if (this.tvFiles.SelectedNode == null)
        {
            return;
        }
        this.btnOk_Click(sender, e);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    ArkEntry gclass126_0;

    IContainer icontainer_0;
}
