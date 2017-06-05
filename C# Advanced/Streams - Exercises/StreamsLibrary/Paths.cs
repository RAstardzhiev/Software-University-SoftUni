namespace StreamsLibrary
{
    using System;
    using System.IO;

    public static class Paths
    {
        public static string GetFile()
        {
            Console.WriteLine("Enter the location of your file (including the file's name and extension):");
            var file = Console.ReadLine();

            while (!File.Exists(file))
            {
                UserInterface.WriteRed($@"The path you entered does not exists. Please enter the full path of your file.{Environment.NewLine}e.g: ""D:\Folder Name\Second Folder\File Name.txt""");
                file = Console.ReadLine();
            }

            return file;
        }

        public static string GetDirectory()
        {
            Console.Write("Enter Directory path: ");
            var dir = Console.ReadLine();

            while (!Directory.Exists(dir))
            {
                UserInterface.WriteRed($@"This Directory does not exists. Please try again. You must enter the full path to your folder{Environment.NewLine}e.g. ""D:\Software-University-SoftUni\C# Advanced""");
                dir = Console.ReadLine();
            }

            return dir;
        }

        public static string SetOutputFileInSameFolderAsInputFile(string inputFile, string addition)
        {
            var fileName = Path.GetFileNameWithoutExtension(inputFile);
            var extension = Path.GetExtension(inputFile);
            var dir = inputFile.Substring(0, inputFile.LastIndexOf('\\'));

            return Path.Combine(dir, $"{fileName} - {addition}{extension}");
        }
    }
}
