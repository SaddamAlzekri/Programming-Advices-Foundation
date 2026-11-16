using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rdm = new Random();

            for(int i = 0; i <= 10;i++)
            {
                Console.Write(rdm.Next(1, 10) + "  ");
            }
            Console.ReadKey();
        }
    }
}
