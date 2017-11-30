namespace BusTickets.App
{
    using BusTickets.App.Core;
    using BusTickets.App.Interfaces;
    using BusTickets.Data;

    public class Startup
    {
        public static void Main()
        {

            using (var context = new BusTicketsContext())
            {
                var commandDispatcher = new CommandDispatcher<ICommand>();
                var engine = new Engine(context, commandDispatcher);
                engine.Run();
            }
        }
    }
}
