using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public partial class VgsImportDialog : Form
{
	public VgsImportDialog(ArkEntry gclass126_1)
	{
		this.InitializeComponent();
		this.gclass126_0 = gclass126_1;
		this.comboBox_0 = new ComboBox[]
		{
			this.cbChannel0,
			this.cbChannel1,
			this.cbChannel2,
			this.cbChannel3,
			this.cbChannel4,
			this.cbChannel5,
			this.cbChannel6,
			this.cbChannel7
		};
		BinaryReader binaryReader_ = new BinaryReader(gclass126_1.method_9());
		this.struct2_0 = Class39.smethod_0(binaryReader_);
		switch (this.struct2_0.struct3_0.Length)
		{
		case 1:
			this.lMapping.Text = "0=Speech?";
			goto IL_13F;
		case 2:
			if (gclass126_1.method_6().Contains("_p"))
			{
				this.lMapping.Text = "0=Guitar, 1=Rhythm/Bass";
				goto IL_13F;
			}
			this.lMapping.Text = "0/1=Music L/R";
			goto IL_13F;
		case 4:
			this.lMapping.Text = "0/1=Band L/R, 2/3=Guitar L/R";
			goto IL_13F;
		case 5:
			this.lMapping.Text = "0/1=Band L/R, 2/3=Guitar L/R, 4=Bass";
			goto IL_13F;
		case 6:
			this.lMapping.Text = "0/1=Band L/R, 2/3=Lead L/R, 4/5=Rhythm L/R";
			goto IL_13F;
		}
		this.lMapping.Text = "..";
		IL_13F:
		for (int i = 0; i < this.struct2_0.struct3_0.Length; i++)
		{
			this.comboBox_0[i].Enabled = true;
		}
		this.method_1(new VgsImportDialog.Class13[8]);
		this.btnOk.Enabled = false;
	}

	VgsImportDialog.Class13[] method_0()
	{
		VgsImportDialog.Class13[] array = new VgsImportDialog.Class13[this.comboBox_0.Length];
		foreach (ComboBox comboBox in this.comboBox_0)
		{
			int num = Array.IndexOf<ComboBox>(this.comboBox_0, comboBox);
			array[num] = (comboBox.SelectedItem as VgsImportDialog.Class13);
		}
		return array;
	}

	void method_1(VgsImportDialog.Class13[] class13_0)
	{
		foreach (ComboBox comboBox in this.comboBox_0)
		{
			VgsImportDialog.Class13 @class = class13_0[Array.IndexOf<ComboBox>(this.comboBox_0, comboBox)];
			comboBox.BeginUpdate();
			comboBox.Items.Clear();
			if (!comboBox.Enabled)
			{
				comboBox.Items.Add("Not Used");
				comboBox.SelectedIndex = 0;
				comboBox.EndUpdate();
			}
			else
			{
				comboBox.Items.Add("Silence");
				int selectedIndex = 0;
				foreach (object obj in this.lvSources.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					foreach (VgsImportDialog.Class13 class2 in (listViewItem.Tag as VgsImportDialog.Class14).class13_0)
					{
						int num = comboBox.Items.Add(class2);
						if (@class != null && class2.class14_0 == @class.class14_0 && class2.int_0 == @class.int_0 && class2.int_1 == @class.int_1)
						{
							selectedIndex = num;
						}
					}
				}
				comboBox.SelectedIndex = selectedIndex;
				comboBox.EndUpdate();
			}
		}
	}

	void method_2()
	{
		foreach (object obj in this.lvSources.Items)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			VgsImportDialog.Class14 @class = listViewItem.Tag as VgsImportDialog.Class14;
			@class.int_0 = this.lvSources.Items.IndexOf(listViewItem);
			listViewItem.Text = @class.int_0.ToString();
		}
	}

	void tsmiSourceAdd_Click(object sender, EventArgs e)
	{
		this.openFileDialog_0.InitialDirectory = Class61.smethod_0().method_8().method_1("VgsImport");
		if (this.openFileDialog_0.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		Class61.smethod_0().method_8().method_2("VgsImport", Class109.smethod_5(this.openFileDialog_0.FileNames[0]));
		VgsImportDialog.Class13[] class13_ = this.method_0();
		this.lvSources.BeginUpdate();
		foreach (string text in this.openFileDialog_0.FileNames)
		{
			bool flag = false;
			foreach (object obj in this.lvSources.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				if (string.Compare(text, (listViewItem.Tag as VgsImportDialog.Class14).string_0, true) == 0)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				VgsImportDialog.Class14 @class = new VgsImportDialog.Class14();
				@class.string_0 = text;
				string text2 = "";
				GClass94 gclass = new GClass94(44100, 16, 1);
				try
				{
					if (text.EndsWith(".ogg", StringComparison.CurrentCultureIgnoreCase))
					{
						GClass107 gclass2 = new GClass107(text);
						GClass100[] array = gclass2.method_33();
						string[] array2 = new string[]
						{
							"Left",
							"Right"
						};
						@class.int_1 = new int[array.Length];
						int num = 0;
						bool flag2 = false;
						List<VgsImportDialog.Class13> list = new List<VgsImportDialog.Class13>();
						GClass100 gclass3 = array[0];
						for (int j = 0; j < gclass3.int_8; j++)
						{
							list.Add(new VgsImportDialog.Class13
							{
								int_1 = j,
								class14_0 = @class,
								int_0 = num,
								string_0 = array2[j % 2] + ((num > 0) ? (1 + num).ToString() : ""),
								int_2 = gclass3.int_9
							});
							if (gclass3.int_11 != array[0].int_11)
							{
								flag2 = true;
							}
						}
						num++;
						@class.class13_0 = list.ToArray();
						gclass = new GClass94(flag2 ? 0 : array[0].int_9, 16, list.Count);
						text2 = "OGG";
					}
					else if (text.EndsWith(".vgs", StringComparison.CurrentCultureIgnoreCase))
					{
						BinaryReader binaryReader = new BinaryReader(new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read));
						Class39.Struct2 @struct = Class39.smethod_0(binaryReader);
						string[] array3;
						switch (@struct.struct3_0.Length)
						{
						case 2:
							array3 = new string[]
							{
								"Left",
								"Right"
							};
							goto IL_384;
						case 4:
							array3 = new string[]
							{
								"Band Left",
								"Band Right",
								"Guitar Left",
								"Guitar Right"
							};
							goto IL_384;
						case 5:
							array3 = new string[]
							{
								"Band Left",
								"Band Right",
								"Guitar Left",
								"Guitar Right",
								"Bass"
							};
							goto IL_384;
						case 6:
							array3 = new string[]
							{
								"Band Left",
								"Band Right",
								"Guitar Left",
								"Guitar Right",
								"Rhythm Left",
								"Rhythm Right"
							};
							goto IL_384;
						}
						array3 = new string[@struct.struct3_0.Length];
						IL_384:
						VgsImportDialog.Class14 class2 = @class;
						int[] int_ = new int[1];
						class2.int_1 = int_;
						@class.class13_0 = new VgsImportDialog.Class13[@struct.struct3_0.Length];
						bool flag3 = false;
						for (int k = 0; k < @struct.struct3_0.Length; k++)
						{
							VgsImportDialog.Class13 class3 = new VgsImportDialog.Class13();
							class3.int_1 = k;
							class3.class14_0 = @class;
							class3.int_0 = 0;
							class3.string_0 = array3[k];
							class3.int_2 = @struct.struct3_0[k].int_0;
							@class.class13_0[k] = class3;
							if (@struct.struct3_0[k].int_0 != @struct.struct3_0[0].int_0)
							{
								flag3 = true;
							}
						}
						gclass = new GClass94(flag3 ? 0 : @struct.struct3_0[0].int_0, 16, @struct.struct3_0.Length);
						text2 = "VGS";
						binaryReader.Close();
					}
					else
					{
						if (text.EndsWith(".wav", StringComparison.CurrentCultureIgnoreCase))
						{
							GStream1 gstream = new GStream1(text);
							if (gstream.method_0().short_0 == 1)
							{
								if (gstream.method_0().short_3 == 16)
								{
									VgsImportDialog.Class14 class4 = @class;
									int[] int_2 = new int[1];
									class4.int_1 = int_2;
									@class.class13_0 = new VgsImportDialog.Class13[(int)gstream.method_0().short_1];
									string[] array4 = new string[]
									{
										"Left",
										"Right"
									};
									for (int l = 0; l < (int)gstream.method_0().short_1; l++)
									{
										VgsImportDialog.Class13 class5 = new VgsImportDialog.Class13();
										class5.int_1 = l;
										class5.class14_0 = @class;
										class5.int_0 = 0;
										class5.int_2 = gstream.method_0().int_0;
										if (gstream.method_0().short_1 < 2)
										{
											class5.string_0 = array4[l];
										}
										@class.class13_0[l] = class5;
									}
									gclass = gstream.method_0();
									text2 = "PCM";
									gstream.Close();
									goto IL_8B5;
								}
							}
							throw new FileLoadException("Only 16bit PCM formats supported for now");
						}
						GStream0 gstream2 = new GStream0(text);
						if (!bool.Parse(gstream2.method_7("HasAudio")))
						{
							throw new FileLoadException("File doesn't contain audio");
						}
						if (gstream2.method_0().short_3 != 16)
						{
							throw new FileLoadException("Only 16bit streams supported");
						}
						if (int.Parse(gstream2.method_7("WM/ContainerFormat")) == 0)
						{
							text2 = "MP3";
						}
						else
						{
							text2 = "WMA";
						}
						string[] array5 = new string[]
						{
							"Left",
							"Right"
						};
						gclass = gstream2.method_0();
						uint num2 = 0u;
						gstream2.method_1().imethod_5(out num2);
						int[] array6 = new int[num2];
						List<VgsImportDialog.Class13> list2 = new List<VgsImportDialog.Class13>((int)(num2 * 2u));
						int num3 = 0;
						int num4 = 0;
						while ((long)num4 < (long)((ulong)num2))
						{
							GInterface38 ginterface;
							gstream2.method_1().imethod_7((ushort)(1 + num4), out ginterface);
							Guid a;
							ginterface.imethod_0(out a);
							if (!(a != GClass67.smethod_41()))
							{
								array6[num3++] = 1 + num4;
								GInterface9 ginterface2 = ginterface as GInterface9;
								GStruct2 gstruct = default(GStruct2);
								uint cb = 0u;
								ginterface2.imethod_1(IntPtr.Zero, ref cb);
								IntPtr intPtr = Marshal.AllocCoTaskMem((int)cb);
								ginterface2.imethod_1(intPtr, ref cb);
								gstruct = (GStruct2)Marshal.PtrToStructure(intPtr, gstruct.GetType());
								Guid guid_ = gstruct.guid_1;
								if (guid_ == GClass67.smethod_23())
								{
									text2 = "MP3";
								}
								else if (guid_ == GClass67.smethod_29())
								{
									text2 = "PCM";
								}
								else if (guid_ == GClass67.smethod_31())
								{
									text2 = "WMA9";
								}
								else if (guid_ == GClass67.smethod_32())
								{
									text2 = "WMA2";
								}
								else if (guid_ == GClass67.smethod_33())
								{
									text2 = "WMA7";
								}
								else if (guid_ == GClass67.smethod_34())
								{
									text2 = "WMA8";
								}
								else if (guid_ == GClass67.smethod_35())
								{
									text2 = "WMA9";
								}
								else if (guid_ == GClass67.smethod_36())
								{
									text2 = "WMA9";
								}
								else
								{
									text2 = "??";
								}
								if (gstruct.guid_2 == GClass67.smethod_18())
								{
									gclass = (GClass94)Marshal.PtrToStructure(gstruct.intptr_1, gclass.GetType());
									for (int m = 0; m < (int)gclass.short_1; m++)
									{
										VgsImportDialog.Class13 class6 = new VgsImportDialog.Class13();
										class6.int_1 = m;
										class6.class14_0 = @class;
										class6.int_0 = 1 + num4;
										class6.int_2 = gclass.int_0;
										if (m < 2)
										{
											class6.string_0 = array5[m];
										}
										list2.Add(class6);
									}
								}
								Marshal.FreeCoTaskMem(intPtr);
								if (num3 == 1)
								{
									break;
								}
							}
							num4++;
						}
						@class.int_1 = new int[num3];
						Array.Copy(array6, @class.int_1, num3);
						@class.class13_0 = new VgsImportDialog.Class13[list2.Count];
						list2.CopyTo(@class.class13_0);
						gstream2.Close();
					}
					IL_8B5:;
				}
				catch (Exception ex)
				{
					MessageBox.Show(string.Concat(new string[]
					{
						"Could not load '",
						text,
						"'\n\n\"",
						ex.Message,
						"\""
					}), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					goto IL_9DD;
				}
				ListViewItem listViewItem2 = new ListViewItem(this.lvSources.Items.Count.ToString());
				listViewItem2.Tag = @class;
				listViewItem2.SubItems.Add(gclass.short_1.ToString());
				listViewItem2.SubItems.Add(gclass.int_0 + "Hz");
				listViewItem2.SubItems.Add((gclass.short_3 != 0) ? (gclass.short_3.ToString() + "bit") : "VBR");
				listViewItem2.SubItems.Add(text2);
				listViewItem2.SubItems.Add(text.Substring(text.LastIndexOf('\\') + 1));
				this.lvSources.Items.Add(listViewItem2);
			}
			IL_9DD:;
		}
		this.method_2();
		this.lvSources.EndUpdate();
		this.method_1(class13_);
	}

	void tsmiSourceRemove_Click(object sender, EventArgs e)
	{
		VgsImportDialog.Class13[] class13_ = this.method_0();
		this.lvSources.BeginUpdate();
		foreach (object obj in this.lvSources.SelectedItems)
		{
			ListViewItem item = (ListViewItem)obj;
			this.lvSources.Items.Remove(item);
		}
		this.method_2();
		this.lvSources.EndUpdate();
		this.method_1(class13_);
	}

	public void method_3(ref ProgressDialog.GClass73 gclass73_0)
	{
		lock (gclass73_0)
		{
			gclass73_0.string_0 = "Importing";
		}
		List<VgsImportDialog.Class14> list = new List<VgsImportDialog.Class14>(this.lvSources.Items.Count);
		foreach (ComboBox comboBox in this.comboBox_0)
		{
			VgsImportDialog.Class13 @class = comboBox.SelectedItem as VgsImportDialog.Class13;
			if (@class != null && !list.Contains(@class.class14_0))
			{
				lock (gclass73_0)
				{
					gclass73_0.string_1 = "Loading '" + @class.class14_0.string_0.Substring(@class.class14_0.string_0.LastIndexOf('\\') + 1) + "'..";
				}
				if (@class.class14_0.string_0.EndsWith(".ogg", StringComparison.CurrentCultureIgnoreCase))
				{
					GClass107 gclass = new GClass107(@class.class14_0.string_0);
					GClass100 gclass2 = gclass.method_33()[0];
					@class.class14_0.short_0 = new short[gclass2.int_8][];
					long num = gclass.method_21(0);
					for (int j = 0; j < gclass2.int_8; j++)
					{
						@class.class14_0.short_0[j] = new short[num];
					}
					byte[] array2 = new byte[2 * gclass2.int_9];
					int[] array3 = new int[10];
					long num2 = 0L;
					bool flag = false;
					IL_24E:
					while (!flag)
					{
						int num3 = gclass.method_32(array2, array2.Length, 0, 2, 1, array3);
						if (num3 == 0)
						{
							break;
						}
						if (num3 == -1)
						{
							throw new Exception("Error decoding");
						}
						if (array3[0] == 0)
						{
							int num4 = 0;
							for (int k = 0; k < num3 / (gclass2.int_8 * 2); k++)
							{
								for (int l = 0; l < gclass2.int_8; l++)
								{
									byte b = array2[num4++];
									short num5 = (short)((int)array2[num4++] << 8 | (int)b);
									@class.class14_0.short_0[l][(int)(checked((IntPtr)num2))] = num5;
								}
								num2 += 1L;
								if (num2 == num)
								{
									flag = true;

									lock (gclass73_0)
									{
										gclass73_0.int_0 = (int)((1L + num2) * 100L / num);
									}
									goto IL_24E;
								}
							}

                            lock (gclass73_0)
                            {
                                gclass73_0.int_0 = (int)((1L + num2) * 100L / num);
                            }
                            goto IL_24E;
                        }
					}
					gclass = null;
				}
				else if (@class.class14_0.string_0.EndsWith(".vgs", StringComparison.CurrentCultureIgnoreCase))
				{
					FileStream fileStream = new FileStream(@class.class14_0.string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
					BinaryReader binaryReader = new BinaryReader(fileStream);
					Class39.Struct2 @struct = Class39.smethod_0(binaryReader);
					int num6 = 0;
					long num7 = 0L;
					@class.class14_0.short_0 = new short[@struct.struct3_0.Length][];
					long[] array4 = new long[@struct.struct3_0.Length];
					long[] array5 = new long[@struct.struct3_0.Length];
					long[] array6 = new long[@struct.struct3_0.Length];
					for (int m = 0; m < @struct.struct3_0.Length; m++)
					{
						@class.class14_0.short_0[m] = new short[@struct.struct3_0[m].int_1 * 28];
						@class.int_2 = @struct.struct3_0[m].int_0;
						array4[m] = 0L;
						array5[m] = 0L;
						array6[m] = 0L;
						if ((long)@struct.struct3_0[m].int_1 > num7)
						{
							num7 = (long)@struct.struct3_0[m].int_1;
							num6 = m;
						}
					}
					byte[] array7 = new byte[16];
					float[] array8 = new float[28];
					bool flag2 = false;
					while (!flag2)
					{
						fileStream.Read(array7, 0, 16);
						int num8 = (int)(array7[1] & 15);
						if (num8 == num6)
						{
							lock (gclass73_0)
							{
								gclass73_0.int_0 = (int)((1L + array4[num8]) * 100L / (num7 * 28L));
							}
							if ((array7[1] & 128) == 128)
							{
								flag2 = true;
							}
						}
						GClass80.smethod_3(ref array7, 0L, ref array8, 0L, ref array5[num8], ref array6[num8]);
						for (int n = 0; n < 28; n++)
						{
							short[] array9 = @class.class14_0.short_0[num8];
							long[] array10 = array4;
							int num9 = num8;
							long num10;
							array10[num9] = (num10 = array10[num9]) + 1L;
							array9[(int)(checked((IntPtr)num10))] = (short)array8[n];
						}
					}
					binaryReader.Close();
				}
				else
				{
					Stream stream;
					GClass94 gclass3;
					if (@class.class14_0.string_0.EndsWith(".wav", StringComparison.CurrentCultureIgnoreCase))
					{
						stream = new GStream1(@class.class14_0.string_0);
						gclass3 = (stream as GStream1).method_0();
					}
					else
					{
						stream = new GStream0(@class.class14_0.string_0);
						gclass3 = (stream as GStream0).method_0();
					}
					int num11 = @class.class14_0.int_2 * gclass3.int_0 / 1000;
					byte[] array11 = new byte[(int)(28 * gclass3.short_2)];
					long num12 = (long)num11 + stream.Length / (long)gclass3.short_2;
					if (num12 % 28L != 0L)
					{
						num12 += 28L - num12 % 28L;
					}
					@class.class14_0.short_0 = new short[(int)gclass3.short_1][];
					for (int num13 = 0; num13 < (int)gclass3.short_1; num13++)
					{
						@class.class14_0.short_0[num13] = new short[num12];
						@class.int_2 = gclass3.int_0;
					}
					if (num11 < 0)
					{
						stream.Seek((long)(Math.Abs(num11) * (int)gclass3.short_2), SeekOrigin.Begin);
						num11 = 0;
					}
					int num16;
					for (long num14 = (long)num11; num14 < num12; num14 += (long)num16)
					{
						lock (gclass73_0)
						{
							gclass73_0.int_0 = (int)((1L + num14) * 100L / num12);
						}
						int num15 = stream.Read(array11, 0, array11.Length);
						num16 = num15 / (int)gclass3.short_2;
						if (num16 == 0)
						{
							break;
						}
						for (int num17 = 0; num17 < num16; num17++)
						{
							for (int num18 = 0; num18 < (int)gclass3.short_1; num18++)
							{
								int num19 = (num17 * (int)gclass3.short_1 + num18) * (int)(gclass3.short_3 / 8);
								short num20 = (short)((int)array11[num19 + 1] << 8 | (int)array11[num19]);
								@class.class14_0.short_0[num18][(int)(checked((IntPtr)(unchecked(num14 + (long)num17))))] = num20;
							}
						}
					}
					stream.Close();
				}
				list.Add(@class.class14_0);
			}
		}
		if (list.Count == 0)
		{
			return;
		}
		lock (gclass73_0)
		{
			gclass73_0.string_1 = "Creating VGS";
		}
		VgsImportDialog.Class13[] array12 = new VgsImportDialog.Class13[this.struct2_0.struct3_0.Length];
		Class39.Struct2.Struct3[] array13 = new Class39.Struct2.Struct3[array12.Length];
		int num21 = 0;
		int num22 = 0;
		for (int num23 = 0; num23 < array12.Length; num23++)
		{
			VgsImportDialog.Class13 class2 = this.comboBox_0[num23].SelectedItem as VgsImportDialog.Class13;
			array13[num23].int_0 = this.struct2_0.struct3_0[num23].int_0;
			if (class2 != null)
			{
				array12[num23] = class2;
				array13[num23].int_1 = (int)(((long)class2.class14_0.short_0[class2.int_1].Length * (long)array13[num23].int_0 / (long)class2.int_2 + 27L) / 28L);
				num21 = Math.Max(array13[num23].int_1, num21);
				num22 = Math.Max(array13[num23].int_0, num22);
			}
		}
		int num24 = 128;
		int[] array14 = new int[array12.Length];
		for (int num25 = 0; num25 < array12.Length; num25++)
		{
			array14[num25] = (int)((float)(num22 / array13[num25].int_0) + 0.5f);
			array13[num25].int_1 = (int)((float)(num21 / array14[num25]) + 0.5f);
			num24 += array13[num25].int_1 * 16;
		}
		int[] array15 = new int[array12.Length];
		long[] array16 = new long[array12.Length];
		double[] array17 = new double[array12.Length];
		float[] array18 = new float[array12.Length];
		byte[] array19 = new byte[16];
		array19[0] = 12;
		byte[] array20 = array19;
		byte[] array21 = new byte[16];
		float[] array22 = new float[28];
		double[] array23 = new double[4 * array12.Length];
		int num26 = 0;
		MemoryStream memoryStream = new MemoryStream(num24);
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		Class39.smethod_1(binaryWriter, array13);
		int num27 = 0;
		while (num27 < array12.Length)
		{
			for (int num28 = 0; num28 < array12.Length; num28++)
			{
				if (array15[num28] != -1 && num26 % array14[num28] == 0)
				{
					byte b2 = (byte)num28;
					if (array15[num28] + 16 >= array13[num28].int_1 * 16)
					{
						b2 |= 128;
					}
					if (array12[num28] != null && array16[num28] < (long)array12[num28].class14_0.short_0[array12[num28].int_1].Length)
					{
						float float_ = array12[num28].class14_0.float_0;
						double num29 = (double)array12[num28].int_2 / (double)array13[num28].int_0;
						short[] array24 = array12[num28].class14_0.short_0[array12[num28].int_1];
						Array.Clear(array22, 0, 28);
						for (int num30 = 0; num30 < 28; num30++)
						{
							float num31;
							checked
							{
								num31 = (float)array24[(int)((IntPtr)array16[num28])];
								array18[num28] = (float)array24[(int)((IntPtr)array16[num28])];
							}
							long num32 = array16[num28] + (long)(array17[num28] + 0.5);
							if (num32 < (long)array24.Length)
							{
								array18[num28] = (float)array24[(int)(checked((IntPtr)num32))];
							}
							double num33 = array17[num28];
							array22[num30] = (float)((double)num31 + (double)(array18[num28] - num31) * num33) * float_;
							array17[num28] += num29;
							array16[num28] += (long)Math.Truncate(array17[num28]);
							array17[num28] -= Math.Truncate(array17[num28]);
							if (array16[num28] >= (long)array24.Length)
							{
								break;
							}
						}
						Array.Clear(array21, 0, 16);
						GClass80.smethod_4(ref array22, 0L, ref array21, 0L, ref array23[num28 * 4], ref array23[num28 * 4 + 1], ref array23[num28 * 4 + 2], ref array23[num28 * 4 + 3]);
						array21[1] = b2;
						binaryWriter.Write(array21, 0, 16);
					}
					else
					{
						array20[1] = b2;
						binaryWriter.Write(array20);
					}
					array15[num28] += 16;
					if ((b2 & 128) != 0)
					{
						array15[num28] = -1;
						num27++;
					}
				}
			}
			lock (gclass73_0)
			{
				gclass73_0.int_0 = (int)(memoryStream.Position * 100L / (long)num24);
			}
			num26++;
		}
		this.gclass126_0.method_2().method_22(this.gclass126_0, memoryStream, ref gclass73_0);
		binaryWriter.Close();
	}

	void tsmiSourceProperties_Click(object sender, EventArgs e)
	{
		VgsImportDialog.Class14 @class = this.lvSources.SelectedItems[0].Tag as VgsImportDialog.Class14;
		VgsImportSourceDialog vgsImportSourceDialog = new VgsImportSourceDialog();
		if (@class.string_0.EndsWith(".vgs"))
		{
			vgsImportSourceDialog.method_0(false);
		}
		vgsImportSourceDialog.method_3(@class.int_2);
		vgsImportSourceDialog.method_5(@class.float_0);
		if (vgsImportSourceDialog.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		@class.int_2 = vgsImportSourceDialog.method_2();
		@class.float_0 = vgsImportSourceDialog.method_4();
	}

	void cmSource_Opening(object sender, CancelEventArgs e)
	{
		this.tsmiSourceProperties.Enabled = (this.lvSources.SelectedItems.Count == 1);
		this.tsmiSourceRemove.Enabled = (this.lvSources.SelectedItems.Count > 0);
	}

	void cbChannel0_SelectedIndexChanged(object sender, EventArgs e)
	{
		bool enabled = false;
		foreach (ComboBox comboBox in this.comboBox_0)
		{
			if (comboBox.Enabled && comboBox.SelectedIndex != 0)
			{
				enabled = true;
			}
		}
		this.btnOk.Enabled = enabled;
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

	Class39.Struct2 struct2_0;

	ComboBox[] comboBox_0;

	static string[] string_0 = new string[]
	{
		"N/A",
		"0=Speech?",
		"0=Guitar, 1=Bass",
		"3",
		"4",
		"0/1=Band L/R, 2/3=Guitar L/R, 4=Bass",
		"0/1=Band L/R, 2/3=Lead L/R, 4/5=Rhythm L/R",
		"7"
	};

	class Class13
	{
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"#",
				this.class14_0.int_0,
				" Channel ",
				this.int_1,
				(this.string_0 != string.Empty) ? (" (" + this.string_0 + ")") : ""
			});
		}

		public VgsImportDialog.Class14 class14_0;

		public int int_0;

		public int int_1;

		public string string_0 = string.Empty;

		public int int_2;
	}

	class Class14
	{
		public string string_0;

		public int int_0;

		public int[] int_1;

		public VgsImportDialog.Class13[] class13_0;

		public short[][] short_0;

		public int int_2;

		public float float_0 = 1f;
	}
}
