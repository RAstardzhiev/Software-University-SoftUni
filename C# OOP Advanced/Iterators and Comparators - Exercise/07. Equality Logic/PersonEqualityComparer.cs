namespace _07.Equality_Logic
{
    using System.Collections.Generic;

    public class PersonEqualityComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            return x.CompareTo(y) == 0;
        }

        public int GetHashCode(Person person)
        {
            return $"{person.Name} {person.Age}".GetHashCode();
        }
    }
}
