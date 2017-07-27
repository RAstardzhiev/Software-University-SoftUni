namespace _04.Froggy
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            PlayTheGame();
        }

        private static void PlayTheGame()
        {
            var stoneValues = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var stones = new Stones<int>(stoneValues);

            Console.WriteLine(string.Join(", ", stones));
        }
    }
}
