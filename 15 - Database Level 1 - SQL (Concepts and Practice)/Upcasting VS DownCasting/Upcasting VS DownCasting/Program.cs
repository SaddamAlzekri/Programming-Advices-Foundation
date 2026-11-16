using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_VS_DownCasting
{
    public class clsPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Great()
        {
            Console.WriteLine("Hi, My name is {0}, and I am {1} years old.", Name, Age);
        }
    }

    public class clsEmployee : clsPerson
    {
        public float Salary { get; set; }
        public string Company { get; set; }

        public void work()
        {
            Console.WriteLine("I work at {0} and Earn {1:c} per Year.", Company, Salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Upcasting
            clsEmployee Employee = new clsEmployee { Name = "Saddam", Age = 25,Salary = 3000, Company = "ItLagend" };
            clsPerson Person1 = Employee;
            Person1.Great();


            //DownCasting
            clsPerson Person2 = new clsEmployee { Name = "Saddam", Age = 25,Salary = 3000, Company = "ItLagend" };
            clsEmployee Employee2 = (clsEmployee)Person2;
            Employee2.work();

            Console.ReadKey();
        }
    }
}
