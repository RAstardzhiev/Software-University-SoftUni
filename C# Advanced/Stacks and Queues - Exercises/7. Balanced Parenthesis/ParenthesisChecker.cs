namespace _7.Balanced_Parenthesis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ParenthesisChecker
    {
        public static void Main()
        {
            var openParenthesis = new char[]
            {
                '[',
                '(',
                '{'
            };

            var closeParenthesis = new char[]
            {
                ']',
                ')',
                '}'
            };

            var input = Console.ReadLine().ToCharArray();
            var parenthesisHystory = new Stack<char>();
            var areBalanced = true;

            foreach (var symbol in input)
            {
                if (openParenthesis.Contains(symbol))
                {
                    parenthesisHystory.Push(symbol);
                    continue;
                }

                if (closeParenthesis.Contains(symbol))
                {
                    if (parenthesisHystory.Count == 0)
                    {
                        areBalanced = false;
                        break;
                    }

                    var openedWith = parenthesisHystory.Pop();

                    if (!CheckBalance(openedWith, symbol))
                    {
                        areBalanced = false;
                        break;
                    }
                }
            }

            Console.WriteLine(areBalanced ? "YES" : "NO");
        }

        private static bool CheckBalance(char openedWith, char closedWith)
        {
            switch (openedWith)
            {
                case '(':
                    return (closedWith == ')') ? true : false;
                case '[':
                    return (closedWith == ']') ? true : false;
                case '{':
                    return (closedWith == '}') ? true : false;
                default:
                    return false;
            }
        }
    }
}
