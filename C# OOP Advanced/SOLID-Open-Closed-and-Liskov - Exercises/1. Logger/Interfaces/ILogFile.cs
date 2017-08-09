namespace _1.Logger.Interfaces
{
    public interface ILogFile
    {
        int Size { get; }

        void Write(string message);
    }
}
