using System;

public class ConsoleWriter : IWriter
{
    public void WriteLine(string output) => Console.WriteLine(output);
}