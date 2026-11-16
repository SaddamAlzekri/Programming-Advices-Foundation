using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            Console.WriteLine(WeekDays.Thursday);
            int day = (int)WeekDays.Saturday;
            Console.WriteLine(day);

            var wd = (WeekDays)4; // int to enum conversion
            Console.WriteLine(wd);//output: Saturday 

            Console.ReadKey();

        }
    }
}
