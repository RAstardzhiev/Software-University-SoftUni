namespace _03._Longest_Subsequence
{
    using System;
    using System.Linq;
    using System.Text;

    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var maxOccurances = 1;
            var currentCount = 1;
            var maxStartIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > maxOccurances)
                    {
                        maxOccurances = currentCount;
                        maxStartIndex = i - currentCount;
                    }

                    currentCount = 1;
                }

                if (i == numbers.Length - 1 && currentCount > maxOccurances)
                {
                    maxOccurances = currentCount;
                    maxStartIndex = i - currentCount + 1;
                }
            }

            var sb = new StringBuilder();
            for (int i = maxStartIndex; i < maxStartIndex + maxOccurances; i++)
            {
                sb.Append($"{numbers[i]} ");
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
