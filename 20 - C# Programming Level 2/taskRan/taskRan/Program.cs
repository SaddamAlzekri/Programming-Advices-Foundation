using System;
using System.Threading.Tasks;

class program
{
    static async Task Main()
    {
        Task task1 = Task.Run(() => SumOperation(10, 5));
        Task task2 = Task.Run(() => MultiOperation(10, 5));

        await Task.WhenAll(task1, task2);

        Console.WriteLine("Task1 and Task2 completed");
        Console.ReadKey();
    }

    static async Task<int> SumOperation(int Num1, int Num2)
    {
        await Task.Delay(2000);

        return Num1 + Num2;
    }

    static async Task<int> MultiOperation(int Num1, int Num2)
    {
        await Task.Delay(2000);

        return Num1 * Num2;
    }

}