namespace Merge_Files
{
    using System.IO;
    using System.Linq;

    public class MergeFiles
    {
        public static void Main(string[] args)
        {
            string[] allData = File.ReadAllLines("../../src/FileOne.txt");
            allData = allData.Concat(File.ReadAllLines("../../src/FileTwo.txt")).ToArray();
            File.WriteAllLines(@"..\..\src\ThirdFile.txt", allData.OrderBy(x => x));
        }
    }
}
