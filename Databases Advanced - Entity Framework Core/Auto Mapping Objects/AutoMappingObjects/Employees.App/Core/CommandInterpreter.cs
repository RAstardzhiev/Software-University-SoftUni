namespace Employees.App.Core
{
    using Employees.App.Interfaces;
    using System;
    using System.Linq;
    using System.Reflection;

    class CommandInterpreter<TCommand> : ICommandInterpreter<TCommand>
        where TCommand : class
    {
        private const string CommandSuffix = "Command";

        private const string InvalidAbstractionTypeExceptionMessage = "Provided class {0} is neither Abstract nor Interface";
        private const string InvalidCommandNameExceptionMessage = "Command {0} not valid!";

        private Type[] commandTypes;
        private IServiceProvider serviceProvider;

        public CommandInterpreter(IServiceProvider serviceProvider)
        {
            this.commandTypes = this.GetCommandTypes();
            this.serviceProvider = serviceProvider;
        }

        public CommandInterpreter(Type[] commandTypes, IServiceProvider serviceProvider)
        {
            this.commandTypes = commandTypes;
            this.serviceProvider = serviceProvider;
        }

        public TCommand GetCommandInstance(string cmdName, string[] cmdArgs)
        {
            cmdName = $"{cmdName}{CommandSuffix}";
            var cmdType = this.commandTypes
                .SingleOrDefault(c => c.Name.Equals(cmdName, StringComparison.OrdinalIgnoreCase));

            if (cmdType == null)
            {
                throw new ArgumentException(string.Format(InvalidCommandNameExceptionMessage, cmdName.Replace(CommandSuffix, string.Empty)));
            }

            var ctorParams = cmdType
                .GetConstructors()
                .First()
                .GetParameters()
                .Select(p => serviceProvider.GetService(p.ParameterType))
                .ToArray();

            ctorParams[0] = cmdArgs; // So far it is null because is cmdArgs are not present in the serviceProvider

            return (TCommand)Activator.CreateInstance(cmdType, ctorParams);
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
