using System;
using System.Threading;
using System.Threading.Tasks;

class program
{
    static void Main()
    {
        Parallel.For(0, 10, i =>
        {
            Console.WriteLine($"Circle of {i}");
        });
        Console.WriteLine("\n\n\n");

        Parallel.For(0, 10, Loops);

        Console.ReadKey();
    }
    static void Loops(int i)
    {
        Console.WriteLine($"loop {i}");
    }
}