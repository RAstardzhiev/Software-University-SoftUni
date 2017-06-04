using System.IO;
using System.IO.Compression;

class ZipAndUnzip
{
    static void Main()
    {
        Compress("../../text.txt", "../../zipped.gz");

        Decompress("../../zipped.gz", "../../result.txt");
    }

    static void Decompress(string inputFile, string outputFile)
    {
        using (var inputStream = new FileStream(inputFile, FileMode.Open))
        {
            using (var compressionStream = new GZipStream(inputStream, CompressionMode.Decompress, false))
            {
                using (var outputStream = new FileStream(outputFile, FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = compressionStream.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }

                        outputStream.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }

    static void Compress(string inputFile, string outputFile)
    {
        using (var inputStream = new FileStream(inputFile, FileMode.Open))
        {
            using (var outputStream = new FileStream(outputFile, FileMode.Create))
            {
                using (var compressionStream = new GZipStream(outputStream, CompressionMode.Compress, false))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = inputStream.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }

                        compressionStream.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
