using System;
using System.Collections;
using System.Windows.Forms;

class Class84 : IComparer
{
	public int Compare(object object_0, object object_1)
	{
		TreeNode treeNode = object_0 as TreeNode;
		TreeNode treeNode2 = object_1 as TreeNode;
		if (treeNode.Parent == null && treeNode2.Parent == null)
		{
			return -1;
		}
		if (treeNode.Tag == null && treeNode2.Tag is GClass128)
		{
			return -1;
		}
		if (treeNode2.Tag == null && treeNode.Tag is GClass128)
		{
			return 1;
		}
		return treeNode.Text.CompareTo(treeNode2.Text);
	}
}
