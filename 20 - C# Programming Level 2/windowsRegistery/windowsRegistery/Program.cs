using System;
using Microsoft.Win32;

public class Program
{
    static bool WriteInWindowsRegistry(string message)
    {
        string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD\Login";
        try
        {
            Registry.SetValue(KeyPath, "Practice", message, RegistryValueKind.String);
        }
        catch (Exception ex)
        {
            return false;
        }
        return true;
    }

    static string ReadInWindowsRegistry()
    {
        string Message = "";
        string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD\Login";
        try
        {
            Message = Registry.GetValue(KeyPath, "Practice", null) as string;
        }
        catch (Exception ex)
        {
            return "";
        }
        return Message;
    }

    public static void Main()
    {
        string Message = "I am Saddam Alzekri. I'm 25. I from Yemen.";

        WriteInWindowsRegistry(Message);

        Console.WriteLine($"{ReadInWindowsRegistry()}");

        Console.ReadKey();
    }
}