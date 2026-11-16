using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace hashingExample
{
    class Program
    {
        static string ComputeHashing(string input)
        {
            using(SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }
        
        static void Main(string[] args)
        {
            string Name = "Saddam Alzekri";

            string hashString = ComputeHashing(Name);

            Console.WriteLine("Origenal string : " + Name);
            Console.WriteLine("Hashing string : " + hashString);

            Console.ReadKey();
        }
    }
}
