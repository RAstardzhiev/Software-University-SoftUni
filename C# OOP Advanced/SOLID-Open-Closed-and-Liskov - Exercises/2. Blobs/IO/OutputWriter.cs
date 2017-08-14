namespace _02.Blobs.IO
{
    using System;
    using Interfaces;

    public class OutputWriter : IOutputWriter
    {
        public void WriteLine(string line) => Console.WriteLine(line);
    }
}
