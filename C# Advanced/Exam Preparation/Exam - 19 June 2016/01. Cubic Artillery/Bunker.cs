using System.Collections.Generic;

namespace _01.Cubic_Artillery
{
    public class Bunker
    {
        public string Name { get; set; }

        public Queue<int> Weapons { get; set; }

        public int UsedSpace { get; set; }
    }
}
