using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

[StructLayout(LayoutKind.Sequential)]
class Class85
{
    public Class85()
    {
        SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
        securityPermission.Demand();
        this.int_0 = Marshal.SizeOf(typeof(Class85));
        this.int_1 = 0;
        this.intptr_0 = IntPtr.Zero;
        this.int_2 = 100;
    }

    public int int_0;

    public int int_1;

    public IntPtr intptr_0;

    public int int_2;
}
