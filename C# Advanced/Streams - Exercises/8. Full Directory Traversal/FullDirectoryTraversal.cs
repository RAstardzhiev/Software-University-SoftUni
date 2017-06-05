namespace _8.Full_Directory_Traversal
{
    using StreamsLibrary;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class FullDirectoryTraversal
    {
        public static void Main()
        {
            var folders = new Queue<string>();
            folders.Enqueue(Paths.GetDirectory());

            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var reportPath = Path.Combine(desktopPath, "report.txt");

            using (File.Create(reportPath)) {  }

            TraverseDirectory(folders, reportPath);
        }

        private static void TraverseDirectory(Queue<string> folders, string reportPath)
        {
            if (folders == null || folders.Count == 0)
            {
                return;
            }

            var subfolders = Directory.GetDirectories(folders.Peek());

            foreach (var dir in subfolders)
            {
                folders.Enqueue(dir);
            }

            var files = GetFilesFromDirectory(folders.Peek());

            SaveReport(files, folders.Dequeue(), reportPath);

            TraverseDirectory(folders, reportPath);
        }

        private static void SaveReport(Dictionary<string, Dictionary<string, long>> files, string filesDir, string reportPath)
        {
            using (var appender = new FileStream(reportPath, FileMode.Append))
            {
                using (var writer = new StreamWriter(appender))
                {
                    var sb = new StringBuilder();
                    sb.Append($"Folder: {filesDir}{Environment.NewLine}");

                    foreach (var group in files
                        .OrderByDescending(g => g.Value.Count).ThenBy(g => g.Key))
                    {
                        var filesInGroup = string.Join(Environment.NewLine, group.Value
                            .OrderByDescending(f => f.Value)
                            .Select(kvp => $"      --{kvp.Key} - {kvp.Value}kb"));

                        sb.Append($"   {group.Key}{Environment.NewLine}{filesInGroup}{Environment.NewLine}");
                    }

                    sb.Append($"{Environment.NewLine}{new string('*', 70)}{Environment.NewLine}");
                    writer.Write($"{sb.ToString()}{Environment.NewLine}");
                }
            }
        }

        private static Dictionary<string, Dictionary<string, long>> GetFilesFromDirectory(string dir)
        {
            var files = Directory.GetFiles(dir);

            // The files should be grouped by their extension
            // Dictionary<extension, Dictionary<filePath, fileSize>>
            var result = new Dictionary<string, Dictionary<string, long>>();

            foreach (var file in files)
            {
                var extension = Path.GetExtension(file);
                var fileSize = new FileInfo(file).Length;

                if (!result.ContainsKey(extension))
                {
                    result[extension] = new Dictionary<string, long>();
                }

                result[extension][file] = fileSize;
            }

            return result;
        }
    }
}
