using System;
using System.Net;
using System.Threading.Tasks;

class program
{
    static async Task Main()
    {
        Console.WriteLine("Started tasks...");

        Task task1 = downloadAndAsyncPrint("https://www.cnn.com");
        Console.WriteLine("task1 started...");


        Task task2 = downloadAndAsyncPrint("https://www.cnn.com");
        Console.WriteLine("task1 started...");


        Task task3 = downloadAndAsyncPrint("https://www.cnn.com");
        Console.WriteLine("task1 started...");

        await Task.WhenAll(task1, task2, task3);

        Console.WriteLine("Done...");
        Console.ReadKey();
    }

    static async Task downloadAndAsyncPrint(string Url)
    {
        string content = "";
        using (WebClient web = new WebClient())
        {

            await Task.Delay(3000);

            content = await web.DownloadStringTaskAsync(Url);
        }
        Console.WriteLine($"The length is {Url.Length} \n\t\t\tand content of page \n {Url}");
    }
}