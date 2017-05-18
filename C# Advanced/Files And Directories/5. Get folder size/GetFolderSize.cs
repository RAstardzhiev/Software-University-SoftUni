namespace _5.Get_folder_size
{
    using System;
    using System.IO;

    public class GetFolderSize
    {
        public static void Main()
        {
            Console.WriteLine("Enter folder:");
            string dir = Console.ReadLine();

            while (!Directory.Exists(dir))
            {
                Console.WriteLine("Unexistent folder! Please try again.");
                dir = Console.ReadLine();
            }

            double folderSizeInMegabytes = GetFolderSizeInMegabytes(dir);
            Console.WriteLine(folderSizeInMegabytes);
        }

        private static double GetFolderSizeInMegabytes(string dir)
        {
            string[] files = Directory.GetFiles(dir);
            long totalBytes = 0L;

            foreach (var file in files)
            {
                totalBytes += new FileInfo(file).Length;
            }

            return (totalBytes * 1.0) / (1024 * 1024);
        }
    }
}
