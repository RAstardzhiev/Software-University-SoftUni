namespace Randomize_Words
{
    using System;

    public class RandomizeWords
    {
        public static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Random rdn = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = rdn.Next(words.Length);
                string temp = words[i];
                words[i] = words[randomIndex];
                words[randomIndex] = temp;
            }

            Console.WriteLine(string.Join("\n", words));
        }
    }
}
