using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        // Variables 

        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }
        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (Capacity < count)
                {
                    // ResizeArray(count);
                    throw new Exception("Capacity cannot be lower than count");
                }
                else
                {
                    ResizeArray(Capacity);
                }                
            }
        }
        public int index;
        private T[] _items;

        // Constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            _items = new T[capacity];
        }

        // Methods 
        public void Add(T firstItem)
        {
            if (count == capacity)
            {
                // Copy values over then add them to the next available spot, resize
                _items = ResizeArray(capacity * 2);
            }
            _items[count] = firstItem;
            count++;
        }
        public T[] ResizeArray(int newSize)
        {
            T[] copy = new T[newSize];
            capacity = newSize;
            return ArrayCopy(copy);
        }
        public T[] ArrayCopy(T[] newArray)
        {
            for (int i = 0; i < count; i++)
            {
                newArray[i] = _items[i];
            }
            return newArray;
        }

        public void Remove(T item)
        {

        }
    }
}
