using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[ToolboxItem(true)]
[DesignTimeVisible(true)]
[ToolboxBitmap(typeof(GControl2))]
public class GControl2 : Control, ISupportInitialize
{
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_0(GDelegate7 gdelegate7_1)
	{
		this.gdelegate7_0 = (GDelegate7)Delegate.Combine(this.gdelegate7_0, gdelegate7_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_1(GDelegate7 gdelegate7_1)
	{
		this.gdelegate7_0 = (GDelegate7)Delegate.Remove(this.gdelegate7_0, gdelegate7_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_2(GDelegate25 gdelegate25_2)
	{
		this.gdelegate25_0 = (GDelegate25)Delegate.Combine(this.gdelegate25_0, gdelegate25_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_3(GDelegate25 gdelegate25_2)
	{
		this.gdelegate25_0 = (GDelegate25)Delegate.Remove(this.gdelegate25_0, gdelegate25_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_4(GDelegate25 gdelegate25_2)
	{
		this.gdelegate25_1 = (GDelegate25)Delegate.Combine(this.gdelegate25_1, gdelegate25_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_5(GDelegate25 gdelegate25_2)
	{
		this.gdelegate25_1 = (GDelegate25)Delegate.Remove(this.gdelegate25_1, gdelegate25_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_6(GDelegate29 gdelegate29_2)
	{
		this.gdelegate29_0 = (GDelegate29)Delegate.Combine(this.gdelegate29_0, gdelegate29_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_7(GDelegate29 gdelegate29_2)
	{
		this.gdelegate29_0 = (GDelegate29)Delegate.Remove(this.gdelegate29_0, gdelegate29_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_8(GDelegate29 gdelegate29_2)
	{
		this.gdelegate29_1 = (GDelegate29)Delegate.Combine(this.gdelegate29_1, gdelegate29_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_9(GDelegate29 gdelegate29_2)
	{
		this.gdelegate29_1 = (GDelegate29)Delegate.Remove(this.gdelegate29_1, gdelegate29_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_10(GDelegate14 gdelegate14_8)
	{
		this.gdelegate14_0 = (GDelegate14)Delegate.Combine(this.gdelegate14_0, gdelegate14_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_11(GDelegate14 gdelegate14_8)
	{
		this.gdelegate14_0 = (GDelegate14)Delegate.Remove(this.gdelegate14_0, gdelegate14_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_12(GDelegate14 gdelegate14_8)
	{
		this.gdelegate14_1 = (GDelegate14)Delegate.Combine(this.gdelegate14_1, gdelegate14_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_13(GDelegate14 gdelegate14_8)
	{
		this.gdelegate14_1 = (GDelegate14)Delegate.Remove(this.gdelegate14_1, gdelegate14_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_14(GDelegate14 gdelegate14_8)
	{
		this.gdelegate14_2 = (GDelegate14)Delegate.Combine(this.gdelegate14_2, gdelegate14_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_15(GDelegate14 gdelegate14_8)
	{
		this.gdelegate14_2 = (GDelegate14)Delegate.Remove(this.gdelegate14_2, gdelegate14_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_16(GDelegate14 gdelegate14_8)
	{
		this.gdelegate14_3 = (GDelegate14)Delegate.Combine(this.gdelegate14_3, gdelegate14_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_17(GDelegate14 gdelegate14_8)
	{
		this.gdelegate14_3 = (GDelegate14)Delegate.Remove(this.gdelegate14_3, gdelegate14_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_18(GDelegate14 gdelegate14_8)
	{
		this.gdelegate14_4 = (GDelegate14)Delegate.Combine(this.gdelegate14_4, gdelegate14_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_19(GDelegate14 gdelegate14_8)
	{
		this.gdelegate14_4 = (GDelegate14)Delegate.Remove(this.gdelegate14_4, gdelegate14_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_20(GDelegate14 gdelegate14_8)
	{
		this.gdelegate14_5 = (GDelegate14)Delegate.Combine(this.gdelegate14_5, gdelegate14_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_21(GDelegate14 gdelegate14_8)
	{
		this.gdelegate14_5 = (GDelegate14)Delegate.Remove(this.gdelegate14_5, gdelegate14_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_22(GDelegate14 gdelegate14_8)
	{
		this.gdelegate14_6 = (GDelegate14)Delegate.Combine(this.gdelegate14_6, gdelegate14_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_23(GDelegate14 gdelegate14_8)
	{
		this.gdelegate14_6 = (GDelegate14)Delegate.Remove(this.gdelegate14_6, gdelegate14_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_24(GDelegate14 gdelegate14_8)
	{
		this.gdelegate14_7 = (GDelegate14)Delegate.Combine(this.gdelegate14_7, gdelegate14_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_25(GDelegate14 gdelegate14_8)
	{
		this.gdelegate14_7 = (GDelegate14)Delegate.Remove(this.gdelegate14_7, gdelegate14_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_26(GDelegate10 gdelegate10_1)
	{
		this.gdelegate10_0 = (GDelegate10)Delegate.Combine(this.gdelegate10_0, gdelegate10_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_27(GDelegate10 gdelegate10_1)
	{
		this.gdelegate10_0 = (GDelegate10)Delegate.Remove(this.gdelegate10_0, gdelegate10_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_28(GDelegate26 gdelegate26_1)
	{
		this.gdelegate26_0 = (GDelegate26)Delegate.Combine(this.gdelegate26_0, gdelegate26_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_29(GDelegate26 gdelegate26_1)
	{
		this.gdelegate26_0 = (GDelegate26)Delegate.Remove(this.gdelegate26_0, gdelegate26_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_30(GDelegate11 gdelegate11_3)
	{
		this.gdelegate11_0 = (GDelegate11)Delegate.Combine(this.gdelegate11_0, gdelegate11_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_31(GDelegate11 gdelegate11_3)
	{
		this.gdelegate11_0 = (GDelegate11)Delegate.Remove(this.gdelegate11_0, gdelegate11_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_32(GDelegate28 gdelegate28_8)
	{
		this.gdelegate28_0 = (GDelegate28)Delegate.Combine(this.gdelegate28_0, gdelegate28_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_33(GDelegate28 gdelegate28_8)
	{
		this.gdelegate28_0 = (GDelegate28)Delegate.Remove(this.gdelegate28_0, gdelegate28_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_34(GDelegate28 gdelegate28_8)
	{
		this.gdelegate28_1 = (GDelegate28)Delegate.Combine(this.gdelegate28_1, gdelegate28_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_35(GDelegate28 gdelegate28_8)
	{
		this.gdelegate28_1 = (GDelegate28)Delegate.Remove(this.gdelegate28_1, gdelegate28_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_36(GDelegate28 gdelegate28_8)
	{
		this.gdelegate28_2 = (GDelegate28)Delegate.Combine(this.gdelegate28_2, gdelegate28_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_37(GDelegate28 gdelegate28_8)
	{
		this.gdelegate28_2 = (GDelegate28)Delegate.Remove(this.gdelegate28_2, gdelegate28_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_38(GDelegate28 gdelegate28_8)
	{
		this.gdelegate28_3 = (GDelegate28)Delegate.Combine(this.gdelegate28_3, gdelegate28_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_39(GDelegate28 gdelegate28_8)
	{
		this.gdelegate28_3 = (GDelegate28)Delegate.Remove(this.gdelegate28_3, gdelegate28_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_40(GDelegate28 gdelegate28_8)
	{
		this.gdelegate28_4 = (GDelegate28)Delegate.Combine(this.gdelegate28_4, gdelegate28_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_41(GDelegate28 gdelegate28_8)
	{
		this.gdelegate28_4 = (GDelegate28)Delegate.Remove(this.gdelegate28_4, gdelegate28_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_42(GDelegate28 gdelegate28_8)
	{
		this.gdelegate28_5 = (GDelegate28)Delegate.Combine(this.gdelegate28_5, gdelegate28_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_43(GDelegate28 gdelegate28_8)
	{
		this.gdelegate28_5 = (GDelegate28)Delegate.Remove(this.gdelegate28_5, gdelegate28_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_44(GDelegate28 gdelegate28_8)
	{
		this.gdelegate28_6 = (GDelegate28)Delegate.Combine(this.gdelegate28_6, gdelegate28_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_45(GDelegate28 gdelegate28_8)
	{
		this.gdelegate28_6 = (GDelegate28)Delegate.Remove(this.gdelegate28_6, gdelegate28_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_46(GDelegate28 gdelegate28_8)
	{
		this.gdelegate28_7 = (GDelegate28)Delegate.Combine(this.gdelegate28_7, gdelegate28_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_47(GDelegate28 gdelegate28_8)
	{
		this.gdelegate28_7 = (GDelegate28)Delegate.Remove(this.gdelegate28_7, gdelegate28_8);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_48(EventHandler eventHandler_4)
	{
		this.eventHandler_0 = (EventHandler)Delegate.Combine(this.eventHandler_0, eventHandler_4);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_49(EventHandler eventHandler_4)
	{
		this.eventHandler_0 = (EventHandler)Delegate.Remove(this.eventHandler_0, eventHandler_4);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_50(EventHandler eventHandler_4)
	{
		this.eventHandler_1 = (EventHandler)Delegate.Combine(this.eventHandler_1, eventHandler_4);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_51(EventHandler eventHandler_4)
	{
		this.eventHandler_1 = (EventHandler)Delegate.Remove(this.eventHandler_1, eventHandler_4);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_52(GDelegate9 gdelegate9_2)
	{
		this.gdelegate9_0 = (GDelegate9)Delegate.Combine(this.gdelegate9_0, gdelegate9_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_53(GDelegate9 gdelegate9_2)
	{
		this.gdelegate9_0 = (GDelegate9)Delegate.Remove(this.gdelegate9_0, gdelegate9_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_54(GDelegate9 gdelegate9_2)
	{
		this.gdelegate9_1 = (GDelegate9)Delegate.Combine(this.gdelegate9_1, gdelegate9_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_55(GDelegate9 gdelegate9_2)
	{
		this.gdelegate9_1 = (GDelegate9)Delegate.Remove(this.gdelegate9_1, gdelegate9_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_56(GDelegate27 gdelegate27_3)
	{
		this.gdelegate27_0 = (GDelegate27)Delegate.Combine(this.gdelegate27_0, gdelegate27_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_57(GDelegate27 gdelegate27_3)
	{
		this.gdelegate27_0 = (GDelegate27)Delegate.Remove(this.gdelegate27_0, gdelegate27_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_58(GDelegate27 gdelegate27_3)
	{
		this.gdelegate27_1 = (GDelegate27)Delegate.Combine(this.gdelegate27_1, gdelegate27_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_59(GDelegate27 gdelegate27_3)
	{
		this.gdelegate27_1 = (GDelegate27)Delegate.Remove(this.gdelegate27_1, gdelegate27_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_60(GDelegate27 gdelegate27_3)
	{
		this.gdelegate27_2 = (GDelegate27)Delegate.Combine(this.gdelegate27_2, gdelegate27_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_61(GDelegate27 gdelegate27_3)
	{
		this.gdelegate27_2 = (GDelegate27)Delegate.Remove(this.gdelegate27_2, gdelegate27_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_62(GDelegate3 gdelegate3_3)
	{
		this.gdelegate3_0 = (GDelegate3)Delegate.Combine(this.gdelegate3_0, gdelegate3_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_63(GDelegate3 gdelegate3_3)
	{
		this.gdelegate3_0 = (GDelegate3)Delegate.Remove(this.gdelegate3_0, gdelegate3_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_64(GDelegate3 gdelegate3_3)
	{
		this.gdelegate3_1 = (GDelegate3)Delegate.Combine(this.gdelegate3_1, gdelegate3_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_65(GDelegate3 gdelegate3_3)
	{
		this.gdelegate3_1 = (GDelegate3)Delegate.Remove(this.gdelegate3_1, gdelegate3_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_66(GDelegate3 gdelegate3_3)
	{
		this.gdelegate3_2 = (GDelegate3)Delegate.Combine(this.gdelegate3_2, gdelegate3_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_67(GDelegate3 gdelegate3_3)
	{
		this.gdelegate3_2 = (GDelegate3)Delegate.Remove(this.gdelegate3_2, gdelegate3_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_68(GDelegate11 gdelegate11_3)
	{
		this.gdelegate11_1 = (GDelegate11)Delegate.Combine(this.gdelegate11_1, gdelegate11_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_69(GDelegate11 gdelegate11_3)
	{
		this.gdelegate11_1 = (GDelegate11)Delegate.Remove(this.gdelegate11_1, gdelegate11_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_70(GDelegate11 gdelegate11_3)
	{
		this.gdelegate11_2 = (GDelegate11)Delegate.Combine(this.gdelegate11_2, gdelegate11_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_71(GDelegate11 gdelegate11_3)
	{
		this.gdelegate11_2 = (GDelegate11)Delegate.Remove(this.gdelegate11_2, gdelegate11_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_72(GDelegate5 gdelegate5_2)
	{
		this.gdelegate5_0 = (GDelegate5)Delegate.Combine(this.gdelegate5_0, gdelegate5_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_73(GDelegate5 gdelegate5_2)
	{
		this.gdelegate5_0 = (GDelegate5)Delegate.Remove(this.gdelegate5_0, gdelegate5_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_74(GDelegate5 gdelegate5_2)
	{
		this.gdelegate5_1 = (GDelegate5)Delegate.Combine(this.gdelegate5_1, gdelegate5_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_75(GDelegate5 gdelegate5_2)
	{
		this.gdelegate5_1 = (GDelegate5)Delegate.Remove(this.gdelegate5_1, gdelegate5_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_76(GDelegate4 gdelegate4_2)
	{
		this.gdelegate4_0 = (GDelegate4)Delegate.Combine(this.gdelegate4_0, gdelegate4_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_77(GDelegate4 gdelegate4_2)
	{
		this.gdelegate4_0 = (GDelegate4)Delegate.Remove(this.gdelegate4_0, gdelegate4_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_78(GDelegate4 gdelegate4_2)
	{
		this.gdelegate4_1 = (GDelegate4)Delegate.Combine(this.gdelegate4_1, gdelegate4_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_79(GDelegate4 gdelegate4_2)
	{
		this.gdelegate4_1 = (GDelegate4)Delegate.Remove(this.gdelegate4_1, gdelegate4_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_80(EventHandler eventHandler_4)
	{
		this.eventHandler_2 = (EventHandler)Delegate.Combine(this.eventHandler_2, eventHandler_4);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_81(EventHandler eventHandler_4)
	{
		this.eventHandler_2 = (EventHandler)Delegate.Remove(this.eventHandler_2, eventHandler_4);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_82(GDelegate8 gdelegate8_2)
	{
		this.gdelegate8_0 = (GDelegate8)Delegate.Combine(this.gdelegate8_0, gdelegate8_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_83(GDelegate8 gdelegate8_2)
	{
		this.gdelegate8_0 = (GDelegate8)Delegate.Remove(this.gdelegate8_0, gdelegate8_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_84(GDelegate8 gdelegate8_2)
	{
		this.gdelegate8_1 = (GDelegate8)Delegate.Combine(this.gdelegate8_1, gdelegate8_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_85(GDelegate8 gdelegate8_2)
	{
		this.gdelegate8_1 = (GDelegate8)Delegate.Remove(this.gdelegate8_1, gdelegate8_2);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_86(GDelegate18 gdelegate18_1)
	{
		this.gdelegate18_0 = (GDelegate18)Delegate.Combine(this.gdelegate18_0, gdelegate18_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_87(GDelegate18 gdelegate18_1)
	{
		this.gdelegate18_0 = (GDelegate18)Delegate.Remove(this.gdelegate18_0, gdelegate18_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_88(EventHandler eventHandler_4)
	{
		this.eventHandler_3 = (EventHandler)Delegate.Combine(this.eventHandler_3, eventHandler_4);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_89(EventHandler eventHandler_4)
	{
		this.eventHandler_3 = (EventHandler)Delegate.Remove(this.eventHandler_3, eventHandler_4);
	}

	public GControl2()
	{
		this.bool_6 = true;
		this.container_0 = new Container();
		base.SetStyle(ControlStyles.UserPaint, true);
		base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
		base.SetStyle(ControlStyles.DoubleBuffer, true);
		base.SetStyle(ControlStyles.ResizeRedraw, true);
		base.SetStyle(ControlStyles.Selectable, true);
		base.TabStop = true;
		base.Size = new Size(150, 150);
		this.BackColor = Color.White;
		this.gclass32_0 = null;
		this.gclass104_0 = null;
		this.columnHeaderStyle_0 = ColumnHeaderStyle.Clickable;
		this.font_0 = this.Font;
		this.gclass13_0 = new GClass16();
		this.gclass13_0.imethod_4(this.font_0);
		this.gclass77_0 = new GClass77();
		this.bool_0 = true;
		this.int_1 = -1;
		this.int_4 = -1;
		this.int_6 = -1;
		this.int_5 = -1;
		this.int_7 = -1;
		this.color_0 = Color.WhiteSmoke;
		this.borderStyle_0 = BorderStyle.Fixed3D;
		this.bool_1 = true;
		this.hscrollBar_0 = new HScrollBar();
		this.hscrollBar_0.Visible = false;
		this.hscrollBar_0.Location = new Point(this.method_156(), base.Height - this.method_156() - SystemInformation.HorizontalScrollBarHeight);
		this.hscrollBar_0.Width = base.Width - this.method_156() * 2 - SystemInformation.VerticalScrollBarWidth;
		this.hscrollBar_0.Scroll += this.hscrollBar_0_Scroll;
		base.Controls.Add(this.hscrollBar_0);
		this.vscrollBar_0 = new VScrollBar();
		this.vscrollBar_0.Visible = false;
		this.vscrollBar_0.Location = new Point(base.Width - this.method_156() - SystemInformation.VerticalScrollBarWidth, this.method_156());
		this.vscrollBar_0.Height = base.Height - this.method_156() * 2 - SystemInformation.HorizontalScrollBarHeight;
		this.vscrollBar_0.Scroll += this.vscrollBar_0_Scroll;
		base.Controls.Add(this.vscrollBar_0);
		this.genum3_0 = GEnum3.const_0;
		this.color_1 = SystemColors.Control;
		this.genum61_0 = GEnum61.const_0;
		this.bool_2 = true;
		this.bool_3 = false;
		this.bool_4 = false;
		this.bool_5 = false;
		this.color_2 = SystemColors.Highlight;
		this.color_3 = SystemColors.HighlightText;
		this.color_4 = SystemColors.Control;
		this.color_5 = SystemColors.ControlText;
		this.genum29_0 = GEnum29.const_0;
		this.color_6 = Color.Transparent;
		this.genum45_0 = GEnum45.const_0;
		this.gstruct9_0 = new GStruct9(-1, -1);
		this.gstruct9_1 = new GStruct9(-1, -1);
		this.gstruct9_2 = new GStruct9(-1, -1);
		this.int_0 = 1000;
		this.class85_0 = null;
		this.method_138();
		this.toolTip_0 = new ToolTip(this.container_0);
		this.toolTip_0.Active = false;
		this.toolTip_0.InitialDelay = 1000;
		this.string_0 = "There are no items in this view";
		this.gstruct9_3 = new GStruct9(-1, -1);
		this.ginterface3_0 = null;
		this.genum7_0 = GEnum7.const_0;
		this.keys_0 = Keys.F5;
		this.int_8 = 0;
		this.bool_6 = false;
		this.bool_7 = false;
	}

	public Point method_90(int int_9, int int_10)
	{
		int num = int_9 - this.method_156();
		if (this.method_213())
		{
			num += this.hscrollBar_0.Value;
		}
		int num2 = int_10 - this.method_156();
		if (this.method_214())
		{
			num2 += this.method_207() * this.method_202();
		}
		return new Point(num, num2);
	}

	public Point method_91(Point point_0)
	{
		return this.method_90(point_0.X, point_0.Y);
	}

	public Rectangle method_92(Rectangle rectangle_0)
	{
		return new Rectangle(this.method_91(rectangle_0.Location), rectangle_0.Size);
	}

	public Point method_93(int int_9, int int_10)
	{
		int num = int_9 + this.method_156();
		if (this.method_213())
		{
			num -= this.hscrollBar_0.Value;
		}
		int num2 = int_10 + this.method_156();
		if (this.method_214())
		{
			num2 -= this.method_207() * this.method_202();
		}
		return new Point(num, num2);
	}

	public Point method_94(Point point_0)
	{
		return this.method_93(point_0.X, point_0.Y);
	}

	public Rectangle method_95(Rectangle rectangle_0)
	{
		return new Rectangle(this.method_94(rectangle_0.Location), rectangle_0.Size);
	}

	public GClass97 method_96(int int_9, int int_10)
	{
		int num = this.method_111(int_9, int_10);
		int num2 = this.method_105(int_9, int_10);
		if (num != -1 && num < this.method_239().method_12().Count && num2 != -1 && num2 < this.method_239().method_12().method_9(num).method_9().Count)
		{
			return this.method_239().method_10(num, num2);
		}
		return null;
	}

	public GClass97 method_97(Point point_0)
	{
		return this.method_96(point_0.X, point_0.Y);
	}

	public Rectangle method_98(int int_9, int int_10)
	{
		if (int_9 == -1 || int_9 >= this.method_239().method_12().Count || int_10 == -1 || int_10 >= this.method_239().method_12().method_9(int_9).method_9().Count)
		{
			return Rectangle.Empty;
		}
		Rectangle rectangle = this.method_109(int_10);
		if (rectangle == Rectangle.Empty)
		{
			return rectangle;
		}
		Rectangle rectangle2 = this.method_113(int_9);
		if (rectangle2 == Rectangle.Empty)
		{
			return rectangle2;
		}
		return new Rectangle(rectangle.X, rectangle2.Y, rectangle.Width, rectangle2.Height);
	}

	public Rectangle method_99(GStruct9 gstruct9_4)
	{
		return this.method_98(gstruct9_4.method_1(), gstruct9_4.method_3());
	}

	public Rectangle method_100(GClass97 gclass97_0)
	{
		if (gclass97_0 != null && gclass97_0.method_47() != null)
		{
			if (gclass97_0.method_51() != -1)
			{
				if (this.method_239() != null && this.method_166() != null)
				{
					int int_ = this.method_239().method_12().method_8(gclass97_0.method_47());
					int int_2 = gclass97_0.method_51();
					return this.method_98(int_, int_2);
				}
				return Rectangle.Empty;
			}
		}
		return Rectangle.Empty;
	}

	protected internal bool method_101(int int_9, int int_10)
	{
		return this.method_239() != null && this.method_166() != null && int_9 >= 0 && int_9 < this.method_239().method_12().Count && int_10 >= 0 && int_10 < this.method_166().method_23().Count && this.method_239().method_12().method_9(int_9).method_9().method_9(int_10) != null;
	}

	protected internal bool method_102(GStruct9 gstruct9_4)
	{
		return this.method_101(gstruct9_4.method_1(), gstruct9_4.method_3());
	}

	protected GStruct9 method_103(GStruct9 gstruct9_4, bool bool_8, bool bool_9, bool bool_10, bool bool_11)
	{
		if (this.method_170() != 0 && this.method_205() != 0)
		{
			int num = (gstruct9_4.method_1() != -1) ? gstruct9_4.method_1() : 0;
			int num2 = (gstruct9_4.method_3() != -1) ? gstruct9_4.method_3() : 0;
			bool flag = true;
			if (bool_9)
			{
				for (int i = num; i < this.method_205(); i++)
				{
					int j = (flag || !bool_11) ? num2 : 0;
					while (j < this.method_239().method_12().method_9(i).method_9().Count)
					{
						if (i != num || j != num2)
						{
							goto IL_7F;
						}
						if (!flag)
						{
							return GStruct9.gstruct9_0;
						}
						flag = false;
						if (bool_10)
						{
							goto IL_7F;
						}
						if (!bool_11)
						{
							break;
						}
						IL_DB:
						j++;
						continue;
						IL_7F:
						if (!this.method_101(i, j) || !this.method_153(j) || !this.method_239().method_10(i, j).method_40() || !this.method_166().method_23().method_8(j).method_31() || !this.method_166().method_23().method_8(j).method_19())
						{
							goto IL_DB;
						}
						return new GStruct9(i, j);
					}
					if (!bool_8)
					{
						break;
					}
					if (i + 1 == this.method_239().method_12().Count)
					{
						i = -1;
					}
				}
			}
			else
			{
				for (int k = num; k >= 0; k--)
				{
					int l = (flag || !bool_11) ? num2 : this.method_239().method_12().method_9(k).method_9().Count;
					while (l >= 0)
					{
						if (k != num || l != num2)
						{
							goto IL_195;
						}
						if (!flag)
						{
							return GStruct9.gstruct9_0;
						}
						flag = false;
						if (bool_10)
						{
							goto IL_195;
						}
						if (!bool_11)
						{
							break;
						}
						IL_1F3:
						l--;
						continue;
						IL_195:
						if (!this.method_101(k, l) || !this.method_153(l) || !this.method_239().method_10(k, l).method_40() || !this.method_166().method_23().method_8(l).method_31() || !this.method_166().method_23().method_8(l).method_19())
						{
							goto IL_1F3;
						}
						return new GStruct9(k, l);
					}
					if (!bool_8)
					{
						break;
					}
					if (k - 1 == -1)
					{
						k = this.method_239().method_12().Count;
					}
				}
			}
			return GStruct9.gstruct9_0;
		}
		return GStruct9.gstruct9_0;
	}

	protected GStruct9 method_104(GStruct9 gstruct9_4, bool bool_8, bool bool_9, bool bool_10)
	{
		if (this.method_170() != 0 && this.method_205() != 0)
		{
			int num = (gstruct9_4.method_1() != -1) ? gstruct9_4.method_1() : 0;
			int num2 = (gstruct9_4.method_3() != -1) ? gstruct9_4.method_3() : 0;
			bool flag = true;
			if (bool_9)
			{
				for (int i = num; i < this.method_205(); i++)
				{
					int j = flag ? num2 : 0;
					while (j < this.method_239().method_12().method_9(i).method_9().Count)
					{
						if (i != num || j != num2)
						{
							goto IL_6F;
						}
						if (!flag)
						{
							return GStruct9.gstruct9_0;
						}
						flag = false;
						if (bool_10)
						{
							goto IL_6F;
						}
						IL_B2:
						j++;
						continue;
						IL_6F:
						if (!this.method_101(i, j) || !this.method_153(j) || !this.method_239().method_10(i, j).method_37() || !this.method_166().method_23().method_8(j).vmethod_9())
						{
							goto IL_B2;
						}
						return new GStruct9(i, j);
					}
					if (!bool_8)
					{
						break;
					}
					if (i + 1 == this.method_239().method_12().Count)
					{
						i = -1;
					}
				}
			}
			else
			{
				for (int k = num; k >= 0; k--)
				{
					int l = flag ? num2 : this.method_239().method_12().method_9(k).method_9().Count;
					while (l >= 0)
					{
						if (k != num || l != num2)
						{
							goto IL_15C;
						}
						if (!flag)
						{
							return GStruct9.gstruct9_0;
						}
						flag = false;
						if (bool_10)
						{
							goto IL_15C;
						}
						IL_1A1:
						l--;
						continue;
						IL_15C:
						if (!this.method_101(k, l) || !this.method_153(l) || !this.method_239().method_10(k, l).method_37() || !this.method_166().method_23().method_8(l).vmethod_9())
						{
							goto IL_1A1;
						}
						return new GStruct9(k, l);
					}
					if (!bool_8)
					{
						break;
					}
					if (k - 1 == -1)
					{
						k = this.method_239().method_12().Count;
					}
				}
			}
			return GStruct9.gstruct9_0;
		}
		return GStruct9.gstruct9_0;
	}

	public int method_105(int int_9, int int_10)
	{
		if (this.method_166() == null)
		{
			return -1;
		}
		return this.method_166().method_7(this.hscrollBar_0.Value + int_9 - this.method_156());
	}

	public int method_106(Point point_0)
	{
		return this.method_105(point_0.X, point_0.Y);
	}

	public Rectangle method_107(int int_9)
	{
		if (this.method_166() == null)
		{
			return Rectangle.Empty;
		}
		Rectangle rectangle = this.method_166().method_9(int_9);
		if (rectangle == Rectangle.Empty)
		{
			return rectangle;
		}
		rectangle.X -= this.hscrollBar_0.Value - this.method_156();
		rectangle.Y = this.method_156();
		return rectangle;
	}

	public Rectangle method_108(GClass17 gclass17_0)
	{
		if (this.method_166() == null)
		{
			return Rectangle.Empty;
		}
		return this.method_107(this.method_166().method_23().method_6(gclass17_0));
	}

	public Rectangle method_109(int int_9)
	{
		if (this.method_166() == null)
		{
			return Rectangle.Empty;
		}
		Rectangle rectangle = this.method_107(int_9);
		if (rectangle == Rectangle.Empty)
		{
			return rectangle;
		}
		rectangle.Y += this.method_192();
		rectangle.Height = this.method_203();
		return rectangle;
	}

	public Rectangle method_110(GClass17 gclass17_0)
	{
		if (this.method_166() == null)
		{
			return Rectangle.Empty;
		}
		return this.method_109(this.method_166().method_23().method_6(gclass17_0));
	}

	public int method_111(int int_9, int int_10)
	{
		if (this.method_239() == null)
		{
			return -1;
		}
		if (this.method_190() != ColumnHeaderStyle.None)
		{
			int_10 -= this.method_192();
		}
		int_10 -= this.method_156();
		if (int_10 < 0)
		{
			return -1;
		}
		if (this.method_214())
		{
			int_10 += this.method_207() * this.method_202();
		}
		return this.method_239().method_9(int_10);
	}

	public int method_112(Point point_0)
	{
		return this.method_111(point_0.X, point_0.Y);
	}

	public Rectangle method_113(int int_9)
	{
		if (this.method_239() != null && this.method_166() != null && int_9 != -1 && int_9 <= this.method_239().method_12().Count)
		{
			Rectangle result = default(Rectangle);
			result.X = this.DisplayRectangle.X;
			result.Y = this.method_156() + (int_9 - this.method_207()) * this.method_202();
			result.Width = this.method_166().method_29();
			result.Height = this.method_202();
			if (this.method_190() != ColumnHeaderStyle.None)
			{
				result.Y += this.method_192();
			}
			return result;
		}
		return Rectangle.Empty;
	}

	public Rectangle method_114(GClass83 gclass83_0)
	{
		if (this.method_239() == null)
		{
			return Rectangle.Empty;
		}
		return this.method_113(this.method_239().method_12().method_8(gclass83_0));
	}

	public GEnum2 method_115(int int_9, int int_10)
	{
		if (this.method_190() != ColumnHeaderStyle.None && this.method_193().Contains(int_9, int_10))
		{
			return GEnum2.const_1;
		}
		if (this.method_164().Contains(int_9, int_10))
		{
			return GEnum2.const_0;
		}
		if (!base.Bounds.Contains(int_9, int_10))
		{
			return GEnum2.const_3;
		}
		return GEnum2.const_2;
	}

	public GEnum2 method_116(Point point_0)
	{
		return this.method_115(point_0.X, point_0.Y);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.container_0 != null)
		{
			this.container_0.Dispose();
		}
		base.Dispose(disposing);
	}

	public void method_117()
	{
		if (this.method_166() != null)
		{
			this.method_167(null);
		}
		if (this.method_239() != null)
		{
			this.method_240(null);
		}
	}

	void method_118(GClass97 gclass97_0, GInterface3 ginterface3_1)
	{
		this.method_119(new GStruct9(gclass97_0.method_47().method_35(), gclass97_0.method_51()), ginterface3_1);
	}

	void method_119(GStruct9 gstruct9_4, GInterface3 ginterface3_1)
	{
		this.gstruct9_3 = gstruct9_4;
		this.ginterface3_0 = ginterface3_1;
	}

	public void method_120(int int_9, int int_10)
	{
		this.method_121(new GStruct9(int_9, int_10));
	}

	public void method_121(GStruct9 gstruct9_4)
	{
		if (!this.method_102(gstruct9_4) || !this.method_166().method_23().method_8(gstruct9_4.method_3()).method_19() || !this.method_125(gstruct9_4))
		{
			return;
		}
		if (GStruct9.smethod_1(this.method_176(), GStruct9.gstruct9_0))
		{
			if (GStruct9.smethod_0(this.method_176(), gstruct9_4))
			{
				return;
			}
			this.method_177().imethod_2();
		}
		GClass97 gclass = this.method_239().method_11(gstruct9_4);
		GInterface3 ginterface = this.method_166().method_12(gstruct9_4.method_3());
		if (ginterface != null && gclass.method_37() && this.method_166().method_23().method_8(gstruct9_4.method_3()).vmethod_9())
		{
			if (this.method_143(gstruct9_4))
			{
				this.Refresh();
			}
			Rectangle rectangle = this.method_99(gstruct9_4);
			GEventArgs5 geventArgs = new GEventArgs5(gclass, ginterface, this, gstruct9_4.method_1(), gstruct9_4.method_3(), rectangle);
			this.vmethod_28(geventArgs);
			if (!geventArgs.method_9())
			{
				if (!ginterface.imethod_0(gclass, this, gstruct9_4, rectangle, geventArgs.method_11()))
				{
					return;
				}
				this.gstruct9_3 = gstruct9_4;
				this.ginterface3_0 = ginterface;
				ginterface.imethod_1();
			}
			return;
		}
	}

	public void method_122()
	{
		if (GStruct9.smethod_0(this.method_176(), GStruct9.gstruct9_0))
		{
			return;
		}
		this.method_177().imethod_2();
		base.Invalidate(this.method_113(this.gstruct9_3.method_1()));
		this.gstruct9_3 = GStruct9.gstruct9_0;
		this.ginterface3_0 = null;
	}

	public void method_123()
	{
		if (GStruct9.smethod_0(this.method_176(), GStruct9.gstruct9_0))
		{
			return;
		}
		this.method_177().imethod_3();
		this.gstruct9_3 = GStruct9.gstruct9_0;
		this.ginterface3_0 = null;
	}

	public bool method_124(int int_9, int int_10)
	{
		return this.method_125(new GStruct9(int_9, int_10));
	}

	public bool method_125(GStruct9 gstruct9_4)
	{
		return this.method_102(gstruct9_4) && this.method_166().method_23().method_8(gstruct9_4.method_3()).method_19() && this.method_239().method_11(gstruct9_4).method_37() && this.method_166().method_23().method_8(gstruct9_4.method_3()).vmethod_9();
	}

	public bool method_126(int int_9, int int_10)
	{
		return this.method_127(new GStruct9(int_9, int_10));
	}

	public bool method_127(GStruct9 gstruct9_4)
	{
		return this.method_102(gstruct9_4) && this.method_166().method_23().method_8(gstruct9_4.method_3()).method_19() && this.method_239().method_11(gstruct9_4).method_40() && this.method_166().method_23().method_8(gstruct9_4.method_3()).method_31();
	}

	public void method_128(GClass97 gclass97_0)
	{
		this.method_129(gclass97_0.method_47().method_34(), gclass97_0.method_50());
	}

	public void method_129(int int_9, int int_10)
	{
		Rectangle rectangle = this.method_98(int_9, int_10);
		if (rectangle == Rectangle.Empty)
		{
			return;
		}
		if (rectangle.IntersectsWith(this.method_164()))
		{
			base.Invalidate(Rectangle.Intersect(this.method_164(), rectangle), false);
		}
	}

	public void method_130(GStruct9 gstruct9_4)
	{
		this.method_129(gstruct9_4.method_1(), gstruct9_4.method_3());
	}

	public void method_131(GClass83 gclass83_0)
	{
		this.method_132(gclass83_0.method_34());
	}

	public void method_132(int int_9)
	{
		Rectangle rectangle = this.method_113(int_9);
		if (rectangle == Rectangle.Empty)
		{
			return;
		}
		if (rectangle.IntersectsWith(this.method_164()))
		{
			base.Invalidate(Rectangle.Intersect(this.method_164(), rectangle), false);
		}
	}

	public void method_133(GStruct9 gstruct9_4)
	{
		this.method_132(gstruct9_4.method_1());
	}

	protected internal bool method_134(Keys keys_1)
	{
		if ((keys_1 & Keys.Alt) != Keys.Alt)
		{
			Keys keys = keys_1 & Keys.KeyCode;
			return keys == Keys.Up || keys == Keys.Down || keys == Keys.Left || keys == Keys.Right || keys == Keys.Prior || keys == Keys.Next || keys == Keys.Home || keys == Keys.End || keys == Keys.Tab;
		}
		return false;
	}

	protected virtual bool IsInputKey(Keys keyData)
	{
		if ((keyData & Keys.Alt) != Keys.Alt)
		{
			switch (keyData & Keys.KeyCode)
			{
			case Keys.Prior:
			case Keys.Next:
			case Keys.End:
			case Keys.Home:
			case Keys.Left:
			case Keys.Up:
			case Keys.Right:
			case Keys.Down:
				return true;
			default:
				if (base.IsInputKey(keyData))
				{
					return true;
				}
				break;
			}
		}
		return false;
	}

	public void method_135()
	{
		if (base.IsHandleCreated)
		{
			if (this.int_8 == 0)
			{
				Class96.SendMessage(base.Handle, 11, 0, 0);
			}
			this.int_8++;
		}
	}

	public void method_136()
	{
		if (this.int_8 <= 0)
		{
			return;
		}
		this.int_8--;
		if (this.int_8 == 0)
		{
			Class96.SendMessage(base.Handle, 11, -1, 0);
			base.PerformLayout();
			base.Invalidate(true);
		}
	}

	public void BeginInit()
	{
		this.bool_6 = true;
	}

	public void EndInit()
	{
		this.bool_6 = false;
		base.PerformLayout();
	}

	public bool method_137()
	{
		return this.bool_6;
	}

	public void method_138()
	{
		if (this.class85_0 == null)
		{
			this.class85_0 = new Class85();
			this.class85_0.int_1 = 3;
			this.class85_0.intptr_0 = base.Handle;
		}
		this.class85_0.int_2 = this.method_161();
		Class96.TrackMouseEvent(this.class85_0);
	}

	public void method_139()
	{
		if (!this.method_211() || this.method_166() == null)
		{
			return;
		}
		if (base.Width != 0 && base.Height != 0)
		{
			bool flag = this.method_166().method_29() > base.Width - this.method_156() * 2;
			bool flag2;
			if (flag2 = (this.method_204() > base.Height - this.method_156() * 2 - (flag ? SystemInformation.HorizontalScrollBarHeight : 0)))
			{
				flag = (this.method_166().method_29() > base.Width - this.method_156() * 2 - SystemInformation.VerticalScrollBarWidth);
			}
			if (flag)
			{
				Rectangle bounds = new Rectangle(this.method_156(), base.Height - this.method_156() - SystemInformation.HorizontalScrollBarHeight, base.Width - this.method_156() * 2, SystemInformation.HorizontalScrollBarHeight);
				if (flag2)
				{
					bounds.Width -= SystemInformation.VerticalScrollBarWidth;
				}
				this.hscrollBar_0.Visible = true;
				this.hscrollBar_0.Bounds = bounds;
				this.hscrollBar_0.Minimum = 0;
				this.hscrollBar_0.Maximum = this.method_166().method_29();
				this.hscrollBar_0.SmallChange = GClass17.int_8;
				this.hscrollBar_0.LargeChange = bounds.Width - 1;
				if (this.hscrollBar_0.Value > this.hscrollBar_0.Maximum - this.hscrollBar_0.LargeChange)
				{
					this.hscrollBar_0.Value = this.hscrollBar_0.Maximum - this.hscrollBar_0.LargeChange;
				}
			}
			else
			{
				this.hscrollBar_0.Visible = false;
				this.hscrollBar_0.Value = 0;
			}
			if (flag2)
			{
				Rectangle bounds2 = new Rectangle(base.Width - this.method_156() - SystemInformation.VerticalScrollBarWidth, this.method_156(), SystemInformation.VerticalScrollBarWidth, base.Height - this.method_156() * 2);
				if (flag)
				{
					bounds2.Height -= SystemInformation.HorizontalScrollBarHeight;
				}
				this.vscrollBar_0.Visible = true;
				this.vscrollBar_0.Bounds = bounds2;
				this.vscrollBar_0.Minimum = 0;
				this.vscrollBar_0.Maximum = ((this.method_205() > this.method_206()) ? (this.method_205() - 1) : this.method_206());
				this.vscrollBar_0.SmallChange = 1;
				this.vscrollBar_0.LargeChange = this.method_206() - 1;
				if (this.vscrollBar_0.Value > this.vscrollBar_0.Maximum - this.vscrollBar_0.LargeChange)
				{
					this.vscrollBar_0.Value = this.vscrollBar_0.Maximum - this.vscrollBar_0.LargeChange;
					return;
				}
			}
			else
			{
				this.vscrollBar_0.Visible = false;
				this.vscrollBar_0.Value = 0;
			}
			return;
		}
	}

	protected void method_140(int int_9)
	{
		int num = this.hscrollBar_0.Value - int_9;
		if (num != 0)
		{
			Struct8 @struct = Struct8.smethod_0(this.method_163());
			Rectangle rc = @struct.method_0();
			Class96.ScrollWindow(base.Handle, num, 0, ref @struct, ref @struct);
			if (num < 0)
			{
				rc.X = rc.Right + num;
			}
			rc.Width = Math.Abs(num);
			base.Invalidate(rc, false);
			if (this.method_214())
			{
				base.Invalidate(new Rectangle(base.Width - this.method_156() - SystemInformation.VerticalScrollBarWidth, base.Height - this.method_156() - SystemInformation.HorizontalScrollBarHeight, SystemInformation.VerticalScrollBarWidth, SystemInformation.HorizontalScrollBarHeight), false);
			}
		}
	}

	protected void method_141(int int_9)
	{
		int num = this.vscrollBar_0.Value - int_9;
		if (num != 0)
		{
			Struct8 @struct = Struct8.smethod_0(this.method_164());
			Rectangle rc = @struct.method_0();
			num *= this.method_202();
			Class96.ScrollWindow(base.Handle, 0, num, ref @struct, ref @struct);
			if (num < 0)
			{
				rc.Y = rc.Bottom + num;
			}
			rc.Height = Math.Abs(num);
			base.Invalidate(rc, false);
			if (this.method_213())
			{
				base.Invalidate(new Rectangle(base.Width - this.method_156() - SystemInformation.VerticalScrollBarWidth, base.Height - this.method_156() - SystemInformation.HorizontalScrollBarHeight, SystemInformation.VerticalScrollBarWidth, SystemInformation.HorizontalScrollBarHeight), false);
			}
		}
	}

	public bool method_142(int int_9, int int_10)
	{
		if (this.method_211() && (this.method_213() || this.method_214()))
		{
			if (int_9 != -1)
			{
				if (int_10 == -1)
				{
					if (this.method_159().method_3() != -1)
					{
						int_10 = this.method_159().method_3();
					}
					else
					{
						int_10 = 0;
					}
				}
				int num = this.hscrollBar_0.Value;
				int num2 = this.vscrollBar_0.Value;
				if (this.method_213())
				{
					if (int_10 < 0)
					{
						int_10 = 0;
					}
					else if (int_10 >= this.method_170())
					{
						int_10 = this.method_170() - 1;
					}
					if (this.method_166().method_23().method_8(int_10).method_19())
					{
						if (this.method_166().method_23().method_8(int_10).method_38() < this.hscrollBar_0.Value)
						{
							num = this.method_166().method_23().method_8(int_10).method_38();
						}
						else if (this.method_166().method_23().method_8(int_10).method_39() > this.hscrollBar_0.Value + this.method_164().Width)
						{
							num = this.method_166().method_23().method_8(int_10).method_39() - this.method_164().Width;
						}
						if (num > this.hscrollBar_0.Maximum - this.hscrollBar_0.LargeChange)
						{
							num = this.hscrollBar_0.Maximum - this.hscrollBar_0.LargeChange;
						}
					}
				}
				if (this.method_214())
				{
					if (int_9 < 0)
					{
						num2 = 0;
					}
					else if (int_9 >= this.method_205())
					{
						num2 = this.method_205() - 1;
					}
					else if (int_9 < num2)
					{
						num2 = int_9;
					}
					else if (int_9 > num2 + this.vscrollBar_0.LargeChange)
					{
						num2 += int_9 - (num2 + this.vscrollBar_0.LargeChange);
					}
					if (num2 > this.vscrollBar_0.Maximum - this.vscrollBar_0.LargeChange)
					{
						num2 = this.vscrollBar_0.Maximum - this.vscrollBar_0.LargeChange + 1;
					}
				}
				if (this.method_113(int_9).Bottom > this.method_164().Bottom)
				{
					num2++;
				}
				bool result;
				if (result = (this.hscrollBar_0.Value != num || this.vscrollBar_0.Value != num2))
				{
					this.hscrollBar_0.Value = num;
					this.vscrollBar_0.Value = num2;
					base.Invalidate(this.method_163());
				}
				return result;
			}
		}
		return false;
	}

	public bool method_143(GStruct9 gstruct9_4)
	{
		return this.method_142(gstruct9_4.method_1(), gstruct9_4.method_3());
	}

	public int method_144()
	{
		if (this.method_166() != null && this.method_166().method_31() != 0)
		{
			return this.method_166().method_7(this.hscrollBar_0.Value);
		}
		return -1;
	}

	public int method_145()
	{
		if (this.method_166() == null || this.method_166().method_31() == 0)
		{
			return -1;
		}
		int num = this.hscrollBar_0.Value + this.method_163().Right;
		if (this.method_214())
		{
			num -= this.vscrollBar_0.Width;
		}
		int num2 = this.method_166().method_7(num);
		if (num2 == -1)
		{
			return this.method_166().method_21(this.method_166().method_23().Count);
		}
		if (!this.method_166().method_23().method_8(num2).method_19())
		{
			return this.method_166().method_21(num2);
		}
		return num2;
	}

	public void method_146()
	{
		this.method_147(true);
	}

	public void method_147(bool bool_8)
	{
		if (this.method_247())
		{
			return;
		}
		if (!this.method_153(this.int_7) && this.method_153(this.gstruct9_2.method_3()))
		{
			this.int_7 = this.gstruct9_2.method_3();
		}
		if (this.method_153(this.int_7))
		{
			if (!this.method_166().method_23().method_8(this.int_7).vmethod_6())
			{
				return;
			}
			SortOrder sortOrder_ = SortOrder.Ascending;
			GClass17 gclass = this.method_166().method_23().method_8(this.int_7);
			if (gclass.method_27() == SortOrder.Ascending)
			{
				sortOrder_ = SortOrder.Descending;
			}
			this.method_152(this.int_7, gclass, sortOrder_, bool_8);
		}
	}

	public void method_148(int int_9)
	{
		this.method_149(int_9, true);
	}

	public void method_149(int int_9, bool bool_8)
	{
		if (this.method_247())
		{
			return;
		}
		if (this.method_153(int_9))
		{
			if (!this.method_166().method_23().method_8(int_9).vmethod_6())
			{
				return;
			}
			if (int_9 != this.int_7 && this.method_153(this.int_7))
			{
				this.method_166().method_23().method_8(this.int_7).method_29(SortOrder.None);
			}
			this.int_7 = int_9;
			SortOrder sortOrder_ = SortOrder.Ascending;
			GClass17 gclass = this.method_166().method_23().method_8(int_9);
			if (gclass.method_27() == SortOrder.Ascending)
			{
				sortOrder_ = SortOrder.Descending;
			}
			this.method_152(int_9, gclass, sortOrder_, bool_8);
		}
	}

	public void method_150(int int_9, SortOrder sortOrder_0)
	{
		this.method_151(int_9, sortOrder_0, true);
	}

	public void method_151(int int_9, SortOrder sortOrder_0, bool bool_8)
	{
		if (this.method_247())
		{
			return;
		}
		if (this.method_153(int_9))
		{
			if (!this.method_166().method_23().method_8(int_9).vmethod_6())
			{
				return;
			}
			if (int_9 != this.int_7 && this.method_153(this.int_7))
			{
				this.method_166().method_23().method_8(this.int_7).method_29(SortOrder.None);
			}
			this.int_7 = int_9;
			this.method_152(int_9, this.method_166().method_23().method_8(int_9), sortOrder_0, bool_8);
		}
	}

	void method_152(int int_9, GClass17 gclass17_0, SortOrder sortOrder_0, bool bool_8)
	{
		GClass38 icomparer_;
		if (gclass17_0.method_25() != null)
		{
			icomparer_ = (GClass38)Activator.CreateInstance(gclass17_0.method_25(), new object[]
			{
				this.method_239(),
				int_9,
				sortOrder_0
			});
		}
		else
		{
			if (gclass17_0.vmethod_8() == null)
			{
				return;
			}
			icomparer_ = (GClass38)Activator.CreateInstance(gclass17_0.vmethod_8(), new object[]
			{
				this.method_239(),
				int_9,
				sortOrder_0
			});
		}
		gclass17_0.method_29(sortOrder_0);
		GClass55 gclass;
		if (this.method_239().method_12().Count < 1000)
		{
			if (bool_8)
			{
				gclass = new GClass59(this.method_239(), int_9, icomparer_, sortOrder_0);
			}
			else
			{
				gclass = new GClass58(this.method_239(), int_9, icomparer_, sortOrder_0);
			}
		}
		else if (bool_8)
		{
			gclass = new GClass57(this.method_239(), int_9, icomparer_, sortOrder_0);
		}
		else
		{
			gclass = new GClass56(this.method_239(), int_9, icomparer_, sortOrder_0);
		}
		this.method_135();
		this.vmethod_38(new GClass93(gclass17_0, int_9, GEnum13.const_18, null));
		gclass.vmethod_0();
		this.vmethod_39(new GClass93(gclass17_0, int_9, GEnum13.const_18, null));
		this.method_136();
	}

	public bool method_153(int int_9)
	{
		return this.method_166() != null && int_9 >= 0 && int_9 < this.method_166().method_23().Count;
	}

	public BorderStyle method_154()
	{
		return this.borderStyle_0;
	}

	public void method_155(BorderStyle borderStyle_1)
	{
		if (!Enum.IsDefined(typeof(BorderStyle), borderStyle_1))
		{
			throw new InvalidEnumArgumentException("value", (int)borderStyle_1, typeof(BorderStyle));
		}
		if (this.borderStyle_0 != borderStyle_1)
		{
			this.borderStyle_0 = borderStyle_1;
			base.Invalidate(true);
		}
	}

	protected int method_156()
	{
		if (this.method_154() == BorderStyle.Fixed3D)
		{
			return SystemInformation.Border3DSize.Width;
		}
		if (this.method_154() == BorderStyle.FixedSingle)
		{
			return 1;
		}
		return 0;
	}

	public GStruct9 method_157()
	{
		return this.gstruct9_0;
	}

	public GStruct9 method_158()
	{
		return this.gstruct9_1;
	}

	public GStruct9 method_159()
	{
		return this.gstruct9_2;
	}

	public void method_160(GStruct9 gstruct9_4)
	{
		if (!this.method_102(gstruct9_4))
		{
			return;
		}
		if (!this.method_239().method_11(gstruct9_4).method_40())
		{
			return;
		}
		if (GStruct9.smethod_1(this.gstruct9_2, gstruct9_4))
		{
			if (!this.gstruct9_2.method_5())
			{
				this.method_263(this.gstruct9_2);
			}
			this.gstruct9_2 = gstruct9_4;
			if (!gstruct9_4.method_5())
			{
				this.method_143(gstruct9_4);
				this.method_262(gstruct9_4);
			}
		}
	}

	public int method_161()
	{
		return this.int_0;
	}

	public void method_162(int int_9)
	{
		if (int_9 < 100)
		{
			throw new ArgumentException("HoverTime cannot be less than 100", "value");
		}
		if (this.int_0 != int_9)
		{
			this.int_0 = int_9;
			this.method_138();
		}
	}

	public Rectangle method_163()
	{
		Rectangle result = this.method_165();
		if (this.method_213())
		{
			result.Height -= SystemInformation.HorizontalScrollBarHeight;
		}
		if (this.method_214())
		{
			result.Width -= SystemInformation.VerticalScrollBarWidth;
		}
		return result;
	}

	public Rectangle method_164()
	{
		Rectangle result = this.method_163();
		if (this.method_190() != ColumnHeaderStyle.None && this.method_170() > 0)
		{
			result.Y += this.method_192();
			result.Height -= this.method_192();
		}
		return result;
	}

	Rectangle method_165()
	{
		return new Rectangle(this.method_156(), this.method_156(), base.Width - this.method_156() * 2, base.Height - this.method_156() * 2);
	}

	public GClass32 method_166()
	{
		return this.gclass32_0;
	}

	public void method_167(GClass32 gclass32_1)
	{
		if (this.gclass32_0 != gclass32_1)
		{
			if (this.gclass32_0 != null && this.gclass32_0.method_32() == this)
			{
				this.gclass32_0.method_34(null);
			}
			this.gclass32_0 = gclass32_1;
			if (gclass32_1 != null)
			{
				gclass32_1.method_34(this);
			}
			this.vmethod_24(EventArgs.Empty);
		}
	}

	public bool method_168()
	{
		return this.bool_0;
	}

	public void method_169(bool bool_8)
	{
		if (this.bool_0 != bool_8)
		{
			this.bool_0 = bool_8;
		}
	}

	public int method_170()
	{
		if (this.method_166() == null)
		{
			return -1;
		}
		return this.method_166().method_23().Count;
	}

	public int method_171()
	{
		return this.int_7;
	}

	public Color method_172()
	{
		return this.color_0;
	}

	public void method_173(Color color_7)
	{
		if (this.color_0 != color_7)
		{
			this.color_0 = color_7;
			if (this.method_153(this.int_7))
			{
				Rectangle rectangle = this.method_109(this.int_7);
				if (this.method_163().IntersectsWith(rectangle))
				{
					base.Invalidate(Rectangle.Intersect(this.method_163(), rectangle));
				}
			}
		}
	}

	bool method_174()
	{
		return this.color_0 != Color.WhiteSmoke;
	}

	public override Rectangle DisplayRectangle
	{
		get
		{
			Rectangle result = this.method_164();
			if (!this.bool_6)
			{
				result.X -= this.hscrollBar_0.Value;
				result.Y -= this.vscrollBar_0.Value;
			}
			if (this.method_166() == null)
			{
				return result;
			}
			if (this.method_166().method_28() <= this.method_164().Width)
			{
				result.Width = this.method_164().Width;
			}
			else
			{
				result.Width = this.method_166().method_29();
			}
			if (this.method_203() <= this.method_164().Height)
			{
				result.Height = this.method_164().Height;
			}
			else
			{
				result.Height = this.method_203();
			}
			return result;
		}
	}

	public bool method_175()
	{
		return !this.method_176().method_5();
	}

	public GStruct9 method_176()
	{
		return this.gstruct9_3;
	}

	public GInterface3 method_177()
	{
		return this.ginterface3_0;
	}

	public GEnum7 method_178()
	{
		return this.genum7_0;
	}

	public void method_179(GEnum7 genum7_1)
	{
		if (!Enum.IsDefined(typeof(GEnum7), genum7_1))
		{
			throw new InvalidEnumArgumentException("value", (int)genum7_1, typeof(GEnum7));
		}
		if (this.genum7_0 != genum7_1)
		{
			this.genum7_0 = genum7_1;
		}
	}

	public Keys method_180()
	{
		return this.keys_0;
	}

	public void method_181(Keys keys_1)
	{
		if (this.method_134(keys_1))
		{
			throw new ArgumentException("CustomEditKey cannot be one of the Table's reserved keys (Up arrow, Down arrow, Left arrow, Right arrow, PageUp, PageDown, Home, End, Tab)", "value");
		}
		if (this.keys_0 != keys_1)
		{
			this.keys_0 = keys_1;
		}
	}

	public GEnum3 method_182()
	{
		return this.genum3_0;
	}

	public void method_183(GEnum3 genum3_1)
	{
		if (!Enum.IsDefined(typeof(GEnum3), genum3_1))
		{
			throw new InvalidEnumArgumentException("value", (int)genum3_1, typeof(GEnum3));
		}
		if (this.genum3_0 != genum3_1)
		{
			this.genum3_0 = genum3_1;
			base.Invalidate(this.method_163(), false);
		}
	}

	public GEnum61 method_184()
	{
		return this.genum61_0;
	}

	public void method_185(GEnum61 genum61_1)
	{
		if (!Enum.IsDefined(typeof(GEnum61), genum61_1))
		{
			throw new InvalidEnumArgumentException("value", (int)genum61_1, typeof(GEnum61));
		}
		if (this.genum61_0 != genum61_1)
		{
			this.genum61_0 = genum61_1;
			if (this.method_182() != GEnum3.const_0)
			{
				base.Invalidate(this.method_163(), false);
			}
		}
	}

	public Color method_186()
	{
		return this.color_1;
	}

	public void method_187(Color color_7)
	{
		if (this.color_1 != color_7)
		{
			this.color_1 = color_7;
			if (this.method_182() != GEnum3.const_0)
			{
				base.Invalidate(this.method_163(), false);
			}
		}
	}

	bool method_188()
	{
		return this.method_186() != SystemColors.Control;
	}

	public virtual Color BackColor
	{
		get
		{
			return base.BackColor;
		}
		set
		{
			base.BackColor = value;
		}
	}

	bool method_189()
	{
		return this.BackColor != Color.White;
	}

	public ColumnHeaderStyle method_190()
	{
		return this.columnHeaderStyle_0;
	}

	public void method_191(ColumnHeaderStyle columnHeaderStyle_1)
	{
		if (!Enum.IsDefined(typeof(ColumnHeaderStyle), columnHeaderStyle_1))
		{
			throw new InvalidEnumArgumentException("value", (int)columnHeaderStyle_1, typeof(ColumnHeaderStyle));
		}
		if (this.columnHeaderStyle_0 != columnHeaderStyle_1)
		{
			this.columnHeaderStyle_0 = columnHeaderStyle_1;
			this.int_5 = -1;
			this.int_6 = -1;
			base.Invalidate();
		}
	}

	public int method_192()
	{
		if (this.method_166() != null && this.method_190() != ColumnHeaderStyle.None)
		{
			return this.method_166().method_24();
		}
		return 0;
	}

	public Rectangle method_193()
	{
		return new Rectangle(this.method_156(), this.method_156(), this.method_163().Width, this.method_192());
	}

	public Font method_194()
	{
		return this.font_0;
	}

	public void method_195(Font font_1)
	{
		if (font_1 == null)
		{
			throw new ArgumentNullException("HeaderFont cannot be null");
		}
		if (this.font_0 != font_1)
		{
			this.font_0 = font_1;
			this.method_197().imethod_4(font_1);
			base.Invalidate(this.method_193(), false);
		}
	}

	bool method_196()
	{
		return this.method_194() != this.Font;
	}

	public GClass13 method_197()
	{
		if (this.gclass13_0 == null)
		{
			this.gclass13_0 = new GClass16();
		}
		return this.gclass13_0;
	}

	public void method_198(GClass13 gclass13_1)
	{
		if (gclass13_1 == null)
		{
			throw new ArgumentNullException("HeaderRenderer cannot be null");
		}
		if (this.gclass13_0 != gclass13_1)
		{
			this.gclass13_0 = gclass13_1;
			this.gclass13_0.imethod_4(this.method_194());
			base.Invalidate(this.method_193(), false);
		}
	}

	public GClass77 method_199()
	{
		return this.gclass77_0;
	}

	public bool method_200()
	{
		return this.method_199().method_1();
	}

	public void method_201(bool bool_8)
	{
		this.method_199().method_2(bool_8);
	}

	public int method_202()
	{
		if (this.method_239() == null)
		{
			return 0;
		}
		return this.method_239().method_14();
	}

	protected int method_203()
	{
		if (this.method_239() == null)
		{
			return 0;
		}
		return this.method_239().method_17();
	}

	protected int method_204()
	{
		return this.method_203() + this.method_192();
	}

	public int method_205()
	{
		if (this.method_239() == null)
		{
			return 0;
		}
		return this.method_239().method_12().Count;
	}

	public int method_206()
	{
		int num = this.method_164().Height / this.method_202();
		if (this.method_164().Height % this.method_202() > 0)
		{
			num++;
		}
		return num;
	}

	public int method_207()
	{
		if (this.method_239() == null || this.method_239().method_12().Count == 0)
		{
			return -1;
		}
		if (this.method_214())
		{
			return this.vscrollBar_0.Value;
		}
		return 0;
	}

	public GClass83 method_208()
	{
		if (this.method_239() != null && this.method_239().method_12().Count != 0)
		{
			return this.method_239().method_12().method_9(this.method_207());
		}
		return null;
	}

	public Color method_209()
	{
		return this.color_6;
	}

	public void method_210(Color color_7)
	{
		if (this.color_6 != color_7)
		{
			this.color_6 = color_7;
			base.Invalidate(this.method_164(), false);
		}
	}

	public bool method_211()
	{
		return this.bool_1;
	}

	public void method_212(bool bool_8)
	{
		if (this.bool_1 != bool_8)
		{
			this.bool_1 = bool_8;
			base.PerformLayout();
		}
	}

	public bool method_213()
	{
		return this.hscrollBar_0 != null && this.hscrollBar_0.Visible;
	}

	public bool method_214()
	{
		return this.vscrollBar_0 != null && this.vscrollBar_0.Visible;
	}

	public bool method_215()
	{
		return this.bool_2;
	}

	public void method_216(bool bool_8)
	{
		if (this.bool_2 != bool_8)
		{
			this.bool_2 = bool_8;
			if (!bool_8 && this.method_239() != null)
			{
				this.method_239().method_13().method_13();
			}
		}
	}

	public GEnum29 method_217()
	{
		return this.genum29_0;
	}

	public void method_218(GEnum29 genum29_1)
	{
		if (!Enum.IsDefined(typeof(GEnum29), genum29_1))
		{
			throw new InvalidEnumArgumentException("value", (int)genum29_1, typeof(GEnum29));
		}
		if (this.genum29_0 != genum29_1)
		{
			this.genum29_0 = genum29_1;
			if (this.method_239() != null)
			{
				base.Invalidate(this.method_164(), false);
			}
		}
	}

	public bool method_219()
	{
		return this.bool_3;
	}

	public void method_220(bool bool_8)
	{
		if (this.bool_3 != bool_8)
		{
			this.bool_3 = bool_8;
		}
	}

	public bool method_221()
	{
		return this.bool_4;
	}

	public void method_222(bool bool_8)
	{
		if (this.bool_4 != bool_8)
		{
			this.bool_4 = bool_8;
			if (this.method_239() != null)
			{
				base.Invalidate(this.method_164(), false);
			}
		}
	}

	public bool method_223()
	{
		return this.bool_5;
	}

	public void method_224(bool bool_8)
	{
		if (this.bool_5 != bool_8)
		{
			this.bool_5 = bool_8;
			if (!this.Focused && this.method_239() != null)
			{
				base.Invalidate(this.method_164(), false);
			}
		}
	}

	public Color method_225()
	{
		return this.color_2;
	}

	public void method_226(Color color_7)
	{
		if (this.color_2 != color_7)
		{
			this.color_2 = color_7;
			if (this.method_239() != null)
			{
				base.Invalidate(this.method_164(), false);
			}
		}
	}

	bool method_227()
	{
		return this.color_2 != SystemColors.Highlight;
	}

	public Color method_228()
	{
		return this.color_3;
	}

	public void method_229(Color color_7)
	{
		if (this.color_3 != color_7)
		{
			this.color_3 = color_7;
			if (this.method_239() != null)
			{
				base.Invalidate(this.method_164(), false);
			}
		}
	}

	bool method_230()
	{
		return this.color_3 != SystemColors.HighlightText;
	}

	public Color method_231()
	{
		return this.color_4;
	}

	public void method_232(Color color_7)
	{
		if (this.color_4 != color_7)
		{
			this.color_4 = color_7;
			if (!this.Focused && !this.method_223() && this.method_239() != null)
			{
				base.Invalidate(this.method_164(), false);
			}
		}
	}

	bool method_233()
	{
		return this.color_4 != SystemColors.Control;
	}

	public Color method_234()
	{
		return this.color_5;
	}

	public void method_235(Color color_7)
	{
		if (this.color_5 != color_7)
		{
			this.color_5 = color_7;
			if (!this.Focused && !this.method_223() && this.method_239() != null)
			{
				base.Invalidate(this.method_164(), false);
			}
		}
	}

	bool method_236()
	{
		return this.color_5 != SystemColors.ControlText;
	}

	public GClass83[] method_237()
	{
		if (this.method_239() == null)
		{
			return new GClass83[0];
		}
		return this.method_239().method_13().method_25();
	}

	public int[] method_238()
	{
		if (this.method_239() == null)
		{
			return new int[0];
		}
		return this.method_239().method_13().method_26();
	}

	public GClass104 method_239()
	{
		return this.gclass104_0;
	}

	public void method_240(GClass104 gclass104_1)
	{
		if (this.gclass104_0 != gclass104_1)
		{
			if (this.gclass104_0 != null && this.gclass104_0.method_18() == this)
			{
				this.gclass104_0.method_20(null);
			}
			this.gclass104_0 = gclass104_1;
			if (gclass104_1 != null)
			{
				gclass104_1.method_20(this);
			}
			this.vmethod_40(EventArgs.Empty);
		}
	}

	public string method_241()
	{
		return this.string_0;
	}

	public void method_242(string string_1)
	{
		if (!this.string_0.Equals(string_1))
		{
			this.string_0 = string_1;
			if (this.method_166() == null || this.method_239() == null || this.method_239().method_12().Count == 0)
			{
				base.Invalidate(this.method_163());
			}
		}
	}

	protected GEnum45 method_243()
	{
		return this.genum45_0;
	}

	protected void method_244(GEnum45 genum45_1)
	{
		this.genum45_0 = genum45_1;
	}

	protected void method_245(int int_9, int int_10)
	{
		GEnum2 genum = this.method_115(int_9, int_10);
		if (genum == GEnum2.const_1)
		{
			int num = this.method_105(int_9, int_10);
			if (num == -1)
			{
				this.method_244(GEnum45.const_0);
				return;
			}
			Rectangle rectangle = this.method_166().method_9(num);
			int_9 = this.method_90(int_9, int_10).X;
			if (int_9 < rectangle.Left + GClass17.int_5)
			{
				this.method_244(GEnum45.const_2);
				while (num != 0 && !this.method_166().method_23().method_8(num - 1).method_19())
				{
					num--;
				}
				if (num == 0 || !this.method_166().method_23().method_8(num - 1).method_31())
				{
					this.method_244(GEnum45.const_1);
				}
			}
			else if (int_9 > rectangle.Right - GClass17.int_5)
			{
				this.method_244(GEnum45.const_2);
			}
			else
			{
				this.method_244(GEnum45.const_1);
			}
		}
		else if (genum == GEnum2.const_0)
		{
			this.method_244(GEnum45.const_5);
		}
		else
		{
			this.method_244(GEnum45.const_0);
		}
		if (this.method_243() == GEnum45.const_2 && !this.method_168())
		{
			this.method_244(GEnum45.const_1);
		}
	}

	protected internal bool method_246()
	{
		return base.IsHandleCreated && this.int_8 == 0;
	}

	internal bool method_247()
	{
		return this.bool_7;
	}

	internal void method_248(bool bool_8)
	{
		this.bool_7 = bool_8;
	}

	internal ToolTip method_249()
	{
		return this.toolTip_0;
	}

	public bool method_250()
	{
		return this.toolTip_0.Active;
	}

	public void method_251(bool bool_8)
	{
		this.toolTip_0.Active = bool_8;
	}

	public int method_252()
	{
		return this.toolTip_0.AutomaticDelay;
	}

	public void method_253(int int_9)
	{
		if (int_9 > 0 && this.toolTip_0.AutomaticDelay != int_9)
		{
			this.toolTip_0.AutomaticDelay = int_9;
		}
	}

	public int method_254()
	{
		return this.toolTip_0.AutoPopDelay;
	}

	public void method_255(int int_9)
	{
		if (int_9 > 0 && this.toolTip_0.AutoPopDelay != int_9)
		{
			this.toolTip_0.AutoPopDelay = int_9;
		}
	}

	public int method_256()
	{
		return this.toolTip_0.InitialDelay;
	}

	public void method_257(int int_9)
	{
		if (int_9 > 0 && this.toolTip_0.InitialDelay != int_9)
		{
			this.toolTip_0.InitialDelay = int_9;
		}
	}

	public bool method_258()
	{
		return this.toolTip_0.ShowAlways;
	}

	public void method_259(bool bool_8)
	{
		if (this.toolTip_0.ShowAlways != bool_8)
		{
			this.toolTip_0.ShowAlways = bool_8;
		}
	}

	void method_260()
	{
		bool active;
		if (active = this.method_249().Active)
		{
			this.method_249().Active = false;
		}
		this.method_138();
		this.method_249().SetToolTip(this, null);
		if (active)
		{
			this.method_249().Active = true;
		}
	}

	protected internal virtual void vmethod_0(GEventArgs1 geventArgs1_0)
	{
		if (this.method_246())
		{
			this.method_129(geventArgs1_0.method_3(), geventArgs1_0.method_1());
			if (this.gdelegate7_0 != null)
			{
				this.gdelegate7_0(this, geventArgs1_0);
			}
			if (geventArgs1_0.method_6() == GEnum6.const_10)
			{
				this.vmethod_2(new GEventArgs4(geventArgs1_0.method_0(), geventArgs1_0.method_1(), geventArgs1_0.method_3()));
			}
		}
	}

	void method_261(object sender, GEventArgs1 e)
	{
		this.vmethod_0(e);
	}

	protected internal virtual void vmethod_1(GEventArgs2 geventArgs2_0)
	{
		if (this.method_246() && this.gdelegate10_0 != null)
		{
			this.gdelegate10_0(this, geventArgs2_0);
		}
	}

	protected internal virtual void vmethod_2(GEventArgs4 geventArgs4_0)
	{
		if (this.method_246() && this.gdelegate26_0 != null)
		{
			this.gdelegate26_0(this, geventArgs4_0);
		}
	}

	protected virtual void vmethod_3(GEventArgs3 geventArgs3_0)
	{
		if (this.method_246())
		{
			GInterface2 ginterface = this.method_166().method_17(geventArgs3_0.method_1());
			if (ginterface != null)
			{
				ginterface.imethod_14(geventArgs3_0);
			}
			if (this.gdelegate25_0 != null)
			{
				this.gdelegate25_0(this, geventArgs3_0);
			}
		}
	}

	protected void method_262(GStruct9 gstruct9_4)
	{
		if (!this.method_102(gstruct9_4))
		{
			return;
		}
		GInterface2 ginterface = this.method_166().method_17(gstruct9_4.method_3());
		if (ginterface != null)
		{
			GClass97 gclass97_ = null;
			if (gstruct9_4.method_3() < this.method_239().method_12().method_9(gstruct9_4.method_1()).method_9().Count)
			{
				gclass97_ = this.method_239().method_12().method_9(gstruct9_4.method_1()).method_9().method_9(gstruct9_4.method_3());
			}
			GEventArgs3 geventArgs3_ = new GEventArgs3(gclass97_, this, gstruct9_4.method_1(), gstruct9_4.method_3(), this.method_98(gstruct9_4.method_1(), gstruct9_4.method_3()));
			this.vmethod_3(geventArgs3_);
		}
	}

	protected virtual void vmethod_4(GEventArgs3 geventArgs3_0)
	{
		if (this.method_246())
		{
			GInterface2 ginterface = this.method_166().method_17(geventArgs3_0.method_1());
			if (ginterface != null)
			{
				ginterface.imethod_15(geventArgs3_0);
			}
			if (this.gdelegate25_1 != null)
			{
				this.gdelegate25_1(this, geventArgs3_0);
			}
		}
	}

	protected void method_263(GStruct9 gstruct9_4)
	{
		if (!this.method_102(gstruct9_4))
		{
			return;
		}
		GInterface2 ginterface = this.method_166().method_17(gstruct9_4.method_3());
		if (ginterface != null)
		{
			GClass97 gclass97_ = null;
			if (gstruct9_4.method_3() < this.method_239().method_12().method_9(gstruct9_4.method_1()).method_9().Count)
			{
				gclass97_ = this.method_239().method_10(gstruct9_4.method_1(), gstruct9_4.method_3());
			}
			GEventArgs3 geventArgs3_ = new GEventArgs3(gclass97_, this, gstruct9_4.method_1(), gstruct9_4.method_3(), this.method_98(gstruct9_4.method_1(), gstruct9_4.method_3()));
			this.vmethod_4(geventArgs3_);
		}
	}

	protected virtual void vmethod_5(GEventArgs17 geventArgs17_0)
	{
		if (this.method_246())
		{
			GInterface2 ginterface = this.method_166().method_17(geventArgs17_0.method_3());
			if (ginterface != null)
			{
				ginterface.imethod_16(geventArgs17_0);
			}
			if (this.gdelegate29_0 != null)
			{
				this.gdelegate29_0(geventArgs17_0.method_0(), geventArgs17_0);
			}
		}
	}

	protected void method_264(GStruct9 gstruct9_4, KeyEventArgs keyEventArgs_0)
	{
		if (!this.method_102(gstruct9_4))
		{
			return;
		}
		if (!this.method_239().method_11(gstruct9_4).method_40())
		{
			return;
		}
		if (this.method_166().method_17(gstruct9_4.method_3()) != null)
		{
			GClass97 gclass97_ = null;
			if (gstruct9_4.method_3() < this.method_239().method_12().method_9(gstruct9_4.method_1()).method_9().Count)
			{
				gclass97_ = this.method_239().method_12().method_9(gstruct9_4.method_1()).method_9().method_9(gstruct9_4.method_3());
			}
			GEventArgs17 geventArgs17_ = new GEventArgs17(gclass97_, this, gstruct9_4, this.method_98(gstruct9_4.method_1(), gstruct9_4.method_3()), keyEventArgs_0);
			this.vmethod_5(geventArgs17_);
		}
	}

	protected virtual void vmethod_6(GEventArgs17 geventArgs17_0)
	{
		if (this.method_246())
		{
			GInterface2 ginterface = this.method_166().method_17(geventArgs17_0.method_3());
			if (ginterface != null)
			{
				ginterface.imethod_17(geventArgs17_0);
			}
			if (this.gdelegate29_1 != null)
			{
				this.gdelegate29_1(geventArgs17_0.method_0(), geventArgs17_0);
			}
		}
	}

	protected void method_265(GStruct9 gstruct9_4, KeyEventArgs keyEventArgs_0)
	{
		if (!this.method_102(gstruct9_4))
		{
			return;
		}
		if (!this.method_239().method_11(gstruct9_4).method_40())
		{
			return;
		}
		if (this.method_166().method_17(gstruct9_4.method_3()) != null)
		{
			GClass97 gclass97_ = null;
			if (gstruct9_4.method_3() < this.method_239().method_12().method_9(gstruct9_4.method_1()).method_9().Count)
			{
				gclass97_ = this.method_239().method_12().method_9(gstruct9_4.method_1()).method_9().method_9(gstruct9_4.method_3());
			}
			GEventArgs17 geventArgs17_ = new GEventArgs17(gclass97_, this, gstruct9_4, this.method_98(gstruct9_4.method_1(), gstruct9_4.method_3()), keyEventArgs_0);
			this.vmethod_6(geventArgs17_);
		}
	}

	protected virtual void vmethod_7(GEventArgs10 geventArgs10_0)
	{
		if (this.method_246())
		{
			GInterface2 ginterface = this.method_166().method_17(geventArgs10_0.method_3());
			if (ginterface != null)
			{
				ginterface.imethod_18(geventArgs10_0);
			}
			if (this.gdelegate14_0 != null)
			{
				this.gdelegate14_0(geventArgs10_0.method_0(), geventArgs10_0);
			}
		}
	}

	protected void method_266(GStruct9 gstruct9_4)
	{
		if (!this.method_102(gstruct9_4))
		{
			return;
		}
		if (this.method_166().method_17(gstruct9_4.method_3()) != null)
		{
			GClass97 gclass97_ = null;
			if (gstruct9_4.method_3() < this.method_239().method_12().method_9(gstruct9_4.method_1()).method_9().Count)
			{
				gclass97_ = this.method_239().method_12().method_9(gstruct9_4.method_1()).method_9().method_9(gstruct9_4.method_3());
			}
			GEventArgs10 geventArgs10_ = new GEventArgs10(gclass97_, this, gstruct9_4.method_1(), gstruct9_4.method_3(), this.method_98(gstruct9_4.method_1(), gstruct9_4.method_3()));
			this.vmethod_7(geventArgs10_);
		}
	}

	protected virtual void vmethod_8(GEventArgs10 geventArgs10_0)
	{
		if (this.method_246())
		{
			GInterface2 ginterface = this.method_166().method_17(geventArgs10_0.method_3());
			if (ginterface != null)
			{
				ginterface.imethod_19(geventArgs10_0);
			}
			if (this.gdelegate14_1 != null)
			{
				this.gdelegate14_1(geventArgs10_0.method_0(), geventArgs10_0);
			}
		}
	}

	protected internal void method_267(GStruct9 gstruct9_4)
	{
		if (!this.method_102(gstruct9_4))
		{
			return;
		}
		if (this.method_166().method_17(gstruct9_4.method_3()) != null)
		{
			GClass97 gclass97_ = null;
			if (gstruct9_4.method_3() < this.method_239().method_12().method_9(gstruct9_4.method_1()).method_9().Count)
			{
				gclass97_ = this.method_239().method_12().method_9(gstruct9_4.method_1()).method_9().method_9(gstruct9_4.method_3());
			}
			GEventArgs10 geventArgs10_ = new GEventArgs10(gclass97_, this, gstruct9_4.method_1(), gstruct9_4.method_3(), this.method_98(gstruct9_4.method_1(), gstruct9_4.method_3()));
			this.vmethod_8(geventArgs10_);
		}
	}

	protected virtual void vmethod_9(GEventArgs10 geventArgs10_0)
	{
		if (this.method_246())
		{
			GInterface2 ginterface = this.method_166().method_17(geventArgs10_0.method_3());
			if (ginterface != null)
			{
				ginterface.imethod_20(geventArgs10_0);
			}
			if (this.gdelegate14_3 != null)
			{
				this.gdelegate14_3(geventArgs10_0.method_0(), geventArgs10_0);
			}
		}
	}

	protected void method_268(GStruct9 gstruct9_4, MouseEventArgs mouseEventArgs_0)
	{
		if (!this.method_102(gstruct9_4))
		{
			return;
		}
		if (!this.method_239().method_11(gstruct9_4).method_40())
		{
			return;
		}
		if (this.method_166().method_17(gstruct9_4.method_3()) != null)
		{
			GClass97 gclass97_ = null;
			if (gstruct9_4.method_3() < this.method_239().method_12().method_9(gstruct9_4.method_1()).method_9().Count)
			{
				gclass97_ = this.method_239().method_12().method_9(gstruct9_4.method_1()).method_9().method_9(gstruct9_4.method_3());
			}
			GEventArgs10 geventArgs10_ = new GEventArgs10(gclass97_, this, gstruct9_4.method_1(), gstruct9_4.method_3(), this.method_98(gstruct9_4.method_1(), gstruct9_4.method_3()), mouseEventArgs_0);
			this.vmethod_9(geventArgs10_);
		}
	}

	protected virtual void vmethod_10(GEventArgs10 geventArgs10_0)
	{
		if (this.method_246())
		{
			GInterface2 ginterface = this.method_166().method_17(geventArgs10_0.method_3());
			if (ginterface != null)
			{
				ginterface.imethod_21(geventArgs10_0);
			}
			if (this.gdelegate14_2 != null)
			{
				this.gdelegate14_2(geventArgs10_0.method_0(), geventArgs10_0);
			}
		}
	}

	protected void method_269(GStruct9 gstruct9_4, MouseEventArgs mouseEventArgs_0)
	{
		if (!this.method_102(gstruct9_4))
		{
			return;
		}
		if (!this.method_239().method_11(gstruct9_4).method_40())
		{
			return;
		}
		if (this.method_166().method_17(gstruct9_4.method_3()) != null)
		{
			GClass97 gclass97_ = null;
			if (gstruct9_4.method_3() < this.method_239().method_12().method_9(gstruct9_4.method_1()).method_9().Count)
			{
				gclass97_ = this.method_239().method_12().method_9(gstruct9_4.method_1()).method_9().method_9(gstruct9_4.method_3());
			}
			GEventArgs10 geventArgs10_ = new GEventArgs10(gclass97_, this, gstruct9_4.method_1(), gstruct9_4.method_3(), this.method_98(gstruct9_4.method_1(), gstruct9_4.method_3()), mouseEventArgs_0);
			this.vmethod_10(geventArgs10_);
		}
	}

	protected virtual void vmethod_11(GEventArgs10 geventArgs10_0)
	{
		if (this.method_246())
		{
			GInterface2 ginterface = this.method_166().method_17(geventArgs10_0.method_3());
			if (ginterface != null)
			{
				ginterface.imethod_22(geventArgs10_0);
			}
			if (this.gdelegate14_4 != null)
			{
				this.gdelegate14_4(geventArgs10_0.method_0(), geventArgs10_0);
			}
		}
	}

	protected void method_270(GStruct9 gstruct9_4, MouseEventArgs mouseEventArgs_0)
	{
		if (!this.method_102(gstruct9_4))
		{
			return;
		}
		if (this.method_166().method_17(gstruct9_4.method_3()) != null)
		{
			GClass97 gclass97_ = null;
			if (gstruct9_4.method_3() < this.method_239().method_12().method_9(gstruct9_4.method_1()).method_9().Count)
			{
				gclass97_ = this.method_239().method_12().method_9(gstruct9_4.method_1()).method_9().method_9(gstruct9_4.method_3());
			}
			GEventArgs10 geventArgs10_ = new GEventArgs10(gclass97_, this, gstruct9_4.method_1(), gstruct9_4.method_3(), this.method_98(gstruct9_4.method_1(), gstruct9_4.method_3()), mouseEventArgs_0);
			this.vmethod_11(geventArgs10_);
		}
	}

	internal void method_271()
	{
		if (!this.gstruct9_0.method_5())
		{
			this.method_138();
			GStruct9 gstruct9_ = this.gstruct9_0;
			this.gstruct9_0 = GStruct9.gstruct9_0;
			this.method_267(gstruct9_);
		}
	}

	protected virtual void vmethod_12(GEventArgs10 geventArgs10_0)
	{
		if (this.method_246() && this.gdelegate14_5 != null)
		{
			this.gdelegate14_5(geventArgs10_0.method_0(), geventArgs10_0);
		}
	}

	protected virtual void vmethod_13(GEventArgs10 geventArgs10_0)
	{
		if (!this.method_127(geventArgs10_0.method_5()))
		{
			return;
		}
		if (this.method_246())
		{
			GInterface2 ginterface = this.method_166().method_17(this.method_157().method_3());
			if (ginterface != null)
			{
				ginterface.imethod_23(geventArgs10_0);
			}
			if (this.gdelegate14_6 != null)
			{
				this.gdelegate14_6(geventArgs10_0.method_0(), geventArgs10_0);
			}
		}
	}

	protected virtual void vmethod_14(GEventArgs10 geventArgs10_0)
	{
		if (!this.method_127(geventArgs10_0.method_5()))
		{
			return;
		}
		if (this.method_246())
		{
			GInterface2 ginterface = this.method_166().method_17(this.method_157().method_3());
			if (ginterface != null)
			{
				ginterface.imethod_24(geventArgs10_0);
			}
			if (this.gdelegate14_7 != null)
			{
				this.gdelegate14_7(geventArgs10_0.method_0(), geventArgs10_0);
			}
		}
	}

	protected internal virtual void vmethod_15(GClass93 gclass93_0)
	{
		if (this.method_246())
		{
			Rectangle rc;
			if (gclass93_0.method_2() != -1)
			{
				rc = this.method_107(gclass93_0.method_2());
			}
			else
			{
				rc = this.method_108(gclass93_0.method_0());
			}
			switch (gclass93_0.method_4())
			{
			case GEnum13.const_1:
			case GEnum13.const_3:
			case GEnum13.const_6:
			case GEnum13.const_8:
				if (rc.IntersectsWith(this.method_193()))
				{
					base.Invalidate(rc);
				}
				break;
			case GEnum13.const_2:
			case GEnum13.const_9:
			case GEnum13.const_12:
				if (gclass93_0.method_4() == GEnum13.const_12 && gclass93_0.method_2() == this.method_159().method_3())
				{
					this.method_160(GStruct9.gstruct9_0);
				}
				if (rc.IntersectsWith(this.method_193()))
				{
					base.Invalidate(new Rectangle(rc.X, this.method_163().Top, rc.Width, this.method_163().Height));
				}
				break;
			case GEnum13.const_4:
			case GEnum13.const_5:
				if (gclass93_0.method_4() == GEnum13.const_5)
				{
					if (gclass93_0.method_0().method_19() && gclass93_0.method_2() != this.int_7)
					{
						gclass93_0.method_0().method_29(SortOrder.None);
					}
					if (gclass93_0.method_2() == this.method_159().method_3() && !gclass93_0.method_0().method_19())
					{
						int num = this.method_166().method_22(gclass93_0.method_2());
						if (num == -1)
						{
							num = this.method_166().method_21(gclass93_0.method_2());
						}
						if (num != -1)
						{
							this.method_160(new GStruct9(this.method_159().method_1(), num));
						}
						else
						{
							this.method_160(GStruct9.gstruct9_0);
						}
					}
				}
				if (rc.X <= 0)
				{
					base.Invalidate(this.method_163());
				}
				else if (rc.Left <= this.method_163().Right)
				{
					base.Invalidate(new Rectangle(rc.X, this.method_163().Top, this.method_163().Right - rc.X, this.method_163().Height));
				}
				this.method_139();
				break;
			}
			if (this.gdelegate11_0 != null)
			{
				this.gdelegate11_0(gclass93_0.method_0(), gclass93_0);
			}
		}
	}

	protected virtual void vmethod_16(GEventArgs16 geventArgs16_0)
	{
		if (this.method_246())
		{
			if (this.method_197() != null)
			{
				this.method_197().GInterface8.imethod_14(geventArgs16_0);
			}
			if (this.gdelegate28_0 != null)
			{
				this.gdelegate28_0(geventArgs16_0.method_0(), geventArgs16_0);
			}
		}
	}

	protected void method_272(int int_9)
	{
		if (int_9 >= 0 && this.method_166() != null && int_9 < this.method_166().method_23().Count)
		{
			if (this.method_197() != null)
			{
				GClass17 gclass17_ = this.method_166().method_23().method_8(int_9);
				GEventArgs16 geventArgs16_ = new GEventArgs16(gclass17_, this, int_9, this.method_95(this.method_166().method_9(int_9)));
				this.vmethod_16(geventArgs16_);
			}
			return;
		}
	}

	protected virtual void vmethod_17(GEventArgs16 geventArgs16_0)
	{
		if (this.method_246())
		{
			if (this.method_197() != null)
			{
				this.method_197().GInterface8.imethod_15(geventArgs16_0);
			}
			if (this.gdelegate28_1 != null)
			{
				this.gdelegate28_1(geventArgs16_0.method_0(), geventArgs16_0);
			}
		}
	}

	protected void method_273(int int_9)
	{
		if (int_9 >= 0 && this.method_166() != null && int_9 < this.method_166().method_23().Count)
		{
			if (this.method_197() != null)
			{
				GClass17 gclass17_ = this.method_166().method_23().method_8(int_9);
				GEventArgs16 geventArgs16_ = new GEventArgs16(gclass17_, this, int_9, this.method_95(this.method_166().method_9(int_9)));
				this.vmethod_17(geventArgs16_);
			}
			return;
		}
	}

	protected virtual void vmethod_18(GEventArgs16 geventArgs16_0)
	{
		if (this.method_246())
		{
			if (this.method_197() != null)
			{
				this.method_197().GInterface8.imethod_16(geventArgs16_0);
			}
			if (this.gdelegate28_3 != null)
			{
				this.gdelegate28_3(geventArgs16_0.method_0(), geventArgs16_0);
			}
		}
	}

	protected void method_274(int int_9, MouseEventArgs mouseEventArgs_0)
	{
		if (int_9 >= 0 && this.method_166() != null && int_9 < this.method_166().method_23().Count)
		{
			if (this.method_197() != null)
			{
				GClass17 gclass17_ = this.method_166().method_23().method_8(int_9);
				GEventArgs16 geventArgs16_ = new GEventArgs16(gclass17_, this, int_9, this.method_95(this.method_166().method_9(int_9)), mouseEventArgs_0);
				this.vmethod_18(geventArgs16_);
			}
			return;
		}
	}

	protected virtual void vmethod_19(GEventArgs16 geventArgs16_0)
	{
		if (this.method_246())
		{
			if (this.method_197() != null)
			{
				this.method_197().imethod_17(geventArgs16_0);
			}
			if (this.gdelegate28_2 != null)
			{
				this.gdelegate28_2(geventArgs16_0.method_0(), geventArgs16_0);
			}
		}
	}

	protected void method_275(int int_9, MouseEventArgs mouseEventArgs_0)
	{
		if (int_9 >= 0 && this.method_166() != null && int_9 < this.method_166().method_23().Count)
		{
			if (this.method_197() != null)
			{
				GClass17 gclass17_ = this.method_166().method_23().method_8(int_9);
				GEventArgs16 geventArgs16_ = new GEventArgs16(gclass17_, this, int_9, this.method_95(this.method_166().method_9(int_9)), mouseEventArgs_0);
				this.vmethod_19(geventArgs16_);
			}
			return;
		}
	}

	protected virtual void vmethod_20(GEventArgs16 geventArgs16_0)
	{
		if (this.method_246())
		{
			if (this.method_197() != null)
			{
				this.method_197().GInterface8.imethod_18(geventArgs16_0);
			}
			if (this.gdelegate28_4 != null)
			{
				this.gdelegate28_4(geventArgs16_0.method_0(), geventArgs16_0);
			}
		}
	}

	protected void method_276(int int_9, MouseEventArgs mouseEventArgs_0)
	{
		if (int_9 >= 0 && this.method_166() != null && int_9 < this.method_166().method_23().Count)
		{
			if (this.method_197() != null)
			{
				GClass17 gclass17_ = this.method_166().method_23().method_8(int_9);
				GEventArgs16 geventArgs16_ = new GEventArgs16(gclass17_, this, int_9, this.method_95(this.method_166().method_9(int_9)), mouseEventArgs_0);
				this.vmethod_20(geventArgs16_);
			}
			return;
		}
	}

	internal void method_277()
	{
		if (this.int_6 != -1)
		{
			this.method_138();
			int int_ = this.int_6;
			this.int_6 = -1;
			this.method_273(int_);
		}
	}

	protected virtual void vmethod_21(GEventArgs16 geventArgs16_0)
	{
		if (this.method_246() && this.gdelegate28_5 != null)
		{
			this.gdelegate28_5(geventArgs16_0.method_0(), geventArgs16_0);
		}
	}

	protected virtual void vmethod_22(GEventArgs16 geventArgs16_0)
	{
		if (this.method_246())
		{
			if (this.method_197() != null)
			{
				this.method_197().imethod_19(geventArgs16_0);
			}
			if (this.gdelegate28_6 != null)
			{
				this.gdelegate28_6(geventArgs16_0.method_0(), geventArgs16_0);
			}
		}
	}

	protected virtual void vmethod_23(GEventArgs16 geventArgs16_0)
	{
		if (this.method_246())
		{
			if (this.method_197() != null)
			{
				this.method_197().GInterface8.imethod_20(geventArgs16_0);
			}
			if (this.gdelegate28_7 != null)
			{
				this.gdelegate28_7(geventArgs16_0.method_0(), geventArgs16_0);
			}
		}
	}

	protected virtual void vmethod_24(EventArgs eventArgs_0)
	{
		if (this.method_246())
		{
			base.PerformLayout();
			base.Invalidate();
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, eventArgs_0);
			}
		}
	}

	protected internal virtual void vmethod_25(GClass90 gclass90_0)
	{
		if (this.method_246())
		{
			base.PerformLayout();
			base.Invalidate();
			if (this.gdelegate9_0 != null)
			{
				this.gdelegate9_0(this, gclass90_0);
			}
		}
	}

	protected internal virtual void vmethod_26(GClass90 gclass90_0)
	{
		if (this.method_246())
		{
			base.PerformLayout();
			base.Invalidate();
			if (this.gdelegate9_1 != null)
			{
				this.gdelegate9_1(this, gclass90_0);
			}
		}
	}

	protected internal virtual void vmethod_27(EventArgs eventArgs_0)
	{
		if (this.method_246())
		{
			base.PerformLayout();
			base.Invalidate();
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, eventArgs_0);
			}
		}
	}

	protected internal virtual void vmethod_28(GEventArgs5 geventArgs5_0)
	{
		if (this.method_246() && this.gdelegate27_0 != null)
		{
			this.gdelegate27_0(geventArgs5_0.method_0(), geventArgs5_0);
		}
	}

	protected internal virtual void vmethod_29(GEventArgs5 geventArgs5_0)
	{
		if (this.method_246() && this.gdelegate27_1 != null)
		{
			this.gdelegate27_1(geventArgs5_0.method_0(), geventArgs5_0);
		}
	}

	protected internal virtual void vmethod_30(GEventArgs5 geventArgs5_0)
	{
		if (this.method_246() && this.gdelegate27_2 != null)
		{
			this.gdelegate27_2(geventArgs5_0.method_0(), geventArgs5_0);
		}
	}

	protected virtual void OnGotFocus(EventArgs eventArgs_0)
	{
		if (this.method_159().method_5())
		{
			GStruct9 gstruct9_ = this.method_103(this.method_159(), true, true, true, true);
			if (this.method_102(gstruct9_))
			{
				this.method_160(gstruct9_);
			}
		}
		else
		{
			this.method_262(this.method_159());
		}
		if (this.method_238().Length > 0)
		{
			base.Invalidate(this.method_164());
		}
		base.OnGotFocus(eventArgs_0);
	}

	protected virtual void OnLostFocus(EventArgs eventArgs_0)
	{
		if (!this.method_159().method_5())
		{
			this.method_263(this.method_159());
		}
		if (this.method_238().Length > 0)
		{
			base.Invalidate(this.method_164());
		}
		base.OnLostFocus(eventArgs_0);
	}

	protected virtual void OnKeyDown(KeyEventArgs keyEventArgs_0)
	{
		base.OnKeyDown(keyEventArgs_0);
		if (this.method_102(this.method_159()))
		{
			if (this.method_134(keyEventArgs_0.KeyData))
			{
				Keys keys = keyEventArgs_0.KeyData & Keys.KeyCode;
				if (keys != Keys.Up && keys != Keys.Down && keys != Keys.Left)
				{
					if (keys != Keys.Right)
					{
						if (keyEventArgs_0.KeyData == Keys.Prior)
						{
							if (this.method_205() <= 0)
							{
								return;
							}
							GStruct9 gstruct9_;
							if (!this.method_214())
							{
								gstruct9_ = this.method_103(new GStruct9(0, this.method_159().method_3()), true, true, true, false);
							}
							else if (this.method_159().method_1() > this.vscrollBar_0.Value && this.method_239().method_10(this.vscrollBar_0.Value, this.method_159().method_3()).method_40())
							{
								gstruct9_ = this.method_103(new GStruct9(this.vscrollBar_0.Value, this.method_159().method_3()), true, true, true, false);
							}
							else
							{
								gstruct9_ = this.method_103(new GStruct9(Math.Max(-1, this.vscrollBar_0.Value - (this.vscrollBar_0.LargeChange - 1)), this.method_159().method_3()), true, true, true, false);
							}
							if (GStruct9.smethod_1(gstruct9_, GStruct9.gstruct9_0))
							{
								this.method_160(gstruct9_);
								this.method_239().method_13().method_1(this.method_159());
								return;
							}
							return;
						}
						else if (keyEventArgs_0.KeyData == Keys.Next)
						{
							if (this.method_205() <= 0)
							{
								return;
							}
							GStruct9 gstruct9_2;
							if (!this.method_214())
							{
								gstruct9_2 = this.method_103(new GStruct9(this.method_205() - 1, this.method_159().method_3()), true, false, true, false);
							}
							else if (this.method_159().method_1() < this.vscrollBar_0.Value + this.vscrollBar_0.LargeChange)
							{
								if (this.method_159().method_1() == this.vscrollBar_0.Value + this.vscrollBar_0.LargeChange - 1 && this.method_113(this.vscrollBar_0.Value + this.vscrollBar_0.LargeChange).Bottom > this.method_164().Bottom)
								{
									gstruct9_2 = this.method_103(new GStruct9(Math.Min(this.method_205() - 1, this.method_159().method_1() - 1 + this.vscrollBar_0.LargeChange), this.method_159().method_3()), true, false, true, false);
								}
								else
								{
									gstruct9_2 = this.method_103(new GStruct9(this.vscrollBar_0.Value + this.vscrollBar_0.LargeChange - 1, this.method_159().method_3()), true, false, true, false);
								}
							}
							else
							{
								gstruct9_2 = this.method_103(new GStruct9(Math.Min(this.method_205() - 1, this.method_159().method_1() + this.vscrollBar_0.LargeChange), this.method_159().method_3()), true, false, true, false);
							}
							if (GStruct9.smethod_1(gstruct9_2, GStruct9.gstruct9_0))
							{
								this.method_160(gstruct9_2);
								this.method_239().method_13().method_1(this.method_159());
								return;
							}
							return;
						}
						else
						{
							if ((keyEventArgs_0.KeyData != Keys.Home && keyEventArgs_0.KeyData != Keys.End) || this.method_205() <= 0)
							{
								return;
							}
							GStruct9 gstruct9_3;
							if (keyEventArgs_0.KeyData == Keys.Home)
							{
								gstruct9_3 = this.method_103(GStruct9.gstruct9_0, true, true, true, true);
							}
							else
							{
								gstruct9_3 = this.method_103(new GStruct9(this.method_205() - 1, this.method_239().method_12().method_9(this.method_205() - 1).method_9().Count), true, false, true, true);
							}
							if (GStruct9.smethod_1(gstruct9_3, GStruct9.gstruct9_0))
							{
								this.method_160(gstruct9_3);
								this.method_239().method_13().method_1(this.method_159());
								return;
							}
							return;
						}
					}
				}
				GStruct9 gstruct9_4;
				if (keys == Keys.Up)
				{
					gstruct9_4 = this.method_103(this.method_159(), this.method_159().method_1() > 0, false, false, false);
				}
				else if (keys == Keys.Down)
				{
					gstruct9_4 = this.method_103(this.method_159(), this.method_159().method_1() < this.method_205() - 1, true, false, false);
				}
				else if (keys == Keys.Left)
				{
					gstruct9_4 = this.method_103(this.method_159(), false, false, false, true);
				}
				else
				{
					gstruct9_4 = this.method_103(this.method_159(), false, true, false, true);
				}
				if (GStruct9.smethod_1(gstruct9_4, GStruct9.gstruct9_0))
				{
					this.method_160(gstruct9_4);
					if ((keyEventArgs_0.KeyData & Keys.Modifiers) == Keys.Shift && this.method_219())
					{
						this.method_239().method_13().method_11(this.method_159());
						return;
					}
					this.method_239().method_13().method_1(this.method_159());
					return;
				}
			}
			else
			{
				if (keyEventArgs_0.KeyData == this.method_180() && this.method_178() == GEnum7.const_2)
				{
					this.method_121(this.method_159());
					return;
				}
				this.method_264(this.method_159(), keyEventArgs_0);
				return;
			}
		}
		else if (GStruct9.smethod_0(this.method_159(), GStruct9.gstruct9_0))
		{
			Keys keys2 = keyEventArgs_0.KeyData & Keys.KeyCode;
			if (this.method_134(keyEventArgs_0.KeyData) && (keys2 == Keys.Down || keys2 == Keys.Right))
			{
				GStruct9 gstruct9_5;
				if (keys2 == Keys.Down)
				{
					gstruct9_5 = this.method_103(this.method_159(), true, true, true, false);
				}
				else
				{
					gstruct9_5 = this.method_103(this.method_159(), false, true, true, true);
				}
				if (GStruct9.smethod_1(gstruct9_5, GStruct9.gstruct9_0))
				{
					this.method_160(gstruct9_5);
					if ((keyEventArgs_0.KeyData & Keys.Modifiers) == Keys.Shift && this.method_219())
					{
						this.method_239().method_13().method_11(this.method_159());
						return;
					}
					this.method_239().method_13().method_1(this.method_159());
				}
			}
		}
	}

	protected virtual void OnKeyUp(KeyEventArgs keyEventArgs_0)
	{
		base.OnKeyUp(keyEventArgs_0);
		if (!this.method_134(keyEventArgs_0.KeyData))
		{
			if (keyEventArgs_0.KeyData == this.method_180() && this.method_178() == GEnum7.const_2)
			{
				return;
			}
			this.method_265(this.method_159(), keyEventArgs_0);
		}
	}

	protected virtual void OnLayout(LayoutEventArgs levent)
	{
		if (base.IsHandleCreated && !this.bool_6)
		{
			base.OnLayout(levent);
			this.method_139();
			return;
		}
	}

	protected virtual void OnMouseUp(MouseEventArgs mouseEventArgs_0)
	{
		base.OnMouseUp(mouseEventArgs_0);
		if (!this.method_246())
		{
			return;
		}
		this.method_245(mouseEventArgs_0.X, mouseEventArgs_0.Y);
		GEnum2 genum = this.method_115(mouseEventArgs_0.X, mouseEventArgs_0.Y);
		if (mouseEventArgs_0.Button == MouseButtons.Left)
		{
			if (!this.method_158().method_5())
			{
				if (this.method_102(this.method_158()))
				{
					this.method_268(this.method_158(), mouseEventArgs_0);
				}
				this.gstruct9_1 = GStruct9.gstruct9_0;
			}
			if (this.int_1 != -1)
			{
				if (this.int_4 != -1)
				{
					this.method_278(this.method_109(this.int_1).Left + this.int_4);
				}
				this.method_166().method_23().method_8(this.int_1).method_10(this.int_4);
				this.int_1 = -1;
				this.int_4 = -1;
				this.method_139();
				base.Invalidate(this.method_163(), true);
			}
			if (genum == GEnum2.const_1)
			{
				int num = this.method_105(mouseEventArgs_0.X, mouseEventArgs_0.Y);
				if (this.int_5 != -1)
				{
					if (this.int_5 == num)
					{
						if (this.int_6 != -1 && this.int_6 != num)
						{
							this.method_166().method_23().method_8(this.int_6).method_18(GEnum62.const_0);
						}
						this.method_166().method_23().method_8(this.int_5).method_18(GEnum62.const_1);
						this.method_274(num, mouseEventArgs_0);
					}
					this.int_5 = -1;
					if (this.method_166().method_23().method_8(num).vmethod_6() && this.method_239() != null && this.method_239().method_12().Count > 0)
					{
						this.method_148(num);
					}
					base.Invalidate(this.method_193(), false);
				}
				return;
			}
			if (this.int_5 != -1)
			{
				this.int_5 = -1;
				base.Invalidate(this.method_193(), false);
			}
		}
	}

	protected virtual void OnMouseDown(MouseEventArgs mouseEventArgs_0)
	{
		base.OnMouseDown(mouseEventArgs_0);
		if (!this.method_246())
		{
			return;
		}
		this.method_245(mouseEventArgs_0.X, mouseEventArgs_0.Y);
		GEnum2 genum = this.method_115(mouseEventArgs_0.X, mouseEventArgs_0.Y);
		int num = this.method_111(mouseEventArgs_0.X, mouseEventArgs_0.Y);
		int num2 = this.method_105(mouseEventArgs_0.X, mouseEventArgs_0.Y);
		if (this.method_175() && (this.method_176().method_1() != num || this.method_176().method_3() != num2))
		{
			base.Focus();
			if (genum == GEnum2.const_1 && mouseEventArgs_0.Button != MouseButtons.Right)
			{
				return;
			}
		}
		if (genum == GEnum2.const_1)
		{
			if (mouseEventArgs_0.Button == MouseButtons.Right && this.method_199().method_1())
			{
				this.method_199().method_0(this, new Point(mouseEventArgs_0.X, mouseEventArgs_0.Y));
				return;
			}
			if (num2 == -1 || !this.method_166().method_23().method_8(num2).method_31())
			{
				return;
			}
			if (mouseEventArgs_0.Button == MouseButtons.Left)
			{
				this.method_160(new GStruct9(-1, -1));
				if (mouseEventArgs_0.Clicks > 1)
				{
					return;
				}
				this.method_275(num2, mouseEventArgs_0);
				if (this.method_243() == GEnum45.const_2)
				{
					Rectangle rectangle = this.method_166().method_9(num2);
					int x = this.method_90(mouseEventArgs_0.X, mouseEventArgs_0.Y).X;
					if (x <= rectangle.Left + GClass17.int_5)
					{
						num2 = this.method_166().method_21(num2);
					}
					this.int_1 = num2;
					if (this.int_1 != -1)
					{
						this.int_2 = this.method_166().method_9(num2).Left;
						this.int_3 = x - (this.int_2 + this.method_166().method_23().method_8(num2).method_9());
						return;
					}
				}
				else
				{
					if (this.method_190() != ColumnHeaderStyle.Clickable || !this.method_166().method_23().method_8(num2).vmethod_6())
					{
						return;
					}
					if (num2 == -1)
					{
						return;
					}
					if (this.int_5 != -1)
					{
						this.method_166().method_23().method_8(this.int_5).method_18(GEnum62.const_0);
					}
					this.int_5 = num2;
					this.method_166().method_23().method_8(num2).method_18(GEnum62.const_2);
				}
				return;
			}
		}
		if (genum == GEnum2.const_0)
		{
			if (mouseEventArgs_0.Button != MouseButtons.Left && mouseEventArgs_0.Button != MouseButtons.Right)
			{
				return;
			}
			if (!this.method_101(num, num2) || !this.method_126(num, num2))
			{
				this.method_239().method_13().method_13();
				return;
			}
			this.method_160(new GStruct9(num, num2));
			if (mouseEventArgs_0.Clicks > 1 || !this.method_215())
			{
				return;
			}
			this.gstruct9_1.method_2(num);
			this.gstruct9_1.method_4(num2);
			this.method_269(new GStruct9(num, num2), mouseEventArgs_0);
			if (!this.method_166().method_23().method_8(num2).vmethod_11())
			{
				return;
			}
			if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift && this.method_219())
			{
				if (mouseEventArgs_0.Button == MouseButtons.Right)
				{
					return;
				}
				this.method_239().method_13().method_10(num, num2);
				return;
			}
			else if ((Control.ModifierKeys & Keys.Control) == Keys.Control && this.method_219())
			{
				if (mouseEventArgs_0.Button == MouseButtons.Right)
				{
					return;
				}
				if (this.method_239().method_13().method_22(num, num2))
				{
					this.method_239().method_13().method_15(num, num2);
					return;
				}
				this.method_239().method_13().method_4(num, num2);
				return;
			}
			else
			{
				this.method_239().method_13().method_0(num, num2);
			}
		}
	}

	protected virtual void OnMouseMove(MouseEventArgs mouseEventArgs_0)
	{
		base.OnMouseMove(mouseEventArgs_0);
		if (this.method_243() == GEnum45.const_3)
		{
			return;
		}
		if (mouseEventArgs_0.Button == MouseButtons.Left && !this.method_158().method_5() && this.method_102(this.method_158()))
		{
			this.method_270(this.method_158(), mouseEventArgs_0);
			return;
		}
		if (this.int_1 != -1)
		{
			if (this.int_4 != -1)
			{
				this.method_278(this.method_109(this.int_1).Left + this.int_4);
			}
			int num = this.method_90(mouseEventArgs_0.X, mouseEventArgs_0.Y).X - this.int_2 - this.int_3;
			if (num < GClass17.int_8)
			{
				num = GClass17.int_8;
			}
			else if (num > GClass17.int_7)
			{
				num = GClass17.int_7;
			}
			this.int_4 = num;
			this.method_278(this.method_109(this.int_1).Left + this.int_4);
			return;
		}
		this.method_245(mouseEventArgs_0.X, mouseEventArgs_0.Y);
		GEnum2 genum = this.method_115(mouseEventArgs_0.X, mouseEventArgs_0.Y);
		if (genum == GEnum2.const_1)
		{
			int num2 = this.method_105(mouseEventArgs_0.X, mouseEventArgs_0.Y);
			if (this.int_6 != num2)
			{
				if (this.int_6 != -1)
				{
					this.method_166().method_23().method_8(this.int_6).method_18(GEnum62.const_0);
					this.method_273(this.int_6);
				}
				if (this.method_243() != GEnum45.const_2)
				{
					this.int_6 = num2;
					if (this.int_6 != -1 && this.method_166().method_23().method_8(num2).method_31())
					{
						this.method_166().method_23().method_8(num2).method_18(GEnum62.const_1);
						this.method_272(num2);
					}
				}
			}
			else if (num2 != -1 && this.method_166().method_23().method_8(num2).method_31())
			{
				this.method_276(num2, mouseEventArgs_0);
			}
			if (this.int_5 != -1 && this.int_5 != num2)
			{
				this.method_166().method_23().method_8(this.int_5).method_18(GEnum62.const_0);
			}
			else if (num2 != -1 && this.int_5 == num2 && this.method_166().method_23().method_8(this.int_5).method_16() != GEnum62.const_2)
			{
				this.method_166().method_23().method_8(this.int_5).method_18(GEnum62.const_2);
			}
			if (this.method_243() == GEnum45.const_2)
			{
				Rectangle rectangle = this.method_166().method_9(num2);
				int x = this.method_90(mouseEventArgs_0.X, mouseEventArgs_0.Y).X;
				this.Cursor = Cursors.VSplit;
				if (mouseEventArgs_0.Button == MouseButtons.Left)
				{
					this.Cursor = Cursors.Default;
				}
				if (x < rectangle.Left + GClass17.int_5)
				{
					int num3 = num2;
					while (num3 != 0)
					{
						num3--;
						if (this.method_166().method_23().method_8(num3).method_19())
						{
							break;
						}
					}
					if (num3 != -1)
					{
						if (this.method_166().method_23().method_8(num3).method_31())
						{
							if (this.int_6 != -1)
							{
								this.method_166().method_23().method_8(this.int_6).method_18(GEnum62.const_0);
							}
							this.int_6 = num3;
							this.method_166().method_23().method_8(this.int_6).method_18(GEnum62.const_1);
							this.method_272(num3);
						}
						else
						{
							this.Cursor = Cursors.Default;
						}
					}
				}
				else if (this.method_166().method_23().method_8(num2).method_31())
				{
					this.int_6 = num2;
					this.method_166().method_23().method_8(this.int_6).method_18(GEnum62.const_1);
				}
				else
				{
					this.Cursor = Cursors.Default;
				}
			}
			else
			{
				this.Cursor = Cursors.Default;
			}
			this.method_271();
			return;
		}
		if (this.int_6 != -1)
		{
			this.method_166().method_23().method_8(this.int_6).method_18(GEnum62.const_0);
			this.method_277();
		}
		if (this.int_5 != -1)
		{
			this.method_166().method_23().method_8(this.int_5).method_18(GEnum62.const_0);
		}
		if (genum != GEnum2.const_0)
		{
			this.method_271();
			if (!this.gstruct9_1.method_5())
			{
				this.method_267(this.gstruct9_1);
			}
			if (this.method_239() == null)
			{
				this.method_260();
			}
			this.Cursor = Cursors.Default;
			return;
		}
		GStruct9 gstruct9_ = new GStruct9(this.method_111(mouseEventArgs_0.X, mouseEventArgs_0.Y), this.method_105(mouseEventArgs_0.X, mouseEventArgs_0.Y));
		if (gstruct9_.method_5())
		{
			this.method_271();
			if (this.method_239() == null)
			{
				this.method_260();
			}
			return;
		}
		if (!GStruct9.smethod_1(gstruct9_, this.gstruct9_0))
		{
			this.method_270(gstruct9_, mouseEventArgs_0);
			return;
		}
		if (this.method_102(gstruct9_))
		{
			GStruct9 gstruct = this.gstruct9_0;
			if (!gstruct.method_5())
			{
				this.method_271();
			}
			this.gstruct9_0 = gstruct9_;
			this.method_266(gstruct9_);
			return;
		}
		this.method_271();
		this.Cursor = Cursors.Default;
	}

	protected virtual void OnMouseLeave(EventArgs eventArgs_0)
	{
		base.OnMouseLeave(eventArgs_0);
		if (this.int_6 != -1)
		{
			this.method_166().method_23().method_8(this.int_6).method_18(GEnum62.const_0);
			this.method_277();
		}
	}

	protected virtual void OnMouseWheel(MouseEventArgs mouseEventArgs_0)
	{
		base.OnMouseWheel(mouseEventArgs_0);
		if (!this.method_211() || (!this.method_213() && !this.method_214()))
		{
			return;
		}
		if (this.method_214())
		{
			int num = this.vscrollBar_0.Value - mouseEventArgs_0.Delta / 120 * SystemInformation.MouseWheelScrollLines;
			if (num < 0)
			{
				num = 0;
			}
			else if (num > this.vscrollBar_0.Maximum - this.vscrollBar_0.LargeChange + 1)
			{
				num = this.vscrollBar_0.Maximum - this.vscrollBar_0.LargeChange + 1;
			}
			this.method_141(num);
			this.vscrollBar_0.Value = num;
			return;
		}
		if (this.method_213())
		{
			int num2 = this.hscrollBar_0.Value - mouseEventArgs_0.Delta / 120 * GClass17.int_8;
			if (num2 < 0)
			{
				num2 = 0;
			}
			else if (num2 > this.hscrollBar_0.Maximum - this.hscrollBar_0.LargeChange)
			{
				num2 = this.hscrollBar_0.Maximum - this.hscrollBar_0.LargeChange;
			}
			this.method_140(num2);
			this.hscrollBar_0.Value = num2;
		}
	}

	protected virtual void OnMouseHover(EventArgs eventArgs_0)
	{
		base.OnMouseHover(eventArgs_0);
		if (this.method_102(this.method_157()))
		{
			this.vmethod_12(new GEventArgs10(this.method_239().method_11(this.method_157()), this, this.method_157(), this.method_99(this.method_157())));
			return;
		}
		if (this.int_6 != -1)
		{
			this.vmethod_21(new GEventArgs16(this.method_166().method_23().method_8(this.int_6), this, this.int_6, this.method_95(this.method_166().method_9(this.int_6))));
		}
	}

	protected virtual void OnClick(EventArgs eventArgs_0)
	{
		base.OnClick(eventArgs_0);
		if (this.method_102(this.method_157()))
		{
			this.vmethod_13(new GEventArgs10(this.method_239().method_11(this.method_157()), this, this.method_157(), this.method_99(this.method_157())));
			return;
		}
		if (this.int_6 != -1)
		{
			this.vmethod_22(new GEventArgs16(this.method_166().method_23().method_8(this.int_6), this, this.int_6, this.method_95(this.method_166().method_9(this.int_6))));
		}
	}

	protected virtual void OnDoubleClick(EventArgs eventArgs_0)
	{
		base.OnDoubleClick(eventArgs_0);
		if (this.method_102(this.method_157()))
		{
			this.method_99(this.method_157());
			this.vmethod_14(new GEventArgs10(this.method_239().method_11(this.method_157()), this, this.method_157(), this.method_99(this.method_157())));
			return;
		}
		if (this.int_6 != -1)
		{
			this.vmethod_23(new GEventArgs16(this.method_166().method_23().method_8(this.int_6), this, this.int_6, this.method_95(this.method_166().method_9(this.int_6))));
		}
	}

	protected virtual void OnPaintBackground(PaintEventArgs pevent)
	{
		base.OnPaintBackground(pevent);
	}

	protected virtual void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		if (base.Width != 0 && base.Height != 0)
		{
			if (this.method_166() != null)
			{
				Region clip = paintEventArgs_0.Graphics.Clip;
				if (this.method_239() != null && this.method_239().method_12().Count > 0)
				{
					this.method_283(paintEventArgs_0);
					paintEventArgs_0.Graphics.Clip = clip;
				}
				if (this.method_182() != GEnum3.const_0)
				{
					this.method_281(paintEventArgs_0);
				}
				if (this.method_190() != ColumnHeaderStyle.None && this.method_166().method_23().Count > 0 && this.method_193().IntersectsWith(paintEventArgs_0.ClipRectangle))
				{
					this.method_282(paintEventArgs_0);
				}
				paintEventArgs_0.Graphics.Clip = clip;
			}
			this.method_285(paintEventArgs_0);
			this.method_279(paintEventArgs_0);
			return;
		}
	}

	void method_278(int int_9)
	{
		Point start = base.PointToScreen(new Point(int_9, this.method_163().Top));
		ControlPaint.DrawReversibleLine(start, new Point(start.X, start.Y + this.method_163().Height), this.BackColor);
	}

	protected void method_279(PaintEventArgs paintEventArgs_0)
	{
		if (this.method_154() == BorderStyle.Fixed3D)
		{
			if (GClass69.smethod_29())
			{
				GEnum58 genum58_ = GEnum58.const_0;
				if (!base.Enabled)
				{
					genum58_ = GEnum58.const_3;
				}
				Rectangle rectangle_ = new Rectangle(0, 0, SystemInformation.Border3DSize.Width, base.Height);
				if (rectangle_.IntersectsWith(paintEventArgs_0.ClipRectangle))
				{
					GClass69.smethod_22(paintEventArgs_0.Graphics, base.ClientRectangle, rectangle_, genum58_);
				}
				rectangle_ = new Rectangle(0, 0, base.Width, SystemInformation.Border3DSize.Height);
				if (rectangle_.IntersectsWith(paintEventArgs_0.ClipRectangle))
				{
					GClass69.smethod_22(paintEventArgs_0.Graphics, base.ClientRectangle, rectangle_, genum58_);
				}
				rectangle_ = new Rectangle(base.Width - SystemInformation.Border3DSize.Width, 0, base.Width, base.Height);
				if (rectangle_.IntersectsWith(paintEventArgs_0.ClipRectangle))
				{
					GClass69.smethod_22(paintEventArgs_0.Graphics, base.ClientRectangle, rectangle_, genum58_);
				}
				rectangle_ = new Rectangle(0, base.Height - SystemInformation.Border3DSize.Height, base.Width, SystemInformation.Border3DSize.Height);
				if (rectangle_.IntersectsWith(paintEventArgs_0.ClipRectangle))
				{
					GClass69.smethod_22(paintEventArgs_0.Graphics, base.ClientRectangle, rectangle_, genum58_);
				}
			}
			else
			{
				ControlPaint.DrawBorder3D(paintEventArgs_0.Graphics, 0, 0, base.Width, base.Height, Border3DStyle.Sunken);
			}
		}
		else if (this.method_154() == BorderStyle.FixedSingle)
		{
			paintEventArgs_0.Graphics.DrawRectangle(Pens.Black, 0, 0, base.Width - 1, base.Height - 1);
		}
		if (this.method_213() && this.method_214())
		{
			Rectangle rect = new Rectangle(base.Width - this.method_156() - SystemInformation.VerticalScrollBarWidth, base.Height - this.method_156() - SystemInformation.HorizontalScrollBarHeight, SystemInformation.VerticalScrollBarWidth, SystemInformation.HorizontalScrollBarHeight);
			if (rect.IntersectsWith(paintEventArgs_0.ClipRectangle))
			{
				paintEventArgs_0.Graphics.FillRectangle(SystemBrushes.Control, rect);
			}
		}
	}

	protected void method_280(PaintEventArgs paintEventArgs_0, int int_9, int int_10, Rectangle rectangle_0)
	{
		if (int_9 == 0 && int_10 == 1)
		{
			int_10 = 1;
		}
		GInterface2 ginterface = this.method_166().method_23().method_8(int_10).method_21();
		if (ginterface == null)
		{
			ginterface = this.method_166().method_16(this.method_166().method_23().method_8(int_10).vmethod_0());
		}
		if (ginterface == null)
		{
			return;
		}
		GEventArgs8 geventArgs = new GEventArgs8(paintEventArgs_0.Graphics, rectangle_0);
		geventArgs.Graphics.SetClip(Rectangle.Intersect(paintEventArgs_0.ClipRectangle, rectangle_0));
		if (int_10 < this.method_239().method_12().method_9(int_9).method_9().Count)
		{
			bool flag = false;
			if (this.method_221())
			{
				flag = this.method_239().method_13().method_24(int_9);
			}
			else if (this.method_217() == GEnum29.const_0)
			{
				if (this.method_239().method_13().method_24(int_9) && this.method_166().method_21(int_10) == -1)
				{
					flag = true;
				}
			}
			else if (this.method_217() == GEnum29.const_1 && this.method_239().method_13().method_22(int_9, int_10))
			{
				flag = true;
			}
			bool flag2 = this.method_239().method_10(int_9, int_10).method_37() && this.method_239().method_12().method_9(int_9).method_25() && this.method_166().method_23().method_8(int_10).vmethod_9();
			bool flag3 = this.method_239().method_10(int_9, int_10).method_40() && this.method_239().method_12().method_9(int_9).method_28() && this.method_166().method_23().method_8(int_10).method_31();
			geventArgs.method_1(this.method_239().method_10(int_9, int_10));
			geventArgs.method_5(int_9);
			geventArgs.method_7(int_10);
			geventArgs.method_3(this);
			geventArgs.method_9(flag);
			geventArgs.method_11(this.Focused && this.method_159().method_1() == int_9 && this.method_159().method_3() == int_10);
			geventArgs.method_13(int_10 == this.int_7);
			geventArgs.method_15(flag2);
			geventArgs.method_17(flag3);
			geventArgs.method_19(rectangle_0);
		}
		else
		{
			geventArgs.method_1(null);
			geventArgs.method_5(int_9);
			geventArgs.method_7(int_10);
			geventArgs.method_3(this);
			geventArgs.method_9(false);
			geventArgs.method_11(false);
			geventArgs.method_13(false);
			geventArgs.method_15(false);
			geventArgs.method_17(false);
			geventArgs.method_19(rectangle_0);
		}
		this.vmethod_31(geventArgs);
		if (!geventArgs.method_21())
		{
			ginterface.imethod_13(geventArgs);
		}
		this.vmethod_32(geventArgs);
	}

	protected virtual void vmethod_31(GEventArgs8 geventArgs8_0)
	{
		if (this.gdelegate5_0 != null)
		{
			this.gdelegate5_0(this, geventArgs8_0);
		}
	}

	protected virtual void vmethod_32(GEventArgs8 geventArgs8_0)
	{
		if (this.gdelegate5_1 != null)
		{
			this.gdelegate5_1(this, geventArgs8_0);
		}
	}

	protected void method_281(PaintEventArgs paintEventArgs_0)
	{
		if (this.method_182() == GEnum3.const_0)
		{
			return;
		}
		if (this.method_166() != null && this.method_166().method_23().Count != 0)
		{
			if (this.method_166() != null)
			{
				using (Pen pen = new Pen(this.method_186()))
				{
					pen.DashStyle = (DashStyle)this.method_184();
					if ((this.method_182() & GEnum3.const_1) == GEnum3.const_1)
					{
						int num = this.DisplayRectangle.X;
						for (int i = 0; i < this.method_166().method_23().Count; i++)
						{
							if (this.method_166().method_23().method_8(i).method_19())
							{
								num += this.method_166().method_23().method_8(i).method_9();
								if (num >= paintEventArgs_0.ClipRectangle.Left && num <= paintEventArgs_0.ClipRectangle.Right)
								{
									paintEventArgs_0.Graphics.DrawLine(pen, num - 1, paintEventArgs_0.ClipRectangle.Top, num - 1, paintEventArgs_0.ClipRectangle.Bottom);
								}
							}
						}
					}
					if (this.method_239() != null && (this.method_182() & GEnum3.const_2) == GEnum3.const_2)
					{
						int num2 = this.method_164().Y + this.method_202() - 1;
						for (int j = num2; j <= paintEventArgs_0.ClipRectangle.Bottom; j += this.method_202())
						{
							if (j >= this.method_164().Top)
							{
								paintEventArgs_0.Graphics.DrawLine(pen, paintEventArgs_0.ClipRectangle.Left, j, paintEventArgs_0.ClipRectangle.Right, j);
							}
						}
					}
				}
			}
			return;
		}
	}

	protected void method_282(PaintEventArgs paintEventArgs_0)
	{
		if (!this.method_193().IntersectsWith(paintEventArgs_0.ClipRectangle))
		{
			return;
		}
		int num = this.DisplayRectangle.Left;
		bool flag = true;
		GEventArgs7 geventArgs = new GEventArgs7(paintEventArgs_0.Graphics, paintEventArgs_0.ClipRectangle);
		for (int i = 0; i < this.method_166().method_23().Count; i++)
		{
			if (this.method_166().method_23().method_8(i).method_19())
			{
				Rectangle rect = new Rectangle(num, this.method_156(), this.method_166().method_23().method_8(i).method_9(), this.method_192());
				if (paintEventArgs_0.ClipRectangle.IntersectsWith(rect))
				{
					this.gclass13_0.imethod_2(new Rectangle(num, this.method_156(), this.method_166().method_23().method_8(i).method_9(), this.method_192()));
					geventArgs.Graphics.SetClip(Rectangle.Intersect(paintEventArgs_0.ClipRectangle, this.gclass13_0.GInterface1.imethod_1()));
					geventArgs.method_1(this.method_166().method_23().method_8(i));
					geventArgs.method_5(i);
					geventArgs.method_3(this);
					geventArgs.method_7(this.method_190());
					geventArgs.method_9(this.gclass13_0.GInterface1.imethod_1());
					this.vmethod_33(geventArgs);
					if (!geventArgs.method_10())
					{
						this.gclass13_0.GInterface8.imethod_13(geventArgs);
					}
					this.vmethod_34(geventArgs);
				}
				num += this.method_166().method_23().method_8(i).method_9();
				if (num >= paintEventArgs_0.ClipRectangle.Right)
				{
					return;
				}
				if (num >= base.ClientRectangle.Width)
				{
					flag = false;
					IL_1B2:
					if (flag)
					{
						this.gclass13_0.imethod_2(new Rectangle(num, this.method_156(), base.ClientRectangle.Width - num + 2, this.method_192()));
						geventArgs.Graphics.SetClip(Rectangle.Intersect(paintEventArgs_0.ClipRectangle, this.gclass13_0.GInterface1.imethod_1()));
						geventArgs.method_1(null);
						geventArgs.method_5(-1);
						geventArgs.method_3(this);
						geventArgs.method_7(this.method_190());
						geventArgs.method_9(this.gclass13_0.GInterface1.imethod_1());
						this.vmethod_33(geventArgs);
						if (!geventArgs.method_10())
						{
							this.gclass13_0.GInterface8.imethod_13(geventArgs);
						}
						this.vmethod_34(geventArgs);
					}
					return;
				}
			}
		}
		goto IL_1B2;
	}

	protected virtual void vmethod_33(GEventArgs7 geventArgs7_0)
	{
		if (this.gdelegate4_0 != null)
		{
			this.gdelegate4_0(this, geventArgs7_0);
		}
	}

	protected virtual void vmethod_34(GEventArgs7 geventArgs7_0)
	{
		if (this.gdelegate4_1 != null)
		{
			this.gdelegate4_1(this, geventArgs7_0);
		}
	}

	protected void method_283(PaintEventArgs paintEventArgs_0)
	{
		int left = this.DisplayRectangle.Left;
		int num = this.method_163().Top;
		if (this.method_190() != ColumnHeaderStyle.None)
		{
			num += this.method_192();
		}
		Rectangle rectangle_ = new Rectangle(left, num, this.method_166().method_28(), this.method_202());
		for (int i = this.method_207(); i < Math.Min(this.method_239().method_12().Count, this.method_207() + this.method_206() + 1); i++)
		{
			if (rectangle_.IntersectsWith(paintEventArgs_0.ClipRectangle))
			{
				this.method_284(paintEventArgs_0, i, rectangle_);
			}
			else if (rectangle_.Top > paintEventArgs_0.ClipRectangle.Bottom)
			{
				break;
			}
			rectangle_.Y += this.method_202();
		}
		if (this.method_153(this.int_7) && rectangle_.Y < this.method_163().Bottom)
		{
			Rectangle rectangle = this.method_109(this.int_7);
			rectangle.Y = rectangle_.Y;
			rectangle.Height = this.method_163().Bottom - rectangle_.Y;
			if (rectangle.IntersectsWith(paintEventArgs_0.ClipRectangle))
			{
				rectangle.Intersect(paintEventArgs_0.ClipRectangle);
				paintEventArgs_0.Graphics.SetClip(rectangle);
				using (SolidBrush solidBrush = new SolidBrush(this.method_172()))
				{
					paintEventArgs_0.Graphics.FillRectangle(solidBrush, rectangle);
				}
			}
		}
	}

	protected void method_284(PaintEventArgs paintEventArgs_0, int int_9, Rectangle rectangle_0)
	{
		Rectangle rectangle_ = new Rectangle(rectangle_0.X, rectangle_0.Y, 0, rectangle_0.Height);
		for (int i = 0; i < this.method_166().method_23().Count; i++)
		{
			if (this.method_166().method_23().method_8(i).method_19())
			{
				rectangle_.Width = this.method_166().method_23().method_8(i).method_9();
				if (rectangle_.IntersectsWith(paintEventArgs_0.ClipRectangle))
				{
					this.method_280(paintEventArgs_0, int_9, i, rectangle_);
				}
				else if (rectangle_.Left > paintEventArgs_0.ClipRectangle.Right)
				{
					return;
				}
				rectangle_.X += this.method_166().method_23().method_8(i).method_9();
			}
		}
	}

	protected void method_285(PaintEventArgs paintEventArgs_0)
	{
		if (this.method_166() == null || this.method_205() == 0)
		{
			Rectangle r = this.method_164();
			r.Y += 10;
			r.Height -= 10;
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			using (SolidBrush solidBrush = new SolidBrush(this.ForeColor))
			{
				if (base.DesignMode)
				{
					if (this.method_166() != null && this.method_239() != null)
					{
						if (this.method_239() != null && this.method_239().method_12().Count == 0 && this.method_241() != null && this.method_241().Length > 0)
						{
							paintEventArgs_0.Graphics.DrawString(this.method_241(), this.Font, solidBrush, r, stringFormat);
						}
					}
					else
					{
						string s = null;
						if (this.method_166() == null)
						{
							if (this.method_239() == null)
							{
								s = "Table does not have a ColumnModel or TableModel";
							}
							else
							{
								s = "Table does not have a ColumnModel";
							}
						}
						else if (this.method_239() == null)
						{
							s = "Table does not have a TableModel";
						}
						paintEventArgs_0.Graphics.DrawString(s, this.Font, solidBrush, r, stringFormat);
					}
				}
				else if (this.method_241() != null && this.method_241().Length > 0)
				{
					paintEventArgs_0.Graphics.DrawString(this.method_241(), this.Font, solidBrush, r, stringFormat);
				}
			}
		}
	}

	protected internal virtual void vmethod_35(GEventArgs6 geventArgs6_0)
	{
		if (this.method_246())
		{
			this.method_132(geventArgs6_0.method_1());
			if (this.gdelegate3_2 != null)
			{
				this.gdelegate3_2(geventArgs6_0.method_0(), geventArgs6_0);
			}
		}
	}

	protected internal virtual void vmethod_36(GEventArgs6 geventArgs6_0)
	{
		if (this.method_246())
		{
			this.method_132(geventArgs6_0.method_1());
			if (this.gdelegate3_0 != null)
			{
				this.gdelegate3_0(geventArgs6_0.method_0(), geventArgs6_0);
			}
		}
	}

	protected internal virtual void vmethod_37(GEventArgs6 geventArgs6_0)
	{
		if (this.method_246())
		{
			this.method_132(geventArgs6_0.method_1());
			if (this.gdelegate3_1 != null)
			{
				this.gdelegate3_1(this, geventArgs6_0);
			}
			if (geventArgs6_0.method_4() == -1 && geventArgs6_0.method_5() == -1)
			{
				if (this.method_159().method_1() == geventArgs6_0.method_1())
				{
					this.gstruct9_2 = GStruct9.gstruct9_0;
					return;
				}
			}
			else
			{
				for (int i = geventArgs6_0.method_4(); i <= geventArgs6_0.method_5(); i++)
				{
					if (this.method_159().method_1() == geventArgs6_0.method_1() && this.method_159().method_3() == i)
					{
						this.gstruct9_2 = GStruct9.gstruct9_0;
						return;
					}
				}
			}
		}
	}

	protected void hscrollBar_0_Scroll(object sender, ScrollEventArgs e)
	{
		if (this.method_175())
		{
			this.method_122();
		}
		if (this.method_246())
		{
			if (e.Type == ScrollEventType.ThumbPosition)
			{
				if (this.method_184() != GEnum61.const_0 && (this.method_182() == GEnum3.const_2 || this.method_182() == GEnum3.const_3))
				{
					base.Invalidate(this.method_164(), false);
				}
				if (GStruct9.smethod_1(this.method_159(), GStruct9.gstruct9_0))
				{
					base.Invalidate(this.method_99(this.method_159()), false);
					return;
				}
			}
			else
			{
				this.method_140(e.NewValue);
			}
		}
	}

	protected void vscrollBar_0_Scroll(object sender, ScrollEventArgs e)
	{
		if (this.method_175())
		{
			this.method_122();
		}
		if (this.method_246())
		{
			if (e.Type == ScrollEventType.ThumbPosition)
			{
				if (this.method_184() != GEnum61.const_0 && (this.method_182() == GEnum3.const_1 || this.method_182() == GEnum3.const_3))
				{
					base.Invalidate(this.method_164(), false);
					return;
				}
			}
			else
			{
				this.method_141(e.NewValue);
			}
		}
	}

	void method_286(object sender, EventArgs e)
	{
		base.Focus();
	}

	protected virtual void vmethod_38(GClass93 gclass93_0)
	{
		if (this.gdelegate11_1 != null)
		{
			this.gdelegate11_1(this, gclass93_0);
		}
	}

	protected virtual void vmethod_39(GClass93 gclass93_0)
	{
		if (this.gdelegate11_2 != null)
		{
			this.gdelegate11_2(this, gclass93_0);
		}
	}

	protected internal virtual void vmethod_40(EventArgs eventArgs_0)
	{
		if (this.method_246())
		{
			base.PerformLayout();
			base.Invalidate();
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, eventArgs_0);
			}
		}
	}

	protected internal virtual void vmethod_41(GEventArgs13 geventArgs13_0)
	{
		if (this.method_246())
		{
			if (geventArgs13_0.method_3() != Rectangle.Empty)
			{
				Rectangle rc = new Rectangle(this.method_94(geventArgs13_0.method_3().Location), geventArgs13_0.method_3().Size);
				if (this.method_190() != ColumnHeaderStyle.None)
				{
					rc.Y += this.method_192();
				}
				base.Invalidate(rc);
			}
			if (geventArgs13_0.method_4() != Rectangle.Empty)
			{
				Rectangle rc2 = new Rectangle(this.method_94(geventArgs13_0.method_4().Location), geventArgs13_0.method_4().Size);
				if (this.method_190() != ColumnHeaderStyle.None)
				{
					rc2.Y += this.method_192();
				}
				base.Invalidate(rc2);
			}
			if (this.gdelegate18_0 != null)
			{
				this.gdelegate18_0(this, geventArgs13_0);
			}
		}
	}

	protected internal virtual void vmethod_42(EventArgs eventArgs_0)
	{
		if (this.method_246())
		{
			base.PerformLayout();
			base.Invalidate();
			if (this.eventHandler_3 != null)
			{
				this.eventHandler_3(this, eventArgs_0);
			}
		}
	}

	protected internal virtual void vmethod_43(GEventArgs9 geventArgs9_0)
	{
		if (this.method_246())
		{
			base.PerformLayout();
			base.Invalidate();
			if (this.gdelegate8_0 != null)
			{
				this.gdelegate8_0(geventArgs9_0.method_0(), geventArgs9_0);
			}
		}
	}

	protected internal virtual void vmethod_44(GEventArgs9 geventArgs9_0)
	{
		if (this.method_246())
		{
			base.PerformLayout();
			base.Invalidate();
			if (this.gdelegate8_1 != null)
			{
				this.gdelegate8_1(geventArgs9_0.method_0(), geventArgs9_0);
			}
		}
	}

	GDelegate7 gdelegate7_0;

	GDelegate25 gdelegate25_0;

	GDelegate25 gdelegate25_1;

	GDelegate29 gdelegate29_0;

	GDelegate29 gdelegate29_1;

	GDelegate14 gdelegate14_0;

	GDelegate14 gdelegate14_1;

	GDelegate14 gdelegate14_2;

	GDelegate14 gdelegate14_3;

	GDelegate14 gdelegate14_4;

	GDelegate14 gdelegate14_5;

	GDelegate14 gdelegate14_6;

	GDelegate14 gdelegate14_7;

	GDelegate10 gdelegate10_0;

	GDelegate26 gdelegate26_0;

	GDelegate11 gdelegate11_0;

	GDelegate28 gdelegate28_0;

	GDelegate28 gdelegate28_1;

	GDelegate28 gdelegate28_2;

	GDelegate28 gdelegate28_3;

	GDelegate28 gdelegate28_4;

	GDelegate28 gdelegate28_5;

	GDelegate28 gdelegate28_6;

	GDelegate28 gdelegate28_7;

	EventHandler eventHandler_0;

	EventHandler eventHandler_1;

	GDelegate9 gdelegate9_0;

	GDelegate9 gdelegate9_1;

	GDelegate27 gdelegate27_0;

	GDelegate27 gdelegate27_1;

	GDelegate27 gdelegate27_2;

	GDelegate3 gdelegate3_0;

	GDelegate3 gdelegate3_1;

	GDelegate3 gdelegate3_2;

	GDelegate11 gdelegate11_1;

	GDelegate11 gdelegate11_2;

	GDelegate5 gdelegate5_0;

	GDelegate5 gdelegate5_1;

	GDelegate4 gdelegate4_0;

	GDelegate4 gdelegate4_1;

	EventHandler eventHandler_2;

	GDelegate8 gdelegate8_0;

	GDelegate8 gdelegate8_1;

	GDelegate18 gdelegate18_0;

	EventHandler eventHandler_3;

	Container container_0;

	BorderStyle borderStyle_0;

	GStruct9 gstruct9_0;

	GStruct9 gstruct9_1;

	GStruct9 gstruct9_2;

	GStruct9 gstruct9_3;

	GInterface3 ginterface3_0;

	GEnum7 genum7_0;

	Keys keys_0;

	int int_0;

	Class85 class85_0;

	GClass32 gclass32_0;

	bool bool_0;

	int int_1;

	int int_2;

	int int_3;

	int int_4;

	int int_5;

	int int_6;

	int int_7;

	Color color_0;

	GEnum3 genum3_0;

	Color color_1;

	GEnum61 genum61_0;

	ColumnHeaderStyle columnHeaderStyle_0;

	GClass13 gclass13_0;

	Font font_0;

	GClass77 gclass77_0;

	GClass104 gclass104_0;

	bool bool_1;

	HScrollBar hscrollBar_0;

	VScrollBar vscrollBar_0;

	bool bool_2;

	bool bool_3;

	bool bool_4;

	bool bool_5;

	Color color_2;

	Color color_3;

	Color color_4;

	Color color_5;

	GEnum29 genum29_0;

	GEnum45 genum45_0;

	bool bool_6;

	int int_8;

	ToolTip toolTip_0;

	Color color_6;

	string string_0;

	bool bool_7;
}
