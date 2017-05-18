namespace _4.Merging_two_files_into_third_one
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class MergingTwoFiles
    {
        public static void Main()
        {
            Console.WriteLine("First File - Enter full path, name and extension:");
            string firstFileName;
            string firstFileDir = GetFile(out firstFileName);

            Console.WriteLine("Second File - Enter full path, name and extension:");
            string secondFileName;
            string secondFileDir = GetFile(out secondFileName);

            string[] firstContent = File.ReadAllLines(Path.Combine(firstFileDir, firstFileName));
            string[] secondContent = File.ReadAllLines(Path.Combine(secondFileDir, secondFileName));

            StringBuilder margedContent = new StringBuilder();

            for (int i = 0; i < Math.Min(firstContent.Length, secondContent.Length); i++)
            {
                margedContent.AppendLine($"{firstContent[i]}");
                margedContent.AppendLine($"{secondContent[i]}");
            }

            if (firstContent.Length > secondContent.Length)
            {
                margedContent.AppendLine(string.Join(Environment.NewLine, firstContent.Skip(secondContent.Length)));
            }

            if (secondContent.Length > firstContent.Length)
            {
                margedContent.AppendLine(string.Join(Environment.NewLine, secondContent.Skip(firstContent.Length)));
            }

            string margedFile = $"{firstFileDir}\\{Path.GetFileNameWithoutExtension(firstFileName)}_{Path.GetFileNameWithoutExtension(secondFileName)}_Marged.txt";
            File.WriteAllText(margedFile, margedContent.ToString());
            Console.WriteLine($"The new Marged file is saved as: {margedFile}");
        }

        private static string GetFile(out string fileName)
        {
            string file = Console.ReadLine();

            while (!File.Exists(file))
            {
                Console.WriteLine("This file does not exist! Please try again");
                file = Console.ReadLine();
            }

            int indexOfLastSlash = file.LastIndexOf('\\');
            fileName = file.Substring(indexOfLastSlash + 1);

            return file.Substring(0, indexOfLastSlash);
        }
    }
}
