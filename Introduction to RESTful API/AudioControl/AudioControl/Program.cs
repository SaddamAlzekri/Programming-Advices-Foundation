using System;
using NAudio.CoreAudioApi;

class Program
{
    static void SetVolume(float volumePercent)
    {
        if (volumePercent < 0 || volumePercent > 100)
        {
            Console.WriteLine(
                "Enter volume between 0 and 100");
            return;
        }

        MMDeviceEnumerator enumerator =
            new MMDeviceEnumerator();

        MMDevice device =
            enumerator.GetDefaultAudioEndpoint(
                DataFlow.Render,
                Role.Multimedia);

        // تحويل إلى 0.0 → 1.0
        device.AudioEndpointVolume.MasterVolumeLevelScalar =
            volumePercent / 100.0f;

        Console.WriteLine(
            $"Volume set to {volumePercent}%");
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== Volume Control =====");
            Console.WriteLine("1 - Mute");
            Console.WriteLine("2 - Max Volume");
            Console.WriteLine("3 - Custom Volume");
            Console.WriteLine("4 - Exit");

            Console.Write("\nChoose Option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":

                    SetVolume(0);

                    break;

                case "2":

                    SetVolume(100);

                    break;

                case "3":

                    Console.Write(
                        "Enter volume (0 - 100): ");

                    float percent =
                        Convert.ToSingle(
                            Console.ReadLine());

                    SetVolume(percent);

                    break;

                case "4":

                    return;

                default:

                    Console.WriteLine(
                        "Invalid Option");

                    break;
            }
        }
    }
}