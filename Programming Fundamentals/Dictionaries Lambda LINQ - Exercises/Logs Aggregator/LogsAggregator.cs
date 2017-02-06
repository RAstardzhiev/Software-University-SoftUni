namespace Logs_Aggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LogsAggregator
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, SortedDictionary<string, int>> userIpDuration = new SortedDictionary<string, SortedDictionary<string, int>>();
            
            // Input <IP> <user> <duration> 
            // Example: 192.168.0.11 peter 33
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (!userIpDuration.ContainsKey(input[1]))
                {
                    userIpDuration[input[1]] = new SortedDictionary<string, int>();
                }

                if (userIpDuration[input[1]].ContainsKey(input[0]))
                {
                    userIpDuration[input[1]][input[0]] += int.Parse(input[2]);
                }
                else
                {
                    userIpDuration[input[1]][input[0]] = int.Parse(input[2]);
                }
            }

            foreach (KeyValuePair<string, SortedDictionary<string, int>> user in userIpDuration)
            {
                Console.Write($"{user.Key}: {user.Value.Values.Sum()} [");
                List<string> ips = user.Value.Keys.ToList();
                Console.WriteLine(string.Join(", ", ips) + "]");
            }
        }
    }
}
