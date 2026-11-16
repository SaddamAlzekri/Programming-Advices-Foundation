using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace AtributesInCSharp
{


    class Program
    {
        [Conditional("DEBUG")]
        public static void DebugMethode1()
        {
            Console.WriteLine("This is DebugMethode1");
        }

        public static void NormalMethode1()
        {
            Console.WriteLine("This is NormalMethode1");
        }

        [Conditional("Alzekri")]
        public static void DefineMethode1()
        {
            Console.WriteLine("This is DefineMethode1");
        }
        static void Main(string[] args)
        {
            DebugMethode1();
            NormalMethode1();
            DefineMethode1();

            Console.ReadKey();
        }
    }

}
