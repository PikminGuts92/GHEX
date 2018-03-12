using System;
using System.Runtime.InteropServices;

abstract class Class96
{
	[DllImport("Comctl32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern int DllGetVersion(ref Struct5 struct5_0);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool IsThemeActive();

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool IsAppThemed();

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern IntPtr OpenThemeData(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPTStr)] string string_0);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern int CloseThemeData(IntPtr intptr_0);

	[DllImport("UxTheme.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern int DrawThemeBackground(IntPtr intptr_0, IntPtr intptr_1, int int_0, int int_1, ref Struct8 struct8_0, ref Struct8 struct8_1);

	[DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern int SendMessage(IntPtr intptr_0, int int_0, int int_1, int int_2);

	[DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool TrackMouseEvent(Class85 class85_0);

	[DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern IntPtr PostMessage(IntPtr intptr_0, int int_0, int int_1, int int_2);

	[DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool MessageBeep(int int_0);

	[DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern void NotifyWinEvent(int int_0, IntPtr intptr_0, int int_1, int int_2);

	[DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool ScrollWindow(IntPtr intptr_0, int int_0, int int_1, ref Struct8 struct8_0, ref Struct8 struct8_1);

	[DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern void keybd_event(byte byte_0, byte byte_1, Enum9 enum9_0, int int_0);

	[DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool PeekMessage(ref Struct1 struct1_0, IntPtr intptr_0, int int_0, int int_1, int int_2);

	[DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool TranslateMessage(ref Struct1 struct1_0);

	[DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern int DispatchMessage(ref Struct1 struct1_0);
}
