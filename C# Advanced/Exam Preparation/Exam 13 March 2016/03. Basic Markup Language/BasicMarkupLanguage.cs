namespace _03.Basic_Markup_Language
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class BasicMarkupLanguage
    {
        public static void Main()
        {
            var outputLines = GetInputFromConsole();
            Console.WriteLine(outputLines);
        }

        private static StringBuilder GetInputFromConsole()
        {
            var outputLines = new StringBuilder();
            var lineNumber = 1;
            var input = Console.ReadLine();

            while (input != "<stop/>")
            {
                var match = Regex.Match(input, @"<\s*(reverse|repeat|inverse)[\s\S]+?(value\s*=\s*""\s*([0-9]+)\s*""\s*)*content\s*=\s*""([\s\S]+?)""\s*\/\s*>");

                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }

                var commandResult = ExecuteInputCommand(match);
                int repeatValue;
                var isCommandRepeat = int.TryParse(match.Groups[3].Value, out repeatValue);

                if (isCommandRepeat)
                {
                    for (int i = 0; i < repeatValue; i++)
                    {
                        outputLines.AppendLine($"{lineNumber}. {match.Groups[4]}");
                        lineNumber++;
                    }
                }
                else  if (!string.IsNullOrEmpty(commandResult))
                {
                    outputLines.AppendLine($"{lineNumber}. {commandResult}");
                    lineNumber++;
                }

                input = Console.ReadLine();
            }

            return outputLines;
        }

        private static string ExecuteInputCommand(Match match)
        {
            switch (match.Groups[1].Value)
            {
                case "inverse":
                    return string.Join(string.Empty, match.Groups[4].Value
                        .ToCharArray()
                        .Select(c => char.IsLower(c)
                            ? c = char.ToUpper(c)
                            : c = char.ToLower(c)));
                case "reverse":
                    return string.Join(string.Empty, match.Groups[4].Value
                        .ToCharArray()
                        .Reverse());
                default:
                    return null;
            }
        }
    }
}
