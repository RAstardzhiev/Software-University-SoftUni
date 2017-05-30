namespace SimpleJudge
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public static class IOManager
    {
        public static void CreateDirectoryInCurrentFolder(string name)
        {
            string path = $"{SessionData.currentPath}\\{name}";
            Directory.CreateDirectory(path);
        }

        public static void TraverseDirectory(int depth)
        {
            OutputWriter.WriteEmptyLine();
            int initialIdentation = SessionData.currentPath.Split('\\').Length;
            Queue<string> subFolders = new Queue<string>();
            subFolders.Enqueue(SessionData.currentPath);

            foreach (var file in Directory.GetFiles(subFolders.Peek()))
            {
                int indexOfLastSlash = file.LastIndexOf('\\');
                string fileName = file.Substring(indexOfLastSlash);
                OutputWriter.WriteMessageOnNewLine($"{new string('-', indexOfLastSlash)}{fileName}");

                //if (depth - initialIdentation < 0)
                //{
                //    break;
                //}
            }
        }

        public static void ChangeCurrentDirectoryRelative(string relativePath)
        {
            if (relativePath == "..")
            {
                string currentPath = SessionData.currentPath;
                int indexOfLastSlash = currentPath.LastIndexOf('\\');
                string newPath = currentPath.Substring(0, indexOfLastSlash);
                SessionData.currentPath = newPath;
            }
            else
            {
                string currentPath = SessionData.currentPath;
                currentPath += $"\\{relativePath}";
                ChangeCurrentDirectoryAbsolute(currentPath);
            }
        }

        public static void ChangeCurrentDirectoryAbsolute(string absolutePath)
        {
            if (!Directory.Exists(absolutePath))
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidPath);
                return;
            }

            SessionData.currentPath = absolutePath;
        }
    }
}
