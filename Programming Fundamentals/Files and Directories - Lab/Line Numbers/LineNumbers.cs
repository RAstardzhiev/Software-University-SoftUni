namespace Line_Numbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        public static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("../Input/input.txt");
            for (int i = 0; i < input.Length; i++)
            {
                File.AppendAllText("../Output/output.txt", $"{i + 1}. {input[i]}{Environment.NewLine}");
            }
        }
    }
}
