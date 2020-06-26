using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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
        {
            bool foundValue = false;
            for (int i = 0; i < count; i++)
            {

                if (items[i].Equals(value))
                {
                    foundValue = true;
                    // if (i != capacity - 1) // if we're not on the last iteration 
                    if (!(i == capacity - 1)) // if we're not on the last iteration 
                    {
                        items[i] = items[i + 1];
                    }

                }
                else if (i == count - 1)
                {

                }
                else if (foundValue == true)
                {
                    items[i] = items[i + 1];
                }
                //0. locating the item
                // if the item is actually in the array...
                //1. remove an item from items array
                //2. code shifts all items following index back by one
                //3. if index withing boundries(4,8,16,32 ect) then subtract 1 from index move everything to the left,
            }
            if (foundValue)
            {
                count--;
            }

        }
        public override string ToString()
        {
            string listAsAString = "";

            for (int i = 0; i < count; i++)
            {
                listAsAString += items[i].ToString();
                // listAsAString = listAsAString + items[i].ToString();
            }

            return listAsAString;
        }

        public void AddTwoLists(CustomList<T> oddsList, CustomList<T> evenList)
        {
            List<int> odds;
            List<int> evens;
            string result = " ";

            oddsList = new List<int>() { 1, 3, 5 };
            evenList = new List<int>() { 2, 4, 6 };
            int numbers = new List<int>();

           for (int i = 0; i < count; i++) 
           {

             numbers = odds.Count[i] + evens.Count[i];

           }
            return result;

        }

            
       

            //List<int> result = evens + odds;
            //result has 1,3,5,2,4,6
            // Overload + operator to add two Box objects.
       
    }





}
        

    
                
                
                
           


