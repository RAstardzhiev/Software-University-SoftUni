namespace _11.Logs_Aggregator
{
    using System;
    using System.Collections.Generic;

    public class LogsAggregator
    {
        public static void Main()
        {
            SortedDictionary<string, UserStat> userData = GetInput();

            foreach (var user in userData)
            {
                Console.WriteLine($"{user.Key}: {user.Value.Duration} [{string.Join(", ", user.Value.IpHIstory)}]");
            }
        }

        private static SortedDictionary<string, UserStat> GetInput()
        {
            var userData = new SortedDictionary<string, UserStat>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var ipAddress = input[0];
                var username = input[1];
                var duration = int.Parse(input[2]);

                if (!userData.ContainsKey(username))
                {
                    userData[username] = new UserStat
                    {
                        IpHIstory = new SortedSet<string>(),
                        Duration = 0
                    };
                }

                userData[username].IpHIstory.Add(ipAddress);
                userData[username].Duration += duration;
            }

            return userData;
        }
    }
}
