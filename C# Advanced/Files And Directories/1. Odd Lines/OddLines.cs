namespace _1.Odd_Lines
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class OddLines
    {
        public static void Main()
        {
            Console.WriteLine("Enter the full File path (including its name and extension): ");
            var inputFile = Console.ReadLine();

            while (!File.Exists(inputFile))
            {
                Console.WriteLine("Wrong path! Try again");
                Console.WriteLine("Enter the full File path (including its name and extension): ");
                inputFile = Console.ReadLine();
            }

            var input = File.ReadAllLines(inputFile);
            var output = new Queue<string>();

            Console.WriteLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(input[i]);
                    output.Enqueue(input[i]);
                }
            }

            var inputFileName = Path.GetFileNameWithoutExtension(inputFile);
            var directory = inputFile.Substring(0, inputFile.LastIndexOf('\\'));
            var outputFile = Path.Combine(directory, $"{inputFileName}'s Odd Lines.txt");

            File.WriteAllLines(outputFile, output);

            Console.WriteLine($"{Environment.NewLine}The resulted file is saved here: {outputFile}");
        }
    }
}
