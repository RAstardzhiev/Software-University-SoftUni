namespace _13.Srabsko_Unleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SrabskoUnleashed
    {
        public static void Main()
        {
            var townSingerMoney = new Dictionary<string, Dictionary<string, long>>();

            // Get Performance data from the console and assign values to the dictionary// Input Format: "singer @venue ticketsPrice ticketsCount"
            while (true)
            {
                var performanceData = Console.ReadLine().Trim();
                if (performanceData.ToLower() == "end")
                {
                    break;
                }

                // Validate input - Format: "singer @venue ticketsPrice ticketsCount"
                var indexOfSeparation = performanceData.IndexOf(" @");
                if (indexOfSeparation < 1)
                {
                    continue;
                }

                var indexOfTicketPrice = IndexOfTicketPrice(performanceData);
                if (indexOfTicketPrice < 0 || performanceData[indexOfTicketPrice - 1] != ' ')
                {
                    continue;
                }

                var indexOfTicketsAmount = performanceData.LastIndexOf(' ');
                if (indexOfTicketsAmount < indexOfTicketPrice + 1)
                {
                    continue;
                }

                // Parse input to dictionary
                var singer = performanceData.Substring(0, indexOfSeparation);
                var town = performanceData.Substring(indexOfSeparation + 2, indexOfTicketPrice - (indexOfSeparation + 2) - 1);
                var priceOfATicket = long.Parse(performanceData.Substring(indexOfTicketPrice, indexOfTicketsAmount - indexOfTicketPrice).Trim());
                var ticketsAmount = long.Parse(performanceData.Substring(indexOfTicketsAmount + 1));

                if (!townSingerMoney.ContainsKey(town))
                {
                    townSingerMoney[town] = new Dictionary<string, long>();
                }

                if (!townSingerMoney[town].ContainsKey(singer))
                {
                    townSingerMoney[town][singer] = 0;
                }

                townSingerMoney[town][singer] += priceOfATicket * ticketsAmount;
            }

            // Print singers
            foreach (var town in townSingerMoney)
            {
                Console.WriteLine(town.Key);
                foreach (var singer in town.Value.OrderByDescending(kvp => kvp.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }

        private static int IndexOfTicketPrice(string performanceData)
        {
            for (int i = performanceData.Length - 1; i >= 6; i--)
            {
                if (char.IsLetter(performanceData[i]))
                {
                    return i + 2;
                }
            }

            return -1;
        }
    }
}
