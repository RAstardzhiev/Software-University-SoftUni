namespace BashSoft
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Attributes;
    using Contracts;
    using Contracts.Repository;
    using IO.Commands;

    public class CommandInterpreter : IInterpreter
    {
        private IContentComparer judge;
        private IDatabase repository;
        private IDirectoryManager inputOutputManager;

        public CommandInterpreter(IContentComparer judge, IDatabase repository, IDirectoryManager inputOutputManager)
        {
            this.judge = judge;
            this.repository = repository;
            this.inputOutputManager = inputOutputManager;
        }

        public void InterpretCommand(string input)
        {
            string[] data = input.Split();
            string commandName = data[0];

            try
            {
                IExecutable command = this.ParseCommand(input, commandName, data);
                command.Execute();
            }
            catch (Exception e)
            {
                OutputWriter.DisplayException(e.Message);
            }
        }

        private IExecutable ParseCommand(string input, string command, string[] data)
        {
            object[] parametersForConstruction = new object[]
            {
                input, data
            };

            Type commandType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .First(t => t.GetCustomAttributes(typeof(AliasAttribute))
                    .Where(attr => attr.Equals(command))
                    .ToArray()
                    .Length > 0);

            Type interpreterType = typeof(CommandInterpreter);
            Command exe = (Command)Activator.CreateInstance(commandType, parametersForConstruction);

            FieldInfo[] fieldsOfCommand = commandType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            FieldInfo[] fieldsOfInterpreter = interpreterType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var commandField in fieldsOfCommand)
            {
                Attribute injectAttribute = commandField.GetCustomAttribute(typeof(InjectAttribute));
                if (injectAttribute != null)
                {
                    if (fieldsOfInterpreter.Any(f => f.FieldType == commandField.FieldType))
                    {
                        commandField.SetValue(
                            exe, 
                            fieldsOfInterpreter
                                .First(f => f.FieldType == commandField.FieldType)
                                .GetValue(this));
                    }
                }
            }

            return exe;
        }        
    }
}
