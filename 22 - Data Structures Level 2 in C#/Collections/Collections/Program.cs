using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void WorkingWithDictionary()
        {
            Dictionary<string, int> FruitBasket = new Dictionary<string, int>();

            FruitBasket.Add("Apple", 12);
            FruitBasket.Add("Banana", 15);
            FruitBasket.Add("Date", 10);
            FruitBasket.Add("Orange", 20);

            foreach (KeyValuePair<string, int> Fruit in FruitBasket)
            {
                Console.WriteLine("The Key : " + Fruit.Key + " The value : " + Fruit.Value);
            }

            FruitBasket.Remove("Apple");
            
            Console.WriteLine("\nPrint the dictionary after remove.\n");

            foreach (KeyValuePair<string, int> Fruit in FruitBasket)
            {
                Console.WriteLine("The Key : " + Fruit.Key + " The value : " + Fruit.Value);
            }
        }

        static void TryGetValue()
        {
            Dictionary<string, int> FruitBasket = new Dictionary<string, int>
            {
                {"Apple", 5},
                {"Banana", 10},
                {"Strowberry", 15},
                {"Watermelon", 20}
            };

            int AppleQuentity = 0;
            
            if(FruitBasket.TryGetValue("Apple", out AppleQuentity))
            {
                Console.WriteLine("The Count of Apples is " + AppleQuentity);
            }else
            {
                Console.WriteLine("Apple not found in the basket");
            }

            int DateQuentity = 0;

            if(FruitBasket.TryGetValue("Date", out DateQuentity))
            {
                Console.WriteLine("The count of Date is " + DateQuentity);
            }else
            {
                Console.WriteLine("DateQuentity not found in the basket.");
            }
        }

        static void LinqWithDictionary()
        {
            Dictionary<string, int> FruitBasket = new Dictionary<string, int>
            {
                {"Apple", 5},
                {"Banana", 10},
                {"Strowberry", 15},
                {"Watermellon", 20},
                {"Date", 25}
            };

            var Fruitinfo = FruitBasket.Select(n => new { n.Key, n.Value });

            foreach(var item in Fruitinfo)
            {
                Console.WriteLine("The key : " + item.Key + " The value : " + item.Value);
            }
            
            Console.WriteLine("\n\nWhere By by descinding.\n\n");

            var FruitStoreMore12 = FruitBasket.Where(n => n.Value >= 12);

            foreach(var item in FruitStoreMore12)
            {
                Console.WriteLine("The key : " + item.Key + "The value : " + item.Value);
            }

            Console.WriteLine("\n\nOrder.\n\n");
            var Order = FruitBasket.OrderBy(n => n.Value);


            foreach (var item in Order)
            {
                Console.WriteLine("The key : " + item.Key + "The value : " + item.Value);
            }


            Console.WriteLine("\n\nOrderBy by descinding.\n\n");
            var OrdernonDescinding = FruitBasket.OrderByDescending(n => n.Value);
            foreach (var item in OrdernonDescinding)
            {
                Console.WriteLine("The key : " + item.Key + "The value : " + item.Value);
            }


        }

        static void AdvancedDictionary()
        {
            Dictionary<string, string> FruitCategory = new Dictionary<string, string>
            {
                {"Apple", "Tree"},
                {"Banana", "Herb"},
                {"Cherry", "Tree"},
                {"Strawberry", "Bush"},
                {"Respberry", "Bush"}
            };

            Console.WriteLine("Categoties\n");
            var GategiryFruit = FruitCategory.GroupBy(n => n.Value);

            foreach(var item in GategiryFruit)
            {
                Console.WriteLine("The Key : " + item.Key);
                foreach(var item2 in item)
                {
                    Console.WriteLine(" -" + item2.Value);
                }
            }

            Dictionary<string, int> FruitBasket = new Dictionary<string, int>
            {
                {"Apple", 50},
                {"Banana", 10},
                {"Strowberry", 15},
                {"Watermellon", 20},
                {"Date", 25}
            };

            var SortedFilterFruits = FruitBasket
                .Where(n => n.Value > 12)
                .OrderBy(n => n.Value)
                .Select(n => new { n.Key, n.Value });

            foreach(var item in SortedFilterFruits)
            {
                Console.WriteLine("The key : " + item.Key + "The value : " + item.Value);
            }

        }

        static void HashSet()
        {
            HashSet<string> Colors = new HashSet<string>();

            Colors.Add("Red");
            Colors.Add("Blue");
            Colors.Add("Yellow");
            Colors.Add("Green");
            Colors.Add("Orange");
            Colors.Add("Purple");
            Colors.Add("Red");
            Colors.Add("Purple");

            Console.WriteLine("The Colors");
            
            foreach(var item in Colors)
            {
                Console.WriteLine(item);
            }

            Colors.Remove("Red");
            Colors.RemoveWhere(n => n.Length <= 4);

            Console.WriteLine("\n\nThe Hashet After the Remove.\n\n");

            foreach (var item in Colors)
            {
                Console.WriteLine(item);
            }
        }

        static void HashsetIsExists()
        {
            HashSet<int> Numbers = new HashSet<int>();

            Numbers.Add(1);
            Numbers.Add(2);
            Numbers.Add(3);
            Numbers.Add(4);
            Numbers.Add(5);
            Numbers.Add(6);
            Numbers.Add(7);
            Numbers.Add(8);

            var Filters = Numbers.Where(n => n > 5);

            foreach (var item in Filters)
            {
                Console.WriteLine(item);
            }

            HashSet<string> Colors = new HashSet<string>();

            Colors.Add("Red");
            Colors.Add("Blue");
            Colors.Add("Yellow");
            Colors.Add("Purple");
            Colors.Add("White");
            Colors.Add("Green");
            Colors.Add("lightblue");
            var Filter2 = Colors.Where(n => n.Length > 5);

            foreach (var item in Filter2)
            {
                Console.WriteLine(item);
            }
        }

        static void UnionHashset()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 4 };

            set1.UnionWith(set2);

            Console.WriteLine("Union Of set1 and set2");

            foreach(var item in set1)
            {
                Console.WriteLine(item);
            }
 
        }

        static void IntersectionHashset()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 4 };

            set1.IntersectWith(set2);

            Console.WriteLine("Intersection Of set1 and set2");

            foreach (var item in set1)
            {
                Console.WriteLine(item);
            }

        }

        static void DifferrentHashset()
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 4 };

            set1.ExceptWith(set2);

            Console.WriteLine("Differrent Of set1 and set2");

            foreach (var item in set1)
            {
                Console.WriteLine(item);
            }

        }

        static void SymmetricHashset()
        {
            HashSet<int> set1 = new HashSet<int> { 3, 4, 5 };
            HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4, 5, 6 };;
            HashSet<int> set3 = new HashSet<int> { 3, 4, 5 };


            set1.SymmetricExceptWith(set2);

            Console.WriteLine("Symmetric difference of set:");
            foreach(int item in set1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Set1 equal set2 : " + set1.SetEquals(set2));
            Console.WriteLine("Set2 equal set3 : " + set2.SetEquals(set3));

            Console.WriteLine("Set1 Sub set set2 : " + set1.IsSubsetOf(set2));
            Console.WriteLine("Set2 Supper set set1 : " + set2.IsSupersetOf(set1));
            Console.WriteLine("Set2 overlabs set1 : " + set2.Overlaps(set1));  
        }

        static void SortedList()
        {
            var SortedList = new SortedList<string, int>();

            SortedList.Add("Apple", 10);
            SortedList.Add("Banana", 15);
            SortedList.Add("Date", 20);
            SortedList.Add("Watermellon", 30);

            foreach(var item in SortedList)
            {
                Console.WriteLine("The Key : " + item.Key + "The value : " + item.Value);
            }

            SortedList.Remove("Apple");
            SortedList.RemoveAt(2);

            Console.WriteLine("\n\n");
            foreach (var item in SortedList)
            {
                Console.WriteLine("The Key : " + item.Key + "The value : " + item.Value);
            }
        }

        static void AdvancedSortedList()
        {
            SortedList<int, string> numbers = new SortedList<int, string>
            {
                {1, "One"},
                {2, "Two"},
                {3, "Three"},
                {4, "Four"},
                {5, "Five"}
            };

            var sortedList = from n in numbers
                             where n.Key > 2
                             select n;
            foreach(var item in sortedList)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
            Console.WriteLine("\n\n");

            var sortedLi= numbers.Where(n => n.Key > 1);

            foreach (var item in sortedLi)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
            Console.WriteLine("\n\n");

            var group = numbers.GroupBy(n => n.Value.Length);

            foreach (var item in group)
            {
                Console.WriteLine(item.Key + "  " + string.Join(" ,", item.Select(n => n.Value)));
            }
        }
        
        public class Employee
        {
            public string Name { get; set; }
            public string Department { get; set; }
            public int Salary { get; set; }

            public Employee(string Name, string Department, int Salary)
            {
                this.Name = Name;
                this.Department = Department;
                this.Salary = Salary;
            }
        }

        static void Employee2()
        {
            SortedList<int, Employee> employee = new SortedList<int, Employee>
            {
                {1, new Employee("Ali", "IT", 5000)},
                {2, new Employee("Saddam", "CS", 7000)},
                {3, new Employee("Mohammed", "HR", 8000)},
            };

            var Filter = employee.Where(e => e.Value.Department == "IT")
                .OrderByDescending(e => e.Value.Salary)
                .Select(e => e.Value.Department);

            foreach(var item in Filter)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            Employee2();

            Console.ReadKey();
        }
    }
}
