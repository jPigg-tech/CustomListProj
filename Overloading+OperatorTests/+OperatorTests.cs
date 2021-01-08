using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListProject;

namespace Overloading_OperatorTests
{
    [TestClass]
    public class UnitTest1
    {
        // Add two lists of any type and preserve the original lists.
        [TestMethod]
        public void CreateTwoListsOfStrings_AddTheListsTogether_PreserveOriginalLists()
        {
            // Arrange
            CustomList<string> list1 = new CustomList<string> { "1, 2, " };
            CustomList<string> list2 = new CustomList<string> { "3, 4" };

            string expected = "1, 2, 3, 4";
            string actual;

            // Act

            foreach (string value in list1 + list2)
            {
                actual = (value + ", ");
            }
                             
            // Assert
            Assert.AreEqual(expected, actual);
        }

           
    }
}
