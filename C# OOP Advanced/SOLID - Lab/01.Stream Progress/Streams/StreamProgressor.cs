namespace _01.Stream_Progress.Streams
{
    using Interfaces;

    public abstract class StreamProgressor
    {
        private IStreamable file;

        public StreamProgressor(IStreamable file)
        {
            this.file = file;
        }

        public virtual int CalculateCurrentPercent()
        {
            return (this.file.BytesSent * 100) / this.file.Length;
        }
    }
}