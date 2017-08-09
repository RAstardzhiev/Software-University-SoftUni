namespace _1.Logger
{
    using Controllers;

    public class StartUp
    {
        public static void Main()
        {
            var simpleCodeManualTester = new SimpleCodeManualTester();
            simpleCodeManualTester.FirstSample();
            simpleCodeManualTester.Implementations();
            simpleCodeManualTester.Extensibility();
            simpleCodeManualTester.ReportThreshold();

            var controller = new Controller();
            controller.GetAppendersFromConsole();
            controller.ExecuteCommands();
            controller.PrintAppenders();
        }
    }
}
