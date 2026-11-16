using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterless_Constructor
{
    class clsPerson
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public clsPerson()
        {
            ID = -1;
            Name = "Saddam Alzekri";
            Age = 25;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            clsPerson Person = new clsPerson();

            Console.WriteLine(Person.ID);
            Console.WriteLine(Person.Name);
            Console.WriteLine(Person.Age);

            Console.ReadLine();
        }
    }
}
