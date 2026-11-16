using System;
using System.Collections.Generic;
using System.Collections;
namespace IListCollection
{
    class program
    {
        public class IlistCollection<T> : IList<T>
        {
            private List<T> _items = new List<T>();
            public T this[int index]
            {
                get => _items[index];
                set => _items[index] = value;
            }

            public int Count => _items.Count;
            public bool IsReadOnly => false;
            public void Add(T item) => _items.Add(item);
            public bool Remove(T item) => _items.Remove(item);
            public void Clear() => _items.Clear();
            public bool Contains(T item) => _items.Contains(item);
            public int IndexOf(T item) => _items.IndexOf(item);
            public void Insert(int index, T item) => _items[index] = item;
            public void RemoveAt(int index) => _items.RemoveAt(index);
            public void CopyTo(T[] array, int index) => _items.CopyTo(array, index);
            public IEnumerator<T> GetEnumerator() => _items.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => _items.GetEnumerator();
        }

        static void Main()
        {
            IlistCollection<string> Ilist = new IlistCollection<string>();

            Ilist.Add("Ali 1");
            Ilist.Add("Ali 2");
            Ilist.Add("Ali 3");
            Ilist.Add("Ali 4");

            Ilist[3] = "Saddam";
            
            foreach(string item in Ilist)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}