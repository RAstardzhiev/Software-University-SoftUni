namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;

    public static class OutputWriter
    {
        public static void WriteMessageOnNewLine(string message)
        {
            Console.WriteLine(message);
        }

        // Display student
        public static void PrintStudent(KeyValuePair<string, List<int>> student)
        {
            WriteMessageOnNewLine($"{student.Key} - {string.Join(", ", student.Value)}");
        }
    }
}
