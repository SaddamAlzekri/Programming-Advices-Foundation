using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Level_inheritance
{
    public class clsPerson
    {
        public clsPerson(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public void introduce()
        {
            Console.WriteLine("Hi, My name is {0} and I'm {1} Years old", Name, Age);
        }
    }

    public class clsEmployee :  clsPerson
    {
        public clsEmployee(string Name, int Age,int EmployeeId, decimal Salary) : base (Name, Age)
        {
            this.EmployeeId = EmployeeId;
            this.Salary = Salary;
        }
        public int EmployeeId { get; set; }
        public decimal Salary { get; set; }

        public void Work()
        {
            Console.WriteLine("Employee with ID {0} and Salary {1:c} is working", EmployeeId, Salary);
        }
    }

    public class clsDoctor : clsEmployee
    {
        public clsDoctor(string Name, int Age, int EmployeeId, decimal Salary,string Specialty)
            : base(Name, Age, EmployeeId, Salary)
        {
            this.EmployeeId = EmployeeId;
            this.Salary = Salary;
        }
        public string Specialty { get; set; }

        public void Heal()
        {
            Console.WriteLine("Doctor {0} with ID {1}, salary {2:c} and specialty {3}",Name, EmployeeId, Salary, Specialty);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            clsDoctor Doctor = new clsDoctor("Saddam l-zekri", 25, 1, 7000, "Dintist");

            Doctor.Heal();
            Doctor.Work();

            Console.ReadKey();
        }
    }
}
