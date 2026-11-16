using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class clsPerson
    {
        public clsPerson(int Id, string FirstName, string LastName, string Title)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Title = Title;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }


        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

    }

    class clsEmployee : clsPerson
    {
        public float Salary { get; set; }
        public string DepartMent { get; set; }

        public clsEmployee(int Id, string FirstName, string LastName, string Title, float Salary, string DepartMent) : base (Id, FirstName, LastName, Title)
        {
            this.Salary = Salary;
            this.DepartMent = DepartMent;
        }
        public void IncreaseSalaryby(float Amount)
        {
            Salary += Amount;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            clsEmployee Employee = new clsEmployee(01, "Saddam", "Al-zekri", "Mr", 5000, "IT");
          //  clsEmployee Employee = new clsEmployee();

            Console.WriteLine("Access object1 for Employee");

            // Anothor way

            //Employee.Id = 10;
            //Employee.Title = "Mr";
            //Employee.FirstName = "Saddam";
            //Employee.LastName ="Al-zekri";
            //Employee.Salary = 5000;
            //Employee.DepartMent = "IT";

            Console.WriteLine("ID : {0}", Employee.Id);
            Console.WriteLine("Title : {0}", Employee.Title);
            Console.WriteLine("FirstName : {0}", Employee.FirstName);
            Console.WriteLine("LastName : {0}", Employee.LastName);
            Console.WriteLine("Salary : {0}", Employee.Salary);
            Console.WriteLine("DepartMent : {0}", Employee.DepartMent);

            Employee.IncreaseSalaryby(100);
            Console.WriteLine("Salary After increase : {0}", Employee.Salary);

            Console.ReadKey();
        }
    }
}