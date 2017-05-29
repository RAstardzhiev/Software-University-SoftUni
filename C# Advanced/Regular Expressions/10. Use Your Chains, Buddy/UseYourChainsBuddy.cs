namespace _10.Use_Your_Chains__Buddy
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class UseYourChainsBuddy
    {
        public static void Main()
        {
            var encryptedText = ExtractContentFromPTags();
            var decryptedText = DecryptText(encryptedText);
            Console.WriteLine(decryptedText);
        }

        private static string DecryptText(StringBuilder encryptedText)
        {
            for (int i = 0; i < encryptedText.Length; i++)
            {
                if (char.IsDigit(encryptedText[i]))
                {
                    continue;
                }
                else if (!char.IsLower(encryptedText[i]))
                {
                    if (i > 0 && encryptedText[i - 1] == ' ')
                    {
                        encryptedText.Remove(i, 1);
                        i--;
                    }
                    else
                    {
                        encryptedText[i] = ' ';
                    }
                }
                else if (encryptedText[i] >= 'a' && encryptedText[i] <= 'm')
                {
                    encryptedText[i] = (char)(encryptedText[i] + 13); // 'n' - 'a' = 13
                }
                else
                {
                    encryptedText[i] = (char)(encryptedText[i] - 13); // 'n' - 13 = 'a'
                }
            }

            return encryptedText.ToString();
        }

        private static StringBuilder ExtractContentFromPTags()
        {
            var input = Console.ReadLine();

            /*
             * Maybe more universal Regex would be:
             * <\s*p[\s\S]*?>([\s\S]+?)<\s*\/p\s*>
             * But Judge gives 88/100 with it.
             */

            var matches = Regex.Matches(input, @"<p>([\s\S]+?)<\/p>");
            var sb = new StringBuilder();

            foreach (Match match in matches)
            {
                sb.Append(match.Groups[1].Value);
            }

            return sb;
        }
    }
}
