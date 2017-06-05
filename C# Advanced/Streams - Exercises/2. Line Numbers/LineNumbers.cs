namespace _2.Line_Numbers
{
    using StreamsLibrary;
    using System;
    using System.IO;

    public class LineNumbers
    {
        public static void Main()
        {
            System.Console.Write("Line Numbers - ");
            var file = Paths.GetFile();
            var outputFile = Paths.SetOutputFileInSameFolderAsInputFile(file, "Numbered");

            using (var reader = new StreamReader(file))
            {
                using (var writer = new StreamWriter(outputFile))
                {
                    var line = reader.ReadLine();
                    var lineCounter = 1;

                    while (line != null)
                    {
                        writer.WriteLine($"{lineCounter}\t| {line}");
                        lineCounter++;

                        line = reader.ReadLine();
                    }
                }
            }

            Console.Write("Ready. Your file is here:  ");
            UserInterface.WriteGreen(outputFile);
        }
    }
}
