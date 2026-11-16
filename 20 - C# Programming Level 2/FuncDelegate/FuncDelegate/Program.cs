using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDelegate
{
    class Program
    {
        static Func<int, int> square = MultiNumbers;

        public static int MultiNumbers(int Number)
        {
            return Number * Number;
        }
        
        static void Main(string[] args)
        {

            int Result = square(5);

            Console.WriteLine("The Result : " + Result);

            Console.ReadKey();
        }
    }
}
