using System;
using System.Runtime.InteropServices;

class Program
{
    // استدعاء دالة Win32 من ملف user32.dll
    [DllImport("user32.dll", SetLastError = true)]
    private static extern bool SystemParametersInfo(
        uint uiAction,
        uint uiParam,
        string pvParam,
        uint fWinIni);

    // ثوابت خاصة بتغيير الخلفية
    private const uint SPI_SETDESKWALLPAPER = 20;
    private const uint SPIF_UPDATEINIFILE = 0x01;
    private const uint SPIF_SENDCHANGE = 0x02;

    // دالة تغيير خلفية سطح المكتب
    static void ChangeDesktopBackground(string imagePath)
    {
        bool result = SystemParametersInfo(
            SPI_SETDESKWALLPAPER,
            0,
            imagePath,
            SPIF_UPDATEINIFILE | SPIF_SENDCHANGE);

        if (result)
            Console.WriteLine("Wallpaper changed successfully.");
        else
            Console.WriteLine("Failed to change wallpaper.");
    }

    static void Main()
    {
        // ضع هنا مسار الصورة
        string path = @"E:\image\LIBMS2.jpg";

        ChangeDesktopBackground(path);
    }
}