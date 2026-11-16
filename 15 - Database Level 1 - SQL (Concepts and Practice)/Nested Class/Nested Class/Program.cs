using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Class
{
    public class OuterClass
    {
        public int OuterVariable { get; set; }

        public OuterClass(int OuterVariable)
        {
            this.OuterVariable = OuterVariable;
        }

        public void OuterMethod(int OuterVariable)
        {
            Console.WriteLine("Outer Method called with outervariable = " + OuterVariable);
        }
        public class InnerClass
        {
            public int InnerVariable { get; set; }

            public InnerClass(int InnerVariable)
            {
                this.InnerVariable = InnerVariable;
            }

            public void InnerMethod(int InnerVariable)
            {
                Console.WriteLine("Inner Method called with innervariable = " + InnerVariable);
            }

            public void AccessOuterVariable(OuterClass Outer)
            {
                Console.WriteLine("Accessing outervariable from inner class: " + Outer.OuterVariable);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OuterClass Outer = new OuterClass(45);

            OuterClass.InnerClass Inner = new OuterClass.InnerClass(54);

            Inner.AccessOuterVariable(Outer);
            Inner.InnerMethod(Inner.InnerVariable);
            Outer.OuterMethod(Outer.OuterVariable);

            Console.ReadKey();
        }
    }
}
