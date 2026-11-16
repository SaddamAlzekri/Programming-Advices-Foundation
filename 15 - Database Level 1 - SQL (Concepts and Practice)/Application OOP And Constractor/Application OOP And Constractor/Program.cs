using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_OOP_And_Constractor
{
    class clsPerson
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public clsPerson(int ID, string Name, int Age)
        {
            this.ID = ID;
            this.Name = Name;
            this.Age = Age;
        }

        public static clsPerson Find(int ID)
        {
            if (ID == 10)
                return new clsPerson(10, "Saddam Al-zekri", 25);
            else
                return null;
        }

        public static clsPerson Find(string UserName, string PassWord)
        {
            if (UserName == "Saddam Al-zekri" && PassWord == "1234")
                return new clsPerson(10, "Saddam Al-zekri", 25);
            else
                return null;
        }
    }
    class Program
    {
       static void Main(string[] args)
        {
            clsPerson Person1 = clsPerson.Find(10);

            Console.WriteLine("Search about Person by ID");

            if (Person1 != null)
            {
                Console.WriteLine("ID = {0}", Person1.ID);
                Console.WriteLine("Name = {0}", Person1.Name);
                Console.WriteLine("Age = {0}", Person1.Age);
            }
            else
                Console.WriteLine("There isnot this id");

            clsPerson Person2 = clsPerson.Find("Saddam Al-zekri", "1234");

            Console.WriteLine("\n\nSearch about Person by UserName/Password");

            if (Person2 != null)
            {
                Console.WriteLine("ID = {0}", Person2.ID);
                Console.WriteLine("Name = {0}", Person2.Name);
                Console.WriteLine("Age = {0}", Person2.Age);
            }
            else
                Console.WriteLine("There isnot this id");

            Console.ReadKey();
        }
    }
}
