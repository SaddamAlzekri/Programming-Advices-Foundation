using System;
using System.Runtime.InteropServices;

class Program
{
    // استدعاء دالة Win32
    [DllImport("user32.dll")]
    private static extern int GetSystemMetrics(int nIndex);

    // ثوابت العرض والطول
    private const int SM_CXSCREEN = 0; // عرض الشاشة
    private const int SM_CYSCREEN = 1; // ارتفاع الشاشة

    static void Main()
    {
        int width = GetSystemMetrics(SM_CXSCREEN);
        int height = GetSystemMetrics(SM_CYSCREEN);

        int resolution = width * height;

        Console.WriteLine($"The width of screen : {width} px");
        Console.WriteLine($"The height of screen : {height} px");
        Console.WriteLine($"The resolution : {resolution}");
    }
}