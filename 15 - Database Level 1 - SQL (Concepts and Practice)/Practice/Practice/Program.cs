using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class clsPractice
    {
        //This is method use for practise and revsoinabout c#
        public void Print()
        {
            string Work = "FullStack developer";
            Console.Write("Hi, I am {0}.", "Saddam Al-zekri");
            Console.WriteLine("I am 25. I Work as {0}.", Work);

            Console.WriteLine("\aHi, I \\teach  \bin Taiz \"university \'in Computer \nScience\t department.");
        }

        public void Print2()
        {
            int x = 10, y = 20;
            string Department = "FullStack developer";
            double Num1 = 10.1d;
            float Num2 = 70.2f;
            char ch = 'M';
            bool Sighn = true;
            var xyz = 10;
            var Abc = "xyz";
            decimal Q = 101010104;
            Console.WriteLine((x + y) + " " + Department + " " + (Num1 + Num2) + " " + ch + " " + Sighn);
            Console.WriteLine(xyz + " " + Abc + " " + Q + " " + byte.MaxValue + " To " + byte.MinValue);
            int Hexadeimal = 0x2fa;
            /*Do not use thsis way int Visual stodio 2013,
            Use this way in visual stodio 2017 and so on */
             //int Binary = 0b1010;
            Console.WriteLine(Hexadeimal /*+ "  " + Binary*/);

        }
    }

    public enum enWeekEnd : byte
    {
        Saturday,
        Sunday,
        Monday,
        Tuesday,
    }

    public struct stPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public string Address { get; set; }

        public string FullName 
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public void Print()
        {
            Console.WriteLine("Hi, I am {0},My age is {1} and I live in {2}.", FullName, Age, Address);
        }
    }
      
    class Program
    {
       public void PrintMyInfo(string Name = "Saddam Al-zelri", int Age = 25)
       {
           Console.WriteLine("Hi, I am {0} and I am {1}", Name, Age);
       }
        static void Main(string[] args)
        {
            PrintMyInfo();

            //int[] MyArray2 = { 1, 2, 3, 44, 33, 46, 89 };

            //Console.WriteLine(MyArray2.Min());
            //Console.WriteLine(MyArray2.Max());
            //Console.WriteLine(MyArray2.Count());
            //Console.WriteLine(MyArray2.Average());
            //Console.WriteLine(MyArray2.Sum());
            //Console.WriteLine(Math.Max(5, 10));

            //int[] NumList = new int[4];

            //NumList[0] = 10;
            //NumList[1] = 20;
            //NumList[2] = 30;
            //NumList[3] = 40; 
            //Console.WriteLine(NumList[0]);

            /////////////////////////
            //int[,] DlNumList = new int[2, 3];

            //DlNumList[0, 0] = 10;
            //DlNumList[0, 1] = 20;
            //DlNumList[0, 2] = 30;

            //DlNumList[1, 0] = 40;
            //DlNumList[1, 1] = 50;
            //DlNumList[1, 2] = 60;

            //Console.WriteLine(DlNumList[0, 2] + " " + DlNumList[1, 2]);
            //char[] MyArray = { 'q', 'Q', 'O', 'l' };
            //int[] MyArray2 = { 1, 2, 3, 44 };

            //foreach(char Ch in MyArray)
            //{
            //    Console.WriteLine(Ch);
            //}

            //for (int x = 1; x <= 5; x++)
            //{
            //    Console.WriteLine("Hello World");
            //}

            //int i = 0;
            //while(i < 5)
            //{
            //    ++i;
            //    Console.WriteLine("Hello World in while");
            //}

            //int ii = 0;
            //do
            //{
            //    ++ii;
            //    Console.WriteLine("Hello World in do while");
            //}while(ii < 5);

                //int Number = Convert.ToInt32(Console.ReadLine());

                //string Result = (Number % 2 == 0) ? "It is Even" : "It is Odd";

                //Console.WriteLine("The Number is " + Result);

                //Console.WriteLine("Enter FirstName.");
                //string FirstName = Console.ReadLine();
                //Console.WriteLine("Enter LastName.");
                //string LastName = Console.ReadLine();
                //Console.WriteLine("Enter Age.");
                //int Age = Convert.ToInt32(Console.ReadLine());

                //string FullName = FirstName + " " + LastName;

                //Console.WriteLine("FullName : " + FullName);
                //Console.WriteLine("Age : " + Age);


                //int Counter = 20;
                //double Price = 120.5d;
                //bool sighn = true;

                //Console.WriteLine(Convert.ToString(Counter));
                //Console.WriteLine(Convert.ToInt32(Price));
                //Console.WriteLine(Convert.ToString(sighn));
                //Console.WriteLine(Convert.ToDouble(Counter));

                //int Age = 25;
                //double Salary = 6500.5d;

                ////implicit Casting
                //long ImplicitAge = Age;
                //Console.WriteLine(ImplicitAge);
                ////Explicit Casting
                //int ExplicitSalary = (int)Salary;
                //Console.WriteLine(ExplicitSalary);

                //string S1 = "Saddam Hussein Al-zekri";

                //Console.WriteLine(S1.Length);
                //Console.WriteLine(S1.ToUpper());
                //Console.WriteLine(S1.ToLower());
                //Console.WriteLine(S1[7]);
                //Console.WriteLine(S1.Replace('m', 'k'));
                //Console.WriteLine(S1.Insert(3, "xyz"));
                //Console.WriteLine(S1.Contains("e"));
                //Console.WriteLine(S1.LastIndexOf("e"));

                //string S2 = "Saddam,Hussein,Al-zekri";
                //string[] NameList = S2.Split(',');

                //Console.WriteLine(NameList[0]);
                //Console.WriteLine(NameList[1]);
                //Console.WriteLine(NameList[2]);

                //string S3 = " Saddam ";

                //Console.WriteLine(S3);
                //Console.WriteLine(S3.Trim());
                //Console.WriteLine(S3.TrimStart());
                //Console.WriteLine(S3.TrimEnd());

                //DateTime dt1 = new DateTime(2023, 8, 30);
                //DateTime dt2 = new DateTime(2023, 8, 20);
                //TimeSpan ts = dt1.Subtract(dt2);
                //Console.WriteLine(ts);
                //Console.WriteLine(dt1 + ts);
                //Console.WriteLine(dt1 - dt2);
                //Console.WriteLine(dt1 >= dt2);


                //DateTime dt = new DateTime(2023, 2, 21);
                //TimeSpan ts = new TimeSpan(49, 25, 44);
                //Console.WriteLine(ts);
                //Console.WriteLine(ts.Days);
                //Console.WriteLine(ts.Days);
                //Console.WriteLine(ts.Minutes);
                //Console.WriteLine(ts.Seconds);

                //DateTime newDate1 = dt.Add(ts);
                //DateTime newDate2 = dt.Subtract(ts);

                //Console.WriteLine("New Time After Add = " + newDate1);
                //Console.WriteLine("New Time After Subtruct = " + newDate2);

                //Console.WriteLine(DateTime.UtcNow.Ticks);
                //Console.WriteLine(DateTime.Now.Ticks);
                //Console.WriteLine(DateTime.Today.Ticks);
                //Console.WriteLine(DateTime.MaxValue.Ticks);
                //Console.WriteLine(DateTime.MinValue.Ticks);

                //DateTime Dt = new DateTime();
                //Console.WriteLine("DataTime : " + Dt);
                //DateTime Dt1 = new DateTime(2025, 7, 15);
                //Console.WriteLine("DataTime1 : " + Dt1);
                //DateTime Dt2 = new DateTime(2025, 7, 15, 12, 30, 20, DateTimeKind.Local);
                //Console.WriteLine("DataTime2 : " + Dt2);

                //Console.WriteLine("The time now : " + DateTime.Now);


                //dynamic Variable;

                //Variable = 10;
                //Console.WriteLine("Dynamic variable : " + Variable);
                //Variable = "Hello World";
                //Console.WriteLine("Dynamic variable : " + Variable);
                //Variable = true;
                //Console.WriteLine("Dynamic variable : " + Variable);
                //Variable = 100.23;
                //Console.WriteLine("Dynamic variable : " + Variable);

                //stPerson Person = new stPerson();

                //Person.FirstName = "Saddam";
                //Person.LastName = "Al-zekri";

                //Person.Age = 25;

                //Person.Address = "YEMEN, Taiz City, Al-Turba Twon, Alzakira";

                //Person.Print();

                //clsPractice Practice = new clsPractice();

                //Practice.Print();
                //Practice.Print2();

                //enWeekEnd Weekday = enWeekEnd.Sunday;
                //Console.WriteLine(Convert.ToInt16(Weekday));

                //var Week = (enWeekEnd)3;
                //Console.WriteLine(Week);

                //int? WaterCounter = null;
                //Nullable<int> SpeedCounter = null;
                //WaterCounter = 200;

                //Console.WriteLine(WaterCounter + "  " + SpeedCounter);

                //var Student = new 
                //{ Id = 01, 
                //  Name = "Saddam al-zekri", 
                //  Age = 25,
                //  Degrees = new {Mathimatics = 90, History = 100}
                //};

                //Console.WriteLine("Name = " + Student.Name + "\nAge = " + Student.Degrees.History);

                Console.ReadKey();
        }
    }
}
