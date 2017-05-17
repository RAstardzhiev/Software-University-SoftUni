namespace SimpleJudge
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public static class SessionData
    {
        public static string currentPath = Directory.GetCurrentDirectory();

        public static void CreateDirectoryInCurrentFolder(string name)
        {
            Directory.CreateDirectory(Path.Combine(currentPath, name));
        }

        public static void TraverseDirectory(int depth)
        {
            OutputWriter.WriteEmptyLine();
            int initialIdentation = currentPath.Split('\\').Length;
            Queue<string> subFolders = new Queue<string>();
            subFolders.Enqueue(currentPath);

            if (depth - initialIdentation < 0)
            {
                // break;
            }

            foreach (var file in Directory.GetFiles(subFolders.Peek()))
            {
                OutputWriter.WriteMessageOnNewLine($"{new string('-', subFolders.Peek().Length)}\\{Path.GetFileName(file)}");
            }
        }

        public static void ChangeCurrentDirectoryRelative(string relativePath)
        {
            if (relativePath == "..")
            {
                int indexOfLastSlash = currentPath.LastIndexOf('\\');
                string newPath = currentPath.Substring(0, indexOfLastSlash);
                currentPath = newPath;
            }
            else
            {
                currentPath += $"\\{relativePath}";
                ChangeCurrentDirectoryAbsolute(currentPath);
            }
        }

        private static void ChangeCurrentDirectoryAbsolute(string absolutePath)
        {
            if (!Directory.Exists(absolutePath))
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidPath);
                return;
            }

            currentPath = absolutePath;
        }
    }
}
