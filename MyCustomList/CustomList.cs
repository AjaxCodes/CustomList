using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyCustomList
{
    public class CustomList<T>
    {
        //int[] numbers = new int[5];

        //underlying array that stores list values
        private T[] items = new T[4];

        //count that can be set privately
        private int count;

        //count property that can be read publicly
        public int Count { get { return count; } }

        // Capacity Property - public
        private int capacity;

        public int Capacity { get { return capacity; } set { capacity = value; } }

        public void Add(T item)
        {

        }
        public void Remove(T item)
        {

        }


    }
}
