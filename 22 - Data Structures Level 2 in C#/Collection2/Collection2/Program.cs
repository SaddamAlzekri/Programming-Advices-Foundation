using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection2
{
    class Program
    {
        static void SortedSet()
        {
            SortedSet<int> Sortedset = new SortedSet<int>();
            Sortedset.Add(5);
            Sortedset.Add(4);
            Sortedset.Add(3);
            Sortedset.Add(1);

            Console.WriteLine("The Sortedset elements.\n");
            foreach(int item in Sortedset)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Is found the 3 number : " + Sortedset.Contains(3));

            Sortedset.Remove(1);

            Console.WriteLine("The elements after remove : \n");
            foreach (int item in Sortedset)
            {
                Console.WriteLine(item);
            }
        }

        static void LinqWithSortedSet()
        {
            SortedSet<int> Numbers = new SortedSet<int> {1, 2, 3, 4, 5, 6, 8, 9, 7};

            var filterNumber = Numbers.Where(n => n > 4).OrderBy(n => n).Select(n => n);
            foreach(int item in filterNumber)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");
            
            Console.WriteLine("The min : " + Numbers.Min());
            Console.WriteLine("The Max : " + Numbers.Max());
            Console.WriteLine("The avg : " + Numbers.Average());

            var OrderByDescinding = Numbers.OrderByDescending(n => n);
            Console.WriteLine("\n");
            foreach (int item in OrderByDescinding)
            {
                Console.WriteLine(item);
            }

            var GetsquarEvenNumbers = Numbers.Where(n => n % 2 == 0).Select(x => x * x);
            Console.WriteLine("\n");
            foreach (int item in GetsquarEvenNumbers)
            {
                Console.Write(item + " ");
            }
        }

        static void UnionWith()
        {
            SortedSet<int> set1 = new SortedSet<int> { 1, 2, 3};
            SortedSet<int> set2 = new SortedSet<int> { 3, 4, 5};

            Console.WriteLine("\nUnion\n");
            set1.UnionWith(set2);
            foreach(int item in set1)
            {
                Console.WriteLine(item);
            }
        }

        static void IntersectWith()
        {
            SortedSet<int> set1 = new SortedSet<int> { 1, 2, 3 };
            SortedSet<int> set2 = new SortedSet<int> { 3, 4, 5 };

            Console.WriteLine("\nintersection\n");
            set1.IntersectWith(set2);
            foreach (int item in set1)
            {
                Console.WriteLine(item);
            }
        }

        static void ExpectWith()
        {
            SortedSet<int> set1 = new SortedSet<int> { 1, 2, 3 };
            SortedSet<int> set2 = new SortedSet<int> { 3, 4, 5 };

            Console.WriteLine("\nExpectWith\n");
            set1.ExceptWith(set2);
            foreach (int item in set1)
            {
                Console.WriteLine(item);
            }
        }

        static void IsSubset()
        {
            SortedSet<int> set1 = new SortedSet<int> { 1, 2, 3 };
            SortedSet<int> set2 = new SortedSet<int> { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("Is set1 Subset of set2 : " + set1.IsSubsetOf(set2));
            Console.WriteLine("Is set1 superset of set2 : " + set1.IsSupersetOf(set2));
            Console.WriteLine("Is set1 equal set2 : " + set1.SetEquals(set2));
        }

        static void SortDictionary()
        {
            SortedDictionary<string, int> sortDictionary = new SortedDictionary<string, int>();

            sortDictionary.Add("Apple", 10);
            sortDictionary.Add("Date", 15);
            sortDictionary.Add("Banana", 20);
            sortDictionary.Add("Watermellon", 70);

            Console.WriteLine("\nPrint\n");
            foreach(var item in sortDictionary)
            {
                Console.WriteLine("The Key : " + item.Key + "The value : " + item.Value);
            }

            Console.WriteLine(sortDictionary["Apple"]);
            Console.WriteLine(sortDictionary.ContainsKey("Apple"));
            Console.WriteLine(sortDictionary.ContainsValue(12));

            sortDictionary.Remove("Apple");

            foreach (var item in sortDictionary)
            {
                Console.WriteLine("The Key : " + item.Key + "The value : " + item.Value);
            }
        }

        static void ArrayList()
        {
            ArrayList ArrayList = new ArrayList();

            ArrayList.Add(10);
            ArrayList.Add("Saddam");
            ArrayList.Add(true);

            foreach(var item in ArrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n");
            ArrayList.Remove(10);

            foreach (var item in ArrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("The Count of ArrayList : " + ArrayList.Count);
        }

        static void EvenArray()
        {
            ArrayList ArrayList2 = new ArrayList() { 6, 7, 8, 9,1, 2, 3, 4, 5,  };

            for (int i = 0; i < ArrayList2.Count; i++)
            {
                Console.Write(ArrayList2[i] + " ");
            }

            Console.WriteLine("\n\n");

            var evenNumber = ArrayList2.Cast<int>().Where(n => n % 2 == 0);
            ArrayList2.Sort();
            foreach (int item in evenNumber)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("Min Number : " + ArrayList2.Cast<int>().Min());
            Console.WriteLine("Max Number : " + ArrayList2.Cast<int>().Max());
            Console.WriteLine("Count of Number : " + ArrayList2.Cast<int>().Count());
            Console.WriteLine("AVg Number : " + ArrayList2.Cast<int>().Average());

        }

        static void ObserveableCollection()
        {
            ObservableCollection<string> names = new ObservableCollection<string>();
            names.CollectionChanged += Item_CollectionChange;
            names.Add("Saddam");
            names.Add("Ali");
            names.Add("Hussein");
            names.Add("Sharaf");
            names.Add("Ahmmed");
            names.Add("AbdoAlrab");

            names.Remove("AbdoAlrab");


            names.Insert(0, "Sosoooo");
            names[1] = "Totoooo";
            names.Move(0, 1);

        }

        static void Stack()
        {
            Stack<int> Stack = new Stack<int>();

            Stack.Push(1);
            Stack.Push(12);
            Stack.Push(13);
            Stack.Push(14);

            Stack.Pop();

            foreach(int num in Stack)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(Stack.Peek());

        }

        static void Queue()
        {
            Queue<int> Queue = new Queue<int>();

            Queue.Enqueue(1);
            Queue.Enqueue(12);
            Queue.Enqueue(13);
            Queue.Enqueue(14);

            Queue.Dequeue();

            foreach (int num in Queue)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(Queue.Peek());

            if(Queue.Count == 0)
            {
                Console.WriteLine("The Queue is empty");
            }else
            {
                Console.WriteLine("The Count Of Queue : " + Queue.Count);
            }
        }

        static void LinkedList()
        {
            LinkedList<int> LinkedList = new LinkedList<int>();

            LinkedList.AddLast(1);
            LinkedList.AddLast(10);
            LinkedList.AddLast(20);
            LinkedList.AddLast(30);

            LinkedList.Remove(1);

            foreach(int num in LinkedList)
            {
                Console.WriteLine(num + " ");
            }

        }

        static void Array()
        {
            int[] Numbers = {1, 2,3 ,4};

            string[] Names = { "Ali", "Ala", "Feras" };

            foreach(string item in Names)
            {
                Console.WriteLine(item + " ");
            }

        } 
        static void Main(string[] args)
        {
            Array();

            Console.ReadKey();
        }

        static void Item_CollectionChange(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch(e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    Console.WriteLine("Added:");
                    foreach(var item in e.NewItems)
                    {
                        Console.WriteLine("- " + item);
                    }
                    break;

                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("Remove:");
                    foreach (var item in e.OldItems)
                    {
                        Console.WriteLine("- " + item);
                    }
                    break;

                case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
                    Console.WriteLine("Move:");
                    foreach (var item in e.NewItems)
                    {
                        Console.WriteLine("- " + item);
                    }
                    break;
            }
        }

    }
}
