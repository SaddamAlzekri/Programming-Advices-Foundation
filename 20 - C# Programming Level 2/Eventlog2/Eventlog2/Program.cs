using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventlog2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceName = "Error3";

            if(!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
            }

            EventLog.WriteEntry(sourceName, "This is error", EventLogEntryType.Error);

            Console.ReadKey();
        }
    }
}



