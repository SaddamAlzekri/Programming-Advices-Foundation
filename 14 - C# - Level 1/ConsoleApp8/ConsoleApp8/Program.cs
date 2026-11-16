using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Automatic Implicit Casting

            int Myint = 17;
            double myDouble = Myint;

            Console.WriteLine(Myint);
            Console.WriteLine(myDouble);

            // Automatic Explicit Casting

            double MyDouble = 177.58;

            int Myint2 = (int) MyDouble;

            Console.WriteLine(Myint2);

            // Conversation Methods

            int Myint3 = 20;
            double MyDouble2 = 14.59;
            bool Mybool = true;

            Console.WriteLine(Convert.ToDouble(Myint3));
            Console.WriteLine(Convert.ToString(Myint3));
            Console.WriteLine(Convert.ToDouble(Myint3));
            Console.WriteLine(Convert.ToString(Mybool));



            Console.ReadKey();
        }
    }
}
