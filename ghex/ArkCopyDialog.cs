using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public partial class ArkCopyDialog : Form
{
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	public ArkCopyDialog()
	{
		this.InitializeComponent();
		this.cbDrives.Items.Add("Insert Disc");
		this.cbDrives.SelectedIndex = 0;
		this.timer_0.Enabled = true;
		this.timer_0.Start();
	}

	public string method_0()
	{
		return this.string_1;
	}

	public string method_1()
	{
		if (!this.cbDrives.Enabled)
		{
			return string.Empty;
		}
		return this.cbDrives.Text;
	}

	public bool method_2()
	{
		return this.cbAddToList.Checked;
	}

	public string[] method_3()
	{
		return this.string_0;
	}

	void method_4()
	{
		this.timer_0.Stop();
		bool flag = false;
		try
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT Drive FROM Win32_CDROMDrive");
			foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				if (managementObject["Drive"] != null)
				{
					string text = managementObject["Drive"].ToString().Trim();
					if (File.Exists(text + "\\gen\\main.hdr") && File.Exists(text + "\\gen\\main_0.ark"))
					{
						if (!flag)
						{
							this.cbDrives.Items.Clear();
							flag = true;
						}
						this.cbDrives.Items.Add(text);
					}
				}
			}
		}
		catch
		{
		}
		if (flag)
		{
			this.btnBrowser.Enabled = true;
			this.cbDrives.Enabled = true;
			this.cbDrives.SelectedIndex = 0;
			this.cbDrives_SelectedIndexChanged(null, null);
			return;
		}
		this.timer_0.Start();
	}

	void timer_0_Tick(object sender, EventArgs e)
	{
		this.method_4();
	}

	void btnBrowser_Click(object sender, EventArgs e)
	{
		this.folderBrowserDialog_0.SelectedPath = Class61.smethod_0().method_8().method_1("CopyArchive");
		if (this.folderBrowserDialog_0.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		if (Class61.smethod_0().method_3().method_0(this.folderBrowserDialog_0.SelectedPath + "\\main.hdr"))
		{
			MessageBox.Show("The selected folder already contains an archive that\nis currently in the list.\nPlease remove it or choose another location.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			return;
		}
		foreach (string str in this.method_3())
		{
			if (File.Exists(this.folderBrowserDialog_0.SelectedPath + "\\" + str))
			{
				if (MessageBox.Show("The selected folder already contains archive files.\nDo you want to replace them?", "Overwrite?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
				{
					try
					{
						foreach (string str2 in this.method_3())
						{
							File.Delete(this.folderBrowserDialog_0.SelectedPath + "\\" + str2);
						}
					}
					catch
					{
						MessageBox.Show("Failed to remove old files!\nPlease to it manually or select a\ndifferent folder.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					IL_118:
					string directoryRoot = Directory.GetDirectoryRoot(this.folderBrowserDialog_0.SelectedPath);
					DriveInfo[] drives = DriveInfo.GetDrives();
					int k = 0;
					while (k < drives.Length)
					{
						DriveInfo driveInfo = drives[k];
						if (!(driveInfo.RootDirectory.Name == directoryRoot))
						{
							k++;
						}
						else
						{
							if (driveInfo.AvailableFreeSpace < this.long_0)
							{
								MessageBox.Show("There is not enough free space\nin the target location.\n" + Class109.smethod_3(this.long_0) + " is needed.", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								return;
							}
							IL_196:
							Class61.smethod_0().method_8().method_2("CopyArchive", this.folderBrowserDialog_0.SelectedPath);
							this.lblTarget.Text = this.folderBrowserDialog_0.SelectedPath;
							this.string_1 = this.lblTarget.Text;
							if (this.cbDrives.Enabled)
							{
								this.btnOk.Enabled = true;
								return;
							}
							return;
						}
					}
					goto IL_196;
				}
				return;
			}
		}
		goto IL_118;
	}

	public long method_5()
	{
		return this.long_0;
	}

	void cbDrives_SelectedIndexChanged(object sender, EventArgs e)
	{
		this.lblSource.Text = "N/A";
		this.long_0 = 0L;
		if (!this.cbDrives.Enabled)
		{
			this.string_0 = new string[0];
			return;
		}
		if (this.cbAllFiles.Checked)
		{
			this.string_0 = Directory.GetFiles(this.method_1(), "*.*", SearchOption.AllDirectories);
			for (int i = 0; i < this.string_0.Length; i++)
			{
				this.string_0[i] = this.string_0[i].Substring(this.method_1().Length);
				if (this.string_0[i].StartsWith("\\"))
				{
					this.string_0[i] = this.string_0[i].Substring(1);
				}
			}
			string[] array = this.string_0;
			if (ArkCopyDialog.comparison_0 == null)
			{
				ArkCopyDialog.comparison_0 = new Comparison<string>(ArkCopyDialog.smethod_0);
			}
			Array.Sort<string>(array, ArkCopyDialog.comparison_0);
		}
		else
		{
			this.string_0 = new string[]
			{
				"gen\\main_0.ark",
				"gen\\main.hdr"
			};
		}
		try
		{
			foreach (string str in this.method_3())
			{
				FileStream fileStream = File.Open(this.method_1() + str, FileMode.Open, FileAccess.Read, FileShare.Read);
				this.long_0 += fileStream.Length;
				fileStream.Close();
			}
			this.lblSource.Text = Class109.smethod_3(this.long_0);
		}
		catch
		{
		}
	}

	void cbAllFiles_CheckedChanged(object sender, EventArgs e)
	{
		this.cbDrives_SelectedIndexChanged(null, null);
	}

	[CompilerGenerated]
	static int smethod_0(string string_2, string string_3)
	{
		int num = string_2.CompareTo(string_3);
		if (num == 0)
		{
			return 0;
		}
		if (string_2.EndsWith(".ark", StringComparison.CurrentCultureIgnoreCase))
		{
			return -1;
		}
		if (string_3.EndsWith(".ark", StringComparison.CurrentCultureIgnoreCase))
		{
			return 1;
		}
		return num;
	}

	string[] string_0 = new string[0];

	string string_1 = string.Empty;

	long long_0;

	[CompilerGenerated]
	static Comparison<string> comparison_0;
}
