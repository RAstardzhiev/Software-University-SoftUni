namespace _02.Kings_Gambit
{
    using Controllers;
    using IO;

    public class StartUp
    {
        public static void Main()
        {
            new Engine(new ConsoleReader(), new ConsoleWriter()).Run();
        }
    }
}
