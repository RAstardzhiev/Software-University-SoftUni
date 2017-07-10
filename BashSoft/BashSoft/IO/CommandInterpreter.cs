namespace BashSoft
{
    using Exceptions;
    using IO.Commands;
    using System;

    public class CommandInterpreter
    {
        private Tester judge;
        private StudentsRepository repository;
        private IOManager inputOutputManager;

        public CommandInterpreter(Tester judge, StudentsRepository repository, IOManager inputOutputManager)
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
                Command command = this.ParseCommand(input, commandName, data);
                command.Execute();
            }
            catch (Exception ex)
            {
                OutputWriter.DisplayException(ex.Message);
            }

        }

        private Command ParseCommand(string input, string command, string[] data)
        {
            switch (command)
            {
                case "open":
                    return new OpenFileCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "mkdir":
                    return new MakeDirectoryCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "is":
                    return new TraverseFoldersCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "cmp":
                    return new CompareFilesCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "cdRel":
                    return new ChangeRelativePathCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "cdAbs":
                    return new ChangeAbsolutePathCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "readDb":
                    return new ReadDatabaseCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "help":
                    return new GetHelpCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "show":
                    return new ShowCourseCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "filter":
                    return new PrintFilteredStudentsCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "decOrder":
                case "order":
                    return new PrintOrderedStudentsCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "dropdb":
                    return new DropDatabaseCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "download":
                    // TODO: implement after functionality is implemented
                case "downloadAsynch":
                    // TODO: implement after functionality is implemented
                default:
                    throw new InvalidCommandException(input);
            }
        }
    }
}
