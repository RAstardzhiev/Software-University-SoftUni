namespace Reverse_Array_of_Strings
{
    using System;
    using System.Linq;

    public class Reverse_Array_of_Strings
    {
        public static void Main(string[] args)
        {
            // BOTH VARIATIONS WORK
            string[] input = Console.ReadLine().Split();
            ////for (int i = 0, j = input.Length - 1; i < j && j > i; i++, j--)
            ////{
            ////    string temp = input[i];
            ////    input[i] = input[j];
            ////    input[j] = temp;
            ////}
            ////Console.WriteLine(string.Join(" ", input));
            Console.WriteLine(string.Join(" ", input.Reverse().ToArray()));
        }
    }
}
