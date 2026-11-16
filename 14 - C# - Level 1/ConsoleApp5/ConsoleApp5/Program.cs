
//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

using System;

namespace Main
    {
        internal class Program
        {

        static void Main(string[] args)
            {
            var str = "16/12/2023";

            DateTime dt;

            bool valideOrNot = DateTime.TryParse(str, out dt);

            if (valideOrNot)
                Console.WriteLine(dt);
            else
                Console.WriteLine("{str}the Date is wrong");                                                                                                                                                                                                                    

            Console.ReadKey();

            }
        }
    }

