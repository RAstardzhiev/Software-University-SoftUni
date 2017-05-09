namespace _14.Dragon_Army
{
    using System.Collections.Generic;

    public class DragonComparer : IComparer<Dragon>
    {
        // Dragons are sorted alphabetically by name
        public int Compare(Dragon first, Dragon second)
        {
            return first.Name.CompareTo(second.Name);
        }
    }
}
