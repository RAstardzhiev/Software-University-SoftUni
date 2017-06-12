namespace _10.Predicate_Party_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PredicateParty
    {
        public static void Main()
        {
            var comming = new List<string>();
            AddNames(comming);
            ExecuteCommands(comming);
            PrintCommingList(comming);
        }

        private static void PrintCommingList(List<string> comming)
        {
            var names = string.Join(", ", comming.OrderBy(n => n));
            Console.WriteLine($"{names} are going to the party!");
        }

        private static void ExecuteCommands(List<string> comming)
        {
            var command = Console.ReadLine().Split();

            while (command[0] != "Party!")
            {
                if (command.Length < 3)
                {
                    command = Console.ReadLine().Split();
                    continue;
                }

                switch (command[1])
                {
                    case "StartsWith":
                        ForeachName(command[0], comming, n => n.StartsWith(command[2]));
                                break;
                    case "EndsWith":
                        ForeachName(command[0], comming, n => n.EndsWith(command[2]));
                        break;
                    case "Length":
                        ForeachName(command[0], comming, n => n.Length == int.Parse(command[2]));
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().Split();
            }
        }

        private static void ForeachName(string command, List<string> comming, Func<string, bool> condition)
        {
            for (int i = comming.Count - 1; i >= 0; i--)
            {
                if (condition(comming[i]))
                {
                    switch (command)
                    {
                        case "Remove":
                            comming.RemoveAt(i);
                            break;
                        case "Double":
                            comming.Add(comming[i]);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private static void AddNames(List<string> comming)
        {
            var input = Console.ReadLine().Split();

            foreach (var name in input)
            {
                comming.Add(name);
            }
        }
    }
}
