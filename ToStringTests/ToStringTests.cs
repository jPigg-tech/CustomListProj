using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListProject;

namespace ToStringTests
{
    [TestClass]
    public class ToStringTests
    {
        [TestMethod]
        public void ReturnsOneIntInToAString()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            string expected = "1992";
            int actual;
            int value1 = 1992;


            // Act

            testList.Add(value1);
            actual = testList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // Add multiple ints to a list, return them as a string
        [TestMethod]
        public void ReturnsMultipleIntsInToAString()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            string expected = "2020, 2021";
            int actual;
            int value1 = 2020;
            int value2 = 2021;


            // Act

            testList.Add(value1);
            testList.Add(value2);
            actual = testList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
