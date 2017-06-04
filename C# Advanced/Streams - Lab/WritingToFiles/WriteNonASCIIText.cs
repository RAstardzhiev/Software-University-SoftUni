using System.IO;
using System.Text;

class ProgWriteNonASCIITextram
{
    static void Main()
    {
        // Example for NON ASCII (American Standard Code for Information Interchange)
        string text = "Кирилица";
        var fileStream = new FileStream("../../log.txt", FileMode.Create);
        try
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            fileStream.Write(bytes, 0, bytes.Length);
        }
        finally
        {
            fileStream.Close();
        }
    }
}