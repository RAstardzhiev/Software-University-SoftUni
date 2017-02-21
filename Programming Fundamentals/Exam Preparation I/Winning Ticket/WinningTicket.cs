namespace Winning_Ticket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class WinningTicket
    {
        public static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                .Split(", \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Regex winningPattern = new Regex(@"\@{6,}|#{6,}|\${6,}|\^{6,}");

            foreach (string ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string leftMatch = winningPattern.Match(ticket, 0, 10).Value;
                string rightMatch = winningPattern.Match(ticket, 10).Value;

                if (leftMatch.Length > 0 && rightMatch.Length > 0)
                {
                    if (leftMatch.Length == 10 && leftMatch.Equals(rightMatch))
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - 10{leftMatch[0]} Jackpot!");
                    }
                    else if (leftMatch.Contains(rightMatch) || rightMatch.Contains(leftMatch))
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(leftMatch.Length, rightMatch.Length)}{leftMatch[0]}");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}
