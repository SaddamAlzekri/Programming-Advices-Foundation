using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExampl3
{
    class Program
    {
        delegate int BasicOperatios(int Num1, int Num2);

        static void SumOperation(int Num1, int Num2,BasicOperatios SumOper)
        {
            int result = SumOper(Num1, Num2);
            Console.WriteLine("The result is : " + result);
        }

        public static int SumOp(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        public static int SubOp(int Num1, int Num2)
        {
            return Num1 - Num2;
        }

        static void Main(string[] args)
        {

            BasicOperatios Add = SumOp;
            BasicOperatios Sub = SubOp;

            SumOperation(10, 2, Add);
            SumOperation(10, 2, Sub);

            Console.ReadKey();
        }
    }
}
