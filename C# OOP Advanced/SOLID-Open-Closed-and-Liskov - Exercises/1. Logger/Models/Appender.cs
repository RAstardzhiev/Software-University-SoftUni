namespace _1.Logger.Models
{
    using System;
    using System.Globalization;
    using Enums;
    using Interfaces;

    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
            this.ReportLevel = 0;
        }

        public ReportLevel ReportLevel { get; set; }

        public ILayout Layout { get; private set; }

        protected int MessagesCount { get; set; }

        public abstract void Append(string datetime, string reportLevel, string message);

        public bool IsMessageValidLevel(string messageLevel)
        {
            if (messageLevel == "WARNING")
            {
                messageLevel = "Warn";
            }

            var capitalizedLevel = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(messageLevel.ToLower());

            return (ReportLevel)Enum.Parse(typeof(ReportLevel), capitalizedLevel) >= this.ReportLevel;
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.ReportLevel.ToString().ToUpper()}, Messages appended: {this.MessagesCount}";
        }
    }
}
