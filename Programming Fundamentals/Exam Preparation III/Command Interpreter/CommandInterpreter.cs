namespace Command_Interpreter
{
    using System;
    using System.Linq;

    public class CommandInterpreter
    {
        public static void Main(string[] args)
        {
            string[] collection = Console.ReadLine()
                .Trim()
                .Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Trim()
                    .Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (command[0].Equals("end"))
                {
                    break;
                }

                switch (command[0])
                {
                    case "reverse":
                        collection = Reverse(collection, int.Parse(command[2]), int.Parse(command[4]));
                        break;
                    case "sort":
                        collection = Sort(collection, int.Parse(command[2]), int.Parse(command[4]));
                        break;
                    case "rollLeft":
                        RollLeft(collection, int.Parse(command[1]));
                        break;
                    case "rollRight":
                        RollRight(collection, int.Parse(command[1]));
                        break;
                }
            }

            Console.WriteLine("[" + string.Join(", ", collection) + "]");
        }

        private static void RollRight(string[] collection, int moveCount)
        {
            /*
             * "rollRight [count] times" – this instructs you to move all elements in the array to the right [count] times. 
             * On each roll, the last element is placed at the beginning of the array;
             */
            if (moveCount < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            moveCount %= collection.Length;

            for (int repetitions = 0; repetitions < moveCount; repetitions++)
            {
                string lastStr = collection.Last();
                for (int i = collection.Length - 2; i >= 0; i--)
                {
                    collection[i + 1] = collection[i];
                }

                collection[0] = lastStr;
            }
        }

        private static void RollLeft(string[] collection, int moveCount)
        {
            /*
             * "rollLeft [count] times" – this instructs you to move all elements in the array to the left [count] times. 
             * On each roll, the first element is placed at the end of the array;
             */

            if (moveCount < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            moveCount %= collection.Length;

            for (int repetitions = 0; repetitions < moveCount; repetitions++)
            {
                string firstStr = collection[0];
                for (int i = 1; i < collection.Length; i++)
                {
                    collection[i - 1] = collection[i];
                }

                collection[collection.Length - 1] = firstStr;
            }
        }

        private static string[] Sort(string[] collection, int startIndex, int count)
        {
            /*
             * "sort from [start] count [count]" – this instructs you to sort a portion of the array - 
             * [count] elements starting at index [start];
             */
            if (IsValid(collection.Length, startIndex, count))
            {
                return collection
                .Take(startIndex)
                .Concat(collection.Skip(startIndex).Take(count).OrderBy(s => s))
                .Concat(collection.Skip(startIndex + count))
                .ToArray();
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
                return collection;
            }
        }

        private static string[] Reverse(string[] collection, int startIndex, int count)
        {
            /* 
             * "reverse from [start] count [count]" – this instructs you to reverse a portion of the array – 
             * just [count] elements starting at index [start];
             */
            if (IsValid(collection.Length, startIndex, count))
            {
                return collection
                .Take(startIndex)
                .Concat(collection.Skip(startIndex).Take(count).Reverse())
                .Concat(collection.Skip(startIndex + count))
                .ToArray();
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
                return collection;
            }
        }

        private static bool IsValid(int collectionLength, int startIndex, int countLength)
        {
            if (startIndex >= 0 && startIndex < collectionLength && countLength >= 0 && (startIndex + countLength) <= collectionLength)
            {
                return true;
            }

            return false;
        }
    }
}
