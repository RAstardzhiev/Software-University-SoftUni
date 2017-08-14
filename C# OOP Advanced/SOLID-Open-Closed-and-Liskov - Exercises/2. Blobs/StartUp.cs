namespace _02.Blobs
{
    using Core;
    using IO;

    public class StartUp
    {
        public static void Main()
        {
            new Engine(new InputReader(), new OutputWriter(), new TypeCollector()).Run();
        }
    }
}
