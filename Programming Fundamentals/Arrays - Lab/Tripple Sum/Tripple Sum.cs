namespace Tripple_Sum
{
    using System;
    using System.Linq;

    public class Tripple_Sum
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int lengthOfTheArray = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals(' '))
                {
                    lengthOfTheArray++;
                }
            }

            lengthOfTheArray++;
            int[] numbers = new int[lengthOfTheArray];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (input.Contains(" "))
                {
                    numbers[i] = int.Parse(input.Substring(0, input.IndexOf(' ')));
                    input = input.Substring(input.IndexOf(' ') + 1);
                }
                else
                {
                    numbers[i] = int.Parse(input);
                }
            }

            string output = string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers.Contains(numbers[i] + numbers[j]))
                    {
                        output += $"{numbers[i]} + {numbers[j]} == {numbers[i] + numbers[j]}\n";
                    }
                }
            }

            Console.Write(output.Length > 0 ? output : "No");
        }
    }
}
