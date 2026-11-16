using System;
using System.Threading.Tasks;

class program
{
    static void Main()
    {
        Parallel.Invoke(Methode1, Methode2);

        Console.ReadKey();
    }

    static void Methode1()
    {
        Console.WriteLine($"Methode1 is started");
        Task.Delay(1000);
        Console.WriteLine($"Methode1 is finished");
    }

    static void Methode2()
    {
        Console.WriteLine($"Methode2 is started");
        Task.Delay(1000);
        Console.WriteLine($"Methode2 is finished");
    }

}