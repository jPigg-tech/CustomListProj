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

        
    }
}
