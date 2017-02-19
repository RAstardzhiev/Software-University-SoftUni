namespace UseYourChainsBuddy
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class ParagraphExtractor
    {
        public static void Main(string[] args)
        {
            string[] paragraphTags = GetParagraphs();
            ClearGarbage(paragraphTags);
            DecryptText(paragraphTags);
        }

        private static void DecryptText(string[] paragraphTags)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < paragraphTags.Length; i++)
            {
                for (int j = 0; j < paragraphTags[i].Length; j++)
                {
                    if (paragraphTags[i][j] != ' ')
                    {
                        sb.Append(char.IsDigit(paragraphTags[i][j]) ? paragraphTags[i][j] : DecryptedSymbol(paragraphTags[i][j]));
                    }
                    else
                    {
                        sb.Append(paragraphTags[i][j]);
                    }
                }
            }

            string manual = string.Join(" ", sb
                .ToString()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            Console.WriteLine(manual);
        }

        private static char DecryptedSymbol(char character)
        {
            if (character >= 'n')
            {
                return (char)(character - 13);
            }
            else
            {
                return (char)(character + 13);
            }
        }

        private static void ClearGarbage(string[] paragraphTags)
        {
            Regex regex = new Regex(@"[^a-z0-9]+");

            for (int i = 0; i < paragraphTags.Length; i++)
            {
                paragraphTags[i] = regex.Replace(paragraphTags[i], " ");
            }
        }

        private static string[] GetParagraphs()
        {
            string html = Console.ReadLine();

            Regex regex = new Regex(@"<p>.+?<\/p>");
            MatchCollection matches = regex.Matches(html);

            string[] result = new string[matches.Count];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = matches[i].Value
                    .Replace("</p>", string.Empty)
                    .Remove(0, matches[i].Value.IndexOf('>') + 1);
            }

            return result;
        }
    }
}
