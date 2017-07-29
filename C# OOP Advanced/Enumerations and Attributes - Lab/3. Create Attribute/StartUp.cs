namespace _3.Create_Attribute
{
    [SoftUni("Ventsi")]
    public class StartUp
    {
        [SoftUni("Gosho")]
        public static void Main(string[] args)
        {
            var tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }
    }
}
