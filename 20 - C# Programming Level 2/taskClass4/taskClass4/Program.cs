using System;
using System.Threading.Tasks;

class program
{
    static async Task Main()
    {
        Console.WriteLine("Tasks started...");

        Task<int> task1 = SumOperation(12, 8);
        Console.WriteLine("Tasks task1");

        Task<int> task2 = SumOperation(12, 10);
        Console.WriteLine("Tasks task2");

        int result1 = await task1;
        int result2 = await task2;

        Console.WriteLine($"the result1 : {result1}\nthe result2 : {result2}");

        Console.ReadKey();
    }

    static async Task<int> SumOperation(int num1, int num2)
    {
        await Task.Delay(1000);

        return num1 + num2;
    }
}