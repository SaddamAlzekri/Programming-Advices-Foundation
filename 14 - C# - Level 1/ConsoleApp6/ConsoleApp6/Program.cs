using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "13, 2, 2025";
            DateTime dt;
            bool isValide = DateTime.TryParse(str, out dt);

            if (isValide)
                Console.WriteLine(dt);
            else
                Console.WriteLine("The date is wrong");
            Console.ReadKey();
        }
    }
}
