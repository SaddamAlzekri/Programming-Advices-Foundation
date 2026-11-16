using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine((20 & 6));

            //////////////////////////////////////
            int Number1 = 0;
            Number1 = Convert.ToInt32(Console.ReadLine());

            string result1 = ((Number1 % 2 )== 0) ? "Even Number" : "Odd Number";

            Console.WriteLine("{0} is {1}", Number1, result1);

            ////////////////////////////////
            int Number = 10, result = 0;
            bool Flag = true;

            result = +Number;
            Console.WriteLine("+Number : " + result);

            result = -Number;
            Console.WriteLine("-Number : " + result);

            result = ++Number;
            Console.WriteLine("-Number : " + result);

            result = --Number;
            Console.WriteLine("-Number : " + result);

            Console.WriteLine("!Flage : " + (!Flag));

            Console.WriteLine((Number++));
            Console.WriteLine((Number));
            Console.WriteLine((++Number));
            Console.WriteLine((Number));

            ////////////////////////////////////////
            Console.WriteLine("Enter Your Age.");

            int Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your Age is : " + Age);

            // Arithmatic Operation

            Console.WriteLine("\n\nArithmatic Operation");

            int Sum = 0, Num1, Num2;

            Console.WriteLine("Enter Number1 : ");
            Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number2 : ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            Sum = Num1 + Num2;
            Console.WriteLine("The Result is : " + Sum);

            Sum = Num1 * Num2;
            Console.WriteLine("The Result is : " + Sum);

            Sum = Num1 - Num2;
            Console.WriteLine("The Result is : " + Sum);

            Sum = Num1 / Num2;
            Console.WriteLine("The Result is : " + Sum);

            // Relational Operator

            Console.WriteLine(Num1 == Num2);

            if (Num1 >= Num2)
                Console.WriteLine(Num1);
            else
                Console.WriteLine(Num2);
            

            Console.ReadKey();
        }
    }
}
