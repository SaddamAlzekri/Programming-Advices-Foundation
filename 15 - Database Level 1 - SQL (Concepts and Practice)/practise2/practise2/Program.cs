using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise2
{
    class Program
    {
        public static void PrintMyInfo(string Name = "Ali", int Age = 15)
        {
            Console.WriteLine("Hi, I am {0} and I am {1}", Name, Age);
        }
        static string GetMyName()
        {
            return "Saddam Al-zekri";
        }
        static int Sum(int Num1, int Num2, int Num3 = 5)
        {
            return Num1 + Num2 + Num3;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(rnd.Next(10, 20));
            }

                //try
                //{
                //    int[] NumList = { 1, 2, 3, 4 };
                //    Console.WriteLine(NumList[10]);
                //}catch(Exception e)
                //{
                //    Console.WriteLine(e.Message.ToString());
                //}

                //Console.WriteLine(GetMyName());
                //Console.WriteLine(Sum(12, 3));

                Console.ReadKey();
        }
    }
}
