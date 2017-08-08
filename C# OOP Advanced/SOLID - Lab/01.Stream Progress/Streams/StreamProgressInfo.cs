namespace _01.Stream_Progress.Streams
{
    using Interfaces;

    public class StreamProgressInfo : StreamProgressor
    {
        public StreamProgressInfo(IStreamable file) : base(file)
        {
        }
    }
}
