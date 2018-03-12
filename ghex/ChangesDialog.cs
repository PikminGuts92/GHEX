using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public partial class ChangesDialog : Form
{
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	public ChangesDialog()
	{
		this.InitializeComponent();
	}

	void ChangesDialog_Load(object sender, EventArgs e)
	{
		try
		{
			string path = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\") + 1) + "ChangeLog.txt";
			string[] array = File.ReadAllLines(path);
			string[] array2 = Application.ProductVersion.Split(new char[]
			{
				'.'
			});
			int num = int.Parse(array2[0]);
			int num2 = int.Parse(array2[1]);
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].StartsWith("=== "))
				{
					string[] array3 = array[i].Split(new char[]
					{
						' '
					});
					string[] array4 = array3[3].Split(new char[]
					{
						'.'
					});
					int num3 = int.Parse(array4[0]);
					int num4 = int.Parse(array4[1]);
					if (num3 != num || num4 != num2)
					{
						string[] array5 = new string[i];
						for (int j = 0; j < i; j++)
						{
							array5[j] = array[j];
						}
						array = array5;
					}
				}
			}
			this.textBox1.Lines = array;
		}
		catch
		{
			this.textBox1.Text = "Failed to read change log";
		}
		this.textBox1.SelectionStart = 0;
		this.textBox1.SelectionLength = 0;
	}

	IContainer icontainer_0;
}
