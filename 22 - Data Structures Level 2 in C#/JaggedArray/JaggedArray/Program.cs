using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void JaggedArray()
        {
            int[][] JaggedArray = new int[3][];
            JaggedArray[0] = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            JaggedArray[1] = new int[] { 1, 2, 3 };
            JaggedArray[2] = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Jagged Array");
            for (int i = 0; i < JaggedArray.Length; i++)
            {
                for (int j = 0; j < JaggedArray[i].Length; j++)
                {
                    Console.Write(JaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void JaggedArray2()
        {
            int[][] JaggedArray = new int[3][] 
            {
                new int[] {1, 2, 3, 4, 5, 6,7 },
                new int[] {1, 2, 3},
                new int[] {1, 2, 3, 4, 5, }
            };

            Console.WriteLine("The Max Of Jagged Array : " + JaggedArray.SelectMany(n => n).Max());
            Console.WriteLine("The Min Of Jagged Array : " + JaggedArray.SelectMany(n => n).Min());
            Console.WriteLine("The Sum Of Jagged Array : " + JaggedArray.SelectMany(n => n).Sum());
            Console.WriteLine("The Avg of Jagged Array : " + JaggedArray.SelectMany(n => n).Average());

            var FilterJaggedArray = JaggedArray.Where(n => n.Length > 3).Select(n =>n.Max());

            foreach(var filter in FilterJaggedArray)
            {
                Console.Write(filter + " ");
            }
        }

        static void Tuples()
        {
            Tuple<int, string, double> PersonInfo = new Tuple<int,string,double>(1, "Ali", 4000);

            Console.WriteLine("Item1 : " + PersonInfo.Item1);
            Console.WriteLine("Item2 : " + PersonInfo.Item2);
            Console.WriteLine("Item3 : " + PersonInfo.Item3);

            List<Tuple<int, int, string>> People = new  List<Tuple<int, int, string>>
            {
            Tuple.Create(1, 20, "Ali"),
            Tuple.Create(1, 23, "Sami"),
            Tuple.Create(1, 25, "Saddam")
            };

            var FilterPeople = People.Where(n => n.Item2 > 20);

            foreach(var item in FilterPeople)
            {
                Console.WriteLine(item.Item1 + " " + item.Item2 + " " + item.Item3);
            }
            double Age = FilterPeople.Average(n => n.Item2);

            Console.WriteLine("The avg : " + Age);
        }

        //static (int, string) Department(int ID, string Name) 
        static Tuple<int, string> Department(int ID, string Name)
        {
            //return (ID, Name);
           // return Tuple.Create(ID, Name);
            return new Tuple<int, string>(ID, Name);
        }

        static class CustomCollection<T> : IEnumerable<T>
        {
            IEnumerable<int> Numbers = new int[] { 1, 2, 3, 4 };

            IEnumerable<int> numbers = new List<int>();
        }

        static void Main(string[] args)
        {
            Tuples();

            Console.ReadKey();
        }
    }
}
