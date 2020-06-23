using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public CustomList()
        {
            capacity = 4;
            T temporary;


        }
        // 1.add item to next available index of items array
        //2. if there is no available index, then create a new array and double capacity
        //3. copy values from items array to our newly created array that has the doubled capacity ****
        //3b. update reference of member variable items array
        //4. add item to next available index
         public void Add(T value)
         {
            if (capacity == count)
            {
                T[] tempArray = new T[capacity *= 2];

                for (int index = 0; index < count; index++)
                {
                    tempArray[index] = items[index];
                }

                items = tempArray;
           
            
            }
            items[count] = value;
            count++;

         }



            

    }

}      
                
                
                
           


