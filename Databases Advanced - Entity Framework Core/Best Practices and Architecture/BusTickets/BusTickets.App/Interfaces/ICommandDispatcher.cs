namespace BusTickets.App.Interfaces
{
    public interface ICommandDispatcher<TCommand> 
        where TCommand : class
    {
        TCommand InstantiateCommand(string[] commandParameters);
    }
}
