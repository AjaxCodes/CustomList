using System;
using System.Collections.Generic;
using System.Text;

namespace CustomListProjectGroup
{
    class MyCustomLists
    {
        List<int> mylists = new List<int>();
        int valueOne = 1;
        int valueTwo = 2;
        int valueThree = 3;
        int valueFour = 4;
        
        mylists.Add(valueOne);
        mylists.Add(valueTwo);
        mylists.Add(valueThree);

        mylists[2] = 7;
        int seven = mylists[2];
    }
}
