using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Permissions
            int Permissions = 31;

            if ((2 & 31) == 2)
                Console.WriteLine("Correct");
            else
                Console.WriteLine("Wrong");

                
            if ((7 & 31) == 2)
                Console.WriteLine("Correct");
            else
                Console.WriteLine("Wrong");

            Console.ReadKey();
        }
    }
}
