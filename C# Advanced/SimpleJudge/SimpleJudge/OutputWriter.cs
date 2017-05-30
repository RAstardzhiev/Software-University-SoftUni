namespace SimpleJudge
{
    using System;

    public class OutputWriter
    {
        public static void WriteMessageOnNewLine(string message) => Console.WriteLine(message);
        public static void WriteEmptyLine() => Console.WriteLine();
        public static void DisplayException(string exception) => Console.WriteLine();
    }
}
