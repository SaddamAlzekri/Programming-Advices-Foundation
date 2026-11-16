using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Level_inheritance
{
    public class clsPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void introduce()
        {
            Console.WriteLine("Hi, My name is {0} and I'm {1} Years old", Name, Age);
        }
    }

    public class clsEmployee : clsPerson
    {
        public int EmployeeId { get; set; }
        public decimal Salary { get; set; }

        public void Work()
        {
            Console.WriteLine("Employee with ID {0} and Salary {1:c} is working", EmployeeId, Salary);
        }
    }

    public class clsUser : clsPerson
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Permission { get; set; }

        public void Info()
        {
            Console.WriteLine("User {0} and PassWord {1}", UserName, Password);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            clsEmployee Employee = new clsEmployee();

            Employee.Name = "Saddam Al-zekri";
            Employee.Age = 25;
            Employee.EmployeeId = 001; 
            Employee.Salary = 5500;
            Console.WriteLine("Employee : \n");
            Employee.introduce();
            Employee.Work();

            clsUser User = new clsUser();

            User.Name = "Saddam Al-zekri";
            User.Age = 25;
            User.UserName = "User1";
            User.Password = "1234";
            Console.WriteLine("\nUser : \n");
            User.introduce();
            User.Info();



            Console.ReadKey();
        }
    }
}
