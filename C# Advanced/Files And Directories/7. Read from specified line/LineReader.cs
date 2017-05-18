namespace _7.Read_from_specified_line
{
    using System;
    using System.IO;
    using System.Linq;

    public class LineReader
    {
        public static void Main()
        {
            Console.Write("Enter a file: ");
            string file = Console.ReadLine();

            while (!File.Exists(file))
            {
                Console.Write("Wrong path! Try again. Enter a file: ");
                Console.ReadLine();
            }

            Console.Write("Enter lines to skip: ");
            int skipCount = int.Parse(Console.ReadLine());

            string[] textLines = File.ReadAllLines(file).Skip(skipCount).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine, textLines));
        }
    }
}
