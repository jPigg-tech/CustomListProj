using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListProject;

namespace RemoveTestMethods
{
    [TestClass]
    public class RemoveTests1
    {
        [TestMethod]

        // Remove one value get count
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
    }

        // Remove multiple values, count decreases
        // Create a list add 5 values, check capacity, should be 8
        // Remove one value, check if index updated
    }
}
