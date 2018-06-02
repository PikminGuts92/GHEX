using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class SongPreview : UserControl
{
	public SongPreview(ArkFile gclass128_0, string string_0, List<GClass109> list_0)
	{
		this.InitializeComponent();
		ArkEntry gclass126_ = gclass128_0.method_27(string.Concat(new string[]
		{
			"songs/",
			string_0,
			"/",
			string_0,
			".mid"
		}))[0];
		this.midPreview_0 = new MidPreview(gclass126_, list_0);
		this.midPreview_0.method_32(new MidPreview.GDelegate2(this.method_0));
		this.midPreview_0.MouseDown += this.midPreview_0_MouseDown;
		this.midPreview_0.Dock = DockStyle.Fill;
		this.midPreview_0.method_11(false);
		this.midPreview_0.method_1(MidPreview.GEnum9.const_2);
		base.Controls.Add(this.midPreview_0);
		List<ArkEntry> list = gclass128_0.method_27(string.Concat(new string[]
		{
			"songs/",
			string_0,
			"/",
			string_0,
			".vgs"
		}));
		if (list.Count == 0)
		{
			list = gclass128_0.method_27(string.Concat(new string[]
			{
				"songs/",
				string_0,
				"/",
				string_0,
				"_sp.vgs"
			}));
		}
		this.vgsPreview_0 = new VgsPreview(list[0], null, list_0);
		this.vgsPreview_0.Dock = DockStyle.Top;
		this.vgsPreview_0.Height = this.vgsPreview_0.method_0();
		base.Controls.Add(this.vgsPreview_0);
		this.timer_0.Enabled = true;
	}

	void midPreview_0_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button != MouseButtons.Left)
		{
			return;
		}
		int num = this.midPreview_0.method_26(e.Location);
		if (num != -1)
		{
			this.vgsPreview_0.method_10((float)this.midPreview_0.method_9().method_5(num));
		}
	}

	void method_0(object object_0, MidPreview.GClass63 gclass63_0)
	{
		if (!this.bool_0)
		{
			this.vgsPreview_0.method_10((float)this.midPreview_0.method_9().method_5(gclass63_0.gclass140_0.int_0));
		}
	}

	void timer_0_Tick(object sender, EventArgs e)
	{
		if (!this.vgsPreview_0.method_6())
		{
			if (this.midPreview_0.method_30() != -1)
			{
				this.midPreview_0.method_31(-1);
			}
			return;
		}
		if (!this.vgsPreview_0.IsAudioPlaying() && !this.vgsPreview_0.method_8() && !this.midPreview_0.method_21())
		{
			float num = this.vgsPreview_0.method_13();
			this.bool_0 = true;
			int int_ = this.midPreview_0.method_9().method_6((double)num);
			this.midPreview_0.method_31(int_);
			this.int_0 = int_;
			this.bool_0 = false;
			return;
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

	void InitializeComponent()
	{
		this.icontainer_0 = new Container();
		this.timer_0 = new Timer(this.icontainer_0);
		base.SuspendLayout();
		this.timer_0.Interval = 33;
		this.timer_0.Tick += this.timer_0_Tick;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Name = "SongPreview";
		base.Size = new Size(375, 279);
		base.ResumeLayout(false);
	}

	VgsPreview vgsPreview_0;

	MidPreview midPreview_0;

	bool bool_0;

	int int_0;

	IContainer icontainer_0;

	Timer timer_0;
}
