namespace _03.NMS
{
    using System;
    using System.Text;

    public class NMS
    {
        public static void Main()
        {
            var nms = GetNMS();
            var separatedText = PutDelimiter(nms);
            Console.WriteLine(separatedText);
        }

        private static string PutDelimiter(char[] nms)
        {
            if (nms == null || nms.Length < 1)
            {
                return string.Empty;
            }

            var delimiter = Console.ReadLine();
            var separatedText = new StringBuilder();
            separatedText.Append(nms[0]);

            for (int i = 1; i < nms.Length; i++)
            {
                if (char.ToLower(nms[i - 1]) > char.ToLower(nms[i]))
                {
                    separatedText.Append(delimiter);
                }

                separatedText.Append(nms[i]);
            }

            return separatedText.ToString();
        }

        private static char[] GetNMS()
        {
            var text = new StringBuilder();
            var input = Console.ReadLine();

            while (input != "---NMS SEND---")
            {
                text.Append(input);
                input = Console.ReadLine();
            }

            return text.ToString().ToCharArray();
        }
    }
}
