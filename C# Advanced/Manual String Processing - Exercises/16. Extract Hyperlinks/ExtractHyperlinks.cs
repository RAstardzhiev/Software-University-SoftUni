namespace _16.Extract_Hyperlinks
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ExtractHyperlinks
    {
        public static void Main()
        {
            var hyperlinks = ExtractLinks();

            if (hyperlinks.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, hyperlinks));
            }
        }

        private static List<string> ExtractLinks()
        {
            var html = ReadInput();
            var startIndex = html.IndexOf(" href");
            var links = new List<string>();

            while (startIndex >= 0)
            {
                if (!IsAnchorTag(startIndex, html))
                {
                    startIndex = html.IndexOf(" href", startIndex + 1);
                    continue;
                }

                startIndex = html.IndexOf('=', startIndex) + 1;

                // Check because the +1 above
                if (startIndex <= 0 || startIndex > html.Length)
                {
                    continue;
                }

                var link = GetLink(startIndex, html);
                if (link != null)
                {
                    links.Add(link);
                }

                startIndex = html.IndexOf(" href", html.IndexOf("a>", startIndex));
            }

            return links;
        }

        private static string GetLink(int startIndex, string html)
        {
            var linkStarstAt = -1;
            for (int i = startIndex; i < html.Length; i++)
            {
                if (html[i] != ' ')
                {
                    linkStarstAt = i;
                    break;
                }
            }

            var linkEndsAt = -1;
            switch (html[linkStarstAt])
            {
                case '"':
                    linkEndsAt = html.IndexOf('"', linkStarstAt + 1);
                    break;
                case '\'':
                    linkEndsAt = html.IndexOf('\'', linkStarstAt + 1);
                    break;
                default:

                    for (int i = linkStarstAt; i < html.Length; i++)
                    {
                        if (html[i] == '>' || html[i] == ' ')
                        {
                            linkEndsAt = i;
                            break;
                        }
                    }

                    break;
            }

            if (linkStarstAt < 0 || linkEndsAt < 0)
            {
                return null;
            }

            return html
                .Substring(linkStarstAt, linkEndsAt - linkStarstAt)
                .Trim(new char[] { '"', '\'', ' ' } );
        }

        private static bool IsAnchorTag(int startLinkIndex, string html)
        {
            var tagOpenIndex = html.LastIndexOf('<', startLinkIndex);
            return html[tagOpenIndex + 1] == 'a';
        }

        private static string ReadInput()
        {
            StringBuilder html = new StringBuilder();

            var inpulLine = Console.ReadLine();

            while (inpulLine != "END")
            {
                html.Append(inpulLine);
                inpulLine = Console.ReadLine();
            }

            return html.ToString()
                .Replace('\n', ' ')
                .Replace('\r', ' ')
                .Replace('\t', ' ');
        }
    }
}
