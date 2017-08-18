public class StartUp
{
    public static void Main()
    {
        IInputReader reader = new ConsoleReader();
        IOutputWriter writer = new ConsoleWriter();
        IHeroManager heroManager = new HeroManager();
        ICommandManager commandManager = new CommandManager(heroManager);

        IEngine engine = new Engine(reader, writer, heroManager, commandManager);
        engine.Run();
    }
}