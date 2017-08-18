public interface IOutputWriter
{
    void WriteLine(string line);

    void WriteLine(string format, params string[] args);
}
