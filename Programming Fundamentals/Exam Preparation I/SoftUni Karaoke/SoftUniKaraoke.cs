namespace SoftUni_Karaoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniKaraoke
    {
        public static void Main(string[] args)
        {
            Dictionary<string, List<string>> performances = GetInput();

            if (performances.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (KeyValuePair<string, List<string>> performer in performances)
                {
                    Console.WriteLine($"{performer.Key}: {performer.Value.Count} awards");
                    foreach (string award in performer.Value)
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }

        private static Dictionary<string, List<string>> GetInput()
        {
            string[] participants = Console.ReadLine().Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            string[] songs = Console.ReadLine().Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

            Dictionary<string, List<string>> performances = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] performance = Console.ReadLine().Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                if (performance[0].ToLower().Trim(" \t".ToCharArray()).Equals("dawn"))
                {
                    break;
                }

                string singer = performance[0];
                string song = performance[1];
                string award = performance[2];

                if (participants.Any(x => x.Equals(singer) && songs.Any(y => y.Equals(song))))
                {
                    if (!performances.ContainsKey(singer))
                    {
                        performances[singer] = new List<string>();
                    }

                    performances[singer].Add(award);
                }
            }

            return performances
                .OrderByDescending(x => x.Value.Distinct().ToList().Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value.Distinct().OrderBy(award => award).ToList());
        }
    }
}
