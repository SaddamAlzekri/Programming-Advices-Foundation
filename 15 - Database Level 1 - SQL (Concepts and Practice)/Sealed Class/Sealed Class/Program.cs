using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class
{
    public sealed class clsA
    {
        public string xxxxxx { get; set; }
        public int yyyyyyy { get; set; }
    }

    public class clsB 
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Method1()
        {
            Console.WriteLine("Hi, I am {0}, and I am {1}", Name, Age);
        }
    }

    public class clsC : clsB
    {
        public string Salary { get; set; }

        public  override void Method1()
        {
            Console.WriteLine("Hi, I am {0}, and I am {1}", Name, Age);
        }

    }

    public class clsD : clsC
    {
        public decimal DepartMent { get; set; }

        public sealed override void Method1()
        {
            Console.WriteLine("Hi, I am {0}, and I am {1}, and My Salary is {2}", Name, Age, DepartMent);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            clsD objD = new clsD();
            objD.Name = "Saddam Al-zekri";
            objD.Age = 25;
            objD.DepartMent = 7500;
            objD.Method1();

            Console.ReadKey();
        }
    }
}
