using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExample2
{

    public class PersonInfo
    {
        public string FullName { set; get; }
        public string Phone { set; get; }
        public double Rate { set; get; }

        public PersonInfo(string FullName, string Phone, double Rate)
        {
            this.FullName = FullName;
            this.Phone = Phone;
            this.Rate = Rate;
        }
    }
    class Program
    {
        //static Action<string, double> MyNameAndRate = (Name, Rate) =>
        //    {
        //        Console.WriteLine("My Name is " + Name + " and " + Rate.ToString());
        //    };

        static Action<string, string, double> PersonInfor = (FullName, Phone, Rate) =>
            {
                PersonInformation(new PersonInfo(FullName, Phone, Rate));
                InformationOfPerson(new PersonInfo(FullName, Phone, Rate));
            };

        public static void PersonInformation(PersonInfo Info)
        {
            Console.WriteLine("FullName : " + Info.FullName);
            Console.WriteLine("Phone : " + Info.Phone);
            Console.WriteLine("Rate : " + Info.Rate);
        }

        public static void InformationOfPerson(PersonInfo Info)
        {
            Console.WriteLine("\n----------------------------------------------");
            Console.WriteLine("My Name : " + Info.FullName);
            Console.WriteLine(" My Phone : " + Info.Phone);
            Console.WriteLine("My Rate : " + Info.Rate);
            Console.WriteLine("----------------------------------------------");
        }

        static void Main(string[] args)
        {
           // MyNameAndRate("Saddam Hussein Al-zekri", 99.23);

            PersonInfor("saddam Alzekri", "+697 712126932", 90.38);

            Console.ReadKey();
        }
    }
}
