using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threadings
{
    class Program
    {
        static void Methode1()
        {
            for(int i = 0; i< 10; i++)
            {
                Console.WriteLine("Methode1 : " + 1);
            }
        }

        static void Methode2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Methode2 : " + 1);
            }
        }

        static void Main(string[] args)
        {
            Thread thr1 = new Thread(Methode1);
            thr1.Start();

            Thread thr2 = new Thread(Methode2);
            thr2.Start();

            thr1.Join();
            thr2.Join();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main : " + 1);
            }

            Console.ReadKey();
        }
    }
}
