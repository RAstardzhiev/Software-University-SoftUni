namespace _2.SoftUni_Party
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniParty
    {
        public static void Main()
        {
            var invitations = ReadInput("PARTY");
            var participants = ReadInput("END");
            var didntCame = GetDiff(invitations, participants);

            var vipsToPrint = didntCame.Where(x => char.IsDigit(x[0])).OrderBy(x => x).ToArray();
            var othersToPrint = didntCame.Where(x => !char.IsDigit(x[0])).OrderBy(x => x).ToArray();

            Console.WriteLine(didntCame.Count);

            if (vipsToPrint.Length > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, vipsToPrint));
            }

            if (othersToPrint.Length > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, othersToPrint));
            }
        }

        private static Stack<string> GetDiff(HashSet<string> invitations, HashSet<string> participants)
        {
            var diff = new Stack<string>();

            foreach (var code in invitations)
            {
                if (!participants.Contains(code))
                {
                    diff.Push(code);
                }
            }

            return diff;
        }

        private static HashSet<string> ReadInput(string endOfInput)
        {
            var input = Console.ReadLine();
            var codes = new HashSet<string>();

            while (input != endOfInput)
            {
                codes.Add(input);
                input = Console.ReadLine();
            }

            return codes;
        }
    }
}
