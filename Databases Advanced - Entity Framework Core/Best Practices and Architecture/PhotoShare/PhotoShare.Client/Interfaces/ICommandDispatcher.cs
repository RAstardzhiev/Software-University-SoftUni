namespace PhotoShare.Client.Interfaces
{
    public interface ICommandDispatcher
    {
        string DispatchCommand(string[] commandParameters, int cmdNameWordCount = 1);
    }
}
