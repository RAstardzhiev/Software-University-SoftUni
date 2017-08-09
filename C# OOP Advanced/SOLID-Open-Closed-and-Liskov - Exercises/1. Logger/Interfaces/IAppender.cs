namespace _1.Logger.Interfaces
{
    using Enums;

    public interface IAppender
    {
        ILayout Layout { get; }

        void Append(string datetime, string reportLevel, string message);

        ReportLevel ReportLevel { get; set; }

        bool IsMessageValidLevel(string messageLevel);
    }
}
