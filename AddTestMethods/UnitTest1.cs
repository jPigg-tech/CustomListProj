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
        //create a list add 5 items, check capacity, should be 8
        //add one value, check the first index of the list.  should be the value added

    }
    
}
