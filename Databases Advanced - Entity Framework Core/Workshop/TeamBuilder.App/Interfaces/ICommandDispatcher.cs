namespace TeamBuilder.App.Interfaces
{
    public interface ICommandDispatcher<TCommand>
        where TCommand : class
    {
        TCommand InstantiateCommand(string cmdName, params string[] cmdParameters);
    }
}
