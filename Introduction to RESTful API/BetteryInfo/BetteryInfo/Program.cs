using System;
using System.Runtime.InteropServices;

class Program
{
    // Struct يحتوي معلومات البطارية
    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_POWER_STATUS
    {
        public byte ACLineStatus;       // هل الشاحن موصول؟
        public byte BatteryFlag;        // حالة البطارية
        public byte BatteryLifePercent; // نسبة الشحن
        public byte Reserved1;
        public int BatteryLifeTime;     // الوقت المتبقي بالثواني
        public int BatteryFullLifeTime; // العمر الكامل للبطارية
    }

    // استدعاء Win32 API
    [DllImport("kernel32.dll")]
    static extern bool GetSystemPowerStatus(
        out SYSTEM_POWER_STATUS lpSystemPowerStatus);

    static void Main()
    {
        SYSTEM_POWER_STATUS status;

        bool result = GetSystemPowerStatus(out status);

        if (result)
        {
            Console.WriteLine("===== Battery Information =====");

            // حالة الشاحن
            switch (status.ACLineStatus)
            {
                case 0:
                    Console.WriteLine("Charger: Not Connected");
                    break;

                case 1:
                    Console.WriteLine("Charger: Connected");
                    break;

                default:
                    Console.WriteLine("Charger: Unknown");
                    break;
            }

            // نسبة البطارية
            Console.WriteLine($"Battery Percent: {status.BatteryLifePercent}%");

            // الوقت المتبقي
            if (status.BatteryLifeTime != -1)
            {
                int minutes = status.BatteryLifeTime / 60;
                Console.WriteLine($"Remaining Time: {minutes} Minutes");
            }
            else
            {
                Console.WriteLine("Remaining Time: Unknown");
            }
        }
        else
        {
            Console.WriteLine("Failed to get battery information.");
        }
    }
}