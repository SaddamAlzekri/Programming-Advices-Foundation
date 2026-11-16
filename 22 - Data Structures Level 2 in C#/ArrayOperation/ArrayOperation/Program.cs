using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperation
{
    class Program
    {
        static void SimpleExample()
        {
            int[] Numbers = new int[5];

            for(int i = 0; i< 5; i++)
            {
                Numbers[i] = i;
                Console.Write(Numbers[i] + " ");
            }

            Console.WriteLine();

            string[] NamesOfAnimals = { "Elephant", "Dog", "Cat", "Camel", "Goat" };

            int Length = NamesOfAnimals.Length;

            Console.WriteLine("\nThere ase some Animals that found in Zoo.\n");
            
            foreach(string item in NamesOfAnimals)
            {
                Console.Write(item + "  ");
            }
            
        }

        static void SortArray()
        {
            int[] Numbers = { 1, 2, 3, 5, 6, 4 };

            Array.Sort(Numbers);

            Console.WriteLine("The Sum : " + Numbers.Sum());

            foreach(int item in Numbers)
            {
                Console.Write(item + " ");
            }

            int index = Array.IndexOf(Numbers, 5);
            Console.WriteLine("\nThe index of " + Numbers[0] + " number : " + index);

            int[] CopyNumber = new int[6];

            Array.Copy(Numbers, CopyNumber, Numbers.Length);

            Console.WriteLine("\nCopy Numbers");
            foreach (int item in CopyNumber)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nAdvanced LINQ");
            var FilterArray = Numbers.Where(n => n % 2 == 0).Select(n => n * n);

            foreach(int item in FilterArray)
            {
                Console.Write(item + " ");
            }

        }

        static void PrintMatrix()
        {
            int[,] Matrix = { { 1, 2, 3 }, { 4, 5, 6 } };

            for(int i = 0; i<Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i,j] + " ");
                }


                Console.WriteLine();
            }
        }

        static void ObjFunc()
        {
            var People = new []
            {
                new {Name = "Saddam", Age = 20},
                new {Name = "Ali", Age = 20},
                new {Name = "AbdoAlrab", Age = 30},
                new {Name = "Johan", Age = 30},
                new {Name = "Jone", Age = 30}
            };

            var GroupByAge = People.GroupBy(n => n.Age)
            .Select(group => new 
            { 
              Age = group.Key, 
              people = group.OrderBy(p => p.Name) 
            });
 
            foreach(var item in GroupByAge)
            {
                Console.WriteLine("- item : " + item.Age);
                foreach(var items in item.people)
                {
                    Console.WriteLine(items.Name + "  ");
                }
            }
        }

        static void ObjFunc2()
        {
            var People = new[] 
            {
                new {Name = "Saddam", Age = 20, DepartmentID = 1},
                new {Name = "Saleh", Age = 30, DepartmentID = 2},
                new {Name = "Dora", Age = 20, DepartmentID = 3},
                new {Name = "Hothifa", Age = 30, DepartmentID = 4}
            };

            var DepartMent = new[]
                {
                    new {Name = "IT", ID = 1},
                    new {Name = "CS", ID = 2},
                };

            var PeopleInfo = People.GroupBy(n => n.Age).Select(n => new { Age = n.Key, Name = n.OrderBy(p => p.Name)});

            var PersonInfo = People.Join(DepartMent, p => p.DepartmentID, e => e.ID, (p, e) => new {p.Name,Age = p.Age ,Department = e.Name});
           
            foreach (var item in PersonInfo)
            {
                Console.WriteLine(item.Name + "    " + item.Age + "    " + item.Department);
            }
        }
        private static string BitArraysToString(BitArray bitArray)
        {
            char[] chars = new char[bitArray.Length];
            for(int i = 0; i< bitArray.Length; i++)
            {
                if(bitArray[i] == true)
                {
                    chars[i] = '1';
                }else
                {
                    chars[i] = '0';
                }
            }
            return new string(chars);
        }
        static void BittArray()
        {
            BitArray bit1 = new BitArray(new int[] {2});

            Console.WriteLine("The Number in binary : " + BitArraysToString(bit1));

            for(int i = 0; i<bit1.Length ; i++)
            {
                Console.WriteLine(bit1[i]);
            }
        }

        static void Main(string[] args)
        {
            BittArray();

            Console.ReadKey();
        }
    }
}
