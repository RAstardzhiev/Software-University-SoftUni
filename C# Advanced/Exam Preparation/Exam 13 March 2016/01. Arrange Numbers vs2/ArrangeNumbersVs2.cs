namespace _01.Arrange_Numbers_vs2
{
    using System;
    using System.Linq;
    using System.Text;

    public class ArrangeNumbersVs2
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(str => str.Length > 1 ? str.TrimStart('0') : str)
                .OrderBy(n => GetName(n));

            Console.WriteLine(string.Join(", ", numbers));
        }

        private static string GetName(string num)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < num.Length; i++)
            {
                switch (num[i])
                {
                    case '0':
                        sb.Append("zero-");
                        break;
                    case '1':
                        sb.Append("one-");
                        break;
                    case '2':
                        sb.Append("two-");
                        break;
                    case '3':
                        sb.Append("three-");
                        break;
                    case '4':
                        sb.Append("four-");
                        break;
                    case '5':
                        sb.Append("five-");
                        break;
                    case '6':
                        sb.Append("six-");
                        break;
                    case '7':
                        sb.Append("seven-");
                        break;
                    case '8':
                        sb.Append("eight-");
                        break;
                    case '9':
                        sb.Append("nine-");
                        break;
                    default:
                        break;
                }
            }

            return sb.ToString();
        }
    }
}
