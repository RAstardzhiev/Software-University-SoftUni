namespace Employees.App.Core
{
    using Interfaces;
    using System;
    using System.Linq;

    public class Engine
    {
        private const string EnterCommandMessage = "Enter command: ";

        private IReader reader;
        private IWriter writer;
        private ICommandInterpreter<ICommand> commandInterpreter;

        public Engine(IReader reader, IWriter writer, ICommandInterpreter<ICommand> commandInterpreter)
        {
            this.reader = reader;
            this.writer = writer;
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            while (true)
            {
                this.writer.Write(EnterCommandMessage);

                var input = this.reader.ReadLine().Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                var cmdName = input[0];
                var cmdArgs = input.Skip(1).ToArray();

                try
                {
                    var command = this.commandInterpreter.GetCommandInstance(cmdName, cmdArgs);
                    command.Execute();
                }
                catch (ArgumentException ae)
                {
                    this.writer.WriteLine(ae.Message);
                }
            }
        }
    }
}
