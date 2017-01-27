namespace Sequence_of_Commands
{
    using System;
    using System.Linq;

    public class BrokenToFix
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Trim()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string[] command = Console.ReadLine().Split(ArgumentsDelimiter);

            while (!command[0].Equals("stop"))
            {
                PerformAction(array, command);
                Console.WriteLine(string.Join(" ", array));
                command = Console.ReadLine().Split(ArgumentsDelimiter);
            }
        }

        public static void PerformAction(long[] arr, string[] comand)
        {
            switch (comand[0].ToLower())
            {
                case "multiply":
                    arr[int.Parse(comand[1]) - 1] *= long.Parse(comand[2]);
                    break;
                case "add":
                    arr[int.Parse(comand[1]) - 1] += long.Parse(comand[2]);
                    break;
                case "subtract":
                    arr[int.Parse(comand[1]) - 1] -= long.Parse(comand[2]);
                    break;
                case "lshift":
                    ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    ArrayShiftRight(arr);
                    break;
            }
        }

        public static void ArrayShiftRight(long[] array)
        {
            long temp = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = temp;
        }

        public static void ArrayShiftLeft(long[] array)
        {
            long temp = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = temp;
        }
    }
}
