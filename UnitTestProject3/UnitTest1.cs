using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
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


            //act
            testList.Add(valueOne);
            testList.Add(valueTwo);
            testList.Add(valueThree);
            testList.Add(valueFour);
            testList.Add(valueFive);
            int actualValue = testList.Capacity;

            //assert
            Assert.AreEqual(expectedvalue, actualValue);

        }



        [TestMethod]
        public void AddOneValueToList_Indexer()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expectedValue = 0;
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
        [TestMethod]
        public void RemovingfromTheList()
        {
            CustomList<int> testList = new CustomList<int>();
            int valueOne = 1;
            int valueTwo = 2;
            int valueThree = 3;
            int valueFour = 4;
            int expectedvalue = 3;

            //act
            testList.Add(valueOne);
            testList.Add(valueTwo);
            testList.Add(valueThree);
            testList.Add(valueFour);
            testList.Remove(valueThree);
            int actualValue = testList.Count;


            //assert
            Assert.AreEqual(expectedvalue, actualValue);
        }
        [TestMethod]

        public void Remove_AValueFromList_RemovedValue()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int valueOne = 1;
            int valueTwo = 2;
            int valueThree = 3;
            int expectedvalue = 0;

            //act
            testList.Add(valueOne);
            testList.Add(valueTwo);
            testList.Add(valueThree);
            testList.Remove(valueTwo);
            testList.Remove(valueOne);
            testList.Remove(valueThree);
            int actualValue = testList.Count;

            //assert
            Assert.AreEqual(expectedvalue, actualValue);
        }
        [TestMethod]
        public void RemoveMultipuleValues()
        {
            CustomList<int> testList = new CustomList<int>();
            int valueOne = 1;
            int valueThree = 3;
            int valueFive = 5;
            int valueTwo = 2;
            int valueFour = 4;
            int expectedvalue = 4;
            int actualValue = testList.Capacity;

            //act
            testList.Add(valueOne);
            testList.Add(valueTwo);
            testList.Add(valueThree);
            testList.Add(valueFour);
            testList.Add(valueFive);

            testList.Remove(valueOne);
            testList.Remove(valueThree);
            testList.Remove(valueFive);

            //assert
            Assert.AreEqual(expectedvalue, actualValue);
        }
        [TestMethod]
        public void RemoveCheckingIndex()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();

            // expected index
            //actual index
            int valueOne = 1;
            int valueThree = 3;
            int valueFive = 5;
            int valueTwo = 2;
            int valueFour = 4;

            int expectedValue = 4;


            //act
            testList.Add(valueOne);
            testList.Add(valueTwo);
            testList.Add(valueThree);
            testList.Add(valueFour);
            testList.Add(valueFive);
            testList.Remove(2);
            int actualValue = testList[2];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Remove_MultipleValesToList_CapacityIs()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int valueOne = 1;
            int valueTwo = 2;
            int valueThree = 3;
            int valueFour = 4;
            int valueFive = 5;
            int expectedValue = 4;

            //Act
            testList.Add(valueOne);
            testList.Add(valueTwo);
            testList.Add(valueThree);
            testList.Add(valueFour);
            testList.Add(valueFive);

            testList.Remove(valueTwo);
            int actualValue = testList[2];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);

        }


        [TestMethod]
        public void ConvertToStringTest1()
        {

            //Arrange
            CustomList<int> testList = new CustomList<int>();

            int valueOne = 1;
            int valueTwo = 2;
            int valueThree = 3;

            string expectedValue = "123";
            string actualValue;

            //Act

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            actualValue = testList.ToString();


            //Assert
            Assert.AreEqual(expectedValue, actualValue);

        }


        [TestMethod]
        public void ConvertToStringTest2()
        {

            //Arrange
            CustomList<int> testList = new CustomList<int>();

            int valueOne = 1;
            int valueTwo = 2;
            int valueThree = 3;
            int valueFour = 4;
            int valueFive = 5;

            string expectedValue = "12345";
            string actualValue;

            //Act

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            actualValue = testList.ToString();


            //Assert
            Assert.AreEqual(expectedValue, actualValue);


        }


        [TestMethod]
        public void ConvertToStringTest3()
        {

            //Arrange
            CustomList<int> testList = new CustomList<int>();

            string expectedValue = " ";
            string actualValue;

            //Act
            actualValue = testList.ToString();


            //Assert
            Assert.AreEqual(expectedValue, actualValue);

        }

    }

}

