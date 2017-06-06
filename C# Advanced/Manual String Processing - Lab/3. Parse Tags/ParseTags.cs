namespace _3.Parse_Tags
{
    using System;

    public class ParseTags
    {
        public const string OpenTag = "<upcase>";
        public const string CloseTag = "</upcase>";

        public static void Main()
        {
            var text = Console.ReadLine();

            var indexOfOpenTag = text.IndexOf(OpenTag);

            while (indexOfOpenTag >= 0)
            {
                var indexOfTextEnd = text.IndexOf(CloseTag, indexOfOpenTag);

                if (indexOfTextEnd < 0)
                {
                    break;
                }

                var indexOfCloseTagEnd = indexOfTextEnd + CloseTag.Length;
                var indexOfTextStart = indexOfOpenTag + OpenTag.Length;

                var textToReplace = text.Substring(indexOfOpenTag, indexOfCloseTagEnd - indexOfOpenTag);
                var replacedText = text.Substring(indexOfTextStart, indexOfTextEnd - indexOfTextStart).ToUpper();

                text = text.Replace(textToReplace, replacedText);

                indexOfOpenTag = text.IndexOf(OpenTag);
            }

            Console.WriteLine(text);
        }
    }
}
