namespace _01.Stream_Progress
{
    using System;
    using Models;
    using Streams;

    public class StartUp
    {
        public static void Main()
        {
            var file = new File("File name", 1234, 123);
            var fileProcessInfo = new StreamProgressInfo(file);
            Console.WriteLine(fileProcessInfo.CalculateCurrentPercent());

            var music = new Music("Singer", "Album", 123456, 12349);
            var musicProcessInfo = new StreamProgressInfo(music);
            Console.WriteLine(musicProcessInfo.CalculateCurrentPercent());
        }
    }
}
