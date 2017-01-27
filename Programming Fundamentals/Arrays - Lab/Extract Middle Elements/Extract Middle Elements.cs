namespace Extract_Middle_Elements
{
    using System;

    public class Extract_Middle_Elements
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] numbers = new int[input.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            WriteTheMiddle(numbers);
        }

        public static void WriteTheMiddle(int[] n)
        {
            if (n.Length == 1)
            {
                Console.WriteLine($"{{ {n[0]} }}");
            }
            else if (n.Length % 2 == 0)
            {
                // n/2-1 and n/2
                Console.WriteLine($"{{ {n[n.Length / 2 - 1]}, {n[n.Length / 2]} }}");
            }
            else
            {
                // n/2-1, n/2, n/2+1
                Console.WriteLine($"{{ {n[n.Length / 2 - 1]}, {n[n.Length / 2]}, {n[n.Length / 2 + 1]}}}");
            }
        }
    }
}
