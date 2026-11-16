using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyfirstClassLibrary;

namespace Class_Library2
{
    class Program
    {
        static void Main(string[] args)
        {
            clsMyMath clsMath = new clsMyMath();

            Console.WriteLine("The Result : " + clsMath.Multi(12, 4));

            Console.ReadKey();
        }
    }
}
