using System;

namespace Thea_The_Photographer
{
    public class Thea_The_Photographer
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine(int.MaxValue);
            int allPictures = int.Parse(Console.ReadLine());
            int secondsNeededToFilterEachPicture = int.Parse(Console.ReadLine());
            int percentageGoodPhotos = int.Parse(Console.ReadLine());
            int secondsToUploadEachPicture = int.Parse(Console.ReadLine());

            long neededSeconds = (long)allPictures * secondsNeededToFilterEachPicture + (int)(Math.Ceiling(allPictures * (percentageGoodPhotos / 100.0))) * (long)secondsToUploadEachPicture;

            Console.WriteLine("{0:0}:{1:00}:{2:00}:{3:00}", neededSeconds / 86400, neededSeconds / 3600 % 24, neededSeconds / 60 % 60, neededSeconds % 60);
        }
    }
}
