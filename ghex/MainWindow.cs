using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

public partial class MainWindow : Form
{
	public MainWindow()
	{
		this.InitializeComponent();
		this.MinimumSize = base.Size;
		this.tslVersion.Text = "v" + Application.ProductVersion;
		this.tsbExplorer.Tag = this.arkFileList;
		this.tsbPropertyGrid.Tag = this.propertyGrid1;
		this.tsLeft.method_17(this.tsbPropertyGrid);
		this.tsLeft.method_17(this.tsbExplorer);
		if (Class61.smethod_0().method_4().ContainsKey("MainWindow"))
		{
			base.Bounds = Class61.smethod_0().method_4()["MainWindow"];
		}
		if (Class61.smethod_0().method_4().ContainsKey("MainWindowSplit"))
		{
			Rectangle rectangle = Class61.smethod_0().method_4()["MainWindowSplit"];
			this.splitContainer1.SplitterDistance = rectangle.Width;
		}
	}

	void MainWindow_Load(object sender, EventArgs e)
	{
	}

	void MainWindow_Shown(object sender, EventArgs e)
	{
		this.list_0 = new List<GClass128>();
		Class58[] array = Class61.smethod_0().method_3().ToArray();
		foreach (Class58 @class in array)
		{
			this.method_17(@class.string_0, @class.bool_0, @class.ulong_0);
		}
		this.gclass121_0.method_0(new GDelegate19(this.method_4));
		this.gclass121_0.method_2(new GDelegate19(this.method_3));
	}

