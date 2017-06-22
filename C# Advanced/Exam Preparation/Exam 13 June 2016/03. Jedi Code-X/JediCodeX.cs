namespace _03.Jedi_Code_X
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class JediCodeX
    {
        public static void Main()
        {
            var encryptedText = GetEncryptedText();

            var namePrefixPattern = Console.ReadLine();
            var messagePrefixPattern = Console.ReadLine();

            var names = ExtractCollection(ref encryptedText, ref namePrefixPattern, false);
            var messages = ExtractCollection(ref encryptedText, ref messagePrefixPattern, true);

            PrintJedisMessages(names, messages);
        }

        private static void PrintJedisMessages(List<string> names, List<string> messages)
        {
            var indexesOfMessage = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var jedis = new StringBuilder();

            for (int i = 0; i < names.Count; i++)
            {
                if (i < indexesOfMessage.Length && indexesOfMessage[i] > 0 && indexesOfMessage[i] <= messages.Count)
                {
                    jedis.Append($"{names[i]} - {messages[indexesOfMessage[i] - 1]}{Environment.NewLine}");
                }
                else
                {
                    break;
                }
            }

            Console.Write(jedis);
        }

        private static List<string> ExtractCollection(ref string encryptedText, ref string prefixPattern, bool canHaveDigits)
        {
            var collection = new List<string>();
            var indexOfPattern = encryptedText.IndexOf(prefixPattern);

            while (indexOfPattern >= 0)
            {
                var startIndexOfMatch = indexOfPattern + prefixPattern.Length;

                if (startIndexOfMatch >= encryptedText.Length - prefixPattern.Length)
                {
                    break;
                }

                if (char.IsLetter(encryptedText[startIndexOfMatch + prefixPattern.Length]) ||
                    canHaveDigits && char.IsDigit(encryptedText[startIndexOfMatch + prefixPattern.Length]))
                {
                    indexOfPattern = encryptedText.IndexOf(prefixPattern, indexOfPattern + 1);
                    continue;
                }

                var match = encryptedText.Substring(startIndexOfMatch, prefixPattern.Length);

                if (IsValid(match, canHaveDigits))
                {
                    collection.Add(match);
                }

                indexOfPattern = encryptedText.IndexOf(prefixPattern, indexOfPattern + 1);
            }

            return collection;
        }

        private static bool IsValid(string match, bool canHaveDigits)
        {
            for (int i = 0; i < match.Length; i++)
            {
                if (!char.IsLetter(match[i]))
                {
                    if (canHaveDigits && char.IsDigit(match[i]))
                    {
                        continue;
                    }

                    return false;
                }
            }

            return true;
        }

        private static string GetEncryptedText() 
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            var input = new StringBuilder();

            while (numberOfLines > 0)
            {
                input.Append(Console.ReadLine());
                numberOfLines--;
            }

            return input.ToString();
        }
    }
}
