using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerator<T>
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
                    ResizeArray(count);
                    // throw new Exception("Capacity cannot be lower than count");
                }
                else
                {
                    ResizeArray(Capacity);
                }
            }
        }
        private T[] _items;
        public T this[int i]
        {
            get
            {
                if (i >= 0 && i < count)
                {
                    return _items[i];
                }
                throw new ArgumentOutOfRangeException();
            }
            set 
            {
                if (i >= 0 && i < count)
                {
                    _items[i] = value;
                }
                throw new ArgumentOutOfRangeException();
            }
            // If statement to ensure out-of-bounds index doesnt happen
        }

        // Constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            _items = new T[capacity];
        }

        // Methods 
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

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

        public void Remove(T value)
        {
            // make sure correct value is being removed 
            // make sure the index updates after the item is removed 
            // make sure the count updates when the item is removed 
            for (int i = 0; i < count; i++)
            {
                if (_items[i].Equals(value) && i != count - 1)
                {
                    _items[i] = _items[i + 1];
                    // _items[i] = null;
                }
                else
                {
                    _items[i] = default;
                }
            }
            count--;
        }
        public override string ToString()
        {
            string printMembers = "";

            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    printMembers += _items[i].ToString();
                }
            }
            return printMembers;
        }
       
    }
}
