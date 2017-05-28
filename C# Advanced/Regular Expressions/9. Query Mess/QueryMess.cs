namespace _9.Query_Mess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class QueryMess
    {
        public static void Main()
        {
            Console.WriteLine(TransformDataFromInput());
        }

        private static string TransformDataFromInput()
        {
            var input = Console.ReadLine();
            var stringBuilder = new StringBuilder();

            while (input != "END")
            {
                var withoutUrl = input.Substring(input.LastIndexOf('?') + 1);
                var separated = withoutUrl.Split('&');

                var transformedLine = new Dictionary<string, Queue<string>>();

                foreach (var item in separated)
                {
                    var kvp = item.Split('=');
                    if (kvp.Length < 2)
                    {
                        continue;
                    }

                    kvp[0] = ClearExcessSpaces(kvp[0]);
                    kvp[1] = ClearExcessSpaces(kvp[1]);

                    if (!transformedLine.ContainsKey(kvp[0]))
                    {
                        transformedLine[kvp[0]] = new Queue<string>();
                    }

                    transformedLine[kvp[0]].Enqueue(kvp[1]);
                }

                AddLineToTheResult(stringBuilder, transformedLine);
                input = Console.ReadLine();
            }

            return stringBuilder.ToString();
        }

        private static void AddLineToTheResult(StringBuilder stringBuilder, Dictionary<string, Queue<string>> transformedLine)
        {
            foreach (var item in transformedLine)
            {
                stringBuilder.Append($"{item.Key}=[{string.Join(", ", item.Value)}]");
            }

            stringBuilder.Append(Environment.NewLine);
        }

        private static string ClearExcessSpaces(string str)
        {
            return string.Join(" ", str.Split(new string[] { "%20", "+" }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
