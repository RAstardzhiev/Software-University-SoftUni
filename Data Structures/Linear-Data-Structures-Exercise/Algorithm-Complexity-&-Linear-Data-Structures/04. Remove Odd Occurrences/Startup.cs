namespace _04._Remove_Odd_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Startup
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var occuranceCounter = new Dictionary<int, int>();

            foreach (var num in numbers)
            {
                if (!occuranceCounter.ContainsKey(num))
                {
                    occuranceCounter[num] = 1;
                }
                else
                {
                    occuranceCounter[num]++;
                }
            }

            Console.WriteLine(string.Join(" ", numbers.Where(n => occuranceCounter[n] % 2 == 0)));
        }
    }
}
