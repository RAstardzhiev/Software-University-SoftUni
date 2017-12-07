namespace TeamBuilder.App.Core
{
    using System;
    using System.Linq;
    using System.Reflection;
    using TeamBuilder.App.Interfaces;

    public class CommandDispatcher<TCommand> : ICommandDispatcher<TCommand>
        where TCommand : class
    {
        private const string CommandSuffix = "Command";
        private const string InvalidAbstractionTypeExceptionMessage = "Provided class {0} is neither Abstract nor Interface";
        private const string InvalidCommandParametersExceptionMessage = "Error: invalid command parameters";
        private const string InvalidCommandNameExceptionMessage = "Command {0} not valid!";

        private Type[] commands;
        private IUserSession session;

        public CommandDispatcher(IUserSession session)
        {
            this.commands = this.GetCommandTypes();
            this.session = session;
        }

        public CommandDispatcher(Type[] commandTypes, IUserSession session)
        {
            this.commands = commandTypes;
            this.session = session;
        }

        public TCommand InstantiateCommand(string cmdName, params string[] cmdParameters)
        {
            cmdName = $"{cmdName}{CommandSuffix}";
            var cmdType = commands
                .SingleOrDefault(c => c.Name.Equals(cmdName, StringComparison.OrdinalIgnoreCase));

            if (cmdType == null)
            {
                throw new NotSupportedException(string.Format(InvalidCommandNameExceptionMessage, cmdName.Replace(CommandSuffix, string.Empty)));
            }

            return (TCommand)Activator.CreateInstance(cmdType, new object[] { cmdParameters, this.session });
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
