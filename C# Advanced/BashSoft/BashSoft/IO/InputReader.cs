namespace BashSoft
{
    using System;

    public static class InputReader
    {
        private const string endCommand = "quit";
        public static void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SessionData.currentPath}>");
            string input = Console.ReadLine().Trim();

            while (input != endCommand)
            {
                CommandInterpreter.InterpretCommand(input);

                OutputWriter.WriteMessage($"{SessionData.currentPath}>");
                input = Console.ReadLine().Trim();
            }
        }
    }
}
