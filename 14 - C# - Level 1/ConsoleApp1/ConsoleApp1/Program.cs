using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        enum WeekEnd
        {
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednsday = 4,
            Thursday = 5,
            Friday = 6,
            Saterday = 7
        }

     struct stStudent
     {
         public string FirstName;
         public string LastName;
     }

        static void Main(string[] args)
        {
            stStudent Student1;
            stStudent student2 = new stStudent();

            Student1.FirstName = "Saddam";
            student2.FirstName = "AbdoRahman";

            Console.WriteLine(Student1.FirstName);
            Console.WriteLine(student2.FirstName);

            byte x = 1;
            if (WeekEnd.Sunday == (WeekEnd)x)
                Console.WriteLine("Sunday");

            var Student = new { Id = 20, FirstName = "Saddam", LastName = "Al-zekri" };

            Console.WriteLine(Student.Id);

            Console.WriteLine(default(float));

            dynamic MyDynamicVar = 100;

            Console.WriteLine(MyDynamicVar);

            MyDynamicVar = "Saddam";
            Console.WriteLine(MyDynamicVar);

            var Myvar = 100;
            Console.WriteLine(Myvar);

            var Myvar2 = "Saddam";
            Console.WriteLine(Myvar2);

            Console.ReadLine();
        }
    }
}