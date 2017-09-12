namespace _03.Dependency_Inversion
{
    using Controllers;
    using Models;
    using IO;

    public class StartUp
    {
        public static void Main()
        {
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var calculator = new PrimitiveCalculator();
            new Engine(calculator, reader, writer).Run();
        }
    }
}
