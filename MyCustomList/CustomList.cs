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

        //CustomList<int> numbers = new CustomList<int>();
        //numbers.Add(2);
        //numbers[0]

        public T this[int index]
        {
            get
            {
                //if statements
                if (index >= 0 && index < count) 
                {
                    return items[index];
                }
                return items[index];
                
            }
            set
            {
                items[index] = value;
            }
        }

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
        

        public void Remove(T value)
        {                              //index 0  1  2  3  4
            bool foundValue = false;
            for(int i = 0; i < count; i++)
            {
                //value
                //items
                

                if (items[i].Equals(value))
                {
                    foundValue = true;
                    items[i] = items[i + 1];
                }
                else if ( i == count - 1)
                {
                    T[] temporaryArray = new T[capacity];
                }
                else if (foundValue == true)
                {
                    items[i] = items[i + 1];
                }
                //else if (capacity = items[] && foundValue = true)
                //{
                //    break;
                //}

            }
            
            

            //T[] temporaryArray = new T[capacity];
                  
            ////items[count] = value;
            //for (int i = 0; i < count; i--)
            //{
            //    temporaryArray[i] = items[i];
            //}

            //if (count <= capacity)       
            //{

            //    for (int i = 0; i < count; i--)
            //    {
            //        items[i] = items[i + 1];
            //       //  shifting index over
            //    }
            //}


            //0. locating the item
            // if the item is actually in the array...
                //1. remove an item from items array
                //2. code shifts all items following index back by one
                //3. if index withing boundries(4,8,16,32 ect) then subtract 1 from index move everything to the left,
        }



            

    }

}      
                
                
                
           


