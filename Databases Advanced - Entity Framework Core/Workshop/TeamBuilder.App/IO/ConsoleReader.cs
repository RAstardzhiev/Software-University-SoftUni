namespace TeamBuilder.App.IO
{
    using System;
    using TeamBuilder.App.Interfaces;

    public class ConsoleReader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}
