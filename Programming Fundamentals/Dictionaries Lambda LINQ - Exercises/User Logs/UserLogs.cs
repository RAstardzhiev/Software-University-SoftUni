namespace User_Logs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserLogs
    {
        public static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> userIpCount = new SortedDictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[0].ToLower().Equals("end"))
                {
                    break;
                }

                input = input
                    .Select(x => x.Substring(x.IndexOf('=') + 1))
                    .ToArray();

                if (userIpCount.ContainsKey(input[2]))
                {
                    if (userIpCount[input[2]].ContainsKey(input[0]))
                    {
                        userIpCount[input[2]][input[0]]++;
                    }
                    else
                    {
                        userIpCount[input[2]][input[0]] = 1;
                    }
                }
                else
                {
                    userIpCount[input[2]] = new Dictionary<string, int>();
                    userIpCount[input[2]][input[0]] = 1;
                }
            }

            PrintUserData(userIpCount);
        }

        private static void PrintUserData(SortedDictionary<string, Dictionary<string, int>> userIpCount)
        {
            foreach (KeyValuePair<string, Dictionary<string, int>> user in userIpCount)
            {
                Console.WriteLine(user.Key + ":");
                List<string> userData = new List<string>();
                foreach (KeyValuePair<string, int> ip in userIpCount[user.Key])
                {
                    // 192.23.30.40 => 2
                    userData.Add($"{ip.Key} => {ip.Value}");
                }

                Console.WriteLine(string.Join(", ", userData) + ".");
            }
        }
    }
}
