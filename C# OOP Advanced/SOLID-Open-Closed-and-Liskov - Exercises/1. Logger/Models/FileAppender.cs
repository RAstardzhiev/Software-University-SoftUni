namespace _1.Logger.Models
{
    using System;
    using System.IO;
    using Interfaces;

    public class FileAppender : Appender
    {
        private const string FileName = "log.txt ";
        private readonly string filePath;

        public FileAppender(ILayout layout) : base(layout)
        {
            this.filePath = Path.Combine(Environment.CurrentDirectory, FileName);
            this.File = new LogFile();
        }

        public ILogFile File { get; set; }

        public override void Append(string datetime, string reportLevel, string message)
        {
            if (this.IsMessageValidLevel(reportLevel))
            {
                var report = this.Layout.FormatReport(datetime, reportLevel, message);
                this.File.Write(report);
                System.IO.File.AppendAllText(this.filePath, report);
                System.IO.File.AppendAllText(this.filePath, Environment.NewLine);
                this.MessagesCount++;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, File size: {this.File.Size}";
        }
    }
}
