namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class WordCounter
    {
        public static void Main()
        {
            var dir = GetDirectory();
            Console.WriteLine("Enter text File:");
            var textFile = GetFileName(dir);

            while (!string.IsNullOrEmpty(textFile))
            {
                Console.WriteLine("Enter words to count File: ");
                var wordsFile = GetFileName(dir);

                if (string.IsNullOrEmpty(wordsFile))
                {
                    continue;
                }

                var text = File.ReadAllText($"{dir}\\{textFile}")
                    .ToLower()
                    .Split("\t\r\n\"'`/\\?!@#$%^&*+-_<>[]{}().,;: ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                Dictionary<string, int> wordsCounter = new Dictionary<string, int>();
                var keys = File.ReadAllText($"{dir}\\{wordsFile}").Split();

                foreach (var word in text)
                {
                    // Use a temp variable to save the original casing of the word which we count
                    var key = IsWordToCount(keys, word);

                    if (key != null)
                    {
                        if (!wordsCounter.ContainsKey(key))
                        {
                            wordsCounter[key] = 0;
                        }

                        wordsCounter[key]++;
                    }
                }

                var outputFile = $"{textFile.Substring(0, textFile.LastIndexOf('.'))}_{wordsFile.Substring(0, wordsFile.LastIndexOf('.'))}_Counter.txt";
                File.WriteAllLines($"{dir}\\{outputFile}", wordsCounter
                    .OrderByDescending(kvp => kvp.Value)
                    .Select(kvp => $"{kvp.Key} - {kvp.Value}"));

                Console.WriteLine($"Words count is saved as \"{outputFile}\". {Environment.NewLine}");

                Console.WriteLine("Enter text File:");
                textFile = GetFileName(dir);
            }
        }

        public static string IsWordToCount(string[] keys, string wordToCheck)
        {
            foreach (var key in keys)
            {
                if (key.ToLower() == wordToCheck)
                {
                    return key;
                }
            }

            return null;
        }

        private static string GetFileName(string dir)
        {
            while (true)
            {
                var fileName = Console.ReadLine();

                if (string.IsNullOrEmpty(fileName) || File.Exists($"{dir}\\{fileName}"))
                {
                    return fileName;
                }

                Console.WriteLine($"\t- File {fileName} does not exists! Please try again.");
            }
        }

        private static string GetDirectory()
        {
            Console.WriteLine("Enter directory:");
            var dir = Console.ReadLine();

            while (!Directory.Exists(dir))
            {
                Console.WriteLine($"\t- Not found! Try again.{Environment.NewLine}Enter directory:");
                dir = Console.ReadLine();
            }

            return dir;
        }
    }
}
