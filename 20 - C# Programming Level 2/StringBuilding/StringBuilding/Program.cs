using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilding
{
    class Program
    {
        static public string result = "";

        static void ConcatinateStrings(int iteration)
        {
            for (int i = 0; i < iteration; i++)
            {
                result += "a";
            }
        }

        static void ConcatinateStringBuildings(int iteration)
        {
            result = "";
            StringBuilder str =new StringBuilder();
            for (int i = 0; i < iteration; i++)
            {
                str.Append("a");
               // result = str.ToString();
            }
        }

        static void Main(string[] args)
        {
            Stopwatch Stopwatch1 = new Stopwatch();
            Stopwatch1.Start();
            ConcatinateStrings(200000);
            Stopwatch1.Stop();
            Console.WriteLine("The Time for run \'ConcatinateStrings\' methode : " + Stopwatch1.ElapsedMilliseconds);

            Stopwatch Stopwatch2 = Stopwatch.StartNew();
            ConcatinateStringBuildings(200000);
            Stopwatch1.Stop();
            Console.WriteLine("The Time for run \'ConcatinateStringBuilder\' methode : " + Stopwatch2.ElapsedMilliseconds);


            Console.ReadKey();
        }
    }
}
