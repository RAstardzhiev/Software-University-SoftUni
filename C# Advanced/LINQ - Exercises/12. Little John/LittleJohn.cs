namespace _12.Little_John
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class LittleJohn
    {
        class Arrow
        {
            public string Type { get; set; }

            public int Amount { get; set; }
        }

        public static void Main()
        {
            var arrows = GetArrows();
            var arrowsSum = int.Parse(string.Join(string.Empty, arrows.Select(a => a.Amount)));
            var bin = Convert.ToString(arrowsSum, 2);
            Console.WriteLine(Convert.ToInt32(AppendReversed(bin), 2));
        }

        private static string AppendReversed(string bin)
        {
            var result = bin;

            for (int i = bin.Length - 1; i >= 0; i--)
            {
                result = string.Concat(result, bin[i]);
            }

            return result;
        }

        private static Arrow[] GetArrows()
        {
            var arrows = new Arrow[]
            {
                new Arrow { Type = ">----->", Amount = 0 },
                new Arrow { Type = ">>----->", Amount = 0 },
                new Arrow { Type = ">>>----->>", Amount = 0 }
            };

            for (int i = 0; i < 4; i++)
            {
                var input = Console.ReadLine();
                var matches = Regex.Matches(input, $"(>----->)|(>>----->)|(>>>----->>)");

                foreach (Match mathc in matches)
                {
                    arrows.Where(a => a.Type == mathc.Value).First().Amount++;
                }
            }

            return arrows;
        }
    }
}
