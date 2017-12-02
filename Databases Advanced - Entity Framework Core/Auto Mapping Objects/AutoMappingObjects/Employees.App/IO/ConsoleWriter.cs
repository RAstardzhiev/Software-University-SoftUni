namespace Employees.App.IO
{
    using System;
    using Interfaces;

    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string text) => Console.WriteLine(text);

        public void Write(string text) => Console.Write(text);
    }
}
