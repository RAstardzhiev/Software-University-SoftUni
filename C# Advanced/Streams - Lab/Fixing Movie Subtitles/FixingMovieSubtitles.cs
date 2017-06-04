using System.IO;
using System.Text.RegularExpressions;

class FixingMovieSubtitles
{
    const int Addition = 5000;
    const string InputFile = @"..\..\source.sub";
    const string OutputFile = @"..\..\fixed.sub";
    const string SubtitlePattern = "{(.+)}{(.+)} (.+)";

    static void Main()
    {
        StreamReader streamReader = new StreamReader(InputFile);
        StreamWriter streamWriter = new StreamWriter(OutputFile);

        try
        {
            var regex = new Regex(SubtitlePattern);
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                var match = regex.Match(line);
                int startTime = int.Parse(match.Groups[1].Value) + Addition;
                int endTime = int.Parse(match.Groups[2].Value) + Addition;
                string text = match.Groups[3].Value;

                streamWriter.WriteLine("{{{0}}}{{{1}}} {2}", startTime, endTime, text);
            }
        }
        finally
        {
            streamReader.Close();
            streamWriter.Close();
        }
    }
}
