using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterize_Constructor
{
    class clsPerson
    {
        public int _ID { get; set; }
        public string _Name { get; set; }
        public int _Age { get; set; }

        public clsPerson(int ID, string Name, int Age)
        {
            _ID = ID;
            _Name = Name;
            _Age = Age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            clsPerson Person = new clsPerson(1, "Saddam Al-zekri", 25);

            Console.WriteLine("ID : ", Person._ID);
            Console.WriteLine("Name : ", Person._Name);
            Console.WriteLine("Age : ", Person._Age);

        }
    }
}
