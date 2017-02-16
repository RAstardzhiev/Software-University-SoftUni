namespace Magic_exchangeable_words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ExchangeableWords
    {
        public static void Main(string[] args)
        {
            /*
             * Exchangeable are words where the characters in the first string can be replaced to get the second string. 
             * Example: "egg" and "add" are exchangeable, but "aabbccbb" and "nnooppzz" are not. 
             * (First 'b' corresponds to 'o', but then it also corresponds to 'z'). The two words may not have the same length, 
             * if such is the case they are exchangeable only if the longer one doesn't have more types of characters 
             * then the shorter one ("Clint" and "Eastwaat" are exchangeable because 'a' and 't' are already mapped as 
             * 'l' and 'n', but "Clint" and "Eastwood" aren't exchangeable because 'o' and 'd' are not contained in "Clint").
             */
            string[] input = Console.ReadLine().Split(' ');
            Console.WriteLine(AreTheyExchhangable(input[0], input[1]).ToString().ToLower());
        }

        private static bool AreTheyExchhangable(string firstString, string secondString)
        {
            List<char> firstList = firstString
                .ToList()
                .Distinct()
                .ToList();

            List<char> secondLisst = secondString
                .ToList()
                .Distinct()
                .ToList();

            return (firstList.Count == secondLisst.Count) ? true : false;
        }
    }
}
