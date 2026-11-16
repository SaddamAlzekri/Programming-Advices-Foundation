using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class clsA
    {
        public int x1 = 10;
        private int x2 = 10;
        protected int x3 = 10;

        public int Func1()
        {
            return 200;
        }

        private int Func2()
        {
            return 300;
        }

        protected int Func3()
        {
            return 400;
        }

    }

    class clsB : clsA
    {
        public int Func4()
        {
            return x1 + x3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            clsB B = new clsB();

            Console.WriteLine("All public memers are accessable");
            Console.WriteLine("x1 = {0}", B.x1);
            Console.WriteLine("Result of Func1 = {0}", B.Func4());
            Console.WriteLine("Result of Func4 = {0}", B.Func4());

            Console.ReadKey();

        }
    }
}