	bool method_0(GClass122 gclass122_1)
	{
		if (!gclass122_1.method_0())
		{
			return false;
		}
		DialogResult dialogResult = MessageBox.Show("You've made unsaved changes to '" + gclass122_1.method_3() + "'.\nDo you want to save it first?", "Save?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
		if (dialogResult != DialogResult.Cancel)
		{
			if (dialogResult == DialogResult.Yes)
			{
				gclass122_1.method_18();
			}
			return false;
		}
		return true;
	}

	void method_1(GEventArgs11 geventArgs11_0)
	{
		GClass122 gclass = geventArgs11_0.method_0().Tag as GClass122;
		if (gclass == null)
		{
			return;
		}
		geventArgs11_0.method_3(this.method_0(gclass));
		if (geventArgs11_0.method_2())
		{
			return;
		}
		this.gclass121_0.Remove(gclass);
	}

	GClass98 method_2(GClass122 gclass122_1)
	{
		foreach (object obj in this.tsDocuments.method_35())
		{
			GClass98 gclass = (GClass98)obj;
			if (gclass.Tag == gclass122_1)
			{
				return gclass;
			}
		}
		return null;
	}

	void method_3(GClass122 gclass122_1)
	{
		GClass98 gclass98_ = this.method_2(gclass122_1);
		this.tsDocuments.method_35().vmethod_10(gclass98_);
		if (this.tsDocuments.method_35().Count == 1)
		{
			this.tsDocuments.method_32(false);
		}
		gclass122_1.Dispose();
	}

	void method_4(GClass122 gclass122_1)
	{
		GClass98 gclass = new GClass98(gclass122_1.method_3(), gclass122_1.vmethod_0());
		gclass.Tag = gclass122_1;
		int int_ = this.tsDocuments.method_35().vmethod_9(gclass);
		this.tsDocuments.method_32(true);
		this.tsDocuments.method_30(this.tsDocuments.method_35().method_18(int_));
		this.method_5(gclass122_1, gclass122_1.method_5());
		gclass122_1.method_1(new GDelegate23(this.method_6));
		gclass122_1.method_7(new GDelegate24(this.method_5));
	}

	void method_5(GClass122 gclass122_1, GClass118 gclass118_0)
	{
		this.propertyGrid1.SelectedObject = gclass118_0;
	}

	void method_6(GEventArgs14 geventArgs14_0)
	{
		GClass98 gclass = this.method_2(geventArgs14_0.gclass122_0);
		switch (geventArgs14_0.genum59_0)
		{
		case GEnum59.const_0:
		case GEnum59.const_1:
			gclass.method_15(geventArgs14_0.gclass122_0.method_3() + (geventArgs14_0.gclass122_0.method_0() ? "*" : ""));
			return;
		default:
			return;
		}
	}

	void method_7()
	{
	}

	void method_8()
	{
	}

	void method_9(TreeNode treeNode_0)
	{
		TreeNode treeNode = new TreeNode();
		treeNode.Tag = new MainWindow.Class65();
		treeNode_0.Nodes.Add(treeNode);
	}

	TreeNode method_10(TreeNode treeNode_0)
	{
		while (treeNode_0.Parent != null)
		{
			treeNode_0 = treeNode_0.Parent;
		}
		return treeNode_0;
	}

	void method_11(object object_0)
	{
		MainWindow.Class66 @class = object_0 as MainWindow.Class66;
		GClass128 gclass128_ = @class.gclass128_0;
		try
		{
			gclass128_.method_13();
		}
		catch
		{
		}
		this.method_12(@class);
	}

	void method_12(MainWindow.Class66 class66_0)
	{
		if (this.arkFileList.InvokeRequired)
		{
			if (base.IsDisposed)
			{
				return;
			}
			MainWindow.Delegate2 method = new MainWindow.Delegate2(this.method_12);
			base.Invoke(method, new object[]
			{
				class66_0
			});
			return;
		}
		else
		{
			if (class66_0.treeNode_0.TreeView.IsDisposed)
			{
				return;
			}
			class66_0.treeNode_0.Text = class66_0.treeNode_0.Text.Substring(0, class66_0.treeNode_0.Text.Length - 13);
			this.method_9(class66_0.treeNode_0);
			this.method_15(class66_0.treeNode_0);
			return;
		}
	}

	List<MainWindow.Class67> method_13(GClass128 gclass128_0, ref ProgressDialog.GClass73 gclass73_0)
	{
		List<MainWindow.Class67> list = new List<MainWindow.Class67>();
		try
		{
			lock (gclass73_0)
			{
				gclass73_0.string_0 = "Validating archive";
				gclass73_0.string_1 = "Loading archive..";
				gclass73_0.int_0 = -1;
				gclass73_0.int_1 = 0;
			}
			gclass128_0.method_13();
			GClass127 gclass = gclass128_0.method_27("config/gen/gh2.dtb");
			GEnum54 genum = (gclass.Count > 0 || gclass128_0.method_6()) ? GEnum54.const_2 : GEnum54.const_1;
			List<GClass126> list2 = new List<GClass126>(gclass128_0.method_18().Count);
			list2.AddRange(gclass128_0.method_18());
			List<GClass126> list3 = list2;
			if (MainWindow.comparison_0 == null)
			{
				MainWindow.comparison_0 = new Comparison<GClass126>(MainWindow.smethod_0);
			}
			list3.Sort(MainWindow.comparison_0);
			long num = 0L;
			long num2 = 0L;
			foreach (GClass126 gclass2 in list2)
			{
				num2 += gclass2.method_4();
			}
			int i;
			for (i = 0; i < list2.Count - 1; i++)
			{
				GClass126 gclass3 = list2[i];
				GClass126 gclass4 = list2[i + 1];
				if (gclass3.method_11() + gclass3.method_4() > gclass4.method_11() || gclass3.method_11() == gclass4.method_11())
				{
					break;
				}
			}
			if (i != list2.Count - 1)
			{
				List<GClass126> range = list2.GetRange(i, list2.Count - i);
				foreach (GClass126 gclass126_ in range)
				{
					list.Add(new MainWindow.Class67(gclass126_, "Preceeded by overlapping files"));
				}
				list2.RemoveRange(i, list2.Count - i);
			}
			DateTime now = DateTime.Now;
			i = 0;
			foreach (GClass126 gclass5 in list2)
			{
				lock (gclass73_0)
				{
					gclass73_0.string_1 = "Checking \"" + gclass5.method_6() + "\"";
					gclass73_0.int_0 = -1;
				}
				Stream stream = gclass5.method_9();
				BinaryReader binaryReader = new BinaryReader(stream);
				try
				{
					int num3 = 0;
					int num4 = 0;
					while (stream.Position < stream.Length)
					{
						if (stream.Length - stream.Position >= 8L)
						{
							if (binaryReader.ReadInt64() != 0L)
							{
								break;
							}
							num4 += 8;
							num3 += 8;
						}
						else if (stream.Length - stream.Position >= 4L)
						{
							if (binaryReader.ReadInt32() != 0)
							{
								break;
							}
							num4 += 4;
							num3 += 4;
						}
						else
						{
							if (stream.ReadByte() != 0)
							{
								break;
							}
							num4++;
							num3++;
						}
						if (num3 > 4096)
						{
							num3 = 0;
							string text = Class109.smethod_0(now, num + stream.Position, num2);
							lock (gclass73_0)
							{
								gclass73_0.int_0 = (int)(stream.Position * 100L / stream.Length);
								gclass73_0.string_2 = string.Concat(new object[]
								{
									"File ",
									1 + i,
									" of ",
									list2.Count,
									text
								});
							}
						}
					}
					if ((long)num4 == stream.Length && stream.Length > 512L)
					{
						throw new Exception("File is all zeroes");
					}
					stream.Seek(0L, SeekOrigin.Begin);
					string a = gclass5.method_5();
					if (a == "mid")
					{
						List<MidImportDialog.GClass75> list4 = new List<MidImportDialog.GClass75>();
						GClass120 gclass6 = new GClass120(stream);
						if (gclass6.method_3() == GEnum54.const_1)
						{
							MidImportDialog.smethod_0(gclass6, list4);
						}
						else
						{
							if (gclass6.method_3() != GEnum54.const_2)
							{
								goto IL_467;
							}
							MidImportDialog.smethod_1(gclass6, list4, false);
						}
						if (gclass6.method_3() != genum)
						{
							throw new Exception("Wrong song version");
						}
						using (List<MidImportDialog.GClass75>.Enumerator enumerator4 = list4.GetEnumerator())
						{
							while (enumerator4.MoveNext())
							{
								MidImportDialog.GClass75 gclass7 = enumerator4.Current;
								if (gclass7.genum33_0 == MidImportDialog.GEnum33.const_2)
								{
									throw new Exception(gclass7.string_0);
								}
							}
							goto IL_4AC;
						}
						IL_467:
						throw new Exception("Unknown song version");
					}
					if (a == "vgs")
					{
						Class39.Struct2 @struct = Class39.smethod_0(binaryReader);
						if (@struct.uint_0 != 559114070u || @struct.uint_1 != 2u)
						{
							throw new Exception("Invalid VGS file");
						}
					}
					IL_4AC:
					goto IL_53F;
				}
				catch (Exception ex)
				{
					list.Add(new MainWindow.Class67(gclass5, ex.Message));
					goto IL_53F;
				}

                IL_4C9:
                string text2;
				ProgressDialog.GClass73 obj4;
                
                try
				{
					gclass73_0.int_1 = (int)(num * 100L / num2);
					gclass73_0.string_2 = string.Concat(new object[]
					{
						"File ",
						1 + i,
						" of ",
						list2.Count,
						text2
					});
				}
				finally
				{
					Monitor.Exit(obj4);
				}
				i++;
				continue;
				IL_53F:
				num += stream.Length;
				binaryReader.Close();
				text2 = Class109.smethod_0(now, num, num2);
				Monitor.Enter(obj4 = gclass73_0);
				goto IL_4C9;
			}
			if (list.Count == 0)
			{
				gclass128_0.method_5(true);
			}
		}
		catch (Exception ex2)
		{
			MessageBox.Show(ex2.Message);
			gclass128_0.method_5(false);
		}
		return list;
	}

	void method_14(TreeNode treeNode_0, GClass128 gclass128_0)
	{
		treeNode_0.TreeView.BeginUpdate();
		string text = Class109.smethod_6(treeNode_0);
		foreach (GClass126 gclass in gclass128_0.method_18())
		{
			if (gclass.method_7().StartsWith(text, true, CultureInfo.CurrentUICulture))
			{
				if (string.Compare(text, gclass.method_7(), true) == 0)
				{
					TreeNode treeNode = treeNode_0.Nodes.Add(gclass.method_6());
					treeNode.Tag = gclass;
					treeNode.Name = gclass.method_6();
					string key;
					if ((key = gclass.method_5()) == null)
					{
						goto IL_1F7;
					}
					if (Class120.dictionary_1 == null)
					{
						Class120.dictionary_1 = new Dictionary<string, int>(15)
						{
							{
								"dtb",
								0
							},
							{
								"vgs",
								1
							},
							{
								"mogg",
								2
							},
							{
								"pss",
								3
							},
							{
								"ipu",
								4
							},
							{
								"bmp",
								5
							},
							{
								"bmp_ps2",
								6
							},
							{
								"bmp_xbox",
								7
							},
							{
								"png",
								8
							},
							{
								"png_ps2",
								9
							},
							{
								"png_xbox",
								10
							},
							{
								"gh",
								11
							},
							{
								"rnd_ps2",
								12
							},
							{
								"milo_ps2",
								13
							},
							{
								"milo_xbox",
								14
							}
						};
					}
					int num;
					if (!Class120.dictionary_1.TryGetValue(key, out num))
					{
						goto IL_1F7;
					}
					switch (num)
					{
					case 0:
						treeNode.ImageIndex = 5;
						break;
					case 1:
					case 2:
						treeNode.ImageIndex = 7;
						break;
					case 3:
						treeNode.ImageIndex = 8;
						break;
					case 4:
						treeNode.ImageIndex = 9;
						break;
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:
					case 10:
						treeNode.ImageIndex = 10;
						break;
					case 11:
					case 12:
					case 13:
					case 14:
						treeNode.ImageIndex = 12;
						this.method_9(treeNode);
						break;
					default:
						goto IL_1F7;
					}
					IL_1FE:
					treeNode.SelectedImageIndex = treeNode.ImageIndex;
					continue;
					IL_1F7:
					treeNode.ImageIndex = 2;
					goto IL_1FE;
				}
				string text2 = gclass.method_7().Substring(text.Length);
				if (text2.StartsWith("/"))
				{
					text2 = text2.Remove(0, 1);
				}
				int num2 = text2.IndexOf('/');
				string text3 = text2.Substring(0, (num2 != -1) ? num2 : text2.Length);
				if (treeNode_0.Nodes.Find(text3, false).Length <= 0)
				{
					int num3 = 0;
					while (num3 < treeNode_0.Nodes.Count && treeNode_0.Nodes[num3].Tag == null)
					{
						num3++;
					}
					int imageIndex = 1;
					if (treeNode_0.Name == "songs")
					{
						List<GClass126> list = gclass128_0.method_28("songs/" + text3, "*.vgs");
						List<GClass126> list2 = gclass128_0.method_28("songs/" + text3, text3 + ".mid");
						if (list2.Count == 1 && list.Count > 0)
						{
							imageIndex = 13;
						}
					}
					TreeNode treeNode2 = treeNode_0.Nodes.Insert(num3, text3, text3);
					treeNode2.ImageIndex = imageIndex;
					treeNode2.SelectedImageIndex = treeNode2.ImageIndex;
					this.method_9(treeNode2);
				}
			}
		}
		treeNode_0.Expand();
		treeNode_0.TreeView.EndUpdate();
	}

	bool method_15(TreeNode treeNode_0)
	{
		MainWindow.Class69 @class = new MainWindow.Class69();
		@class.mainWindow_0 = this;
		if (treeNode_0.Nodes.Count != 1 || !(treeNode_0.Nodes[0].Tag is MainWindow.Class65))
		{
			return true;
		}
		@class.gclass128_0 = (this.method_10(treeNode_0).Tag as GClass128);
		if (@class.gclass128_0 == null)
		{
			return false;
		}
		treeNode_0.Nodes.Clear();
		if (@class.gclass128_0.method_18().Count == 0)
		{
			if (!@class.gclass128_0.method_4())
			{
				TreeViewCancelEventHandler treeViewCancelEventHandler = null;
				MainWindow.Class70 class2 = new MainWindow.Class70();
				class2.class69_0 = @class;
				if (MessageBox.Show("The archive you want to load has not been verified.\nYou must do this in order to load it.\nWould you like to do it now?", "Archive", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
				{
					this.method_9(treeNode_0);
					return false;
				}
				class2.list_0 = null;
				ProgressDialog progressDialog = new ProgressDialog(new ProgressDialog.GDelegate6(class2.method_0));
				progressDialog.ShowDialog();
				if (!@class.gclass128_0.method_4())
				{
					if (class2.list_0 != null && class2.list_0.Count != 0)
					{
						if (class2.list_0.Count != @class.gclass128_0.method_18().Count)
						{
							ProgressDialog.GDelegate6 gdelegate = null;
							MainWindow.Class72 class3 = new MainWindow.Class72();
							class3.class70_0 = class2;
							class3.class69_0 = @class;
							List<GClass126> list = new List<GClass126>(class2.list_0.Count);
							foreach (MainWindow.Class67 class4 in class2.list_0)
							{
								list.Add(class4.gclass126_0);
							}
							class3.badArkDialog_0 = new BadArkDialog(list);
							class3.badArkDialog_0.method_2().ImageList = this.imageList_0;
							TreeView treeView = class3.badArkDialog_0.method_2();
							if (treeViewCancelEventHandler == null)
							{
								treeViewCancelEventHandler = new TreeViewCancelEventHandler(class2.method_1);
							}
							treeView.BeforeExpand += treeViewCancelEventHandler;
							TreeNode treeNode = class3.badArkDialog_0.method_2().Nodes.Add(@class.gclass128_0.method_17());
							treeNode.ToolTipText = @class.gclass128_0.method_16();
							treeNode.Tag = @class.gclass128_0;
							treeNode.ImageIndex = 0;
							this.method_9(treeNode);
							treeNode.Expand();
							if (class3.badArkDialog_0.ShowDialog() == DialogResult.OK)
							{
								if (gdelegate == null)
								{
									gdelegate = new ProgressDialog.GDelegate6(class3.method_0);
								}
								ProgressDialog progressDialog2 = new ProgressDialog(gdelegate);
								progressDialog2.ShowDialog();
								goto IL_289;
							}
							goto IL_289;
						}
					}
					MessageBox.Show("The archive was so damaged nothing can\nsafely be recovered from it.\nIt will be removed from the list.\n\nYou could try to copy it again using the\n\"Copy From DVD\" function from the\nFile->Archive menu.", "Sorry..", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					IL_289:
					this.method_20(treeNode_0);
					return false;
				}
				if (@class.gclass128_0.method_4())
				{
					Class61.smethod_0().method_3().method_1(@class.gclass128_0.method_16()).ulong_0 = @class.gclass128_0.method_14();
				}
			}
			treeNode_0.Text += " (Loading...)";
			this.thread_0 = new Thread(new ParameterizedThreadStart(this.method_11));
			this.thread_0.Start(new MainWindow.Class66(@class.gclass128_0, treeNode_0));
			return false;
		}
		if (!(treeNode_0.Tag is GClass126))
		{
			this.method_14(treeNode_0, @class.gclass128_0);
			return true;
		}
		MainWindow.Class73 class5 = new MainWindow.Class73();
		class5.class69_0 = @class;
		class5.gclass126_0 = (treeNode_0.Tag as GClass126);
		ProgressDialog progressDialog3 = new ProgressDialog(new ProgressDialog.GDelegate6(class5.method_0));
		progressDialog3.ShowDialog();
		if (class5.gclass126_0.method_0() == null)
		{
			return false;
		}
		if (class5.gclass126_0.method_0() is Class99)
		{
			Class99 class6 = class5.gclass126_0.method_0() as Class99;
			foreach (Class98 class7 in class6.method_1())
			{
				TreeNode treeNode2 = treeNode_0.Nodes.Add(class7.method_0());
				treeNode2.Tag = class7;
				treeNode2.Name = class7.method_0();
				switch (class7.method_5())
				{
				case Enum8.const_0:
					treeNode2.ImageIndex = 10;
					break;
				case Enum8.const_1:
					goto IL_408;
				case Enum8.const_2:
					treeNode2.ImageIndex = 6;
					break;
				default:
					goto IL_408;
				}
				IL_41A:
				treeNode2.SelectedImageIndex = treeNode2.ImageIndex;
				continue;
				IL_408:
				treeNode2.ImageIndex = 2;
				goto IL_41A;
			}
		}
		return true;
	}

	TreeNode method_16(GClass128 gclass128_0)
	{
		this.arkFileList.BeginUpdate();
		TreeNode treeNode = this.arkFileList.Nodes.Add(gclass128_0.method_17());
		treeNode.ToolTipText = gclass128_0.method_16();
		treeNode.Tag = gclass128_0;
		treeNode.ImageIndex = 0;
		if (gclass128_0.method_3())
		{
			this.method_9(treeNode);
		}
		this.arkFileList.EndUpdate();
		this.list_0.Add(gclass128_0);
		if (!Class61.smethod_0().method_3().method_0(gclass128_0.method_16()))
		{
			if (gclass128_0.method_3() && gclass128_0.method_7() && MessageBox.Show("The archive you're adding is read-only.\nWould you like to make it writable?", "Archive", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
			{
				gclass128_0.method_8();
			}
			foreach (Class58 @class in Class61.smethod_0().method_3())
			{
				@class.bool_0 = false;
			}
			Class61.smethod_0().method_3().Add(new Class58(gclass128_0.method_16(), true, 0UL));
		}
		return treeNode;
	}

	GClass128 method_17(string string_2, bool bool_0, ulong ulong_0)
	{
		GClass128 gclass = null;
		GClass128 result;
		try
		{
			gclass = new GClass128(string_2);
			gclass.method_5(ulong_0 == gclass.method_14());
			goto IL_33;
		}
		catch
		{
			this.arkFileList.Nodes.Add(string_2);
			result = null;
		}
		return result;
		IL_33:
		if (gclass != null)
		{
			TreeNode treeNode = this.method_16(gclass);
			if (bool_0 && treeNode != null)
			{
				treeNode.Expand();
			}
		}
		return gclass;
	}

	void tsmiFileLocateArk_Click(object sender, EventArgs e)
	{
		this.openFileDialog_0.InitialDirectory = Class61.smethod_0().method_8().method_1("LocateArchive");
		DialogResult dialogResult = this.openFileDialog_0.ShowDialog();
		if (dialogResult != DialogResult.OK)
		{
			return;
		}
		if (Class61.smethod_0().method_3().method_0(this.openFileDialog_0.FileName))
		{
			MessageBox.Show("Archive already in list");
			return;
		}
		Class61.smethod_0().method_8().method_2("LocateArchive", Class109.smethod_5(this.openFileDialog_0.FileName));
		this.method_17(this.openFileDialog_0.FileName, true, 0UL);
	}

	void method_18()
	{
		if (this.scPreview.Panel1.Controls.Count > 0)
		{
			this.scPreview.Panel1.Controls[0].Dispose();
		}
		this.scPreview.Panel1.Controls.Clear();
	}

	void method_19(TreeNode treeNode_0)
	{
		MainWindow.Class74 @class = new MainWindow.Class74();
		@class.treeNode_0 = treeNode_0;
		@class.mainWindow_0 = this;
		@class.control_0 = null;
		@class.list_0 = new List<GClass109>();
		ExceptionDialog.smethod_3(new ExceptionDialog.GDelegate22(@class.method_0));
		if (@class.control_0 == null)
		{
			Label label = new Label();
			label.Text = "No preview available";
			if (@class.treeNode_0.Tag != null)
			{
				Label label2 = label;
				label2.Text = label2.Text + " for " + @class.treeNode_0.Text;
			}
			@class.control_0 = label;
		}
		this.lvPreviewProperties.BeginUpdate();
		this.lvPreviewProperties.Items.Clear();
		foreach (GClass109 gclass in @class.list_0)
		{
			ListViewItem listViewItem = this.lvPreviewProperties.Items.Add(gclass.method_0());
			if (gclass.method_1().GetType().IsArray)
			{
				Array array = gclass.method_1() as Array;
				for (int i = this.lvPreviewProperties.Columns.Count - 2; i < array.Length - 1; i++)
				{
					this.lvPreviewProperties.Columns.Add("", this.lvPreviewProperties.Columns[1].Width);
				}

                foreach (var a in array) listViewItem.SubItems.Add(a.ToString());
                continue;
			}
			listViewItem.SubItems.Add(gclass.method_1().ToString());
		}
		this.lvPreviewProperties.EndUpdate();
		this.scPreview.Panel1.Controls.Add(@class.control_0);
		@class.control_0.Dock = DockStyle.Fill;
		foreach (object obj2 in this.tsDocuments.method_35())
		{
			GClass98 gclass2 = (GClass98)obj2;
			if (gclass2.Tag == null)
			{
				this.tsDocuments.method_30(gclass2);
				break;
			}
		}
	}

	void arkFileList_AfterSelect(object sender, TreeViewEventArgs e)
	{
		this.method_18();
		this.method_19(e.Node);
	}

	void method_20(TreeNode treeNode_0)
	{
		if (treeNode_0.Tag is GClass128)
		{
			GClass128 gclass = treeNode_0.Tag as GClass128;
			if (!Class61.smethod_0().method_3().method_2(gclass.method_16()))
			{
				return;
			}
			this.method_21(gclass);
			gclass.method_10();
		}
		else if (treeNode_0.Tag == null && treeNode_0.Text.ToLower().Contains(".hdr"))
		{
			Class61.smethod_0().method_3().method_2(treeNode_0.Text);
		}
		this.arkFileList.Nodes.Remove(treeNode_0);
	}

	void cmiFileListRemove_Click(object sender, EventArgs e)
	{
		TreeNode selectedNode = this.arkFileList.SelectedNode;
		this.method_20(selectedNode);
	}

	void cmArkFileList_Opening(object sender, CancelEventArgs e)
	{
		TreeNode selectedNode = this.arkFileList.SelectedNode;
		this.cmiFileListNA.Visible = true;
		this.cmiFileListRemove.Enabled = false;
		this.cmiFileListRemove.Visible = false;
		this.cmiFileListSave.Enabled = false;
		this.cmiFileListSave.Visible = false;
		this.cmiFileListReLink.Enabled = false;
		this.cmiFileListReLink.Visible = false;
		this.cmiFileListReplace.Enabled = false;
		this.cmiFileListReplace.Visible = false;
		this.cmiFileListImport.Enabled = false;
		this.cmiFileListImport.Visible = false;
		this.cmiFileListExtract.Enabled = false;
		this.cmiFileListExtract.Visible = false;
		this.cmiFileListExportNoteCharts.Enabled = false;
		this.cmiFileListExportNoteCharts.Visible = false;
		this.cmiFileListShrinkArchive.Enabled = false;
		this.cmiFileListShrinkArchive.Visible = false;
		this.cmiFileListMakeWritable.Visible = false;
		this.cmiFileListMakeWritable.Enabled = false;
		if (selectedNode == null)
		{
			return;
		}
		if (selectedNode.Tag is GClass128)
		{
			GClass128 gclass = selectedNode.Tag as GClass128;
			bool flag = gclass.method_7();
			this.cmiFileListNA.Visible = false;
			this.cmiFileListSave.Visible = true;
			this.cmiFileListExportNoteCharts.Visible = true;
			this.cmiFileListShrinkArchive.Visible = true;
			if (gclass.method_18().Count > 0)
			{
				if (!flag)
				{
					this.cmiFileListSave.Enabled = gclass.method_0();
					this.cmiFileListShrinkArchive.Enabled = true;
				}
				this.cmiFileListExportNoteCharts.Enabled = true;
			}
			if (gclass.method_3() && flag && !gclass.method_6())
			{
				this.cmiFileListMakeWritable.Enabled = !gclass.method_2();
				this.cmiFileListMakeWritable.Visible = true;
			}
			this.cmiFileListRemove.Visible = true;
			if (selectedNode.Parent == null && Class61.smethod_0().method_3().method_0(gclass.method_16()))
			{
				this.cmiFileListRemove.Enabled = true;
			}
		}
		if (selectedNode.Tag is GClass126)
		{
			GClass128 gclass2 = this.method_10(selectedNode).Tag as GClass128;
			this.cmiFileListNA.Visible = false;
			this.cmiFileListReplace.Visible = true;
			this.cmiFileListExtract.Visible = true;
			if (!gclass2.method_7())
			{
				this.cmiFileListReplace.Enabled = true;
			}
			GClass126 gclass3 = selectedNode.Tag as GClass126;
			string strA = gclass3.method_5();
			if (string.Compare(strA, "mid", true) == 0 || string.Compare(strA, "vgs", true) == 0)
			{
				this.cmiFileListReplace.Enabled = false;
				this.cmiFileListReplace.Visible = false;
				this.cmiFileListImport.Visible = true;
				if (!gclass2.method_7())
				{
					this.cmiFileListImport.Enabled = true;
				}
			}
			this.cmiFileListExtract.Enabled = true;
		}
		if (selectedNode.Tag is Class98)
		{
			this.cmiFileListNA.Visible = false;
			this.cmiFileListExtract.Visible = true;
			this.cmiFileListExtract.Enabled = true;
		}
		if (selectedNode.Tag == null)
		{
			if (selectedNode.Text.ToLower().Contains(".hdr"))
			{
				this.cmiFileListNA.Visible = false;
				this.cmiFileListRemove.Visible = true;
				this.cmiFileListRemove.Enabled = true;
				return;
			}
			this.cmiFileListNA.Visible = false;
			this.cmiFileListExtract.Visible = true;
			if (selectedNode.Text != "..")
			{
				this.cmiFileListExtract.Enabled = true;
			}
		}
	}

	void arkFileList_BeforeExpand(object sender, TreeViewCancelEventArgs e)
	{
		e.Cancel = !this.method_15(e.Node);
	}

	void method_21(GClass128 gclass128_0)
	{
		if (!gclass128_0.method_0())
		{
			return;
		}
		if (MessageBox.Show("'" + gclass128_0.method_16() + "'\nhas some unsaved changes.\nWould you like to save now?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
		{
			gclass128_0.method_15();
		}
	}

	void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
	{
		foreach (object obj in this.arkFileList.Nodes)
		{
			TreeNode treeNode = (TreeNode)obj;
			if (treeNode.Tag is GClass128)
			{
				GClass128 gclass = treeNode.Tag as GClass128;
				if (gclass.method_18().Count > 0)
				{
					Class61.smethod_0().method_3().method_1(gclass.method_16()).bool_0 = treeNode.IsExpanded;
					Class61.smethod_0().method_3().method_1(gclass.method_16()).ulong_0 = (gclass.method_4() ? gclass.method_14() : 0UL);
					this.method_21(gclass);
				}
			}
		}
		Class61.smethod_0().method_4()["MainWindow"] = base.Bounds;
		Class61.smethod_0().method_4()["MainWindowSplit"] = new Rectangle(0, 0, this.splitContainer1.SplitterDistance, this.scPreview.SplitterDistance);
	}

	void cmiFileListSave_Click(object sender, EventArgs e)
	{
		MainWindow.Class75 @class = new MainWindow.Class75();
		@class.gclass128_0 = (this.arkFileList.SelectedNode.Tag as GClass128);
		ProgressDialog progressDialog = new ProgressDialog(new ProgressDialog.GDelegate6(@class.method_0));
		progressDialog.ShowDialog();
	}

	void cmiFileListReLink_Click(object sender, EventArgs e)
	{
	}

	void arkFileList_BeforeSelect(object sender, TreeViewCancelEventArgs e)
	{
	}

	void cmiFileListReplace_Click(object sender, EventArgs e)
	{
		MainWindow.Class76 @class = new MainWindow.Class76();
		@class.gclass126_0 = (this.arkFileList.SelectedNode.Tag as GClass126);
		@class.openFileDialog_0 = new OpenFileDialog();
		@class.openFileDialog_0.Title = "Locate a file to replace \"" + @class.gclass126_0.method_6() + "\" with..";
		@class.openFileDialog_0.FileName = @class.gclass126_0.method_6();
		@class.openFileDialog_0.Filter = @class.gclass126_0.method_5().ToUpper() + " files|*." + @class.gclass126_0.method_5();
		@class.openFileDialog_0.InitialDirectory = Class61.smethod_0().method_8().method_1("FileReplace");
		if (@class.openFileDialog_0.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		Class61.smethod_0().method_8().method_2("FileReplace", Class109.smethod_5(@class.openFileDialog_0.FileName));
		TreeNode selectedNode = this.arkFileList.SelectedNode;
		@class.gclass128_0 = (this.method_10(selectedNode).Tag as GClass128);
		@class.list_0 = @class.gclass128_0.method_18().FindAll(new Predicate<GClass126>(@class.method_0));
		if (@class.list_0.Count > 0)
		{
			if (MessageBox.Show(string.Concat(new object[]
			{
				"Since there ",
				(@class.list_0.Count == 1) ? "is" : "are",
				" currently ",
				@class.list_0.Count,
				" other file",
				(@class.list_0.Count == 1) ? "" : "s",
				" that use the\ndata pointed to by '",
				@class.gclass126_0.method_6(),
				"'.\nThe new data will be appended to the archive so\nthe other file",
				(@class.list_0.Count == 1) ? "" : "s",
				" can remain valid."
			}), "Append?", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) != DialogResult.OK)
			{
				return;
			}
		}
		else if (MessageBox.Show(string.Concat(new string[]
		{
			"This will completely remove the data for \"",
			@class.gclass126_0.method_6(),
			"\"\nand replace it with the data from\n\"",
			@class.openFileDialog_0.FileName,
			"\".\nDo you want to continue?"
		}), "Replace?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
		{
			return;
		}
		ProgressDialog progressDialog = new ProgressDialog(new ProgressDialog.GDelegate6(@class.method_1));
		this.method_18();
		progressDialog.ShowDialog();
		this.method_19(selectedNode);
	}

	internal string method_22()
	{
		string result;
		try
		{
			result = this.xmlNode_0.Attributes["Url"].Value;
		}
		catch
		{
			result = null;
		}
		return result;
	}

	void timer_0_Tick(object sender, EventArgs e)
	{
		if (!NetworkInterface.GetIsNetworkAvailable())
		{
			return;
		}
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(this.string_0 + "version?id=ghex");
			httpWebRequest.Timeout = 1000;
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(httpWebResponse.GetResponseStream());
			XmlNode xmlNode = xmlDocument["OnReally"]["GuitarHeroExplorer"];
			string value = xmlNode.Attributes["Version"].Value;
			if (value.CompareTo(Application.ProductVersion) > 0)
			{
				Class61.smethod_0().method_7(value);
				this.tslVersion.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
				this.tslVersion.ToolTipText = "Version " + value + " is available!\nDouble-click to download";
				this.tslVersion.IsLink = true;
			}
			if (Class61.smethod_0().method_6().CompareTo(Application.ProductVersion) == 0)
			{
				Class61.smethod_0().method_7("");
				if (this.changesDialog_0 == null)
				{
					this.changesDialog_0 = new ChangesDialog();
				}
				if (!this.changesDialog_0.Visible)
				{
					this.changesDialog_0.Text = "What's new?";
					this.changesDialog_0.ShowDialog();
					this.changesDialog_0 = null;
				}
			}
			this.timer_0.Enabled = false;
			this.xmlNode_0 = xmlNode;
		}
		catch
		{
			this.timer_0.Enabled = false;
		}
	}

	internal void method_23()
	{
		try
		{
			string value = this.xmlNode_0.Attributes["Url"].Value;
			if (this.xmlNode_0 != null && value.StartsWith(this.string_1))
			{
				Process.Start(value);
			}
		}
		catch
		{
		}
	}

	void tslVersion_DoubleClick(object sender, EventArgs e)
	{
		try
		{
			if (this.tslVersion.IsLink)
			{
				this.method_23();
				this.tslVersion.DisplayStyle = ToolStripItemDisplayStyle.Text;
				this.tslVersion.ToolTipText = null;
				this.tslVersion.IsLink = false;
			}
		}
		catch
		{
		}
	}

	void tsmiFileExit_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	void tsmiHelpWebsite_Click(object sender, EventArgs e)
	{
		this.method_23();
	}

	void tsmiHelpAbout_Click(object sender, EventArgs e)
	{
		AboutDialog aboutDialog = new AboutDialog();
		aboutDialog.ShowDialog();
	}

	void arkFileList_MouseClick(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Right)
		{
			TreeNode nodeAt = this.arkFileList.GetNodeAt(e.Location);
			if (nodeAt != null)
			{
				this.arkFileList.SelectedNode = nodeAt;
			}
		}
	}

	void cmiFileListExtract_Click(object sender, EventArgs e)
	{
		MainWindow.Class77 @class = new MainWindow.Class77();
		@class.mainWindow_0 = this;
		@class.treeNode_0 = this.arkFileList.SelectedNode;
		if (@class.treeNode_0.Tag is GClass126)
		{
			MainWindow.Class78 class2 = new MainWindow.Class78();
			class2.class77_0 = @class;
			class2.gclass126_0 = (@class.treeNode_0.Tag as GClass126);
			class2.saveFileDialog_0 = new SaveFileDialog();
			class2.saveFileDialog_0.Title = "Extract \"" + class2.gclass126_0.method_6() + "\" as..";
			class2.saveFileDialog_0.OverwritePrompt = true;
			class2.saveFileDialog_0.FileName = class2.gclass126_0.method_6();
			class2.saveFileDialog_0.Filter = class2.gclass126_0.method_5().ToUpper() + " files|*." + class2.gclass126_0.method_5();
			class2.saveFileDialog_0.ValidateNames = true;
			class2.saveFileDialog_0.InitialDirectory = Class61.smethod_0().method_8().method_1("ExtractFile");
			if (class2.saveFileDialog_0.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			Class61.smethod_0().method_8().method_2("ExtractFile", Class109.smethod_5(class2.saveFileDialog_0.FileName));
			ProgressDialog progressDialog = new ProgressDialog(new ProgressDialog.GDelegate6(class2.method_0));
			progressDialog.ShowDialog();
			return;
		}
		else
		{
			if (!(@class.treeNode_0.Tag is Class98))
			{
				if (@class.treeNode_0.Tag == null)
				{
					MainWindow.Class80 class3 = new MainWindow.Class80();
					class3.class77_0 = @class;
					string str = Class109.smethod_6(@class.treeNode_0.Parent);
					class3.string_0 = str + "/" + @class.treeNode_0.Text;
					if (class3.string_0.StartsWith("/"))
					{
						class3.string_0 = class3.string_0.Substring(1);
					}
					class3.folderBrowserDialog_0 = new FolderBrowserDialog();
					class3.folderBrowserDialog_0.Description = "Extract \"" + class3.string_0 + "\" to..";
					class3.folderBrowserDialog_0.ShowNewFolderButton = true;
					class3.folderBrowserDialog_0.SelectedPath = Class61.smethod_0().method_8().method_1("ExtractFile");
					if (class3.folderBrowserDialog_0.ShowDialog() != DialogResult.OK)
					{
						return;
					}
					Class61.smethod_0().method_8().method_2("ExtractFile", class3.folderBrowserDialog_0.SelectedPath);
					class3.long_0 = 0L;
					GClass128 gclass = this.method_10(@class.treeNode_0).Tag as GClass128;
					class3.list_0 = gclass.method_18().FindAll(new Predicate<GClass126>(class3.method_0));
					string directoryRoot = Directory.GetDirectoryRoot(class3.folderBrowserDialog_0.SelectedPath);
					DriveInfo[] drives = DriveInfo.GetDrives();
					int i = 0;
					while (i < drives.Length)
					{
						DriveInfo driveInfo = drives[i];
						if (!(driveInfo.RootDirectory.Name == directoryRoot))
						{
							i++;
						}
						else
						{
							if (!driveInfo.IsReady)
							{
								MessageBox.Show("Target location is not ready", "Extract", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								return;
							}
							if (driveInfo.AvailableFreeSpace < class3.long_0)
							{
								MessageBox.Show("There is not enough free space\nin the target location.\n" + Class109.smethod_3(class3.long_0) + " is needed.", "Extract", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								return;
							}

							ProgressDialog progressDialog2 = new ProgressDialog(new ProgressDialog.GDelegate6(class3.method_1));
							progressDialog2.ShowDialog();
							return;
						}
					}

                    ProgressDialog progressDialog2_0 = new ProgressDialog(new ProgressDialog.GDelegate6(class3.method_1));
                    progressDialog2_0.ShowDialog();
                    return;
                }
				return;
			}
			MainWindow.Class79 class4 = new MainWindow.Class79();
			class4.class77_0 = @class;
			class4.class98_0 = (@class.treeNode_0.Tag as Class98);
			class4.saveFileDialog_0 = new SaveFileDialog();
			class4.saveFileDialog_0.Title = "Extract \"" + class4.class98_0.method_0() + "\" as..";
			class4.saveFileDialog_0.OverwritePrompt = true;
			class4.saveFileDialog_0.FileName = class4.class98_0.method_0();
			class4.saveFileDialog_0.Filter = class4.class98_0.method_1().ToUpper() + " files|*." + class4.class98_0.method_1();
			class4.saveFileDialog_0.ValidateNames = true;
			class4.saveFileDialog_0.InitialDirectory = Class61.smethod_0().method_8().method_1("ExtractFile");
			if (class4.saveFileDialog_0.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			Class61.smethod_0().method_8().method_2("ExtractFile", Class109.smethod_5(class4.saveFileDialog_0.FileName));
			ProgressDialog progressDialog3 = new ProgressDialog(new ProgressDialog.GDelegate6(class4.method_0));
			progressDialog3.ShowDialog();
			return;
		}
	}

	void method_24(List<GClass126> list_1, string string_2, ref ProgressDialog.GClass73 gclass73_0)
	{
		int num = 0;
		long num2 = 0L;
		long num3 = 0L;
		foreach (GClass126 gclass in list_1)
		{
			num3 += gclass.method_4();
		}
		DateTime now = DateTime.Now;
		foreach (GClass126 gclass2 in list_1)
		{
			string text = Class109.smethod_0(now, num2, num3);
			lock (gclass73_0)
			{
				gclass73_0.string_2 = string.Concat(new object[]
				{
					"File ",
					1 + num,
					" of ",
					list_1.Count,
					text
				});
				gclass73_0.int_1 = num * 100 / list_1.Count;
			}
			string text2 = string_2 + "\\" + gclass2.method_7().Replace("/", "\\");
			try
			{
				if (!Directory.Exists(text2))
				{
					Directory.CreateDirectory(text2);
				}
				FileStream fileStream = new FileStream(text2 + "\\" + gclass2.method_6(), FileMode.Create, FileAccess.Write, FileShare.Read);
				gclass2.method_2().method_24(gclass2, fileStream, ref gclass73_0);
				fileStream.Close();
			}
			catch
			{
			}
			num2 += gclass2.method_4();
			num++;
		}
	}

	void tsmiHelpChanges_Click(object sender, EventArgs e)
	{
		ChangesDialog changesDialog = new ChangesDialog();
		changesDialog.ShowDialog();
	}

	void cmiFileListExportNoteCharts_Click(object sender, EventArgs e)
	{
		MainWindow.Class81 @class = new MainWindow.Class81();
		GClass128 gclass = this.method_10(this.arkFileList.SelectedNode).Tag as GClass128;
		@class.batchExportMidiDialog_0 = new BatchExportMidiDialog();
		GClass127 gclass2 = gclass.method_27("config/gen/gh2.dtb");
		@class.batchExportMidiDialog_0.method_2(gclass2.Count > 0);
		if (@class.batchExportMidiDialog_0.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		@class.folderBrowserDialog_0 = new FolderBrowserDialog();
		@class.folderBrowserDialog_0.SelectedPath = Class61.smethod_0().method_8().method_1("BatchExport");
		if (@class.folderBrowserDialog_0.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		Class61.smethod_0().method_8().method_2("BatchExport", @class.folderBrowserDialog_0.SelectedPath);
		@class.gclass127_0 = gclass.method_28("songs/", "*.mid");
		ProgressDialog progressDialog = new ProgressDialog(new ProgressDialog.GDelegate6(@class.method_0));
		progressDialog.ShowDialog();
	}

	void tsmiHelpReportBug_Click(object sender, EventArgs e)
	{
		BugReportDialog bugReportDialog = new BugReportDialog();
		bugReportDialog.ShowDialog();
	}

	void cmiFileListImport_Click(object sender, EventArgs e)
	{
		TreeNode selectedNode = this.arkFileList.SelectedNode;
		if (!(selectedNode.Tag is GClass126))
		{
			return;
		}
		GClass126 gclass = selectedNode.Tag as GClass126;
		string strA = gclass.method_5();
		Form form = null;
		ProgressDialog.GDelegate6 gdelegate6_ = null;
		if (string.Compare(strA, "vgs", true) == 0)
		{
			form = new VgsImportDialog(gclass);
			gdelegate6_ = new ProgressDialog.GDelegate6((form as VgsImportDialog).method_3);
		}
		else if (string.Compare(strA, "mid", true) == 0)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Class61.smethod_0().method_8().method_1("MidImport");
			openFileDialog.Filter = "Supported files|*.mid;*.sng;*.chart;song.ini";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				Class61.smethod_0().method_8().method_2("MidImport", Class109.smethod_5(openFileDialog.FileName));
				form = new MidImportDialog(gclass, openFileDialog.FileName);
				gdelegate6_ = new ProgressDialog.GDelegate6((form as MidImportDialog).method_5);
			}
		}
		if (form == null)
		{
			return;
		}
		form.Text = "Importing to '" + gclass.method_6() + "'...";
		if (form.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		this.method_18();
		ProgressDialog progressDialog = new ProgressDialog(gdelegate6_);
		progressDialog.ShowDialog();
		this.method_19(selectedNode);
	}

	void method_25(GEventArgs12 geventArgs12_0)
	{
		if (geventArgs12_0.method_1() != this.tsDocuments.method_29())
		{
			return;
		}
		if (this.gclass122_0 != null)
		{
			this.gclass122_0.vmethod_2();
		}
		GClass122 gclass = geventArgs12_0.method_1().Tag as GClass122;
		if (gclass == null)
		{
			if (this.tsbExplorer.Owner != null)
			{
				this.tsLeft.method_17(this.tsbExplorer);
			}
			this.tsbPropertyGrid.Enabled = false;
			this.tsFile.Enabled = false;
			this.tsmiEdit.Enabled = false;
			this.tsmiFileSave.Enabled = false;
			return;
		}
		if (gclass.vmethod_0() != null)
		{
			gclass.vmethod_0().Focus();
		}
		List<ToolStrip> list = new List<ToolStrip>(this.toolStripContainer1.TopToolStripPanel.Controls.Count);
		foreach (object obj in this.toolStripContainer1.TopToolStripPanel.Controls)
		{
			Control control = (Control)obj;
			if (control is ToolStrip)
			{
				list.Add(control as ToolStrip);
			}
		}
		gclass.vmethod_1(list.ToArray());
		this.tsbPropertyGrid.Enabled = true;
		this.tsLeft.method_17(this.tsbPropertyGrid);
		this.tsFile.Enabled = true;
		this.tsmiEdit.Enabled = true;
		this.tsmiFileSave.Enabled = true;
	}

	void tsmiFileNewSong_Click(object sender, EventArgs e)
	{
		GClass123 item = new GClass123();
		this.gclass121_0.Add(item);
	}

	void tsmiFileOpenSong_Click(object sender, EventArgs e)
	{
	}

	void tsmiFileSave_Click(object sender, EventArgs e)
	{
	}

	void tsmiEditUndo_Click(object sender, EventArgs e)
	{
		GClass122 gclass = this.tsDocuments.method_29().Tag as GClass122;
		gclass.method_14();
	}

	void tsmiEditRedo_Click(object sender, EventArgs e)
	{
		GClass122 gclass = this.tsDocuments.method_29().Tag as GClass122;
		gclass.method_16();
	}

	void tsmiEdit_DropDownOpening(object sender, EventArgs e)
	{
		GClass122 gclass = this.tsDocuments.method_29().Tag as GClass122;
		this.tsmiEditUndo.Enabled = gclass.method_13();
		this.tsmiEditRedo.Enabled = gclass.method_15();
		this.tsmiEditDelete.Enabled = false;
	}

	void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
	{
		foreach (GClass122 gclass122_ in this.gclass121_0)
		{
			if (this.method_0(gclass122_))
			{
				e.Cancel = true;
				return;
			}
		}
		this.gclass121_0.Clear();
	}

	void method_26(object sender, GEventArgs15 e)
	{
		if (this.gclass135_0 != null)
		{
			(this.gclass135_0.Tag as Control).Visible = false;
			(this.gclass135_0.Tag as Control).Enabled = false;
		}
		if (e.gclass135_0.Tag != null)
		{
			(e.gclass135_0.Tag as Control).Dock = DockStyle.Fill;
			(e.gclass135_0.Tag as Control).Enabled = true;
			(e.gclass135_0.Tag as Control).Visible = true;
		}
		this.gclass135_0 = e.gclass135_0;
	}

	void propertyGrid1_PropertyValueChanged(object sender, PropertyValueChangedEventArgs e)
	{
		GClass118 gclass = this.propertyGrid1.SelectedObject as GClass118;
		if (gclass != null)
		{
			gclass.method_5(sender, e);
		}
	}

	void tsmiFileCopyArchive_Click(object sender, EventArgs e)
	{
		MainWindow.Class82 @class = new MainWindow.Class82();
		@class.arkCopyDialog_0 = new ArkCopyDialog();
		if (@class.arkCopyDialog_0.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		@class.bool_0 = false;
		@class.string_0 = "";
		ProgressDialog progressDialog = new ProgressDialog(new ProgressDialog.GDelegate6(@class.method_0));
		progressDialog.ShowDialog();
		if (@class.bool_0 && @class.arkCopyDialog_0.method_2())
		{
			this.method_17(@class.arkCopyDialog_0.method_0() + "\\" + @class.string_0, true, 0UL);
			return;
		}
	}

	void cmiFileListShrinkArchive_Click(object sender, EventArgs e)
	{
		MainWindow.Class83 @class = new MainWindow.Class83();
		@class.gclass128_0 = (this.arkFileList.SelectedNode.Tag as GClass128);
		if (@class.gclass128_0 == null)
		{
			return;
		}
		@class.arkShrinkDialog_0 = new ArkShrinkDialog();
		if (@class.arkShrinkDialog_0.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		ProgressDialog progressDialog = new ProgressDialog(new ProgressDialog.GDelegate6(@class.method_0));
		progressDialog.ShowDialog();
	}

	void cmiFileListMakeWritable_Click(object sender, EventArgs e)
	{
		GClass128 gclass = this.arkFileList.SelectedNode.Tag as GClass128;
		if (gclass == null)
		{
			return;
		}
		if (gclass.method_3() && gclass.method_7())
		{
			gclass.method_8();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	[CompilerGenerated]
	static int smethod_0(GClass126 gclass126_0, GClass126 gclass126_1)
	{
		if (gclass126_0.method_11() >= gclass126_1.method_11())
		{
			return 1;
		}
		return -1;
	}

	List<GClass128> list_0;

	GClass121 gclass121_0 = new GClass121();

	Thread thread_0;

	string string_0 = "http://static.onreally.com/";

	string string_1 = "http://onreally.com/ghex/";

	ChangesDialog changesDialog_0;

	XmlNode xmlNode_0;

	GClass122 gclass122_0;

	GClass135 gclass135_0;

	[CompilerGenerated]
	static Comparison<GClass126> comparison_0;

	class Class65
	{
	}

	class Class66
	{
		public Class66(GClass128 gclass128_1, TreeNode treeNode_1)
		{
			this.gclass128_0 = gclass128_1;
			this.treeNode_0 = treeNode_1;
		}

		public GClass128 gclass128_0;

		public TreeNode treeNode_0;
	}

	delegate void Delegate2(MainWindow.Class66 class66_0);

	class Class67
	{
		public Class67(GClass126 gclass126_1, string string_1)
		{
			this.gclass126_0 = gclass126_1;
			this.string_0 = string_1;
		}

		public GClass126 gclass126_0;

		public string string_0;
	}

	class Class68
	{
	}

	[CompilerGenerated]
	sealed class Class69
	{
		public GClass128 gclass128_0;

		public MainWindow mainWindow_0;
	}

	[CompilerGenerated]
	sealed class Class70
	{
		public void method_0(ref ProgressDialog.GClass73 gclass73_0)
		{
			this.list_0 = this.class69_0.mainWindow_0.method_13(this.class69_0.gclass128_0, ref gclass73_0);
		}

		public void method_1(object sender, TreeViewCancelEventArgs e)
		{
			if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Tag is MainWindow.Class65)
			{
				e.Cancel = !this.class69_0.mainWindow_0.method_15(e.Node);
				int num = 0;
				int num2 = 0;
				foreach (object obj in e.Node.Nodes)
				{
					TreeNode treeNode = (TreeNode)obj;
					MainWindow.Class70.Class71 @class = new MainWindow.Class70.Class71();
					@class.class70_0 = this;
					@class.class69_0 = this.class69_0;
					if (treeNode.ImageIndex == 13)
					{
						TreeNode treeNode2 = treeNode;
						treeNode.SelectedImageIndex = 1;
						treeNode2.ImageIndex = 1;
					}
					@class.gclass126_0 = (treeNode.Tag as GClass126);
					if (@class.gclass126_0 != null)
					{
						if (treeNode.ImageIndex == 12)
						{
							treeNode.Nodes.Clear();
						}
						num2++;
						MainWindow.Class67 class2 = this.list_0.Find(new Predicate<MainWindow.Class67>(@class.method_0));
						if (class2 != null)
						{
							treeNode.ForeColor = Color.Red;
							treeNode.Tag = null;
							treeNode.ToolTipText = class2.string_0;
							num++;
						}
						else
						{
							treeNode.ForeColor = SystemColors.GrayText;
						}
					}
				}
				if (num2 > 0 && num == num2)
				{
					e.Node.ForeColor = Color.Red;
					e.Node.Tag = null;
					e.Node.ToolTipText = "All files in this folder are corrupted";
				}
				return;
			}
		}

		public MainWindow.Class69 class69_0;

		public List<MainWindow.Class67> list_0;

		sealed class Class71
		{
			public bool method_0(MainWindow.Class67 class67_0)
			{
				return class67_0.gclass126_0 == this.gclass126_0;
			}

			public MainWindow.Class70 class70_0;

			public MainWindow.Class69 class69_0;

			public GClass126 gclass126_0;
		}
	}

	[CompilerGenerated]
	sealed class Class72
	{
		public void method_0(ref ProgressDialog.GClass73 gclass73_0)
		{
			lock (gclass73_0)
			{
				gclass73_0.string_0 = "Recovering..";
			}
			this.class69_0.mainWindow_0.method_24(this.badArkDialog_0.method_1(), this.badArkDialog_0.method_3(), ref gclass73_0);
		}

		public MainWindow.Class70 class70_0;

		public MainWindow.Class69 class69_0;

		public BadArkDialog badArkDialog_0;
	}

	[CompilerGenerated]
	sealed class Class73
	{
		public void method_0(ref ProgressDialog.GClass73 gclass73_0)
		{
			lock (gclass73_0)
			{
				gclass73_0.string_0 = "Loading..";
			}
			string a;
			if ((a = this.gclass126_0.method_5()) != null)
			{
				if (!(a == "gh") && !(a == "rnd_ps2") && !(a == "milo_ps2"))
				{
					return;
				}
				this.gclass126_0.method_1(Class99.smethod_0(this.gclass126_0.method_8(), ref gclass73_0));
			}
		}

		public MainWindow.Class69 class69_0;

		public GClass126 gclass126_0;
	}

	[CompilerGenerated]
	sealed class Class74
	{
		public void method_0()
		{
			if (this.treeNode_0 != null)
			{
				TreeNode treeNode = this.mainWindow_0.method_10(this.treeNode_0);
				if (treeNode != null && treeNode.Tag is GClass128 && !(treeNode.Tag as GClass128).method_3())
				{
					MessageBox.Show("Cannot access parts of the archive.\nPlease restart the program and try again!", "Preview", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (this.treeNode_0.Tag is GClass126)
				{
					try
					{
						GClass126 gclass = this.treeNode_0.Tag as GClass126;
						string key;
						switch (key = gclass.method_5())
						{
						case "bmp_ps2":
						case "png_ps2":
						case "bmp":
						case "png":
							this.control_0 = new BitmapPreview(gclass, this.list_0);
							goto IL_175;
						case "vgs":
							this.control_0 = new VgsPreview(gclass, null, this.list_0);
							goto IL_175;
						case "mid":
							this.control_0 = new MidPreview(gclass, this.list_0);
							goto IL_175;
						}
						this.list_0.Add(new GClass109("Size", gclass.method_4()));
						IL_175:
						return;
					}
					catch (FileLoadException)
					{
						GClass128 gclass2 = treeNode.Tag as GClass128;
						if (gclass2 != null)
						{
							gclass2.method_5(false);
						}
						MessageBox.Show("Failed to read file.\nPlease restart the program and try again.", "Preview", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
				}
				if (this.treeNode_0.Tag is Class98)
				{
					Class98 @class = this.treeNode_0.Tag as Class98;
					Enum8 @enum = @class.method_5();
					if (@enum == Enum8.const_0)
					{
						try
						{
							BinaryReader binaryReader = new BinaryReader(new MemoryStream(@class.method_2(), 25, @class.method_2().Length - 25));
							binaryReader.BaseStream.Seek((long)(binaryReader.ReadInt32() + 9), SeekOrigin.Current);
							this.control_0 = new BitmapPreview(binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position)), this.list_0);
							return;
						}
						catch
						{
							this.list_0.Clear();
							return;
						}
					}
					this.list_0.Add(new GClass109("Type", @class.method_6()));
					this.list_0.Add(new GClass109("Size", @class.method_2().Length));
					return;
				}
				if (this.treeNode_0.Tag == null && this.treeNode_0.ImageIndex == 13 && string.Compare(this.treeNode_0.Parent.Name, "Songs", true) == 0)
				{
					this.control_0 = new SongPreview(this.mainWindow_0.method_10(this.treeNode_0).Tag as GClass128, this.treeNode_0.Name, this.list_0);
				}
			}
		}

		public Control control_0;

		public List<GClass109> list_0;

		public MainWindow mainWindow_0;

		public TreeNode treeNode_0;
	}

	[CompilerGenerated]
	sealed class Class75
	{
		public void method_0(ref ProgressDialog.GClass73 gclass73_0)
		{
			this.gclass128_0.method_15();
		}

		public GClass128 gclass128_0;
	}

	[CompilerGenerated]
	sealed class Class76
	{
		public bool method_0(GClass126 gclass126_1)
		{
			return gclass126_1.method_11() == this.gclass126_0.method_11() && gclass126_1 != this.gclass126_0;
		}

		public void method_1(ref ProgressDialog.GClass73 gclass73_0)
		{
			FileStream fileStream = new FileStream(this.openFileDialog_0.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
			if (this.list_0.Count > 0)
			{
				this.gclass128_0.method_21(this.gclass126_0, fileStream, ref gclass73_0);
			}
			else
			{
				this.gclass128_0.method_22(this.gclass126_0, fileStream, ref gclass73_0);
			}
			fileStream.Close();
		}

		public GClass126 gclass126_0;

		public OpenFileDialog openFileDialog_0;

		public GClass128 gclass128_0;

		public List<GClass126> list_0;
	}

	[CompilerGenerated]
	sealed class Class77
	{
		public TreeNode treeNode_0;

		public MainWindow mainWindow_0;
	}

	[CompilerGenerated]
	sealed class Class78
	{
		public void method_0(ref ProgressDialog.GClass73 gclass73_0)
		{
			lock (gclass73_0)
			{
				gclass73_0.string_0 = "Extracting..";
			}
			FileStream fileStream = new FileStream(this.saveFileDialog_0.FileName, FileMode.Create, FileAccess.Write, FileShare.Read);
			GClass128 gclass = this.class77_0.mainWindow_0.method_10(this.class77_0.treeNode_0).Tag as GClass128;
			gclass.method_24(this.gclass126_0, fileStream, ref gclass73_0);
			fileStream.Close();
		}

		public MainWindow.Class77 class77_0;

		public GClass126 gclass126_0;

		public SaveFileDialog saveFileDialog_0;
	}

	[CompilerGenerated]
	sealed class Class79
	{
		public void method_0(ref ProgressDialog.GClass73 gclass73_0)
		{
			lock (gclass73_0)
			{
				gclass73_0.string_0 = "Extracting..";
			}
			File.WriteAllBytes(this.saveFileDialog_0.FileName, this.class98_0.method_2());
		}

		public MainWindow.Class77 class77_0;

		public Class98 class98_0;

		public SaveFileDialog saveFileDialog_0;
	}

	[CompilerGenerated]
	sealed class Class80
	{
		public bool method_0(GClass126 gclass126_0)
		{
			if (!gclass126_0.method_7().StartsWith(this.string_0, true, CultureInfo.CurrentUICulture))
			{
				return false;
			}
			this.long_0 += gclass126_0.method_4();
			return true;
		}

		public void method_1(ref ProgressDialog.GClass73 gclass73_0)
		{
			lock (gclass73_0)
			{
				gclass73_0.string_0 = "Extracting..";
			}
			this.class77_0.mainWindow_0.method_24(this.list_0, this.folderBrowserDialog_0.SelectedPath, ref gclass73_0);
		}

		public MainWindow.Class77 class77_0;

		public string string_0;

		public FolderBrowserDialog folderBrowserDialog_0;

		public long long_0;

		public List<GClass126> list_0;
	}

	[CompilerGenerated]
	sealed class Class81
	{
		public void method_0(ref ProgressDialog.GClass73 gclass73_0)
		{
			lock (gclass73_0)
			{
				gclass73_0.string_0 = "Exporting..";
			}
			int num = 0;
			int num2 = 3;
			if (!this.batchExportMidiDialog_0.method_4())
			{
				num = (int)this.batchExportMidiDialog_0.method_5();
				num2 = num;
			}
			foreach (GClass126 gclass in this.gclass127_0)
			{
				int num3 = this.gclass127_0.IndexOf(gclass);
				lock (gclass73_0)
				{
					gclass73_0.string_1 = "Exporting \"" + gclass.method_6() + "\"";
					gclass73_0.string_2 = string.Concat(new object[]
					{
						"File ",
						1 + num3,
						" of ",
						this.gclass127_0.Count
					});
					gclass73_0.int_1 = num3 * 100 / this.gclass127_0.Count;
					gclass73_0.int_0 = 0;
				}
				try
				{
					MidPreview midPreview = new MidPreview(gclass, null);
					midPreview.method_6(this.batchExportMidiDialog_0.method_3());
					midPreview.method_8(this.batchExportMidiDialog_0.method_1());
					lock (gclass73_0)
					{
						gclass73_0.int_0 = 50;
					}
					if (!Directory.Exists(this.folderBrowserDialog_0.SelectedPath))
					{
						Directory.CreateDirectory(this.folderBrowserDialog_0.SelectedPath);
					}
					for (int i = num; i <= num2; i++)
					{
						string string_ = this.folderBrowserDialog_0.SelectedPath + "\\" + this.batchExportMidiDialog_0.method_6(midPreview.method_9(), (GEnum53)i) + ".png";
						string text = "";
						midPreview.method_3((GEnum53)i);
						midPreview.method_13(this.batchExportMidiDialog_0.method_0()[0], midPreview.method_5() ? this.batchExportMidiDialog_0.method_0()[1] : "");
						midPreview.method_25(string_, midPreview.method_24(ref text));
						lock (gclass73_0)
						{
							gclass73_0.int_0 = 50 + 50 * (i - num) / (1 + num2 - num);
						}
					}
					lock (gclass73_0)
					{
						gclass73_0.int_0 = 100;
					}
				}
				catch
				{
					lock (gclass73_0)
					{
						gclass73_0.string_2 = "Failed..";
					}
					Thread.Sleep(500);
					break;
				}
			}
		}

		public BatchExportMidiDialog batchExportMidiDialog_0;

		public FolderBrowserDialog folderBrowserDialog_0;

		public GClass127 gclass127_0;
	}

	[CompilerGenerated]
	sealed class Class82
	{
		public void method_0(ref ProgressDialog.GClass73 gclass73_0)
		{
			lock (gclass73_0)
			{
				gclass73_0.string_0 = "Copying files...";
			}
			try
			{
				DateTime now = DateTime.Now;
				long num = 0L;
				long num2 = 0L;
				int num3 = 0;
				foreach (string text in this.arkCopyDialog_0.method_3())
				{
					string path = this.arkCopyDialog_0.method_1() + "\\" + text;
					lock (gclass73_0)
					{
						gclass73_0.string_1 = text.ToLower() + " => " + this.arkCopyDialog_0.method_0();
						gclass73_0.int_0 = 0;
					}
					if (text.EndsWith("main.hdr", StringComparison.CurrentCultureIgnoreCase))
					{
						this.string_0 = text;
					}
					string text2 = this.arkCopyDialog_0.method_0() + "\\" + text;
					Directory.CreateDirectory(text2.Substring(0, text2.LastIndexOf('\\')));
					FileStream fileStream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read);
					BinaryWriter binaryWriter = new BinaryWriter(new FileStream(text2, FileMode.Create, FileAccess.Write, FileShare.Read));
					int num4 = (int)Math.Min(fileStream.Length, 262144L);
					byte[] array2 = new byte[num4];
					while (fileStream.Position < fileStream.Length)
					{
						long num5 = Math.Min(fileStream.Length - fileStream.Position, (long)array2.Length);
						fileStream.Read(array2, 0, (int)num5);
						binaryWriter.Write(array2, 0, (int)num5);
						int num6 = 0;
						while ((long)num6 < num5)
						{
							if (array2[num6] == 0)
							{
								num2 += 1L;
							}
							num6++;
						}
						if ((fileStream.Position == num5 && num2 == num5) || num2 > 4L * this.arkCopyDialog_0.method_5() / 10L)
						{
							if (MessageBox.Show("It looks like the archive is mostly zeroes.\nDo you want to continue?", "Copy", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
							{
								break;
							}
							num2 = 0L;
						}
						num += num5;
						string text3 = Class109.smethod_0(now, num, this.arkCopyDialog_0.method_5());
						lock (gclass73_0)
						{
							gclass73_0.string_2 = string.Concat(new object[]
							{
								"File ",
								1 + num3,
								"/",
								this.arkCopyDialog_0.method_3().Length,
								text3
							});
							gclass73_0.int_0 = (int)(fileStream.Position * 100L / fileStream.Length);
							gclass73_0.int_1 = (int)(num * 100L / this.arkCopyDialog_0.method_5());
						}
					}
					fileStream.Close();
					binaryWriter.Close();
					num3++;
					num2 = 0L;
				}
				if (num2 == 0L)
				{
					this.bool_0 = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to copy files to hard drive!\n" + ex.Message, "Copy", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		public ArkCopyDialog arkCopyDialog_0;

		public bool bool_0;

		public string string_0;
	}

	[CompilerGenerated]
	sealed class Class83
	{
		public void method_0(ref ProgressDialog.GClass73 gclass73_0)
		{
			lock (gclass73_0)
			{
				gclass73_0.string_0 = "Shrinking..";
				gclass73_0.string_1 = "Collecting files";
			}
			List<GClass126> list = new List<GClass126>();
			if (this.arkShrinkDialog_0.method_2())
			{
				list.AddRange(this.gclass128_0.method_28("songs/", "*.vgs"));
			}
			if (this.arkShrinkDialog_0.method_0())
			{
				list.AddRange(this.gclass128_0.method_28("tutorial/", "*.vgs"));
			}
			if (this.arkShrinkDialog_0.method_1())
			{
				list.AddRange(this.gclass128_0.method_28("sfx/", "*.vgs"));
			}
			DateTime now = DateTime.Now;
			List<GClass126> list2 = list;
			if (MainWindow.Class83.comparison_0 == null)
			{
				MainWindow.Class83.comparison_0 = new Comparison<GClass126>(MainWindow.Class83.smethod_0);
			}
			list2.Sort(MainWindow.Class83.comparison_0);
			list.Reverse();
			byte[] array = new byte[16];
			array[0] = 12;
			byte[] array2 = array;
			int num = 0;
			foreach (GClass126 gclass in list)
			{
				string text = Class109.smethod_0(now, (long)num, (long)list.Count);
				lock (gclass73_0)
				{
					gclass73_0.string_1 = "Processing \"" + gclass.method_6() + "\"";
					gclass73_0.int_0 = -1;
					gclass73_0.string_2 = string.Concat(new object[]
					{
						"File ",
						1 + num,
						"/",
						list.Count,
						text
					});
					gclass73_0.int_1 = num * 100 / list.Count;
				}
				BinaryReader binaryReader = new BinaryReader(gclass.method_9());
				Class39.Struct2 @struct = Class39.smethod_0(binaryReader);
				binaryReader.Close();
				int num2 = 0;
				if (gclass.method_7().StartsWith("songs/"))
				{
					num2 = this.arkShrinkDialog_0.method_3();
				}
				int num3 = 0;
				for (int i = 0; i < @struct.struct3_0.Length; i++)
				{
					long num4 = (long)(num2 * @struct.struct3_0[i].int_0);
					@struct.struct3_0[i].int_1 = Math.Max(2, (int)(num4 / 28L));
					num3 = Math.Max(num3, @struct.struct3_0[i].int_0);
				}
				int num5 = 128;
				int[] array3 = new int[@struct.struct3_0.Length];
				for (int j = 0; j < @struct.struct3_0.Length; j++)
				{
					array3[j] = (int)((float)(num3 / @struct.struct3_0[j].int_0) + 0.5f);
					num5 += @struct.struct3_0[j].int_1 * 16;
				}
				int[] array4 = new int[@struct.struct3_0.Length];
				int num6 = 0;
				MemoryStream memoryStream = new MemoryStream(num5);
				BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
				Class39.smethod_1(binaryWriter, @struct.struct3_0);
				int k = 0;
				while (k < @struct.struct3_0.Length)
				{
					for (int l = 0; l < @struct.struct3_0.Length; l++)
					{
						if (array4[l] != -1 && num6 % array3[l] == 0)
						{
							byte b = (byte)l;
							if (array4[l] + 16 >= @struct.struct3_0[l].int_1 * 16)
							{
								b |= 128;
							}
							array2[1] = b;
							binaryWriter.Write(array2);
							array4[l] += 16;
							if ((b & 128) != 0)
							{
								array4[l] = -1;
								k++;
							}
						}
					}
					num6++;
				}
				memoryStream.Seek(0L, SeekOrigin.Begin);
				this.gclass128_0.method_23(gclass, memoryStream, ref gclass73_0, false);
				binaryWriter.Close();
				num++;
			}
		}

		static int smethod_0(GClass126 gclass126_0, GClass126 gclass126_1)
		{
			if (gclass126_0.method_11() >= gclass126_1.method_11())
			{
				return 1;
			}
			return -1;
		}

		public GClass128 gclass128_0;

		public ArkShrinkDialog arkShrinkDialog_0;

		static Comparison<GClass126> comparison_0;
	}
}
