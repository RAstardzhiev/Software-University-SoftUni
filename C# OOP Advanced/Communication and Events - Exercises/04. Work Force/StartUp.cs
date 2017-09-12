namespace _04.Work_Force
{
    using Controllers;
    using IO;

    public class StartUp
    {
        public static void Main()
        {
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            new Engine(reader, writer).Run();
        }
    }
}
