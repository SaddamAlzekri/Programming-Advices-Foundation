using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14tryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myInt = new int[5];

                Console.WriteLine("Elements is = " + myInt[10]);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
