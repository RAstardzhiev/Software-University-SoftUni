namespace _1.Logger.Interfaces
{
    public interface ILayout
    {
        string FormatReport(string datetime, string reportLevel, string message);
    }
}
