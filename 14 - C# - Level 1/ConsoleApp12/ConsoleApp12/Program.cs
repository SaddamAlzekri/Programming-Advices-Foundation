using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static int size = 0;
        static void push(string[] Topponing, string str)
        {

            Topponing[size] = str;
            size++;
        }
        static void Main(string[] args)
        {

            string[] Topponing;
            Topponing = new string[6];
            string str2 = "iii";

            push(Topponing, "Alao");
            push(Topponing, "Alao2");
            push(Topponing, "Alao3");

            Console.WriteLine(Topponing[0]);
            Console.WriteLine(Topponing[1]);
            Console.WriteLine(Topponing[2]);

            int Number = 12;
            string str = (Number % 2 == 0) ? "Even Number" : "OddNumber";
            Console.WriteLine(str);
            Console.Write("\n\n");
            /////////////////////////////////////
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i + "  ");
            }
            /////////////////////////////////////
            Console.Write("\n\n");
            for (int i = 1; i <= 10; i++)
            {

                for (int j = 10; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Write("\n\n");
            //////////////////////////////////////////
            int myInt = 1;
            while(myInt <= 5)
            {
                Console.WriteLine("C# while Loop: Iteration {0}", myInt);
                myInt++;
            }
            //////////////////////////////////////////////
            Console.Write("\n\n");
            int myInt2 = 1;
            do{
                Console.WriteLine("C# do while Loop: Iteration {0}", myInt2);
                myInt2++;
            }while(myInt2 <= 5);
            //////////////////////////////////////////////
            Console.Write("\n\n");
            int myInt3 = 1;
            do
            {
                Console.WriteLine("C# do while Loop: Iteration {0}", myInt3);
                if (myInt3 == 3)
                    break;
                myInt3++;
            } while (myInt3 <= 5);
            ////////////////////////////////////////
            Console.Write("\n\n");
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i + "  ");
                if (i == 3)
                    break;
            }
            ////////////////////////////////////////
            Console.Write("\n\n");
            for (int i = 0; i <= 10; i++)
            {
                if (i == 3)
                    continue;
                Console.WriteLine("C# do while Loop: Iteration {0}", i);
            }
            ////////////////////////////////////////
            Console.Write("\n\n");
            int[] Num;
            Num = new int[5];
            Num[0] = 1;
            Num[1] = 2;
            Num[2] = 66; 
            Num[3] = 2;
            Num[4] = 66;
            ////////////////////////////////////////
            Console.Write("\n\n");


            int[] myInt7;
            myInt7 = new int[5];
            myInt7[0] = 1;
            myInt7[1] = 2;
            myInt7[2] = 3;
            myInt7[3] = 4;
            myInt7[4] = 5;
            Console.WriteLine("Elements in first index : " + myInt7[0]);
            Console.WriteLine("Elements in second index : " + myInt7[1]);
            Console.WriteLine("Elements in third index : " + myInt7[2]);
            Console.WriteLine("Elements in fourth index : " + myInt7[3]);
            Console.WriteLine("Elements in fifth index : " + myInt7[4]);
            ////////////////////////////////////////
            Console.Write("\n\n");
            int[,] xx = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] xx2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("Elements at index : " + xx[1, 0]);
            Console.WriteLine("Elements at index : " + xx2[0, 1]);
            ////////////////////////////////////////
            Console.Write("\n\n");
            char[] myArray = {'a','o', 'i', 'e', 'u'};
            foreach(char ch in myArray)
            {
                Console.Write(ch + "  ");
            }
            ////////////////////////////////////////
            Console.Write("\n\n");
            char[] gender = { 'm','m', 'f', 'm', 'f', 'm', 'f', 'm', 'm', 'f' };
            int male = 0, female = 0;
            foreach(char g in gender)
            {
                if (g == 'm')
                    male++;
                else
                    female++;
            }
            Console.WriteLine("Number of male = {0}", male);
            Console.WriteLine("Number of female = {0}", female);
            ////////////////////////////////////////
            Console.Write("\n\n");
            int[] Numbers = { 1, -1, 3, 129, 400, 1000 };
            Console.WriteLine("Numbers of minimam = " + Numbers.Min());
            Console.WriteLine("Numbers of maximam = " + Numbers.Max());
            ////////////////////////////////////////
            Console.Write("\n\n");
            int[] Numbers2 = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Numbers of count = " + Numbers2.Count());
            Console.WriteLine("Numbers of sum = " + Numbers2.Sum());
            Console.WriteLine("Numbers of average = " + Numbers2.Average());
            ////////////////////////////////////////
            Console.Write("\n\n");
            Console.WriteLine("Max of 5, 10 is : {0}", Math.Max(5, 10));
            Console.WriteLine("Minax of 5, 10 is : {0}", Math.Min(5, 10));
            Console.WriteLine("Sqrt of 64 : {0}", Math.Sqrt(64));
            Console.WriteLine("Abs of 5, 10 is : {0}", Math.Abs(-4.7));
            Console.WriteLine("Round of 5, 10 is : {0}", Math.Round(4.10));

                Console.ReadKey();
        }
    }
}
