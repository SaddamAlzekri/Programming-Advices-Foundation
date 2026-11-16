using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_program
{
    public interface Iperson
    {
        string Name { get; set; }
        int Age { get; set; }
        void interduce();
        void Print();
    }

    public interface ICommunicate
    {
        void CallPhone();
        void SmsEmail();
        void SendSms();
        void SendFax();
    }

    public abstract class clsPerson : Iperson, ICommunicate
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void interduce()
        {
            Console.WriteLine("Hi, I'm {0} and I am {1}", Name, Age);
        }

        public void Print()
        {
            Console.WriteLine("GoodBye");
        }

        public void CallPhone()
        {
            Console.WriteLine("Hi, Calling phone...");
        }

        public void SmsEmail()
        {
            Console.WriteLine("Email Send...");
        }

        public void SendSms()
        {
            Console.WriteLine("SMS Send...");
        }

        public void SendFax()
        {
            Console.WriteLine("fax Send...");
        }
    }

    public class clsEmployee : clsPerson
    {
        public float Salary { get; set; }

        public void Work()
        {
            Console.WriteLine("I am {0} and I'm {1}, My salary is {2}", Name, Age, Salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            clsEmployee Employee = new clsEmployee();

            Employee.Name = "Saddam Alzekri";
            Employee.Age = 25;
            Employee.Salary = 7500;

            Employee.interduce();
            Employee.Print();
            Employee.Work();

            Console.ReadKey();
        }
    }
}
