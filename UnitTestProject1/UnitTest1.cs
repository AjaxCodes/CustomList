using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddOneValueToList_CountWillEqualOne()
        {
            //arrange
            MyCustomLists<int> testList = new MyCustomLists<int>();
            int value1 = 8;
            int expectedvalue = 1;
            int actualValue = testList.Count;


            //act
            testList.Add(value1);


            //assert
            Assert.AreEqual(expectedvalue, actualValue);

        }
    }[TestMethod]
    public void Add_AddOneValueToList_CapacityIs()
    {
        //arrange
        MyCustomLists<int> testList = new MyCustomLists<int>();
        int value1 = 1;
        int expectedvalue = 1;
        int actualValue = testList.Capacity;


        //act
        testList.Add(value1);


        //assert
        Assert.AreEqual(expectedvalue, actualValue);

    }
    [TestMethod]
    public void AddOneValueToList_Indexer() 
    {
        MyCustomLists<int> testList = new MyCustomLists<int>(0);
        Index[1];
        int expectedValue = 1;
        int actualValue;

        // act
        MyCustomList<int> i = [i];


        Assert.AreEqual(expectedValue, actualValue);



    
    
    
    }
}
