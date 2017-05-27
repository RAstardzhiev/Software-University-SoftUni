namespace _4.Replace_a_tag
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ReplaceATag
    {
        public static void Main()
        {
            var pattern = @"<a.{0,}?(href=?(['|""]?).+?\2).{0,}?>(.+?)<\/a>";
            Queue<string> replacedHtml = new Queue<string>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var replacedLine = Regex.Replace(input, pattern, m => $"[URL {m.Groups[1].Value}]{m.Groups[3].Value}[/URL]");
                replacedHtml.Enqueue(replacedLine);

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, replacedHtml));
        }
    }
}
