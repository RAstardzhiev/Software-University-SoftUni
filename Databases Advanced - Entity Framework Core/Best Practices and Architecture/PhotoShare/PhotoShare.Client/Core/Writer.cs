namespace PhotoShare.Client.Core
{
    using System;
    using PhotoShare.Client.Interfaces;

    public class Writer : IWriter
    {
        public void WriteLine(string message) => Console.WriteLine(message);
    }
}
