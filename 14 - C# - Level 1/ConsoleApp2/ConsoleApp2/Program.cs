using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

           // default value 01/01/0001 00:00:00  
            DateTime dt1 = new DateTime();

            DateTime dt2 = new DateTime(2025, 4, 23);

            DateTime dt3 = new DateTime(2025, 4, 23, 9, 05, 40);

            DateTime dt4 = new DateTime(2025, 4, 23, 9, 05, 40, DateTimeKind.Utc);

            // Get Date now
            DateTime dt5 = new DateTime();
            dt5 = DateTime.Now;

            // return Date now
            DateTime CuurentDate = DateTime.Now;

            //return Date today
            DateTime DateToday = DateTime.Today;

            // return UtcDate
            DateTime UtcDate = DateTime.UtcNow;

            // return MinDate
            DateTime MinDate = DateTime.MinValue;

            //return MaxDate
            DateTime MaxDate = DateTime.MaxValue;


            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(dt4);

            Console.WriteLine("Date now :\n" + dt5);
            Console.WriteLine(DateTime.MinValue.Ticks);
            Console.WriteLine(DateTime.MaxValue.Ticks);

            Console.WriteLine("\n\nCuurentDate : " + CuurentDate);
            Console.WriteLine("DateToday   : " + DateToday);
            Console.WriteLine("UtcDate     : " + UtcDate);
            Console.WriteLine("MinDate     : " + MinDate);
            Console.WriteLine("MaxDate     : " + MaxDate);


            Console.ReadKey();
        }
    }
}
