namespace _9.User_Logs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserLogs
    {
        public static void Main()
        {
            /*
             * The usernames must be sorted alphabetically 
             * While their IP addresses should be displayed in the order of their first appearance
             */
            SortedDictionary<string, Dictionary<string, int>> userIpCount = CollectUserData();

            foreach (var user in userIpCount)
            {
                Console.WriteLine($"{user.Key}:{Environment.NewLine}{string.Join(", ", user.Value.Select(kvp => $"{kvp.Key} => {kvp.Value}"))}.");
            }
        }

        private static SortedDictionary<string, Dictionary<string, int>> CollectUserData()
        {
            var userIpCount = new SortedDictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var userData = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var ipPredicate = userData[0].IndexOf("IP=");
                var userPredicate = userData[2].IndexOf("user=");

                if (userData.Length != 3 || ipPredicate < 0 || userPredicate < 0)
                {
                    input = Console.ReadLine();
                    continue;
                }

                var ipAddress = userData[0].Substring(ipPredicate + 3);
                var username = userData[2].Substring(userPredicate + 5);

                if (!userIpCount.ContainsKey(username))
                {
                    userIpCount[username] = new Dictionary<string, int>();
                }

                if (!userIpCount[username].ContainsKey(ipAddress))
                {
                    userIpCount[username][ipAddress] = 0;
                }

                userIpCount[username][ipAddress]++;

                input = Console.ReadLine();
            }

            return userIpCount;
        }
    }
}
