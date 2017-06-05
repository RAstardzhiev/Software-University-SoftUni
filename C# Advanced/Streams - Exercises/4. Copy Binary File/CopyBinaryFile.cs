namespace _4.Copy_Binary_File
{
    using StreamsLibrary;
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        public static void Main()
        {
            Console.Write("Copy file - ");
            var inputFile = Paths.GetFile();
            var outputFile = Paths.SetOutputFileInSameFolderAsInputFile(inputFile, "Coppyed");

            using (var reader = new FileStream(inputFile, FileMode.Open))
            {
                using (var writer = new FileStream(outputFile, FileMode.OpenOrCreate))
                {
                    byte[] buffer = new byte[4096];

                    while (true)
                    {
                        int readBytes = reader.Read(buffer, 0, buffer.Length);

                        if (readBytes == 0)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, readBytes);
                    }
                }
            }

            Console.Write("Ready. Your file is here: ");
            UserInterface.WriteGreen(outputFile);
        }
    }
}
