namespace _01.Stream_Progress.Interfaces
{
    public interface IStreamable : ISource
    {
        int BytesSent { get; }
    }
}
