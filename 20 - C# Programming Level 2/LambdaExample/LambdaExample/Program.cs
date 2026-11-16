using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExample
{
    class Program
    {
        // Program '1'
        static Func<int, int> Square = x => x * x;

        // Program '2'
        static Action ActionWithoutParameter = () =>
        {
            Console.WriteLine("This is Methode Without Parameter.");
        };

        static Action<int> ActionWithoutOneParameter = (x) =>
        {
            Console.WriteLine("The Square of Number is : " + x * x);
        };

        static void ActionWithoutOneParameter2(int y)
        {
            Console.WriteLine("The Square of Number2 is : " + y * y);
        }
     
        static void Main(string[] args)
        {
            // Program '1'
            int Result = Square(5);
            Console.WriteLine( "The square of 5 is" + Result);

            ActionWithoutOneParameter += ActionWithoutOneParameter2;

            // Program '2'
            ActionWithoutParameter();
            ActionWithoutOneParameter(4);

            
            Console.ReadKey();
        }
    }
}
