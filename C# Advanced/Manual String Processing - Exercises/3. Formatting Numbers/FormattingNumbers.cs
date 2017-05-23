namespace _3.Formatting_Numbers
{
    using System;

    public class FormattingNumbers
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split("\n\r\t ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            int a = int.Parse(input[0]);
            double b = double.Parse(input[1]);
            double c = double.Parse(input[2]);

            string firstColInHex = $"|{a.ToString("X").PadRight(10, ' ')}";
            string secondColBinary = $"|{Convert.ToString(a, 2).PadLeft(10, '0').Substring(0, 10)}";
            string thirdCol = $"{b:F2}";
            string fourthCol = $"{c:F3}";

            Console.WriteLine($"{firstColInHex}{secondColBinary}|{thirdCol.PadLeft(10, ' ')}|{fourthCol.PadRight(10, ' ')}|");
        }
    }
}
