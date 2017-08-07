namespace _03BarracksFactory.Core
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using Attributes;
    using Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        private const string CommandSuffix = "Command";

        private IRepository repository;
        private IUnitFactory unitFactory;

        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            string fullCommandName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(commandName) + CommandSuffix;
            Type commandType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == fullCommandName);

            if (commandType == null)
            {
                throw new InvalidOperationException("Invalid command!");
            }

            IExecutable command = (IExecutable)Activator.CreateInstance(commandType, new[] { data });

            this.InjectDependancies(command);
            return command;
        }

        private void InjectDependancies(IExecutable command)
        {
            Type injectionType = typeof(InjectAttribute);

            IEnumerable<FieldInfo> fieldsForInjection = command.GetType()
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(f => f.GetCustomAttributes().Any(a => a.GetType() == injectionType));

            IEnumerable<FieldInfo> interpreterFields = this.GetType()
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (FieldInfo fieldForInjection in fieldsForInjection)
            {
                fieldForInjection.SetValue(command, interpreterFields
                    .First(f => f.FieldType == fieldForInjection.FieldType)
                    .GetValue(this));
            }
        }
    }
}
