using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BashSoft.Contracts;
using BashSoft.DataStructures;
using System.Collections.Generic;

namespace BashSoft.Tests
{
    [TestClass]
    public class OrderedDataStructureTester
    {
        private ISimpleOrderedBag<string> names;

        [TestInitialize]
        public void SetUp()
        {
            this.names = new SimpleSortedList<string>();
        }

        [TestMethod]
        public void TestEmptyCtor()
        {
            // Assert
            Assert.AreEqual(16, this.names.Capacity, "Initial capacity have to be 16");
            Assert.AreEqual(0, this.names.Size, "Initial size have to be 0");
        }

        [TestMethod]
        public void TestCtorWithInitialCapacity()
        {
            // Arrange
            this.names = new SimpleSortedList<string>(20);

            // Assert
            Assert.AreEqual(20, this.names.Capacity, "Capacity must be equal to the provided one");
            Assert.AreEqual(0, this.names.Size, "Initial size have to be 0");
        }

        [TestMethod]
        public void TestCtorWithAllParams()
        {
            // Arrange
            this.names = new SimpleSortedList<string>(30, StringComparer.OrdinalIgnoreCase);

            // Assert
            Assert.AreEqual(30, this.names.Capacity, "Capacity must be equal to the provided one");
            Assert.AreEqual(0, this.names.Size, "Initial size have to be 0");
        }

        [TestMethod]
        public void TestCtorWithInitialComparer()
        {
            // Arrange
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase);

            // Assert
            Assert.AreEqual(16, this.names.Capacity, "Initial capacity have to be 16");
            Assert.AreEqual(0, this.names.Size, "Initial size have to be 0");
        }

        [TestMethod]
        public void AddIncreasesSize()
        {
            // Act
            this.names.Add("Name");

            // Assert
            Assert.AreEqual(1, this.names.Size, "Add didn't change the size");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNullIsNotPossible()
        {
            // Act 
            this.names.Add(null);
        }

        [TestMethod]
        public void AddElementsMustSortThemAutomatically()
        {
            // Act
            this.names.Add("Rosen");
            this.names.Add("Georgi");
            this.names.Add("Balkan");

            // Assert
            Assert.AreEqual("Balkan", this.names[0], "Elements are not sorted");
            Assert.AreEqual("Georgi", this.names[1], "Elements are not sorted");
            Assert.AreEqual("Rosen", this.names[2], "Elements are not sorted");
        }

        [TestMethod]
        public void AddElementsMoreThanCapacityMustHaveCorrectSize()
        {
            // Arrange
            int expectedSize = 20;

            // Act
            for (int i = 0; i < expectedSize; i++)
            {
                this.names.Add($"Name {i}");
            }

            // Assert
            Assert.AreEqual(expectedSize, this.names.Size, $"Size must be {expectedSize}");
        }

        [TestMethod]
        public void AddElementsMoreThanCapacityMustHaveCorrectCapacity()
        {
            // Act
            for (int i = 0; i < 20; i++)
            {
                this.names.Add($"Name {i}");
            }

            // Assert
            Assert.AreEqual(32, this.names.Capacity, "Capacity must be 32");
        }

        [TestMethod]
        public void AddAllMustSaveAllTheGivenElements()
        {
            // Arrange
            List<string> collecion = new List<string>()
            {
                "First",
                "Second"
            };

            // Act
            this.names.AddAll(collecion);

            // Assert
            Assert.AreEqual(2, this.names.Size, "Not all elements are stored");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddAllCanNotWorkWithNull()
        {
            // Act
            this.names.AddAll(null);
        }

        [TestMethod]
        public void AddAllStoresTheElementInSortedOrder()
        {
            // Arrange
            List<string> collection = new List<string>()
            {
                "Rosen",
                "Georgi",
                "Balkan"
            };

            // Act
            this.names.AddAll(collection);

            // Assert
            Assert.AreEqual("Balkan", this.names[0], "Elements are not sorted");
            Assert.AreEqual("Georgi", this.names[1], "Elements are not sorted");
            Assert.AreEqual("Rosen", this.names[2], "Elements are not sorted");
        }

        [TestMethod]
        public void RemoveShouldDecresaseTheSize()
        {
            // Arrange
            this.names.AddAll(new string[] { "Rosen", "Georgi", "Balkan" });

            // Act
            this.names.Remove("Georgi");

            // Assert
            Assert.AreEqual(2, this.names.Size, "Size is not decreased after removing an element");
        }

        [TestMethod]
        public void RemoveShouldTheExactOneSpecified()
        {
            // Arrange
            this.names.AddAll(new string[] { "1", "2", "3" });

            // Act
            this.names.Remove("2");

            // Assert
            Assert.AreEqual("1", this.names[0], "Removed element is wrong");
            Assert.AreEqual("3", this.names[1], "Removed element is wrong");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveCannotWorkWithNull()
        {
            // Arrange
            this.names.AddAll(new string[] { "1", "2", "3" });

            // Act
            this.names.Remove(null);
        }

        [TestMethod]
        public void JoinWithShouldReturnAllElementsWithTheJoinerBetweenThem()
        {
            // Arrange
            this.names.AddAll(new string[] { "1", "2", "3" });

            // Assert
            Assert.AreEqual("1, 2, 3", this.names.JoinWith(", "), "Elements are not joined correctly");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void JoinWithCannotWorkWithNull()
        {
            // Arrange
            this.names.AddAll(new string[] { "1", "2", "3" });

            // Act
            this.names.JoinWith(null);
        }
    }
}
