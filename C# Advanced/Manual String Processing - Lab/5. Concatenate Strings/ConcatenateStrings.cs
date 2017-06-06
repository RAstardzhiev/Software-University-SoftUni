namespace _5.Concatenate_Strings
{
    using System;
    using System.Text;

    public class ConcatenateStrings
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var textCollector = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                textCollector.Append($"{Console.ReadLine()} ");
            }

            Console.WriteLine(textCollector);
        }
    }
}
