using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculater
{
    class clsCalculater
    {
        public int LastValue = 0;
        public int Result = 0;
        public string OperationType = "Clear";

        private bool _IsZero(int Number)
        {
            return (Number <= 0);
        }

        public void clear()
        {
            LastValue = 0;
            Result = 0;
            OperationType = "Clear";
        }

        public void Add(int AddNumber)
        {
            OperationType = "Add";
            LastValue = AddNumber;
            Result += AddNumber;
        }

        public void Substruct(int Number)
        {
            OperationType = "Substruct";
            LastValue = Number;
            Result -= Number;
        }

        public void Multible(int Number)
        {
            OperationType = "Multible";
            LastValue = Number;
            Result *= Number;
        }
        public void Divide(int Number)
        {
            if (_IsZero(Number))
            {
                OperationType = "Divide";
                LastValue = Number;
                Result /= 1;
            }
            else
            {
                OperationType = "Divide";
                LastValue = Number;
                Result /= Number;
            }
        }

        public void PrintResult()
        {
            Console.WriteLine("Result after {0} {1} is : {2}",OperationType, LastValue, Result);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            clsCalculater Calcu = new clsCalculater();

            Calcu.Add(10); 
            Calcu.PrintResult();
            Calcu.Multible(2); 
            Calcu.PrintResult();
            Calcu.Divide(5); 
            Calcu.PrintResult();
            Calcu.clear();
            Calcu.PrintResult();

            Console.ReadLine();
        }
    }
}
