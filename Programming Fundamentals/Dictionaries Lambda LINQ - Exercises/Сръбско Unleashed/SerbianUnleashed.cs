namespace Сръбско_Unleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SerbianUnleashed
    {
        public static void Main(string[] args)
        {
            // Input Eg.: Mile Kitic @Sunny Beach 21 3500
            Dictionary<string, Dictionary<string, long>> statisticVenueSingerMoney = new Dictionary<string, Dictionary<string, long>>();
            FillDictionary(statisticVenueSingerMoney);
            PrintStat(statisticVenueSingerMoney);
        }

        private static void PrintStat(Dictionary<string, Dictionary<string, long>> statistics)
        {
            // Venues should be kept in the same order they were entered, the singers should be sorted by how much money they have made in descending order. If two singers have made the same amount of money, keep them in the order in which they were entered
            foreach (KeyValuePair<string, Dictionary<string, long>> venue in statistics)
            {
                Console.WriteLine(venue.Key);
                foreach (KeyValuePair<string, long> singer in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }

        private static void FillDictionary(Dictionary<string, Dictionary<string, long>> statisticVenueSingerMoney)
        {
            while (true)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                if (input[0].ToLower().Equals("end"))
                {
                    return;
                }
                else if (!IsValid(input))
                {
                    continue;
                }

                // Input Eg.: Mile Kitic @Sunny Beach 21 3500
                string venue = GetVenue(input);
                long money = GetMoney(input);
                string singer = string.Join(" ", input);

                if (!statisticVenueSingerMoney.ContainsKey(venue))
                {
                    statisticVenueSingerMoney[venue] = new Dictionary<string, long>();
                }

                if (statisticVenueSingerMoney[venue].ContainsKey(singer))
                {
                    statisticVenueSingerMoney[venue][singer] += money;
                }
                else
                {
                    statisticVenueSingerMoney[venue][singer] = money;
                }
            }
        }

        private static long GetMoney(List<string> s)
        {
            long allMoney = long.Parse(s[s.Count - 1]) * long.Parse(s[s.Count - 2]);
            s.RemoveAt(s.Count - 1);
            s.RemoveAt(s.Count - 1);
            return allMoney;
        }

        private static string GetVenue(List<string> s)
        {
            string place = string.Empty;
            bool isAtPlaceName = false;
            for (int i = 0; i < s.Count; i++)
            {
                if (char.IsDigit(s[i][0]))
                {
                    break;
                }

                if (isAtPlaceName)
                {
                    place += " " + s[i];
                    s.RemoveAt(i);
                    i--;
                }
                else if (s[i][0] == '@')
                {
                    isAtPlaceName = true;
                    place += s[i].Substring(1);
                    s.RemoveAt(i);
                    i--;
                }
            }

            return place;
        }

        private static Boolean IsValid(List<string> s)
        {
            bool result = false;
            foreach (var word in s)
            {
                if (word.Length < 1)
                {
                    return false;
                }
                else if (word[0] == '@')
                {
                    result = true;
                }
            }

            if (char.IsDigit(s[s.Count - 1][0]) && char.IsDigit(s[s.Count - 2][0]))
            {
                return result;
            }
            else
            {
                return false;
            }
        }
    }
}
