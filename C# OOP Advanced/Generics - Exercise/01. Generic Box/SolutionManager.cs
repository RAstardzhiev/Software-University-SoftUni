namespace _01.Generic_Box
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class SolutionManager
    {
        internal static void GenericCountMethodDoubles()
        {
            var numberOfDoubles = double.Parse(Console.ReadLine());
            var listOfDoubles = new Stack<Box<double>>();

            while (numberOfDoubles > 0)
            {
                var value = double.Parse(Console.ReadLine());
                listOfDoubles.Push(new Box<double>(value));

                numberOfDoubles--;
            }

            var comparisonValue = double.Parse(Console.ReadLine());
            var comparison = new Box<double>(comparisonValue);
            Console.WriteLine(CountGreaterThanComparisonValue(listOfDoubles, comparison));
        }

        internal static void GenericCountMethodStrings()
        {
            var numberOfElements = int.Parse(Console.ReadLine());
            var listOfElements = new List<Box<string>>();

            while (numberOfElements > 0)
            {
                var element = Console.ReadLine();
                listOfElements.Add(new Box<string>(element));

                numberOfElements--;
            }

            var comparison = new Box<string>(Console.ReadLine());
            Console.WriteLine(CountGreaterThanComparisonValue(listOfElements, comparison));
        }

        private static int CountGreaterThanComparisonValue<T>(IEnumerable<T> collection, T comparisonValue)
            where T : IComparable<T>
        {
            var count = 0;

            foreach (var item in collection)
            {
                if (item.CompareTo(comparisonValue) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        internal static void GenericSwapMethodIntegers()
        {
            var numberOfIntegers = int.Parse(Console.ReadLine());
            var listOfBoxes = new List<Box<int>>();

            while (numberOfIntegers > 0)
            {
                var value = int.Parse(Console.ReadLine());
                listOfBoxes.Add(new Box<int>(value));

                numberOfIntegers--;
            }

            var swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Swap(listOfBoxes, swapIndexes[0], swapIndexes[1]);
            listOfBoxes.ForEach(num => Console.WriteLine(num));
        }

        internal static void GenericSwapMethodStrings()
        {
            var numberOfStrings = int.Parse(Console.ReadLine());
            var listOfBoxes = new List<Box<string>>();

            while (numberOfStrings > 0)
            {
                var value = Console.ReadLine();
                listOfBoxes.Add(new Box<string>(value));

                numberOfStrings--;
            }

            var swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Swap(listOfBoxes, swapIndexes[0], swapIndexes[1]);
            listOfBoxes.ForEach(str => Console.WriteLine(str));
        }

        private static void Swap<T>(IList<T> collection, int indexToSwap, int swapWithIndex)
        {
            var temp = collection[indexToSwap];
            collection[indexToSwap] = collection[swapWithIndex];
            collection[swapWithIndex] = temp;
        }

        internal static void GenericBoxOfInteger()
        {
            var numberOfIntegers = int.Parse(Console.ReadLine());

            while (numberOfIntegers > 0)
            {
                var num = int.Parse(Console.ReadLine());
                Console.WriteLine(new Box<int>(num));

                numberOfIntegers--;
            }
        }

        internal static void GenericBoxOfString()
        {
            var numberOfStrings = int.Parse(Console.ReadLine());

            while (numberOfStrings > 0)
            {
                Console.WriteLine(new Box<string>(Console.ReadLine()));

                numberOfStrings--;
            }
        }

        internal static void GenericBox()
        {
            var box = new Box<int>();
            box.Value = 12313;
            Console.WriteLine(box);

            var stringBox = new Box<string>();
            stringBox.Value = "life in a box";
            Console.WriteLine(stringBox);
        }
    }
}
