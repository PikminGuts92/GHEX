using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class MidPreview : UserControl
{
	public MidPreview(ArkEntry gclass126_1, List<GClass109> list_1)
	{
		this.InitializeComponent();
		this.int_5 = this.panel1.Height;
		this.vscrollBar_0 = new VScrollBar();
		this.vscrollBar_0.Scroll += this.MidPreview_Scroll;
		base.Controls.Add(this.vscrollBar_0);
		this.vscrollBar_0.Dock = DockStyle.Right;
		this.hscrollBar_0 = new HScrollBar();
		this.hscrollBar_0.Scroll += this.MidPreview_Scroll;
		base.Controls.Add(this.hscrollBar_0);
		this.hscrollBar_0.Dock = DockStyle.Bottom;
		this.rectangle_0 = new Rectangle(0, 0, 40, 48);
		this.int_0 = 32;
		this.size_0 = new Size(16, 24);
		this.size_1 = new Size(0, 64);
		this.size_2 = new Size(0, 16);
		this.font_0 = new Font(SystemFonts.MenuFont.FontFamily, 5.7f);
		this.font_1 = new Font("Times New Roman", 18f, FontStyle.Bold);
		this.font_2 = new Font("Times New Roman", 9.1f, FontStyle.Bold);
		this.font_3 = new Font("Arial", 9f);
		this.font_4 = new Font("Times New Roman", 20f, FontStyle.Bold);
		this.int_1 = this.font_4.Height * 2 + this.size_0.Height;
		this.int_2 = this.size_0.Height;
		this.pen_0 = new Pen(Color.FromArgb(230, 230, 230));
		this.printDocument_0.DefaultPageSettings.Margins = new Margins(10, 10, 20, 50);
		this.gclass126_0 = gclass126_1;
		byte[] buffer = gclass126_1.method_8();

        // Loads MIDI file
		this.midiFile = new MidiFile(new MemoryStream(buffer));
		foreach (MidiTrack gclass in this.midiFile.GetTracks())
		{
            // Checks if guitar track
			if (gclass is GClass88 && list_1 != null)
			{
				int[][] array = new int[][]
				{
					new int[4],
					new int[4],
					new int[4],
					new int[4]
				};
				float[] array2 = new float[4];
				GClass88 gclass2 = gclass as GClass88; // 4 difficulty tracks
				for (int i = 0; i < 4; i++)
				{
					array[0][3 - i] = gclass2.method_17((GEnum53)i); // Note count
					array[1][3 - i] = gclass2.method_18((GEnum53)i); // Chord count
					array[2][3 - i] = gclass2.method_19((GEnum53)i); // Sustain count
					array[3][3 - i] = gclass2.method_20((GEnum53)i); // Invalid count

                    // Calculates base score
					array2[3 - i] = (float)((int)gclass2.method_21(this.midiFile, (GEnum53)i));
				}

                // Adds to list of name/value display
				list_1.Add(new GClass109(gclass.method_1() + " Base Score", array2));
				list_1.Add(new GClass109(gclass.method_1() + " Notes", array[0]));
				list_1.Add(new GClass109(gclass.method_1() + " Chords", array[1]));
				list_1.Add(new GClass109(gclass.method_1() + " Sustained", array[2]));
				list_1.Add(new GClass109(gclass.method_1() + " Invalid", array[3]));
			}
		}
		this.bool_0 = true;
		this.int_3 = 0;
		this.int_4 = MidPreview.smethod_0(this.midiFile, this.cbTracks, "");
		this.genum53_0 = GEnum53.const_3;
		this.cbTracks.SelectedIndex = 0;
		if (this.cbTracks.Items.Count == 1)
		{
			this.cbTracks.Enabled = false;
		}
		this.cbTracks2.Enabled = false;
		this.cbTrack2.Enabled = (this.cbTracks.Items.Count > 1);
		int j = 3;
		while (j >= 0)
		{
			if ((this.midiFile.GetTracks()[this.int_3] as GClass88).method_13((GEnum53)j).Count <= 0)
			{
				j--;
			}
			else
			{
				this.cbDifficulty.SelectedIndex = j;
                break;
			}
		}

        GClass87 gclass3 = this.midiFile.FindTrackByName("EVENTS") as GClass87;
        if (gclass3 != null)
        {
            this.cbSection.Items.Clear();
            foreach (MidiEvent gclass4 in gclass3.Events())
            {
                GClass140 gclass5 = gclass4 as GClass140;
                if (gclass5 != null && gclass5.string_0.StartsWith("section "))
                {
                    MidPreview.GClass63 gclass6 = new MidPreview.GClass63();
                    gclass6.gclass140_0 = gclass5;
                    gclass6.string_0 = gclass5.string_0.Substring(8);
                    this.cbSection.Items.Add(gclass6);
                }
            }
            if (this.cbSection.Items.Count > 0)
            {
                this.cbSection.SelectedIndex = 0;
                this.cbSection.Enabled = true;
            }
        }
        this.bool_0 = false;
        this.method_18();
        this.method_16();
        if (this.cbTracks.Items.Count == 0)
        {
            throw new FileLoadException("Not a valid Guitar Hero MIDI file");
        }
    }

	public static int smethod_0(MidiFile gclass120_1, ComboBox comboBox_0, string string_0)
	{
		comboBox_0.Items.Clear();
		for (int i = 0; i < gclass120_1.GetTracks().Count; i++)
		{
			if (gclass120_1.GetTracks()[i] is GClass88 && gclass120_1.GetTracks()[i].method_1() != string_0)
			{
				comboBox_0.Items.Add(gclass120_1.GetTracks()[i].method_1());
			}
		}
		if (comboBox_0.Items.Count > 0)
		{
			if (comboBox_0.SelectedIndex != 0)
			{
				comboBox_0.SelectedIndex = 0;
			}
			string string_ = comboBox_0.SelectedItem.ToString();
			return gclass120_1.GetTracks().IndexOf(gclass120_1.FindTrackByName(string_));
		}
		return 0;
	}

	public MidPreview.GEnum9 method_0()
	{
		return this.genum9_0;
	}

	public void method_1(MidPreview.GEnum9 genum9_1)
	{
		this.genum9_0 = genum9_1;
		this.method_18();
		this.method_16();
		base.Invalidate();
	}

	public GEnum53 method_2()
	{
		return this.genum53_0;
	}

	public void method_3(GEnum53 genum53_1)
	{
		this.cbDifficulty.SelectedIndex = (int)genum53_1;
	}

	public int method_4()
	{
		return this.int_3;
	}

	public bool method_5()
	{
		return this.cbTrack2.Checked;
	}

	public void method_6(bool bool_4)
	{
		this.cbTrack2.Checked = bool_4;
	}

	public bool method_7()
	{
		return this.cbLefty.Checked;
	}

	public void method_8(bool bool_4)
	{
		this.cbLefty.Checked = bool_4;
	}

	public MidiFile method_9()
	{
		return this.midiFile;
	}

	public bool method_10()
	{
		return this.panel1.Height == this.int_5;
	}

	public void method_11(bool bool_4)
	{
		this.panel1.Height = (bool_4 ? this.int_5 : (this.int_5 / 2));
		base.Invalidate();
	}

	int method_12(ComboBox comboBox_0, string string_0)
	{
		return 0;
	}

	public void method_13(string string_0, string string_1)
	{
		MidiTrack gclass = this.midiFile.FindTrackByName(string_0);
		if (gclass != null)
		{
			this.cbTracks.SelectedIndex = this.cbTracks.Items.IndexOf(gclass.method_1());
		}
		MidiTrack gclass2 = this.midiFile.FindTrackByName(string_1);
		if (gclass2 != null)
		{
			this.cbTracks2.SelectedIndex = this.cbTracks2.Items.IndexOf(gclass2.method_1());
		}
	}

	Size method_14(int int_12)
	{
		int num = 0;
		int num2 = this.size_0.Width;
		int num3 = this.size_0.Height;
		int num4 = 0;
		int num5 = 0;
		foreach (Class20 @class in this.list_0)
		{
			int num6 = @class.int_0 + (int)((float)(@class.rectangle_0.Width - @class.int_0) * @class.float_0[(int)this.genum53_0]);
			if (num2 + num6 > int_12 && num5 > 0)
			{
				num = Math.Max(num, num2 - this.size_1.Width);
				num2 = this.size_0.Width;
				num3 += @class.rectangle_0.Height + this.size_1.Height;
			}
			num2 += num6 + this.size_1.Width;
			num4 = @class.rectangle_0.Height + this.size_1.Height;
			num5++;
		}
		num3 += num4;
		num3 += this.size_0.Height;
		return new Size(num, num3);
	}

	void method_15()
	{
		if (this.list_0.Count == 0)
		{
			return;
		}
		int num = 0;
		int i = 0;
		int num2 = this.size_0.Width;
		foreach (Class20 @class in this.list_0)
		{
			int num3 = @class.int_0 + (int)((float)(@class.rectangle_0.Width - @class.int_0) * @class.float_0[(int)this.genum53_0]);
			if (num2 + num3 > this.int_7 && num > 0)
			{
				int num4 = (this.int_6 - num2) / (num - i);
				for (int j = i; j < num; j++)
				{
					this.list_0[j].int_3 = num4;
				}
				num2 = this.size_0.Width;
				i = num;
			}
			num2 += num3 + this.size_1.Width;
			num++;
		}
		int num5 = (this.int_6 - num2) / (this.list_0.Count - i);
		if (num2 < this.int_6 / 4)
		{
			num5 = (this.int_6 / 4 - num2) / (this.list_0.Count - i);
		}
		else if (num2 < this.int_6 / 2)
		{
			num5 = (this.int_6 / 2 - num2) / (this.list_0.Count - i);
		}
		while (i < this.list_0.Count)
		{
			this.list_0[i].int_3 = num5;
			i++;
		}
	}

	void method_16()
	{
		Rectangle rectangle = this.method_20();
		int num = base.ClientRectangle.Width;
		int num2 = base.ClientRectangle.Height - this.panel1.Height - this.size_1.Height;
		Size size = this.method_14(rectangle.Width);
		this.int_6 = rectangle.Width - this.size_0.Width;
		this.int_7 = rectangle.Width;
		this.method_15();
		float num3 = (float)this.vscrollBar_0.Value / (float)this.vscrollBar_0.Maximum;
		if (size.Width > rectangle.Width)
		{
			this.hscrollBar_0.Enabled = true;
			this.hscrollBar_0.Visible = true;
			num2 -= this.hscrollBar_0.Height;
		}
		else
		{
			this.hscrollBar_0.Enabled = false;
			this.hscrollBar_0.Visible = false;
		}
		if (size.Height > num2)
		{
			this.vscrollBar_0.Enabled = true;
			this.vscrollBar_0.Visible = true;
			num -= this.vscrollBar_0.Width;
		}
		else
		{
			this.vscrollBar_0.Enabled = false;
			this.vscrollBar_0.Visible = false;
		}
		if (this.vscrollBar_0.Visible)
		{
			this.vscrollBar_0.Maximum = size.Height - num2 / 2;
			this.vscrollBar_0.Minimum = 0;
			this.vscrollBar_0.SmallChange = this.rectangle_0.Height / 3;
			this.vscrollBar_0.LargeChange = rectangle.Height / 3;
			this.vscrollBar_0.Value = (int)((float)this.vscrollBar_0.Maximum * num3);
			this.vscrollBar_0.Dock = DockStyle.None;
			this.vscrollBar_0.Bounds = new Rectangle(num - 2, this.panel1.Height + 2, this.vscrollBar_0.Width, num2 + this.size_1.Height - 4);
		}
		if (this.hscrollBar_0.Visible)
		{
			this.hscrollBar_0.Maximum = size.Width - num + this.size_0.Width * 2;
			this.hscrollBar_0.Minimum = 0;
			this.hscrollBar_0.SmallChange = this.rectangle_0.Width / 4;
			this.hscrollBar_0.LargeChange = this.rectangle_0.Width;
			this.hscrollBar_0.Dock = DockStyle.None;
			this.hscrollBar_0.Bounds = new Rectangle(2, base.ClientRectangle.Bottom - 2 - this.hscrollBar_0.Height, num - 4, this.hscrollBar_0.Height);
		}
	}

	void method_17(bool bool_4)
	{
		int num = 0;
		int num2 = 1;
		int num3 = (this.midiFile.method_3() == GEnum54.const_1) ? 9 : 10;
		float[] array = null;
		if (this.cbTrack2.Enabled)
		{
			array = new float[]
			{
				(this.midiFile.GetTracks()[this.int_3] as GClass88).method_21(this.midiFile, this.genum53_0),
				(this.midiFile.GetTracks()[this.int_4] as GClass88).method_21(this.midiFile, this.genum53_0)
			};
			float num4 = array[0] + array[1];
			array[0] = 0.5f / (array[0] / num4);
			array[1] = 0.5f / (array[1] / num4);
		}
		foreach (Class20 @class in this.list_0)
		{
			for (int i = 0; i < 4; i++)
			{
				int num5 = 0;
				int num6 = @class.gclass141_0.int_1 * this.midiFile.TicksPerQuarterNote();
				int num7 = @class.int_1 + num6;
				for (int j = 0; j < @class.list_1.Length; j++)
				{
					foreach (MidiEvent gclass in @class.list_1[j][i])
					{
						if (gclass.vmethod_2() == GEnum63.const_4)
						{
							GClass145 gclass2 = gclass as GClass145;
							if (gclass2.bool_0)
							{
								int val = gclass.int_0 + gclass.vmethod_0();
								int num8 = 50 * gclass2.list_0.Count;
								if (this.cbTrack2.Checked)
								{
									num8 = (int)((float)(gclass2.list_0.Count * 50) * array[j]);
								}
								if (gclass.int_0 >= @class.int_1 && gclass.int_0 < num7)
								{
									if (bool_4)
									{
										num++;
										if (num2 < 4 && num > num3)
										{
											num = 0;
											num2++;
										}
									}
									num5 += num8 * num2;
								}
								if (gclass2.method_0())
								{
									int num9 = Math.Max(@class.int_1, gclass2.int_0);
									int num10 = Math.Min(num7, val);
									int num11 = num2;
									if (num2 < 4 && num == num3)
									{
										num11++;
									}
									num5 += (int)((float)(num8 * (num10 - num9)) / (float)(2 * this.midiFile.TicksPerQuarterNote()));
								}
							}
						}
					}
				}
				@class.int_4[i] = num5;
			}
		}
	}

	void method_18()
	{
		this.list_0.Clear();
		GClass88 gclass = this.midiFile.GetTracks()[this.int_3] as GClass88;
		GClass88 gclass2 = this.cbTrack2.Enabled ? (this.midiFile.GetTracks()[this.int_4] as GClass88) : null;
		GClass89 gclass3 = this.midiFile.GetTracks()[0] as GClass89;
		GClass87 gclass4 = this.midiFile.FindTrackByName("EVENTS") as GClass87;
		if (gclass3 == null || gclass == null || gclass4 == null)
		{
			return;
		}
		MidiEvent gclass5 = null;
		foreach (MidiEvent gclass6 in gclass4.Events())
		{
			if (gclass6.vmethod_2() == GEnum63.const_0 && ((GClass140)gclass6).string_0.Equals("end"))
			{
				gclass5 = gclass6;
				break;
			}
		}
		if (gclass5 == null)
		{
			return;
		}
		int num = gclass5.int_0 + gclass5.vmethod_0();
		GClass141 gclass7 = null;
		GClass141 gclass8 = null;
		int i = 0;
		int j = 0;
		int num2 = 0;
		float[] array = new float[4];
		while (j < num)
		{
			if (gclass8 == null)
			{
				while (i < gclass3.Events().Count)
				{
					GClass141 gclass9 = gclass3.Events()[i] as GClass141;
					if (gclass9 != null && gclass9.int_0 >= j)
					{
						gclass8 = gclass9;
						break;
					}
					i++;
				}
			}
			bool flag = false;
			if (gclass8 != null && j == gclass8.int_0)
			{
				if (gclass7 == null || gclass8.int_1 != gclass7.int_1)
				{
					flag = true;
				}
				gclass7 = gclass8;
				gclass8 = null;
			}
			if (gclass7 == null)
			{
				flag = true;
				gclass7 = new GClass141(4, GEnum52.const_2, 24, 8);
			}
			int num3 = gclass7.int_1 * this.midiFile.TicksPerQuarterNote();
			num2 += num3;
			j += num3;
			int num4 = gclass7.int_1 * this.midiFile.TicksPerQuarterNote();
			if (num2 >= num4)
			{
				Class20 @class = new Class20();
				@class.bool_0 = flag;
				@class.gclass141_0 = gclass7;
				@class.int_1 = j - num3;
				@class.rectangle_0 = new Rectangle(0, 0, this.rectangle_0.Width * gclass7.int_1, this.rectangle_0.Height);
				if (flag)
				{
					Class20 class2 = @class;
					class2.rectangle_0.Width = class2.rectangle_0.Width + this.int_0;
					@class.int_0 = this.int_0;
				}
				if (this.cbTrack2.Enabled && this.cbTrack2.Checked)
				{
					Class20 class3 = @class;
					class3.rectangle_0.Height = class3.rectangle_0.Height + (this.size_2.Height + this.rectangle_0.Height);
					@class.list_1 = new List<MidiEvent>[][]
					{
						new List<MidiEvent>[4],
						new List<MidiEvent>[4]
					};
				}
				else
				{
					@class.list_1 = new List<MidiEvent>[][]
					{
						new List<MidiEvent>[4]
					};
				}
				for (int k = 0; k < 4; k++)
				{
					@class.list_1[0][k] = gclass.method_15((GEnum53)k, @class.int_1, num4);
					if (gclass2 != null && this.cbTrack2.Checked)
					{
						@class.list_1[1][k] = gclass2.method_15((GEnum53)k, @class.int_1, num4);
					}
					int num5 = int.MaxValue;
					for (int l = 0; l < @class.list_1.Length; l++)
					{
						int num6 = -1;
						if (@class.list_1[l][k] != null)
						{
							foreach (MidiEvent gclass10 in @class.list_1[l][k])
							{
								if (gclass10.vmethod_2() == GEnum63.const_4)
								{
									if (num6 != -1)
									{
										num5 = Math.Abs(Math.Min(num5, gclass10.int_0 - num6));
									}
									num6 = gclass10.int_0;
								}
							}
						}
					}
					if (num5 != 2147483647 && num5 != 0)
					{
						@class.int_2 = this.midiFile.TicksPerQuarterNote() / num5;
					}
					else
					{
						@class.int_2 = 0;
					}
					if (@class.int_2 < 3)
					{
						@class.float_0[k] = 0.5f;
					}
					else if (@class.int_2 < 6)
					{
						@class.float_0[k] = 1f;
					}
					else if (@class.int_2 < 12)
					{
						@class.float_0[k] = 1.5f;
					}
					else
					{
						@class.float_0[k] = 2f;
					}
					array[k] = Math.Max(@class.float_0[k], array[k]);
				}
				@class.list_0 = gclass3.method_6(@class.int_1, num4);
				this.list_0.Add(@class);
				num2 -= num4;
			}
		}

		this.method_17(false);
		if (this.genum9_0 == MidPreview.GEnum9.const_2)
		{
			foreach (Class20 class4 in this.list_0)
			{
				Array.Copy(array, class4.float_0, 4);
			}
		}
		this.bool_2 = true;
	}

	void method_19(GEnum53 genum53_1, Graphics graphics_0, Rectangle rectangle_1, Rectangle rectangle_2)
	{
		int num = (!this.cbTrack2.Checked || !this.cbTrack2.Enabled) ? 1 : 2;
		MidiTrack gclass = this.midiFile.GetTracks()[0];
		GClass88[] array = new GClass88[]
		{
			this.midiFile.GetTracks()[this.int_3] as GClass88,
			(num == 2) ? (this.midiFile.GetTracks()[this.int_4] as GClass88) : null
		};
		GClass87 gclass2 = this.midiFile.FindTrackByName("EVENTS") as GClass87;
		int width = rectangle_1.Width;
		int height = rectangle_1.Height;
		new SolidBrush(this.BackColor);
		Brush black = Brushes.Black;
		Brush darkGray = Brushes.DarkGray;
		Pen darkGray2 = Pens.DarkGray;
		Pen black2 = Pens.Black;
		int num2 = this.int_8;
		int num3 = -1;
		int height2 = this.font_0.Height;
		int height3 = this.font_1.Height;
		int height4 = this.font_2.Height;
		bool @checked = !this.cbLefty.Checked;
		int num4 = 0;
		int num5 = (int)this.nudTempoThreshold.Value;
		int num6 = 0;
		int num7 = 0;
		int num8 = rectangle_1.X + this.size_0.Width;
		int num9 = rectangle_1.Y + this.size_0.Height + ((!this.bool_3) ? this.size_1.Height : 0);
		GClass145[] array2 = new GClass145[2];
		GClass145[] array3 = array2;
		foreach (Class20 @class in this.list_0)
		{
			num4 += @class.int_4[(int)this.genum53_0];
			GEnum54 genum54_ = this.method_9().method_3();
			int num10 = @class.int_0 + @class.int_3 + (int)((float)(@class.rectangle_0.Width - @class.int_0) * @class.float_0[(int)this.genum53_0]);
			if (num8 + num10 > width && num7 > 0)
			{
				num8 = this.size_0.Width;
				num9 += @class.rectangle_0.Height + this.size_1.Height;
			}
			int num11 = @class.gclass141_0.int_1 * this.midiFile.TicksPerQuarterNote();
			int num12 = @class.int_1 + num11;
			Rectangle rect = new Rectangle(num8, num9, num10, @class.rectangle_0.Height);
			if (!this.bool_3)
			{
				rect.X -= this.hscrollBar_0.Value;
				rect.Y -= this.vscrollBar_0.Value;
			}
			else
			{
				if (num7 < num2)
				{
					num7++;
					continue;
				}
				if (num3 == -1)
				{
					num3 = num9 - rectangle_1.Y;
				}
				rect.Y -= num3;
				if (!rectangle_1.Contains(rect))
				{
					return;
				}
				this.int_8++;
			}
			int num13 = rect.Left + @class.int_0;
			int right = rect.Right;
			@class.rectangle_1 = new Rectangle(num13, rect.Y, rect.Width - @class.int_0, rect.Height);
			@class.rectangle_2 = @class.rectangle_1;
			for (int i = 0; i < num; i++)
			{
				Rectangle rectangle = new Rectangle(rect.X, rect.Y + (this.rectangle_0.Height + this.size_2.Height) * i, num10, this.rectangle_0.Height);
				if (rectangle.IntersectsWith(rectangle_2))
				{
					for (int j = 0; j < @class.gclass141_0.int_1 * 2; j++)
					{
						int num14 = rectangle.Left + @class.int_0 + num11 * j / (@class.gclass141_0.int_1 * 2) * (num10 - @class.int_0) / num11;
						if (j % 2 == 0)
						{
							graphics_0.DrawLine(darkGray2, num14, rectangle.Top, num14, rectangle.Bottom);
						}
						else
						{
							graphics_0.DrawLine(this.pen_0, num14, rectangle.Top + 1, num14, rectangle.Bottom - 1);
						}
					}
					for (int k = 0; k <= rectangle.Height; k += rectangle.Height / 4)
					{
						graphics_0.DrawLine(darkGray2, rectangle.Left, rectangle.Top + k, rectangle.Right, rectangle.Top + k);
					}
					if (@class.bool_0)
					{
						graphics_0.DrawString(@class.gclass141_0.int_1.ToString(), this.font_1, black, (float)(rectangle.X + this.int_0 / 4), (float)(rectangle.Y + rectangle.Height / 2 - height3 * 2 / 3));
						graphics_0.DrawString((1 << (int)@class.gclass141_0.genum52_0).ToString(), this.font_1, black, (float)(rectangle.X + this.int_0 / 4), (float)(rectangle.Y + rectangle.Height / 2 - height3 / 5));
					}
					graphics_0.DrawLine(black2, rectangle.Left, rectangle.Top, rectangle.Left, rectangle.Bottom);
					graphics_0.DrawLine(black2, rectangle.Right, rectangle.Top, rectangle.Right, rectangle.Bottom);
					List<MidiEvent>[] array4 = @class.list_1[i];
					List<MidiEvent> list = (array4[(int)this.genum53_0] != null) ? array4[(int)this.genum53_0] : new List<MidiEvent>();
					List<MidiEvent> list2 = MidiTrack.smethod_0(list, @class.int_1, num11, GEnum63.const_5);
					foreach (MidiEvent gclass3 in list)
					{
						int num15 = gclass3.int_0 + gclass3.vmethod_0();
						if ((gclass3.int_0 >= @class.int_1 && gclass3.int_0 < num12) || (num15 >= @class.int_1 && num15 <= num12) || (gclass3.int_0 < @class.int_1 && num15 >= num12))
						{
							if (gclass3 is GClass146)
							{
								GClass146 gclass4 = gclass3 as GClass146;
								int num16 = num13 + Math.Max(0, (gclass4.int_0 - @class.int_1) * (num10 - @class.int_0) / num11);
								int num17 = Math.Min(right - num16, (num15 - Math.Max(gclass4.int_0, @class.int_1)) * (num10 - @class.int_0) / num11);
								int num18 = rectangle.Top - height2 - 3;
								if (i > 0)
								{
									num18 += this.size_2.Height / 2 - 3;
								}
								graphics_0.FillRectangle(darkGray, num16, num18, num17, 2);
								if (gclass4.int_0 >= @class.int_1)
								{
									graphics_0.DrawLine(darkGray2, num16, num18 - 1, num16, num18 + 2);
								}
								if (num15 <= num12)
								{
									graphics_0.DrawLine(darkGray2, num16 + num17 - 1, num18 - 1, num16 + num17 - 1, num18 + 2);
								}
								@class.rectangle_2 = Rectangle.Union(new Rectangle(num16, num18 - 1, num17, 4), @class.rectangle_2);
							}
							else if (gclass3 is GClass145)
							{
								GClass145 gclass5 = gclass3 as GClass145;
								if (gclass5.bool_0 || (this.cbShowInvalid.Checked && !this.bool_3))
								{
									if (gclass5.int_0 == 0)
									{
										for (int l = 0; l < 5; l++)
										{
											int num19 = l;
											if (@checked)
											{
												num19 = 4 - num19;
											}
											int num20 = num13;
											int num21 = rectangle.Top + num19 * this.rectangle_0.Height / 4;
											Class109.smethod_19(graphics_0, (GEnum51)l, (float)num20, (float)num21, 6f, Class109.Enum12.flag_2);
										}
									}
									int num22 = num13 + (gclass5.int_0 - @class.int_1) * (num10 - @class.int_0) / num11;
									bool flag = false;
									if (list2 != null)
									{
										foreach (MidiEvent gclass6 in list2)
										{
											GClass146 gclass7 = (GClass146)gclass6;
											if (gclass5.int_0 >= gclass7.int_0 && gclass5.int_0 < gclass7.int_0 + gclass7.vmethod_0())
											{
												flag = true;
												break;
											}
										}
									}
									int num23 = 0;
									int num24 = 0;
									if (gclass5.method_0())
									{
										num23 = num13 + Math.Max(0, (gclass5.int_0 - @class.int_1) * (num10 - @class.int_0) / num11);
										num24 = Math.Min(right - num23 + 1, (int)Math.Round((double)(((float)num15 - (float)Math.Max(gclass5.int_0, @class.int_1)) * (float)(num10 - @class.int_0) / (float)num11)));
									}
									bool flag2 = array[i].method_16(array3[i], gclass5, genum54_);
									if (gclass5.bool_0)
									{
										array3[i] = gclass5;
									}
									bool flag3 = gclass3.int_0 >= @class.int_1 && gclass3.int_0 < num12;
									bool flag4 = this.genum9_0 == MidPreview.GEnum9.const_2 && num15 < this.int_9;
									bool flag5 = this.genum9_0 == MidPreview.GEnum9.const_2 && this.int_9 >= gclass5.int_0 && this.int_9 < num15;
									float float_ = (float)((!flag3 || !flag5 || !gclass5.bool_0) ? 6 : 8);
									foreach (GEnum51 genum in gclass5.list_0)
									{
										int num25 = (int)genum;
										if (@checked)
										{
											num25 = 4 - num25;
										}
										int num26 = rectangle.Top + num25 * this.rectangle_0.Height / 4;
										if (gclass5.method_0())
										{
											int num27 = flag5 ? 4 : 3;
											int num28 = num23;
											int num29 = num24;
											Class109.smethod_20(graphics_0, genum, (float)num28, (float)num26, (float)num29, (float)num27, (flag4 || !gclass5.bool_0) ? Class109.Enum12.flag_2 : ((Class109.Enum12)0));
										}
										if (flag3)
										{
											Class109.Enum12 @enum = (flag4 || !gclass5.bool_0) ? Class109.Enum12.flag_2 : ((Class109.Enum12)0);
											@enum |= (flag ? Class109.Enum12.flag_0 : ((Class109.Enum12)0));
											@enum |= (flag2 ? Class109.Enum12.flag_1 : ((Class109.Enum12)0));
											RectangleF value = Class109.smethod_19(graphics_0, genum, (float)num22, (float)num26, float_, @enum);
											@class.rectangle_2 = Rectangle.Union(Rectangle.Round(value), @class.rectangle_2);
										}
									}
								}
							}
						}
					}
				}
			}
			string text = @class.int_4[(int)this.genum53_0].ToString();
			SizeF sizeF = graphics_0.MeasureString(text, this.font_0);
			Rectangle a = new Rectangle(rect.Right - (int)sizeF.Width - 1, rect.Bottom + 1, (int)sizeF.Width, (int)sizeF.Height);
			if (a.IntersectsWith(rectangle_2))
			{
				graphics_0.DrawString(text, this.font_0, Brushes.Gray, (float)a.X, (float)a.Y);
				@class.rectangle_2 = Rectangle.Union(a, @class.rectangle_2);
			}
			Rectangle a2 = new Rectangle(rect.Left + @class.int_0 + 1, rect.Top - height2 - 1, (int)sizeF.Width, (int)sizeF.Height);
			bool flag6;
			if (flag6 = a2.IntersectsWith(rectangle_2))
			{
				graphics_0.DrawString((1 + num7).ToString(), this.font_0, Brushes.Red, (float)a2.X, (float)a2.Y);
				@class.rectangle_2 = Rectangle.Union(a2, @class.rectangle_2);
			}
			if (gclass2 != null)
			{
				foreach (object obj in this.cbSection.Items)
				{
					MidPreview.GClass63 gclass8 = obj as MidPreview.GClass63;
					if (gclass8.gclass140_0.int_0 >= @class.int_1 && gclass8.gclass140_0.int_0 < num12 && gclass8.gclass140_0.vmethod_2() == GEnum63.const_0)
					{
						GClass140 gclass140_ = gclass8.gclass140_0;
						int x = num13 + (gclass140_.int_0 - @class.int_1) / num11;
						Rectangle a3 = new Rectangle(x, rect.Top - height2 * 3 + 2, rect.Width, height2);
						if (a3.IntersectsWith(rectangle_2))
						{
							graphics_0.DrawString(gclass8.string_0, this.font_0, black, a3.Location);
							@class.rectangle_2 = Rectangle.Union(a3, @class.rectangle_2);
						}
					}
				}
			}
			List<MidiEvent> list3 = @class.list_0;
			foreach (MidiEvent gclass9 in list3)
			{
				if (gclass9.vmethod_2() == GEnum63.const_2)
				{
					GClass142 gclass10 = gclass9 as GClass142;
					int num30 = 60000000 / gclass10.int_1;
					if (gclass10.int_0 < num12 && Math.Abs(num30 - num6) >= num5)
					{
						if (flag6)
						{
							int num31 = num13 + (gclass10.int_0 - @class.int_1) * (num10 - @class.int_0) / num11;
							int num32 = rect.Top - height2 - 4 - 15 - height4;
							float num33 = 3.6f;
							float num34 = (float)(num32 + 7);
							float num35 = (float)num31 + num33 + 1f;
							SmoothingMode smoothingMode = graphics_0.SmoothingMode;
							graphics_0.SmoothingMode = SmoothingMode.AntiAlias;
							graphics_0.FillEllipse(black, (float)num31 + 0.2f, num34, num33, num33);
							graphics_0.FillEllipse(black, (float)num31 + 0.2f + 0.75f, num34 - 0.4f, num33, num33);
							graphics_0.FillEllipse(black, (float)num31 + 0.2f + 1.5f, num34 - 0.8f, num33, num33);
							graphics_0.SmoothingMode = smoothingMode;
							graphics_0.DrawLine(new Pen(Color.Black, 0.1f), num35, num34 - num33 - 7f, num35, num34 + 0.4f);
							TextRenderingHint textRenderingHint = graphics_0.TextRenderingHint;
							graphics_0.TextRenderingHint = TextRenderingHint.AntiAlias;
							graphics_0.DrawString("   = " + num30.ToString(), this.font_2, black, (float)num31, (float)num32);
							graphics_0.TextRenderingHint = textRenderingHint;
							@class.rectangle_2 = Rectangle.Union(new Rectangle(num31, num32, rect.Width - num31, 10), @class.rectangle_2);
						}
						num6 = num30;
					}
				}
			}
			num8 += num10 + this.size_1.Width;
			num7++;
		}
		foreach (Class20 class2 in this.list_0)
		{
			int num36 = class2.gclass141_0.int_1 * this.midiFile.TicksPerQuarterNote();
			int num37 = num36 / class2.rectangle_1.Width;
			int num38 = class2.int_1 + num36;
			if (this.class19_0 != null)
			{
				int num39 = Math.Min(this.class19_0.int_1, num38) - Math.Max(this.class19_0.int_0, class2.int_1);
				if (num39 > 0)
				{
					SolidBrush brush = new SolidBrush(Color.FromArgb(128, 128, 128, 255));
					int num40 = class2.rectangle_1.X + Math.Max(0, (this.class19_0.int_0 - class2.int_1) / num37);
					int num41 = Math.Min(class2.rectangle_1.Right, num40 + num39 / num37);
					int width2 = num41 - num40 + 1;
					graphics_0.FillRectangle(brush, num40, class2.rectangle_1.Y, width2, class2.rectangle_1.Height + 1);
				}
			}
			if (!this.bool_3 && this.int_9 >= class2.int_1 && this.int_9 < num38)
			{
				int num42 = class2.rectangle_1.X + (this.int_9 - class2.int_1) * class2.rectangle_1.Width / num36;
				graphics_0.DrawLine(Pens.Blue, num42, class2.rectangle_1.Y - 4, num42, class2.rectangle_1.Bottom + 4);
				class2.rectangle_2 = Rectangle.Union(new Rectangle(num42, class2.rectangle_1.Y - 4, 1, class2.rectangle_1.Height + 8), class2.rectangle_2);
			}
		}
	}

	Rectangle method_20()
	{
		return new Rectangle(base.ClientRectangle.X, base.ClientRectangle.Y + this.panel1.Height, base.ClientRectangle.Width - this.vscrollBar_0.Width * (this.vscrollBar_0.Visible ? 1 : 0), base.ClientRectangle.Height - this.hscrollBar_0.Height * (this.hscrollBar_0.Visible ? 1 : 0) - this.panel1.Height);
	}

	public bool method_21()
	{
		return this.bool_1;
	}

	void MidPreview_Paint(object sender, PaintEventArgs e)
	{
		this.bool_1 = true;
		Rectangle rectangle_ = this.method_20();
		this.method_19(this.genum53_0, e.Graphics, rectangle_, e.ClipRectangle);
		if (this.bool_2)
		{
			this.bool_2 = false;
			e.Graphics.FillRectangle(new SolidBrush(this.BackColor), e.ClipRectangle);
			this.method_19(this.genum53_0, e.Graphics, rectangle_, e.ClipRectangle);
		}
		ControlPaint.DrawBorder3D(e.Graphics, new Rectangle(rectangle_.X, rectangle_.Y, base.ClientRectangle.Width, base.ClientRectangle.Height - this.panel1.Height), Border3DStyle.Sunken);
		if (this.hscrollBar_0.Visible && this.vscrollBar_0.Visible)
		{
			e.Graphics.FillRectangle(SystemBrushes.Control, base.ClientRectangle.Right - this.vscrollBar_0.Width - 2, base.ClientRectangle.Bottom - this.hscrollBar_0.Height - 2, this.vscrollBar_0.Width, this.hscrollBar_0.Height);
		}
		this.bool_1 = false;
	}

	void MidPreview_Resize(object sender, EventArgs e)
	{
		try
		{
			this.method_16();
		}
		catch
		{
		}
		base.Invalidate(base.ClientRectangle);
	}

	void MidPreview_Scroll(object sender, ScrollEventArgs e)
	{
		if (this.genum9_0 != MidPreview.GEnum9.const_2 || this.int_9 == -1)
		{
			base.Invalidate();
		}
	}

	void cbDifficulty_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.cbDifficulty.SelectedIndex == -1)
		{
			return;
		}
        
		this.genum53_0 = (GEnum53)this.cbDifficulty.SelectedIndex;
		GClass88 gclass = this.midiFile.GetTracks()[this.int_3] as GClass88;
		GClass88 gclass2 = (!this.cbTrack2.Enabled || !this.cbTrack2.Checked) ? null : (this.midiFile.GetTracks()[this.int_4] as GClass88);
		this.cbShowInvalid.Enabled = (gclass.method_20(this.genum53_0) > 0 || (gclass2 != null && gclass2.method_20(this.genum53_0) > 0));
		if (!this.cbShowInvalid.Enabled)
		{
			this.cbShowInvalid.Checked = false;
		}
		base.Invalidate();
	}

	void cbTracks_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.cbTracks.SelectedIndex == -1)
		{
			return;
		}
		string string_ = this.cbTracks.SelectedItem.ToString();
		this.int_3 = this.midiFile.GetTracks().IndexOf(this.midiFile.FindTrackByName(string_));
		if (this.cbTrack2.Enabled)
		{
			this.int_4 = MidPreview.smethod_0(this.midiFile, this.cbTracks2, string_);
		}
		if (!this.bool_0)
		{
			this.method_18();
			base.Invalidate();
		}
	}

	void cbTracks2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.cbTracks2.SelectedIndex == -1)
		{
			return;
		}
		this.int_4 = this.midiFile.GetTracks().IndexOf(this.midiFile.FindTrackByName(this.cbTracks2.SelectedItem.ToString()));
		if (!this.bool_0)
		{
			this.method_18();
			base.Invalidate();
		}
	}

	void method_22(Graphics graphics_0, string string_0, Rectangle rectangle_1)
	{
		graphics_0.DrawString(string_0, this.font_4, Brushes.Black, (float)(rectangle_1.X + this.size_0.Width), (float)rectangle_1.Y);
	}

	void method_23(Graphics graphics_0, Rectangle rectangle_1)
	{
		int num = this.font_3.Height + this.size_0.Height / 2 + 4;
		if (this.bool_3)
		{
			num -= this.size_0.Height / 2;
		}
		graphics_0.DrawString("Work in progress - This information has not been verified and may be faulty", this.font_3, Brushes.Red, (float)(rectangle_1.X + this.size_0.Width), (float)(rectangle_1.Bottom - num));
		string text = "generated using guitar hero explorer " + Application.ProductVersion.Substring(0, Application.ProductVersion.LastIndexOf('.')) + "\nhttp://onreally.com/ghex/";
		SizeF sizeF = graphics_0.MeasureString(text, this.font_3);
		graphics_0.DrawString(text, this.font_3, Brushes.DarkGray, (float)(rectangle_1.Width - this.size_0.Width) - sizeF.Width, (float)(rectangle_1.Bottom - num));
	}

	public string method_24(ref string string_0)
	{
		GClass88 gclass = this.midiFile.GetTracks()[this.int_3] as GClass88;
		string text = this.gclass126_0.method_6().Substring(0, this.gclass126_0.method_6().LastIndexOf('.')).ToLower();
		string text2 = gclass.method_1().ToLower();
		string text3 = Class109.smethod_7(this.genum53_0).ToLower();
		if (string.Compare(text2, "t1 gems", true) == 0)
		{
			text2 = "guitar";
		}
		else
		{
			text2 = text2.Substring(text2.IndexOf(' ') + 1);
		}
		string text4 = "";
		if (this.cbTrack2.Enabled && this.cbTrack2.Checked)
		{
			GClass88 gclass2 = this.midiFile.GetTracks()[this.int_4] as GClass88;
			string text5 = gclass2.method_1().ToLower();
			text4 = "+" + text5.Substring(text5.IndexOf(' ') + 1);
		}
		if (string_0 != null)
		{
			string_0 = string.Concat(new string[]
			{
				text,
				"_",
				text2.Replace(' ', '_'),
				text4,
				"_",
				text3
			});
		}
		return string.Concat(new string[]
		{
			text,
			" - ",
			text2,
			text4,
			" (",
			text3,
			")"
		});
	}

	public void method_25(string string_0, string string_1)
	{
		Size size = this.method_14(1024);
		size.Height += this.int_1 + this.int_2 + this.size_0.Height;
		Bitmap bitmap = new Bitmap(size.Width, size.Height, PixelFormat.Format16bppRgb565);
		Graphics graphics = Graphics.FromImage(bitmap);
		Rectangle rectangle = new Rectangle(Point.Empty, bitmap.Size);
		graphics.FillRectangle(Brushes.White, rectangle);
		Rectangle rectangle2 = new Rectangle(0, this.int_1 - this.size_1.Height, size.Width, size.Height - this.font_3.Height);
		this.method_19(this.genum53_0, graphics, rectangle2, rectangle2);
		if (this.bool_2)
		{
			graphics.FillRectangle(Brushes.White, rectangle);
			this.int_6 = rectangle.Width - this.size_0.Width;
			this.int_7 = rectangle.Width;
			this.method_15();
			this.method_19(this.genum53_0, graphics, rectangle2, rectangle2);
		}
		this.method_22(graphics, string_1.ToLower(), rectangle);
		this.method_23(graphics, rectangle);
		bitmap.Save(string_0, ImageFormat.Png);
	}

	void btnExport_Click(object sender, EventArgs e)
	{
		string fileName = "";
		string string_ = this.method_24(ref fileName);
		if (this.cbTitle.Checked)
		{
			string_ = this.tbTitle.Text;
		}
		this.saveFileDialog_0.FileName = fileName;
		this.saveFileDialog_0.InitialDirectory = Class61.smethod_0().method_8().method_1("MidExport");
		if (this.saveFileDialog_0.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		Class61.smethod_0().method_8().method_2("MidExport", Class109.smethod_5(this.saveFileDialog_0.FileName));
		this.method_25(this.saveFileDialog_0.FileName, string_);
	}

	void cbTrack2_CheckedChanged(object sender, EventArgs e)
	{
		if (this.cbTrack2.Checked)
		{
			this.int_4 = MidPreview.smethod_0(this.midiFile, this.cbTracks2, this.midiFile.GetTracks()[this.int_3].method_1());
			this.cbTracks2.SelectedIndex = 0;
		}
		this.cbTracks2.Enabled = this.cbTrack2.Checked;
		this.method_18();
		this.method_16();
		base.Invalidate();
	}

	void btnPrint_Click(object sender, EventArgs e)
	{
		string text = null;
		this.printDocument_0.DocumentName = this.method_24(ref text);
		if (this.cbTitle.Checked)
		{
			this.printDocument_0.DocumentName = this.tbTitle.Text;
		}
		this.printPreviewDialog.DesktopBounds = base.RectangleToScreen(base.Bounds);
		this.printPreviewDialog.ShowDialog();
	}

	void printDocument_0_BeginPrint(object sender, PrintEventArgs e)
	{
		this.int_8 = 0;
		this.bool_3 = true;
	}

	void printDocument_0_EndPrint(object sender, PrintEventArgs e)
	{
		this.bool_3 = false;
	}

	void printDocument_0_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
	{
		Margins margins = new Margins(10, 10, 20, 50);
		e.PageSettings.Margins = margins;
	}

	void printDocument_0_PrintPage(object sender, PrintPageEventArgs e)
	{
		Graphics graphics = e.Graphics;
		Rectangle marginBounds = e.MarginBounds;
		string text = null;
		string string_ = this.method_24(ref text);
		if (this.cbTitle.Checked)
		{
			string_ = this.tbTitle.Text;
		}
		this.method_22(graphics, string_, marginBounds);
		marginBounds.Y += this.int_1;
		marginBounds.Height -= this.int_1;
		Rectangle rectangle = new Rectangle(marginBounds.Location, new Size(marginBounds.Width, marginBounds.Height - this.int_2));
		Rectangle rectangle_ = new Rectangle(marginBounds.X, marginBounds.Y - this.int_1, rectangle.Width, rectangle.Height);
		if (this.bool_2)
		{
			this.method_19(this.genum53_0, graphics, rectangle, rectangle_);
			graphics.FillRectangle(new SolidBrush(this.BackColor), rectangle);
			graphics.DrawRectangle(Pens.Red, rectangle);
		}
		this.method_19(this.genum53_0, graphics, rectangle, rectangle_);
		this.method_23(graphics, e.MarginBounds);
		if (this.int_8 < this.list_0.Count)
		{
			e.HasMorePages = true;
		}
	}

	void btnPageSetup_Click(object sender, EventArgs e)
	{
		this.pageSetupDialog_0.ShowDialog();
	}

	void cbLefty_CheckedChanged(object sender, EventArgs e)
	{
		base.Invalidate();
	}

	void cbTitle_CheckedChanged(object sender, EventArgs e)
	{
		this.tbTitle.Enabled = this.cbTitle.Checked;
		if (this.cbTitle.Checked)
		{
			this.tbTitle.Text = "";
			this.tbTitle.Focus();
			return;
		}
		this.tbTitle.Text = "Title for export/printing";
	}

	void nudTempoThreshold_ValueChanged(object sender, EventArgs e)
	{
		base.Invalidate();
	}

	void MidPreview_Click(object sender, EventArgs e)
	{
		if (this.vscrollBar_0.Visible)
		{
			this.vscrollBar_0.Focus();
		}
	}

	public int method_26(Point point_0)
	{
		Class20 @class = this.method_27(point_0);
		if (@class == null)
		{
			return -1;
		}
		return this.method_28(@class, point_0);
	}

	Class20 method_27(Point point_0)
	{
		foreach (Class20 @class in this.list_0)
		{
			Rectangle rectangle = @class.rectangle_0;
			rectangle.Offset(@class.rectangle_1.Location.X - @class.int_0, @class.rectangle_1.Y);
			if (rectangle.Contains(point_0))
			{
				if (@class.rectangle_1 != Rectangle.Empty)
				{
					return @class;
				}
				return null;
			}
		}
		return null;
	}

	int method_28(Class20 class20_0, Point point_0)
	{
		int num = class20_0.gclass141_0.int_1 * this.midiFile.TicksPerQuarterNote();
		return Math.Max(class20_0.int_1, class20_0.int_1 + (point_0.X - class20_0.rectangle_1.X) * num / class20_0.rectangle_1.Width);
	}

	bool method_29(int int_12, out Class20 class20_0)
	{
		Rectangle rectangle = this.method_20();
		foreach (Class20 @class in this.list_0)
		{
			int num = @class.gclass141_0.int_1 * this.midiFile.TicksPerQuarterNote();
			if (int_12 >= @class.int_1 && int_12 < @class.int_1 + num)
			{
				class20_0 = @class;
				if (!rectangle.Contains(@class.rectangle_2))
				{
					this.vscrollBar_0.Value = Math.Max(this.vscrollBar_0.Minimum, Math.Min(this.vscrollBar_0.Maximum, @class.rectangle_1.Y - this.list_0[0].rectangle_1.Y - this.rectangle_0.Height));
					return true;
				}
				return false;
			}
		}
		class20_0 = null;
		return false;
	}

	public int method_30()
	{
		return this.int_9;
	}

	public void method_31(int int_12)
	{
		if (this.genum9_0 != MidPreview.GEnum9.const_2)
		{
			return;
		}
		Region region = new Region();
		Class20 @class;
		if (!this.method_29(int_12, out @class) && @class != null)
		{
			int num = @class.gclass141_0.int_1 * this.midiFile.TicksPerQuarterNote();
			region.Union(@class.rectangle_2);
			int num2 = this.list_0.IndexOf(@class);
			if (num2 - 1 >= 0)
			{
				region.Union(this.list_0[num2 - 1].rectangle_2);
			}
			if (num2 + 1 < this.list_0.Count)
			{
				region.Union(this.list_0[num2 + 1].rectangle_1);
			}
			int num3 = @class.int_1 + num;
			int num4 = @class.int_1;
			for (int i = 0; i < @class.list_1.Length; i++)
			{
				foreach (MidiEvent gclass in @class.list_1[i][(int)this.genum53_0])
				{
					if (gclass.vmethod_2() == GEnum63.const_4)
					{
						num3 = Math.Min(gclass.int_0, num3);
						num4 = Math.Max(gclass.int_0 + gclass.vmethod_0(), num4);
					}
				}
			}
			if (num3 >= @class.int_1 && num4 < @class.int_1 + num)
			{
				goto IL_1ED;
			}
			Rectangle rect = this.method_20();
			using (List<Class20>.Enumerator enumerator2 = this.list_0.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					Class20 class2 = enumerator2.Current;
					int num5 = Math.Min(num4, class2.int_1 + class2.gclass141_0.int_1 * this.midiFile.TicksPerQuarterNote()) - Math.Max(num3, class2.int_1);
					if (num5 > 0 && class2.rectangle_2.IntersectsWith(rect))
					{
						region.Union(class2.rectangle_2);
					}
				}
				goto IL_1ED;
			}
		}
		region.Union(this.method_20());
		IL_1ED:
		if (!this.cbSection.DroppedDown)
		{
			int j = this.cbSection.Items.Count - 1;
			while (j >= 0)
			{
				MidPreview.GClass63 gclass2 = this.cbSection.Items[j] as MidPreview.GClass63;
				if (gclass2.gclass140_0.int_0 >= int_12)
				{
					j--;
				}
				else
				{
					if (j != this.cbSection.SelectedIndex)
					{
						this.cbSection.SelectedIndex = j;
						break;
					}
					break;
				}
			}
		}
		this.int_9 = int_12;
		base.Invalidate(region);
	}

	void MidPreview_MouseMove(object sender, MouseEventArgs e)
	{
		if (this.genum9_0 != MidPreview.GEnum9.const_1)
		{
			return;
		}
		this.int_9 = -1;
		Class20 @class = this.method_27(e.Location);
		if (@class == null)
		{
			this.int_11 = -1;
			return;
		}
		int num = this.method_28(@class, e.Location);
		this.int_11 = num;
		if (this.mouseButtons_0 == MouseButtons.Left && (this.class19_0 != null || (this.class19_0 == null && Math.Abs(num - this.int_10) >= this.midiFile.TicksPerQuarterNote() / 16)))
		{
			this.class19_0 = new Class19();
			this.class19_0.int_0 = Math.Min(num, this.int_10);
			this.class19_0.int_1 = Math.Max(num, this.int_10);
		}
		this.int_9 = num;
		base.Invalidate();
	}

	void MidPreview_MouseDown(object sender, MouseEventArgs e)
	{
		switch (this.genum9_0)
		{
		case MidPreview.GEnum9.const_1:
			this.class19_0 = null;
			if (e.Button == MouseButtons.Left)
			{
				Class20 @class = this.method_27(e.Location);
				if (@class != null)
				{
					this.int_10 = this.method_28(@class, e.Location);
					this.mouseButtons_0 = e.Button;
				}
			}
			break;
		case MidPreview.GEnum9.const_2:
			break;
		default:
			return;
		}
	}

	void MidPreview_MouseUp(object sender, MouseEventArgs e)
	{
		if (this.genum9_0 != MidPreview.GEnum9.const_1)
		{
			return;
		}
		if (this.mouseButtons_0 != MouseButtons.Left || this.method_27(e.Location) == null)
		{
		}
		this.mouseButtons_0 = MouseButtons.None;
		this.int_10 = -1;
		base.Invalidate();
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_32(MidPreview.GDelegate2 gdelegate2_1)
	{
		this.gdelegate2_0 = (MidPreview.GDelegate2)Delegate.Combine(this.gdelegate2_0, gdelegate2_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_33(MidPreview.GDelegate2 gdelegate2_1)
	{
		this.gdelegate2_0 = (MidPreview.GDelegate2)Delegate.Remove(this.gdelegate2_0, gdelegate2_1);
	}

	void cbSection_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	void cbSection_SelectionChangeCommitted(object sender, EventArgs e)
	{
		MidPreview.GClass63 gclass = this.cbSection.SelectedItem as MidPreview.GClass63;
		if (gclass == null)
		{
			return;
		}
		Class20 @class;
		if (this.method_29(gclass.gclass140_0.int_0, out @class))
		{
			base.Invalidate();
		}
		if (this.gdelegate2_0 != null)
		{
			this.gdelegate2_0(this, gclass);
		}
	}

	void cbShowInvalid_CheckedChanged(object sender, EventArgs e)
	{
		base.Invalidate();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	void InitializeComponent()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MidPreview));
		this.panel1 = new Panel();
		this.cbShowInvalid = new CheckBox();
		this.cbSection = new ComboBox();
		this.label1 = new Label();
		this.nudTempoThreshold = new NumericUpDown();
		this.tbTitle = new TextBox();
		this.cbTitle = new CheckBox();
		this.cbLefty = new CheckBox();
		this.btnPageSetup = new Button();
		this.btnPrint = new Button();
		this.cbTrack2 = new CheckBox();
		this.cbTracks2 = new ComboBox();
		this.btnExport = new Button();
		this.cbTracks = new ComboBox();
		this.cbDifficulty = new ComboBox();
		this.saveFileDialog_0 = new SaveFileDialog();
		this.printDialog_0 = new PrintDialog();
		this.printDocument_0 = new PrintDocument();
		this.printPreviewDialog = new PrintPreviewDialog();
		this.pageSetupDialog_0 = new PageSetupDialog();
		this.panel1.SuspendLayout();
		((ISupportInitialize)this.nudTempoThreshold).BeginInit();
		base.SuspendLayout();
		this.panel1.BackColor = SystemColors.Control;
		this.panel1.Controls.Add(this.cbShowInvalid);
		this.panel1.Controls.Add(this.cbSection);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.nudTempoThreshold);
		this.panel1.Controls.Add(this.tbTitle);
		this.panel1.Controls.Add(this.cbTitle);
		this.panel1.Controls.Add(this.cbLefty);
		this.panel1.Controls.Add(this.btnPageSetup);
		this.panel1.Controls.Add(this.btnPrint);
		this.panel1.Controls.Add(this.cbTrack2);
		this.panel1.Controls.Add(this.cbTracks2);
		this.panel1.Controls.Add(this.btnExport);
		this.panel1.Controls.Add(this.cbTracks);
		this.panel1.Controls.Add(this.cbDifficulty);
		this.panel1.Dock = DockStyle.Top;
		this.panel1.Location = new Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new Size(658, 55);
		this.panel1.TabIndex = 0;
		this.cbShowInvalid.AutoSize = true;
		this.cbShowInvalid.Location = new Point(558, 4);
		this.cbShowInvalid.Name = "cbShowInvalid";
		this.cbShowInvalid.Size = new Size(87, 17);
		this.cbShowInvalid.TabIndex = 13;
		this.cbShowInvalid.Text = "Show Invalid";
		this.cbShowInvalid.UseVisualStyleBackColor = true;
		this.cbShowInvalid.CheckedChanged += this.cbShowInvalid_CheckedChanged;
		this.cbSection.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cbSection.Enabled = false;
		this.cbSection.FormattingEnabled = true;
		this.cbSection.Location = new Point(387, 3);
		this.cbSection.Name = "cbSection";
		this.cbSection.Size = new Size(90, 21);
		this.cbSection.TabIndex = 12;
		this.cbSection.SelectionChangeCommitted += this.cbSection_SelectionChangeCommitted;
		this.cbSection.SelectedIndexChanged += this.cbSection_SelectedIndexChanged;
		this.label1.AutoSize = true;
		this.label1.Location = new Point(384, 33);
		this.label1.Name = "label1";
		this.label1.Size = new Size(93, 13);
		this.label1.TabIndex = 11;
		this.label1.Text = "Tempo Threshold:";
		this.nudTempoThreshold.Location = new Point(480, 30);
		NumericUpDown numericUpDown = this.nudTempoThreshold;
		int[] array = new int[4];
		array[0] = 1;
		numericUpDown.Minimum = new decimal(array);
		this.nudTempoThreshold.Name = "nudTempoThreshold";
		this.nudTempoThreshold.Size = new Size(43, 20);
		this.nudTempoThreshold.TabIndex = 10;
		NumericUpDown numericUpDown2 = this.nudTempoThreshold;
		int[] array2 = new int[4];
		array2[0] = 1;
		numericUpDown2.Value = new decimal(array2);
		this.nudTempoThreshold.ValueChanged += this.nudTempoThreshold_ValueChanged;
		this.tbTitle.Enabled = false;
		this.tbTitle.Location = new Point(209, 30);
		this.tbTitle.MaxLength = 50;
		this.tbTitle.Name = "tbTitle";
		this.tbTitle.Size = new Size(172, 20);
		this.tbTitle.TabIndex = 9;
		this.tbTitle.Text = "Title for export/printing";
		this.cbTitle.AutoSize = true;
		this.cbTitle.Location = new Point(188, 33);
		this.cbTitle.Name = "cbTitle";
		this.cbTitle.Size = new Size(15, 14);
		this.cbTitle.TabIndex = 8;
		this.cbTitle.UseVisualStyleBackColor = true;
		this.cbTitle.CheckedChanged += this.cbTitle_CheckedChanged;
		this.cbLefty.AutoSize = true;
		this.cbLefty.Location = new Point(483, 4);
		this.cbLefty.Name = "cbLefty";
		this.cbLefty.Size = new Size(69, 18);
		this.cbLefty.TabIndex = 7;
		this.cbLefty.Text = "Lefty Flip";
		this.cbLefty.UseCompatibleTextRendering = true;
		this.cbLefty.UseVisualStyleBackColor = true;
		this.cbLefty.CheckedChanged += this.cbLefty_CheckedChanged;
		this.btnPageSetup.FlatStyle = FlatStyle.Popup;
		this.btnPageSetup.Location = new Point(107, 30);
		this.btnPageSetup.Name = "btnPageSetup";
		this.btnPageSetup.Size = new Size(75, 21);
		this.btnPageSetup.TabIndex = 6;
		this.btnPageSetup.Text = "Page Setup";
		this.btnPageSetup.UseVisualStyleBackColor = true;
		this.btnPageSetup.Click += this.btnPageSetup_Click;
		this.btnPrint.FlatStyle = FlatStyle.Popup;
		this.btnPrint.Location = new Point(55, 30);
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.Size = new Size(46, 21);
		this.btnPrint.TabIndex = 5;
		this.btnPrint.Text = "Print";
		this.btnPrint.UseVisualStyleBackColor = true;
		this.btnPrint.Click += this.btnPrint_Click;
		this.cbTrack2.AutoSize = true;
		this.cbTrack2.Location = new Point(143, 6);
		this.cbTrack2.Name = "cbTrack2";
		this.cbTrack2.Size = new Size(15, 14);
		this.cbTrack2.TabIndex = 4;
		this.cbTrack2.UseVisualStyleBackColor = true;
		this.cbTrack2.CheckedChanged += this.cbTrack2_CheckedChanged;
		this.cbTracks2.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cbTracks2.Enabled = false;
		this.cbTracks2.FormattingEnabled = true;
		this.cbTracks2.Location = new Point(164, 3);
		this.cbTracks2.Name = "cbTracks2";
		this.cbTracks2.Size = new Size(134, 21);
		this.cbTracks2.TabIndex = 3;
		this.cbTracks2.SelectedIndexChanged += this.cbTracks2_SelectedIndexChanged;
		this.btnExport.FlatStyle = FlatStyle.Popup;
		this.btnExport.Location = new Point(3, 30);
		this.btnExport.Name = "btnExport";
		this.btnExport.Size = new Size(46, 21);
		this.btnExport.TabIndex = 2;
		this.btnExport.Text = "Export";
		this.btnExport.UseCompatibleTextRendering = true;
		this.btnExport.UseVisualStyleBackColor = true;
		this.btnExport.Click += this.btnExport_Click;
		this.cbTracks.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cbTracks.FormattingEnabled = true;
		this.cbTracks.Location = new Point(3, 3);
		this.cbTracks.Name = "cbTracks";
		this.cbTracks.Size = new Size(134, 21);
		this.cbTracks.TabIndex = 1;
		this.cbTracks.SelectedIndexChanged += this.cbTracks_SelectedIndexChanged;
		this.cbDifficulty.DropDownStyle = ComboBoxStyle.DropDownList;
		this.cbDifficulty.FormattingEnabled = true;
		this.cbDifficulty.Items.AddRange(new object[]
		{
			"Easy",
			"Medium",
			"Hard",
			"Expert"
		});
		this.cbDifficulty.Location = new Point(304, 3);
		this.cbDifficulty.Name = "cbDifficulty";
		this.cbDifficulty.Size = new Size(77, 21);
		this.cbDifficulty.TabIndex = 0;
		this.cbDifficulty.SelectedIndexChanged += this.cbDifficulty_SelectedIndexChanged;
		this.saveFileDialog_0.Filter = "PNG|*.png";
		this.saveFileDialog_0.Title = "Export note chart";
		this.printDialog_0.AllowPrintToFile = false;
		this.printDialog_0.UseEXDialog = true;
		this.printDocument_0.DocumentName = "Notes";
		this.printDocument_0.OriginAtMargins = true;
		this.printDocument_0.PrintPage += this.printDocument_0_PrintPage;
		this.printDocument_0.QueryPageSettings += this.printDocument_0_QueryPageSettings;
		this.printDocument_0.EndPrint += this.printDocument_0_EndPrint;
		this.printDocument_0.BeginPrint += this.printDocument_0_BeginPrint;
		this.printPreviewDialog.AutoScrollMargin = new Size(0, 0);
		this.printPreviewDialog.AutoScrollMinSize = new Size(0, 0);
		this.printPreviewDialog.ClientSize = new Size(400, 300);
		this.printPreviewDialog.Document = this.printDocument_0;
		this.printPreviewDialog.Enabled = true;
		this.printPreviewDialog.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialogIcon");
		this.printPreviewDialog.Name = "printPreviewDialog";
		this.printPreviewDialog.ShowIcon = false;
		this.printPreviewDialog.UseAntiAlias = true;
		this.printPreviewDialog.Visible = false;
		this.pageSetupDialog_0.AllowMargins = false;
		this.pageSetupDialog_0.Document = this.printDocument_0;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		this.BackColor = Color.White;
		base.Controls.Add(this.panel1);
		this.DoubleBuffered = true;
		base.Name = "MidPreview";
		base.Size = new Size(658, 397);
		base.Click += this.MidPreview_Click;
		base.MouseDown += this.MidPreview_MouseDown;
		base.MouseMove += this.MidPreview_MouseMove;
		base.Scroll += this.MidPreview_Scroll;
		base.Resize += this.MidPreview_Resize;
		base.Paint += this.MidPreview_Paint;
		base.MouseUp += this.MidPreview_MouseUp;
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((ISupportInitialize)this.nudTempoThreshold).EndInit();
		base.ResumeLayout(false);
	}

	MidiFile midiFile;

	ArkEntry gclass126_0;

	Rectangle rectangle_0;

	Size size_0;

	Size size_1;

	Size size_2;

	int int_0;

	int int_1;

	int int_2;

	Font font_0;

	Font font_1;

	Font font_2;

	Font font_3;

	Font font_4;

	Pen pen_0;

	int int_3;

	int int_4;

	GEnum53 genum53_0;

	bool bool_0;

	VScrollBar vscrollBar_0;

	HScrollBar hscrollBar_0;

	int int_5;

	MidPreview.GEnum9 genum9_0;

	int int_6;

	int int_7;

	List<Class20> list_0 = new List<Class20>();

	bool bool_1;

	bool bool_2 = true;

	bool bool_3;

	int int_8;

	int int_9 = -1;

	Class19 class19_0;

	int int_10 = -1;

	int int_11 = -1;

	MouseButtons mouseButtons_0;

	MidPreview.GDelegate2 gdelegate2_0;

	IContainer icontainer_0;

	Panel panel1;

	ComboBox cbTracks;

	ComboBox cbDifficulty;

	Button btnExport;

	SaveFileDialog saveFileDialog_0;

	CheckBox cbTrack2;

	ComboBox cbTracks2;

	Button btnPrint;

	PrintDialog printDialog_0;

	PrintDocument printDocument_0;

	PrintPreviewDialog printPreviewDialog;

	Button btnPageSetup;

	PageSetupDialog pageSetupDialog_0;

	CheckBox cbLefty;

	TextBox tbTitle;

	CheckBox cbTitle;

	Label label1;

	NumericUpDown nudTempoThreshold;

	ComboBox cbSection;

	CheckBox cbShowInvalid;

	public class GClass63
	{
		public override string ToString()
		{
			return this.string_0;
		}

		public GClass140 gclass140_0;

		public string string_0;
	}

	public enum GEnum9
	{
		const_0,
		const_1,
		const_2
	}

	public delegate void GDelegate2(object object_0, MidPreview.GClass63 gclass63_0);
}
