namespace Substring
{
    using System;

    public class Substring
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int step = int.Parse(Console.ReadLine());

            char key = 'p';
            bool hasMatch = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == key)
                {
                    hasMatch = true;

                    if (step + i + 1 > input.Length)
                    {
                        Console.WriteLine(input.Substring(i));
                    }
                    else
                    {
                        Console.WriteLine(input.Substring(i, step + 1));
                    }

                    i += step;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
