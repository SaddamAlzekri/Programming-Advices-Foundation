using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    public abstract class clsPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void introduce();

        public void SayGood()
        {
            Console.WriteLine("Hi, GoodBye");
        }
    }

    public class clsEmployee : clsPerson
    {
        public int EmployeeId { get; set; }

        public override void introduce()
        {
            Console.WriteLine("Hi, My name is {0} {1}, and EmployeeId {2}.", FirstName, LastName, EmployeeId);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            clsEmployee Employee = new clsEmployee();

            Employee.FirstName = "Saddam";
            Employee.LastName = "Alzekri";
            Employee.EmployeeId = 123;
            Employee.introduce();
            Employee.SayGood();

            Console.ReadKey();
        }
    }
}
