using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;
namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddOneValueToList_CountWillEqualOne()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 1;
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
            CustomList<int> testList = new CustomList<int>();
            int valueOne = 1;
            int expectedvalue = 4;
            int actualValue = testList.Capacity;

            //act
            testList.Add(valueOne);

            //assert
            Assert.AreEqual(expectedvalue, actualValue);

        }



        [TestMethod]
        public void Add_AddMultipleValuesToList_CapacityIs()
        {
            //arrange

            CustomList<int> testList = new CustomList<int>();
            int valueOne = 1;
            int valueTwo = 2;
            int valueThree = 3;
            int valueFour = 4;
            int valueFive = 5;
            int expectedvalue = 8;
            int actualValue = testList.Capacity;

            //act
            testList.Add(valueOne);
            testList.Add(valueTwo);
            testList.Add(valueThree);
            testList.Add(valueFour);
            testList.Add(valueFive);

            //assert
            Assert.AreEqual(expectedvalue, actualValue);

        }



        [TestMethod]
        public void AddOneValueToList_Indexer()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expectedValue = 8;
            int actualValue = testList[0];

            //act
            testList.Add(8);


            //Assert
            Assert.AreEqual(expectedValue, actualValue);

        }



        [TestMethod]
        public void UnderlyingArray()
        {

            CustomList<int> testList = new CustomList<int>();
            int valueOne = 1;
            int valueTwo = 2;
            int valueThree = 3;
            int valueFour = 4;
            int valueFive = 5;
            int expectedvalue = 1;

            //act
            testList.Add(valueOne);
            testList.Add(valueTwo);
            testList.Add(valueThree);
            testList.Add(valueFour);
            testList.Add(valueFive);

            int actualValue = testList[0];
            //assert
            Assert.AreEqual(expectedvalue, actualValue);


        }
    }
}
