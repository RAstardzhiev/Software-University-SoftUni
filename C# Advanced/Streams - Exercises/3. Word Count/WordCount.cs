namespace _3.Word_Count
{
    using StreamsLibrary;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        public static void Main()
        {
            Console.Write("Words file - ");
            var wordsFile = Paths.GetFile();

            var keysCounter = InitializeKeysCounter(wordsFile);

            string outputFile;
            CountKeyOccurances(keysCounter, out outputFile);
            WriteOutput(keysCounter, outputFile);
        }

        private static void WriteOutput(Dictionary<string, int> keysCounter, string outputFilePath)
        {
            using (var writer = new StreamWriter(outputFilePath))
            {
                foreach (var kvp in keysCounter)
                {
                    writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }

            Console.Write("Ready. Your file is here: ");
            UserInterface.WriteGreen(outputFilePath);
        }

        private static void CountKeyOccurances(Dictionary<string, int> keysCounter, out string outputFile)
        {
            Console.Write("Text file - ");
            var textFile = Paths.GetFile();
            outputFile = Paths.SetOutputFileInSameFolderAsInputFile(textFile, "Counted keys");

            var text = ReadFile(textFile);

            foreach (var key in keysCounter.Keys.OrderBy(x => x))
            {
                var matches = Regex.Matches(text.ToLower(), $@"\b{key}\b");
                keysCounter[key] = matches.Count;
            }
        }

        private static Dictionary<string, int> InitializeKeysCounter(string filePath)
        {
            var keys = ReadFile(filePath)
                .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            var keysCounter = new Dictionary<string, int>();

            foreach (var key in keys)
            {
                keysCounter[key] = 0;
            }

            return keysCounter;
        }

        private static string ReadFile(string filePath)
        {
            var sb = new StringBuilder();

            using (var reader = new StreamReader(filePath))
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    sb.Append($" {line}");
                    line = reader.ReadLine();
                }
            }

            return sb.ToString();
        }
    }
}
