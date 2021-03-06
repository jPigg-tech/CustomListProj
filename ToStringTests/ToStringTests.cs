﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            string actual;
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
            string expected = "20202021";
            string actual;
            int value1 = 2020;//[2020, 2021] "2020, 2021"
            int value2 = 2021;

            // Act
            testList.Add(value1);
            testList.Add(value2);
            actual = testList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // Add multiple chars to a list, return them as a string
        [TestMethod]
        public void AddMultipleCharsToAList_ReturnThemAsAString()
        {
            // Arrange
            CustomList<char> testList = new CustomList<char>();
            string expected = "Jeff";
            string actual;
            char value1 = 'J';
            char value2 = 'e';
            char value3 = 'f';
            char value4 = 'f';

            // Act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Add(value4);
            actual = testList.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }        
    }
}
