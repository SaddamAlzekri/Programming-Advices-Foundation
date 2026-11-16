using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateDelegate
{
    class Program
    {
        static Predicate<int> ISNumberBiggerThan100 = Methode1;

        public static bool Methode1(int Num)
        {
            return (Num % 2 == 0);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the Number : ");
            int Num = Console.Read();

            bool isBiggerthan100 = ISNumberBiggerThan100(Num);

            if (isBiggerthan100)
            {
                Console.WriteLine("The Number is Even");
            }else
            {
                Console.WriteLine("The Number is odd");
            }

            Console.ReadKey();
        }
    }
}
