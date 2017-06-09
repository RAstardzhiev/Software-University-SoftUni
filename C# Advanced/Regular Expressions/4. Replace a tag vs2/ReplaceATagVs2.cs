namespace _4.Replace_a_tag_vs2
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class ReplaceATagVs2
    {
        public static void Main()
        {
            var pattern = @"<a.{0,}?(href=?(['|""]?).+?\2).{0,}?>(.+?)<\/a>";
            var replacedHtml = new StringBuilder();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var replacedLine = Regex.Replace(input, pattern, m => $"[URL {m.Groups[1].Value}]{m.Groups[3].Value}[/URL]");
                replacedHtml.Append($"{replacedLine}{Environment.NewLine}");

                input = Console.ReadLine();
            }

            Console.Write(replacedHtml.ToString());
        }
    }
}
