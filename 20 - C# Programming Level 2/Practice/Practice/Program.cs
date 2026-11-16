using System;
using System.Threading;
using System.Threading.Tasks;

class program
{
    static private int Increment_Number = 0;
    static object lockCounter = new object();

    static async Task Main()
    {
        Thread task = new Thread(IncrementCounter);
        task.Start();

        task.Join();

        Console.WriteLine($"Don!!!");
        Console.WriteLine();
        Console.ReadKey();
    }

    static void IncrementCounter()
    {
        for (int i = 0; i <= 10; i++)
        {
            lock (lockCounter)
            {
                Increment_Number++;
            }
        }
        Console.WriteLine($"Counter is {Increment_Number}");
    }

}
