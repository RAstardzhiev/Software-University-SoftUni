namespace _1.Logger.Models
{
    using System.Linq;
    using System.Text;
    using Interfaces;

    public class LogFile : ILogFile
    {
        private StringBuilder sb;

        public LogFile()
        {
            this.sb = new StringBuilder();
        }

        public int Size { get; private set; }

        public void Write(string message)
        {
            this.sb.AppendLine(message);

            this.Size += message
                .Where(c => char.IsLetter(c))
                .Sum(c => c);
        }

        public override string ToString()
        {
            return this.sb.ToString().Trim();
        }
    }
}
