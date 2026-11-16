using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        public delegate int MultiActionArgs(int Num);

        public static MultiActionArgs Multi;
        public static int MultiNumbers(int Number)
        {
            return Number * Number;
        }

        static void Main(string[] args)
        {
            //MultiActionArgs Multi = new MultiActionArgs(MultiNumbers);

             Multi += MultiNumbers;

            int Result = Multi(2);

            Console.WriteLine("The Result : " + Result);

            Console.ReadKey();
        }
    }
}
