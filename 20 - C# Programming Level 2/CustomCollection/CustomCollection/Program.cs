using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CustomCollection
{
    class program
    {
        public class CustomCollection<T> : ICollection<T>
        {
            private List<T> _items = new List<T>();

            public int Count => _items.Count;
            public bool IsReadOnly => false;
            public void Add(T item)
            {
                _items.Add(item);
            }
            public bool Remove(T item)
            {
                return _items.Remove(item);
            }
            public void Clear() { _items.Clear(); }
            public bool Contains(T item)
            {
                return _items.Contains(item);
            }
            public void CopyTo(T[] array, int arrayIndex)
            {
                _items.CopyTo(array, arrayIndex);
            }
            public IEnumerator<T> GetEnumerator()
            {
                return _items.GetEnumerator();
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        static void Main()
        {
            CustomCollection<string> ShoppingCart = new CustomCollection<string>();

            ShoppingCart.Add("Apple");
            ShoppingCart.Add("Date");
            ShoppingCart.Add("Banana");
            ShoppingCart.Add("Carrot");

            if(ShoppingCart.Contains("Apple"))
            {
                ShoppingCart.Remove("Apple");
                Console.WriteLine("Apple removed from the cart.");
            }

            foreach(var item in ShoppingCart)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}