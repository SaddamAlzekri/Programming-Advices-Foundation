using System;
using System.Threading.Tasks;

class proram
{
    static async Task Main()
    {
        Task<int> resultTask = performAsyncOperation();

        int result = await resultTask;

        Console.WriteLine("Done...");
        Console.WriteLine(result);
        
        Console.ReadKey();
    }

    static async Task<int> performAsyncOperation()
    {
        await Task.Delay(3000);

        return 42;
    }
}