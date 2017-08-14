namespace _02.Kings_Gambit.IO
{
    using System;
    using Interfaces;

    public class ConsoleWriter : IWroiter
    {
        public void WriteLine(string line) => Console.WriteLine(line);
    }
}
