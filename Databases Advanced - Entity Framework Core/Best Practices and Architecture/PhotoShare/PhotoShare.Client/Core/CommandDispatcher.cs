namespace PhotoShare.Client.Core
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;

    using Interfaces;
    using PhotoShare.Data;

    public class CommandDispatcher : ICommandDispatcher
    {
        private const string CommandSuffix = "Command";
        private const string InvalidAbstractionTypeExceptionMessage = "Provided class {0} is neither Abstract nor Interface";
        private const string InvalidCommandNameExceptionMessage = "Command {0} not valid!";
        private const string InvalidCommandParametersExceptionMessage = "Error: invalid command parameters";

        private IEnumerable<Type> commands;
        private IServiceProvider serviceProvider;

        public CommandDispatcher(IServiceProvider serviceProvider)
        {
            this.commands = this.GetAllImplementingTypes<ICommand>();
            this.serviceProvider = serviceProvider;
        }

        public CommandDispatcher(IServiceProvider serviceProvider, IEnumerable<Type> commands)
        {
            this.serviceProvider = serviceProvider;
            this.commands = commands;
        }

        public string DispatchCommand(string[] commandParameters, int cmdNameWordCount = 1)
        {
            if (commandParameters.Length < cmdNameWordCount)
            {
                throw new ArgumentException(InvalidCommandParametersExceptionMessage);
            }

            // Gather matching commands by the given name
            var cmdName = string.Join(string.Empty, commandParameters.Take(cmdNameWordCount));
            var commands = this.commands
                .Where(c => c.Name.StartsWith(cmdName, StringComparison.OrdinalIgnoreCase));

            var commandsCount = commands.Count();
            if (commandsCount < 1)
            {
                throw new ArgumentException(string.Format(InvalidCommandNameExceptionMessage, cmdName));
            }

            // Verify command full name
            cmdName = $"{cmdName}{CommandSuffix}"; // Add Command Suffix for exact match
            var cmdType = commands
                .FirstOrDefault(c => c.Name.Equals(cmdName, StringComparison.OrdinalIgnoreCase));

            if (cmdType == null)
            {
                cmdNameWordCount++;
                return this.DispatchCommand(commandParameters, cmdNameWordCount);
            }

            // Coming here means that the right comand is found
            var cmdParameters = commandParameters
                .Skip(cmdNameWordCount)
                .ToArray();

            var cmdInstance = this.InstantiateCommand(cmdType);
            return cmdInstance.Execute(cmdParameters);
        }

        private ICommand InstantiateCommand(Type cmdType)
        {
            var constructor = cmdType
                .GetConstructors()
                .First();

            var constructorParameters = constructor
                .GetParameters()
                .Select(pi => pi.ParameterType);

            var sevices = constructorParameters
                .Select(this.serviceProvider.GetService)
                .ToArray();

            return (ICommand)constructor.Invoke(sevices);
        }

        private Type[] GetAllImplementingTypes<T>()
            where T : class
        {
            Type parentType = typeof(T);
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
