using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public partial class BatchExportMidiDialog : Form
{
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	public BatchExportMidiDialog()
	{
		this.InitializeComponent();
		this.cbDifficulty.SelectedIndex = 3;
	}

	public string[] method_0()
	{
		return this.string_0;
	}

	public bool method_1()
	{
		return this.cbLefty.Checked;
	}

	public void method_2(bool bool_0)
	{
		this.cbCoop.Enabled = bool_0;
		if (!bool_0)
		{
			this.cbCoop.Checked = false;
		}
	}

	public bool method_3()
	{
		return this.cbCoop.Checked;
	}

	public bool method_4()
	{
		return this.cbAllDifficulties.Checked;
	}

	public GEnum53 method_5()
	{
		return (GEnum53)this.cbDifficulty.SelectedIndex;
	}

	public string method_6(MidiFile gclass120_0, GEnum53 genum53_0)
	{
		int num = 1;
		switch (gclass120_0.method_3())
		{
		case GEnum54.const_1:
			if (this.string_0[0] == null)
			{
				this.string_0[0] = "t1 gems";
				this.string_0[1] = null;
			}
			break;
		case GEnum54.const_2:
			if (this.cbCoop.Checked)
			{
				num = 2;
				if (gclass120_0.FindTrackByName("part guitar coop") != null)
				{
					this.string_0[0] = "part guitar coop";
				}
				else
				{
					this.string_0[0] = "part guitar";
				}
				if (gclass120_0.FindTrackByName("part rhythm") != null)
				{
					this.string_0[1] = "part rhythm";
				}
				else
				{
					this.string_0[1] = "part bass";
				}
			}
			else if (this.string_0[0] == null)
			{
				this.string_0[0] = "part guitar";
				this.string_0[1] = null;
			}
			break;
		default:
			throw new NotImplementedException();
		}
		string text = this.tbFormat.Text;
		if (text.Contains("%1") || (this.cbCoop.Checked && text.Contains("%2")))
		{
			string[] array = new string[]
			{
				"track1",
				"track2"
			};
			for (int i = 0; i < num; i++)
			{
				GClass88 gclass = gclass120_0.FindTrackByName(this.string_0[i]) as GClass88;
				if (gclass == null)
				{
					BatchExportChooseTracksDialog batchExportChooseTracksDialog = new BatchExportChooseTracksDialog(gclass120_0, this.string_0);
					batchExportChooseTracksDialog.method_0(this.cbCoop.Checked);
					while (gclass == null)
					{
						if (batchExportChooseTracksDialog.ShowDialog() != DialogResult.OK)
						{
							throw new NotImplementedException();
						}
						this.string_0 = batchExportChooseTracksDialog.method_1();
						gclass = (gclass120_0.FindTrackByName(this.string_0[i]) as GClass88);
					}
				}
				string text2 = gclass.method_1().ToLower();
				if (string.Compare(text2, "t1 gems", true) == 0)
				{
					text2 = "guitar";
				}
				else
				{
					text2 = text2.Substring(text2.IndexOf(' ') + 1).Replace(" coop", "");
				}
				array[i] = text2;
			}
			text = text.Replace("%1", array[0]);
			if (this.cbCoop.Checked)
			{
				text = text.Replace("%2", array[1]);
			}
		}
		text = text.Replace("%d", Class109.smethod_7(genum53_0).ToLower());
		if (gclass120_0.GetTracks()[0].method_1() != null && gclass120_0.GetTracks()[0].method_1().Length > 0)
		{
			text = text.Replace("%n", gclass120_0.GetTracks()[0].method_1().ToLower());
		}
		else
		{
			BatchExportNewNameDialog batchExportNewNameDialog = new BatchExportNewNameDialog();
			batchExportNewNameDialog.Text = "Enter new name for song";
			if (batchExportNewNameDialog.ShowDialog() != DialogResult.OK)
			{
				return null;
			}
			text = text.Replace("%n", batchExportNewNameDialog.method_0().ToLower());
		}
		return text;
	}

	void cbAllDifficulties_CheckedChanged(object sender, EventArgs e)
	{
		this.cbDifficulty.Enabled = !this.cbAllDifficulties.Checked;
	}

	IContainer icontainer_0;

	string[] string_0 = new string[2];
}
