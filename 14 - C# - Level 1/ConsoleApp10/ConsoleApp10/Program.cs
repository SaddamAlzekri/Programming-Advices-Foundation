using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter FirstName : ");

            string FirstName = Console.ReadLine(); 
            
            Console.WriteLine("Enter LastName : ");

            string LastName = Console.ReadLine();

            string FullName = FirstName + " " + LastName;

            Console.WriteLine(FullName);

            Console.ReadKey();
        }
    }
}
