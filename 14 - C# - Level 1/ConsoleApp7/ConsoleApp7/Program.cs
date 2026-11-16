using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string S1 = "Saddam Al-zekri";

            Console.WriteLine(S1.Length);
            Console.WriteLine(S1.Substring(3, 10));
            Console.WriteLine(S1.ToUpper());
            Console.WriteLine(S1.ToLower());
            Console.WriteLine(S1[2]);
            Console.WriteLine(S1.Insert(3, "###"));
            Console.WriteLine(S1.Replace("S", "*"));
            Console.WriteLine(S1.IndexOf("e")); // get index Of "e"
            Console.WriteLine(S1.Contains("e")); // True
            Console.WriteLine(S1.Contains("f")); // false
            Console.WriteLine(S1.LastIndexOf("m")); // false

            //////////////////////////////////////////

            string S2 = "Saddam,Hussein,Al-zekri";
            string[] NameList = S2.Split(',');

            Console.WriteLine(NameList[0]);
            Console.WriteLine(NameList[1]);
            Console.WriteLine(NameList[2]);
            //////////////////////////////////////////

            string S3 = "  Abu-Hadhoud  ";
            Console.WriteLine(S3.Trim());
            Console.WriteLine(S3.TrimStart());
            Console.WriteLine(S3.TrimEnd());

            //string interpolation

            string firstName = "Mohammed";
            string lastName = "Abu-Hadhoud";
            string code = "107";

            //You shold use $ to $ to identify an interpolated string 
            string fullName = $"Mr. {firstName} {lastName}, Code: {code}";

            Console.WriteLine(fullName);

            Console.ReadKey();
        }
    }
}

/*
 * Length
 * SubString
 * Replace
 * Insert
 * String[]
 * IndexOf
 * Contains
 * LastIndexOf
 * Trim
 * TrimStart
 * TrimEnd
 * StringName.Split
   
 And So on
 */


/*
 * there are two types for type casting
 * 1.implicit casting
 * 2.explicit casting
 */