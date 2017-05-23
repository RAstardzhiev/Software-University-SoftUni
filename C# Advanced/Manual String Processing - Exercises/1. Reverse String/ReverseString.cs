namespace _1.Reverse_String
{
    using System;
    using System.Text;

    public class ReverseString
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(Reversr(input));
        }

        private static string Reversr(string initial)
        {
            StringBuilder reversed = new StringBuilder(initial.Length);

            for (int i = initial.Length - 1; i >= 0; i--)
            {
                reversed.Append(initial[i]);
            }

            return reversed.ToString();
        }
    }
}
