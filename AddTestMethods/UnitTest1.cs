using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListProject;

namespace AddTestMethods
{
    [TestClass]
    public class CustomListClassTests
    {
        [TestMethod]
        public void AddOneItemToList_GetCount()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;
            int value1 = 5;

            // Act
            testList.Add(value1);
            actual = testList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //add multiple values, count increases
        [TestMethod]
        public void AddMultipleVariablesToList_GetCount()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;
            int actual;
            int value1 = 5;
            int value2 = 7;
            int value3 = 10;

            // Act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            actual = testList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //create a list check capacity, should be 4
        [TestMethod]
        public void CreateAList_GetCapacity()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;            

            // Act           
            actual = testList.capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //create a list add 5 items, check capacity, should be 8
        [TestMethod]
        public void CreateAList_Add5Items_GetCapacity()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 8;
            int actual;
            int value1 = 5;
            int value2 = 7;
            int value3 = 10;
            int value4 = 15;
            int value5 = 23;

            // Act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Add(value4);
            testList.Add(value5);
            actual = testList.capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        //add one value, check the first index of the list.  should be the value added
        [TestMethod]
        public void CreateAList_AddOneItem_CheckIndex()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 28;
            int actual;
            int value1 = 28;           

            // Act
            testList.Add(value1);
            actual = testList[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
    
}
