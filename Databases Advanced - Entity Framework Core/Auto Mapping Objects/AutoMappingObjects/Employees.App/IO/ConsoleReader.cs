namespace Employees.App.IO
{
    using System;
    using Interfaces;

    public class ConsoleReader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}
