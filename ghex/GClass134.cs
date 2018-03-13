using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GClass134 : ToolStrip
{
	public GClass134()
	{
		this.method_0();
	}

	public GClass134(params GClass135[] gclass135_1) : base(gclass135_1)
	{
		this.method_0();
	}

	protected void method_0()
	{
		base.RenderMode = ToolStripRenderMode.ManagerRenderMode;
		base.Renderer = this.class102_0;
		this.class102_0.method_1(this.method_8());
		this.designerVerb_0 = new DesignerVerb("Insert tab page", new EventHandler(this.method_1));
	}

	public override ISite Site
	{
		get
		{
			ISite site = base.Site;
			if (site != null && site.DesignMode)
			{
				IContainer container = site.Container;
				if (container != null)
				{
					IDesignerHost designerHost = container as IDesignerHost;
					if (designerHost != null)
					{
						IDesigner designer = designerHost.GetDesigner(site.Component);
						if (designer != null && !designer.Verbs.Contains(this.designerVerb_0))
						{
							designer.Verbs.Add(this.designerVerb_0);
						}
					}
				}
			}
			return site;
		}
		set
		{
			base.Site = value;
		}
	}

	protected void method_1(object sender, EventArgs e)
	{
		ISite site = base.Site;
		if (site != null && site.DesignMode)
		{
			IContainer container = site.Container;
			if (container != null)
			{
				GClass135 gclass = new GClass135();
				container.Add(gclass);
				gclass.Text = gclass.Name;
			}
		}
	}

	public ToolStripRenderer method_2()
	{
		return this.class102_0;
	}

	public void method_3(ToolStripRenderer toolStripRenderer_0)
	{
		base.Renderer = this.class102_0;
	}

	public ToolStripLayoutStyle method_4()
	{
		return base.LayoutStyle;
	}

	public void method_5(ToolStripLayoutStyle toolStripLayoutStyle_0)
	{
		switch (toolStripLayoutStyle_0)
		{
		case ToolStripLayoutStyle.StackWithOverflow:
		case ToolStripLayoutStyle.HorizontalStackWithOverflow:
		case ToolStripLayoutStyle.VerticalStackWithOverflow:
			base.LayoutStyle = ToolStripLayoutStyle.StackWithOverflow;
			return;
		case ToolStripLayoutStyle.Flow:
			base.LayoutStyle = ToolStripLayoutStyle.Flow;
			return;
		case ToolStripLayoutStyle.Table:
			base.LayoutStyle = ToolStripLayoutStyle.Table;
			return;
		default:
			base.LayoutStyle = ToolStripLayoutStyle.StackWithOverflow;
			return;
		}
	}

	public ToolStripRenderMode method_6()
	{
		return base.RenderMode;
	}

	public void method_7(ToolStripRenderMode toolStripRenderMode_0)
	{
		this.method_9(toolStripRenderMode_0);
	}

	public ToolStripRenderMode method_8()
	{
		return this.class102_0.method_0();
	}

	public void method_9(ToolStripRenderMode toolStripRenderMode_0)
	{
		this.class102_0.method_1(toolStripRenderMode_0);
		base.Invalidate();
	}

	protected override Padding DefaultPadding
	{
		get
		{
			return Padding.Empty;
		}
	}

	public Padding method_10()
	{
		return this.DefaultPadding;
	}

	public void method_11(Padding padding_0)
	{
	}

	public bool method_12()
	{
		return this.class102_0.method_4();
	}

	public void method_13(bool bool_0)
	{
		this.class102_0.method_5(bool_0);
		base.Invalidate();
	}

	public bool method_14()
	{
		return this.class102_0.method_2();
	}

	public void method_15(bool bool_0)
	{
		this.class102_0.method_3(bool_0);
		base.Invalidate();
	}

	public GClass135 method_16()
	{
		return this.gclass135_0;
	}

	public void method_17(GClass135 gclass135_1)
	{
		if (gclass135_1 == null)
		{
			return;
		}
		if (this.gclass135_0 == gclass135_1)
		{
			return;
		}
		if (gclass135_1.Owner != this)
		{
			throw new ArgumentException("Cannot select TabButtons that do not belong to this TabStrip");
		}
		this.OnItemClicked(new ToolStripItemClickedEventArgs(gclass135_1));
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_18(EventHandler<GEventArgs15> eventHandler_1)
	{
		this.eventHandler_0 = (EventHandler<GEventArgs15>)Delegate.Combine(this.eventHandler_0, eventHandler_1);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_19(EventHandler<GEventArgs15> eventHandler_1)
	{
		this.eventHandler_0 = (EventHandler<GEventArgs15>)Delegate.Remove(this.eventHandler_0, eventHandler_1);
	}

	protected void method_20(GClass135 gclass135_1)
	{
		base.Invalidate();
		if (this.eventHandler_0 != null)
		{
			this.eventHandler_0(this, new GEventArgs15(gclass135_1));
		}
	}

	protected override void OnItemAdded(ToolStripItemEventArgs toolStripItemEventArgs_0)
	{
		base.OnItemAdded(toolStripItemEventArgs_0);
		if (toolStripItemEventArgs_0.Item is GClass135)
		{
			this.method_17((GClass135)toolStripItemEventArgs_0.Item);
		}
	}

	protected override void OnItemClicked(ToolStripItemClickedEventArgs toolStripItemClickedEventArgs_0)
	{
		GClass135 gclass = toolStripItemClickedEventArgs_0.ClickedItem as GClass135;
		if (gclass != null)
		{
			base.SuspendLayout();
			this.gclass135_0 = gclass;
			base.ResumeLayout();
			this.method_20(gclass);
		}
		base.OnItemClicked(toolStripItemClickedEventArgs_0);
	}

	Class102 class102_0 = new Class102();

	protected GClass135 gclass135_0;

	DesignerVerb designerVerb_0;

	EventHandler<GEventArgs15> eventHandler_0;
}
