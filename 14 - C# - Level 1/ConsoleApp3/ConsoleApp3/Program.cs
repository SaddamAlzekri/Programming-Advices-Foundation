using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2025, 01, 01);

            TimeSpan ts = new TimeSpan(49, 25, 32);

            Console.WriteLine(ts);

            Console.WriteLine(ts.Days);
            Console.WriteLine(ts.Hours);
            Console.WriteLine(ts.Minutes);
            Console.WriteLine(ts.Seconds);

            DateTime Datetime = dt.Add(ts);

            Console.WriteLine(Datetime);

            // between two Times

            DateTime start = new DateTime(2025, 4, 22);
            DateTime end = new DateTime(2025, 4, 23);

            TimeSpan result = end.Subtract(start);

            //One day
            Console.WriteLine(result); 

            Console.ReadKey();
        }
    }
}
