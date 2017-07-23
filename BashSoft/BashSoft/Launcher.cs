namespace BashSoft
{
    using Contracts;

    public class Launcher
    {
        public static void Main()
        {
            Tester tester = new Tester();
            IDirectoryManager ioManager = new IOManager();
            StudentsRepository repo = new StudentsRepository(new RepositoryFilter(), new RepositorySorter());

            IInterpreter currentInterpreter = new CommandInterpreter(tester, repo, ioManager);
            IReader reader =  new InputReader(currentInterpreter);

            reader.StartReadingCommands();
        }
    }
}
