namespace _11.Logs_Aggregator
{
    using System.Collections.Generic;

    public class UserStat
    {
        public SortedSet<string> IpHIstory { get; set; }

        public int Duration { get; set; }
    }
}
