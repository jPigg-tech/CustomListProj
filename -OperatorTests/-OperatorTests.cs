using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListProject;

namespace _OperatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MinusOperator_CompareTwoLists_RemoveTheSharedValues()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();

            CustomList<int> expected = new CustomList<int>();
            expected.Add(7);
            expected.Add(14);            

            CustomList<int> actual = new CustomList<int>();

            // Act
            list1.Add(7);
            list1.Add(14);
            list1.Add(21);

            list2.Add(2);
            list2.Add(12);
            list2.Add(21);

            actual = list1 - list2;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOperator_CompareTwoLists_Remove()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();

            CustomList<int> expected = new CustomList<int>();
            expected.Add(7);
            expected.Add(14);
            expected.Add(21);

            CustomList<int> actual = new CustomList<int>();

            // Act
            list1.Add(7);
            list1.Add(14);
            list1.Add(21);

            actual = list1 - list2;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
