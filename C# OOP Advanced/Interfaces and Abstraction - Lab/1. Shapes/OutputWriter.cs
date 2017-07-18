namespace _1.Shapes
{
    using System;

    public class OutputWriter
    {
        public static void WriteLine(string line)
        {
            Console.WriteLine(line);
        }

        public static void WriteLine(char ch)
        {
            Console.WriteLine(ch);
        }

        public static void WriteLine()
        {
            Console.WriteLine();
        }

        public static void Write(char ch)
        {
            Console.Write(ch);
        }

        public static void Write(string text)
        {
            Console.Write(text);
        }
    }
}
