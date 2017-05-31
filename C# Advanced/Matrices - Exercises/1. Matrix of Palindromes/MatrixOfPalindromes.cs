namespace _1.Matrix_of_Palindromes
{
    using System;
    using System.Linq;
    using System.Text;

    public class MatrixOfPalindromes
    {
        public static void Main()
        {
            Console.WriteLine(BuildMatrix());
        }

        private static string BuildMatrix()
        {
            var dimensions = ParseInput();

            if (dimensions == null)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();

            for (int i = 0; i < dimensions[0]; i++)
            {
                for (int j = 0; j < dimensions[1]; j++)
                {
                    var borderChar = (char)('a' + i);
                    var middleChar = (char)(borderChar + j);
                    sb.Append($"{borderChar}{middleChar}{borderChar} ");
                }

                if (i != dimensions[0] - 1)
                {
                    sb.Append(Environment.NewLine);
                }
            }

            return sb.ToString();
        }

        private static int[] ParseInput()
        {
            int[] result = null;

            try
            {
                result = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
        }
    }
}
