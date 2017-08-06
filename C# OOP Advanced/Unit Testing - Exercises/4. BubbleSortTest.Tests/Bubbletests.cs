namespace _4.BubbleSortTest.Tests
{
    using NUnit.Framework;
    using Bubble_Sort_Test;

    [TestFixture]
    public class BubbleTests
    {
        [Test]
        [TestCase(9, 2, 3, 4, 5, 6, 7, 8, 1)]
        [TestCase(9, 8, 7, 6, 5, 4, 3, 2, 1)]
        public void BubbleCanSortNumbers(params int[] numbersToSort)
        {
            // Arrange
            var bubble = new Bubble();
            var sortedNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Act
            bubble.Sort(numbersToSort);

            // Assert
            CollectionAssert.AreEqual(sortedNumbers, numbersToSort);
        }
    }
}
