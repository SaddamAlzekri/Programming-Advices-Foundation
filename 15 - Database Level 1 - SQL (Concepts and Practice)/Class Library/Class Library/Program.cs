using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyfirstClassLibrary;

namespace Class_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            clsMyMath clsMath = new clsMyMath();

            Console.WriteLine("The Result : " + clsMath.Sum(12, 13));

            Console.ReadKey();
        }
    }
}
