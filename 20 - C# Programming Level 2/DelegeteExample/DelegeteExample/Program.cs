using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegeteExample
{
    class Program
    {
        public delegate void WriteAction(string MyName);

        public static void Methode1(string MyName)
        {
            Console.WriteLine(MyName);
        }

        public static void Methode2(string MyName)
        {
            string fileName = "MyFile.txt";

            using (StreamWriter writter = new StreamWriter(fileName, true))
            {
                writter.WriteLine(MyName);
            }
        }
        static void Main(string[] args)
        {

            WriteAction WriteAction1 = Methode1;

            WriteAction1 += Methode2;

            WriteAction1("Saddam alzekri.");

            WriteAction1 -= Methode2;

            WriteAction1("AbdulRahman alzekri.");

            Console.ReadKey();
        }
    }

}
