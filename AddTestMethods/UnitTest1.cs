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

        //[TestMethod]
        //public void AddTwoItemsToList_GetCompacity()
        //{

        //}

        //[TestMethod]
        //public void AddTwoItemsToList_GetIndex()
        //{

        //}
    }
    
}
