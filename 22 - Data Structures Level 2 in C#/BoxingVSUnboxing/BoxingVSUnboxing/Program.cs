using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingVSUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int valType = 10;
            object referenceType = valType;

            // boxing
            Console.WriteLine("boxing : " + referenceType);

            int Unboxing = (int)referenceType;
            // unboxing
            Console.WriteLine("Unboxing : " + Unboxing);
            Console.ReadKey();
        }
    }
}
