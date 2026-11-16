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

            int[] myInt = {1, 2, 3, 4};
            int Counter = 0;
            for (int i = 0; i <= myInt.Length; i++)
            {
                Counter = i;
            }
            Console.WriteLine(Counter);

                Console.ReadKey();
        }
    }
}
