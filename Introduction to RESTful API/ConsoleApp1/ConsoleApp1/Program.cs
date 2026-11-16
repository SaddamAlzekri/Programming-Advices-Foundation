using System;
using System.Runtime.InteropServices;

class Program
{
    // Win32 API
    [DllImport("user32.dll", SetLastError = true)]
    static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

    // Constants
    const uint EWX_SHUTDOWN = 0x00000001;
    const uint EWX_REBOOT = 0x00000002;
    const uint EWX_LOGOFF = 0x00000000;
    const uint EWX_FORCE = 0x00000004;

    static void Main()
    {
        // إغلاق الجهاز
       // ExitWindowsEx(EWX_SHUTDOWN | EWX_FORCE, 0);

        // إعادة تشغيل:
        // ExitWindowsEx(EWX_REBOOT | EWX_FORCE, 0);

        // تسجيل خروج:
         ExitWindowsEx(EWX_LOGOFF, 0);
    }
}