using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class clsA
    {
        public virtual void Print()
        {
            Console.WriteLine("Hi, I am the print methode from the base class A");
        }

        public virtual void Print2()
        {
            Console.WriteLine("Hi, I am the print methode from the base class A2");
        }
    }
    class clsB : clsA
    {
        public override void Print()
        {
            Console.WriteLine("Hi, I am the print methode from the derived class B");
        }

        public new void Print2()
        {
            Console.WriteLine("Hi, I am the print methode from the base class B2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            clsA objA = new clsA();
            objA.Print();
            objA.Print2();


            clsB objB = new clsB();
            objB.Print();
            objB.Print2();


            clsA objAA = objB;
            objAA.Print();
            objAA.Print2();

            Console.ReadKey();

        }
    }
}
