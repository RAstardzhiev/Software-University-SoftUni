namespace _03.Cubic_Messages
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class CubicMessages
    {
        public static void Main()
        {
            var messages = GetMessages();
            Console.Write(messages);
        }

        private static StringBuilder GetMessages()
        {
            var messages = new StringBuilder();
            var input = Console.ReadLine();

            while (input != "Over!")
            {
                var messageLength = int.Parse(Console.ReadLine());
                var match = Regex.Match(input, "^([0-9]+)([a-zA-Z]+)([^a-zA-Z]*)$");

                if (match.Success && match.Groups[2].Value.Length == messageLength)
                {
                    var message = match.Groups[2].Value;
                    messages.Append($"{message} == ");
                    var digitsString = $"{match.Groups[1].Value}{ExtractDigits(match.Groups[3].Value)}";

                    for (int i = 0; i < digitsString.Length; i++)
                    {
                        var index = int.Parse($"{digitsString[i]}");

                        if (index >= 0 && index < message.Length)
                        {
                            messages.Append(message[index]);
                        }
                        else
                        {
                            messages.Append(' ');
                        }
                    }

                    messages.Append(Environment.NewLine);
                }

                input = Console.ReadLine();
            }

            return messages;
        }

        private static string ExtractDigits(string str)
        {
            var result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();
        }
    }
}
