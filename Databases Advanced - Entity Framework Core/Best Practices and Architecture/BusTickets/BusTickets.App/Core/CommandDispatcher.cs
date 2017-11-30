namespace BusTickets.App.Core
{
    using Interfaces;
    using System;
    using System.Linq;
    using System.Reflection;

    public class CommandDispatcher<TCommand> : ICommandDispatcher<TCommand>
        where TCommand : class
    {
        private const string CommandSuffix = "Command";
        private const string InvalidAbstractionTypeExceptionMessage = "Provided class {0} is neither Abstract nor Interface";
        private const string InvalidCommandParametersExceptionMessage = "Error: invalid command parameters";
        private const string InvalidCommandNameExceptionMessage = "Command {0} not valid!";

        private Type[] commands;

        public CommandDispatcher()
        {
            this.commands = this.GetCommandTypes();
        }

        public CommandDispatcher(Type[] commandTypes)
        {
            this.commands = commandTypes;
        }

        public TCommand InstantiateCommand(string[] commandParameters)
        {
            var cmdName = commandParameters.First().Replace("-", string.Empty);
            var cmdParameters = commandParameters.Skip(1).ToArray();

            cmdName = $"{cmdName}{CommandSuffix}"; 
            var cmdType = commands
                .SingleOrDefault(c => c.Name.Equals(cmdName, StringComparison.OrdinalIgnoreCase));

            if (cmdType == null)
            {
                throw new ArgumentException(string.Format(InvalidCommandNameExceptionMessage, cmdName.Replace(CommandSuffix, string.Empty)));
            }

            return (TCommand)Activator.CreateInstance(cmdType, new object[] { cmdParameters });
        }

        private Type[] GetCommandTypes()
        {
            Type parentType = typeof(TCommand);
            if (!parentType.IsAbstract && !parentType.IsInterface)
            {
                throw new ArgumentException(string.Format(InvalidAbstractionTypeExceptionMessage, parentType.Name));
            }

            return Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => parentType.IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .ToArray();
        }
    }
}
