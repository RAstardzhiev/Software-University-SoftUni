namespace _3.IteratorTest.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using NUnit.Framework;
    using Iterator_Test.Models;

    [TestFixture]
    public class ListIteratorTest
    {
        private ListIterator listIterator;
        private string[] initializingCollection;

        [SetUp]
        public void TestInit()
        {
            this.initializingCollection = new string[] { "qwe", "asd", "zxc" };
            this.listIterator = new ListIterator(this.initializingCollection);
        }

        [Test]
        public void InitializationConstructorCannotWorkWithNull()
        {
            // Arrange
            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => new ListIterator(null));
        }

        [Test]
        public void MoveReturnsTrueWhenSuccessful()
        {
            // Arrange
            // Act
            // Assert
            Assert.AreEqual(true, this.listIterator.Move());
            Assert.AreEqual(true, this.listIterator.Move());
        }

        [Test]
        public void MoveReturnsFalseWhenThereIsNoMoreElements()
        {
            // Arrange
            // Act
            this.listIterator.Move();
            this.listIterator.Move();

            // Assert
            Assert.AreEqual(false, this.listIterator.Move());
        }

        [Test]
        public void MoveMovesTheInternalIndexToTheNextElementInTheCollection()
        {
            // Arrange
            // Act
            this.listIterator.Move();
            var internalIndexValue = typeof(ListIterator)
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "currentIndex")
                .GetValue(this.listIterator);

            // Assert
            Assert.AreEqual(1, internalIndexValue, "Move doesn't influence the internal index");
        }

        [Test]
        public void HasNextReturnsTrueIfThereIsNextElement()
        {
            // Arrange
            // Act
            this.listIterator.Move();

            // Assert
            Assert.IsTrue(this.listIterator.HasNext());
        }

        [Test]
        public void HasNextReturnsFalseIfThereIsNotNextElement()
        {
            // Arrange
            // Act
            this.listIterator.Move();
            this.listIterator.Move();

            // Assert
            Assert.IsFalse(this.listIterator.HasNext());
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void PrintReturnsCurrentElement(int elementToreturn)
        {
            // Arrange
            // Act
            for (int i = 0; i < elementToreturn; i++)
            {
                this.listIterator.Move();
            }

            // Assert
            Assert.AreEqual(this.initializingCollection[elementToreturn],
                this.listIterator.Print(), 
                "Print Doesn't return correcr element");
        }

        [Test]
        public void CannotPrintWithEmptyIterator()
        {
            // Arrange
            this.listIterator = new ListIterator(new string[0]);

            // Act
            // Assert
            var ex = Assert.Throws<InvalidOperationException>(() => this.listIterator.Print());
            Assert.AreEqual("Invalid Operation!", ex.Message, "Attempting to print over empty iterator throws exception with an incorrect message");
        }
    }
}
