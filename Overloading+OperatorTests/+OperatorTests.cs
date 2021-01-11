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
            CustomList<string> list1 = new CustomList<string>();
            CustomList<string> list2 = new CustomList<string>();

            CustomList<string> expected = new CustomList<string>();
            expected.Add("1");
            expected.Add("2");
            expected.Add("3");
            expected.Add("4");

            CustomList<string> actual = new CustomList<string>();

            // Act
            list1.Add("1");
            list1.Add("2");

            list2.Add("3");
            list2.Add("4");

            actual = list1 + list2;           
                             
            // Assert
            Assert.AreEqual(expected, actual);
        }

           
    }
}
