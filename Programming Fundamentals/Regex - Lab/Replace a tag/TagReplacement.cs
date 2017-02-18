namespace Replace_a_tag
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class TagReplacement
    {
        public static void Main(string[] args)
        {
            /*
             *Write a program that replaces in a HTML document given as string all the tags <a href=…>…</a> 
             * with corresponding tags [URL href=…>…[/URL]. Read an input, until you receive “end” command. 
             * Print the result on the console.  
             */
            List<string> html = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower().Equals("end"))
                {
                    break;
                }

                html.Add(input);
            }

            Regex regex = new Regex(@"<a.*(href=.*>?)>(.*)<\/a>");

            foreach (string line in html)
            {
                string result = regex.Replace(line, "[URL $1]$2[/URL]");

                Console.WriteLine(result);
            }
        }
    }
}
