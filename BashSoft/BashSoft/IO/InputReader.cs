namespace BashSoft
{
    using System;

    public class InputReader
    {
        private const string endCommand = "quit";

        private CommandInterpreter interpreter;

        public InputReader(CommandInterpreter commandInterpreter)
        {
            this.interpreter = commandInterpreter;
        }

        public void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SessionData.currentPath}>");
            string input = Console.ReadLine().Trim();

            while (input != endCommand)
            {
                this.interpreter.InterpretCommand(input);

                OutputWriter.WriteMessage($"{SessionData.currentPath}>");
                input = Console.ReadLine().Trim();
            }
        }
    }
}
