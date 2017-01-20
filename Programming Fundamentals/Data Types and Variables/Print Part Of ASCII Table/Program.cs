using System;

namespace Print_Part_Of_ASCII_Table
{
    public class Print_Part_Of_ASCII_Table
    {
        public static void Main(string[] args)
        {
            int firstChar = int.Parse(Console.ReadLine());
            int lastChar = int.Parse(Console.ReadLine());
            for (int i = firstChar; i <= lastChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
