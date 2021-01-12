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
        [TestMethod]
        public void CreateTwoListsOfInts_AddTheListsTogether_PreserveOriginalLists()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();

            CustomList<int> expected = new CustomList<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(4);

            CustomList<int> actual = new CustomList<int>();

            // Act
            list1.Add(1);
            list1.Add(2);

            list2.Add(3);
            list2.Add(4);

            actual = list1 + list2;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        public void CreateTwoListsOfChars_AddTheListsTogether_PreserveOriginalLists()
        {
            // Arrange
            CustomList<char> list1 = new CustomList<char>();
            CustomList<char> list2 = new CustomList<char>();

            CustomList<char> expected = new CustomList<char>();
            expected.Add('J');
            expected.Add('e');
            expected.Add('f');
            expected.Add('f');

            CustomList<char> actual = new CustomList<char>();

            // Act
            list1.Add('J');
            list1.Add('e');

            list2.Add('f');
            list2.Add('f');

            actual = list1 + list2;

            // Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
