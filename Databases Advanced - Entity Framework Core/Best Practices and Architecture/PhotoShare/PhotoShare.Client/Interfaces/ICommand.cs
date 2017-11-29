namespace PhotoShare.Client.Interfaces
{
    public interface ICommand
    {
        string Execute(string[] data);
    }
}
