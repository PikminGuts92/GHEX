using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

public class GClass123 : GClass122
{
	public GClass123()
	{
		MidiFile gclass120_ = new MidiFile(new FileStream("c:\\ghcustom\\freebird\\freebird.mid", FileMode.Open));
		this.gclass136_0 = GClass136.smethod_0(gclass120_);
		base.method_4("Untitled Song");
		this.songEditorControl_0 = new SongEditorControl(this.gclass136_0);
		this.songEditorControl_0.Dock = DockStyle.Fill;
		List<GClass123.Class104> list = new List<GClass123.Class104>();
		GClass35 gclass = this.gclass136_0.method_13("part guitar") as GClass35;
		if (gclass == null)
		{
			gclass = (this.gclass136_0.method_13("t1 gems") as GClass35);
		}
		Class64 @class = new Class64(this.songEditorControl_0, this, gclass);
		this.songEditorControl_0.method_2(@class);
		this.list_1.Add(@class);
		GClass123.Class104 class2 = new GClass123.Class104();
		class2.class64_0 = @class;
		if (gclass.method_17().CompareTo("PART GUITAR") != 0 && gclass.method_17().CompareTo("T1 GEMS") != 0)
		{
			if (gclass.method_17().CompareTo("PART BASS") == 0)
			{
				class2.int_0 = 4;
			}
		}
		else
		{
			class2.int_0 = 2;
		}
		list.Add(class2);
		this.method_19(list);
	}

	public override void vmethod_1(ToolStrip[] toolStrip_0)
	{
		base.vmethod_1(toolStrip_0);
		foreach (GClass106 gclass in this.list_1)
		{
			gclass.vmethod_5(toolStrip_0);
		}
	}

	public override void vmethod_2()
	{
		base.vmethod_2();
		foreach (GClass106 gclass in this.list_1)
		{
			gclass.vmethod_6();
		}
	}

	void method_19(List<GClass123.Class104> list_2)
	{
		GClass123.Class105 @class = new GClass123.Class105();
		@class.list_0 = list_2;
		@class.gclass123_0 = this;
		this.thread_0 = new Thread(new ThreadStart(@class.method_0));
		this.thread_0.Start();
	}

	public override Control vmethod_0()
	{
		return this.songEditorControl_0;
	}

	protected override void vmethod_4()
	{
	}

	protected override void vmethod_3(GEventArgs14 geventArgs14_0)
	{
		base.vmethod_3(geventArgs14_0);
		foreach (GClass106 gclass in this.list_1)
		{
			gclass.vmethod_4(geventArgs14_0.gclass122_0.method_10());
		}
	}

	SongEditorControl songEditorControl_0;

	GClass136 gclass136_0;

	List<GClass106> list_1 = new List<GClass106>();

	GClass118 gclass118_1 = new GClass118();

	Thread thread_0;

	class Class104
	{
		public int int_0;

		public Class64 class64_0;
	}

	[CompilerGenerated]
	sealed class Class105
	{
		public void method_0()
		{
			this.gclass123_0.gclass136_0.method_14().method_4("c:\\ghcustom\\freebird\\freebird.vgs");
			foreach (GClass123.Class104 @class in this.list_0)
			{
				@class.class64_0.method_18(this.gclass123_0.gclass136_0.method_14().method_1(@class.int_0 % this.gclass123_0.gclass136_0.method_14().method_0()));
			}
		}

		public GClass123 gclass123_0;

		public List<GClass123.Class104> list_0;
	}
}
