namespace TeamBuilder.App
{
    using System;
    using System.Linq;
    using TeamBuilder.App.Interfaces;
    using TeamBuilder.Data;

    public class Engine
    {
        private const string EnterCommandMessage = "Enter command:";

        private TeamBuilderContext context;
        private ICommandDispatcher<ICommand> commandDispatcher;
        private IReader reader;
        private IWriter writer;

        public Engine(TeamBuilderContext context, 
            ICommandDispatcher<ICommand> commandDispatcher, 
            IReader reader, 
            IWriter writer)
        {
            this.commandDispatcher = commandDispatcher;
            this.context = context;
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            while (true)
            {
                this.writer.WriteLine(EnterCommandMessage);
                var input = this.reader.ReadLine()
                    .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                if (input.Length == 0)
                {
                    continue;
                }

                var cmdName = input[0];
                var cmdArgs = input
                    .Skip(1)
                    .ToArray();

                var cmdResult = this.TryExecuteCommand(cmdName, cmdArgs, context);
                this.writer.WriteLine(cmdResult);
            }
        }

        private string TryExecuteCommand(string cmdName, string[] cmdArgs, TeamBuilderContext context)
        {
            try
            {
                var command = this.commandDispatcher.InstantiateCommand(cmdName, cmdArgs);
                return command.Execute(context);
            }
            catch (ArgumentException ae)
            {
                return ae.Message;
            }
            catch (InvalidOperationException ioe)
            {
                return ioe.Message;
            }
            catch (NotSupportedException nse)
            {
                return nse.Message;
            }
            catch (FormatException fe)
            {
                return fe.Message;
            }
        }
    }
}
