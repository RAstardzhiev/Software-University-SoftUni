namespace _1.Logger.Interfaces
{
    using Enums;

    public interface IAppender
    {
        ILayout Layout { get; }

        ReportLevel ReportLevel { get; set; }

        void Append(string datetime, string reportLevel, string message);

        bool IsMessageValidLevel(string messageLevel);
    }
}
