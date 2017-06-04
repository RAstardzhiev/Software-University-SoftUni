using System;
using System.IO;

class Program
{
    const string FilePath = "../../text.txt";

    static void Main()
    {
        string text = File.ReadAllText(FilePath);
        Console.WriteLine(text);        
        
        File.WriteAllText("../../new.txt", "New line");

        bool fileExists = File.Exists("../../Program.cs");
        Console.WriteLine(fileExists);

        var fileStream = File.Create("temp.bin");
        fileStream.Close();

        File.Move("temp.bin", "renamed.bin");

        File.Delete("renamed.bin");

        var fileInfo = new FileInfo("../../Program.cs");
        Console.WriteLine("Name: {0}, Extension: {1}, Size: {2}b, Last Accessed: {3}",
            fileInfo.Name, fileInfo.Extension, fileInfo.Length, fileInfo.LastAccessTime);

        string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
        foreach (var file in files)
        {
            Console.WriteLine(file);
        }

        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        Console.WriteLine(path);
    }
}
