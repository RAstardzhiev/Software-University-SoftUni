namespace _1.Logger.Models
{
    using System.Collections.Generic;
    using System.Text;
    using Interfaces;

    public class Logger : ILogger
    {
        private IList<IAppender> appenders;

        public Logger(params IAppender[] appenders)
        {
            this.appenders = new List<IAppender>();
            this.AddAppender(appenders);
        }

        public void AddAppender(IEnumerable<IAppender> appenders)
        {
            foreach (var appender in appenders)
            {
                this.appenders.Add(appender);
            }
        }

        public void Info(string datetime, string message) 
            => this.Log(datetime, nameof(this.Info), message);

        public void Warn(string datetime, string message)
            => this.Log(datetime, nameof(this.Warn), message);

        public void Error(string datetime, string message)
            => this.Log(datetime, nameof(this.Error), message);

        public void Critical(string datetime, string message)
            => this.Log(datetime, nameof(this.Critical), message);

        public void Fatal(string datetime, string message) 
            => this.Log(datetime, nameof(this.Fatal), message);

        private void Log(string datetime, string reportLevel, string message)
        {
            foreach (var appender in this.appenders)
            {
                appender.Append(datetime, reportLevel, message);
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Logger info");

            foreach (var appender in this.appenders)
            {
                sb.AppendLine(appender.ToString().Trim());
            }

            return sb.ToString();
        }
    }
}
