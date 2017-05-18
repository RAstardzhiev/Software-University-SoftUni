namespace _6.Timer
{
    using System;
    using System.Diagnostics;
    using System.IO;

    public class Timer
    {
        public static void Main()
        {
            Console.WriteLine("Enter file 1:");
            string firstFile = GetFile();
            Console.WriteLine("Enter file 2:");
            string secondFile = GetFile();
            
            TimeSpan firstFileTime = ReadFile(firstFile);
            TimeSpan secondFileTime = ReadFile(secondFile);

            Console.WriteLine(firstFileTime < secondFileTime);
        }

        private static TimeSpan ReadFile(string path)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            string text = File.ReadAllText(path);

            timer.Stop();
            return timer.Elapsed;
        }

        private static string GetFile()
        {
            string file = Console.ReadLine();

            while (!File.Exists(file))
            {
                Console.WriteLine("Wrong path! Try again.");
                Console.ReadLine();
            }

            return file;
        }
    }
}
