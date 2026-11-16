using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateConstructorVSStaticClass
{
    static class Settings
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

        //private Settings()
        //{

        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
           //By two ways,I can cancel Object of class
           // Settings setting = new Settings();

            Settings.ProjectPath = @"C://ProjectFile";

            Console.WriteLine("DayNumber = {0}", Settings.DayNumber);
            Console.WriteLine("DayName = {0}", Settings.DayName);
            Console.WriteLine("ProjectPath = {0}", Settings.ProjectPath);

            Console.ReadLine();
        }
    }
}
