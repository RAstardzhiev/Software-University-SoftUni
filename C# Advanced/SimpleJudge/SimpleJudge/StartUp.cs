namespace SimpleJudge
{
    public class StartUp
    {
        public static void Main()
        {
            SessionData.CreateDirectoryInCurrentFolder("pesho");
            SessionData.TraverseDirectory(0);
            //var tested = @"C:\Users\Roy Jones Jr\Desktop\SoftBash\Simple Judge\test3.txt";
            //var expected = @"C:\Users\Roy Jones Jr\Desktop\SoftBash\Simple Judge\test2.txt";
            //Tester.CompareContent(tested, expected);
        }
    }
}
