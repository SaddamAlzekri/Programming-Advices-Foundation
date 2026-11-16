using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegate
{
    class Program
    {
        Action ActionMessage = Methode1;
        Action<int, int> MultiDelegate = Methode2;

        public static void Methode1()
        {
            Console.WriteLine("Hello, World");
        }

        public static void Methode2(int Num1, int Num2)
        {
            int Result = Num1 * Num2;

            Console.WriteLine(Num1 + " * " + Num2 +" = "+ Result);
        }

        static void Main(string[] args)
        {
            Methode1();
            Methode2(2, 2);

            Console.ReadKey();
        }
    }
}
