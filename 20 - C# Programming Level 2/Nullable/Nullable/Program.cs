using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> hotDegree1 = null;

            int? hotDegree2 = null;

            if(hotDegree1.HasValue)
            {
                Console.WriteLine("HotDegree1 has a value : " + hotDegree1.Value);
            }
            else
            {
                Console.WriteLine("HotDegree1 has not a value.");
            }

            int result = hotDegree2 ?? 0;
            Console.WriteLine("The result is : " + result);

            string str = hotDegree2 ?.ToString();
            Console.WriteLine("The result is : " + (str ?? "null"));

            Console.ReadKey();

        }
    }
}
