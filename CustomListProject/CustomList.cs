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
        public int capacity;
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
            if(count == capacity)
            {
                //resize
            }
            _items[count] = firstItem;
            count++;
        }
    }
}
