using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    public class clsA
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Method1()
        {
            Console.WriteLine("Method1 of class A");
            clsB objB = new clsB();
            objB.Method2();
        }
    }

    public class clsB
    {
        public decimal Salary { get; set; }
     
        public void Method2()
        {
            Console.WriteLine("Method2 of class B");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            clsA objA = new clsA();
            objA.Method1();

            Console.ReadKey();
        }
    }
}
