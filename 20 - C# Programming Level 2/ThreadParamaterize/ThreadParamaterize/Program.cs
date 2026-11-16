using System;
using System.Threading;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadParamaterize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Threads...");

            Thread t1 = new Thread(() => DownloadAndPrint("https://www.cnn.com"));
            t1.Start();
            Console.WriteLine("Thread 1 started");


            Thread t2 = new Thread(() => DownloadAndPrint("https://www.amazon.com"));
            t2.Start();
            Console.WriteLine("Thread 2 started");


            Thread t3 = new Thread(() => DownloadAndPrint("https://www.ProgrammingAdvices.com"));
            t3.Start();
            Console.WriteLine("Thread 3 started");

            Console.ReadKey();
        }
        static void DownloadAndPrint(string URL)
        {
            string Content = null;
            using (WebClient client = new WebClient())
            {
                Content = client.DownloadString(URL);
            }
            Console.WriteLine(URL + "  " + Content.Length + "character downloaded");
        }
    }
}
