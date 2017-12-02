namespace Employees.App.Interfaces
{
    public interface ICommandInterpreter<TCommand> 
        where TCommand : class
    {
        TCommand GetCommandInstance(string cmdName, string[] cmdArgs);
    }
}
