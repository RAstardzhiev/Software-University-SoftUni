using System;

public class ConsoleReader : IInputReader
{
    public string ReadLine()
    {
        return Console.ReadLine();
    }
}