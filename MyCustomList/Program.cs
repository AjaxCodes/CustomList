using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>();
            //numbers.Count = 100;

            CustomList<int> customList = new CustomList<int>();
            customList.Add(2);
            customList.Add(4);
        }
    }
}
