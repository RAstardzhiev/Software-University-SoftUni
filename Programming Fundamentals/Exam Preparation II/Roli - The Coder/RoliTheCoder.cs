namespace Roli___The_Coder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RoliTheCoder
    {
        public static void Main(string[] args)
        {
            List<Event> events = GetFromInput();
            PrintEvents(events);
        }

        private static void PrintEvents(List<Event> events)
        {
            for (int i = 0; i < events.Count; i++)
            {
                events[i].Participants = events[i].Participants
                    .Distinct()
                    .OrderBy(x => x)
                    .ToList();
            }

            events = events
                .OrderByDescending(e => e.Participants.Count)
                .ThenBy(e => e.Name)
                .ToList();

            for (int i = 0; i < events.Count; i++)
            {
                Console.WriteLine($"{events[i].Name} - {events[i].Participants.Count}");
                if (events[i].Participants.Count > 0)
                {
                    foreach (string person in events[i].Participants)
                    {
                        Console.WriteLine(person);
                    }
                }
            }
        }

        private static List<Event> GetFromInput()
        {
            List<Event> events = new List<Event>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input.Trim(" \t".ToCharArray()).ToLower().Equals("time for code"))
                {
                    break;
                }

                if (!input.Contains('#'))
                {
                    continue;
                }

                int hashTagIndex = input.IndexOf('#');
                int namesStartIndex = input.IndexOf(" @");

                string id = input
                    .Substring(0, hashTagIndex)
                    .Trim(" \t".ToCharArray());

                string eventName = (namesStartIndex > 0)
                    ? input.Substring(hashTagIndex + 1, namesStartIndex - hashTagIndex).Trim(" \t".ToCharArray())
                    : input.Substring(hashTagIndex + 1).Trim(" \t".ToCharArray());

                bool isIdAvalable = events.Any(x => x.ID.Equals(id));
                bool isNameAvalable = events.Any(x => x.Name.Equals(eventName));

                if (namesStartIndex > 0)
                {
                    List<string> participants = input
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Skip(2)
                        .Select(p => p.Trim(" \t".ToCharArray()))
                        .ToList();

                    if (!isIdAvalable && !isNameAvalable)
                    {
                        events.Add(new Event
                        {
                            ID = id,
                            Name = eventName,
                            Participants = participants
                        });
                    }
                    else if (isIdAvalable && isNameAvalable)
                    {
                        for (int i = 0; i < events.Count; i++)
                        {
                            if (events[i].Name.Equals(eventName) && events[i].ID.Equals(id))
                            {
                                events[i].Participants.AddRange(participants);
                            }
                        }
                    }
                }
                else
                {
                    events.Add(new Event { Name = eventName, ID = id, Participants = new List<string>() });
                }
            }

            return events;
        }
    }
}
