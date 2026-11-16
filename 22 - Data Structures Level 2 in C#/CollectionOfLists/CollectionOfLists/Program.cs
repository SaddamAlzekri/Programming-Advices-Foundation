using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionOfLists
{
    class Program
    {
        static void ExampleOne()
        {
            List<int> Numbers = new List<int>();

            Numbers.Add(10);
            Numbers.Add(20);
            Numbers.Add(30);
            Numbers.Add(40);

            Console.WriteLine("The Count Of Numbers : " + Numbers.Count());

            Console.WriteLine("The value at index 0  = " + Numbers[0]);

            Numbers[0] = 500;
            Console.WriteLine(Numbers[0]);
        }

        static void ExampleTwo()
        {
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Numbers.Add(11);
            Console.WriteLine("The List of Number After use Add Func : " + string.Join(" ,", Numbers));

            Numbers.Insert(0, 0);
            Console.WriteLine("The List of Number After use Insert Func : " + string.Join(" ,", Numbers));

            Numbers.InsertRange(5, new List<int> { 50, 60 });
            Console.WriteLine("The List of Number After use InsertRange Func : " + string.Join(" ,", Numbers));
        }

        static void ExampleThree()
        {
            List<int> Numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};


            Numbers.Remove(10);
            Console.WriteLine(string.Join(" ,", Numbers));

            Numbers.RemoveAt(0);
            Console.WriteLine(string.Join(" ,", Numbers));

            Numbers.RemoveAll(n => n <= 5);
            Console.WriteLine(string.Join(" ,", Numbers));

            List<int> Numbers2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Numbers2.RemoveAll(n => n >= 5);
            Console.WriteLine(string.Join(" ,", Numbers2));
            
            List<int> Numbers3 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Numbers3.RemoveAll(n => n % 2 == 0);
            Console.WriteLine(string.Join(" ,", Numbers3));

        }

        static void ExampleFour()
        {
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Numbers.AddRange(new int[] { 11, 12, 13 });
            Console.WriteLine(string.Join(" ,", Numbers));

            Console.WriteLine(Numbers.Contains(11));
            Console.WriteLine(Numbers.Contains(14));
            Console.WriteLine(Numbers.IndexOf(11));

            Numbers.InsertRange(0, new List<int> { 14, 15, 16 });
            Console.WriteLine(string.Join(" ,", Numbers));
            Numbers.Sort();
            Console.WriteLine(string.Join(" ,", Numbers));
            Numbers.Reverse();
            Console.WriteLine(string.Join(" ,", Numbers));
            Numbers.Clear();
            Console.WriteLine(string.Join(" ,", Numbers));
        }

        static void ExampleFive()
        {
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < Numbers.Count; i++)
            {
                Console.Write(Numbers[i] + " ");
            }
            Console.WriteLine("\nAnother way\n");

            foreach (int num in Numbers)
            {
                Console.Write(num + " ");
            }
            // This way do in bigger version
            // Numbers.ForEach(Numbers => Console.WriteLine(Numbers));
        }

        static void ExampleSex()
        {
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Sum : " + Numbers.Sum());
            Console.WriteLine("Average : " + Numbers.Average());
            Console.WriteLine("Min: " + Numbers.Min());
            Console.WriteLine("Max : " + Numbers.Max());
            Console.WriteLine("Count : " + Numbers.Count());


        }
        static void ExampleSeven()
        {
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Even Number : " + string.Join(" ,",Numbers.Where(n => n % 2 == 0)));
            Console.WriteLine("Odd Number : " + string.Join(" ,",Numbers.Where(n => n % 2 != 0)));
            Console.WriteLine("Number Biger than 5 : " + string.Join(" ,",Numbers.Where(n => n > 5)));
            Console.WriteLine("Number least than 5 : " + string.Join(" ,",Numbers.Where(n => n < 5)));
            Console.WriteLine("every second than 5 : " + string.Join(" ,",Numbers.Where((n, index) => index % 2 == 1)));
            Console.WriteLine("Number between 3-8 : " + string.Join(" ,",Numbers.Where(n => n > 3 && n < 8)));
            Console.WriteLine(string.Join(" ,", Numbers.Where(n => n == 4)));
            Console.WriteLine(string.Join(" ,", Numbers.Where(n => n - 2 == 2)));

        }

        static void ExampleEight()
        {
            List<int> Numbers = new List<int> { 1, -2, -93, 4, 5, 6, 71, 8, 9, 10 };
            Console.WriteLine(string.Join(" ,", Numbers));

            Numbers.Sort();
            Console.WriteLine(string.Join(" ,", Numbers));

            Numbers.Reverse();
            Console.WriteLine(string.Join(" ,", Numbers));

            Console.WriteLine(string.Join(" ,", Numbers.OrderBy(n => n)));
            Console.WriteLine(string.Join(" ,", Numbers.OrderByDescending(n => n)));

            
        }

        static void ExampleNine()
        {
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Is there Numbers : " + string.Join(" ,", Numbers.Contains(101)));
            Console.WriteLine("Is least 5 : " + string.Join(" ,", Numbers.Exists(n => n <= 5)));
            Console.WriteLine("Is bigger 3 : " + string.Join(" ,", Numbers.Find(n => n > 3)));
            Console.WriteLine("Find All bigger 3 : " + string.Join(" ,", Numbers.FindAll(n => n > 3)));
            Console.WriteLine("Is there Numbers : " + string.Join(" ,", Numbers.Any(n => n > 9)));



        }

        static void ExampleTen()
        {
            List<string> Fruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Strowberry" };

            Console.WriteLine(string.Join(" ,", Fruits.Contains("Apple")));
            Console.WriteLine(string.Join(" ,", Fruits.Find(F => F.Length == 5)));
            Console.WriteLine(string.Join(" ,", Fruits.FindAll(F => F.Length > 5)));
            Console.WriteLine(string.Join(" ,", Fruits.Any(F => F.Contains("pp"))));
            Console.WriteLine(string.Join(" ,", Fruits.Any(F => F.Contains("ppk"))));
            Console.WriteLine(string.Join(" ,", Fruits.Any(F => F.StartsWith("Ba"))));

            
        }

        class PersonInfo
        {
            private string p1;
            private int p2;

            public string Name { get; set; }
            public int Age { get; set; }

            public PersonInfo(string Name, int Age)
            {
                this.Name = Name;
                this.Age = Age;
            }
        }

        static void ExampleEleven()
        {
            List<PersonInfo> Person = new List<PersonInfo> 
            {
                new PersonInfo("Ali", 20),
                new PersonInfo("Saddam", 18),
                new PersonInfo("Ahmmed1", 15),
                new PersonInfo("Ahmmed3", 16),
                new PersonInfo("Ahmmed3", 14),
                new PersonInfo("Ahmmed4", 30),

            };

            foreach(PersonInfo P in Person)
            {
                Console.WriteLine("The Name : " + P.Name + " The Age : " + P.Age);
            }

            PersonInfo Persons = Person.Find(P => P.Name == "Saddam");

            if(Persons != null)
            {
                Console.WriteLine("The Name : " +Persons.Name + " The Age : " + Persons.Age);
            }

            PersonInfo Persons2 = Person.FirstOrDefault(P => P.Name == "Saddam");

            if (Persons != null)
            {
                Persons2.Age = 26;
                Persons2.Name = "Somaia";
                Console.WriteLine("The Name : " + Persons.Name + " The Age : " + Persons.Age);
            }

            Console.WriteLine(Person.Any(P => P.Name == "Ali"));
            Console.WriteLine(Person.Exists(P => P.Name == "Maher"));
            
            Person.RemoveAll(P => P.Age == 15);
            Person.RemoveAt(0);
            foreach (PersonInfo P in Person)
            {
                Console.WriteLine("The Name : " + P.Name + " The Age : " + P.Age);
            }
        }
        
        static void ExampleTewlve()
        {
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] arrNumbers = Numbers.ToArray();

            Console.WriteLine("Convert List To Array : " +string.Join(" ,", arrNumbers));

            List<int> ListNum = new List<int>(arrNumbers);

            Console.WriteLine("Convert Array To List : " + string.Join(" ,", arrNumbers));

        }

        static void HashTable()
        {
            Hashtable MyHashTable = new Hashtable();

            MyHashTable.Add("Key1", "value1");
            MyHashTable.Add("Key2", "value2");
            MyHashTable.Add("Key3", "value3");
            MyHashTable.Add(1, 209090);

            Console.WriteLine(MyHashTable[1]);

            Console.WriteLine(MyHashTable["Key1"]);
            MyHashTable[1] = "value4";

            Console.WriteLine(MyHashTable[1]);
            Console.WriteLine("\n\n ");
            MyHashTable.Remove(1);
            foreach(DictionaryEntry hash in MyHashTable)
            {
                Console.WriteLine("Key : " + hash.Key + " Value : " + hash.Value);
            }
        }

        static void Main(string[] args)
        {


            //ExampleOne();
            //ExampleTwo();
            //ExampleThree();
            //ExampleFour();
            //ExampleFive();
            //ExampleSex();
            //ExampleSeven();
            //ExampleEight();
            //ExampleNine();
            //ExampleTen();
            //ExampleEleven();
            //ExampleTewlve();
            HashTable();

            Console.ReadKey();
        }
    }
}
