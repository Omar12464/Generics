using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics1
{
    internal class FixedSize<T>
    {
        private T[] items;
        private int count;

        public int Capacity { get; private set; }
        public int Count { get { return count; } }

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                Console.WriteLine(nameof(capacity), "Capacity must be greater than zero.");
            }

            Capacity = capacity;
            items = new T[Capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (count >= Capacity)
            {
                Console.WriteLine("List is already full.");
            }

            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                Console.WriteLine(nameof(index), "Invalid index.");
            }

            return items[index];
        }
    }
}
