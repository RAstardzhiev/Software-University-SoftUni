namespace Rage_Quit
{
    using System;
    using System.Linq;
    using System.Text;

    public class RageQuit
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper().Trim(" \t\n\r".ToCharArray());

            StringBuilder result = new StringBuilder();

            int lastDigitIndex = -1;
            int currentDigitIndex = -1;
            int stringLength = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    currentDigitIndex = i;
                }
                else
                {
                    stringLength++;
                }

                if (currentDigitIndex != lastDigitIndex)
                {
                    int numberLength = 1;
                    for (int j = i + 1; j < input.Length; j++)
                    {
                        if (!char.IsDigit(input[j]))
                        {
                            break;
                        }

                        numberLength++;
                    }

                    int repetitions = int.Parse(input.Substring(i, numberLength));
                    string pattern = input.Substring(lastDigitIndex + 1, stringLength);

                    for (int j = 0; j < repetitions; j++)
                    {
                        result.Append(pattern);
                    }

                    currentDigitIndex = currentDigitIndex + numberLength - 1;
                    lastDigitIndex = currentDigitIndex;
                    stringLength = 0;
                }
            }

            Console.WriteLine($"Unique symbols used: {result.ToString().Distinct().Count()}");
            Console.WriteLine(result);
        }
    }
}
