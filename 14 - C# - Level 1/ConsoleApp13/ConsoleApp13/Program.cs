using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static string printMyName()
        {
            Console.WriteLine("Enter your Name :");

            string myName = Console.ReadLine();

            return myName;
        }

        static byte GetAge()
       {
           Console.WriteLine("Enter your Age :");
           byte Age = Convert.ToByte(Console.ReadLine());
           return Age;
       }

        static void printMyInfo(string Name = "Saddam Al-zekri", byte Age = 25)
        {
            Console.WriteLine("My name is {0}. I am {1}", Name, Age);
        }

        static void myMethod(string Child1, string Child2, string Child3)
        {
            Console.WriteLine("Child1 : {0}, Child2 : {1},Child3 : {2}", Child1, Child2, Child3);
        }

        static int Sum(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        static int Sum(int Num1, int Num2, int Num3)
        {
            return Num1 + Num2 + Num3;
        }

        static void Main(string[] args)
        {
            string myName = printMyName();
            byte Age = GetAge();

            //input value
            printMyInfo(myName, Age);

            //By defaolt value
            printMyInfo();

            //Named Argements
            myMethod(Child2: "Ali", Child1: "Samira", Child3: "Saleh");

            //OverLoading

            Console.WriteLine("The Reuslt of Sum = " + Sum(Num1: 10, Num2: 20, Num3: 30));
            Console.WriteLine("The Reuslt of Sum = " + Sum(Num1: 10, Num2: 30));

            Console.ReadKey();
        }
    }
}
