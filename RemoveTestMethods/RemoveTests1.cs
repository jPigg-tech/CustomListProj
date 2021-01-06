using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListProject;

namespace RemoveTestMethods
{
    [TestClass]
    public class RemoveTests1
    {
        // Remove one item get count
        [TestMethod]        
        public void CreateAListOfItems_RemoveOneItem_GetCount()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;
            int value1 = 5;
            int value2 = 10;
            int value3 = 20;

            // Act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Remove(value3);
            actual = testList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // Remove multiple items, count decreases
        [TestMethod]
        public void CreateAListOfItems_RemoveMultipleItems_GetCount()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;
            int value1 = 5;
            int value2 = 10;
            int value3 = 20;

            // Act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Remove(value3);
            testList.Remove(value2);
            actual = testList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // test to make sure the index updates
        [TestMethod]
        public void CreateAListOfItems_RemoveOneItem_CheckIfIndexUpdates()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 10;
            int actual;
            int value1 = 5;
            int value2 = 10;
            int value3 = 20;

            // Act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Remove(value1);
            actual = testList[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // if you have multiple of the same values make sure you remove the right value 
        [TestMethod]
        public void CreateAListOfItems_RemoveOneItemThatIsIdenticalToAnotherItem_CheckIfRemovesCorrectItem()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 10;
            int expected2 = 5;
            int actual;
            int actual2;
            int value1 = 5;
            int value2 = 10;
            int value3 = 20;
            int value4 = 5;

            // Act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Add(value4);
            testList.Remove(5);
            actual = testList[0];
            actual2 = testList[2];

            // Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
        }
    }
}
