namespace BusTickets.App.Interfaces
{
    using BusTickets.Data;

    public interface ICommand
    {
        string[] CmdArgs { get; }

        string Execute(BusTicketsContext context);
    }
}
