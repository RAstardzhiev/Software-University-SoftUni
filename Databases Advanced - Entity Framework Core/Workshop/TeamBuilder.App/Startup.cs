namespace TeamBuilder.App
{
    using TeamBuilder.App.Core;
    using TeamBuilder.App.Interfaces;
    using TeamBuilder.App.IO;
    using TeamBuilder.Data;

    public class Startup
    {
        public static void Main()
        {
            var context = new TeamBuilderContext();
            var session = new UserSession();
            var commandDispatcher = new CommandDispatcher<ICommand>(session);
            var writer = new ConsoleWriter();
            var reader = new ConsoleReader();

            var engine = new Engine(context, commandDispatcher, reader, writer);
            engine.Run();
        }
    }
}
