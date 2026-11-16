using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerExample
{

    public class Logger
    {
        public delegate void LogAction(string message);
        public LogAction _LogAction;

        public Logger(LogAction action)
        {
            _LogAction = action;
        }

        public void ChanngeMethode(LogAction action)
        {
            this._LogAction += action;
        }
        public void Log(string message)
        {
            _LogAction(message);
        }

    }
    class Program
    {
        public static void LogToScreen(string message)
        {
            Console.WriteLine(message);
        }

        public static void LogToFile(string message)
        {
            string fileName = @"Log.txt";

            using (StreamWriter Writer = new StreamWriter(fileName, true))
            {
                Writer.WriteLine(message);
            }
        }

        static void Main(string[] args)
        {
            Logger FileLogger = new Logger(LogToFile);
            Logger ScreenLogger = new Logger(LogToScreen);
            

            ScreenLogger.Log("Hello, World By Screen");
            FileLogger.Log("Hello, Wold By File");

            FileLogger.ChanngeMethode(LogToScreen);
            FileLogger.Log("The message will be display on the screen");

            Console.ReadKey();
        }
    }
}
