using System;
using System.Threading.Tasks;

class program
{
    static List<string> List = new List<string>
    {
        "Saddam Hussein",
        "Ali Saeed",
        "Saleh Rajeh"
    };

    static void Main()
    {
        Parallel.ForEach(List, list =>
        {
            Console.WriteLine(list);
        });

        Console.WriteLine("\n\n\n");
        Parallel.ForEach(List, listPrint);
        Console.ReadKey();
    }

    static void listPrint(string str)
    {
        Console.WriteLine(str); 
    }
}


