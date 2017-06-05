namespace _1.Odd_Lines
{
    using StreamsLibrary;
    using System;
    using System.IO;
    using System.Text;

    public class OddLines
    {
        public static void Main()
        {
            Console.Write("Odd lines - ");
            var file = Paths.GetFile();
            var resultedOddLines = new StringBuilder();

            using (var reader = new StreamReader(file))
            {
                var lineNumber = 0;
                var line = reader.ReadLine();

                while (line != null)
                {
                    if (lineNumber % 2 == 1)
                    {
                        resultedOddLines.Append($"{line}{Environment.NewLine}");
                    }

                    lineNumber++;
                    line = reader.ReadLine();
                }
            }

            Console.Write(resultedOddLines.ToString());
        }
    }
}
