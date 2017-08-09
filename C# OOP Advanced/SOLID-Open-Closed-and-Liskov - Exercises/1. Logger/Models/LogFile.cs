namespace _1.Logger.Models
{
    using System;
    using System.Text;
    using Interfaces;

    public class LogFile : ILogFile
    {
        private StringBuilder sb;

        public LogFile()
        {
            this.sb = new StringBuilder();
        }

        public int Size => this.CalculateSize();

        public void Write(string message)
        {
            this.sb.AppendLine(message);
        }

        private int CalculateSize()
        {
            var text = this.sb.ToString().Replace("<", string.Empty);
            text = text.Replace("/", string.Empty);
            text = text.Replace(">", string.Empty);

            var size = 0;

            for (int i = 0; i < this.sb.Length; i++)
            {
                if (sb[i] >= 'a' && sb[i] <= 'z' || 
                    sb[i] >= 'A' && sb[i] <= 'Z')
                {
                    size += sb[i];
                }
            }

            return size;
        }

        public override string ToString()
        {
            return this.sb.ToString().Trim();
        }
    }
}
