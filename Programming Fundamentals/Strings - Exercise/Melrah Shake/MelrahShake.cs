namespace Melrah_Shake
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MelrahShake
    {
        public static void Main(string[] args)
        {
            /*
             * You are given a string of random characters, and a pattern of random characters. 
             * You need to “shake off” (remove) all of the border occurrences of that pattern, 
             * in other words, the very first match and the very last match of the pattern you find in the string.
             * 
             * When you successfully shake off a match, you remove from the pattern the character which corresponds to the 
             * index equal to the pattern’s length / 2. 
             * 
             * Then you continue to shake off the border occurrences of the new pattern until the pattern becomes empty or 
             * until there is less than the - needed for shake, matches in the remaining string.
             * 
             * In case you have found at least two matches, and you have successfully shaken them off, you print “Shaked it.” 
             * Otherwise you print “No shake.”, the remains of the main string, and you end the program. 
             */

            string text = Console.ReadLine();
            string pattern = Console.ReadLine();
            Shake(text, pattern);
        }

        private static void Shake(string text, string pattern)
        {
            int patternOccurances = CountOcurances(text, pattern);

            if (patternOccurances > 1)
            {
                Console.WriteLine("Shaked it.");

                text = text.Remove(text.IndexOf(pattern), pattern.Length);
                text = text.Remove(text.LastIndexOf(pattern), pattern.Length);
                pattern = pattern.Remove(pattern.Length / 2, 1);

                Shake(text, pattern);
            }
            else
            {
                Console.WriteLine("No shake.");
                Console.WriteLine(text);
                return;
            }
        }

        private static int CountOcurances(string text, string pattern)
        {
            int index = text.IndexOf(pattern);
            int count = 0;
            while (index >= 0 && pattern.Length > 0)
            {
                count++;
                index = text.IndexOf(pattern, index + 1);
            }

            return count;
        }
    }
}
