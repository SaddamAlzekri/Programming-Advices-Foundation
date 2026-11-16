using System;
using System.Runtime.InteropServices;

class Program
{
    // استدعاء Win32 API
    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    static extern int MessageBox(
        IntPtr hWnd,
        string lpText,
        string lpCaption,
        uint uType);

    static void Main()
    {
        MessageBox(
            IntPtr.Zero,
            "Hello From Win32 API",
            "My Message Box",
            0);
    }
}
