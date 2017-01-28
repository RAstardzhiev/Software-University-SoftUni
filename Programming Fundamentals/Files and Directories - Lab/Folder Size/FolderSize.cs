namespace Folder_Size
{
    using System;
    using System.IO;

    public class FolderSize
    {
        public static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("../../TestFolder");
            double sum = 0;

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            sum = (sum / 1024) / 1024;
            File.WriteAllText("../../TestFolder/Size of Files here in MB.txt", sum.ToString());
        }
    }
}
