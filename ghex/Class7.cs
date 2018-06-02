using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

class Class7
{
    public Class7()
    {
        this.delegate0_0 = new Class7.Delegate0(this.method_3);
    }

    public void method_0(IntPtr intptr_2)
    {
        this.intptr_0 = intptr_2;
        this.intptr_1 = Class7.SetWindowLong(intptr_2, -4, this.delegate0_0);
    }

    public void method_1()
    {
        Class7.SetWindowLong(this.intptr_0, -4, this.intptr_1);
        this.intptr_0 = IntPtr.Zero;
        this.intptr_1 = IntPtr.Zero;
    }

    protected virtual void vmethod_0(ref Message message_0)
    {
        this.method_2(ref message_0);
    }

    public void method_2(ref Message message_0)
    {
        message_0.Result = Class7.CallWindowProc(this.intptr_1, message_0.HWnd, message_0.Msg, message_0.WParam, message_0.LParam);
    }

    IntPtr method_3(IntPtr intptr_2, int int_1, IntPtr intptr_3, IntPtr intptr_4)
    {
        Message message = Message.Create(intptr_2, int_1, intptr_3, intptr_4);
        this.vmethod_0(ref message);
        return message.Result;
    }

    [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    static extern IntPtr SetWindowLong(IntPtr intptr_2, int int_1, Class7.Delegate0 delegate0_1);

    [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    static extern IntPtr SetWindowLong(IntPtr intptr_2, int int_1, IntPtr intptr_3);

    [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    static extern IntPtr CallWindowProc(IntPtr intptr_2, IntPtr intptr_3, int int_1, IntPtr intptr_4, IntPtr intptr_5);

    public IntPtr method_4()
    {
        return this.intptr_0;
    }

    const int int_0 = -4;

    IntPtr intptr_0;

    Class7.Delegate0 delegate0_0;

    IntPtr intptr_1;

    delegate IntPtr Delegate0(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr intptr_2);
}
