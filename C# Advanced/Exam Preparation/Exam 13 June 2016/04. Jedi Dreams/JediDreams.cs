namespace _04.Jedi_Dreams
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class JediDreams
    {
        public const string MethodDeclarationPattern = @"static\s+.*\s+([a-zA-Z]*[A-Z][a-zA-Z]*)\s*\(";
        public const string CallPattern = @"([a-zA-Z]*[A-Z][a-zA-Z]*)\s*\(";

        public static void Main()
        {
            var methods = GetMethodsFromInput();
            PrintMethods(methods);
        }

        private static void PrintMethods(Stack<Method> methods)
        {
            var sb = new StringBuilder();

            foreach (var method in methods
                .OrderByDescending(m => m.CalledMethods.Count)
                .ThenBy(m => m.Name))
            {
                sb.Append($"{method.Name} -> ");

                if (method.CalledMethods.Count == 0)
                {
                    sb.Append("None");
                }
                else
                {
                    sb.Append($"{method.CalledMethods.Count} -> ");
                    sb.Append(string.Join(", ", method.CalledMethods.OrderBy(call => call)));
                }

                sb.Append(Environment.NewLine);
            }

            Console.Write(sb);
        }

        private static Stack<Method> GetMethodsFromInput()
        {
            var methods = new Stack<Method>();
            var numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                var line = Console.ReadLine();

                var methodMatch = Regex.Match(line, MethodDeclarationPattern);
                var callMatches = Regex.Matches(line, CallPattern);

                if (methodMatch.Success)
                {
                    methods.Push(new Method
                    {
                        Name = methodMatch.Groups[1].Value,
                        CalledMethods = new Queue<string>()
                    });
                }
                else
                {
                    foreach (Match match in callMatches)
                    {
                        methods.Peek().CalledMethods.Enqueue(match.Groups[1].Value);
                    }
                }
            }

            return methods;
        }
    }
}
