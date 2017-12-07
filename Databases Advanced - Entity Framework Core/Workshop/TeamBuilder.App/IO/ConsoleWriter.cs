namespace TeamBuilder.App.IO
{
    using System;
    using TeamBuilder.App.Interfaces;

    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string text) => Console.WriteLine(text);
    }
}
