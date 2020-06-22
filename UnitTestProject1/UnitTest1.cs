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



            //act
            testList.Add(value1);
            int actualValue = testList.Count;

            //assert
            Assert.AreEqual(expectedvalue, actualValue);

        }
        [TestMethod]
        public void Add_AddOneValueToList_CapacityIs()
        {
            //arrange
            MyCustomLists<int> testList = new MyCustomLists<int>();
            int value1 = 1;
            int expectedvalue = 4;
            int actualValue = testList.Capacity;


            //act
            testList.Add(value1);


            //assert
            Assert.AreEqual(expectedvalue, actualValue);

        }
        [TestMethod]
        public void AddOneValueToList_Indexer()
        {
            MyCustomLists<int> testList = new MyCustomLists<int>();

            testList.Add(8);
            int expectedValue = 8;
            int actualValue = testList[0];

            //Assert

            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void UnderlyingArray()
        {
            //Arrange
            MyCustomLists<int> testList = new MyCustomLists<int>();

            int expectedValue;
            int actualValue;
            int[] x;

            //Assret

            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void TestCompareLists() 
        {

        
        
        
        
        
        }










    }   







}
