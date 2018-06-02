using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public partial class BadArkDialog : Form
{
    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
        {
            this.icontainer_0.Dispose();
        }
        base.Dispose(disposing);
    }

    public BadArkDialog(List<ArkEntry> list_3)
    {
        this.InitializeComponent();
        this.MinimumSize = base.Size;
        this.MaximumSize = new Size(base.Size.Width, base.Size.Height * 2);
        this.list_0 = list_3;
        foreach (ArkEntry gclass in list_3[0].GetArk().GetArkEntries())
        {
            if (!list_3.Contains(gclass))
            {
                this.list_1.Add(gclass);
                this.long_0 += gclass.GetFileSize();
            }
        }
        this.method_0();
    }

    void method_0()
    {
        if (this.cbAll.Checked)
        {
            this.btnOk.Enabled = true;
            this.lblInfo.Text = "All healthy files will be recovered (" + Class109.smethod_3(this.long_0) + ")";
            return;
        }
        if (this.list_2.Count == 0)
        {
            this.btnOk.Enabled = false;
            this.lblInfo.Text = "No files selected for recovery..";
            return;
        }
        this.long_1 = 0L;
        foreach (ArkEntry gclass in this.list_2)
        {
            this.long_1 += gclass.GetFileSize();
        }
        this.lblInfo.Text = string.Concat(new object[]
        {
            "",
            this.list_2.Count,
            " file",
            (this.list_2.Count > 1) ? "s" : "",
            " (",
            Class109.smethod_3(this.long_1),
            ") selected for recovery.."
        });
        this.btnOk.Enabled = true;
    }

    public List<ArkEntry> method_1()
    {
        if (!this.cbAll.Checked)
        {
            return this.list_2;
        }
        return this.list_1;
    }

    public TreeView method_2()
    {
        return this.tvFiles;
    }

    public string method_3()
    {
        return this.string_0;
    }

    void BadArkDialog_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (!this.bool_0)
        {
            return;
        }
        this.folderBrowserDialog_0.SelectedPath = Class61.smethod_0().method_8().method_1("RecoverArchive");
        if (this.folderBrowserDialog_0.ShowDialog() != DialogResult.OK)
        {
            e.Cancel = true;
            this.bool_0 = false;
            return;
        }
        string directoryRoot = Directory.GetDirectoryRoot(this.folderBrowserDialog_0.SelectedPath);
        foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
        {
            if (driveInfo.RootDirectory.Name == directoryRoot)
            {
                if (driveInfo.AvailableFreeSpace < this.long_1)
                {
                    MessageBox.Show("There is not enough free space\nin the target location.\n" + Class109.smethod_3(this.long_1) + " is needed.", "Recover", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    e.Cancel = true;
                    this.bool_0 = false;
                }
                else
                {
                    this.string_0 = this.folderBrowserDialog_0.SelectedPath;
                    Class61.smethod_0().method_8().method_2("RecoverArchive", this.folderBrowserDialog_0.SelectedPath);
                }
                return;
            }
        }

        this.string_0 = this.folderBrowserDialog_0.SelectedPath;
        Class61.smethod_0().method_8().method_2("RecoverArchive", this.folderBrowserDialog_0.SelectedPath);
    }

    void btnOk_Click(object sender, EventArgs e)
    {
        this.bool_0 = true;
    }

    void method_4(string string_1)
    {
        string[] array = string_1.Split(new char[]
        {
            '/'
        });
        TreeNode treeNode = this.tvFiles.Nodes[0];
        for (int i = 0; i < array.Length; i++)
        {
            TreeNode[] array2 = treeNode.Nodes.Find(array[i], false);
            if (array2 == null || array2.Length == 0)
            {
                return;
            }
            treeNode = array2[0];
            treeNode.Expand();
        }
    }

    void method_5(List<TreeNode> list_3, TreeNode treeNode_0)
    {
        foreach (object obj in treeNode_0.Nodes)
        {
            TreeNode treeNode = (TreeNode)obj;
            if (treeNode.ImageIndex == 1)
            {
                this.method_5(list_3, treeNode);
            }
            else if (treeNode.Tag != null && treeNode.Tag is ArkEntry)
            {
                list_3.Add(treeNode);
            }
        }
    }

    void tsmiRecover_Click(object sender, EventArgs e)
    {
        List<TreeNode> list = new List<TreeNode>();
        if (!(this.tvFiles.SelectedNode.Tag is ArkEntry))
        {
            this.method_5(list, this.tvFiles.SelectedNode);
        }
        else
        {
            list.Add(this.tvFiles.SelectedNode);
        }
        foreach (TreeNode treeNode in list)
        {
            ArkEntry item = treeNode.Tag as ArkEntry;
            bool flag;
            if (flag = this.list_2.Contains(item))
            {
                this.list_2.Remove(item);
            }
            else
            {
                this.list_2.Add(item);
            }
            treeNode.ForeColor = ((!flag) ? this.tvFiles.ForeColor : SystemColors.GrayText);
        }
        this.method_0();
    }

    void cmsFiles_Opening(object sender, CancelEventArgs e)
    {
        if (this.tvFiles.SelectedNode == null)
        {
            e.Cancel = true;
            return;
        }
        ArkEntry gclass = this.tvFiles.SelectedNode.Tag as ArkEntry;
        if (gclass == null)
        {
            if (this.tvFiles.SelectedNode.ImageIndex != 1 || this.tvFiles.SelectedNode.ForeColor == Color.Red)
            {
                e.Cancel = true;
            }
            return;
        }
        this.tsmiRecover.Checked = this.list_2.Contains(gclass);
    }

    void tvFiles_MouseClick(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            TreeNode nodeAt = this.tvFiles.GetNodeAt(e.Location);
            if (nodeAt != null && (nodeAt.Tag is ArkEntry || nodeAt.ImageIndex == 1))
            {
                this.tvFiles.SelectedNode = nodeAt;
            }
        }
    }

    void tvFiles_DoubleClick(object sender, EventArgs e)
    {
        if (this.tvFiles.SelectedNode != null && this.tvFiles.SelectedNode.ImageIndex != 1)
        {
            this.tsmiRecover_Click(sender, e);
        }
    }

    void cbAll_CheckedChanged(object sender, EventArgs e)
    {
        if (this.cbAll.Checked)
        {
            this.tvFiles.Enabled = false;
        }
        else
        {
            this.tvFiles.Enabled = true;
        }
        this.method_0();
    }

    List<ArkEntry> list_0;

    List<ArkEntry> list_1 = new List<ArkEntry>();

    long long_0;

    long long_1;

    List<ArkEntry> list_2 = new List<ArkEntry>();

    string string_0 = "";

    bool bool_0;
}
