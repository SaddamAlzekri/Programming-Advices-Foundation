using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Saddam";

            switch(Name)
            {
                case "Saddam":
                    Console.WriteLine("Yes Saddam");
                    break;

                case "Ali":
                    Console.WriteLine("Yes Ali");
                    break;
                default:
                    Console.WriteLine("No name Matches!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
