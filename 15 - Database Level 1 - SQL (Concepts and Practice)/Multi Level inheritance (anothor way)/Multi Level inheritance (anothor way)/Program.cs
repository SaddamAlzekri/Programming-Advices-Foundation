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

    public class clsDoctor : clsEmployee
    {
        public string Specialty { get; set; }

        public void Heal()
        {
            Console.WriteLine("Doctor {0} with ID {1}, salary {2:c} and specialty {3}", Name, EmployeeId, Salary, Specialty);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            clsDoctor Doctor = new clsDoctor();

            Doctor.Name = "Saddam";           
            Doctor.Age = 25;
            Doctor.EmployeeId = 1;
            Doctor.Salary = 10000;
            Doctor.Specialty = "Dintist";

            Doctor.introduce();
            Doctor.Work();
            Doctor.Heal();

            Console.ReadKey();
        }
    }
}
