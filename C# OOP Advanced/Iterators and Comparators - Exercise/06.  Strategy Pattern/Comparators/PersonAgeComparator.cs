namespace _06.Strategy_Pattern.Comparators
{
    using Models;
    using System.Collections.Generic;

    public class PersonAgeComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age - y.Age;
        }
    }
}
