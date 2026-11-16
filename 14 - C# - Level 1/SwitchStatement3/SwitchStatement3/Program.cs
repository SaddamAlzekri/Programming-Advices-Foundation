using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement3
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            double FirstNum, SecondNum, Result;

            Console.WriteLine("Enter a operator.");
            ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter a FirstNumber.");
            FirstNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a SecondNumber.");
            SecondNum = Convert.ToDouble(Console.ReadLine());

            switch(ch)
            {
                case '+':
                    Result = FirstNum + SecondNum;
                    Console.WriteLine("The Result : " + Result);
                    break;

                case '-':
                    Result = FirstNum - SecondNum;
                    Console.WriteLine("The Result : " + Result);
                    break;

                case '*':
                    Result = FirstNum * SecondNum;
                    Console.WriteLine("The Result : " + Result);
                    break;

                case '/':
                    if(FirstNum == 0)
                    {
                        Console.WriteLine("Enter another FirstNumber:");
                        FirstNum = Convert.ToDouble(Console.ReadLine());
                    }
                    Result = FirstNum / SecondNum;
                    Console.WriteLine("The Result : " + Result);
                    break;
            }
            Console.ReadKey();
        }
    }
}
