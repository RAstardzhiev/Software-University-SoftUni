namespace BashSoft
{
    using System;
    using Contracts;

    public class InputReader : IReader
    {
        private const string EndCommand = "quit";

        private IInterpreter interpreter;

        public InputReader(IInterpreter interpreter)
        {
            this.interpreter = interpreter;
        }

        public void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SessionData.CurrentPath}" + "> ");
            string input = Console.ReadLine().Trim();

            while (input != EndCommand)
            {
                this.interpreter.InterpretCommand(input);
                OutputWriter.WriteMessage($"{SessionData.CurrentPath}" + "> ");
                input = Console.ReadLine().Trim();
            }
        }
    }
}
