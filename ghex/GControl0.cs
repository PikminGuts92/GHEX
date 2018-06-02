using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

[ToolboxItem(false)]
public class GControl0 : ContainerControl
{
    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_0(EventHandler eventHandler_1)
    {
        this.eventHandler_0 = (EventHandler)Delegate.Combine(this.eventHandler_0, eventHandler_1);
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public void method_1(EventHandler eventHandler_1)
    {
        this.eventHandler_0 = (EventHandler)Delegate.Remove(this.eventHandler_0, eventHandler_1);
    }

    public GControl0()
    {
        base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        base.SetStyle(ControlStyles.ResizeRedraw, true);
        base.SetStyle(ControlStyles.UserPaint, true);
    }

    protected override void OnSystemColorsChanged(EventArgs eventArgs_0)
    {
        base.OnSystemColorsChanged(eventArgs_0);
        this.method_2();
        base.Invalidate();
    }

    protected virtual void vmethod_0(EventArgs eventArgs_0)
    {
        if (this.eventHandler_0 != null)
        {
            this.eventHandler_0(this, eventArgs_0);
        }
    }

    void method_2()
    {
        if (!this.method_4())
        {
            GControl0.toolStripProfessionalRenderer_0.ColorTable.UseSystemColors = true;
            return;
        }
        GControl0.toolStripProfessionalRenderer_0.ColorTable.UseSystemColors = false;
    }

    public ToolStripProfessionalRenderer method_3()
    {
        return GControl0.toolStripProfessionalRenderer_0;
    }

    public bool method_4()
    {
        return VisualStyleRenderer.IsSupported && VisualStyleInformation.IsSupportedByOS && Application.RenderWithVisualStyles;
    }

    static ToolStripProfessionalRenderer toolStripProfessionalRenderer_0 = new ToolStripProfessionalRenderer();

    EventHandler eventHandler_0;
}
