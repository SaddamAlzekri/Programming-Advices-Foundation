using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    static class clsSettings
    {
        public static int DayNumber
        {
            get
            {
                return DateTime.Today.Day;
            }
        }

        public static string DayName
        {
            get
            {
                return DateTime.Today.DayOfWeek.ToString();
            }
        }

        public static string ProjectPath
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The Number Of Day = {0}", clsSettings.DayNumber);
            Console.WriteLine("The name Of Day = {0}", clsSettings.DayName);
            clsSettings.ProjectPath = @"C://ProjectFile";
            Console.WriteLine("Project File", clsSettings.ProjectPath);

            Console.ReadLine();
        }
    }
}
