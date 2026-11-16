using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class clsPerson
    {
        public string FirstName;
        public string LastName;

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            clsPerson Person1 = new clsPerson();

            Console.WriteLine("Accessing Object 1 (Person1)");
            Person1.FirstName = "Saddam";
            Person1.LastName = "Al-zekri";
            Console.WriteLine(Person1.FullName());

            clsPerson Person2 = new clsPerson();

            Console.WriteLine("\n\nAccessing Object 2 (Person2)");
            Person2.FirstName = "Ali";
            Person2.LastName = "Al-Magrami";
            Console.WriteLine(Person2.FullName());

            Console.ReadKey();
        }
    }
}
