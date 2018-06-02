using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

public partial class MidImportDialog : Form
{
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	public MidImportDialog(ArkEntry gclass126_1, string string_2)
	{
		this.InitializeComponent();
		this.MinimumSize = base.Size;
		this.MaximumSize = new Size(base.Size.Width * 4 / 3, base.Size.Height * 2);
		this.tblTracks.method_56(new GDelegate27(this.method_2));
		this.tblTracks.method_58(new GDelegate27(this.method_3));
		this.string_0 = string_2;
		MidiFile gclass = new MidiFile(gclass126_1.method_9());
		this.genum54_0 = gclass.method_3();
		this.gclass126_0 = gclass126_1;
		Stream stream = new FileStream(string_2, FileMode.Open, FileAccess.Read, FileShare.Read);
		try
		{
			if (string_2.EndsWith(".mid", StringComparison.CurrentCultureIgnoreCase))
			{
				this.gclass120_0 = new MidiFile(stream);
				if (this.gclass120_0.method_3() == GEnum54.const_0)
				{
					throw new FileLoadException("Not a valid GH MIDI file!");
				}
			}
			else if (string_2.EndsWith(".sng", StringComparison.CurrentCultureIgnoreCase))
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(stream);
				if (xmlDocument["Song"] == null || xmlDocument["Song"]["Properties"] == null)
				{
					throw new FileLoadException("Not a valid Freetar file");
				}
				float num = 0f;
				if (xmlDocument["Song"]["Properties"]["Length"] != null)
				{
					num = float.Parse(xmlDocument["Song"]["Properties"]["Length"].InnerText.Trim(), CultureInfo.InvariantCulture);
				}
				float float_ = 100f;
				if (xmlDocument["Song"]["Properties"]["BeatsPerSecond"] != null)
				{
					float_ = float.Parse(xmlDocument["Song"]["Properties"]["BeatsPerSecond"].InnerText.Trim(), CultureInfo.InvariantCulture) * 60f / 8f;
				}
				if (xmlDocument["Song"]["Data"] == null)
				{
					throw new FileLoadException("Not a valid Freetar file (no Data)");
				}
				this.gclass120_0 = new MidiFile();
				this.gclass120_0.SetTicksPerQuarterNote(480);
				GClass89 gclass2 = new GClass89(this.gclass120_0);
				gclass2.method_2("temp");
				gclass2.Events().Add(new GClass142(float_));
				gclass2.Events().Add(new GClass141(4, GEnum52.const_2, 24, 8));
				this.gclass120_0.GetTracks().Add(gclass2);
				GClass88 gclass3 = new GClass88(this.gclass120_0, "PART GUITAR");
				this.gclass120_0.GetTracks().Add(gclass3);
				GClass145 gclass4 = null;
				float num2 = 0f;
				foreach (object obj in xmlDocument["Song"]["Data"].ChildNodes)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (!(xmlNode.Name != "Note"))
					{
						float num3 = float.Parse(xmlNode.Attributes["time"].Value.Trim(), CultureInfo.InvariantCulture);
						float num4 = float.Parse(xmlNode.Attributes["duration"].Value.Trim(), CultureInfo.InvariantCulture);
						GEnum51 item = GEnum51.const_4 - int.Parse(xmlNode.Attributes["track"].Value);
						if (gclass4 == null || num3 != num2)
						{
							gclass4 = new GClass145(gclass3);
							gclass4.int_0 = this.gclass120_0.method_6((double)num3);
							if (num4 > 0f)
							{
								gclass4.vmethod_1(this.gclass120_0.method_6((double)num4));
							}
							gclass4.bool_0 = true;
							gclass3.method_13(GEnum53.const_3).Add(gclass4);
						}
						gclass4.list_0.Add(item);
						num2 = num3;
					}
				}
				if (num2 > num)
				{
					num = num2 + 0.05f;
				}
				GClass87 gclass5 = new GClass87(this.gclass120_0, "EVENTS");
				gclass5.Events().Add(new GClass140(this.gclass120_0.method_6((double)num), GEnum64.const_0, "end"));
				this.gclass120_0.GetTracks().Add(gclass5);
			}
			else
			{
				if (string_2.EndsWith(".chart", StringComparison.CurrentCultureIgnoreCase))
				{
					StreamReader streamReader = new StreamReader(stream);
					string text = string.Empty;
					int val = 0;
					int num5 = 0;
					this.gclass120_0 = new MidiFile();
					this.gclass120_0.SetTicksPerQuarterNote(192);
					this.gclass120_0.GetTracks().Add(new GClass89(this.gclass120_0));
					GClass87 gclass6 = new GClass87(this.gclass120_0, "EVENTS");
					this.gclass120_0.GetTracks().Add(gclass6);
					try
					{
						int num6 = 0;
						bool flag = true;
						GClass145 gclass7 = null;
						GClass88 gclass8 = null;
						while (!streamReader.EndOfStream)
						{
							string text2 = streamReader.ReadLine();
							num5++;
							int num7 = text2.IndexOfAny(new char[]
							{
								';',
								'#'
							});
							if (num7 != -1)
							{
								text2 = text2.Remove(num7);
							}
							num7 = text2.IndexOf("//");
							if (num7 != -1)
							{
								text2 = text2.Remove(num7);
							}
							text2 = text2.Trim();
							if (text2.Length != 0)
							{
								string[] array = text2.Split(new char[]
								{
									' ',
									'='
								}, StringSplitOptions.RemoveEmptyEntries);
								array[0] = array[0].Trim();
								if (array[0].StartsWith("[") && array[0].EndsWith("]"))
								{
									text = array[0].Trim(new char[]
									{
										'[',
										']'
									});
								}
								else
								{
									string text3;
									switch (text3 = array[0].ToLower())
									{
									case "{":
										if (text == string.Empty)
										{
											throw new FileLoadException("No section");
										}
										continue;
									case "}":
										text = string.Empty;
										continue;
									case "name":
										if (string.Compare(text, "Song", true) == 0)
										{
											this.gclass120_0.GetTracks()[0].method_2(string.Join(" ", array, 1, array.Length - 1).Trim().Trim(new char[]
											{
												'"'
											}));
											continue;
										}
										throw new FileLoadException("Didn't expect 'Name' here");
									case "offset":
									{
										if (string.Compare(text, "Song", true) != 0)
										{
											throw new FileLoadException("Didn't expect 'Offset' here");
										}
										float num9 = float.Parse(array[1].Trim(), CultureInfo.InvariantCulture);
										if (num9 > 0f)
										{
											this.gclass120_0.GetTracks()[0].Events().Add(new GClass142(240f / num9));
											this.gclass120_0.GetTracks()[0].Events().Add(new GClass141(4, GEnum52.const_2, 24, 8));
											num6 = this.gclass120_0.TicksPerQuarterNote() * 4;
											continue;
										}
										continue;
									}
									case "player2":
										if (string.Compare(text, "Song", true) == 0)
										{
											flag = !array[1].Trim().ToLower().Contains("rhythm");
											continue;
										}
										throw new FileLoadException("Didn't expect 'Player2' here");
									case "resolution":
										if (string.Compare(text, "Song", true) == 0)
										{
											this.gclass120_0.SetTicksPerQuarterNote(int.Parse(array[1].Trim()));
											continue;
										}
										throw new FileLoadException("Didn't expect 'Resolution' here");
									}
									int num10;
									if (int.TryParse(array[0], out num10) && array.Length >= 3)
									{
										int num11 = int.Parse(array[0].Trim());
										int num12 = num6 + num11;
										val = Math.Max(num12, val);
										array[1] = array[1].Trim();
										if ((text3 = array[1].ToUpper()) != null)
										{
											if (!(text3 == "TS"))
											{
												if (!(text3 == "B"))
												{
													if (text3 == "E" || text3 == "S" || text3 == "N")
													{
														bool flag2 = text.EndsWith("Single", StringComparison.InvariantCultureIgnoreCase);
														bool flag3 = text.EndsWith("DoubleGuitar", StringComparison.InvariantCultureIgnoreCase);
														bool flag4 = text.EndsWith("DoubleBass", StringComparison.InvariantCultureIgnoreCase);
														bool flag5 = string.Compare(text, "Events", true) == 0;
														if (flag2 || flag3 || flag4 || flag5)
														{
															GClass87 gclass9 = gclass6;
															GEnum53 genum53_ = GEnum53.const_4;
															if (!flag5)
															{
																string text4 = flag2 ? "PART GUITAR" : (flag3 ? "PART GUITAR COOP" : (flag4 ? (flag ? "PART BASS" : "PART RHYTHM") : ""));
																gclass8 = (this.gclass120_0.FindTrackByName(text4) as GClass88);
																if (gclass8 == null)
																{
																	gclass8 = new GClass88(this.gclass120_0, text4);
																	this.gclass120_0.GetTracks().Add(gclass8);
																}
																if (text.StartsWith("Easy", StringComparison.InvariantCultureIgnoreCase))
																{
																	genum53_ = GEnum53.const_0;
																}
																else if (text.StartsWith("Medium", StringComparison.InvariantCultureIgnoreCase))
																{
																	genum53_ = GEnum53.const_1;
																}
																else if (text.StartsWith("Hard", StringComparison.InvariantCultureIgnoreCase))
																{
																	genum53_ = GEnum53.const_2;
																}
																else
																{
																	if (!text.StartsWith("Expert", StringComparison.InvariantCultureIgnoreCase))
																	{
																		throw new FileLoadException("Unknown difficulty specified");
																	}
																	genum53_ = GEnum53.const_3;
																}
																gclass9 = gclass8;
															}
															if ((text3 = array[1].ToUpper()) != null)
															{
																if (!(text3 == "E"))
																{
																	if (!(text3 == "N"))
																	{
																		if (text3 == "S")
																		{
																			int num13 = int.Parse(array[2].Trim());
																			int int_ = int.Parse(array[3].Trim());
																			int num8 = num13;
																			switch (num8)
																			{
																			case 0:
																			case 1:
																			{
																				GClass147 gclass10 = new GClass147();
																				gclass10.int_0 = num12;
																				gclass10.int_1 = num13;
																				gclass10.vmethod_1(int_);
																				gclass8.method_13(genum53_).Add(gclass10);
																				break;
																			}
																			case 2:
																			{
																				GClass146 gclass11 = new GClass146();
																				gclass11.int_0 = num12;
																				gclass11.vmethod_1(int_);
																				gclass8.method_13(genum53_).Add(gclass11);
																				break;
																			}
																			}
																		}
																	}
																	else
																	{
																		if (gclass7 == null || num12 != gclass7.int_0)
																		{
																			gclass7 = new GClass145(gclass8);
																			gclass7.int_0 = num12;
																			gclass7.bool_0 = true;
																			gclass7.vmethod_1(int.Parse(array[3].Trim()));
																			gclass8.method_13(genum53_).Add(gclass7);
																		}
																		GEnum51 item2 = (GEnum51)int.Parse(array[2].Trim());
																		gclass7.list_0.Add(item2);
																	}
																}
																else
																{
																	string text5 = string.Empty;
																	if (array[2].Trim().StartsWith("\"") && array[array.Length - 1].Trim().EndsWith("\""))
																	{
																		text5 = string.Join(" ", array, 2, array.Length - 2).Trim(new char[]
																		{
																			'"'
																		});
																	}
																	else
																	{
																		text5 = array[2];
																	}
																	GClass140 item3 = new GClass140(num12, GEnum64.const_0, text5.Trim());
																	gclass9.Events().Add(item3);
																}
															}
														}
													}
												}
												else
												{
													if (string.Compare(text, "SyncTrack", true) != 0)
													{
														throw new FileLoadException("Didn't expect 'B' here");
													}
													GClass142 gclass12 = new GClass142(float.Parse(array[2].Trim(), CultureInfo.InvariantCulture) / 1000f);
													gclass12.int_0 = num12;
													this.gclass120_0.GetTracks()[0].Events().Add(gclass12);
												}
											}
											else
											{
												if (string.Compare(text, "SyncTrack", true) != 0)
												{
													throw new FileLoadException("Didn't expect 'TS' here");
												}
												GClass141 gclass13 = new GClass141(int.Parse(array[2].Trim()), GEnum52.const_2, 24, 8);
												gclass13.int_0 = num12;
												this.gclass120_0.GetTracks()[0].Events().Add(gclass13);
											}
										}
									}
								}
							}
						}
						goto IL_1058;
					}
					catch (Exception ex)
					{
						throw new FileLoadException(string.Concat(new object[]
						{
							"Error parsing file on line ",
							num5,
							" in \"",
							string_2.Substring(string_2.LastIndexOf('\\') + 1),
							"\":\n",
							ex.Message
						}));
					}
				}
				if (string_2.EndsWith("\\song.ini", StringComparison.CurrentCultureIgnoreCase))
				{
					string[] array2 = File.ReadAllLines(string_2);
					bool flag6 = false;
					bool flag7 = false;
					foreach (string text6 in array2)
					{
						string[] array4 = text6.Trim().ToLower().Split(new char[]
						{
							'='
						}, StringSplitOptions.RemoveEmptyEntries);
						string text3;
						if (array4.Length != 0 && (text3 = array4[0].Trim()) != null)
						{
							if (!(text3 == "[song]"))
							{
								if (!(text3 == "scores") && !(text3 == "casettecolor"))
								{
									if (!(text3 == "name"))
									{
										if (!(text3 == "artist"))
										{
										}
									}
									else
									{
										flag7 = true;
									}
								}
							}
							else
							{
								flag6 = true;
							}
						}
					}
					if (!flag6 || !flag7)
					{
						throw new Exception("Not a valid FoF song");
					}
					string path = string_2.Substring(0, string_2.LastIndexOf('\\') + 1) + "notes.mid";
					if (!File.Exists(path))
					{
						throw new Exception("Can't find notes for song");
					}
					FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
					try
					{
						MidiFile gclass14 = new MidiFile(fileStream);
						this.gclass120_0 = new MidiFile();
						this.gclass120_0.SetTicksPerQuarterNote(gclass14.TicksPerQuarterNote());
						GClass89 gclass15 = new GClass89(this.gclass120_0);
						gclass15.method_2("tempFoF");
						this.gclass120_0.GetTracks().Add(gclass15);
						GClass88 gclass16 = new GClass88(this.gclass120_0, "PART GUITAR");
						this.gclass120_0.GetTracks().Add(gclass16);
						List<MidiEvent> list = new List<MidiEvent>();
						List<MidiEvent> list2 = new List<MidiEvent>();
						foreach (MidiTrack gclass17 in gclass14.GetTracks())
						{
							foreach (MidiEvent gclass18 in gclass17.Events())
							{
								switch (gclass18.vmethod_2())
								{
								case GEnum63.const_1:
								case GEnum63.const_2:
									list.Add(gclass18);
									break;
								case GEnum63.const_3:
									list2.Add(gclass18);
									break;
								}
							}
						}
						list.Sort(new GClass138());
						list2.Sort(new GClass138());
						gclass15.Events().AddRange(list);
						gclass16.vmethod_0(list2);
					}
					catch
					{
						throw new Exception("Failed to load notes");
					}
					fileStream.Close();
				}
			}
			IL_1058:
			foreach (MidiTrack gclass19 in this.gclass120_0.GetTracks())
			{
				if (gclass19 is GClass88)
				{
					for (int j = 0; j < 4; j++)
					{
						if ((gclass19 as GClass88).method_13((GEnum53)j).Count != 0)
						{
							MidImportDialog.Class30 @class = new MidImportDialog.Class30();
							@class.genum53_0 = (GEnum53)j;
							@class.gclass88_0 = (gclass19 as GClass88);
							this.list_0.Add(@class);
						}
					}
				}
			}
			GClass49 gclass20 = new GClass49();
			gclass20.method_44().Add("Empty");
			foreach (MidImportDialog.Class30 item4 in this.list_0)
			{
				gclass20.method_44().Add(item4);
			}
			this.gclass20_0.method_24(gclass20);
			this.gclass20_1.method_24(gclass20);
			this.gclass20_2.method_24(gclass20);
			this.gclass20_3.method_24(gclass20);
			foreach (MidiTrack gclass21 in gclass.GetTracks())
			{
				if (gclass21 is GClass88)
				{
					GClass83 gclass22 = new GClass83();
					gclass22.method_9().method_0(new GClass97(gclass21.method_1()));
					for (int k = 3; k >= 0; k--)
					{
						GEnum53 genum = (GEnum53)k;
						MidImportDialog.Class30 class2 = null;
						foreach (MidImportDialog.Class30 class3 in this.list_0)
						{
							bool flag8 = class3.genum53_0 == genum;
							if ((string.Compare(class3.gclass88_0.method_1(), gclass21.method_1(), true) == 0 || (string.Compare(class3.gclass88_0.method_1(), "T1 GEMS", true) == 0 && string.Compare(gclass21.method_1(), "PART GUITAR", true) == 0)) && flag8)
							{
								class2 = class3;
							}
						}
						GClass97 gclass23 = new GClass97();
						gclass23.method_0(new GDelegate7(this.method_1));
						if (class2 != null)
						{
							gclass23.method_6(class2.ToString());
							gclass23.method_10(class2);
						}
						else
						{
							gclass23.method_6("Empty");
						}
						gclass22.method_9().method_0(gclass23);
					}
					this.tblTracks.method_239().method_12().method_0(gclass22);
				}
			}
			GEnum54 genum2 = this.gclass120_0.method_3();
			if (genum2 == GEnum54.const_1)
			{
				MidImportDialog.smethod_0(this.gclass120_0, this.list_1);
				if (this.genum54_0 == GEnum54.const_2)
				{
					this.method_6(this.gclass120_0, this.list_1);
				}
			}
			else if (genum2 == GEnum54.const_2)
			{
				MidImportDialog.smethod_1(this.gclass120_0, this.list_1, true);
				if (this.genum54_0 != GEnum54.const_2)
				{
					this.list_1.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_2, "Can't convert from Guitar Hero 2 to Guitar Hero 1"));
				}
			}
		}
		catch (Exception ex2)
		{
			string[] array5 = ex2.Message.Split(new char[]
			{
				'\n'
			});
			int num14 = 0;
			foreach (string string_3 in array5)
			{
				MidImportDialog.GClass75 gclass24 = new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_2, string_3);
				if (num14 > 0)
				{
					gclass24.int_0 = 1;
				}
				this.list_1.Add(gclass24);
				num14++;
			}
		}
		stream.Close();
		ListViewGroup group = this.lvIssues.Groups.Add("Import", "Import");
		this.lvIssues.BeginUpdate();
		foreach (MidImportDialog.GClass75 gclass25 in this.list_1)
		{
			if (gclass25.genum33_0 == MidImportDialog.GEnum33.const_2)
			{
				this.bool_0 = false;
			}
			ListViewItem listViewItem;
			if (gclass25.string_1 != null)
			{
				ListViewGroup listViewGroup = null;
				foreach (object obj2 in this.lvIssues.Groups)
				{
					ListViewGroup listViewGroup2 = (ListViewGroup)obj2;
					if (listViewGroup2.Name == gclass25.string_1)
					{
						listViewGroup = listViewGroup2;
						break;
					}
				}
				if (listViewGroup == null)
				{
					listViewGroup = this.lvIssues.Groups.Add(gclass25.string_1, gclass25.string_1);
				}
				listViewItem = new ListViewItem(gclass25.string_0, (int)gclass25.genum33_0, listViewGroup);
			}
			else
			{
				listViewItem = new ListViewItem(gclass25.string_0, (int)gclass25.genum33_0, group);
			}
			if (gclass25.int_0 > 0)
			{
				listViewItem.IndentCount = gclass25.int_0;
				listViewItem.ImageIndex = -1;
			}
			this.lvIssues.Items.Add(listViewItem);
		}
		this.lvIssues.EndUpdate();
		if (this.list_1.Count == 0)
		{
			this.lvIssues.Items.Add(new ListViewItem("No issues found..", 0, group));
		}
		this.bool_1 = true;
		this.method_0();
		this.bool_1 = false;
	}

	void method_0()
	{
		bool flag = false;
		foreach (object obj in this.tblTracks.method_239().method_12())
		{
			GClass83 gclass = (GClass83)obj;
			foreach (object obj2 in gclass.method_9())
			{
				GClass97 gclass2 = (GClass97)obj2;
				if (!(gclass2.method_9() is MidImportDialog.Class30))
				{
					if (!flag)
					{
						continue;
					}
				}
				else
				{
					flag = true;
				}
				break;
			}
		}
		this.btnOk.Enabled = (this.bool_0 && flag);
	}

	void method_1(object sender, GEventArgs1 e)
	{
		if (this.bool_1)
		{
			return;
		}
		this.method_0();
	}

	void method_2(object sender, GEventArgs5 e)
	{
		if (e.method_6() is GClass49)
		{
			GClass49 gclass = e.method_6() as GClass49;
			gclass.method_50(e.method_0().method_9());
		}
	}

	void method_3(object sender, GEventArgs5 e)
	{
		if (e.method_6() is GClass49)
		{
			GClass49 gclass = e.method_6() as GClass49;
			e.method_0().method_10(gclass.method_49());
		}
	}

	void method_4(GClass88 gclass88_0)
	{
		for (int i = 0; i < 4; i++)
		{
			List<MidiEvent> list = gclass88_0.method_13((GEnum53)i);
			bool flag = false;
			foreach (MidiEvent gclass in list)
			{
				if (gclass.vmethod_2() == GEnum63.const_4)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				GClass145 gclass2 = new GClass145(gclass88_0);
				gclass2.int_0 = 0;
				gclass2.vmethod_1(gclass88_0.Parent().TicksPerQuarterNote() / 4);
				gclass2.bool_0 = true;
				gclass2.list_0.Add(GEnum51.const_2);
				list.Insert(0, gclass2);
			}
		}
	}

	public void method_5(ref ProgressDialog.GClass73 gclass73_0)
	{
		MidImportDialog.Class31 @class = new MidImportDialog.Class31();
		lock (gclass73_0)
		{
			gclass73_0.string_1 = "Creating MIDI";
		}
		MidiFile gclass = new MidiFile();
		gclass.SetTicksPerQuarterNote(this.gclass120_0.TicksPerQuarterNote());
		gclass.GetTracks().Add(this.gclass120_0.GetTracks()[0]);
		@class.list_0 = new List<string>();
		@class.list_0.Add(gclass.GetTracks()[0].method_1());
		switch (this.genum54_0)
		{
		case GEnum54.const_1:
			@class.list_0.AddRange(this.list_2);
			break;
		case GEnum54.const_2:
			@class.list_0.AddRange(this.list_3);
			break;
		default:
			throw new Exception("Unknown MIDI version");
		}
		foreach (object obj2 in this.tblTracks.method_239().method_12())
		{
			GClass83 gclass2 = (GClass83)obj2;
			GClass88 gclass3 = gclass.FindTrackByName(gclass2.method_9().method_9(0).method_5()) as GClass88;
			if (gclass3 == null)
			{
				gclass3 = new GClass88(gclass, gclass2.method_9().method_9(0).method_5());
				gclass.GetTracks().Add(gclass3);
			}
			GClass88 gclass4 = null;
			foreach (object obj3 in gclass2.method_9())
			{
				GClass97 gclass5 = (GClass97)obj3;
				MidImportDialog.Class30 class2 = gclass5.method_9() as MidImportDialog.Class30;
				if (class2 != null)
				{
					if (gclass4 == null && class2.gclass88_0.Events().Count > 0)
					{
						gclass4 = class2.gclass88_0;
					}
					GEnum53 genum53_ = (GEnum53)4 - gclass5.method_50();
					gclass3.method_13(genum53_).Clear();
					gclass3.method_13(genum53_).AddRange(class2.gclass88_0.method_13(class2.genum53_0));
				}
			}
			if (gclass4 != null)
			{
				gclass3.Events().AddRange(gclass4.Events());
			}
		}
		foreach (MidiTrack gclass6 in this.gclass120_0.GetTracks())
		{
			if (this.gclass120_0.GetTracks().IndexOf(gclass6) != 0 && @class.list_0.Contains(gclass6.method_1()) && !(gclass6 is GClass88))
			{
				gclass.GetTracks().Add(gclass6);
			}
		}
		lock (gclass73_0)
		{
			gclass73_0.int_0 = 33;
		}
		gclass.GetTracks().Sort(new Comparison<MidiTrack>(@class.method_0));
		foreach (MidiTrack gclass7 in gclass.GetTracks())
		{
			if (gclass7 is GClass88)
			{
				this.method_4(gclass7 as GClass88);
			}
		}
		lock (gclass73_0)
		{
			gclass73_0.int_0 = 66;
		}
		List<MidImportDialog.GClass75> list = new List<MidImportDialog.GClass75>();
		switch (gclass.method_3())
		{
		case GEnum54.const_1:
			MidImportDialog.smethod_0(gclass, list);
			break;
		case GEnum54.const_2:
			MidImportDialog.smethod_1(gclass, list, false);
			break;
		default:
			throw new Exception("Bad MIDI after import");
		}
		foreach (MidImportDialog.GClass75 gclass8 in list)
		{
			if (gclass8.genum33_0 == MidImportDialog.GEnum33.const_2)
			{
				throw new Exception("Error after conversion:\n" + gclass8.string_0);
			}
		}
		MemoryStream memoryStream = new MemoryStream(10240);
		gclass.method_7(memoryStream);
		lock (gclass73_0)
		{
			gclass73_0.int_0 = 100;
		}
		memoryStream.Seek(0L, SeekOrigin.Begin);
		this.gclass126_0.GetArk().method_22(this.gclass126_0, memoryStream, ref gclass73_0);
		memoryStream.Close();
	}

	public static void smethod_0(MidiFile gclass120_1, List<MidImportDialog.GClass75> list_14)
	{
		List<MidiEvent> list = new List<MidiEvent>();
		GClass87 gclass = gclass120_1.FindTrackByName("ANIM") as GClass87;
		if (gclass != null)
		{
			foreach (MidiEvent gclass2 in gclass.Events())
			{
				GEnum63 genum = gclass2.vmethod_2();
				if (genum != GEnum63.const_0)
				{
					if (genum == GEnum63.const_8)
					{
						GClass144 gclass3 = gclass2 as GClass144;
						if ((gclass3.int_2 < 40 || gclass3.int_2 > 58) && gclass3.int_2 != 60)
						{
							list.Add(gclass2);
							list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass.method_1(), string.Concat(new object[]
							{
								"Ignoring unsupported trigger ",
								gclass3.int_2,
								" at ",
								Class109.smethod_2((float)gclass120_1.method_5(gclass3.int_0))
							})));
						}
					}
					else
					{
						list.Add(gclass2);
						list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass.method_1(), string.Concat(new object[]
						{
							"Ignoring unsupported event of type ",
							(int)gclass2.vmethod_2(),
							" at ",
							Class109.smethod_2((float)gclass120_1.method_5(gclass2.int_0))
						})));
					}
				}
				else
				{
					GClass140 gclass4 = gclass2 as GClass140;
					if (gclass4.string_0.StartsWith("HandMap_"))
					{
						if (!MidImportDialog.list_4.Contains(gclass4.string_0.Substring(8)))
						{
							list.Add(gclass2);
							list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass.method_1(), "Ignoring unsupported HandMap: \"" + gclass4.string_0.Substring(8) + "\" at " + Class109.smethod_2((float)gclass120_1.method_5(gclass4.int_0))));
						}
					}
					else
					{
						list.Add(gclass2);
						list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass.method_1(), "Ignoring unsupported trigger: \"" + gclass4.string_0 + "\" at " + Class109.smethod_2((float)gclass120_1.method_5(gclass4.int_0))));
					}
				}
			}
			list.Clear();
		}
		else
		{
			gclass = new GClass87(gclass120_1, "ANIM");
			gclass120_1.GetTracks().Add(gclass);
			list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_0, "Added empty \"ANIM\" track"));
		}
		GClass88 gclass5 = gclass120_1.FindTrackByName("T1 GEMS") as GClass88;
		if (gclass5 != null)
		{
			foreach (MidiEvent gclass6 in gclass5.Events())
			{
				GEnum63 genum2 = gclass6.vmethod_2();
				if (genum2 != GEnum63.const_0)
				{
					switch (genum2)
					{
					case GEnum63.const_5:
					case GEnum63.const_6:
					case GEnum63.const_7:
						break;
					default:
						list.Add(gclass6);
						list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass5.method_1(), string.Concat(new object[]
						{
							"Ignoring unsupported event of type ",
							(int)gclass6.vmethod_2(),
							" at ",
							Class109.smethod_2((float)gclass120_1.method_5(gclass6.int_0))
						})));
						break;
					}
				}
				else
				{
					list.Add(gclass6);
					list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass5.method_1(), "Ignoring text event: \"" + (gclass6 as GClass140).string_0 + "\" at " + Class109.smethod_2((float)gclass120_1.method_5(gclass6.int_0))));
				}
			}
			list.Clear();
		}
		else
		{
			list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_2, "Missing notes track (\"T1 GEMS\")"));
		}
		GClass87 gclass7 = gclass120_1.FindTrackByName("TRIGGERS") as GClass87;
		if (gclass7 != null)
		{
			foreach (MidiEvent gclass8 in gclass7.Events())
			{
				GEnum63 genum3 = gclass8.vmethod_2();
				if (genum3 != GEnum63.const_0)
				{
					if (genum3 == GEnum63.const_8)
					{
						GClass144 gclass9 = gclass8 as GClass144;
						if (gclass9.int_2 < 60 || gclass9.int_2 > 61)
						{
							list.Add(gclass8);
							list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass7.method_1(), string.Concat(new object[]
							{
								"Ignoring unknown trigger: ",
								gclass9.int_2,
								" at ",
								Class109.smethod_2((float)gclass120_1.method_5(gclass9.int_0))
							})));
						}
					}
					else
					{
						list.Add(gclass8);
						list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass7.method_1(), string.Concat(new object[]
						{
							"Ignoring unsupported event of type ",
							(int)gclass8.vmethod_2(),
							" at ",
							Class109.smethod_2((float)gclass120_1.method_5(gclass8.int_0))
						})));
					}
				}
				else
				{
					list.Add(gclass8);
					list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass7.method_1(), "Ignoring text event: \"" + (gclass8 as GClass140).string_0 + "\" at " + Class109.smethod_2((float)gclass120_1.method_5(gclass8.int_0))));
				}
			}
			foreach (MidiEvent item in list)
			{
				gclass7.Events().Remove(item);
			}
			list.Clear();
		}
		else
		{
			gclass7 = new GClass87(gclass120_1, "TRIGGERS");
			gclass120_1.GetTracks().Add(gclass7);
			list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_0, "Added empty \"TRIGGERS\" track"));
		}
		bool flag = true;
		GClass87 gclass10 = gclass120_1.FindTrackByName("EVENTS") as GClass87;
		if (gclass10 != null)
		{
			foreach (MidiEvent gclass11 in gclass10.Events())
			{
				GEnum63 genum4 = gclass11.vmethod_2();
				if (genum4 != GEnum63.const_0)
				{
					if (genum4 != GEnum63.const_8)
					{
						list.Add(gclass11);
						list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass10.method_1(), string.Concat(new object[]
						{
							"Ignoring unsupported event of type ",
							(int)gclass11.vmethod_2(),
							" at ",
							Class109.smethod_2((float)gclass120_1.method_5(gclass11.int_0))
						})));
					}
					else
					{
						if (flag)
						{
							list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass10.method_1(), "Ignoring all trigger notes in \"EVENTS\""));
						}
						flag = false;
						list.Add(gclass11);
					}
				}
				else
				{
					GClass140 gclass12 = gclass11 as GClass140;
					if (gclass12.string_0.StartsWith("StrumMap_"))
					{
						if (!MidImportDialog.list_5.Contains(gclass12.string_0.Substring(9)))
						{
							list.Add(gclass11);
							list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass10.method_1(), "Ignoring unsupported StrumMap: \"" + gclass12.string_0.Substring(9) + "\" at " + Class109.smethod_2((float)gclass120_1.method_5(gclass12.int_0))));
						}
					}
					else if (!MidImportDialog.list_6.Contains(gclass12.string_0))
					{
						list.Add(gclass11);
						list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass10.method_1(), "Ignoring text event: \"" + gclass12.string_0 + "\" at " + Class109.smethod_2((float)gclass120_1.method_5(gclass12.int_0))));
					}
				}
			}
			foreach (MidiEvent item2 in list)
			{
				gclass10.Events().Remove(item2);
			}
			list.Clear();
			return;
		}
		gclass10 = new GClass87(gclass120_1, "EVENTS");
		gclass120_1.GetTracks().Add(gclass10);
		list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_0, "Added empty \"EVENTS\" track"));
	}

	void method_6(MidiFile gclass120_1, List<MidImportDialog.GClass75> list_14)
	{
		List<MidiEvent> list = new List<MidiEvent>();
		GClass88 gclass = gclass120_1.FindTrackByName("T1 GEMS") as GClass88;
		GClass145 gclass2 = null;
		if (gclass != null)
		{
			gclass.method_2("PART GUITAR");
			foreach (MidiEvent gclass3 in gclass.Events())
			{
				GEnum63 genum = gclass3.vmethod_2();
				if (genum == GEnum63.const_7)
				{
					list.Add(gclass3);
				}
			}
			foreach (MidiEvent item in list)
			{
				gclass.Events().Remove(item);
			}
			list.Clear();
			for (int i = 0; i < 4; i++)
			{
				foreach (MidiEvent gclass4 in gclass.method_13((GEnum53)i))
				{
					if (gclass4.vmethod_2() == GEnum63.const_4 && (gclass2 == null || gclass4.int_0 < gclass2.int_0))
					{
						gclass2 = (gclass4 as GClass145);
					}
				}
			}
		}
		GClass87 gclass5 = gclass120_1.FindTrackByName("ANIM") as GClass87;
		if (gclass5 != null)
		{
			foreach (MidiEvent gclass6 in gclass5.Events())
			{
				GEnum63 genum2 = gclass6.vmethod_2();
				if (genum2 != GEnum63.const_0)
				{
					if (genum2 == GEnum63.const_8)
					{
						GClass144 gclass7 = gclass6 as GClass144;
						if (gclass7.int_2 >= 40 || gclass7.int_2 <= 59)
						{
							gclass.Events().Add(gclass7);
							list.Add(gclass7);
						}
					}
				}
				else
				{
					GClass140 gclass8 = gclass6 as GClass140;
					if (gclass8.string_0.StartsWith("HandMap_") && MidImportDialog.list_4.Contains(gclass8.string_0.Substring(8)))
					{
						gclass.Events().Add(gclass8);
						list.Add(gclass8);
					}
				}
			}
			foreach (MidiEvent item2 in list)
			{
				gclass5.Events().Remove(item2);
			}
			list.Clear();
		}
		bool flag = true;
		GClass140 gclass9 = null;
		GClass87 gclass10 = gclass120_1.FindTrackByName("EVENTS") as GClass87;
		if (gclass10 != null)
		{
			List<GClass140> list2 = new List<GClass140>();
			List<MidiEvent> list3 = new List<MidiEvent>();
			foreach (MidiEvent gclass11 in gclass10.Events())
			{
				GClass140 gclass12 = gclass11 as GClass140;
				if (gclass12 != null)
				{
					if (gclass12.string_0.StartsWith("StrumMap_"))
					{
						if (flag)
						{
							list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_0, gclass10.method_1(), "Ignoring StrumMaps for the guitar at " + Class109.smethod_2((float)gclass120_1.method_5(gclass12.int_0))));
						}
						flag = false;
						list.Add(gclass11);
					}
					else
					{
						int num = MidImportDialog.list_6.IndexOf(gclass12.string_0);
						MidiTrack gclass13 = null;
						if (num == -1)
						{
							list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass10.method_1(), "Don't know how to translate \"" + gclass12.string_0 + "\""));
						}
						else if (gclass12.string_0.StartsWith("bass_"))
						{
							gclass13 = gclass120_1.FindTrackByName("BAND BASS");
							if (gclass13 == null)
							{
								gclass13 = new GClass87(gclass120_1, "BAND BASS");
								gclass120_1.GetTracks().Add(gclass13);
							}
						}
						else if (gclass12.string_0.StartsWith("drum_"))
						{
							gclass13 = gclass120_1.FindTrackByName("BAND DRUMS");
							if (gclass13 == null)
							{
								gclass13 = new GClass87(gclass120_1, "BAND DRUMS");
								gclass120_1.GetTracks().Add(gclass13);
							}
						}
						else if (!gclass12.string_0.StartsWith("gtr_") && !gclass12.string_0.StartsWith("solo_") && !gclass12.string_0.StartsWith("wail_"))
						{
							if (gclass12.string_0.StartsWith("keys_"))
							{
								gclass13 = gclass120_1.FindTrackByName("BAND KEYS");
								if (gclass13 == null)
								{
									gclass13 = new GClass87(gclass120_1, "BAND KEYS");
									gclass120_1.GetTracks().Add(gclass13);
								}
							}
							else if (gclass12.string_0.StartsWith("sing_"))
							{
								gclass13 = gclass120_1.FindTrackByName("BAND SINGER");
								if (gclass13 == null)
								{
									gclass13 = new GClass87(gclass120_1, "BAND SINGER");
									gclass120_1.GetTracks().Add(gclass13);
								}
							}
							else
							{
								GClass140 gclass14 = new GClass140(gclass12.int_0, gclass12.genum64_0, MidImportDialog.string_1[num]);
								if (gclass14.string_0.Equals("end"))
								{
									gclass9 = gclass14;
								}
								if (!gclass14.string_0.Equals("bridge"))
								{
									list3.Add(gclass14);
								}
								if (gclass14.string_0.Equals("verse") || gclass14.string_0.Equals("bridge") || gclass14.string_0.Equals("chorus") || gclass14.string_0.Equals("solo"))
								{
									list2.Add(gclass14);
								}
							}
						}
						else
						{
							gclass13 = gclass120_1.FindTrackByName("PART GUITAR");
						}
						if (gclass13 != null)
						{
							gclass13.Events().Add(new GClass140(gclass12.int_0, gclass12.genum64_0, MidImportDialog.string_1[num]));
						}
						list.Add(gclass12);
					}
				}
			}
			foreach (MidiEvent item3 in list)
			{
				gclass10.Events().Remove(item3);
			}
			list.Clear();
			foreach (MidiEvent item4 in list3)
			{
				gclass10.Events().Add(item4);
			}
			list3.Clear();
			int[] array = new int[4];
			int[] array2 = array;
			int num2 = 0;
			int num3 = -1;
			GClass140 gclass15 = null;
			GClass140 gclass16 = null;
			foreach (GClass140 gclass17 in list2)
			{
				int num4 = 0;
				string text = gclass17.string_0;
				if (text == "verse")
				{
					num4 = 0;
				}
				else if (text == "bridge")
				{
					num4 = 1;
				}
				else if (text == "chorus")
				{
					num4 = 2;
				}
				else if (text == "solo")
				{
					num4 = 3;
				}
				if (num4 != num3)
				{
					array2[num4]++;
				}
				GClass140 gclass18 = new GClass140(gclass17.int_0, GEnum64.const_0, string.Concat(new object[]
				{
					"section ",
					text,
					"_",
					array2[num4]
				}));
				gclass10.Events().Add(gclass18);
				if (gclass15 == null)
				{
					gclass15 = gclass18;
				}
				if (gclass16 != null && (num4 == num3 || num2 > 0))
				{
					GClass140 gclass19 = gclass16;
					gclass19.string_0 += (char)(97 + num2++);
				}
				if (num4 != num3)
				{
					num2 = 0;
				}
				gclass16 = gclass18;
				num3 = num4;
			}
			if (gclass2 != null && gclass15 != null && gclass2.int_0 < gclass15.int_0)
			{
				GClass140 item5 = new GClass140(gclass2.int_0 / gclass120_1.TicksPerQuarterNote() * gclass120_1.TicksPerQuarterNote(), GEnum64.const_0, "section intro");
				gclass10.Events().Add(item5);
			}
		}
		GClass87 gclass20 = gclass120_1.FindTrackByName("TRIGGERS") as GClass87;
		if (gclass20 != null)
		{
			GClass87 gclass21 = gclass120_1.FindTrackByName("BAND DRUMS") as GClass87;
			GClass87 gclass22 = gclass120_1.FindTrackByName("BAND BASS") as GClass87;
			foreach (MidiEvent gclass23 in gclass20.Events())
			{
				GClass144 gclass24 = gclass23 as GClass144;
				list.Add(gclass24);
				if (gclass24 != null)
				{
					if (gclass24.int_2 == 60)
					{
						if (gclass21 == null)
						{
							gclass21 = new GClass87(gclass120_1, "BAND DRUMS");
							gclass120_1.GetTracks().Add(gclass21);
						}
						gclass21.Events().Add(new GClass144(gclass24.int_0, gclass24.vmethod_0(), 36));
					}
					else if (gclass24.int_2 == 61)
					{
						if (gclass22 == null)
						{
							gclass22 = new GClass87(gclass120_1, "BAND BASS");
							gclass120_1.GetTracks().Add(gclass22);
						}
						gclass22.Events().Add(new GClass144(gclass24.int_0, gclass24.vmethod_0(), 36));
					}
				}
			}
			foreach (MidiEvent item6 in list)
			{
				gclass20.Events().Remove(item6);
			}
			gclass20.Events().Clear();
		}
		int j = 1;
		while (j < gclass120_1.GetTracks().Count)
		{
			if (!this.list_3.Contains(gclass120_1.GetTracks()[j].method_1()))
			{
				gclass120_1.GetTracks().Remove(gclass120_1.GetTracks()[j]);
			}
			else
			{
				j++;
			}
		}
		if (gclass9 == null)
		{
			MidImportDialog.smethod_3(gclass120_1, list_14, true);
		}
		else
		{
			int num5 = MidImportDialog.smethod_2(gclass120_1);
			if (gclass9.int_0 < num5 - gclass120_1.TicksPerQuarterNote() * 4)
			{
				list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, "An end event is present but maybe too early, at " + Class109.smethod_2((float)gclass120_1.method_5(gclass9.int_0)) + ", when actual end might be at " + Class109.smethod_2((float)gclass120_1.method_5(num5))));
			}
		}
		foreach (MidiTrack gclass25 in gclass120_1.GetTracks())
		{
			gclass25.Events().Sort(new GClass138());
		}
	}

	public static void smethod_1(MidiFile gclass120_1, List<MidImportDialog.GClass75> list_14, bool bool_2)
	{
		List<MidiEvent> list = new List<MidiEvent>();
		if (gclass120_1.GetTracks().Count == 0 || !(gclass120_1.GetTracks()[0] is GClass89))
		{
			list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_2, "Missing tempo track"));
			return;
		}
		if (gclass120_1.FindTrackByName("PART GUITAR") == null)
		{
			list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_2, "Missing \"PART GUITAR\" track"));
			return;
		}
		foreach (MidiTrack gclass in gclass120_1.GetTracks())
		{
			if (gclass.method_1().StartsWith("BAND "))
			{
				foreach (MidiEvent gclass2 in gclass.Events())
				{
					GEnum63 genum = gclass2.vmethod_2();
					if (genum != GEnum63.const_0)
					{
						if (genum != GEnum63.const_8)
						{
							list.Add(gclass2);
							list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass.method_1(), string.Concat(new object[]
							{
								"Ignoring unsupported event of type ",
								(int)gclass2.vmethod_2(),
								" at ",
								Class109.smethod_2((float)gclass120_1.method_5(gclass2.int_0))
							})));
						}
						else if (gclass.method_1() == "BAND BASS")
						{
							if (!MidImportDialog.list_8.Contains(((GClass144)gclass2).int_2))
							{
								list.Add(gclass2);
								list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass.method_1(), string.Concat(new object[]
								{
									"Ignoring unsupported bass trigger: ",
									((GClass144)gclass2).int_2,
									" at ",
									Class109.smethod_2((float)gclass120_1.method_5(gclass2.int_0))
								})));
							}
						}
						else if (gclass.method_1() == "BAND DRUMS")
						{
							if (!MidImportDialog.list_9.Contains(((GClass144)gclass2).int_2))
							{
								list.Add(gclass2);
								list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass.method_1(), string.Concat(new object[]
								{
									"Ignoring unsupported drums trigger: ",
									((GClass144)gclass2).int_2,
									" at ",
									Class109.smethod_2((float)gclass120_1.method_5(gclass2.int_0))
								})));
							}
						}
						else
						{
							list.Add(gclass2);
							list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass.method_1(), string.Concat(new object[]
							{
								"Ignoring unsupported trigger ",
								((GClass144)gclass2).int_2,
								" in ",
								gclass.method_1(),
								" at ",
								Class109.smethod_2((float)gclass120_1.method_5(gclass2.int_0))
							})));
						}
					}
					else if (!MidImportDialog.list_7.Contains(((GClass140)gclass2).string_0))
					{
						list.Add(gclass2);
						list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass.method_1(), "Ignoring unsupported text trigger: \"" + ((GClass140)gclass2).string_0 + "\" at " + Class109.smethod_2((float)gclass120_1.method_5(gclass2.int_0))));
					}
				}
				foreach (MidiEvent item in list)
				{
					gclass.Events().Remove(item);
				}
				list.Clear();
			}
		}
		foreach (MidiTrack gclass3 in gclass120_1.GetTracks())
		{
			if (gclass3.method_1().StartsWith("PART "))
			{
				foreach (MidiEvent gclass4 in gclass3.Events())
				{
					GEnum63 genum2 = gclass4.vmethod_2();
					if (genum2 != GEnum63.const_0)
					{
						if (genum2 != GEnum63.const_8)
						{
							list.Add(gclass4);
							list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass3.method_1(), string.Concat(new object[]
							{
								"Ignoring unsupported event of type ",
								(int)gclass4.vmethod_2(),
								" at ",
								Class109.smethod_2((float)gclass120_1.method_5(gclass4.int_0))
							})));
						}
						else
						{
							GClass144 gclass5 = (GClass144)gclass4;
							bool flag = false;
							if (gclass5.int_2 < 40 || gclass5.int_2 > 59)
							{
								if (gclass3.method_1() == "PART BASS")
								{
									if (gclass5.int_2 != 39 && gclass5.int_2 != 110)
									{
										flag = true;
									}
								}
								else if (gclass3.method_1() == "PART GUITAR")
								{
									if (gclass5.int_2 != 35 && gclass5.int_2 != 38 && gclass5.int_2 != 39 && gclass5.int_2 != 110)
									{
										flag = true;
									}
								}
								else if (gclass3.method_1() == "PART GUITAR COOP")
								{
									if (gclass5.int_2 != 38 && gclass5.int_2 != 39 && gclass5.int_2 != 110)
									{
										flag = true;
									}
								}
								else if (gclass3.method_1() == "PART RHYTHM")
								{
									if (gclass5.int_2 != 39 && gclass5.int_2 != 110 && gclass5.int_2 != 119)
									{
										flag = true;
									}
								}
								else
								{
									flag = true;
								}
							}
							if (flag)
							{
								list.Add(gclass4);
								list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass3.method_1(), string.Concat(new object[]
								{
									"Ignoring unsupported trigger: ",
									gclass5.int_2,
									" at ",
									Class109.smethod_2((float)gclass120_1.method_5(gclass5.int_0))
								})));
							}
							if (gclass5.vmethod_0() == 0)
							{
								list.Add(gclass4);
								list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass3.method_1(), string.Concat(new object[]
								{
									"Ignoring zero length trigger: ",
									gclass5.int_2,
									" at ",
									Class109.smethod_2((float)gclass120_1.method_5(gclass5.int_0))
								})));
							}
						}
					}
					else
					{
						GClass140 gclass6 = (GClass140)gclass4;
						if (gclass6.string_0.StartsWith("map "))
						{
							string text = gclass6.string_0.Substring(4);
							if (text.StartsWith("StrumMap_"))
							{
								string text2 = text.Substring(9);
								if (!MidImportDialog.list_5.Contains(text2) && text2.CompareTo("SlapBass") != 0)
								{
									list.Add(gclass4);
									list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass3.method_1(), "Ignoring unsupported StrumMap: \"" + text2 + "\" at " + Class109.smethod_2((float)gclass120_1.method_5(gclass4.int_0))));
								}
							}
							else if (text.StartsWith("HandMap_"))
							{
								string text3 = text.Substring(8);
								if (!MidImportDialog.list_4.Contains(text3))
								{
									list.Add(gclass4);
									list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass3.method_1(), "Ignoring unsupported HandMap: \"" + text3 + "\" at " + Class109.smethod_2((float)gclass120_1.method_5(gclass4.int_0))));
								}
							}
							else
							{
								list.Add(gclass4);
								list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass3.method_1(), "Ignoring unsupported map: \"" + text + "\" at " + Class109.smethod_2((float)gclass120_1.method_5(gclass4.int_0))));
							}
						}
						else if (!MidImportDialog.list_7.Contains(gclass6.string_0) && !MidImportDialog.list_10.Contains(gclass6.string_0))
						{
							list.Add(gclass4);
							list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass3.method_1(), "Ignoring unsupported text trigger: \"" + gclass6.string_0 + "\" at " + Class109.smethod_2((float)gclass120_1.method_5(gclass4.int_0))));
						}
					}
				}
				foreach (MidiEvent item2 in list)
				{
					gclass3.Events().Remove(item2);
				}
				list.Clear();
				for (int i = 0; i < 4; i++)
				{
					foreach (MidiEvent gclass7 in ((GClass88)gclass3).method_13((GEnum53)i))
					{
						switch (gclass7.vmethod_2())
						{
						case GEnum63.const_5:
							if (gclass7.vmethod_0() == 0)
							{
								list.Add(gclass7);
								list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass3.method_1(), "Ignoring zero length star power section at " + Class109.smethod_2((float)gclass120_1.method_5(gclass7.int_0))));
							}
							break;
						case GEnum63.const_6:
							if (gclass7.vmethod_0() == 0)
							{
								list.Add(gclass7);
								list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass3.method_1(), string.Concat(new object[]
								{
									"Ignoring zero length player",
									1 + ((GClass147)gclass7).int_1,
									" section at ",
									Class109.smethod_2((float)gclass120_1.method_5(gclass7.int_0))
								})));
							}
							break;
						case GEnum63.const_8:
							if (gclass7.vmethod_0() == 0)
							{
								list.Add(gclass7);
								list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass3.method_1(), string.Concat(new object[]
								{
									"Ignoring zero length trigger ",
									((GClass144)gclass7).int_2,
									" at ",
									Class109.smethod_2((float)gclass120_1.method_5(gclass7.int_0))
								})));
							}
							break;
						}
					}
					foreach (MidiEvent item3 in list)
					{
						((GClass88)gclass3).method_13((GEnum53)i).Remove(item3);
					}
					list.Clear();
				}
			}
		}
		GClass87 gclass8 = gclass120_1.FindTrackByName("TRIGGERS") as GClass87;
		if (gclass8 != null)
		{
			foreach (MidiEvent gclass9 in gclass8.Events())
			{
				GEnum63 genum3 = gclass9.vmethod_2();
				if (genum3 != GEnum63.const_0)
				{
					if (genum3 == GEnum63.const_8)
					{
						if (!MidImportDialog.list_11.Contains(((GClass144)gclass9).int_2))
						{
							list.Add(gclass9);
							list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass8.method_1(), string.Concat(new object[]
							{
								"Ignoring unsupported trigger ",
								((GClass144)gclass9).int_2,
								" at ",
								Class109.smethod_2((float)gclass120_1.method_5(gclass9.int_0))
							})));
						}
					}
					else
					{
						list.Add(gclass9);
						list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass8.method_1(), string.Concat(new object[]
						{
							"Ignoring unsupported event of type ",
							(int)gclass9.vmethod_2(),
							" at ",
							Class109.smethod_2((float)gclass120_1.method_5(gclass9.int_0))
						})));
					}
				}
				else
				{
					list.Add(gclass9);
					list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass8.method_1(), "Ignoring unsupported text trigger \"" + ((GClass140)gclass9).string_0 + "\" at " + Class109.smethod_2((float)gclass120_1.method_5(gclass9.int_0))));
				}
			}
			foreach (MidiEvent item4 in list)
			{
				gclass8.Events().Remove(item4);
			}
			list.Clear();
		}
		else
		{
			gclass120_1.GetTracks().Add(new GClass87(gclass120_1, "TRIGGERS"));
			list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_0, "Added empty TRIGGERS track"));
		}
		GClass87 gclass10 = gclass120_1.FindTrackByName("EVENTS") as GClass87;
		bool flag2 = true;
		GClass140 gclass11 = null;
		if (gclass10 != null)
		{
			foreach (MidiEvent gclass12 in gclass10.Events())
			{
				GEnum63 genum4 = gclass12.vmethod_2();
				if (genum4 != GEnum63.const_0)
				{
					if (genum4 == GEnum63.const_8)
					{
						if (flag2)
						{
							flag2 = false;
							list.Add(gclass12);
							list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass10.method_1(), "Note triggers aren't supported in EVENTS"));
						}
					}
					else
					{
						list.Add(gclass12);
						list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass10.method_1(), string.Concat(new object[]
						{
							"Ignoring unsupported event of type ",
							(int)gclass12.vmethod_2(),
							" at ",
							Class109.smethod_2((float)gclass120_1.method_5(gclass12.int_0))
						})));
					}
				}
				else
				{
					GClass140 gclass13 = (GClass140)gclass12;
					if (!gclass13.string_0.StartsWith("section "))
					{
						if (gclass13.string_0.StartsWith("lighting ("))
						{
							string text4 = gclass13.string_0.Substring(8).Trim().Trim(new char[]
							{
								'(',
								')'
							});
							if (!MidImportDialog.list_13.Contains(text4))
							{
								list.Add(gclass12);
								list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass10.method_1(), "Ignoring unsupported lighting trigger \"" + text4 + "\" at " + Class109.smethod_2((float)gclass120_1.method_5(gclass13.int_0))));
							}
						}
						else if (!MidImportDialog.list_12.Contains(gclass13.string_0))
						{
							list.Add(gclass12);
							list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, gclass10.method_1(), "Ignoring unsupported text trigger \"" + gclass13.string_0 + "\" at " + Class109.smethod_2((float)gclass120_1.method_5(gclass13.int_0))));
						}
					}
					if (gclass13.string_0.CompareTo("end") == 0)
					{
						gclass11 = gclass13;
					}
				}
			}
			foreach (MidiEvent item5 in list)
			{
				gclass10.Events().Remove(item5);
			}
			list.Clear();
		}
		else
		{
			gclass10 = new GClass87(gclass120_1, "EVENTS");
			gclass120_1.GetTracks().Add(gclass10);
			list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_0, "Added empty EVENTS track"));
		}
		if (gclass11 == null)
		{
			MidImportDialog.smethod_3(gclass120_1, list_14, bool_2);
			return;
		}
		int num = MidImportDialog.smethod_2(gclass120_1);
		if (gclass11.int_0 < num - gclass120_1.TicksPerQuarterNote() * 4)
		{
			list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_1, "An end event is present but maybe too early, at " + Class109.smethod_2((float)gclass120_1.method_5(gclass11.int_0)) + ", when actual end might be at " + Class109.smethod_2((float)gclass120_1.method_5(num))));
		}
	}

	static int smethod_2(MidiFile gclass120_1)
	{
		int num = 0;
		foreach (MidiTrack gclass in gclass120_1.GetTracks())
		{
			foreach (MidiEvent gclass2 in gclass.Events())
			{
				num = Math.Max(num, gclass2.int_0 + gclass2.vmethod_0());
			}
			if (gclass is GClass88)
			{
				for (int i = 0; i < 4; i++)
				{
					foreach (MidiEvent gclass3 in ((GClass88)gclass).method_13((GEnum53)i))
					{
						num = Math.Max(num, gclass3.int_0 + gclass3.vmethod_0());
					}
				}
			}
		}
		return num;
	}

	static void smethod_3(MidiFile gclass120_1, List<MidImportDialog.GClass75> list_14, bool bool_2)
	{
		int num = MidImportDialog.smethod_2(gclass120_1);
		if (bool_2)
		{
			int int_ = num + gclass120_1.TicksPerQuarterNote() * 6;
			gclass120_1.FindTrackByName("EVENTS").Events().Add(new GClass140(int_, GEnum64.const_0, "end"));
			list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_0, "Added missing end event at " + Class109.smethod_2((float)gclass120_1.method_5(int_))));
			return;
		}
		list_14.Add(new MidImportDialog.GClass75(MidImportDialog.GEnum33.const_2, "No end event found!"));
	}

	ArkEntry gclass126_0;

	GEnum54 genum54_0;

	MidiFile gclass120_0;

	string string_0;

	List<MidImportDialog.Class30> list_0 = new List<MidImportDialog.Class30>();

	List<MidImportDialog.GClass75> list_1 = new List<MidImportDialog.GClass75>();

	bool bool_0 = true;

	bool bool_1 = true;

	List<string> list_2 = new List<string>(new string[]
	{
		"T1 GEMS",
		"EVENTS",
		"ANIM",
		"TRIGGERS"
	});

	List<string> list_3 = new List<string>(new string[]
	{
		"PART GUITAR",
		"PART GUITAR COOP",
		"PART RHYTHM",
		"PART BASS",
		"BAND BASS",
		"BAND DRUMS",
		"BAND SINGER",
		"BAND KEYS",
		"EVENTS",
		"TRIGGERS"
	});

	static List<string> list_4 = new List<string>(new string[]
	{
		"AllChords",
		"Default",
		"DropD",
		"DropD2",
		"Linear",
		"NoChords",
		"Solo"
	});

	static List<string> list_5 = new List<string>(new string[]
	{
		"Default",
		"punk",
		"softpick"
	});

	static List<string> list_6 = new List<string>(new string[]
	{
		"bass_double_tempo",
		"bass_half_tempo",
		"bass_normal_tempo",
		"bass_off",
		"bass_on",
		"crowd_double_tempo",
		"crowd_half_tempo",
		"crowd_normal_tempo",
		"drum_allbeat",
		"drum_double",
		"drum_double_tempo",
		"drum_half",
		"drum_half_tempo",
		"drum_normal",
		"drum_normal_tempo",
		"drum_off",
		"drum_on",
		"gtr_double_tempo",
		"gtr_half_tempo",
		"gtr_normal_tempo",
		"gtr_off",
		"gtr_on",
		"keys_normal",
		"keys_off",
		"keys_on",
		"sing_double",
		"sing_double_tempo",
		"sing_half_tempo",
		"sing_normal_tempo",
		"sing_off",
		"sing_on",
		"solo_off",
		"solo_on",
		"wail_off",
		"wail_on",
		"verse",
		"bridge",
		"chorus",
		"end",
		"solo"
	});

	static string[] string_1 = new string[]
	{
		"double_tempo",
		"half_tempo",
		"normal_tempo",
		"idle",
		"play",
		"crowd_fast_tempo",
		"crowd_half_tempo",
		"crowd_normal_tempo",
		"allbeat",
		"double",
		"double",
		"half_time",
		"half_time",
		"normal_tempo",
		"normal_tempo",
		"idle",
		"play",
		"double_tempo",
		"half_tempo",
		"normal_tempo",
		"idle",
		"play",
		"normal_tempo",
		"idle",
		"play",
		"double_tempo",
		"double_tempo",
		"half_tempo",
		"normal_tempo",
		"idle",
		"play",
		"solo_off",
		"solo_on",
		"wail_off",
		"wail_on",
		"verse",
		"bridge",
		"chorus",
		"end",
		"solo"
	};

	static List<string> list_7 = new List<string>(new string[]
	{
		"idle",
		"play",
		"double_time",
		"half_time",
		"allbeat",
		"nobeat",
		"normal_tempo",
		"half_tempo",
		"double_tempo",
		"wail_on",
		"wail_off"
	});

	static List<int> list_8 = new List<int>(new int[]
	{
		36,
		40,
		41,
		43,
		44,
		45,
		46,
		47,
		48,
		49,
		52,
		60,
		61,
		62,
		67,
		72,
		73,
		74,
		75,
		79,
		84,
		85,
		86,
		87,
		88,
		91,
		96,
		97,
		98,
		99,
		100,
		103,
		119
	});

	static List<int> list_9 = new List<int>(new int[]
	{
		36,
		37,
		48,
		49,
		65
	});

	static List<string> list_10 = new List<string>(new string[]
	{
		"ow_face_on",
		"ow_face_off",
		"solo_on",
		"solo_off"
	});

	static List<int> list_11 = new List<int>(new int[]
	{
		24,
		25,
		26,
		36,
		38,
		48,
		49,
		50,
		52,
		60
	});

	static List<string> list_12 = new List<string>(new string[]
	{
		"crowd_fast_tempo",
		"crowd_half_tempo",
		"crowd_lighters_fast",
		"crowd_lighters_off",
		"crowd_lighters_slow",
		"crowd_normal_tempo",
		"music_start",
		"band_jump",
		"sync_band_jump",
		"sync_head_bang",
		"sync_wag",
		"chorus",
		"verse",
		"solo",
		"end"
	});

	static List<string> list_13 = new List<string>(new string[]
	{
		"",
		"blackout",
		"strobe",
		"flare",
		"color1",
		"color2",
		"sweep",
		"chase"
	});

	class Class30
	{
		public override string ToString()
		{
			return this.gclass88_0.method_1() + " - " + Class109.smethod_7(this.genum53_0);
		}

		public GClass88 gclass88_0;

		public GEnum53 genum53_0;
	}

	public enum GEnum33
	{
		const_0,
		const_1,
		const_2
	}

	public class GClass75
	{
		public GClass75(MidImportDialog.GEnum33 genum33_1, string string_2, string string_3)
		{
			this.string_0 = string_3;
			this.string_1 = string_2;
			this.genum33_0 = genum33_1;
		}

		public GClass75(MidImportDialog.GEnum33 genum33_1, string string_2) : this(genum33_1, null, string_2)
		{
		}

		public string string_0;

		public string string_1;

		public MidImportDialog.GEnum33 genum33_0;

		public int int_0;
	}

	[CompilerGenerated]
	sealed class Class31
	{
		public int method_0(MidiTrack gclass86_0, MidiTrack gclass86_1)
		{
			int num = this.list_0.IndexOf(gclass86_0.method_1());
			int num2 = this.list_0.IndexOf(gclass86_1.method_1());
			return num - num2;
		}

		public List<string> list_0;
	}
}
