namespace _2.Line_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class LineNumbers
    {
        public static void Main()
        {
            Console.WriteLine("Enter a folder path");
            var dir = Console.ReadLine();

            while (!Directory.Exists(dir))
            {
                Console.WriteLine($"Incorect path! Please try again.");
                Console.WriteLine("Enter a folder path");
                dir = Console.ReadLine();
            }

            var files = Directory.GetFiles(dir);

            foreach (var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file);
                var outputName = $"{fileName}_Nummerated.txt";

                var content = File.ReadAllLines(file);
                Queue<string> nummerated = new Queue<string>(content.Length);

                for (int i = 0; i < content.Length; i++)
                {
                    nummerated.Enqueue($"{i + 1}. {content[i]}");
                }

                Console.WriteLine($"{fileName} -> {outputName}");

                File.WriteAllLines($"{dir}\\{outputName}", nummerated);
            }
        }
    }
}
